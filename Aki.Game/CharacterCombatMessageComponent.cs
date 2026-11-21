using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CombatMessage;
using Google.Protobuf;

// Token: 0x020025AA RID: 9642
[NullableContext(1)]
[Nullable(0)]
public class CharacterCombatMessageComponent : EntityComponent
{
	// Token: 0x06017E75 RID: 97909 RVA: 0x0071E620 File Offset: 0x0071C820
	public void FlushPendingMessagesBeforeMorph()
	{
		Entity entity = base.Entity;
		if (entity == null || !entity.IsInit || !entity.Active || entity.IsEnd || this.IsFlushingMessages)
		{
			return;
		}
		int size = this.MessageQueue.Size;
		if (size == 0)
		{
			return;
		}
		this.IsFlushingMessages = true;
		try
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
			Entity entity2 = entity;
			string message = "变身前按序执行缓冲消息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Count", size);
			instance.Info(flag, entity2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			int num = 0;
			while (num < size && this.MessageQueue.Size > 0 && !entity.IsEnd)
			{
				if (!entity.Active)
				{
					break;
				}
				TCombatMessage combatMessage = this.MessageQueue.Pop();
				this.ProcessCombatMessage(combatMessage);
				num++;
			}
		}
		finally
		{
			this.IsFlushingMessages = false;
		}
	}

	// Token: 0x06017E76 RID: 97910 RVA: 0x0071E6F4 File Offset: 0x0071C8F4
	public unsafe void AddToQueue(ENotifyMessageId id, CombatCommon combatCommon, IMessage message, double executeTime)
	{
		this.MessageQueue.Push(new TCombatMessage(combatCommon, id, message, executeTime));
		if (this.MessageQueue.Size >= 50 && !this.IsFlushingMessages)
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

	// Token: 0x06017E77 RID: 97911 RVA: 0x0071E7BC File Offset: 0x0071C9BC
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

	// Token: 0x06017E78 RID: 97912 RVA: 0x0071E878 File Offset: 0x0071CA78
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

	// Token: 0x06017E79 RID: 97913 RVA: 0x0071E914 File Offset: 0x0071CB14
	private void PreTickInternal(float _)
	{
		if (this.IsFlushingMessages)
		{
			return;
		}
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

	// Token: 0x06017E7A RID: 97914 RVA: 0x0071E9B4 File Offset: 0x0071CBB4
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

	// Token: 0x06017E7B RID: 97915 RVA: 0x0071EA60 File Offset: 0x0071CC60
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCombatMessageComponent characterCombatMessageComponent = (CharacterCombatMessageComponent)componentTemplate;
		if (characterCombatMessageComponent.MessageQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MessageQueue), "MessageQueue"))
		{
			return false;
		}
		this.IsFlushingMessages = characterCombatMessageComponent.IsFlushingMessages;
		return true;
	}

	// Token: 0x1700254C RID: 9548
	// (get) Token: 0x06017E7C RID: 97916 RVA: 0x0071EAAE File Offset: 0x0071CCAE
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700254D RID: 9549
	// (get) Token: 0x06017E7D RID: 97917 RVA: 0x0071EAB1 File Offset: 0x0071CCB1
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CC77 RID: 52343
	private const int MESSAGE_BUFFER_MAX_SIZE = 50;

	// Token: 0x0400CC78 RID: 52344
	private readonly Queue<TCombatMessage> MessageQueue = new Queue<TCombatMessage>(50);

	// Token: 0x0400CC79 RID: 52345
	private bool IsFlushingMessages;
}
