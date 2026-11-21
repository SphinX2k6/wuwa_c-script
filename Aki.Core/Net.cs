using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extensions;
using CSharpScript.Core.Net;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020000B4 RID: 180
[NullableContext(1)]
[Nullable(0)]
public class Net : Singleton
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001CBBB File Offset: 0x0001ADBB
	public float RttMs
	{
		get
		{
			return NetInfo.Instance.RttMs;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001CBC7 File Offset: 0x0001ADC7
	public float LastReceiveTimeMs
	{
		get
		{
			return (float)this.LastReceiveTimeMsInternal;
		}
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
	public void StartReconnecting()
	{
		this.IsReconnecting = true;
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001CBD9 File Offset: 0x0001ADD9
	private void EndReconnecting()
	{
		this.IsReconnecting = false;
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001CBE2 File Offset: 0x0001ADE2
	public bool IsServerConnected()
	{
		return this.IsReconnecting || this.LoginState == Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001CBF7 File Offset: 0x0001ADF7
	public bool IsFinishLogin()
	{
		return this.LoginState == Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0001CC02 File Offset: 0x0001AE02
	public void ChangeState1()
	{
		this.LoginState = Net.EServerLoginState.AskingProtoKey;
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0001CC0B File Offset: 0x0001AE0B
	private void ChangeStateKeyReady()
	{
		if (this.LoginState != Net.EServerLoginState.AskingProtoKey)
		{
			this.PrintChangeStateError(Net.EServerLoginState.ProtoKeyReady);
		}
		this.LoginState = Net.EServerLoginState.ProtoKeyReady;
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0001CC24 File Offset: 0x0001AE24
	private bool IsProtoKeyReady()
	{
		return this.LoginState >= Net.EServerLoginState.ProtoKeyReady && this.LoginState <= Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0001CC3D File Offset: 0x0001AE3D
	public void ChangeStateEnterGame()
	{
		if (this.LoginState != Net.EServerLoginState.ProtoKeyReady && this.LoginState != Net.EServerLoginState.DoingLogin)
		{
			this.PrintChangeStateError(Net.EServerLoginState.DoingLogin);
		}
		this.LoginState = Net.EServerLoginState.DoingLogin;
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0001CC5F File Offset: 0x0001AE5F
	private void ChangeStateFinishLogin()
	{
		if (this.LoginState != Net.EServerLoginState.DoingLogin)
		{
			this.PrintChangeStateError(Net.EServerLoginState.FinishedLogin);
		}
		this.LoginState = Net.EServerLoginState.FinishedLogin;
		this.EndReconnecting();
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0001CC7E File Offset: 0x0001AE7E
	public bool IsNotifyCallbackPaused()
	{
		return this.IsNotifyCallbackPausedInternal;
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0001CC88 File Offset: 0x0001AE88
	public void PauseAllNotifyCallback()
	{
		this.IsNotifyCallbackPausedInternal = true;
		Log.Instance.Info(ELogModule.Net, ELogAuthor.MZJ, "暂停消息处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
	public void ResumeAllNotifyCallback()
	{
		this.IsNotifyCallbackPausedInternal = false;
		Log.Instance.Info(ELogModule.Net, ELogAuthor.MZJ, "恢复消息处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
	private unsafe void PrintChangeStateError(Net.EServerLoginState destState)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "状态切换错误";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Current", this.LoginState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Dest", destState);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001CD57 File Offset: 0x0001AF57
	public void SetNetworkErrorHandle(Net.TNetworkErrorHandle handle)
	{
		this.NetErrorHandle = handle;
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0001CD60 File Offset: 0x0001AF60
	public void SetExceptionHandle(Net.TExceptionHandle handle)
	{
		this.ExceptionHandle = handle;
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0001CD69 File Offset: 0x0001AF69
	public void SetAddRequestMaskHandle(Action<int> handle)
	{
		this.AddRequestMaskHandle = handle;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001CD72 File Offset: 0x0001AF72
	public void SetRemoveRequestMaskHandle(Action<int> handle)
	{
		this.RemoveRequestMaskHandle = handle;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0001CD7C File Offset: 0x0001AF7C
	public bool Initialize()
	{
		this.SetKcpConnectStatus(Net.EKcpConnectStatus.NoConnect);
		this.KcpClient = new UKuroKcpClient();
		if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
		{
			this.KcpClient.UseNewResolveIp = false;
		}
		this.KcpClient.IsTickDrivenOutside = true;
		this.KcpClient.OnConnectSuccess.Add(new Action(this.OnKcpConnectSuccess));
		this.KcpClient.OnRecResp.Bind(new Action<int, short, ushort, FArrayBuffer>(this.OnReceiveResponse));
		this.KcpClient.OnRecException.Bind(new Action<int, short, uint, FArrayBuffer>(this.OnReceiveException));
		this.KcpClient.OnRecTcpException.Bind(new Action<uint>(this.OnReceiveTcpException));
		this.KcpClient.OnRecPush.Bind(new Action<int, ushort, FArrayBuffer>(this.OnReceivePush));
		this.KcpClient.OnError.Bind(new Action<int, int, int, int, int>(this.OnError));
		this.KcpClient.SetEnType(2, 111);
		this.KcpClient.SetEnType(2, 112);
		bool disableCrc = false;
		UKuroVariableFunctionLibrary.GetBoolValue("DisableCrc", ref disableCrc);
		NetInfo.Instance.DisableCrc = disableCrc;
		this.RpcId = 0;
		this.UpStreamSeqNo = 0;
		this.DownStreamSeqNo = 0;
		this.FillMessageNameAndStatMap(NetDefine.PushMessageIds, "Net.Push", true);
		this.FillMessageNameAndStatMap(NetDefine.RequestMessageIds, "Net.Request", false);
		this.FillMessageNameAndStatMap(NetDefine.ResponseMessageIds, "Net.Response", true);
		this.FillMessageNameAndStatMap(NetDefine.NotifyMessageIds, "Net.Notify", true);
		uint num = 1000U;
		if (this.KcpClient.RemoteMtu > 0U)
		{
			num = this.KcpClient.RemoteMtu;
		}
		uint kcpSegmentSize = (num - 24U) * 127U;
		this.KcpClient.SetKcpMtu((int)num);
		this.KcpClient.SetKcpSegmentSize((int)kcpSegmentSize);
		this.KcpClient.SetKcpWndSize(256, 256);
		this.KcpClient.SetKcpNoDelay(1, 10, 2, 1);
		this.KcpClient.SetKcpStream(true);
		NetGameBudgetOnceTaskGroup groupObject = new NetGameBudgetOnceTaskGroup(new FName("NetOnceTaskGroup"), 100, new Func<bool>(this.IsCacheQueueEmpty), new Action(this.ConsumeCacheQueue));
		GameBudgetInterfaceController.Instance.RegisterOnceTaskCustomGroup(groupObject);
		return true;
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001CF9E File Offset: 0x0001B19E
	public void Tick(float deltaTime)
	{
		if (this.KcpClient != null)
		{
			this.KcpClient.TickOutside(deltaTime);
		}
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
	public void InitCanTimerOutMessage(HashSet<ERequestMessageId> messageIdsSet)
	{
		this.CanTimeOutMessages = messageIdsSet;
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001CFBD File Offset: 0x0001B1BD
	private bool IsCacheQueueEmpty()
	{
		return this.CallbackList.Count == 0 || (this.IsNotifyCallbackPausedInternal && this.NonePausedCallbackCount == 0);
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001CFE1 File Offset: 0x0001B1E1
	private bool CallCurrentCallback()
	{
		if (this.CurrentProcessedCallback != null)
		{
			if (this.CurrentProcessedCallback.DoCallback())
			{
				this.CurrentProcessedCallback = null;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001D004 File Offset: 0x0001B204
	private void ConsumeCacheQueue()
	{
		if (this.CallCurrentCallback())
		{
			return;
		}
		LinkedNode<Net.CallbackQueueItem> linkedNode = this.CallbackList.GetHeadNextNode();
		while (linkedNode != null)
		{
			if (this.IsNotifyCallbackPausedInternal)
			{
				Net.CallbackQueueItem element = linkedNode.Element;
				if (element != null && element.IsPaused())
				{
					linkedNode = linkedNode.Next;
					continue;
				}
			}
			this.CurrentProcessedCallback = linkedNode.Element;
			this.CallbackList.RemoveNode(linkedNode);
			int nonePausedCallbackCount = this.NonePausedCallbackCount;
			Net.CallbackQueueItem element2 = linkedNode.Element;
			this.NonePausedCallbackCount = nonePausedCallbackCount - ((element2 == null || !element2.IsPaused()) ? 1 : 0);
			this.CallCurrentCallback();
			return;
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0001D094 File Offset: 0x0001B294
	public void Connect(string ip, int port, Net.TConnectResultCallback callback, int timeoutMsPerTry, int retryCount)
	{
		if (!this.CanKcpConnect())
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.ZJC, "已经连接或者正在连接中", default(ReadOnlySpan<ValueTuple<string, object>>));
			callback(Net.EConnectResult.Other);
			return;
		}
		this.ConnectCallback = callback;
		this.ConnectMaxRetryCount = retryCount;
		this.ConnectRetryCount = 0;
		this.ConnectServerIp = ip;
		this.ConnectServerPort = port;
		this.ConnectTimeoutMsPerTry = timeoutMsPerTry;
		this.DoConnect();
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0001D100 File Offset: 0x0001B300
	[NullableContext(0)]
	public UniTask<Net.EConnectResult> ConnectAsync([Nullable(1)] string ip, int port, int timeoutMsPerTry, int retryCount)
	{
		Net.<ConnectAsync>d__92 <ConnectAsync>d__;
		<ConnectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<Net.EConnectResult>.Create();
		<ConnectAsync>d__.<>4__this = this;
		<ConnectAsync>d__.ip = ip;
		<ConnectAsync>d__.port = port;
		<ConnectAsync>d__.timeoutMsPerTry = timeoutMsPerTry;
		<ConnectAsync>d__.retryCount = retryCount;
		<ConnectAsync>d__.<>1__state = -1;
		<ConnectAsync>d__.<>t__builder.Start<Net.<ConnectAsync>d__92>(ref <ConnectAsync>d__);
		return <ConnectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0001D164 File Offset: 0x0001B364
	public void Disconnect(Net.EDisconnectReason disconnectReason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "断开连接";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", disconnectReason);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.SetKcpConnectStatus(Net.EKcpConnectStatus.NoConnect);
		if (this.ConnectCallback != null)
		{
			this.SetConnectResult(Net.EConnectResult.Disconnect);
		}
		if (disconnectReason == Net.EDisconnectReason.Logout)
		{
			this.LoginState = Net.EServerLoginState.Logout;
		}
		else
		{
			this.LoginState = Net.EServerLoginState.NoLogin;
		}
		if (disconnectReason != Net.EDisconnectReason.Reconnect)
		{
			this.CleanMessageCaches();
			this.RpcId = 0;
			this.UpStreamSeqNo = 0;
			this.EndReconnecting();
		}
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
	public unsafe void SetDynamicProtoKey(Net.EServerEncryptType sType, byte[] key)
	{
		Net.EClientEncryptType eclientEncryptType = Net.Instance.s2cEncryptType[sType];
		this.ChangeStateKeyReady();
		fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(key))
		{
			byte* data = arrayDataReference;
			FArrayBuffer farrayBuffer = new FArrayBuffer
			{
				Data = (void*)data,
				Length = (ulong)((long)key.Length)
			};
			if (!this.KcpClient.SetK((byte)eclientEncryptType, farrayBuffer))
			{
				Log.Instance.Warn(ELogModule.Net, ELogAuthor.LRA, "网络 key 设置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0001D261 File Offset: 0x0001B461
	public int GetDownStreamSeqNo()
	{
		return this.DownStreamSeqNo;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0001D26C File Offset: 0x0001B46C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public unsafe ValueTuple<int, int, string, string> GetCachedMessageData(int seqNo)
	{
		LinkedNode<Net.SendMessageCache> linkedNode = this.MessageCacheList.GetHeadNextNode();
		Net.SendMessageCache sendMessageCache = null;
		while (linkedNode != null)
		{
			if (linkedNode.Element.SeqNo == seqNo)
			{
				sendMessageCache = linkedNode.Element;
				break;
			}
			linkedNode = linkedNode.Next;
		}
		if (sendMessageCache != null)
		{
			fixed (byte* pinnableReference = sendMessageCache.EncodeMessage.GetPinnableReference())
			{
				byte* data = pinnableReference;
				FArrayBuffer farrayBuffer = new FArrayBuffer
				{
					Data = (void*)data,
					Length = (ulong)((long)sendMessageCache.EncodeMessage.Length)
				};
				string[] array = this.KcpClient.GetDebugString(farrayBuffer, ";", (short)sendMessageCache.MessageId, sendMessageCache.SeqNo).Split(';', StringSplitOptions.None);
				return new ValueTuple<int, int, string, string>((int)sendMessageCache.MessageId, int.Parse(array[0]), array[1], array[3]);
			}
		}
		return new ValueTuple<int, int, string, string>(0, 0, "", "");
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x0001D345 File Offset: 0x0001B545
	public int GetUnVerifiedMessageCount()
	{
		return this.MessageCacheList.Count;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0001D354 File Offset: 0x0001B554
	public unsafe void ReconnectSuccessAndReSend(int lastReceivedClientSeq)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "重连流程";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("lastReceived", lastReceivedClientSeq);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		int count = this.MessageCacheList.Count;
		if (count > 0)
		{
			LinkedNode<Net.SendMessageCache> linkedNode = this.MessageCacheList.GetHeadNextNode();
			bool includeThis = false;
			while (linkedNode != null)
			{
				int seqNo = linkedNode.Element.SeqNo;
				if (seqNo >= lastReceivedClientSeq)
				{
					includeThis = (seqNo == lastReceivedClientSeq);
					break;
				}
				linkedNode = linkedNode.Next;
			}
			if (linkedNode != null)
			{
				Net.SendMessageCache.DisposeAndRemoveBefore(this.MessageCacheList, linkedNode, includeThis);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Net;
				ELogAuthor author2 = ELogAuthor.MZJ;
				string message2 = "重连流程, 清理掉已经被服务器收到的缓存消息";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("beforeCount", count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("afterCount", this.MessageCacheList.Count);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("find SeqNo", linkedNode.Element.SeqNo);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
		if (this.MessageCacheList.Count > 0)
		{
			int num = 0;
			int num2 = 0;
			EMessageId emessageId = (EMessageId)0;
			for (LinkedNode<Net.SendMessageCache> linkedNode2 = this.MessageCacheList.GetHeadNextNode(); linkedNode2 != null; linkedNode2 = linkedNode2.Next)
			{
				Net.SendMessageCache element = linkedNode2.Element;
				EMessageId messageId = element.MessageId;
				if ((NetDefine.ProtoConfig[messageId] & 3) != 0)
				{
					int rpcId = element.RpcId;
					Net.EMessageType emessageType = (rpcId != 0) ? Net.EMessageType.Request : Net.EMessageType.Push;
					if (emessageType == Net.EMessageType.Push || element.Handle != null)
					{
						num++;
						num2 = element.SeqNo;
						emessageId = messageId;
						this.DoSend(emessageType, element.SeqNo, new int?(rpcId), messageId, element.EncodeMessage, null);
					}
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Net;
			ELogAuthor author3 = ELogAuthor.MZJ;
			string message3 = "重连流程, 重发未被服务器确认的消息";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Count", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("lastSeqNo", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("lastMsgId", emessageId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		this.ChangeStateFinishLogin();
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0001D5BC File Offset: 0x0001B7BC
	public bool Register(ENotifyMessageId id, [Nullable(new byte[]
	{
		1,
		2,
		2
	})] Action<IMessage, Net.CallbackStatus> callback)
	{
		if (this.NotifyHandles.ContainsKey(id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "网络消息重复注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.NotifyHandles[id] = new Net.MessageCallback(callback);
		return true;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001D618 File Offset: 0x0001B818
	public bool UnRegister(ENotifyMessageId id)
	{
		if (!this.NotifyHandles.Remove(id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "Notify消息未注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0001D664 File Offset: 0x0001B864
	public void Send(EPushMessageId pushMessageId, IMessage message)
	{
		if (!this.IsPassLoginCheck((EMessageId)pushMessageId))
		{
			return;
		}
		this.EncodeAddToCacheAndSend(Net.EMessageType.Push, (EMessageId)pushMessageId, message, null, null);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0001D690 File Offset: 0x0001B890
	public void Call(ERequestMessageId requestMessageId, IMessage message, [Nullable(2)] Action<IMessage, Net.CallbackStatus> handle, int timeoutMs = 0)
	{
		if (this.IsRequestLocked(requestMessageId))
		{
			if (handle != null)
			{
				handle(null, null);
			}
			return;
		}
		if (!this.IsPassLoginCheck((EMessageId)requestMessageId))
		{
			if (handle != null)
			{
				handle(null, null);
			}
			return;
		}
		int rpcId = this.GetRpcId();
		LinkedNode<Net.SendMessageCache> linkedNode = this.EncodeAddToCacheAndSend(Net.EMessageType.Request, (EMessageId)requestMessageId, message, new int?(rpcId), new Net.MessageCallback(handle));
		this.SaveCallbackAndLockRequest(requestMessageId, linkedNode);
		if (timeoutMs > 0)
		{
			this.AddMessageTimeout(timeoutMs, linkedNode.Element);
		}
		if ((NetDefine.ProtoConfig[(EMessageId)requestMessageId] & 4) == 4)
		{
			Action<int> addRequestMaskHandle = this.AddRequestMaskHandle;
			if (addRequestMaskHandle == null)
			{
				return;
			}
			addRequestMaskHandle(rpcId);
		}
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001D720 File Offset: 0x0001B920
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<IMessage> CallAsync(ERequestMessageId requestMessageId, IMessage message, int timeoutMs = 0)
	{
		Net.<CallAsync>d__105 <CallAsync>d__;
		<CallAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<IMessage>.Create();
		<CallAsync>d__.<>4__this = this;
		<CallAsync>d__.requestMessageId = requestMessageId;
		<CallAsync>d__.message = message;
		<CallAsync>d__.timeoutMs = timeoutMs;
		<CallAsync>d__.<>1__state = -1;
		<CallAsync>d__.<>t__builder.Start<Net.<CallAsync>d__105>(ref <CallAsync>d__);
		return <CallAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0001D77C File Offset: 0x0001B97C
	private unsafe LinkedNode<Net.SendMessageCache> EncodeAddToCacheAndSend(Net.EMessageType msgType, EMessageId msgId, IMessage message, int? rpcId, [Nullable(2)] Net.IMessageCallBack handle)
	{
		int num = this.IncUpStreamSeqNo();
		LinkedNode<Net.SendMessageCache> result;
		using (MessageSerializationBuffer buffer = MessageSerializationBuffer.GetBuffer(msgId, message))
		{
			if (buffer.Length > 30720)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Net;
				ELogAuthor author = ELogAuthor.MZJ;
				string message2 = "消息过大";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("message", msgId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", buffer.Length);
				instance.Error(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			Net.SendMessageCache messageCache = new Net.SendMessageCache(rpcId, new int?(num), new EMessageId?(msgId), buffer.MessageSpan, handle);
			LinkedNode<Net.SendMessageCache> linkedNode = this.AddToMessageCache(messageCache);
			if (!this.CacheDueToReconnecting((int)msgId))
			{
				this.DoSend(msgType, num, rpcId, msgId, buffer.MessageSpan, null);
			}
			result = linkedNode;
		}
		return result;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0001D870 File Offset: 0x0001BA70
	private unsafe void AddMessageTimeout(int timeoutMs, Net.SendMessageCache messageCache)
	{
		ERequestMessageId requestMessageId = (ERequestMessageId)messageCache.MessageId;
		if (this.CanTimeOutMessages.Contains(requestMessageId))
		{
			TimerHandle timeoutHandle = TimerSystem.Instance.Delay(delegate(float id)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Net;
				ELogAuthor author2 = ELogAuthor.MZJ;
				string message2 = "协议超时";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("message", requestMessageId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timeout", timeoutMs);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				Net.IMessageCallBack handle = messageCache.Handle;
				messageCache.ClearHandle();
				messageCache.TimeoutHandle = null;
				if ((NetDefine.ProtoConfig[messageCache.MessageId] & 4) == 4)
				{
					Action<int> removeRequestMaskHandle = this.RemoveRequestMaskHandle;
					if (removeRequestMaskHandle != null)
					{
						removeRequestMaskHandle(messageCache.RpcId);
					}
				}
				if ((NetDefine.ProtoConfig[messageCache.MessageId] & 8) == 8)
				{
					this.RequestLock.Remove(requestMessageId);
				}
				this.RequestMessageMap.Remove(messageCache.RpcId);
				if (handle != null)
				{
					try
					{
						if (this.IsNetStatEnable)
						{
							this.MessageIdStatMap.GetValueOrDefault((EMessageId)requestMessageId, null);
						}
						handle.Invoke(null, null);
					}
					catch (Exception ex) when (1)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.Net;
						ELogAuthor author3 = ELogAuthor.MZJ;
						string message3 = "callback执行异常";
						Exception error = ex;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("requestId", requestMessageId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex.Message);
						instance3.ErrorWithStack(module3, author3, message3, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					finally
					{
					}
				}
			}, (float)timeoutMs, null, null, true, 1f);
			messageCache.TimeoutHandle = timeoutHandle;
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "该协议未配置可超时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("message", requestMessageId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0001D920 File Offset: 0x0001BB20
	private void FillMessageNameAndStatMap(EMessageId[] messageIds, string namePrefix, bool createStat)
	{
		if (this.IsNetLogEnabled || this.IsNetStatEnable)
		{
			foreach (EMessageId emessageId in messageIds)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted(namePrefix);
				defaultInterpolatedStringHandler.AppendLiteral(".(");
				defaultInterpolatedStringHandler.AppendFormatted<EMessageId>(emessageId);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				if (this.IsNetLogEnabled)
				{
					this.MessageIdNameMap[emessageId] = text;
				}
				if (createStat && this.IsNetStatEnable)
				{
					Stat value = Stat.CreateNoFlameGraph(text, "", "");
					this.MessageIdStatMap[emessageId] = value;
				}
			}
		}
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001D9D4 File Offset: 0x0001BBD4
	private bool IsRequestLocked(ERequestMessageId requestMessageId)
	{
		if (this.RequestLock.Contains(requestMessageId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "Request重复发送。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("message", requestMessageId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		return false;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0001DA1E File Offset: 0x0001BC1E
	private void SetKcpConnectStatus(Net.EKcpConnectStatus connectStatus)
	{
		if (this.KcpConnectStatus != connectStatus)
		{
			this.KcpConnectStatus = connectStatus;
			if (connectStatus == Net.EKcpConnectStatus.NoConnect && this.KcpClient != null)
			{
				this.KcpClient.Disconnect();
			}
		}
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0001DA46 File Offset: 0x0001BC46
	private bool CanKcpConnect()
	{
		return this.KcpConnectStatus == Net.EKcpConnectStatus.NoConnect;
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0001DA54 File Offset: 0x0001BC54
	private void DoConnect()
	{
		this.ConnectTimeoutTimer = TimerSystem.Instance.Delay(delegate(float id)
		{
			this.SetConnectResult(Net.EConnectResult.Timeout);
		}, (float)this.ConnectTimeoutMsPerTry, null, null, true, 1f);
		this.SetKcpConnectStatus(Net.EKcpConnectStatus.Connecting);
		if (this.KcpClient != null)
		{
			this.KcpClient.Connect(this.ConnectServerIp, this.ConnectServerPort, NetInfo.Instance.DisableCrc);
		}
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001DABD File Offset: 0x0001BCBD
	private bool IsReconnectControlMessage(ERequestMessageId messageId)
	{
		return messageId == ERequestMessageId.ProtoKeyRequest || messageId == ERequestMessageId.ReconnectRequest;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0001DACB File Offset: 0x0001BCCB
	private bool CacheDueToReconnecting(int messageId)
	{
		return this.IsReconnecting && !this.IsReconnectControlMessage((ERequestMessageId)messageId);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
	private unsafe bool IsPassLoginCheck(EMessageId messageId)
	{
		if (this.LoginState == Net.EServerLoginState.Logout)
		{
			return false;
		}
		if (this.IsReconnecting)
		{
			if (messageId == EMessageId.ReconnectRequest && !this.IsProtoKeyReady())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Net;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "上行协议时机不对，未发送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("messageId", messageId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return true;
		}
		else
		{
			if (!this.IsMsgUseBuiltinEncrypt(messageId) && !this.IsProtoKeyReady())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Net;
				ELogAuthor author2 = ELogAuthor.LRA;
				string message2 = "上行协议时机不对，未发送";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("messageId", messageId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (this.LoginState != Net.EServerLoginState.FinishedLogin && (NetDefine.ProtoConfig[messageId] & 3) != 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Net;
				ELogAuthor author3 = ELogAuthor.ZJC;
				string message3 = "尚未完成登录流程, 登录流程以外的协议会被丢弃";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", this.LoginState);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("messageId", messageId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return true;
		}
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001DC00 File Offset: 0x0001BE00
	private int GetRpcId()
	{
		if (this.RpcId < 32767)
		{
			short num = this.RpcId + 1;
			this.RpcId = num;
			return (int)num;
		}
		this.RpcId = 1;
		return (int)this.RpcId;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0001DC3C File Offset: 0x0001BE3C
	private int IncUpStreamSeqNo()
	{
		if (this.UpStreamSeqNo < 2147483647)
		{
			int num = this.UpStreamSeqNo + 1;
			this.UpStreamSeqNo = num;
			return num;
		}
		this.UpStreamSeqNo = 1;
		return this.UpStreamSeqNo;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0001DC78 File Offset: 0x0001BE78
	private unsafe bool SetDownStreamSeqNo(int downStreamSeqNo)
	{
		if (downStreamSeqNo == 0)
		{
			return true;
		}
		int downStreamSeqNo2 = this.DownStreamSeqNo;
		this.DownStreamSeqNo = downStreamSeqNo;
		int num = downStreamSeqNo2 + 1;
		if (downStreamSeqNo2 == 2147483647)
		{
			num = 1;
		}
		if (downStreamSeqNo != num)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "下行包序号不对";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", downStreamSeqNo2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", num);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return true;
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0001DD0A File Offset: 0x0001BF0A
	private LinkedNode<Net.SendMessageCache> AddToMessageCache(Net.SendMessageCache messageCache)
	{
		bool isNetLogEnabled = this.IsNetLogEnabled;
		messageCache.InList = true;
		return this.MessageCacheList.AddTail(messageCache);
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0001DD26 File Offset: 0x0001BF26
	private void SaveCallbackAndLockRequest(ERequestMessageId requestMessageId, LinkedNode<Net.SendMessageCache> node)
	{
		this.RequestMessageMap[node.Element.RpcId] = node;
		if ((NetDefine.ProtoConfig[(EMessageId)requestMessageId] & 8) == 8)
		{
			this.RequestLock.Add(requestMessageId);
		}
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0001DD5C File Offset: 0x0001BF5C
	private void DeleteServerReceivedRequest(LinkedNode<Net.SendMessageCache> nodeRequestMsg)
	{
		Net.SendMessageCache element = nodeRequestMsg.Element;
		EMessageId messageId = element.MessageId;
		this.RequestMessageMap.Remove(element.RpcId);
		if ((NetDefine.ProtoConfig[messageId] & 8) == 8)
		{
			this.RequestLock.Remove((ERequestMessageId)messageId);
		}
		if (messageId == EMessageId.EnterGameRequest)
		{
			this.ChangeStateFinishLogin();
		}
		if (this.IsReconnectControlMessage((ERequestMessageId)messageId))
		{
			return;
		}
		Net.SendMessageCache.DisposeAndRemoveBefore(this.MessageCacheList, nodeRequestMsg, true);
		bool isNetLogEnabled = this.IsNetLogEnabled;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0001DDCF File Offset: 0x0001BFCF
	private bool IsMsgUseBuiltinEncrypt(EMessageId msgId)
	{
		return msgId == EMessageId.ProtoKeyRequest;
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0001DDDC File Offset: 0x0001BFDC
	private void OnKcpConnectSuccess()
	{
		Log.Instance.Info(ELogModule.Net, ELogAuthor.LRX, "[CSharp] OnKcpConnectSuccess", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroKcpClient kcpClient = Net.Instance.KcpClient;
		if (kcpClient != null)
		{
			kcpClient.SetKcpStream(true);
		}
		Net.Instance.SetConnectResult(Net.EConnectResult.Success);
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0001DE28 File Offset: 0x0001C028
	private void SetConnectResult(Net.EConnectResult result)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.MZJ;
		string message = "Kcp连接结果:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.ConnectTimeoutTimer != null && TimerSystem.Instance.Has(this.ConnectTimeoutTimer))
		{
			TimerSystem.Instance.Remove(this.ConnectTimeoutTimer);
			this.ConnectTimeoutTimer = null;
		}
		if (result == Net.EConnectResult.Timeout && Net.Instance.HandleConnectTimeout(false))
		{
			return;
		}
		if ((result == Net.EConnectResult.TCPConnectFailed || result == Net.EConnectResult.TCPConnectTimeOut) && Net.Instance.HandleConnectTimeout(true))
		{
			return;
		}
		if (this.ConnectCallback != null)
		{
			this.ConnectCallback(result);
			this.ConnectCallback = null;
		}
		this.SetKcpConnectStatus((result == Net.EConnectResult.Success) ? Net.EKcpConnectStatus.Connected : Net.EKcpConnectStatus.NoConnect);
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
	private unsafe void OnError(int code1, int code2, int code3, int code4, int code5)
	{
		switch (code1)
		{
		case 1:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "SocketError";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("errorCode", code2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Size", code3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Read", code4);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (code2 != 0)
			{
				Net.TNetworkErrorHandle netErrorHandle = Net.Instance.NetErrorHandle;
				if (netErrorHandle == null)
				{
					return;
				}
				netErrorHandle(code2);
				return;
			}
			break;
		}
		case 2:
			break;
		case 3:
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Net;
			ELogAuthor author2 = ELogAuthor.MZJ;
			string message2 = "DecryptError";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Result", code2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Type", code3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("RpcId", code4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("MessageId", code5);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			return;
		}
		case 4:
			this.HandleKcpRecvError(code2);
			break;
		default:
			return;
		}
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0001E048 File Offset: 0x0001C248
	private void HandleKcpRecvError(int code)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "KcpRecvError";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", code);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (code == -4)
		{
			NetInfo.Instance.DisableCrc = true;
			UKuroVariableFunctionLibrary.SetBoolValue("DisableCrc", true);
		}
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0001E09D File Offset: 0x0001C29D
	private void OnReceiveResponse(int seqNo, short rpcId, ushort messageId, FArrayBuffer messageBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Response, seqNo, (int)messageId, messageBuffer, new int?((int)rpcId), false);
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001E0B2 File Offset: 0x0001C2B2
	private void OnReceiveException(int seqNo, short rpcId, uint errorCode, FArrayBuffer stringBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Exception, seqNo, (int)errorCode, stringBuffer, new int?((int)rpcId), false);
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
	private unsafe void OnReceiveTcpException(uint errorCode)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "TCP连接建立失败:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TcpHosts", NetInfo.Instance.TcpHosts.FormatNetHostInfo());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorCode", errorCode);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.SetConnectResult(Net.EConnectResult.TCPConnectFailed);
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0001E144 File Offset: 0x0001C344
	private void OnReceivePush(int seqNo, ushort messageId, FArrayBuffer messageBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Push, seqNo, (int)messageId, messageBuffer, null, false);
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0001E168 File Offset: 0x0001C368
	private unsafe bool ProcessReceiveMessage(Net.EMessageType messageType, int serverSeqNo, int messageIdOrErrorCode, FArrayBuffer messageBuffer, int? rpcId = null, bool recvFromTs = false)
	{
		Span<byte> span = messageBuffer.ToSpan();
		this.SetDownStreamSeqNo(serverSeqNo);
		LinkedNode<Net.SendMessageCache> nodeRequestMsg = null;
		IMessage message = null;
		Net.IMessageCallBack messageCallBack = null;
		EMessageId messageIdOrErrorCode2 = (EMessageId)messageIdOrErrorCode;
		ERequestMessageId? requestId = null;
		if (messageIdOrErrorCode2 == EMessageId.KcpConvResponse)
		{
			this.ProcessKcpConvResponseMessage(messageIdOrErrorCode2, span);
			return true;
		}
		bool flag = false;
		long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		this.LastReceiveTimeMsInternal = num;
		if (rpcId != null)
		{
			this.RequestMessageMap.TryGetValue(rpcId.Value, out nodeRequestMsg);
			if (nodeRequestMsg != null)
			{
				this.DeleteServerReceivedRequest(nodeRequestMsg);
				Net.SendMessageCache element = nodeRequestMsg.Element;
				long num2 = num - element.SendTimeMs;
				requestId = new ERequestMessageId?((ERequestMessageId)element.MessageId);
				NetInfo.Instance.SetRttMs((int)num2);
				if (num2 > 300L)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Net;
					ELogAuthor author = ELogAuthor.MZJ;
					string message2 = "RTT过高";
					<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("requestId", requestId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rpcId", rpcId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("seqNo", element.SeqNo);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("serverSeqNo", serverSeqNo);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("rtt", num2);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("deltaTime", Time.Instance.DeltaTime);
					instance.Warn(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				}
				messageCallBack = element.Handle;
				if (element.TimeoutHandle != null)
				{
					TimerSystem.Instance.Remove(element.TimeoutHandle);
				}
			}
			else if (!recvFromTs)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Net;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message3 = "网络 rpc 响应不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("rpcId", rpcId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("messageId", messageIdOrErrorCode);
				instance2.Error(module2, author2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}
		else
		{
			Net.IMessageCallBack messageCallBack2;
			this.NotifyHandles.TryGetValue((ENotifyMessageId)messageIdOrErrorCode2, out messageCallBack2);
			messageCallBack = messageCallBack2;
			if (messageCallBack == null && this.IsNetLogEnabled && !recvFromTs)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Net;
				ELogAuthor author3 = ELogAuthor.LCC;
				string message4 = "网络 notify 响应不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Id", messageIdOrErrorCode2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Name", this.MessageIdNameMap.GetValueOrDefault(messageIdOrErrorCode2, ""));
				instance3.Warn(module3, author3, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			}
			flag = true;
		}
		if (messageType == Net.EMessageType.Exception)
		{
			string errMessage = "[异常信息:" + Encoding.UTF8.GetString(span) + "]";
			Net.IMessageCallBack originalHandle = messageCallBack;
			messageCallBack = new Net.MessageCallback(delegate(IMessage resp, Net.CallbackStatus status)
			{
				Net.TExceptionHandle exceptionHandle = this.ExceptionHandle;
				if (exceptionHandle != null)
				{
					exceptionHandle(rpcId.GetValueOrDefault(0), messageIdOrErrorCode, (int)requestId.Value, (nodeRequestMsg != null) ? this.ParseToMessage((EMessageId)requestId.Value, nodeRequestMsg.Element.EncodeMessage) : null, errMessage);
				}
				Net.IMessageCallBack originalHandle = originalHandle;
				if (originalHandle == null)
				{
					return;
				}
				originalHandle.Invoke(null, null);
			});
		}
		else
		{
			message = this.ParseToMessage(messageIdOrErrorCode2, span);
			if (message == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Net;
				ELogAuthor author4 = ELogAuthor.LCC;
				string message5 = "协议解析异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("messageId", messageIdOrErrorCode2);
				instance4.Error(module4, author4, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		if (message != null && this.IsNetLogEnabled)
		{
			this.LogNet((int)messageIdOrErrorCode2, serverSeqNo, rpcId, message);
		}
		Net.CallbackQueueItem callbackQueueItem = new Net.CallbackQueueItem(messageIdOrErrorCode2, flag, num, requestId, rpcId, messageCallBack, message);
		if (this.UseBudget)
		{
			this.CallbackList.AddTail(callbackQueueItem);
			this.NonePausedCallbackCount += ((!flag) ? 1 : 0);
		}
		else
		{
			while (!callbackQueueItem.DoCallback())
			{
			}
		}
		return true;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0001E578 File Offset: 0x0001C778
	[NullableContext(0)]
	private unsafe bool DoSend(Net.EMessageType msgType, int seqNo, int? rpcId, EMessageId msgId, Span<byte> encodedMsg, [Nullable(2)] IMessage originalMessage = null)
	{
		if (this.IsNetLogEnabled)
		{
			IMessage message = originalMessage ?? this.ParseToMessage(msgId, encodedMsg);
			this.LogNet((int)msgId, seqNo, rpcId, message);
		}
		fixed (byte* pinnableReference = encodedMsg.GetPinnableReference())
		{
			byte* data = pinnableReference;
			FArrayBuffer farrayBuffer = new FArrayBuffer
			{
				Data = (void*)data,
				Length = (ulong)((long)encodedMsg.Length)
			};
			return this.KcpClient.SendM((sbyte)msgType, seqNo, (short)rpcId.GetValueOrDefault(0), (short)msgId, farrayBuffer, (NetDefine.ProtoConfig[msgId] & 32) == 0);
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0001E604 File Offset: 0x0001C804
	private void CleanMessageCaches()
	{
		this.RequestLock.Clear();
		this.RequestMessageMap.Clear();
		Net.SendMessageCache.DisposeAllAndClear(this.MessageCacheList);
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0001E628 File Offset: 0x0001C828
	[NullableContext(2)]
	private void LogNet(int id, int seqNo, int? rpcId, object message)
	{
		if (!this.IsHeartLogEnabled && (id == 1650 || id == 1651 || id == 25350))
		{
			return;
		}
		if (id == 18855 || id == 17980 || id == 18826 || id == 21168 || id == 23069 || id == 23936 || id == 28799 || id == 28031 || id == 18938)
		{
			return;
		}
		if (!this.IsSyncLogEnabled && (id == 29999 || id == 23977 || id == 19018 || id == 24670 || id == 18681 || id == 20922 || id == 26497 || id == 29973 || id == 24289))
		{
			return;
		}
		bool isNetLogEnabled = this.IsNetLogEnabled;
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0001E6F8 File Offset: 0x0001C8F8
	[NullableContext(0)]
	[return: Nullable(2)]
	public unsafe IMessage ParseToMessage(EMessageId messageId, Span<byte> encodedMsg)
	{
		IMessage message = NetDefine.CreateMessageById((int)messageId);
		if (message == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.LRX;
			string message2 = "未注册的消息类型->请重新导出网络消息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("messageId:", messageId);
			instance.Error(module, author, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		IMessage result;
		try
		{
			message.MergeFrom(encodedMsg);
			result = message;
		}
		catch (Exception ex)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Net;
			ELogAuthor author2 = ELogAuthor.LRX;
			string message3 = "Net.ParseToMessage->解析消息异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("messageId:", messageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ex:", ex.ToString());
			instance2.Error(module2, author2, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			result = null;
		}
		return result;
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0001E7C4 File Offset: 0x0001C9C4
	private unsafe bool HandleConnectTimeout(bool ignoreTcp)
	{
		if (!ignoreTcp)
		{
			int num = 10000;
			int num2 = 0;
			bool flag = NetInfo.Instance.TcpRatio >= num;
			if (NetInfo.Instance.TcpRatio < num && NetInfo.Instance.TcpRatio > 0)
			{
				num2 = Net.SharedRandom.Next(0, num);
				flag = (num2 < NetInfo.Instance.TcpRatio && NetInfo.Instance.TcpRetry < NetInfo.Instance.TcpMaxRetry);
			}
			bool flag2 = NetInfo.Instance.TcpRetry >= NetInfo.Instance.TcpMaxRetry;
			if (flag && !flag2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Net;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "kcp会话id使用Tcp获取:";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TcpRatio", NetInfo.Instance.TcpRatio);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RandomValue", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RetryCount", this.ConnectRetryCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TcpRetry", NetInfo.Instance.TcpRetry);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				this.StartTcpConnect();
				return true;
			}
		}
		if (this.ConnectRetryCount >= this.ConnectMaxRetryCount)
		{
			return false;
		}
		this.ConnectRetryCount++;
		this.SetKcpConnectStatus(Net.EKcpConnectStatus.NoConnect);
		this.DoConnect();
		return true;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0001E948 File Offset: 0x0001CB48
	private unsafe void StartTcpConnect()
	{
		if (this.KcpClient == null)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.LRX, "KCP未初始化,无法启动TCP连接", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.KcpConnectStatus == Net.EKcpConnectStatus.Connected)
		{
			Log.Instance.Warn(ELogModule.Net, ELogAuthor.LRX, "KCP已连接,无需建立TCP连接", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (NetInfo.Instance.TcpHosts == null || NetInfo.Instance.TcpHosts.Count == 0)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.LRX, "TCP服务器列表为空, 无法建立TCP连接", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.KcpClient == null)
		{
			return;
		}
		this.KcpClient.CloseTcpConnect();
		string host = NetInfo.Instance.TcpHosts[0].host;
		int port = NetInfo.Instance.TcpHosts[0].port;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "开始建立TCP连接:";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("addr", host);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("port", port);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TcpHosts", NetInfo.Instance.TcpHosts.FormatNetHostInfo());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LoginTraceId", NetInfo.Instance.LoginTraceId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		this.KcpClient.OnTcpConnected.Add(new Action(this.OnTcpConnected));
		this.KcpClient.OnTcpConnectFailed.Add(new Action(this.OnTcpConnectFailed));
		this.KcpClient.StartTcpConnect(host, port);
		this.ConnectTimeoutTimer = TimerSystem.Instance.Delay(delegate(float id)
		{
			this.SetConnectResult(Net.EConnectResult.TCPConnectTimeOut);
		}, (float)this.ConnectTimeoutMsPerTry, null, null, true, 1f);
		NetInfo instance2 = NetInfo.Instance;
		int tcpRetry = instance2.TcpRetry;
		instance2.TcpRetry = tcpRetry + 1;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0001EB40 File Offset: 0x0001CD40
	private unsafe void OnTcpConnected()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "TCP连接建立成功:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TcpHosts", NetInfo.Instance.TcpHosts.FormatNetHostInfo());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LoginTraceId", NetInfo.Instance.LoginTraceId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (Net.Instance.KcpClient == null)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.LRX, "获取KCPConv失败,KCP实例不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KcpConvRequest message2 = new KcpConvRequest
		{
			LoginTraceId = NetInfo.Instance.LoginTraceId,
			DeviceId = NetInfo.Instance.DeviceId,
			UdpPort = this.ConnectServerPort,
			Token = NetInfo.Instance.Token
		};
		using (MessageSerializationBuffer buffer = MessageSerializationBuffer.GetBuffer(EMessageId.KcpConvRequest, message2))
		{
			fixed (byte* pinnableReference = buffer.MessageSpan.GetPinnableReference())
			{
				byte* data = pinnableReference;
				FArrayBuffer farrayBuffer = new FArrayBuffer
				{
					Data = (void*)data,
					Length = (ulong)((long)buffer.Length)
				};
				Net.Instance.KcpClient.SendTcpMessage(0, 3728, farrayBuffer);
			}
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0001ECA4 File Offset: 0x0001CEA4
	private void OnTcpConnectFailed()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Net;
		ELogAuthor author = ELogAuthor.LRX;
		string message = "TCP连接建立失败:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TcpHosts", NetInfo.Instance.TcpHosts.FormatNetHostInfo());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Net.Instance.SetConnectResult(Net.EConnectResult.TCPConnectFailed);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
	[NullableContext(0)]
	private unsafe void ProcessKcpConvResponseMessage(EMessageId messageId, Span<byte> bufferSpan)
	{
		KcpConvResponse kcpConvResponse = this.ParseToMessage(messageId, bufferSpan) as KcpConvResponse;
		if (kcpConvResponse == null || kcpConvResponse.Code != ErrorCode.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "TCP连接建立失败:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TcpHosts", NetInfo.Instance.TcpHosts.FormatNetHostInfo());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Code", (kcpConvResponse != null) ? new ErrorCode?(kcpConvResponse.Code) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.SetConnectResult(Net.EConnectResult.TCPConnectFailed);
			return;
		}
		uint conv = kcpConvResponse.Conv;
		this.KcpClient.CloseTcpConnect();
		this.KcpClient.RemoteMtu = (uint)kcpConvResponse.KcpMtu;
		this.KcpClient.HandleKcpConnect((uint)kcpConvResponse.CrcCheck, conv);
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
	public static Net Instance
	{
		get
		{
			if (Net._instance == null)
			{
				Net._instance = new Net();
				Net._instance.OnInit();
			}
			return Net._instance;
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0001EDFB File Offset: 0x0001CFFB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0001EDFD File Offset: 0x0001CFFD
	public static void ResetStaticDefaultValue()
	{
		Net instance = Net._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Net._instance = null;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0001EE16 File Offset: 0x0001D016
	static Net()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Net.CreateStaticDefaultValue), new Action(Net.ResetStaticDefaultValue));
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001EE40 File Offset: 0x0001D040
	public Net()
	{
		Dictionary<Net.EServerEncryptType, Net.EClientEncryptType> dictionary = new Dictionary<Net.EServerEncryptType, Net.EClientEncryptType>();
		dictionary[Net.EServerEncryptType.NoEncrypt] = Net.EClientEncryptType.NoEncrypt;
		dictionary[Net.EServerEncryptType.Aes] = Net.EClientEncryptType.Aes;
		this.s2cEncryptType = dictionary;
		this.UseBudget = true;
		this.ConnectServerIp = "";
		this.NotifyHandles = new Dictionary<ENotifyMessageId, Net.IMessageCallBack>();
		this.RequestLock = new HashSet<ERequestMessageId>();
		this.MessageCacheList = new global::LinkedList<Net.SendMessageCache>(Net.SendMessageCache.NullMessageCache);
		this.RequestMessageMap = new Dictionary<int, LinkedNode<Net.SendMessageCache>>();
		this.MessageIdNameMap = new Dictionary<EMessageId, string>();
		this.MessageIdStatMap = new Dictionary<EMessageId, Stat>();
		this.StatCall = Stat.Create("Net.Call", "", "");
		this.StatSend = Stat.Create("Net.SendInternal", "", "");
		this.CanTimeOutMessages = new HashSet<ERequestMessageId>();
		this.CallbackList = new global::LinkedList<Net.CallbackQueueItem>(new Net.CallbackQueueItem(delegate(Net.CallbackStatus status)
		{
		}, EMessageId.LoginRequest, true));
		this.StatAddRequestMask = Stat.Create("Net.AddRequestMask", "", "");
		this.StatRemoveRequestMask = Stat.Create("Net.RemoveRequestMask", "", "");
		this.StatEncode = Stat.Create("Net.Encode", "", "");
		base..ctor();
	}

	// Token: 0x04000470 RID: 1136
	public const bool ENABLE_NET_STAT = true;

	// Token: 0x04000471 RID: 1137
	public const bool ENABLE_NET_LOG = true;

	// Token: 0x04000472 RID: 1138
	public const bool ENABLE_HEARTBEAT_LOG = true;

	// Token: 0x04000473 RID: 1139
	public const bool ENABLE_SYNC_LOG = true;

	// Token: 0x04000474 RID: 1140
	public const bool ENABLE_MESSAGE_LOG = false;

	// Token: 0x04000475 RID: 1141
	private readonly Dictionary<Net.EServerEncryptType, Net.EClientEncryptType> s2cEncryptType;

	// Token: 0x04000476 RID: 1142
	private long LastReceiveTimeMsInternal;

	// Token: 0x04000477 RID: 1143
	public bool UseBudget;

	// Token: 0x04000478 RID: 1144
	[Nullable(2)]
	private UKuroKcpClient KcpClient;

	// Token: 0x04000479 RID: 1145
	[StaticVariableRuleIgnore]
	private static readonly Random SharedRandom = new Random();

	// Token: 0x0400047A RID: 1146
	[Nullable(2)]
	private Net.TConnectResultCallback ConnectCallback;

	// Token: 0x0400047B RID: 1147
	private string ConnectServerIp;

	// Token: 0x0400047C RID: 1148
	private int ConnectServerPort;

	// Token: 0x0400047D RID: 1149
	private int ConnectTimeoutMsPerTry;

	// Token: 0x0400047E RID: 1150
	[Nullable(2)]
	private TimerHandle ConnectTimeoutTimer;

	// Token: 0x0400047F RID: 1151
	private int ConnectRetryCount;

	// Token: 0x04000480 RID: 1152
	private int ConnectMaxRetryCount;

	// Token: 0x04000481 RID: 1153
	private readonly Dictionary<ENotifyMessageId, Net.IMessageCallBack> NotifyHandles;

	// Token: 0x04000482 RID: 1154
	private readonly HashSet<ERequestMessageId> RequestLock;

	// Token: 0x04000483 RID: 1155
	private readonly global::LinkedList<Net.SendMessageCache> MessageCacheList;

	// Token: 0x04000484 RID: 1156
	private readonly Dictionary<int, LinkedNode<Net.SendMessageCache>> RequestMessageMap;

	// Token: 0x04000485 RID: 1157
	private readonly Dictionary<EMessageId, string> MessageIdNameMap;

	// Token: 0x04000486 RID: 1158
	private readonly Dictionary<EMessageId, Stat> MessageIdStatMap;

	// Token: 0x04000487 RID: 1159
	private readonly Stat StatCall;

	// Token: 0x04000488 RID: 1160
	private readonly Stat StatSend;

	// Token: 0x04000489 RID: 1161
	private HashSet<ERequestMessageId> CanTimeOutMessages;

	// Token: 0x0400048A RID: 1162
	private short RpcId;

	// Token: 0x0400048B RID: 1163
	private int UpStreamSeqNo;

	// Token: 0x0400048C RID: 1164
	private int DownStreamSeqNo;

	// Token: 0x0400048D RID: 1165
	private Net.EKcpConnectStatus KcpConnectStatus;

	// Token: 0x0400048E RID: 1166
	private Net.EServerLoginState LoginState;

	// Token: 0x0400048F RID: 1167
	private bool IsReconnecting;

	// Token: 0x04000490 RID: 1168
	private bool IsNetLogEnabled;

	// Token: 0x04000491 RID: 1169
	private bool IsNetStatEnable;

	// Token: 0x04000492 RID: 1170
	private bool IsHeartLogEnabled;

	// Token: 0x04000493 RID: 1171
	private bool IsSyncLogEnabled;

	// Token: 0x04000494 RID: 1172
	private Net.TExceptionHandle ExceptionHandle;

	// Token: 0x04000495 RID: 1173
	private Action<int> AddRequestMaskHandle;

	// Token: 0x04000496 RID: 1174
	private Action<int> RemoveRequestMaskHandle;

	// Token: 0x04000497 RID: 1175
	private Net.TNetworkErrorHandle NetErrorHandle;

	// Token: 0x04000498 RID: 1176
	[Nullable(2)]
	private Net.CallbackQueueItem CurrentProcessedCallback;

	// Token: 0x04000499 RID: 1177
	private readonly global::LinkedList<Net.CallbackQueueItem> CallbackList;

	// Token: 0x0400049A RID: 1178
	private int NonePausedCallbackCount;

	// Token: 0x0400049B RID: 1179
	private bool IsNotifyCallbackPausedInternal;

	// Token: 0x0400049C RID: 1180
	private readonly Stat StatAddRequestMask;

	// Token: 0x0400049D RID: 1181
	private readonly Stat StatRemoveRequestMask;

	// Token: 0x0400049E RID: 1182
	private readonly Stat StatEncode;

	// Token: 0x0400049F RID: 1183
	[Nullable(2)]
	private static Net _instance;

	// Token: 0x020001AD RID: 429
	[NullableContext(0)]
	public enum EMsgTypeIndex
	{
		// Token: 0x0400080D RID: 2061
		Request,
		// Token: 0x0400080E RID: 2062
		Response
	}

	// Token: 0x020001AE RID: 430
	[NullableContext(2)]
	public interface IMessageCallBack
	{
		// Token: 0x06000D7A RID: 3450
		void Invoke(IMessage message, Net.CallbackStatus callbackStatus);
	}

	// Token: 0x020001AF RID: 431
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class MessageCallback : Net.IMessageCallBack
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x0003E8AE File Offset: 0x0003CAAE
		public MessageCallback(Action<IMessage, Net.CallbackStatus> callback)
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
		public void Invoke(IMessage message, Net.CallbackStatus callbackStatus)
		{
			try
			{
				Action<IMessage, Net.CallbackStatus> callback = this.Callback;
				if (callback != null)
				{
					callback(message, callbackStatus);
				}
			}
			catch (Exception ex) when (1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Net;
				ELogAuthor author = ELogAuthor.LRX;
				string message2 = "Callback执行异常:";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "声明类型";
				Action<IMessage, Net.CallbackStatus> callback2 = this.Callback;
				object item2;
				if (callback2 == null)
				{
					item2 = null;
				}
				else
				{
					Type declaringType = callback2.Method.DeclaringType;
					item2 = ((declaringType != null) ? declaringType.FullName : null);
				}
				ptr = new ValueTuple<string, object>(item, item2);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item3 = "方法:";
				Action<IMessage, Net.CallbackStatus> callback3 = this.Callback;
				ptr2 = new ValueTuple<string, object>(item3, (callback3 != null) ? callback3.Method.Name : null);
				instance.ErrorWithStack(module, author, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0400080F RID: 2063
		private readonly Action<IMessage, Net.CallbackStatus> Callback = callback;
	}

	// Token: 0x020001B0 RID: 432
	[NullableContext(0)]
	private enum EMessageType
	{
		// Token: 0x04000811 RID: 2065
		Request = 1,
		// Token: 0x04000812 RID: 2066
		Response,
		// Token: 0x04000813 RID: 2067
		Exception,
		// Token: 0x04000814 RID: 2068
		Push
	}

	// Token: 0x020001B1 RID: 433
	[NullableContext(0)]
	public enum EServerEncryptType
	{
		// Token: 0x04000816 RID: 2070
		NoEncrypt,
		// Token: 0x04000817 RID: 2071
		Aes = 2
	}

	// Token: 0x020001B2 RID: 434
	[NullableContext(0)]
	private enum EClientEncryptType
	{
		// Token: 0x04000819 RID: 2073
		Aes,
		// Token: 0x0400081A RID: 2074
		NoEncrypt,
		// Token: 0x0400081B RID: 2075
		Rsa
	}

	// Token: 0x020001B3 RID: 435
	[NullableContext(0)]
	private enum EKcpConnectStatus
	{
		// Token: 0x0400081D RID: 2077
		NoConnect,
		// Token: 0x0400081E RID: 2078
		Connecting,
		// Token: 0x0400081F RID: 2079
		Connected
	}

	// Token: 0x020001B4 RID: 436
	[NullableContext(0)]
	public enum EConnectResult
	{
		// Token: 0x04000821 RID: 2081
		Success,
		// Token: 0x04000822 RID: 2082
		Timeout,
		// Token: 0x04000823 RID: 2083
		Disconnect,
		// Token: 0x04000824 RID: 2084
		Other,
		// Token: 0x04000825 RID: 2085
		TCPConnectFailed,
		// Token: 0x04000826 RID: 2086
		TCPConnectTimeOut
	}

	// Token: 0x020001B5 RID: 437
	[NullableContext(0)]
	public enum EDisconnectReason
	{
		// Token: 0x04000828 RID: 2088
		Logout,
		// Token: 0x04000829 RID: 2089
		Reconnect,
		// Token: 0x0400082A RID: 2090
		LoginFail
	}

	// Token: 0x020001B6 RID: 438
	[NullableContext(0)]
	public class CallbackStatus
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x0003E998 File Offset: 0x0003CB98
		public CallbackStatus(EMessageId messageId)
		{
			this.CallbackMessageId = messageId;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0003E9AE File Offset: 0x0003CBAE
		public EMessageId MessageId
		{
			get
			{
				return this.CallbackMessageId;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0003E9B6 File Offset: 0x0003CBB6
		public bool IsJobFinished
		{
			get
			{
				return this.IsFinished;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0003E9BE File Offset: 0x0003CBBE
		public int CallbackCount
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0003E9C6 File Offset: 0x0003CBC6
		public void IncrementCount()
		{
			this.Count++;
		}

		// Token: 0x0400082B RID: 2091
		[Nullable(2)]
		public object UserData;

		// Token: 0x0400082C RID: 2092
		public bool IsFinished = true;

		// Token: 0x0400082D RID: 2093
		private int Count;

		// Token: 0x0400082E RID: 2094
		private readonly EMessageId CallbackMessageId;
	}

	// Token: 0x020001B7 RID: 439
	// (Invoke) Token: 0x06000D83 RID: 3459
	[NullableContext(0)]
	public delegate void WrappedCallback(Net.CallbackStatus status);

	// Token: 0x020001B8 RID: 440
	[NullableContext(2)]
	[Nullable(0)]
	private class CallbackQueueItem
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		[NullableContext(1)]
		public CallbackQueueItem(Net.WrappedCallback callback, EMessageId messageId, bool isPaused)
		{
			this.Status = new Net.CallbackStatus(messageId);
			this.IsPausedInternal = isPaused;
			this.MessageId = messageId;
			this.ReceivedTimeMs = 0L;
			this.RequestId = null;
			this.RpcId = null;
			this.Handle = null;
			this.Message = null;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0003EA34 File Offset: 0x0003CC34
		public CallbackQueueItem(EMessageId messageId, bool isPaused, long receivedTimeMs, ERequestMessageId? requestId, int? rpcId, Net.IMessageCallBack handle, IMessage message)
		{
			this.Status = new Net.CallbackStatus(messageId);
			this.IsPausedInternal = isPaused;
			this.MessageId = messageId;
			this.ReceivedTimeMs = receivedTimeMs;
			this.RequestId = requestId;
			this.RpcId = rpcId;
			this.Handle = handle;
			this.Message = message;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0003EA88 File Offset: 0x0003CC88
		public unsafe bool DoCallback()
		{
			Stat stat = null;
			if (Net.Instance.IsNetStatEnable)
			{
				Net.Instance.MessageIdStatMap.TryGetValue(this.MessageId, out stat);
			}
			if (Net.Instance.IsNetLogEnabled && this.Status.CallbackCount == 0)
			{
				long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.ReceivedTimeMs;
				if (num > 67L)
				{
					string item;
					Net.Instance.MessageIdNameMap.TryGetValue(this.MessageId, out item);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Net;
					ELogAuthor author = ELogAuthor.MZJ;
					string message = "callback exceeds limit";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("delay", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("msg", item);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			try
			{
				if (this.Status.CallbackCount == 0 && this.RequestId != null && (NetDefine.ProtoConfig[(EMessageId)this.RequestId.Value] & 4) == 4)
				{
					Action<int> removeRequestMaskHandle = Net.Instance.RemoveRequestMaskHandle;
					if (removeRequestMaskHandle != null)
					{
						removeRequestMaskHandle(this.RpcId.GetValueOrDefault(0));
					}
				}
				Net.IMessageCallBack handle = this.Handle;
				if (handle != null)
				{
					handle.Invoke(this.Message, this.Status);
				}
			}
			catch (Exception ex) when (1)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Net;
				ELogAuthor author2 = ELogAuthor.MZJ;
				string message2 = "callback执行异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("messageId", this.MessageId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance2.ErrorWithStack(module2, author2, message2, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			finally
			{
				this.Status.IncrementCount();
			}
			return this.Status.IsJobFinished;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0003EC90 File Offset: 0x0003CE90
		public bool IsPaused()
		{
			return this.IsPausedInternal;
		}

		// Token: 0x0400082F RID: 2095
		[Nullable(1)]
		private readonly Net.CallbackStatus Status;

		// Token: 0x04000830 RID: 2096
		private readonly bool IsPausedInternal;

		// Token: 0x04000831 RID: 2097
		private readonly EMessageId MessageId;

		// Token: 0x04000832 RID: 2098
		private readonly long ReceivedTimeMs;

		// Token: 0x04000833 RID: 2099
		private readonly ERequestMessageId? RequestId;

		// Token: 0x04000834 RID: 2100
		private readonly int? RpcId;

		// Token: 0x04000835 RID: 2101
		private readonly Net.IMessageCallBack Handle;

		// Token: 0x04000836 RID: 2102
		private readonly IMessage Message;
	}

	// Token: 0x020001B9 RID: 441
	[NullableContext(0)]
	public enum EServerLoginState
	{
		// Token: 0x04000838 RID: 2104
		NoLogin,
		// Token: 0x04000839 RID: 2105
		AskingProtoKey,
		// Token: 0x0400083A RID: 2106
		ProtoKeyReady,
		// Token: 0x0400083B RID: 2107
		DoingLogin,
		// Token: 0x0400083C RID: 2108
		FinishedLogin,
		// Token: 0x0400083D RID: 2109
		Logout
	}

	// Token: 0x020001BA RID: 442
	[NullableContext(0)]
	private enum EKcpErrorCodeLevel1
	{
		// Token: 0x0400083F RID: 2111
		NoError,
		// Token: 0x04000840 RID: 2112
		SocketReceiveError,
		// Token: 0x04000841 RID: 2113
		PayloadError,
		// Token: 0x04000842 RID: 2114
		DecryptError,
		// Token: 0x04000843 RID: 2115
		KcpRecvError
	}

	// Token: 0x020001BB RID: 443
	[NullableContext(0)]
	private enum EKcpConnectError
	{
		// Token: 0x04000845 RID: 2117
		CrcCheckError = -4
	}

	// Token: 0x020001BC RID: 444
	[NullableContext(0)]
	private enum ESocketErrors
	{
		// Token: 0x04000847 RID: 2119
		SE_NO_ERROR
	}

	// Token: 0x020001BD RID: 445
	[NullableContext(0)]
	public class SendMessageCache : IDisposable
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0003EC98 File Offset: 0x0003CE98
		public Span<byte> EncodeMessage
		{
			get
			{
				if (this.EncodeMessageBuffer == null)
				{
					return Span<byte>.Empty;
				}
				return new Span<byte>(this.EncodeMessageBuffer, 0, this.MessageSize);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		public SendMessageCache(int? rpcId, int? seqNo, EMessageId? id, Span<byte> encodeMessage, [Nullable(2)] Net.IMessageCallBack handle)
		{
			this.RpcId = rpcId.GetValueOrDefault();
			this.SeqNo = seqNo.GetValueOrDefault();
			this.MessageId = id.GetValueOrDefault();
			if (!encodeMessage.IsEmpty)
			{
				this.EncodeMessageBuffer = ArrayPool<byte>.Shared.Rent(encodeMessage.Length);
				this.MessageSize = encodeMessage.Length;
				encodeMessage.CopyTo(this.EncodeMessageBuffer);
			}
			this.Handle = handle;
			this.SendTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			this.TimeoutHandle = null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0003ED57 File Offset: 0x0003CF57
		public void ClearHandle()
		{
			this.Handle = null;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0003ED60 File Offset: 0x0003CF60
		public void Dispose()
		{
			if (this.EncodeMessageBuffer != null)
			{
				ArrayPool<byte>.Shared.Return(this.EncodeMessageBuffer, false);
				this.EncodeMessageBuffer = null;
				this.MessageSize = 0;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		[NullableContext(1)]
		public static void DisposeAndRemoveBefore(global::LinkedList<Net.SendMessageCache> list, LinkedNode<Net.SendMessageCache> node, bool includeThis)
		{
			Net.SendMessageCache element = node.Element;
			if (element == null || !element.InList)
			{
				return;
			}
			LinkedNode<Net.SendMessageCache> linkedNode = list.GetHeadNextNode();
			while (linkedNode != null && linkedNode != node)
			{
				Net.SendMessageCache element2 = linkedNode.Element;
				if (element2 != null)
				{
					element2.Dispose();
				}
				if (linkedNode.Element != null)
				{
					linkedNode.Element.InList = false;
				}
				linkedNode = linkedNode.Next;
			}
			if (includeThis)
			{
				Net.SendMessageCache element3 = node.Element;
				if (element3 != null)
				{
					element3.Dispose();
				}
				node.Element.InList = false;
			}
			list.RemoveNodesBeforeThis(node, includeThis);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0003EE14 File Offset: 0x0003D014
		[NullableContext(1)]
		public static void DisposeAllAndClear(global::LinkedList<Net.SendMessageCache> list)
		{
			for (LinkedNode<Net.SendMessageCache> linkedNode = list.GetHeadNextNode(); linkedNode != null; linkedNode = linkedNode.Next)
			{
				Net.SendMessageCache element = linkedNode.Element;
				if (element != null)
				{
					element.Dispose();
				}
				if (linkedNode.Element != null)
				{
					linkedNode.Element.InList = false;
				}
			}
			list.RemoveAllNodeWithoutHead();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0003EE5F File Offset: 0x0003D05F
		[Nullable(1)]
		public static Net.SendMessageCache NullMessageCache { [NullableContext(1)] get; } = new Net.SendMessageCache(null, null, null, null, null);

		// Token: 0x04000848 RID: 2120
		public int RpcId;

		// Token: 0x04000849 RID: 2121
		public int SeqNo;

		// Token: 0x0400084A RID: 2122
		public EMessageId MessageId;

		// Token: 0x0400084B RID: 2123
		[Nullable(2)]
		private byte[] EncodeMessageBuffer;

		// Token: 0x0400084C RID: 2124
		private int MessageSize;

		// Token: 0x0400084D RID: 2125
		public long SendTimeMs;

		// Token: 0x0400084E RID: 2126
		[Nullable(2)]
		public TimerHandle TimeoutHandle;

		// Token: 0x0400084F RID: 2127
		[Nullable(2)]
		public Net.IMessageCallBack Handle;

		// Token: 0x04000850 RID: 2128
		public bool InList;
	}

	// Token: 0x020001BE RID: 446
	// (Invoke) Token: 0x06000D93 RID: 3475
	[NullableContext(0)]
	public delegate void TExceptionHandle(int rpcId, int errorCode, int messageId, [Nullable(2)] object message, string errorMessage);

	// Token: 0x020001BF RID: 447
	// (Invoke) Token: 0x06000D97 RID: 3479
	[NullableContext(0)]
	public delegate void TConnectResultCallback(Net.EConnectResult result);

	// Token: 0x020001C0 RID: 448
	// (Invoke) Token: 0x06000D9B RID: 3483
	[NullableContext(0)]
	public delegate void TNetworkErrorHandle(int errorCode);
}
