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

// Token: 0x020000B2 RID: 178
[NullableContext(1)]
[Nullable(0)]
public class Net : Singleton
{
	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x0001C4D3 File Offset: 0x0001A6D3
	public float RttMs
	{
		get
		{
			return NetInfo.Instance.RttMs;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001C4DF File Offset: 0x0001A6DF
	public float LastReceiveTimeMs
	{
		get
		{
			return (float)this.LastReceiveTimeMsInternal;
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
	public void StartReconnecting()
	{
		this.IsReconnecting = true;
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0001C4F1 File Offset: 0x0001A6F1
	private void EndReconnecting()
	{
		this.IsReconnecting = false;
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0001C4FA File Offset: 0x0001A6FA
	public bool IsServerConnected()
	{
		return this.IsReconnecting || this.LoginState == Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001C50F File Offset: 0x0001A70F
	public bool IsFinishLogin()
	{
		return this.LoginState == Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0001C51A File Offset: 0x0001A71A
	public void ChangeState1()
	{
		this.LoginState = Net.EServerLoginState.AskingProtoKey;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001C523 File Offset: 0x0001A723
	private void ChangeStateKeyReady()
	{
		if (this.LoginState != Net.EServerLoginState.AskingProtoKey)
		{
			this.PrintChangeStateError(Net.EServerLoginState.ProtoKeyReady);
		}
		this.LoginState = Net.EServerLoginState.ProtoKeyReady;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0001C53C File Offset: 0x0001A73C
	private bool IsProtoKeyReady()
	{
		return this.LoginState >= Net.EServerLoginState.ProtoKeyReady && this.LoginState <= Net.EServerLoginState.FinishedLogin;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0001C555 File Offset: 0x0001A755
	public void ChangeStateEnterGame()
	{
		if (this.LoginState != Net.EServerLoginState.ProtoKeyReady && this.LoginState != Net.EServerLoginState.DoingLogin)
		{
			this.PrintChangeStateError(Net.EServerLoginState.DoingLogin);
		}
		this.LoginState = Net.EServerLoginState.DoingLogin;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001C577 File Offset: 0x0001A777
	private void ChangeStateFinishLogin()
	{
		if (this.LoginState != Net.EServerLoginState.DoingLogin)
		{
			this.PrintChangeStateError(Net.EServerLoginState.FinishedLogin);
		}
		this.LoginState = Net.EServerLoginState.FinishedLogin;
		this.EndReconnecting();
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0001C596 File Offset: 0x0001A796
	public bool IsNotifyCallbackPaused()
	{
		return this.IsNotifyCallbackPausedInternal;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
	public void PauseAllNotifyCallback()
	{
		this.IsNotifyCallbackPausedInternal = true;
		Log.Instance.Info(ELogModule.Net, ELogAuthor.MZJ, "暂停消息处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
	public void ResumeAllNotifyCallback()
	{
		this.IsNotifyCallbackPausedInternal = false;
		Log.Instance.Info(ELogModule.Net, ELogAuthor.MZJ, "恢复消息处理", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0001C600 File Offset: 0x0001A800
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

	// Token: 0x0600055F RID: 1375 RVA: 0x0001C66F File Offset: 0x0001A86F
	public void SetNetworkErrorHandle(Net.TNetworkErrorHandle handle)
	{
		this.NetErrorHandle = handle;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0001C678 File Offset: 0x0001A878
	public void SetExceptionHandle(Net.TExceptionHandle handle)
	{
		this.ExceptionHandle = handle;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001C681 File Offset: 0x0001A881
	public void SetAddRequestMaskHandle(Action<int> handle)
	{
		this.AddRequestMaskHandle = handle;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001C68A File Offset: 0x0001A88A
	public void SetRemoveRequestMaskHandle(Action<int> handle)
	{
		this.RemoveRequestMaskHandle = handle;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0001C694 File Offset: 0x0001A894
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
		if (!Info.Instance.IsBuildShipping)
		{
			this.IsNetLogEnabled = true;
			this.IsNetStatEnable = true;
			this.IsHeartLogEnabled = true;
			this.IsSyncLogEnabled = true;
			this.KcpClient.OpenSendVerify = true;
		}
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

	// Token: 0x06000564 RID: 1380 RVA: 0x0001C8EA File Offset: 0x0001AAEA
	public void Tick(float deltaTime)
	{
		if (this.KcpClient != null)
		{
			this.KcpClient.TickOutside(deltaTime);
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001C900 File Offset: 0x0001AB00
	public void InitCanTimerOutMessage(HashSet<ERequestMessageId> messageIdsSet)
	{
		this.CanTimeOutMessages = messageIdsSet;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0001C909 File Offset: 0x0001AB09
	private bool IsCacheQueueEmpty()
	{
		return this.CallbackList.Count == 0 || (this.IsNotifyCallbackPausedInternal && this.NonePausedCallbackCount == 0);
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0001C92D File Offset: 0x0001AB2D
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

	// Token: 0x06000568 RID: 1384 RVA: 0x0001C950 File Offset: 0x0001AB50
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

	// Token: 0x06000569 RID: 1385 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
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

	// Token: 0x0600056A RID: 1386 RVA: 0x0001CA4C File Offset: 0x0001AC4C
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

	// Token: 0x0600056B RID: 1387 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
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

	// Token: 0x0600056C RID: 1388 RVA: 0x0001CB30 File Offset: 0x0001AD30
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

	// Token: 0x0600056D RID: 1389 RVA: 0x0001CBAD File Offset: 0x0001ADAD
	public int GetDownStreamSeqNo()
	{
		return this.DownStreamSeqNo;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
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

	// Token: 0x0600056F RID: 1391 RVA: 0x0001CC91 File Offset: 0x0001AE91
	public int GetUnVerifiedMessageCount()
	{
		return this.MessageCacheList.Count;
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001CCA0 File Offset: 0x0001AEA0
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

	// Token: 0x06000571 RID: 1393 RVA: 0x0001CF08 File Offset: 0x0001B108
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

	// Token: 0x06000572 RID: 1394 RVA: 0x0001CF64 File Offset: 0x0001B164
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

	// Token: 0x06000573 RID: 1395 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
	public void Send(EPushMessageId pushMessageId, IMessage message)
	{
		if (!this.IsPassLoginCheck((EMessageId)pushMessageId))
		{
			return;
		}
		this.EncodeAddToCacheAndSend(Net.EMessageType.Push, (EMessageId)pushMessageId, message, null, null);
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0001CFDC File Offset: 0x0001B1DC
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

	// Token: 0x06000575 RID: 1397 RVA: 0x0001D06C File Offset: 0x0001B26C
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

	// Token: 0x06000576 RID: 1398 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
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

	// Token: 0x06000577 RID: 1399 RVA: 0x0001D1BC File Offset: 0x0001B3BC
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

	// Token: 0x06000578 RID: 1400 RVA: 0x0001D26C File Offset: 0x0001B46C
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

	// Token: 0x06000579 RID: 1401 RVA: 0x0001D320 File Offset: 0x0001B520
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

	// Token: 0x0600057A RID: 1402 RVA: 0x0001D36A File Offset: 0x0001B56A
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

	// Token: 0x0600057B RID: 1403 RVA: 0x0001D392 File Offset: 0x0001B592
	private bool CanKcpConnect()
	{
		return this.KcpConnectStatus == Net.EKcpConnectStatus.NoConnect;
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
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

	// Token: 0x0600057D RID: 1405 RVA: 0x0001D409 File Offset: 0x0001B609
	private bool IsReconnectControlMessage(ERequestMessageId messageId)
	{
		return messageId == ERequestMessageId.ProtoKeyRequest || messageId == ERequestMessageId.ReconnectRequest;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001D417 File Offset: 0x0001B617
	private bool CacheDueToReconnecting(int messageId)
	{
		return this.IsReconnecting && !this.IsReconnectControlMessage((ERequestMessageId)messageId);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0001D430 File Offset: 0x0001B630
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

	// Token: 0x06000580 RID: 1408 RVA: 0x0001D54C File Offset: 0x0001B74C
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

	// Token: 0x06000581 RID: 1409 RVA: 0x0001D588 File Offset: 0x0001B788
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

	// Token: 0x06000582 RID: 1410 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
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

	// Token: 0x06000583 RID: 1411 RVA: 0x0001D656 File Offset: 0x0001B856
	private LinkedNode<Net.SendMessageCache> AddToMessageCache(Net.SendMessageCache messageCache)
	{
		bool isNetLogEnabled = this.IsNetLogEnabled;
		messageCache.InList = true;
		return this.MessageCacheList.AddTail(messageCache);
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0001D672 File Offset: 0x0001B872
	private void SaveCallbackAndLockRequest(ERequestMessageId requestMessageId, LinkedNode<Net.SendMessageCache> node)
	{
		this.RequestMessageMap[node.Element.RpcId] = node;
		if ((NetDefine.ProtoConfig[(EMessageId)requestMessageId] & 8) == 8)
		{
			this.RequestLock.Add(requestMessageId);
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0001D6A8 File Offset: 0x0001B8A8
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

	// Token: 0x06000586 RID: 1414 RVA: 0x0001D71B File Offset: 0x0001B91B
	private bool IsMsgUseBuiltinEncrypt(EMessageId msgId)
	{
		return msgId == EMessageId.ProtoKeyRequest;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0001D728 File Offset: 0x0001B928
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

	// Token: 0x06000588 RID: 1416 RVA: 0x0001D774 File Offset: 0x0001B974
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

	// Token: 0x06000589 RID: 1417 RVA: 0x0001D834 File Offset: 0x0001BA34
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

	// Token: 0x0600058A RID: 1418 RVA: 0x0001D994 File Offset: 0x0001BB94
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

	// Token: 0x0600058B RID: 1419 RVA: 0x0001D9E9 File Offset: 0x0001BBE9
	private void OnReceiveResponse(int seqNo, short rpcId, ushort messageId, FArrayBuffer messageBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Response, seqNo, (int)messageId, messageBuffer, new int?((int)rpcId), false);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0001D9FE File Offset: 0x0001BBFE
	private void OnReceiveException(int seqNo, short rpcId, uint errorCode, FArrayBuffer stringBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Exception, seqNo, (int)errorCode, stringBuffer, new int?((int)rpcId), false);
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0001DA14 File Offset: 0x0001BC14
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

	// Token: 0x0600058E RID: 1422 RVA: 0x0001DA90 File Offset: 0x0001BC90
	private void OnReceivePush(int seqNo, ushort messageId, FArrayBuffer messageBuffer)
	{
		this.ProcessReceiveMessage(Net.EMessageType.Push, seqNo, (int)messageId, messageBuffer, null, false);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
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

	// Token: 0x06000590 RID: 1424 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
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

	// Token: 0x06000591 RID: 1425 RVA: 0x0001DF50 File Offset: 0x0001C150
	private void CleanMessageCaches()
	{
		this.RequestLock.Clear();
		this.RequestMessageMap.Clear();
		Net.SendMessageCache.DisposeAllAndClear(this.MessageCacheList);
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0001DF74 File Offset: 0x0001C174
	private void LogNet(int id, int seqNo, int? rpcId, object message)
	{
		if (!this.IsHeartLogEnabled && (id == 1650 || id == 1651 || id == 15194))
		{
			return;
		}
		if (id == 24756 || id == 17992 || id == 24978 || id == 25437 || id == 24276 || id == 17230 || id == 28306 || id == 17250 || id == 20474)
		{
			return;
		}
		if (!this.IsSyncLogEnabled && (id == 16475 || id == 16407 || id == 17782 || id == 21027 || id == 27094 || id == 16509 || id == 19470 || id == 25706 || id == 18163))
		{
			return;
		}
		int num = message.GetType().GetProperties().Length;
		bool isNetLogEnabled = this.IsNetLogEnabled;
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001E054 File Offset: 0x0001C254
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

	// Token: 0x06000594 RID: 1428 RVA: 0x0001E120 File Offset: 0x0001C320
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

	// Token: 0x06000595 RID: 1429 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
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

	// Token: 0x06000596 RID: 1430 RVA: 0x0001E49C File Offset: 0x0001C69C
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

	// Token: 0x06000597 RID: 1431 RVA: 0x0001E600 File Offset: 0x0001C800
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

	// Token: 0x06000598 RID: 1432 RVA: 0x0001E650 File Offset: 0x0001C850
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

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001E734 File Offset: 0x0001C934
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

	// Token: 0x0600059A RID: 1434 RVA: 0x0001E757 File Offset: 0x0001C957
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0001E759 File Offset: 0x0001C959
	public static void ResetStaticDefaultValue()
	{
		Net instance = Net._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Net._instance = null;
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0001E772 File Offset: 0x0001C972
	static Net()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Net.CreateStaticDefaultValue), new Action(Net.ResetStaticDefaultValue));
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0001E79C File Offset: 0x0001C99C
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

	// Token: 0x04000462 RID: 1122
	public const bool ENABLE_NET_STAT = true;

	// Token: 0x04000463 RID: 1123
	public const bool ENABLE_NET_LOG = true;

	// Token: 0x04000464 RID: 1124
	public const bool ENABLE_HEARTBEAT_LOG = true;

	// Token: 0x04000465 RID: 1125
	public const bool ENABLE_SYNC_LOG = true;

	// Token: 0x04000466 RID: 1126
	public const bool ENABLE_MESSAGE_LOG = false;

	// Token: 0x04000467 RID: 1127
	private readonly Dictionary<Net.EServerEncryptType, Net.EClientEncryptType> s2cEncryptType;

	// Token: 0x04000468 RID: 1128
	private long LastReceiveTimeMsInternal;

	// Token: 0x04000469 RID: 1129
	public bool UseBudget;

	// Token: 0x0400046A RID: 1130
	[Nullable(2)]
	private UKuroKcpClient KcpClient;

	// Token: 0x0400046B RID: 1131
	[StaticVariableRuleIgnore]
	private static readonly Random SharedRandom = new Random();

	// Token: 0x0400046C RID: 1132
	[Nullable(2)]
	private Net.TConnectResultCallback ConnectCallback;

	// Token: 0x0400046D RID: 1133
	private string ConnectServerIp;

	// Token: 0x0400046E RID: 1134
	private int ConnectServerPort;

	// Token: 0x0400046F RID: 1135
	private int ConnectTimeoutMsPerTry;

	// Token: 0x04000470 RID: 1136
	[Nullable(2)]
	private TimerHandle ConnectTimeoutTimer;

	// Token: 0x04000471 RID: 1137
	private int ConnectRetryCount;

	// Token: 0x04000472 RID: 1138
	private int ConnectMaxRetryCount;

	// Token: 0x04000473 RID: 1139
	private readonly Dictionary<ENotifyMessageId, Net.IMessageCallBack> NotifyHandles;

	// Token: 0x04000474 RID: 1140
	private readonly HashSet<ERequestMessageId> RequestLock;

	// Token: 0x04000475 RID: 1141
	private readonly global::LinkedList<Net.SendMessageCache> MessageCacheList;

	// Token: 0x04000476 RID: 1142
	private readonly Dictionary<int, LinkedNode<Net.SendMessageCache>> RequestMessageMap;

	// Token: 0x04000477 RID: 1143
	private readonly Dictionary<EMessageId, string> MessageIdNameMap;

	// Token: 0x04000478 RID: 1144
	private readonly Dictionary<EMessageId, Stat> MessageIdStatMap;

	// Token: 0x04000479 RID: 1145
	private readonly Stat StatCall;

	// Token: 0x0400047A RID: 1146
	private readonly Stat StatSend;

	// Token: 0x0400047B RID: 1147
	private HashSet<ERequestMessageId> CanTimeOutMessages;

	// Token: 0x0400047C RID: 1148
	private short RpcId;

	// Token: 0x0400047D RID: 1149
	private int UpStreamSeqNo;

	// Token: 0x0400047E RID: 1150
	private int DownStreamSeqNo;

	// Token: 0x0400047F RID: 1151
	private Net.EKcpConnectStatus KcpConnectStatus;

	// Token: 0x04000480 RID: 1152
	private Net.EServerLoginState LoginState;

	// Token: 0x04000481 RID: 1153
	private bool IsReconnecting;

	// Token: 0x04000482 RID: 1154
	private bool IsNetLogEnabled;

	// Token: 0x04000483 RID: 1155
	private bool IsNetStatEnable;

	// Token: 0x04000484 RID: 1156
	private bool IsHeartLogEnabled;

	// Token: 0x04000485 RID: 1157
	private bool IsSyncLogEnabled;

	// Token: 0x04000486 RID: 1158
	private Net.TExceptionHandle ExceptionHandle;

	// Token: 0x04000487 RID: 1159
	private Action<int> AddRequestMaskHandle;

	// Token: 0x04000488 RID: 1160
	private Action<int> RemoveRequestMaskHandle;

	// Token: 0x04000489 RID: 1161
	private Net.TNetworkErrorHandle NetErrorHandle;

	// Token: 0x0400048A RID: 1162
	[Nullable(2)]
	private Net.CallbackQueueItem CurrentProcessedCallback;

	// Token: 0x0400048B RID: 1163
	private readonly global::LinkedList<Net.CallbackQueueItem> CallbackList;

	// Token: 0x0400048C RID: 1164
	private int NonePausedCallbackCount;

	// Token: 0x0400048D RID: 1165
	private bool IsNotifyCallbackPausedInternal;

	// Token: 0x0400048E RID: 1166
	private readonly Stat StatAddRequestMask;

	// Token: 0x0400048F RID: 1167
	private readonly Stat StatRemoveRequestMask;

	// Token: 0x04000490 RID: 1168
	private readonly Stat StatEncode;

	// Token: 0x04000491 RID: 1169
	[Nullable(2)]
	private static Net _instance;

	// Token: 0x020001A7 RID: 423
	[NullableContext(0)]
	public enum EMsgTypeIndex
	{
		// Token: 0x040007E8 RID: 2024
		Request,
		// Token: 0x040007E9 RID: 2025
		Response
	}

	// Token: 0x020001A8 RID: 424
	[NullableContext(2)]
	public interface IMessageCallBack
	{
		// Token: 0x06000D0F RID: 3343
		void Invoke(IMessage message, Net.CallbackStatus callbackStatus);
	}

	// Token: 0x020001A9 RID: 425
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class MessageCallback : Net.IMessageCallBack
	{
		// Token: 0x06000D10 RID: 3344 RVA: 0x0003D9DA File Offset: 0x0003BBDA
		public MessageCallback(Action<IMessage, Net.CallbackStatus> callback)
		{
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0003D9EC File Offset: 0x0003BBEC
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

		// Token: 0x040007EA RID: 2026
		private readonly Action<IMessage, Net.CallbackStatus> Callback = callback;
	}

	// Token: 0x020001AA RID: 426
	[NullableContext(0)]
	private enum EMessageType
	{
		// Token: 0x040007EC RID: 2028
		Request = 1,
		// Token: 0x040007ED RID: 2029
		Response,
		// Token: 0x040007EE RID: 2030
		Exception,
		// Token: 0x040007EF RID: 2031
		Push
	}

	// Token: 0x020001AB RID: 427
	[NullableContext(0)]
	public enum EServerEncryptType
	{
		// Token: 0x040007F1 RID: 2033
		NoEncrypt,
		// Token: 0x040007F2 RID: 2034
		Aes = 2
	}

	// Token: 0x020001AC RID: 428
	[NullableContext(0)]
	private enum EClientEncryptType
	{
		// Token: 0x040007F4 RID: 2036
		Aes,
		// Token: 0x040007F5 RID: 2037
		NoEncrypt,
		// Token: 0x040007F6 RID: 2038
		Rsa
	}

	// Token: 0x020001AD RID: 429
	[NullableContext(0)]
	private enum EKcpConnectStatus
	{
		// Token: 0x040007F8 RID: 2040
		NoConnect,
		// Token: 0x040007F9 RID: 2041
		Connecting,
		// Token: 0x040007FA RID: 2042
		Connected
	}

	// Token: 0x020001AE RID: 430
	[NullableContext(0)]
	public enum EConnectResult
	{
		// Token: 0x040007FC RID: 2044
		Success,
		// Token: 0x040007FD RID: 2045
		Timeout,
		// Token: 0x040007FE RID: 2046
		Disconnect,
		// Token: 0x040007FF RID: 2047
		Other,
		// Token: 0x04000800 RID: 2048
		TCPConnectFailed,
		// Token: 0x04000801 RID: 2049
		TCPConnectTimeOut
	}

	// Token: 0x020001AF RID: 431
	[NullableContext(0)]
	public enum EDisconnectReason
	{
		// Token: 0x04000803 RID: 2051
		Logout,
		// Token: 0x04000804 RID: 2052
		Reconnect,
		// Token: 0x04000805 RID: 2053
		LoginFail
	}

	// Token: 0x020001B0 RID: 432
	[NullableContext(0)]
	public class CallbackStatus
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
		public CallbackStatus(EMessageId messageId)
		{
			this.CallbackMessageId = messageId;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0003DADA File Offset: 0x0003BCDA
		public EMessageId MessageId
		{
			get
			{
				return this.CallbackMessageId;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003DAE2 File Offset: 0x0003BCE2
		public bool IsJobFinished
		{
			get
			{
				return this.IsFinished;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0003DAEA File Offset: 0x0003BCEA
		public int CallbackCount
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0003DAF2 File Offset: 0x0003BCF2
		public void IncrementCount()
		{
			this.Count++;
		}

		// Token: 0x04000806 RID: 2054
		[Nullable(2)]
		public object UserData;

		// Token: 0x04000807 RID: 2055
		public bool IsFinished = true;

		// Token: 0x04000808 RID: 2056
		private int Count;

		// Token: 0x04000809 RID: 2057
		private readonly EMessageId CallbackMessageId;
	}

	// Token: 0x020001B1 RID: 433
	// (Invoke) Token: 0x06000D18 RID: 3352
	[NullableContext(0)]
	public delegate void WrappedCallback(Net.CallbackStatus status);

	// Token: 0x020001B2 RID: 434
	[NullableContext(2)]
	[Nullable(0)]
	private class CallbackQueueItem
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0003DB04 File Offset: 0x0003BD04
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x0003DB60 File Offset: 0x0003BD60
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

		// Token: 0x06000D1D RID: 3357 RVA: 0x0003DBB4 File Offset: 0x0003BDB4
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

		// Token: 0x06000D1E RID: 3358 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		public bool IsPaused()
		{
			return this.IsPausedInternal;
		}

		// Token: 0x0400080A RID: 2058
		[Nullable(1)]
		private readonly Net.CallbackStatus Status;

		// Token: 0x0400080B RID: 2059
		private readonly bool IsPausedInternal;

		// Token: 0x0400080C RID: 2060
		private readonly EMessageId MessageId;

		// Token: 0x0400080D RID: 2061
		private readonly long ReceivedTimeMs;

		// Token: 0x0400080E RID: 2062
		private readonly ERequestMessageId? RequestId;

		// Token: 0x0400080F RID: 2063
		private readonly int? RpcId;

		// Token: 0x04000810 RID: 2064
		private readonly Net.IMessageCallBack Handle;

		// Token: 0x04000811 RID: 2065
		private readonly IMessage Message;
	}

	// Token: 0x020001B3 RID: 435
	[NullableContext(0)]
	public enum EServerLoginState
	{
		// Token: 0x04000813 RID: 2067
		NoLogin,
		// Token: 0x04000814 RID: 2068
		AskingProtoKey,
		// Token: 0x04000815 RID: 2069
		ProtoKeyReady,
		// Token: 0x04000816 RID: 2070
		DoingLogin,
		// Token: 0x04000817 RID: 2071
		FinishedLogin,
		// Token: 0x04000818 RID: 2072
		Logout
	}

	// Token: 0x020001B4 RID: 436
	[NullableContext(0)]
	private enum EKcpErrorCodeLevel1
	{
		// Token: 0x0400081A RID: 2074
		NoError,
		// Token: 0x0400081B RID: 2075
		SocketReceiveError,
		// Token: 0x0400081C RID: 2076
		PayloadError,
		// Token: 0x0400081D RID: 2077
		DecryptError,
		// Token: 0x0400081E RID: 2078
		KcpRecvError
	}

	// Token: 0x020001B5 RID: 437
	[NullableContext(0)]
	private enum EKcpConnectError
	{
		// Token: 0x04000820 RID: 2080
		CrcCheckError = -4
	}

	// Token: 0x020001B6 RID: 438
	[NullableContext(0)]
	private enum ESocketErrors
	{
		// Token: 0x04000822 RID: 2082
		SE_NO_ERROR
	}

	// Token: 0x020001B7 RID: 439
	[NullableContext(0)]
	public class SendMessageCache : IDisposable
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
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

		// Token: 0x06000D20 RID: 3360 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
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

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003DE83 File Offset: 0x0003C083
		public void ClearHandle()
		{
			this.Handle = null;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003DE8C File Offset: 0x0003C08C
		public void Dispose()
		{
			if (this.EncodeMessageBuffer != null)
			{
				ArrayPool<byte>.Shared.Return(this.EncodeMessageBuffer, false);
				this.EncodeMessageBuffer = null;
				this.MessageSize = 0;
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
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

		// Token: 0x06000D24 RID: 3364 RVA: 0x0003DF40 File Offset: 0x0003C140
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0003DF8B File Offset: 0x0003C18B
		[Nullable(1)]
		public static Net.SendMessageCache NullMessageCache { [NullableContext(1)] get; } = new Net.SendMessageCache(null, null, null, null, null);

		// Token: 0x04000823 RID: 2083
		public int RpcId;

		// Token: 0x04000824 RID: 2084
		public int SeqNo;

		// Token: 0x04000825 RID: 2085
		public EMessageId MessageId;

		// Token: 0x04000826 RID: 2086
		[Nullable(2)]
		private byte[] EncodeMessageBuffer;

		// Token: 0x04000827 RID: 2087
		private int MessageSize;

		// Token: 0x04000828 RID: 2088
		public long SendTimeMs;

		// Token: 0x04000829 RID: 2089
		[Nullable(2)]
		public TimerHandle TimeoutHandle;

		// Token: 0x0400082A RID: 2090
		[Nullable(2)]
		public Net.IMessageCallBack Handle;

		// Token: 0x0400082B RID: 2091
		public bool InList;
	}

	// Token: 0x020001B8 RID: 440
	// (Invoke) Token: 0x06000D28 RID: 3368
	[NullableContext(0)]
	public delegate void TExceptionHandle(int rpcId, int errorCode, int messageId, [Nullable(2)] object message, string errorMessage);

	// Token: 0x020001B9 RID: 441
	// (Invoke) Token: 0x06000D2C RID: 3372
	[NullableContext(0)]
	public delegate void TConnectResultCallback(Net.EConnectResult result);

	// Token: 0x020001BA RID: 442
	// (Invoke) Token: 0x06000D30 RID: 3376
	[NullableContext(0)]
	public delegate void TNetworkErrorHandle(int errorCode);
}
