using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.CombatMessage;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Typing;
using Google.Protobuf;

// Token: 0x02000C77 RID: 3191
[NullableContext(1)]
[Nullable(0)]
public class CombatNet : Singleton
{
	// Token: 0x17000ED9 RID: 3801
	// (get) Token: 0x06008550 RID: 34128 RVA: 0x0028C9D5 File Offset: 0x0028ABD5
	// (set) Token: 0x06008551 RID: 34129 RVA: 0x0028C9DD File Offset: 0x0028ABDD
	public Dictionary<ENotifyMessageId, IHandler> NotifyMap { get; set; } = new Dictionary<ENotifyMessageId, IHandler>();

	// Token: 0x17000EDA RID: 3802
	// (get) Token: 0x06008552 RID: 34130 RVA: 0x0028C9E6 File Offset: 0x0028ABE6
	// (set) Token: 0x06008553 RID: 34131 RVA: 0x0028C9EE File Offset: 0x0028ABEE
	public Dictionary<int, Action<IMessage>> RequestMap { get; set; } = new Dictionary<int, Action<IMessage>>();

	// Token: 0x17000EDB RID: 3803
	// (get) Token: 0x06008554 RID: 34132 RVA: 0x0028C9F7 File Offset: 0x0028ABF7
	// (set) Token: 0x06008555 RID: 34133 RVA: 0x0028C9FF File Offset: 0x0028ABFF
	[Nullable(new byte[]
	{
		1,
		1,
		2,
		1,
		1
	})]
	private Dictionary<long, Tuple<int, Action<IMessage>, CombatSendData>> PendingCallList { [return: Nullable(new byte[]
	{
		1,
		1,
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		1,
		1,
		2,
		1,
		1
	})] set; } = new Dictionary<long, Tuple<int, Action<IMessage>, CombatSendData>>();

	// Token: 0x17000EDC RID: 3804
	// (get) Token: 0x06008556 RID: 34134 RVA: 0x0028CA08 File Offset: 0x0028AC08
	// (set) Token: 0x06008557 RID: 34135 RVA: 0x0028CA10 File Offset: 0x0028AC10
	private Stat CallStat { get; set; } = Stat.Create("CombatNet.Call", "", "");

	// Token: 0x17000EDD RID: 3805
	// (get) Token: 0x06008558 RID: 34136 RVA: 0x0028CA19 File Offset: 0x0028AC19
	// (set) Token: 0x06008559 RID: 34137 RVA: 0x0028CA21 File Offset: 0x0028AC21
	private Stat SendStat { get; set; } = Stat.Create("CombatNet.Send", "", "");

	// Token: 0x0600855A RID: 34138 RVA: 0x0028CA2C File Offset: 0x0028AC2C
	[NullableContext(0)]
	[CombatListenImplement]
	public unsafe static void Listen<T>([Nullable(new byte[]
	{
		1,
		2,
		1,
		2
	})] Action<Entity, T, CombatCommon> callBack, ENotifyMessageId notifyId, bool needSync, bool needCache = false) where T : IMessage
	{
		CombatNet.<>c__DisplayClass22_0<T> CS$<>8__locals1 = new CombatNet.<>c__DisplayClass22_0<T>();
		CS$<>8__locals1.callBack = callBack;
		IHandler handler;
		if (!CombatNet.Instance.NotifyMap.TryGetValue(notifyId, out handler))
		{
			handler = new StaticHandler
			{
				IsSync = new bool?(needSync),
				IsCache = new bool?(needCache),
				Listener = null,
				Preprocessor = null
			};
			CombatNet.Instance.NotifyMap[notifyId] = handler;
		}
		StaticHandler staticHandler = handler as StaticHandler;
		if (handler.Type == EHandlerType.Component || (staticHandler != null && staticHandler.Listener != null))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiplayerCombat;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "重复注册函数监听或类型不匹配";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MessageKey", notifyId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MessageId", notifyId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FunctionName", CS$<>8__locals1.callBack);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		staticHandler.IsSync = new bool?(needSync);
		staticHandler.Listener = new Action<Entity, IMessage, CombatCommon>(CS$<>8__locals1.<Listen>g__WrappedCallBack|0);
	}

