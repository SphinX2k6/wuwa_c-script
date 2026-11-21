using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelFlow.Section;

namespace CSharpScript.Game.LevelFlow
{
	// Token: 0x020060EB RID: 24811
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowModel : ModelBase
	{
		// Token: 0x0603B7CB RID: 243659 RVA: 0x010D6BCB File Offset: 0x010D4DCB
		public void InitTaskTreeInfo(long treeIncId, int treeNodeId)
		{
			this.TreeIncIdInternal = treeIncId;
			this.TreeNodeIdInternal = treeNodeId;
		}

		// Token: 0x0603B7CC RID: 243660 RVA: 0x010D6BDB File Offset: 0x010D4DDB
		public void InitTiTanLevelFlowInfo()
		{
			this.SectionData = new LevelFlowTiTanData();
			this.SectionData.Init();
		}

		// Token: 0x0603B7CD RID: 243661 RVA: 0x010D6BF4 File Offset: 0x010D4DF4
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

		// Token: 0x0603B7CE RID: 243662 RVA: 0x010D6C44 File Offset: 0x010D4E44
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

		// Token: 0x0603B7CF RID: 243663 RVA: 0x010D6CAC File Offset: 0x010D4EAC
		private void ExecuteSection(LevelFlowSection section)
		{
			section.BindCompleteCallBack(new Action<LevelFlowSection, bool>(this.OnSectionComplete));
			section.Enter();
		}

		// Token: 0x0603B7D0 RID: 243664 RVA: 0x010D6CC8 File Offset: 0x010D4EC8
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

		// Token: 0x0603B7D1 RID: 243665 RVA: 0x010D6D54 File Offset: 0x010D4F54
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

		// Token: 0x0603B7D2 RID: 243666 RVA: 0x010D6D74 File Offset: 0x010D4F74
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

		// Token: 0x0603B7D3 RID: 243667 RVA: 0x010D6DB0 File Offset: 0x010D4FB0
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

		// Token: 0x0603B7D4 RID: 243668 RVA: 0x010D6E6B File Offset: 0x010D506B
		private void End()
		{
			this.CurrentSection = null;
			LevelFlowResourceManager.Release();
		}

		// Token: 0x0603B7D5 RID: 243669 RVA: 0x010D6E7C File Offset: 0x010D507C
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

		// Token: 0x0603B7D6 RID: 243670 RVA: 0x010D6F12 File Offset: 0x010D5112
		private void OnDynamicActionComplete(LevelFlowActionBase action, bool isSuccess)
		{
			if (!isSuccess)
			{
				return;
			}
			this.DynamicActionSet.Remove(action);
		}

		// Token: 0x170070A9 RID: 28841
		// (get) Token: 0x0603B7D7 RID: 243671 RVA: 0x010D6F25 File Offset: 0x010D5125
		public long TreeIncId
		{
			get
			{
				return this.TreeIncIdInternal;
			}
		}

		// Token: 0x170070AA RID: 28842
		// (get) Token: 0x0603B7D8 RID: 243672 RVA: 0x010D6F2D File Offset: 0x010D512D
		public int TreeNodeId
		{
			get
			{
				return this.TreeNodeIdInternal;
			}
		}

		// Token: 0x170070AB RID: 28843
		// (get) Token: 0x0603B7D9 RID: 243673 RVA: 0x010D6F35 File Offset: 0x010D5135
		public bool IsEnd
		{
			get
			{
				return this.IsEndInternal;
			}
		}

		// Token: 0x170070AC RID: 28844
		// (get) Token: 0x0603B7DA RID: 243674 RVA: 0x010D6F3D File Offset: 0x010D513D
		public static LevelFlowModel Instance
		{
			get
			{
				return LevelFlowModel._Instance;
			}
		}

		// Token: 0x0603B7DB RID: 243675 RVA: 0x010D6F44 File Offset: 0x010D5144
		public static LevelFlowModel GetOrCreateInstance()
		{
			if (LevelFlowModel._Instance == null)
			{
				LevelFlowModel.CreateInstance();
			}
			return LevelFlowModel._Instance;
		}

		// Token: 0x0603B7DC RID: 243676 RVA: 0x010D6F58 File Offset: 0x010D5158
		public static bool CreateInstance()
		{
			if (LevelFlowModel._Instance != null)
			{
				return true;
			}
			LevelFlowModel._Instance = new LevelFlowModel();
			return true;
		}

		// Token: 0x0603B7DD RID: 243677 RVA: 0x010D6F6E File Offset: 0x010D516E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B7DE RID: 243678 RVA: 0x010D6F70 File Offset: 0x010D5170
		public static void ResetStaticDefaultValue()
		{
			LevelFlowModel._Instance = null;
		}

		// Token: 0x0603B7DF RID: 243679 RVA: 0x010D6F78 File Offset: 0x010D5178
		static LevelFlowModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowModel.CreateStaticDefaultValue), new Action(LevelFlowModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F5E3 RID: 128483
		public bool IsDebug;

		// Token: 0x0401F5E4 RID: 128484
		public bool IsIgnoreForceMove;

		// Token: 0x0401F5E5 RID: 128485
		private long TreeIncIdInternal;

		// Token: 0x0401F5E6 RID: 128486
		private int TreeNodeIdInternal;

		// Token: 0x0401F5E7 RID: 128487
		[Nullable(2)]
		private LevelFlowData SectionData;

		// Token: 0x0401F5E8 RID: 128488
		private int CurrentSectionIndex;

		// Token: 0x0401F5E9 RID: 128489
		[Nullable(2)]
		private LevelFlowSection CurrentSection;

		// Token: 0x0401F5EA RID: 128490
		private bool IsEndInternal;

		// Token: 0x0401F5EB RID: 128491
		private readonly HashSet<LevelFlowActionBase> DynamicActionSet = new HashSet<LevelFlowActionBase>();

		// Token: 0x0401F5EC RID: 128492
		[Nullable(2)]
		private Action<bool> RollbackCompleteCallBack;

		// Token: 0x0401F5ED RID: 128493
		[Nullable(2)]
		private static LevelFlowModel _Instance;
	}
}
