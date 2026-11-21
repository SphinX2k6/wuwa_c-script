using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extensions;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001560 RID: 5472
[NullableContext(1)]
[Nullable(0)]
public class Heartbeat : Singleton
{
	// Token: 0x0600DAC2 RID: 56002 RVA: 0x0040B7A5 File Offset: 0x004099A5
	public int GetHeartbeatInterval()
	{
		return this.HeartbeatInterval;
	}

	// Token: 0x0600DAC3 RID: 56003 RVA: 0x0040B7AD File Offset: 0x004099AD
	public void SendHeartbeatImmediately()
	{
		this.SinceLastSendTimeMs = 9999999;
	}

	// Token: 0x0600DAC4 RID: 56004 RVA: 0x0040B7BA File Offset: 0x004099BA
	public void SetMaxTimeOutHandler(Action handler)
	{
		this.MaxTimeOutHandler = handler;
	}

	// Token: 0x0600DAC5 RID: 56005 RVA: 0x0040B7C4 File Offset: 0x004099C4
	public unsafe void BeginHeartBeat(HeartbeatDefine.EBeginHeartbeat reason)
	{
		this.IsHeartBeatOpen = true;
		this.IsWaitingResponse = false;
		this.LastTickMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		this.CurTimeOutCount = 0;
		this.SetHeartBeatMode(HeartbeatDefine.EHeartBeatType.NormalHeartBeat);
		this.SendHeartbeatImmediately();
		EventSystem.Instance.Emit(EEventName.StartHeartBeat);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Heartbeat;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "开启心跳";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxTimeOutCount", this.TimeOutMaxCount);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConnectTimeOut", this.ConnectTimeOut);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HeartbeatInterval", this.HeartbeatInterval);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x0600DAC6 RID: 56006 RVA: 0x0040B8C8 File Offset: 0x00409AC8
	public void SetHeartBeatMode(HeartbeatDefine.EHeartBeatType type)
	{
		HeartbeatDefine.EHeartBeatType? currentHeartBeatState = this.CurrentHeartBeatState;
		if (type == currentHeartBeatState.GetValueOrDefault() & currentHeartBeatState != null)
		{
			return;
		}
		this.CurrentHeartBeatState = new HeartbeatDefine.EHeartBeatType?(type);
		if (type == HeartbeatDefine.EHeartBeatType.NormalHeartBeat)
		{
			this.TimeOutMaxCount = ConfigCommonParamById.GetIntConfig("normal_heartbeat_timeout_reconnect").GetValueOrDefault(3);
			this.ConnectTimeOut = ConfigCommonParamById.GetIntConfig("normal_heartbeat_timeout_ms").GetValueOrDefault(3000);
			this.HeartbeatInterval = ConfigCommonParamById.GetIntConfig("normal_heartbeat_interval_ms").GetValueOrDefault(7000);
			return;
		}
		if (type != HeartbeatDefine.EHeartBeatType.BattleHeartBeat)
		{
			return;
		}
		this.TimeOutMaxCount = ConfigCommonParamById.GetIntConfig("battle_heartbeat_timeout_reconnect").GetValueOrDefault(3);
		this.ConnectTimeOut = ConfigCommonParamById.GetIntConfig("battle_heartbeat_timeout_ms").GetValueOrDefault(900);
		this.HeartbeatInterval = ConfigCommonParamById.GetIntConfig("battle_heartbeat_interval_ms").GetValueOrDefault(1000);
	}