	// Token: 0x0600855B RID: 34139 RVA: 0x0028CB54 File Offset: 0x0028AD54
	[NullableContext(0)]
	[CombatPreprocessImplement]
	public unsafe static void Preprocess<T>([Nullable(new byte[]
	{
		1,
		2,
		1,
		2
	})] Func<Entity, T, CombatCommon, bool> callBack, ENotifyMessageId notifyId) where T : IMessage
	{
		CombatNet.<>c__DisplayClass23_0<T> CS$<>8__locals1 = new CombatNet.<>c__DisplayClass23_0<T>();
		CS$<>8__locals1.callBack = callBack;
		IHandler handler;
		if (!CombatNet.Instance.NotifyMap.TryGetValue(notifyId, out handler))
		{
			handler = new StaticHandler
			{
				IsSync = null,
				IsCache = null,
				Listener = null,
				Preprocessor = null
			};
			CombatNet.Instance.NotifyMap[notifyId] = handler;
		}
		StaticHandler staticHandler = handler as StaticHandler;
		if (handler.Type == EHandlerType.Component || (staticHandler != null && staticHandler.Preprocessor != null))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiplayerCombat;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "不能为组件listener注册预处理函数或类型不匹配";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MessageKey", notifyId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MessageId", notifyId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FunctionName", CS$<>8__locals1.callBack);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		staticHandler.Preprocessor = new Func<Entity, IMessage, CombatCommon, bool>(CS$<>8__locals1.<Preprocess>g__WrappedCallBack|0);
	}

