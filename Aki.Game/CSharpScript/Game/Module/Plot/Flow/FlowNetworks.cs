using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200406E RID: 16494
	[NullableContext(2)]
	[Nullable(0)]
	public class FlowNetworks
	{
		// Token: 0x06029D31 RID: 171313 RVA: 0x00BD2370 File Offset: 0x00BD0570
		public static void Register()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.FlowStartNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = FlowNetworks.<>O.<0>__HandleFlowStartNotify) == null)
			{
				callback = (FlowNetworks.<>O.<0>__HandleFlowStartNotify = new Action<IMessage, Net.CallbackStatus>(FlowNetworks.HandleFlowStartNotify));
			}
			instance.Register(id, callback);
			Net instance2 = Net.Instance;
			ENotifyMessageId id2 = ENotifyMessageId.FlowEndNotify;
			Action<IMessage, Net.CallbackStatus> callback2;
			if ((callback2 = FlowNetworks.<>O.<1>__HandleFlowEndNotify) == null)
			{
				callback2 = (FlowNetworks.<>O.<1>__HandleFlowEndNotify = new Action<IMessage, Net.CallbackStatus>(FlowNetworks.HandleFlowEndNotify));
			}
			instance2.Register(id2, callback2);
			Net instance3 = Net.Instance;
			ENotifyMessageId id3 = ENotifyMessageId.FlowServerSkipNotify;
			Action<IMessage, Net.CallbackStatus> callback3;
			if ((callback3 = FlowNetworks.<>O.<2>__HandleFlowSkipBlackScreenNotify) == null)
			{
				callback3 = (FlowNetworks.<>O.<2>__HandleFlowSkipBlackScreenNotify = new Action<IMessage, Net.CallbackStatus>(FlowNetworks.HandleFlowSkipBlackScreenNotify));
			}
			instance3.Register(id3, callback3);
		}

		// Token: 0x06029D32 RID: 171314 RVA: 0x00BD23FE File Offset: 0x00BD05FE
		public static void UnRegister()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FlowStartNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlowEndNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FlowServerSkipNotify);
		}

		// Token: 0x06029D33 RID: 171315 RVA: 0x00BD2430 File Offset: 0x00BD0630
		private static void HandleFlowStartNotify(IMessage msg, Net.CallbackStatus _)
		{
			FlowStartNotify notify = (FlowStartNotify)msg;
			FlowController.Instance.StartNotify(notify);
		}

		// Token: 0x06029D34 RID: 171316 RVA: 0x00BD2450 File Offset: 0x00BD0650
		private static void HandleFlowEndNotify(IMessage msg, Net.CallbackStatus _)
		{
			FlowEndNotify notify = (FlowEndNotify)msg;
			FlowController.Instance.EndNotify(notify);
		}

		// Token: 0x06029D35 RID: 171317 RVA: 0x00BD2470 File Offset: 0x00BD0670
		private static void HandleFlowSkipBlackScreenNotify(IMessage msg, Net.CallbackStatus _)
		{
			FlowServerSkipNotify notify = (FlowServerSkipNotify)msg;
			FlowController.Instance.SkipBlackScreenNotify(notify);
		}

		// Token: 0x06029D36 RID: 171318 RVA: 0x00BD2490 File Offset: 0x00BD0690
		public static void RequestGmFinish()
		{
			ChatRequest chatRequest = ChatRequest.Create();
			chatRequest.ChannelId = 0;
			chatRequest.Content = "@skipflow";
			Net.Instance.Call(ERequestMessageId.ChatRequest, chatRequest, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06029D37 RID: 171319 RVA: 0x00BD24E8 File Offset: 0x00BD06E8
		public static void RequestAction(long flowIncId, int actionId, Action<ErrorCode> callback)
		{
			FlowActionRequest flowActionRequest = FlowActionRequest.Create();
			flowActionRequest.FlowIncId = flowIncId;
			flowActionRequest.ActionId = actionId;
			Net.Instance.Call(ERequestMessageId.FlowActionRequest, flowActionRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlowActionResponse flowActionResponse = (FlowActionResponse)msg;
				if (callback != null)
				{
					callback(flowActionResponse.Code);
				}
				FlowNetworks.HandleErrorCode(flowActionResponse.Code, 29872);
			}, 0);
		}

		// Token: 0x06029D38 RID: 171320 RVA: 0x00BD2534 File Offset: 0x00BD0734
		public static void RequestFlowEnd(long flowIncId, bool isSkip, [Nullable(new byte[]
		{
			1,
			0,
			1,
			0
		})] List<ValueTuple<int, List<ValueTuple<int, int>>>> optionList, Action<long, ErrorCode?> callback = null, bool clientError = false)
		{
			FlowEndRequest flowEndRequest = FlowEndRequest.Create();
			flowEndRequest.FlowIncId = flowIncId;
			flowEndRequest.IsSkip = isSkip;
			new Dictionary<string, FlowOptionInfoList>();
			foreach (ValueTuple<int, List<ValueTuple<int, int>>> valueTuple in optionList)
			{
				int item = valueTuple.Item1;
				List<ValueTuple<int, int>> item2 = valueTuple.Item2;
				FlowOptionInfoList flowOptionInfoList = new FlowOptionInfoList();
				foreach (ValueTuple<int, int> valueTuple2 in item2)
				{
					FlowOptionInfo item3 = new FlowOptionInfo
					{
						TalkId = valueTuple2.Item1,
						OptionIndex = valueTuple2.Item2
					};
					flowOptionInfoList.OptionIndexList.Add(item3);
				}
				flowEndRequest.OptionInfos.Add(item, flowOptionInfoList);
			}
			flowEndRequest.ClientError = clientError;
			Net.Instance.Call(ERequestMessageId.FlowEndRequest, flowEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlowEndResponse flowEndResponse = (FlowEndResponse)msg;
				if (flowEndResponse == null)
				{
					FlowController.Instance.LogError("请求完成剧情时网络错误", default(ReadOnlySpan<ValueTuple<string, object>>));
					Action<long, ErrorCode?> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(flowIncId, null);
					return;
				}
				else
				{
					FlowNetworks.HandleErrorCode(flowEndResponse.Code, 29872);
					Action<long, ErrorCode?> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(flowIncId, new ErrorCode?(flowEndResponse.Code));
					return;
				}
			}, 0);
		}

		// Token: 0x06029D39 RID: 171321 RVA: 0x00BD2660 File Offset: 0x00BD0860
		public static void RequestFlowRestart(long flowIncId)
		{
			FlowRestartRequest flowRestartRequest = FlowRestartRequest.Create();
			flowRestartRequest.FlowIncId = flowIncId;
			Net.Instance.Call(ERequestMessageId.FlowRestartRequest, flowRestartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlowRestartResponse flowRestartResponse = (FlowRestartResponse)msg;
				if (flowRestartResponse == null)
				{
					FlowController instance = FlowController.Instance;
					string text = "请求重启剧情时网络错误";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowIncId", flowIncId);
					instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (flowRestartResponse.Code != ErrorCode.Success)
				{
					FlowController instance2 = FlowController.Instance;
					string text2 = "请求重启剧情失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("flowIncId", flowIncId);
					instance2.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}, 0);
		}

		// Token: 0x06029D3A RID: 171322 RVA: 0x00BD26AC File Offset: 0x00BD08AC
		[NullableContext(1)]
		public static void RequestSeqEndPosition(FlowContext context, IVector location, IRotator rotation)
		{
			if (!context.IsServerNotify)
			{
				return;
			}
			FlowSeqSetPlayerPosRequest flowSeqSetPlayerPosRequest = FlowSeqSetPlayerPosRequest.Create();
			flowSeqSetPlayerPosRequest.FlowIncId = context.FlowIncId;
			flowSeqSetPlayerPosRequest.TalkActionId = context.CurShowTalkActionId;
			flowSeqSetPlayerPosRequest.TalkId = context.CurTalkId;
			flowSeqSetPlayerPosRequest.X = (float)location.X;
			flowSeqSetPlayerPosRequest.Y = (float)location.Y;
			flowSeqSetPlayerPosRequest.Z = (float)location.Z;
			flowSeqSetPlayerPosRequest.A = rotation.Yaw;
			long incId = context.FlowIncId;
			Net.Instance.Call(ERequestMessageId.FlowSeqSetPlayerPosRequest, flowSeqSetPlayerPosRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlowSeqSetPlayerPosResponse flowSeqSetPlayerPosResponse = (FlowSeqSetPlayerPosResponse)msg;
				if (flowSeqSetPlayerPosResponse == null)
				{
					FlowController instance = FlowController.Instance;
					string text = "请求Seq最终位置时网络错误";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowIncId", incId);
					instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (flowSeqSetPlayerPosResponse.Code != ErrorCode.Success)
				{
					FlowController instance2 = FlowController.Instance;
					string text2 = "请求Seq最终位置失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("flowIncId", incId);
					instance2.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}, 0);
		}

		// Token: 0x06029D3B RID: 171323 RVA: 0x00BD2750 File Offset: 0x00BD0950
		private static void HandleErrorCode(ErrorCode code, int messageId)
		{
			if (code == ErrorCode.ErrFinishFlowFail)
			{
				FlowController.Instance.LogError("请求服务器完成剧情失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (code == ErrorCode.ErrFlowActionFail)
			{
				FlowController.Instance.LogError("请求服务器剧情行为失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				ErrorCodeController.Instance.OpenErrorCodeTipView(code, messageId, null, true, true);
			}
		}

		// Token: 0x06029D3C RID: 171324 RVA: 0x00BD27B0 File Offset: 0x00BD09B0
		[NullableContext(1)]
		public static void RequestSafeTeleport(long flowIncId, Action<bool> callback)
		{
			FlowTeleportToPlotPosRequest flowTeleportToPlotPosRequest = FlowTeleportToPlotPosRequest.Create();
			flowTeleportToPlotPosRequest.FlowIncId = flowIncId;
			Net.Instance.Call(ERequestMessageId.FlowTeleportToPlotPosRequest, flowTeleportToPlotPosRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FlowTeleportToPlotPosResponse flowTeleportToPlotPosResponse = (FlowTeleportToPlotPosResponse)msg;
				if (flowTeleportToPlotPosResponse == null || flowTeleportToPlotPosResponse.Code != ErrorCode.Success)
				{
					FlowController.Instance.LogError("请求服务器传送到剧情起始点失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					callback(false);
					return;
				}
				callback(true);
			}, 0);
		}

		// Token: 0x02009C62 RID: 40034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030AC5 RID: 199365
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__HandleFlowStartNotify;

			// Token: 0x04030AC6 RID: 199366
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <1>__HandleFlowEndNotify;

			// Token: 0x04030AC7 RID: 199367
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <2>__HandleFlowSkipBlackScreenNotify;
		}
	}
}
