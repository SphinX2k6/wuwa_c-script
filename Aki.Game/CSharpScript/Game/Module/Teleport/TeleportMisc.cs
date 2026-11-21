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
	// Token: 0x02003B15 RID: 15125
	[NullableContext(2)]
	[Nullable(0)]
	public class TeleportMisc
	{
		// Token: 0x06026D88 RID: 159112 RVA: 0x00ADFF40 File Offset: 0x00ADE140
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

		// Token: 0x06026D89 RID: 159113 RVA: 0x00ADFF7C File Offset: 0x00ADE17C
		private unsafe static void SendTeleportTransferRequestPurely(int markConfigId, Action onSuccess = null)
		{
			LoadingModel.Instance.TargetTeleportId = markConfigId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TeleportMisc;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 发送传送点传送请求";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("teleportId", markConfigId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.TeleportMisc;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = "传送: 传送点传送请求失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("teleportId", markConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("errorCode", teleportTransferResponse.ErrorCode);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
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

		// Token: 0x06026D8A RID: 159114 RVA: 0x00AE0010 File Offset: 0x00ADE210
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

		// Token: 0x06026D8B RID: 159115 RVA: 0x00AE00BC File Offset: 0x00ADE2BC
		public unsafe static void SendTeleportTransferRequestByEntityId(int instEntityTeleportId)
		{
			InstEntityTeleporter config = MapConfig.Instance.GetInstEntityTeleportConfigById(instEntityTeleportId).Value;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.TeleportMisc;
			ELogAuthor author = ELogAuthor.CK;
			string message = "传送: 发送实体传送请求";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instEntityTeleportId", instEntityTeleportId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			InstEntityTeleportRequest instEntityTeleportRequest = InstEntityTeleportRequest.Create();
			instEntityTeleportRequest.InstId = config.InstId;
			instEntityTeleportRequest.EntityConfigId = config.EntityConfigId;
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
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.TeleportMisc;
					ELogAuthor author2 = ELogAuthor.CK;
					string message2 = "传送: 实体传送请求失败";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instEntityTeleportId", instEntityTeleportId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instId", config.InstId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("entityConfigId", config.EntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("errorCode", instEntityTeleportResponse.ErrorCode);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					ErrorCodeController.Instance.OpenErrorCodeTipView(instEntityTeleportResponse.ErrorCode, EResponseMessageId.InstEntityTeleportResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06026D8C RID: 159116 RVA: 0x00AE0170 File Offset: 0x00ADE370
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
