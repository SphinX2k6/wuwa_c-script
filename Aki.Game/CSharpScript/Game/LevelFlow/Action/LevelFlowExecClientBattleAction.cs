using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelEvents;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006107 RID: 24839
	public class LevelFlowExecClientBattleAction : LevelFlowActionBase
	{
		// Token: 0x0603B89D RID: 243869 RVA: 0x010E18FA File Offset: 0x010DFAFA
		[NullableContext(1)]
		public LevelFlowExecClientBattleAction Init(ExecClientBattleAction param)
		{
			this.Param = param;
			return this;
		}

		// Token: 0x0603B89E RID: 243870 RVA: 0x010E1904 File Offset: 0x010DFB04
		protected override void OnExecute()
		{
			if (this.Param == null)
			{
				base.FinishExecute(false);
				return;
			}
			switch (this.Param.ClientBattleOption.Type)
			{
			case EExecClientBattleActionType.SendTagEventToControlCharacter:
				LevelEventExecClientBattleAction.HandleSendTagEvent(this.Param.ClientBattleOption as IClientSendTagEventToControlCharacter, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
				});
				return;
			case EExecClientBattleActionType.TriggerHookPointSkill:
				LevelEventExecClientBattleAction.HandleHookPointSkill(this.Param.ClientBattleOption as ITriggerHookPointSkill, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[LevelFlowExecClientBattleAction] HandleHookPointSkill执行失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionId", this.ActionId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				});
				return;
			case EExecClientBattleActionType.TriggerMotorSkill:
				LevelEventExecClientBattleAction.HandleMotorSkill(this.Param.ClientBattleOption as ITriggerMotorSkill, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[LevelFlowExecClientBattleAction] HandleHookPointSkill执行失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionId", this.ActionId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}, null);
				return;
			case EExecClientBattleActionType.FollowShooterSkill:
				LevelEventExecClientBattleAction.HandleFollowShooterSkill(this.Param.ClientBattleOption as IFollowShooterSkillSkill, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
				});
				return;
			case EExecClientBattleActionType.GroupAiCommunicate:
				LevelEventExecClientBattleAction.HandleGroupAiCommunicate(this.Param.ClientBattleOption as IClientGroupAiCommunicate, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
				});
				return;
			case EExecClientBattleActionType.ChangeAnimalEmotionBubble:
				LevelEventExecClientBattleAction.HandleChangeAnimalEmotionBubble(this.Param.ClientBattleOption as IChangeAnimalEmotionBubble, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
				});
				return;
			case EExecClientBattleActionType.MonsterNpcInteract:
				LevelEventExecClientBattleAction.HandleMonsterNpcInteract(this.Param.ClientBattleOption as IMonsterNpcInteract, delegate
				{
					base.FinishExecute(true);
				}, delegate
				{
					base.FinishExecute(false);
				});
				return;
			default:
				return;
			}
		}

		// Token: 0x0603B89F RID: 243871 RVA: 0x010E1A98 File Offset: 0x010DFC98
		protected unsafe override void LogExecuteInfo()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Param", this.Param);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0401F66D RID: 128621
		[Nullable(2)]
		private ExecClientBattleAction Param;
	}
}
