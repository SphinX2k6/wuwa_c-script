using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02005E5D RID: 24157
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleUiSetController : UiControllerBase
	{
		// Token: 0x0603D6AC RID: 251564 RVA: 0x00ED0893 File Offset: 0x00ECEA93
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603D6AD RID: 251565 RVA: 0x00ED0896 File Offset: 0x00ECEA96
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0603D6AE RID: 251566 RVA: 0x00ED0899 File Offset: 0x00ECEA99
		protected override void OnRegisterNetEvent()
		{
			Net instance = Net.Instance;
			ENotifyMessageId id = ENotifyMessageId.SettingNotify;
			Action<IMessage, Net.CallbackStatus> callback;
			if ((callback = BattleUiSetController.<>O.<0>__SettingNotify) == null)
			{
				callback = (BattleUiSetController.<>O.<0>__SettingNotify = new Action<IMessage, Net.CallbackStatus>(BattleUiSetController.SettingNotify));
			}
			instance.Register(id, callback);
		}

		// Token: 0x0603D6AF RID: 251567 RVA: 0x00ED08C6 File Offset: 0x00ECEAC6
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SettingNotify);
		}

		// Token: 0x0603D6B0 RID: 251568 RVA: 0x00ED08D8 File Offset: 0x00ECEAD8
		[NullableContext(2)]
		private static void SettingNotify(IMessage msg, Net.CallbackStatus status)
		{
			SettingNotify settingNotify = (SettingNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "SettingNotify 通知移动端按键设置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", settingNotify);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			RepeatedField<MobileButtonSetting> mobileButtonSettings = settingNotify.MobileButtonSettings;
			if (mobileButtonSettings == null)
			{
				return;
			}
			BattleUiSetModel instance2 = BattleUiSetModel.Instance;
			foreach (MobileButtonSetting mobileButtonSetting in mobileButtonSettings)
			{
				int id = mobileButtonSetting.Id;
				BattleUiSetPanelItemData panelItemDataByConfigId = instance2.GetPanelItemDataByConfigId(id);
				if (panelItemDataByConfigId == null)
				{
					break;
				}
				panelItemDataByConfigId.Size = mobileButtonSetting.Size;
				panelItemDataByConfigId.EditSize = mobileButtonSetting.Size;
				panelItemDataByConfigId.Alpha = mobileButtonSetting.Transparency;
				panelItemDataByConfigId.EditAlpha = mobileButtonSetting.Transparency;
				panelItemDataByConfigId.OffsetX = mobileButtonSetting.ScreenX;
				panelItemDataByConfigId.EditOffsetX = mobileButtonSetting.ScreenX;
				panelItemDataByConfigId.OffsetY = mobileButtonSetting.ScreenY;
				panelItemDataByConfigId.EditOffsetY = mobileButtonSetting.ScreenY;
				panelItemDataByConfigId.HierarchyIndex = mobileButtonSetting.ButtonLevel;
				panelItemDataByConfigId.EditorHierarchyIndex = mobileButtonSetting.ButtonLevel;
			}
		}

		// Token: 0x0603D6B1 RID: 251569 RVA: 0x00ED0A10 File Offset: 0x00ECEC10
		public static void MobileButtonSettingUpdateRequest(IReadOnlyList<MobileButtonSetting> settings)
		{
			MobileButtonSettingUpdateRequest mobileButtonSettingUpdateRequest = Aki.Protocol.MobileButtonSettingUpdateRequest.Create();
			mobileButtonSettingUpdateRequest.MobileButtonSettings.AddRange(settings);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "MobileButtonSettingUpdateRequest 客户端请求移动端键位设置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("request", mobileButtonSettingUpdateRequest);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Net instance2 = Net.Instance;
			ERequestMessageId requestMessageId = ERequestMessageId.MobileButtonSettingUpdateRequest;
			IMessage message2 = mobileButtonSettingUpdateRequest;
			Action<IMessage, Net.CallbackStatus> handle;
			if ((handle = BattleUiSetController.<>O.<1>__MobileButtonSettingUpdateResponse) == null)
			{
				handle = (BattleUiSetController.<>O.<1>__MobileButtonSettingUpdateResponse = new Action<IMessage, Net.CallbackStatus>(BattleUiSetController.MobileButtonSettingUpdateResponse));
			}
			instance2.Call(requestMessageId, message2, handle, 0);
		}

		// Token: 0x0603D6B2 RID: 251570 RVA: 0x00ED0A88 File Offset: 0x00ECEC88
		[NullableContext(2)]
		private static void MobileButtonSettingUpdateResponse(IMessage msg, Net.CallbackStatus status)
		{
			MobileButtonSettingUpdateResponse mobileButtonSettingUpdateResponse = (MobileButtonSettingUpdateResponse)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "MobileButtonSettingUpdateResponse 服务端返回移动端键位设置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("response", mobileButtonSettingUpdateResponse);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (mobileButtonSettingUpdateResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mobileButtonSettingUpdateResponse.ErrorCode, 27442, null, true, true);
				return;
			}
			GenericPromptController instance2 = GenericPromptController.Instance;
			BattleUiPureModeData pureModeData = BattleUiModel.Instance.PureModeData;
			instance2.ShowPromptByCode((pureModeData != null && pureModeData.IsOpen) ? "SaveButtonPureMode" : "SaveButton", Array.Empty<object>());
		}

		// Token: 0x17008E75 RID: 36469
		// (get) Token: 0x0603D6B3 RID: 251571 RVA: 0x00ED0B1A File Offset: 0x00ECED1A
		public static BattleUiSetController Instance
		{
			get
			{
				return BattleUiSetController._Instance;
			}
		}

		// Token: 0x0603D6B4 RID: 251572 RVA: 0x00ED0B21 File Offset: 0x00ECED21
		public static BattleUiSetController GetOrCreateInstance()
		{
			if (BattleUiSetController._Instance == null)
			{
				BattleUiSetController.CreateInstance();
			}
			return BattleUiSetController._Instance;
		}

		// Token: 0x0603D6B5 RID: 251573 RVA: 0x00ED0B35 File Offset: 0x00ECED35
		public static bool CreateInstance()
		{
			if (BattleUiSetController._Instance != null)
			{
				return true;
			}
			BattleUiSetController._Instance = new BattleUiSetController();
			return true;
		}

		// Token: 0x0603D6B6 RID: 251574 RVA: 0x00ED0B4B File Offset: 0x00ECED4B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D6B7 RID: 251575 RVA: 0x00ED0B4D File Offset: 0x00ECED4D
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetController._Instance = null;
		}

		// Token: 0x0603D6B8 RID: 251576 RVA: 0x00ED0B55 File Offset: 0x00ECED55
		static BattleUiSetController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetController.CreateStaticDefaultValue), new Action(BattleUiSetController.ResetStaticDefaultValue));
		}

		// Token: 0x040200C7 RID: 131271
		[Nullable(2)]
		private static BattleUiSetController _Instance;

		// Token: 0x0200C1D3 RID: 49619
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403A936 RID: 239926
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__SettingNotify;

			// Token: 0x0403A937 RID: 239927
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <1>__MobileButtonSettingUpdateResponse;
		}
	}
}
