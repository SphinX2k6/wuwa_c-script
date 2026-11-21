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
	// Token: 0x02004E42 RID: 20034
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class BattleUiSetController : UiControllerBase
	{
		// Token: 0x0603263C RID: 206396 RVA: 0x00E21E03 File Offset: 0x00E20003
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603263D RID: 206397 RVA: 0x00E21E06 File Offset: 0x00E20006
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0603263E RID: 206398 RVA: 0x00E21E09 File Offset: 0x00E20009
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

		// Token: 0x0603263F RID: 206399 RVA: 0x00E21E36 File Offset: 0x00E20036
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SettingNotify);
		}

		// Token: 0x06032640 RID: 206400 RVA: 0x00E21E48 File Offset: 0x00E20048
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

		// Token: 0x06032641 RID: 206401 RVA: 0x00E21F80 File Offset: 0x00E20180
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

		// Token: 0x06032642 RID: 206402 RVA: 0x00E21FF8 File Offset: 0x00E201F8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mobileButtonSettingUpdateResponse.ErrorCode, 22058, null, true, true);
				return;
			}
			GenericPromptController instance2 = GenericPromptController.Instance;
			BattleUiPureModeData pureModeData = BattleUiModel.Instance.PureModeData;
			instance2.ShowPromptByCode((pureModeData != null && pureModeData.IsOpen) ? "SaveButtonPureMode" : "SaveButton", Array.Empty<object>());
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x06032643 RID: 206403 RVA: 0x00E2208A File Offset: 0x00E2028A
		public static BattleUiSetController Instance
		{
			get
			{
				return BattleUiSetController._Instance;
			}
		}

		// Token: 0x06032644 RID: 206404 RVA: 0x00E22091 File Offset: 0x00E20291
		public static BattleUiSetController GetOrCreateInstance()
		{
			if (BattleUiSetController._Instance == null)
			{
				BattleUiSetController.CreateInstance();
			}
			return BattleUiSetController._Instance;
		}

		// Token: 0x06032645 RID: 206405 RVA: 0x00E220A5 File Offset: 0x00E202A5
		public static bool CreateInstance()
		{
			if (BattleUiSetController._Instance != null)
			{
				return true;
			}
			BattleUiSetController._Instance = new BattleUiSetController();
			return true;
		}

		// Token: 0x06032646 RID: 206406 RVA: 0x00E220BB File Offset: 0x00E202BB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032647 RID: 206407 RVA: 0x00E220BD File Offset: 0x00E202BD
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetController._Instance = null;
		}

		// Token: 0x06032648 RID: 206408 RVA: 0x00E220C5 File Offset: 0x00E202C5
		static BattleUiSetController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetController.CreateStaticDefaultValue), new Action(BattleUiSetController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB8E RID: 109454
		[Nullable(2)]
		private static BattleUiSetController _Instance;

		// Token: 0x0200ABE2 RID: 44002
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04035328 RID: 217896
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Action<IMessage, Net.CallbackStatus> <0>__SettingNotify;

			// Token: 0x04035329 RID: 217897
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
