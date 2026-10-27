using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x0200732A RID: 29482
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineStateCue : AiStateMachineState
	{
		// Token: 0x060485BF RID: 296383 RVA: 0x0129CBEC File Offset: 0x0129ADEC
		[NullableContext(1)]
		public AiStateMachineStateCue(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485C0 RID: 296384 RVA: 0x0129CC04 File Offset: 0x0129AE04
		[NullableContext(1)]
		protected unsafe override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.HideOnLoading = state.BindCue.HideOnLoading;
			this.CueIds = state.BindCue.CueIds;
			this.ConfigReplaceTagId = state.BindCue.ConfigReplaceTagId;
			this.ConfigReplaceTagName = state.BindCue.ConfigReplaceTagName;
			if (!string.IsNullOrEmpty(this.ConfigReplaceTagName) && this.ConfigReplaceTagName != "None")
			{
				this.ReplaceConfig = this.Node.FindStateRepPerfConfig(this.ConfigReplaceTagName);
				IStateRepPerfBase replaceConfig = this.ReplaceConfig;
				if (replaceConfig != null && replaceConfig.Type == EStateRepPerfType.Effects)
				{
					IStateRepPerfEffects stateRepPerfEffects = this.ReplaceConfig as IStateRepPerfEffects;
					if (((stateRepPerfEffects != null) ? stateRepPerfEffects.GamePlayCues : null) != null)
					{
						List<long> cueIds = this.CueIds;
						this.CueIds = new List<long>();
						foreach (int num in stateRepPerfEffects.GamePlayCues)
						{
							this.CueIds.Add((long)num);
						}
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
						AiStateMachineBase node = this.Node;
						Entity entity = (node != null) ? node.Entity : null;
						string message = "StateCue特效替换成功";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原CueIds", cueIds);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("新CueIds", this.CueIds);
						instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
				else if (this.ReplaceConfig != null)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
					AiStateMachineBase node2 = this.Node;
					Entity entity2 = (node2 != null) ? node2.Entity : null;
					string message2 = "StateCue替换配置错误，替换配置不生效";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("节点", this.Node.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ConfigReplaceTagName", this.ConfigReplaceTagName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("配置覆盖Type", this.ReplaceConfig.Type);
					instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
			return true;
		}

		// Token: 0x060485C1 RID: 296385 RVA: 0x0129CE3C File Offset: 0x0129B03C
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			this.CueList = new List<int>();
			this.LoadFinishCount = 0;
			this.Loading = true;
			if (this.HideOnLoading && this.DisableHandle == null)
			{
				this.DisableHandle = new int?(this.Node.ActorComponent.DisableActor("状态机加载特效或材质"));
			}
			using (List<long>.Enumerator enumerator = this.CueIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					long cueConfigId = enumerator.Current;
					int num = this.Node.GameplayCueComponent.AddCue(cueConfigId, new GameplayCueParam?(new GameplayCueParam
					{
						BeginCallback = delegate()
						{
							this.OnLoadCompleted(cueConfigId);
						}
					}));
					if (num != 0)
					{
						this.CueList.Add(num);
					}
				}
			}
		}

		// Token: 0x060485C2 RID: 296386 RVA: 0x0129CF30 File Offset: 0x0129B130
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			if (this.HideOnLoading && this.Loading)
			{
				this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
				this.DisableHandle = null;
			}
			foreach (int num in this.CueList)
			{
				this.Node.GameplayCueComponent.RemoveCueByHandle((long)num);
			}
			this.CueList = new List<int>();
		}

		// Token: 0x060485C3 RID: 296387 RVA: 0x0129CFD4 File Offset: 0x0129B1D4
		private void OnLoadCompleted(long cueConfigId)
		{
			if (!this.Node.Activated)
			{
				return;
			}
			this.LoadFinishCount++;
			if (this.HideOnLoading && this.LoadFinishCount >= this.CueIds.Count)
			{
				this.Node.ActorComponent.EnableActor(this.DisableHandle.Value);
				this.DisableHandle = null;
				this.Loading = false;
			}
		}

		// Token: 0x060485C4 RID: 296388 RVA: 0x0129D048 File Offset: 0x0129B248
		protected override void OnClear()
		{
			if (this.CueList != null && this.CueList.Count > 0)
			{
				foreach (int num in this.CueList)
				{
					this.Node.GameplayCueComponent.RemoveCueByHandle((long)num);
				}
				this.CueList = new List<int>();
			}
		}

		// Token: 0x060485C5 RID: 296389 RVA: 0x0129D0C8 File Offset: 0x0129B2C8
		[NullableContext(1)]
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026425 RID: 156709
		private List<long> CueIds;

		// Token: 0x04026426 RID: 156710
		private bool HideOnLoading;

		// Token: 0x04026427 RID: 156711
		public int ConfigReplaceTagId;

		// Token: 0x04026428 RID: 156712
		[Nullable(1)]
		public string ConfigReplaceTagName = "";

		// Token: 0x04026429 RID: 156713
		private IStateRepPerfBase ReplaceConfig;

		// Token: 0x0402642A RID: 156714
		private List<int> CueList;

		// Token: 0x0402642B RID: 156715
		private int LoadFinishCount;

		// Token: 0x0402642C RID: 156716
		private bool Loading;

		// Token: 0x0402642D RID: 156717
		private int? DisableHandle;
	}
}
