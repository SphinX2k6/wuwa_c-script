using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CombatMessage;
using Google.Protobuf;

// Token: 0x02003054 RID: 12372
[NullableContext(1)]
[Nullable(0)]
public class CharacterCombatMessageComponent : EntityComponent
{
	// Token: 0x0601A4DD RID: 107741 RVA: 0x006F75A0 File Offset: 0x006F57A0
	public unsafe void AddToQueue(ENotifyMessageId id, CombatCommon combatCommon, IMessage message, double executeTime)
	{
		this.MessageQueue.Push(new TCombatMessage(combatCommon, id, message, executeTime));
		if (this.MessageQueue.Size >= 50)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
			Entity entity = base.Entity;
			string message2 = "战斗消息缓冲满了";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsInit", base.Entity.IsInit);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Active", base.Entity.Active);
			instance.Warn(flag, entity, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			TCombatMessage combatMessage = this.MessageQueue.Pop();
			this.ProcessCombatMessage(combatMessage);
		}
	}

	// Token: 0x0601A4DE RID: 107742 RVA: 0x006F765C File Offset: 0x006F585C
	protected unsafe override void OnActivate()
	{
		while (this.MessageQueue.Size > 0)
		{
			TCombatMessage tcombatMessage = this.MessageQueue.Pop();
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Notify;
			Entity entity = base.Entity;
			string message = "协议OnActivate执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Message", tcombatMessage.MessageId.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CombatCommon", tcombatMessage.CombatCommon);
			instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ProcessCombatMessage(tcombatMessage);
		}
		CombatMessageController.Instance.RegisterPreTick(this, new Action<float>(this.PreTickInternal));
	}

	// Token: 0x0601A4DF RID: 107743 RVA: 0x006F7718 File Offset: 0x006F5918
	protected unsafe override bool OnEnd()
	{
		while (this.MessageQueue.Size > 0)
		{
			TCombatMessage tcombatMessage = this.MessageQueue.Pop();
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Notify;
			Entity entity = base.Entity;
			string message = "OnEnd未执行的协议，已抛弃";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Message", tcombatMessage.MessageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CombatCommon", tcombatMessage.CombatCommon);
			instance.Info(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		CombatMessageController.Instance.UnregisterPreTick(this);
		return true;
	}

	// Token: 0x0601A4E0 RID: 107744 RVA: 0x006F77B4 File Offset: 0x006F59B4
	private void PreTickInternal(float _)
	{
		while (this.MessageQueue.Size > 0)
		{
			TCombatMessage front = this.MessageQueue.Front;
			if (front == null)
			{
				break;
			}
			if (Time.Instance.NowSeconds < front.ExecuteTime)
			{
				if (this.MessageQueue.Size < 50)
				{
					break;
				}
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = base.Entity;
				string message = "战斗缓冲满，立即执行";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", front.MessageId);
				instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.MessageQueue.Pop();
			this.ProcessCombatMessage(front);
		}
	}

	// Token: 0x0601A4E1 RID: 107745 RVA: 0x006F784C File Offset: 0x006F5A4C
	private unsafe void ProcessCombatMessage(TCombatMessage combatMessage)
	{
		try
		{
			CombatMessageController.Instance.Process(combatMessage.MessageId, base.Entity, combatMessage.Message, combatMessage.CombatCommon);
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CombatInfo;
			ELogAuthor author = ELogAuthor.WCL;
			string message = "战斗协议执行回调方法异常";
			Exception error = ex;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("messageId", combatMessage.MessageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0601A4E2 RID: 107746 RVA: 0x006F78F8 File Offset: 0x006F5AF8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCombatMessageComponent characterCombatMessageComponent = (CharacterCombatMessageComponent)componentTemplate;
		return !base.CanResetComponentProperty("MessageQueue") || characterCombatMessageComponent.MessageQueue == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Queue<TCombatMessage>>(this.MessageQueue), "MessageQueue");
	}

	// Token: 0x0400C89E RID: 51358
	private const int MESSAGE_BUFFER_MAX_SIZE = 50;

	// Token: 0x0400C89F RID: 51359
	private readonly Queue<TCombatMessage> MessageQueue = new Queue<TCombatMessage>(50);
}
