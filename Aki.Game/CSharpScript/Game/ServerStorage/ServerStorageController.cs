using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.ServerStorage
{
	// Token: 0x02004581 RID: 17793
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ServerStorageController : ControllerBase
	{
		// Token: 0x0602DE8A RID: 188042 RVA: 0x00A8DE0B File Offset: 0x00A8C00B
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.StorageInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStorageInfoInitNotify));
			return true;
		}

		// Token: 0x0602DE8B RID: 188043 RVA: 0x00A8DE2A File Offset: 0x00A8C02A
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.StorageInfoNotify);
			return true;
		}

		// Token: 0x0602DE8C RID: 188044 RVA: 0x00A8DE40 File Offset: 0x00A8C040
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

		// Token: 0x0602DE8D RID: 188045 RVA: 0x00A8DE78 File Offset: 0x00A8C078
		public void SendStorageInfoUpdateRequest(StorageInfoUpdateRequest request)
		{
			Net.Instance.Call(ERequestMessageId.StorageInfoUpdateRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				StorageInfoUpdateResponse storageInfoUpdateResponse = (StorageInfoUpdateResponse)msg;
				if (storageInfoUpdateResponse == null)
				{
					return;
				}
				if (storageInfoUpdateResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(storageInfoUpdateResponse.ErrorCode, 15571, null, true, true);
				}
			}, 0);
		}

		// Token: 0x17007595 RID: 30101
		// (get) Token: 0x0602DE8E RID: 188046 RVA: 0x00A8DEAA File Offset: 0x00A8C0AA
		public static ServerStorageController Instance
		{
			get
			{
				return ServerStorageController._Instance;
			}
		}

		// Token: 0x0602DE8F RID: 188047 RVA: 0x00A8DEB1 File Offset: 0x00A8C0B1
		public static ServerStorageController GetOrCreateInstance()
		{
			if (ServerStorageController._Instance == null)
			{
				ServerStorageController.CreateInstance();
			}
			return ServerStorageController._Instance;
		}

		// Token: 0x0602DE90 RID: 188048 RVA: 0x00A8DEC5 File Offset: 0x00A8C0C5
		public static bool CreateInstance()
		{
			if (ServerStorageController._Instance != null)
			{
				return true;
			}
			ServerStorageController._Instance = new ServerStorageController();
			return true;
		}

		// Token: 0x0602DE91 RID: 188049 RVA: 0x00A8DEDB File Offset: 0x00A8C0DB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DE92 RID: 188050 RVA: 0x00A8DEDD File Offset: 0x00A8C0DD
		public static void ResetStaticDefaultValue()
		{
			ServerStorageController._Instance = null;
		}

		// Token: 0x0602DE93 RID: 188051 RVA: 0x00A8DEE5 File Offset: 0x00A8C0E5
		static ServerStorageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ServerStorageController.CreateStaticDefaultValue), new Action(ServerStorageController.ResetStaticDefaultValue));
		}

		// Token: 0x04018841 RID: 100417
		[Nullable(2)]
		private static ServerStorageController _Instance;
	}
}