	// Token: 0x0600DAC7 RID: 56007 RVA: 0x0040B9B0 File Offset: 0x00409BB0
	public unsafe void StopHeartBeat(HeartbeatDefine.EStopHeartbeat reason)
	{
		this.IsHeartBeatOpen = false;
		int curTimeOutCount = this.CurTimeOutCount;
		this.CurTimeOutCount = 0;
		this.SetHeartBeatMode(HeartbeatDefine.EHeartBeatType.NormalHeartBeat);
		EventSystem.Instance.Emit(EEventName.StopHeartBeat);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Heartbeat;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "结束心跳";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxTimeOutCount", this.TimeOutMaxCount);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConnectTimeOut", this.ConnectTimeOut);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HeartbeatInterval", this.HeartbeatInterval);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TimeOutCount", curTimeOutCount);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
		string item = "Reason";
		HeartbeatDefine.EStopHeartbeat estopHeartbeat = reason;
		ptr = new ValueTuple<string, object>(item, estopHeartbeat.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
	}

	// Token: 0x0600DAC8 RID: 56008 RVA: 0x0040BAB8 File Offset: 0x00409CB8
	private void AddTimeOutCount()
	{
		this.CurTimeOutCount++;
		if (!this.IsHeartBeatOpen)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Heartbeat;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "心跳超时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("次数", this.CurTimeOutCount);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.CurTimeOutCount < this.TimeOutMaxCount)
		{
			this.SendHeartbeatImmediately();
			return;
		}
		TimerSystem.Instance.Next(delegate(float handleId)
		{
			Action maxTimeOutHandler = this.MaxTimeOutHandler;
			if (maxTimeOutHandler == null)
			{
				return;
			}
			maxTimeOutHandler();
		}, null, null);
	}

	// Token: 0x0600DAC9 RID: 56009 RVA: 0x0040BB3D File Offset: 0x00409D3D
	public void RegisterTick()
	{
		if (this.TickTimerHandle == null)
		{
			this.TickTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x0600DACA RID: 56010 RVA: 0x0040BB70 File Offset: 0x00409D70
	private void Tick(float deltaMs)
	{
		if (!this.IsHeartBeatOpen)
		{
			return;
		}
		long num = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		float num2 = Math.Max((float)(num - this.LastTickMs), deltaMs);
		this.SinceLastSendTimeMs += (int)num2;
		this.LastTickMs = num;
		if (this.SinceLastSendTimeMs < this.HeartbeatInterval)
		{
			return;
		}
		if (this.IsWaitingResponse)
		{
			return;
		}
		this.SendHeartbeat();
	}

	// Token: 0x0600DACB RID: 56011 RVA: 0x0040BBD8 File Offset: 0x00409DD8
	private void SendHeartbeat()
	{
		this.SinceLastSendTimeMs = 0;
		HeartbeatRequest heartbeatRequest = new HeartbeatRequest();
		FArrayBuffer antiData = FTpSafeProxy.GetAntiData2();
		if (antiData.Length > 0UL)
		{
			heartbeatRequest.ReportData = ByteString.CopyFrom(antiData.ToByteArray());
		}
		Net.Instance.Call(ERequestMessageId.HeartbeatRequest, heartbeatRequest, new Action<IMessage, Net.CallbackStatus>(this.HeartbeatResponse), this.ConnectTimeOut);
		this.IsWaitingResponse = true;
		EventSystem.Instance.Emit(EEventName.SendHeartbeat);
	}

	// Token: 0x0600DACC RID: 56012 RVA: 0x0040BC49 File Offset: 0x00409E49
	[NullableContext(2)]
	private void HeartbeatResponse(IMessage msg, Net.CallbackStatus status)
	{
		bool flag = (HeartbeatResponse)msg != null;
		this.IsWaitingResponse = false;
		if (!flag)
		{
			this.AddTimeOutCount();
		}
	}

	// Token: 0x17001473 RID: 5235
	// (get) Token: 0x0600DACD RID: 56013 RVA: 0x0040BC60 File Offset: 0x00409E60
	public static Heartbeat Instance
	{
		get
		{
			if (Heartbeat._instance == null)
			{
				Heartbeat._instance = new Heartbeat();
				Heartbeat._instance.OnInit();
			}
			return Heartbeat._instance;
		}
	}

	// Token: 0x0600DACE RID: 56014 RVA: 0x0040BC83 File Offset: 0x00409E83
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DACF RID: 56015 RVA: 0x0040BC85 File Offset: 0x00409E85
	public static void ResetStaticDefaultValue()
	{
		Heartbeat instance = Heartbeat._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Heartbeat._instance = null;
	}

	// Token: 0x0600DAD0 RID: 56016 RVA: 0x0040BC9E File Offset: 0x00409E9E
	static Heartbeat()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Heartbeat.CreateStaticDefaultValue), new Action(Heartbeat.ResetStaticDefaultValue));
	}

	// Token: 0x04007A0A RID: 31242
	private bool IsHeartBeatOpen;

	// Token: 0x04007A0B RID: 31243
	private bool IsWaitingResponse;

	// Token: 0x04007A0C RID: 31244
	private int CurTimeOutCount;

	// Token: 0x04007A0D RID: 31245
	public int TimeOutMaxCount;

	// Token: 0x04007A0E RID: 31246
	private int ConnectTimeOut;

	// Token: 0x04007A0F RID: 31247
	private int HeartbeatInterval;

	// Token: 0x04007A10 RID: 31248
	private int SinceLastSendTimeMs;

	// Token: 0x04007A11 RID: 31249
	private long LastTickMs;

	// Token: 0x04007A12 RID: 31250
	[Nullable(2)]
	private TimerHandle TickTimerHandle;

	// Token: 0x04007A13 RID: 31251
	private Action MaxTimeOutHandler;

	// Token: 0x04007A14 RID: 31252
	private HeartbeatDefine.EHeartBeatType? CurrentHeartBeatState;

	// Token: 0x04007A15 RID: 31253
	[Nullable(2)]
	private static Heartbeat _instance;
}
