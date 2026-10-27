using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Utils.CombatStateMachine;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007321 RID: 29473
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTaskSkill : AiStateMachineTask
	{
		// Token: 0x06048587 RID: 296327 RVA: 0x0129BFBA File Offset: 0x0129A1BA
		public AiStateMachineTaskSkill(AiStateMachineBase StateMachineNode, CombatStateMachineDefine.Fsm.Task State) : base(StateMachineNode, State)
		{
		}

		// Token: 0x17009F8C RID: 40844
		// (get) Token: 0x06048588 RID: 296328 RVA: 0x0129BFE1 File Offset: 0x0129A1E1
		// (set) Token: 0x06048589 RID: 296329 RVA: 0x0129BFE9 File Offset: 0x0129A1E9
		public override bool IsAsyncTask { get; set; } = true;

		// Token: 0x0604858A RID: 296330 RVA: 0x0129BFF4 File Offset: 0x0129A1F4
		protected unsafe override bool OnInit(CombatStateMachineDefine.Fsm.Task state)
		{
			if (this.Node.SkillId != 0L)
			{
				this.Node.Owner.PushErrorMessage("状态节点配置错误，重复配置技能，节点[" + this.Node.Name + "]]");
				return false;
			}
			if (state.TaskSkillByName != null)
			{
				this.SkillName = state.TaskSkillByName.SkillName;
				this.ConfigReplaceTagId = state.TaskSkillByName.ConfigReplaceTagId;
				this.ConfigReplaceTagName = state.TaskSkillByName.ConfigReplaceTagName;
				this.SkillId = this.Node.Entity.GetComponent<CharacterSkillComponent>().GetSkillIdByName(this.SkillName).GetValueOrDefault();
				this.Node.SkillId = (long)this.SkillId;
			}
			else if (state.TaskSkill != null)
			{
				this.SkillId = state.TaskSkill.SkillId;
				this.ConfigReplaceTagId = state.TaskSkill.ConfigReplaceTagId;
				this.ConfigReplaceTagName = state.TaskSkill.ConfigReplaceTagName;
				this.Node.SkillId = (long)state.TaskSkill.SkillId;
			}
			else
			{
				this.Node.Owner.PushErrorMessage("状态节点配置错误，技能为空，节点[" + this.Node.Name + "]]");
			}
			if (!string.IsNullOrEmpty(this.ConfigReplaceTagName) && this.ConfigReplaceTagName != "None")
			{
				this.ReplaceConfig = this.Node.FindStateRepPerfConfig(this.ConfigReplaceTagName);
				IStateRepPerfBase replaceConfig = this.ReplaceConfig;
				if (replaceConfig != null && replaceConfig.Type == EStateRepPerfType.SkillId)
				{
					IStateRepPerfSkillId stateRepPerfSkillId = this.ReplaceConfig as IStateRepPerfSkillId;
					if (stateRepPerfSkillId == null || stateRepPerfSkillId.SkillId != 0L)
					{
						int skillId = this.SkillId;
						this.SkillId = (int)stateRepPerfSkillId.SkillId;
						this.Node.SkillId = stateRepPerfSkillId.SkillId;
						CombatLog instance = CombatLog.Instance;
						CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
						AiStateMachineBase node = this.Node;
						Entity entity = (node != null) ? node.Entity : null;
						string message = "SkillTask技能替换成功";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原SkillId", skillId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("新SkillId", stateRepPerfSkillId.SkillId);
						instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
				else if (this.ReplaceConfig != null)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
					AiStateMachineBase node2 = this.Node;
					Entity entity2 = (node2 != null) ? node2.Entity : null;
					string message2 = "SkillTask替换配置错误，替换配置不生效";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("节点", this.Node.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ConfigReplaceTagName", this.ConfigReplaceTagName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("配置覆盖Type", this.ReplaceConfig.Type);
					instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
			}
			return true;
		}

		// Token: 0x0604858B RID: 296331 RVA: 0x0129C2EC File Offset: 0x0129A4EC
		public override void OnEnter(long? contextId = null)
		{
			if (this.SkillId == 0)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
				Entity entity = this.Node.Entity;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("状态节点执行技能失败，技能查询失败，节点[");
				defaultInterpolatedStringHandler.AppendFormatted(this.Node.Name);
				defaultInterpolatedStringHandler.AppendLiteral("]，技能名[");
				defaultInterpolatedStringHandler.AppendFormatted(this.SkillName);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				instance.Error(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PreExecution = this.Node.RootNode.WaitSwitchState;
			this.Done = false;
			if (this.SkillId != 0 && (this.Node.ActorComponent.IsAutonomousProxy || this.PreExecution))
			{
				this.Node.SkillComponent.StopAllSkills("AiStateMachineTaskSkill.OnEnter");
				EntityHandle currentTarget = this.Node.AiController.AiHateList.GetCurrentTarget();
				this.Entered = true;
				this.Node.SkillComponent.BeginSkillAsync(this.SkillId, new SkillParam
				{
					Target = ((currentTarget != null) ? currentTarget.Entity : null),
					ContextId = contextId,
					Reason = "AiStateMachineTaskSkill.OnEnter"
				}).ContinueWith(delegate(bool result)
				{
					this.WaitingBeginSkill = false;
					this.Done = result;
					CombatNet.Instance.RemovePendingCall(contextId.GetValueOrDefault());
				});
				this.WaitingBeginSkill = true;
			}
		}

		// Token: 0x0604858C RID: 296332 RVA: 0x0129C460 File Offset: 0x0129A660
		protected override void OnTick(float deltaSeconds, long? contextId = null)
		{
			if (this.Entered && !this.WaitingBeginSkill && !this.Done && (this.Node.ActorComponent.IsAutonomousProxy || this.PreExecution))
			{
				if (this.Node.ElapseTime < (float)this.Timeout)
				{
					this.Node.SkillComponent.BeginSkillAsync(this.SkillId, new SkillParam
					{
						ContextId = contextId,
						Reason = "AiStateMachineTaskSkill.OnTick"
					}).ContinueWith(delegate(bool result)
					{
						this.Done = result;
					});
					return;
				}
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
				Entity entity = this.Node.Entity;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler.AppendLiteral("状态机技能释放失败 节点[");
				defaultInterpolatedStringHandler.AppendFormatted(this.Node.Name);
				defaultInterpolatedStringHandler.AppendLiteral("]，技能名[");
				defaultInterpolatedStringHandler.AppendFormatted(this.SkillName);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				instance.Info(flag, entity, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				UseSkillFailPush useSkillFailPush = UseSkillFailPush.Create();
				useSkillFailPush.SkillId = (long)this.SkillId;
				CombatNet.Instance.Send(EPushMessageId.UseSkillFailPush, this.Node.Entity, useSkillFailPush, contextId, null, null);
				this.Node.TaskFinished = true;
				this.Done = true;
			}
		}

		// Token: 0x0604858D RID: 296333 RVA: 0x0129C5C9 File Offset: 0x0129A7C9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026407 RID: 156679
		public string SkillName = "";

		// Token: 0x04026408 RID: 156680
		public int SkillId;

		// Token: 0x04026409 RID: 156681
		public int ConfigReplaceTagId;

		// Token: 0x0402640A RID: 156682
		public string ConfigReplaceTagName = "";

		// Token: 0x0402640B RID: 156683
		[Nullable(2)]
		private IStateRepPerfBase ReplaceConfig;

		// Token: 0x0402640C RID: 156684
		public int Timeout;

		// Token: 0x0402640D RID: 156685
		public bool Done;

		// Token: 0x0402640E RID: 156686
		public bool Entered;

		// Token: 0x0402640F RID: 156687
		private bool WaitingBeginSkill;

		// Token: 0x04026410 RID: 156688
		public bool PreExecution;
	}
}
