using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelFlow.Section;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x02006F6A RID: 28522
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowModel : ModelBase
	{
		// Token: 0x0604561D RID: 284189 RVA: 0x0112CDC7 File Offset: 0x0112AFC7
		public void InitTaskTreeInfo(long treeIncId, int treeNodeId)
		{
			this.TreeIncIdInternal = treeIncId;
			this.TreeNodeIdInternal = treeNodeId;
		}

		// Token: 0x0604561E RID: 284190 RVA: 0x0112CDD7 File Offset: 0x0112AFD7
		public void InitTiTanLevelFlowInfo()
		{
			this.SectionData = new LevelFlowTiTanData();
			this.SectionData.Init();
		}

		// Token: 0x0604561F RID: 284191 RVA: 0x0112CDF0 File Offset: 0x0112AFF0
		public void StartLevelFlow(int index)
		{
			if (this.SectionData.GetCapacity() <= 0)
			{
				return;
			}
			this.IsEndInternal = false;
			this.CurrentSectionIndex = index;
			LevelFlowSection section = this.SectionData.GetSection(this.CurrentSectionIndex);
			if (section == null)
			{
				return;
			}
			this.CurrentSection = section;
			this.ExecuteSection(section);
		}

		// Token: 0x06045620 RID: 284192 RVA: 0x0112CE40 File Offset: 0x0112B040
		public void OnTick(float delta)
		{
			if (this.CurrentSection == null)
			{
				return;
			}
			this.CurrentSection.Tick(delta);
			foreach (LevelFlowActionBase levelFlowActionBase in this.DynamicActionSet)
			{
				levelFlowActionBase.Tick(delta);
			}
		}

		// Token: 0x06045621 RID: 284193 RVA: 0x0112CEA8 File Offset: 0x0112B0A8
		private void ExecuteSection(LevelFlowSection section)
		{
			section.BindCompleteCallBack(new Action<LevelFlowSection, bool>(this.OnSectionComplete));
			section.Enter();
		}

		// Token: 0x06045622 RID: 284194 RVA: 0x0112CEC4 File Offset: 0x0112B0C4
		public void ResetLevelFlow(bool isEnd = false)
		{
			this.IsEndInternal = isEnd;
			if (this.CurrentSection != null)
			{
				this.CurrentSection.BindResetCompleteCallBack(new Action<LevelFlowSection, bool>(this.OnSectionResetComplete));
				this.CurrentSection.Reset();
			}
			foreach (LevelFlowActionBase levelFlowActionBase in this.DynamicActionSet)
			{
				levelFlowActionBase.Reset();
			}
			this.DynamicActionSet.Clear();
		}

		// Token: 0x06045623 RID: 284195 RVA: 0x0112CF50 File Offset: 0x0112B150
		public void RollBackLevelFlow(Action<bool> rollbackCompleteCallBack)
		{
			if (this.CurrentSection == null)
			{
				rollbackCompleteCallBack(true);
				return;
			}
			this.RollbackCompleteCallBack = rollbackCompleteCallBack;
			this.ResetLevelFlow(true);
		}

		// Token: 0x06045624 RID: 284196 RVA: 0x0112CF70 File Offset: 0x0112B170
		public void PushDynamicAction(LevelFlowActionBase action)
		{
			if (this.IsEnd)
			{
				return;
			}
			if (this.CurrentSection == null)
			{
				return;
			}
			this.DynamicActionSet.Add(action);
			action.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnDynamicActionComplete));
			action.Execute();
		}

		// Token: 0x06045625 RID: 284197 RVA: 0x0112CFAC File Offset: 0x0112B1AC
		private void OnSectionComplete(LevelFlowSection section, bool isSuccess)
		{
			if (!isSuccess)
			{
				if (this.IsDebug)
				{
					return;
				}
				this.ResetLevelFlow(false);
				return;
			}
			else
			{
				if (section.SectionId != this.CurrentSection.SectionId)
				{
					Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "section回调异常", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.CurrentSection.Exit();
				this.CurrentSectionIndex++;
				if (this.CurrentSectionIndex >= this.SectionData.GetCapacity())
				{
					this.End();
					EventSystem.Instance.Emit(EEventName.OnLevelFlowFinished);
					return;
				}
				LevelFlowSection section2 = this.SectionData.GetSection(this.CurrentSectionIndex);
				if (section2 == null)
				{
					return;
				}
				this.CurrentSection = section2;
				this.ExecuteSection(section2);
				return;
			}
		}

		// Token: 0x06045626 RID: 284198 RVA: 0x0112D067 File Offset: 0x0112B267
		private void End()
		{
			this.CurrentSection = null;
			LevelFlowResourceManager.Release();
		}

		// Token: 0x06045627 RID: 284199 RVA: 0x0112D078 File Offset: 0x0112B278
		private void OnSectionResetComplete(LevelFlowSection section, bool isSuccess)
		{
			if (this.IsEndInternal)
			{
				this.End();
				Action<bool> rollbackCompleteCallBack = this.RollbackCompleteCallBack;
				if (rollbackCompleteCallBack != null)
				{
					rollbackCompleteCallBack(isSuccess);
				}
				this.RollbackCompleteCallBack = null;
				return;
			}
			if (!isSuccess)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "回退都失败了，怎么能成功呢", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (section.SectionId != this.CurrentSection.SectionId)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "section回调异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CurrentSection.Enter();
		}

		// Token: 0x06045628 RID: 284200 RVA: 0x0112D10E File Offset: 0x0112B30E
		private void OnDynamicActionComplete(LevelFlowActionBase action, bool isSuccess)
		{
			if (!isSuccess)
			{
				return;
			}
			this.DynamicActionSet.Remove(action);
		}

		// Token: 0x17009B6A RID: 39786
		// (get) Token: 0x06045629 RID: 284201 RVA: 0x0112D121 File Offset: 0x0112B321
		public long TreeIncId
		{
			get
			{
				return this.TreeIncIdInternal;
			}
		}

		// Token: 0x17009B6B RID: 39787
		// (get) Token: 0x0604562A RID: 284202 RVA: 0x0112D129 File Offset: 0x0112B329
		public int TreeNodeId
		{
			get
			{
				return this.TreeNodeIdInternal;
			}
		}

		// Token: 0x17009B6C RID: 39788
		// (get) Token: 0x0604562B RID: 284203 RVA: 0x0112D131 File Offset: 0x0112B331
		public bool IsEnd
		{
			get
			{
				return this.IsEndInternal;
			}
		}

		// Token: 0x17009B6D RID: 39789
		// (get) Token: 0x0604562C RID: 284204 RVA: 0x0112D139 File Offset: 0x0112B339
		public static LevelFlowModel Instance
		{
			get
			{
				return LevelFlowModel._Instance;
			}
		}

		// Token: 0x0604562D RID: 284205 RVA: 0x0112D140 File Offset: 0x0112B340
		public static LevelFlowModel GetOrCreateInstance()
		{
			if (LevelFlowModel._Instance == null)
			{
				LevelFlowModel.CreateInstance();
			}
			return LevelFlowModel._Instance;
		}

		// Token: 0x0604562E RID: 284206 RVA: 0x0112D154 File Offset: 0x0112B354
		public static bool CreateInstance()
		{
			if (LevelFlowModel._Instance != null)
			{
				return true;
			}
			LevelFlowModel._Instance = new LevelFlowModel();
			return true;
		}

		// Token: 0x0604562F RID: 284207 RVA: 0x0112D16A File Offset: 0x0112B36A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045630 RID: 284208 RVA: 0x0112D16C File Offset: 0x0112B36C
		public static void ResetStaticDefaultValue()
		{
			LevelFlowModel._Instance = null;
		}

		// Token: 0x06045631 RID: 284209 RVA: 0x0112D174 File Offset: 0x0112B374
		static LevelFlowModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowModel.CreateStaticDefaultValue), new Action(LevelFlowModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402432E RID: 148270
		public bool IsDebug;

		// Token: 0x0402432F RID: 148271
		public bool IsIgnoreForceMove;

		// Token: 0x04024330 RID: 148272
		private long TreeIncIdInternal;

		// Token: 0x04024331 RID: 148273
		private int TreeNodeIdInternal;

		// Token: 0x04024332 RID: 148274
		[Nullable(2)]
		private LevelFlowData SectionData;

		// Token: 0x04024333 RID: 148275
		private int CurrentSectionIndex;

		// Token: 0x04024334 RID: 148276
		[Nullable(2)]
		private LevelFlowSection CurrentSection;

		// Token: 0x04024335 RID: 148277
		private bool IsEndInternal;

		// Token: 0x04024336 RID: 148278
		private readonly HashSet<LevelFlowActionBase> DynamicActionSet = new HashSet<LevelFlowActionBase>();

		// Token: 0x04024337 RID: 148279
		[Nullable(2)]
		private Action<bool> RollbackCompleteCallBack;

		// Token: 0x04024338 RID: 148280
		[Nullable(2)]
		private static LevelFlowModel _Instance;
	}
}