	// Token: 0x0600855C RID: 34140 RVA: 0x0028CC78 File Offset: 0x0028AE78
	protected unsafe bool CheckHandle(object target, ECombatNotifyDataMessage notifyKey, int notifyId, string property)
	{
		if (!(target is Type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MultiplayerCombat;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "CombatMessage notify callback should be static function";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MessageKey", notifyKey);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MessageId", notifyId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FunctionName", property);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		return true;
	}

	// Token: 0x0600855D RID: 34141 RVA: 0x0028CD09 File Offset: 0x0028AF09
	public void RemovePendingCall(long msgId)
	{
		this.PendingCallList.Remove(msgId);
	}

	// Token: 0x0600855E RID: 34142 RVA: 0x0028CD18 File Offset: 0x0028AF18
	public int GenerateRpcId()
	{
		if (this.RequestId < 32767)
		{
			int num = this.RequestId + 1;
			this.RequestId = num;
			return num;
		}
		return this.RequestId = 0;
	}

	// Token: 0x0600855F RID: 34143 RVA: 0x0028CD50 File Offset: 0x0028AF50
	public long Call(ERequestMessageId id, [Nullable(2)] Entity entity, IMessage data, [Nullable(new byte[]
	{
		2,
		1
	})] Action<IMessage> handle = null, long? preMessageId = null, long? messageId = null, bool? isServerRequest = null, bool? isPending = null)
	{
		CombatNet.<>c__DisplayClass27_0 CS$<>8__locals1 = new CombatNet.<>c__DisplayClass27_0();
		CS$<>8__locals1.handle = handle;
		if (preMessageId != null && this.PendingCallList.ContainsKey(preMessageId.Value))
		{
			Tuple<int, Action<IMessage>, CombatSendData> tuple = this.PendingCallList[preMessageId.Value];
			int item = tuple.Item1;
			Action<IMessage> item2 = tuple.Item2;
			CombatSendData item3 = tuple.Item3;
			if (item2 != null)
			{
				this.RequestMap[item] = item2;
			}
			CombatMessageModel.Instance.MessagePack.Data.Add(item3);
			this.PendingCallList.Remove(preMessageId.Value);
		}
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		long valueOrDefault = num2.GetValueOrDefault();
		int num3 = this.GenerateRpcId();
		long num4 = messageId ?? CombatMessageModel.Instance.GenMessageId();
		CombatRequestData combatRequestData = new CombatRequestData();
		combatRequestData.RequestId = num3;
		combatRequestData.CombatCommon = this.CreateCombatCommon(valueOrDefault, isServerRequest, preMessageId, new long?(num4));
		CombatMessageExtension.SetRequestDataMessage(combatRequestData, (ECombatRequestDataMessage)id, data);
		CombatSendData combatSendData = new CombatSendData();
		combatSendData.Request = combatRequestData;
		if (isPending.GetValueOrDefault())
		{
			this.PendingCallList[num4] = new Tuple<int, Action<IMessage>, CombatSendData>(num3, new Action<IMessage>(CS$<>8__locals1.<Call>g__WrapHandle|0), combatSendData);
		}
		else
		{
			this.RequestMap[num3] = new Action<IMessage>(CS$<>8__locals1.<Call>g__WrapHandle|0);
			CombatMessageModel.Instance.MessagePack.Data.Add(combatSendData);
		}
		return num4;
	}

	// Token: 0x06008560 RID: 34144 RVA: 0x0028CEEF File Offset: 0x0028B0EF
	[Conditional("DEBUG")]
	private void DataReport(ERequestMessageId id, [Nullable(2)] Entity entity, IMessage data)
	{
	}

	// Token: 0x06008561 RID: 34145 RVA: 0x0028CEF4 File Offset: 0x0028B0F4
	public long Send(EPushMessageId id, Entity entity, IMessage message, long? preMessageId = null, long? messageId = null, bool? isServerRequest = null)
	{
		if (preMessageId != null && this.PendingCallList.ContainsKey(preMessageId.Value))
		{
			Tuple<int, Action<IMessage>, CombatSendData> tuple = this.PendingCallList[preMessageId.Value];
			int item = tuple.Item1;
			Action<IMessage> item2 = tuple.Item2;
			CombatSendData item3 = tuple.Item3;
			if (item2 != null)
			{
				this.RequestMap[item] = item2;
			}
			CombatMessageModel.Instance.MessagePack.Data.Add(item3);
			this.PendingCallList.Remove(preMessageId.Value);
		}
		CombatPushData combatPushData = new CombatPushData();
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		long valueOrDefault = num2.GetValueOrDefault();
		long value = messageId.GetValueOrDefault();
		if (messageId == null)
		{
			value = CombatMessageModel.Instance.GenMessageId();
			messageId = new long?(value);
		}
		combatPushData.CombatCommon = this.CreateCombatCommon(valueOrDefault, isServerRequest, preMessageId, messageId);
		CombatMessageExtension.SetPushDataMessage(combatPushData, (ECombatPushDataMessage)id, message);
		CombatSendData combatSendData = new CombatSendData();
		combatSendData.Push = combatPushData;
		CombatMessageModel.Instance.MessagePack.Data.Add(combatSendData);
		return messageId.Value;
	}

	// Token: 0x06008562 RID: 34146 RVA: 0x0028D030 File Offset: 0x0028B230
	public CombatCommon CreateCombatCommon(long creatureDataId, bool? isServerRequest = null, long? preMessageId = null, long? messageId = null)
	{
		return new CombatCommon
		{
			EntityId = creatureDataId,
			PreMessageId = preMessageId.GetValueOrDefault(),
			MessageId = (messageId ?? CombatMessageModel.Instance.GenMessageId()),
			Originator = (long)CreatureModel.Instance.GetPlayerId(),
			TimeStamp = (float)Time.Instance.NowSeconds,
			IsServerRequest = isServerRequest.GetValueOrDefault()
		};
	}

	// Token: 0x17000EDE RID: 3806
	// (get) Token: 0x06008563 RID: 34147 RVA: 0x0028D0AA File Offset: 0x0028B2AA
	public static CombatNet Instance
	{
		get
		{
			if (CombatNet._instance == null)
			{
				CombatNet._instance = new CombatNet();
				CombatNet._instance.OnInit();
			}
			return CombatNet._instance;
		}
	}

	// Token: 0x06008564 RID: 34148 RVA: 0x0028D0CD File Offset: 0x0028B2CD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008565 RID: 34149 RVA: 0x0028D0CF File Offset: 0x0028B2CF
	public static void ResetStaticDefaultValue()
	{
		CombatNet instance = CombatNet._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CombatNet._instance = null;
	}

	// Token: 0x06008566 RID: 34150 RVA: 0x0028D0E8 File Offset: 0x0028B2E8
	static CombatNet()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatNet.CreateStaticDefaultValue), new Action(CombatNet.ResetStaticDefaultValue));
	}

	// Token: 0x0400512C RID: 20780
	private readonly int IsWithEditor = (KuroApplication.IsWithEditor() > false) ? 1 : 0;

	// Token: 0x0400512E RID: 20782
	private int RequestId;

	// Token: 0x04005133 RID: 20787
	[Nullable(2)]
	private static CombatNet _instance;
}
