using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x020034A9 RID: 13481
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ServerStorageController : ControllerBase
	{
		// Token: 0x0602256C RID: 140652 RVA: 0x009B9523 File Offset: 0x009B7723
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.StorageInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStorageInfoInitNotify));
			return true;
		}

		// Token: 0x0602256D RID: 140653 RVA: 0x009B9542 File Offset: 0x009B7742
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.StorageInfoNotify);
			return true;
		}

		// Token: 0x0602256E RID: 140654 RVA: 0x009B9558 File Offset: 0x009B7758
		[NullableContext(2)]
		private void OnStorageInfoInitNotify(IMessage msg, Net.CallbackStatus _)
		{
			StorageInfoNotify storageInfoNotify = (StorageInfoNotify)msg;
			if (storageInfoNotify == null)
			{
				return;
			}
			ServerStorageModel.Instance.InitStorageInfo(storageInfoNotify.Infos);
			EventSystem.Instance.Emit(EEventName.OnServerStorageInfoInited);
		}

		// Token: 0x0602256F RID: 140655 RVA: 0x009B9590 File Offset: 0x009B7790
		public void SendStorageInfoUpdateRequest(StorageInfoUpdateRequest request, Action<bool> onResult)
		{
			Net.Instance.Call(ERequestMessageId.StorageInfoUpdateRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				StorageInfoUpdateResponse storageInfoUpdateResponse = (StorageInfoUpdateResponse)msg;
				if (storageInfoUpdateResponse == null)
				{
					Action<bool> onResult2 = onResult;
					if (onResult2 == null)
					{
						return;
					}
					onResult2(false);
					return;
				}
				else if (storageInfoUpdateResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(storageInfoUpdateResponse.ErrorCode, 24640, null, true, true);
					Action<bool> onResult3 = onResult;
					if (onResult3 == null)
					{
						return;
					}
					onResult3(false);
					return;
				}
				else
				{
					Action<bool> onResult4 = onResult;
					if (onResult4 == null)
					{
						return;
					}
					onResult4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06022570 RID: 140656 RVA: 0x009B95C7 File Offset: 0x009B77C7
		public static ServerStorageController Instance
		{
			get
			{
				return ServerStorageController._Instance;
			}
		}

		// Token: 0x06022571 RID: 140657 RVA: 0x009B95CE File Offset: 0x009B77CE
		public static ServerStorageController GetOrCreateInstance()
		{
			if (ServerStorageController._Instance == null)
			{
				ServerStorageController.CreateInstance();
			}
			return ServerStorageController._Instance;
		}

		// Token: 0x06022572 RID: 140658 RVA: 0x009B95E2 File Offset: 0x009B77E2
		public static bool CreateInstance()
		{
			if (ServerStorageController._Instance != null)
			{
				return true;
			}
			ServerStorageController._Instance = new ServerStorageController();
			return true;
		}

		// Token: 0x06022573 RID: 140659 RVA: 0x009B95F8 File Offset: 0x009B77F8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022574 RID: 140660 RVA: 0x009B95FA File Offset: 0x009B77FA
		public static void ResetStaticDefaultValue()
		{
			ServerStorageController._Instance = null;
		}

		// Token: 0x06022575 RID: 140661 RVA: 0x009B9602 File Offset: 0x009B7802
		static ServerStorageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerStorageController.CreateStaticDefaultValue), new Action(ServerStorageController.ResetStaticDefaultValue));
		}

		// Token: 0x04012E7B RID: 77435
		[Nullable(2)]
		private static ServerStorageController _Instance;
	}
}
