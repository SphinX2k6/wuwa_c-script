using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.CombatMessage;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Typing;
using Google.Protobuf;

// Token: 0x020017BE RID: 6078
[NullableContext(1)]
[Nullable(0)]
public class CombatNet : Singleton
{
	// Token: 0x17000EB6 RID: 3766
	// (get) Token: 0x0600B168 RID: 45416 RVA: 0x0028243D File Offset: 0x0028063D
	// (set) Token: 0x0600B169 RID: 45417 RVA: 0x00282445 File Offset: 0x00280645
	public Dictionary<ENotifyMessageId, IHandler> NotifyMap { get; set; } = new Dictionary<ENotifyMessageId, IHandler>();

	// Token: 0x17000EB7 RID: 3767
	// (get) Token: 0x0600B16A RID: 45418 RVA: 0x0028244E File Offset: 0x0028064E
	// (set) Token: 0x0600B16B RID: 45419 RVA: 0x00282456 File Offset: 0x00280656
	public Dictionary<int, Action<IMessage>> RequestMap { get; set; } = new Dictionary<int, Action<IMessage>>();

	// Token: 0x17000EB8 RID: 3768
	// (get) Token: 0x0600B16C RID: 45420 RVA: 0x0028245F File Offset: 0x0028065F
	// (set) Token: 0x0600B16D RID: 45421 RVA: 0x00282467 File Offset: 0x00280667
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

	// Token: 0x17000EB9 RID: 3769
	// (get) Token: 0x0600B16E RID: 45422 RVA: 0x00282470 File Offset: 0x00280670
	// (set) Token: 0x0600B16F RID: 45423 RVA: 0x00282478 File Offset: 0x00280678
	private Stat CallStat { get; set; } = Stat.Create("CombatNet.Call", "", "");

	// Token: 0x17000EBA RID: 3770
	// (get) Token: 0x0600B170 RID: 45424 RVA: 0x00282481 File Offset: 0x00280681
	// (set) Token: 0x0600B171 RID: 45425 RVA: 0x00282489 File Offset: 0x00280689
	private Stat SendStat { get; set; } = Stat.Create("CombatNet.Send", "", "");

	// Token: 0x0600B172 RID: 45426 RVA: 0x00282494 File Offset: 0x00280694
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

	// Token: 0x0600B173 RID: 45427 RVA: 0x002825BC File Offset: 0x002807BC
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

	// Token: 0x0600B174 RID: 45428 RVA: 0x002826E0 File Offset: 0x002808E0
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

	// Token: 0x0600B175 RID: 45429 RVA: 0x00282771 File Offset: 0x00280971
	public void RemovePendingCall(long msgId)
	{
		this.PendingCallList.Remove(msgId);
	}

	// Token: 0x0600B176 RID: 45430 RVA: 0x00282780 File Offset: 0x00280980
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

	// Token: 0x0600B177 RID: 45431 RVA: 0x002827B8 File Offset: 0x002809B8
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

	// Token: 0x0600B178 RID: 45432 RVA: 0x00282957 File Offset: 0x00280B57
	[Conditional("DEBUG")]
	private void DataReport(ERequestMessageId id, [Nullable(2)] Entity entity, IMessage data)
	{
	}

	// Token: 0x0600B179 RID: 45433 RVA: 0x0028295C File Offset: 0x00280B5C
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

	// Token: 0x0600B17A RID: 45434 RVA: 0x00282A98 File Offset: 0x00280C98
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

	// Token: 0x17000EBB RID: 3771
	// (get) Token: 0x0600B17B RID: 45435 RVA: 0x00282B12 File Offset: 0x00280D12
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

	// Token: 0x0600B17C RID: 45436 RVA: 0x00282B35 File Offset: 0x00280D35
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B17D RID: 45437 RVA: 0x00282B37 File Offset: 0x00280D37
	public static void ResetStaticDefaultValue()
	{
		CombatNet instance = CombatNet._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CombatNet._instance = null;
	}

	// Token: 0x0600B17E RID: 45438 RVA: 0x00282B50 File Offset: 0x00280D50
	static CombatNet()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatNet.CreateStaticDefaultValue), new Action(CombatNet.ResetStaticDefaultValue));
	}

	// Token: 0x04005082 RID: 20610
	private readonly int IsWithEditor = (KuroApplication.IsWithEditor() > false) ? 1 : 0;

	// Token: 0x04005084 RID: 20612
	private int RequestId;

	// Token: 0x04005089 RID: 20617
	[Nullable(2)]
	private static CombatNet _instance;
}
