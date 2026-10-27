using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.ResManager;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02004B6B RID: 19307
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportMisc
	{
		// Token: 0x06031FF2 RID: 204786 RVA: 0x00B9BC70 File Offset: 0x00B99E70
		public static void SendTeleportTransferRequest(int markConfigId)
		{
			if (TeleportMisc.ShowTeleportConfirmBox(delegate
			{
				TeleportMisc.SendTeleportTransferRequestPurely(markConfigId, delegate
				{
					InstanceDungeonModel.Instance.ClearInstanceDungeonInfo();
				});
			}))
			{
				return;
			}
			TeleportMisc.SendTeleportTransferRequestPurely(markConfigId, null);
		}

		// Token: 0x06031FF3 RID: 204787 RVA: 0x00B9BCAC File Offset: 0x00B99EAC
		private static void SendTeleportTransferRequestPurely(int markConfigId, Action onSuccess = null)
		{
			LoadingModel.Instance.TargetTeleportId = markConfigId;
			TeleportTransferRequest teleportTransferRequest = TeleportTransferRequest.Create();
			teleportTransferRequest.Id = markConfigId;
			Net.Instance.Call(ERequestMessageId.TeleportTransferRequest, teleportTransferRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TeleportTransferResponse teleportTransferResponse = (TeleportTransferResponse)msg;
				if (GlobalData.World == null)
				{
					return;
				}
				if (teleportTransferResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
				{
					return;
				}
				if (teleportTransferResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					if (teleportTransferResponse.ErrorCode != Aki.Protocol.ErrorCode.ErrSceneBlockSplitNotBlock)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(teleportTransferResponse.ErrorCode, EResponseMessageId.TeleportTransferResponse, null, true, true);
					}
					return;
				}
				Action onSuccess2 = onSuccess;
				if (onSuccess2 == null)
				{
					return;
				}
				onSuccess2();
			}, 0);
		}

		// Token: 0x06031FF4 RID: 204788 RVA: 0x00B9BCFC File Offset: 0x00B99EFC
		public static bool ShowTeleportConfirmBox(Action confirmCallBack = null)
		{
			if (confirmCallBack == null)
			{
				confirmCallBack = delegate()
				{
				};
			}
			int? currentDungeonTelExitConfirmId = InstanceDungeonModel.Instance.GetCurrentDungeonTelExitConfirmId();
			if (currentDungeonTelExitConfirmId != null)
			{
				int? num = currentDungeonTelExitConfirmId;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)currentDungeonTelExitConfirmId.Value);
					confirmBoxDataNew.FunctionMap[2] = delegate()
					{
						confirmCallBack();
					};
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06031FF5 RID: 204789 RVA: 0x00B9BDA8 File Offset: 0x00B99FA8
		public static void SendTeleportTransferRequestByEntityId(int instEntityTeleportId)
		{
			InstEntityTeleporter value = MapConfig.Instance.GetInstEntityTeleportConfigById(instEntityTeleportId).Value;
			InstEntityTeleportRequest instEntityTeleportRequest = InstEntityTeleportRequest.Create();
			instEntityTeleportRequest.InstId = value.InstId;
			instEntityTeleportRequest.EntityConfigId = value.EntityConfigId;
			Net.Instance.Call(ERequestMessageId.InstEntityTeleportRequest, instEntityTeleportRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				InstEntityTeleportResponse instEntityTeleportResponse = (InstEntityTeleportResponse)msg;
				if (GlobalData.World == null)
				{
					return;
				}
				if (instEntityTeleportResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
				{
					return;
				}
				if (instEntityTeleportResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(instEntityTeleportResponse.ErrorCode, EResponseMessageId.InstEntityTeleportResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06031FF6 RID: 204790 RVA: 0x00B9BE1C File Offset: 0x00B9A01C
		[NullableContext(1)]
		public unsafe static bool BackToGameIfTargetPositionInvalid(global::Vector position, string reason)
		{
			int mapId = GameModeModel.Instance.MapId;
			ValueTuple<bool, bool> valueTuple = ResourceManagerController.Instance.IsBlockResourceDownloaded(mapId, position);
			bool item = valueTuple.Item1;
			bool item2 = valueTuple.Item2;
			if (item && !item2)
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SubPackageTeleportToUnFinishAreaConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
				ReConnectController.Instance.Logout(ELogoutReason.InvalidTeleportPosition);
			};
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
			int mapBlockFromPosition = ResourceManagerController.Instance.GetMapBlockFromPosition(mapId, position);
			if (mapBlockFromPosition >= 0)
			{
				ResourceManagerController.Instance.PushCurBlock(new <>z__ReadOnlySingleElementList<int>(mapBlockFromPosition), "传送保底,回到登陆界面");
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Teleport;
			ELogAuthor author = ELogAuthor.XY;
			string message = "传送: 目标位置所在区块资源未下载, 回到登录界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mapId", mapId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("position", position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return true;
		}
	}
}
