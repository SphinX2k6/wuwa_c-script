using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extensions;
using CSharpScript.Game.Common.Event;
using CSharpScript.Typing;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200208D RID: 8333
[NullableContext(1)]
[Nullable(0)]
public class Heartbeat : Singleton
{
	// Token: 0x0601065A RID: 67162 RVA: 0x003FF35D File Offset: 0x003FD55D
	public int GetHeartbeatInterval()
	{
		return this.HeartbeatInterval;
	}

	// Token: 0x0601065B RID: 67163 RVA: 0x003FF365 File Offset: 0x003FD565
	public void SendHeartbeatImmediately()
	{
		this.SinceLastSendTimeMs = 9999999;
	}

	// Token: 0x0601065C RID: 67164 RVA: 0x003FF372 File Offset: 0x003FD572
	public void SetMaxTimeOutHandler(Action handler)
	{
		this.MaxTimeOutHandler = handler;
	}

	// Token: 0x0601065D RID: 67165 RVA: 0x003FF37C File Offset: 0x003FD57C
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

	// Token: 0x0601065E RID: 67166 RVA: 0x003FF480 File Offset: 0x003FD680
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

	// Token: 0x0601065F RID: 67167 RVA: 0x003FF568 File Offset: 0x003FD768
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

	// Token: 0x06010660 RID: 67168 RVA: 0x003FF670 File Offset: 0x003FD870
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

	// Token: 0x06010661 RID: 67169 RVA: 0x003FF6F5 File Offset: 0x003FD8F5
	public void RegisterTick()
	{
		if (this.TickTimerHandle == null)
		{
			this.TickTimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x06010662 RID: 67170 RVA: 0x003FF728 File Offset: 0x003FD928
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

	// Token: 0x06010663 RID: 67171 RVA: 0x003FF790 File Offset: 0x003FD990
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

	// Token: 0x06010664 RID: 67172 RVA: 0x003FF801 File Offset: 0x003FDA01
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

	// Token: 0x17001446 RID: 5190
	// (get) Token: 0x06010665 RID: 67173 RVA: 0x003FF818 File Offset: 0x003FDA18
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

	// Token: 0x06010666 RID: 67174 RVA: 0x003FF83B File Offset: 0x003FDA3B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010667 RID: 67175 RVA: 0x003FF83D File Offset: 0x003FDA3D
	public static void ResetStaticDefaultValue()
	{
		Heartbeat instance = Heartbeat._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Heartbeat._instance = null;
	}

	// Token: 0x06010668 RID: 67176 RVA: 0x003FF856 File Offset: 0x003FDA56
	static Heartbeat()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Heartbeat.CreateStaticDefaultValue), new Action(Heartbeat.ResetStaticDefaultValue));
	}

	// Token: 0x04007921 RID: 31009
	private bool IsHeartBeatOpen;

	// Token: 0x04007922 RID: 31010
	private bool IsWaitingResponse;

	// Token: 0x04007923 RID: 31011
	private int CurTimeOutCount;

	// Token: 0x04007924 RID: 31012
	public int TimeOutMaxCount;

	// Token: 0x04007925 RID: 31013
	private int ConnectTimeOut;

	// Token: 0x04007926 RID: 31014
	private int HeartbeatInterval;

	// Token: 0x04007927 RID: 31015
	private int SinceLastSendTimeMs;

	// Token: 0x04007928 RID: 31016
	private long LastTickMs;

	// Token: 0x04007929 RID: 31017
	[Nullable(2)]
	private TimerHandle TickTimerHandle;

	// Token: 0x0400792A RID: 31018
	private Action MaxTimeOutHandler;

	// Token: 0x0400792B RID: 31019
	private HeartbeatDefine.EHeartBeatType? CurrentHeartBeatState;

	// Token: 0x0400792C RID: 31020
	[Nullable(2)]
	private static Heartbeat _instance;
}
