using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001F92 RID: 8082
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InfoDisplayController : ControllerBase
{
	// Token: 0x0600FAF1 RID: 64241 RVA: 0x003CCA8C File Offset: 0x003CAC8C
	[NullableContext(2)]
	public bool OpenInfoDisplay(int reactId, TOpenViewCallBack finishCallback = null, object param = null, bool inPlot = false, ELayerType? layerType = null)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.InfoDisplayTypeOneView) || UiManager.Instance.IsViewOpen(EUiViewName.InfoDisplayTypeTwoView) || UiManager.Instance.IsViewOpen(EUiViewName.InfoDisplayTypeThreeView) || UiManager.Instance.IsViewOpen(EUiViewName.InfoDisplayTypeFourNewView) || UiManager.Instance.IsViewOpen(EUiViewName.InfoDisplayTypeFiveView))
		{
			return false;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("infodisplay_use_item_cd");
		if (this.LastOpenTime != 0.0)
		{
			double num = Time.Instance.Now - this.LastOpenTime;
			if (intConfig != null && num <= (double)(intConfig.Value * 1000))
			{
				GenericPromptController.Instance.ShowPromptByCode("InDisplayCd", Array.Empty<object>());
				return false;
			}
		}
		InfoDisplayModel.Instance.ClearGroupInfo();
		InfoDisplayModel.Instance.SetCurrentOpenInformationId(reactId);
		int infoDisplayType = InfoDisplayModuleConfig.Instance.GetInfoDisplayType(reactId);
		EUiViewName? infoDisplayViewName = this.GetInfoDisplayViewName(infoDisplayType);
		if (infoDisplayViewName != null)
		{
			if (inPlot)
			{
				UiManager.Instance.OpenViewByPlot(infoDisplayViewName.Value, param, finishCallback);
			}
			else if (layerType != null)
			{
				UiManager.Instance.OpenViewWithLayer(infoDisplayViewName.Value, layerType.Value, null, finishCallback);
			}
			else
			{
				UiManager.Instance.OpenView(infoDisplayViewName.Value, null, finishCallback);
			}
		}
		this.LastOpenTime = Time.Instance.Now;
		return true;
	}

	// Token: 0x0600FAF2 RID: 64242 RVA: 0x003CCBE4 File Offset: 0x003CADE4
	private EUiViewName? GetInfoDisplayViewName(int type)
	{
		if (type == 1)
		{
			return new EUiViewName?(EUiViewName.InfoDisplayTypeOneView);
		}
		if (type == 2)
		{
			return new EUiViewName?(EUiViewName.InfoDisplayTypeTwoView);
		}
		if (type == 3)
		{
			return new EUiViewName?(EUiViewName.InfoDisplayTypeThreeView);
		}
		if (type == 4)
		{
			return new EUiViewName?(EUiViewName.InfoDisplayTypeFourNewView);
		}
		if (type == 5)
		{
			return new EUiViewName?(EUiViewName.InfoDisplayTypeFiveView);
		}
		return null;
	}

	// Token: 0x0600FAF3 RID: 64243 RVA: 0x003CCC48 File Offset: 0x003CAE48
	[NullableContext(2)]
	public unsafe bool OpenInfoDisplayGroup(int groupId, TOpenViewCallBack finishCallback = null, object param = null, bool inPlot = false, ELayerType? layerType = null)
	{
		InfoDisplayGroup? config = ConfigInfoDisplayGroupById.GetConfig(groupId, true);
		if (config == null || config.Value.InfoListLength == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InfoDisplay;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "信息展示组配置不存在或信息列表为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < config.Value.InfoListLength; i++)
		{
			list.Add(config.Value.InfoList(i));
		}
		int infoDisplayType = InfoDisplayModuleConfig.Instance.GetInfoDisplayType(list[0]);
		if (infoDisplayType != 1 && infoDisplayType != 3)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.InfoDisplay;
			ELogAuthor author2 = ELogAuthor.HYF;
			string message2 = "信息展示组配置错误，仅支持类型1和3";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupId", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", infoDisplayType);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		foreach (int num in list)
		{
			int infoDisplayType2 = InfoDisplayModuleConfig.Instance.GetInfoDisplayType(num);
			if (infoDisplayType2 != infoDisplayType)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.InfoDisplay;
				ELogAuthor author3 = ELogAuthor.HYF;
				string message3 = "信息展示组配置错误，组内信息类型不一致";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("groupId", groupId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("infoId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("type", infoDisplayType2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("groupType", infoDisplayType);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				return false;
			}
		}
		bool flag = this.OpenInfoDisplay(list[0], finishCallback, param, inPlot, layerType);
		if (flag)
		{
			InfoDisplayModel.Instance.SetGroupInfo(list);
		}
		return flag;
	}

	// Token: 0x0600FAF4 RID: 64244 RVA: 0x003CCE80 File Offset: 0x003CB080
	public void OpenInfoDisplayImgView()
	{
		UiManager.Instance.OpenView(EUiViewName.InfoDisplayImgView, null, null);
	}

	// Token: 0x0600FAF5 RID: 64245 RVA: 0x003CCE93 File Offset: 0x003CB093
	public void OpenInfoDisplayAttachmentBigImgView()
	{
		UiManager.Instance.OpenView(EUiViewName.InfoDisplayAttachmentBigImgView, null, null);
	}

	// Token: 0x0600FAF6 RID: 64246 RVA: 0x003CCEA6 File Offset: 0x003CB0A6
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x0600FAF7 RID: 64247 RVA: 0x003CCEAF File Offset: 0x003CB0AF
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x0600FAF8 RID: 64248 RVA: 0x003CCEB8 File Offset: 0x003CB0B8
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
	}

	// Token: 0x0600FAF9 RID: 64249 RVA: 0x003CCED6 File Offset: 0x003CB0D6
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
	}

	// Token: 0x0600FAFA RID: 64250 RVA: 0x003CCEF4 File Offset: 0x003CB0F4
	private void OnItemUse(int configId, int useCount)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		int num;
		if (itemConfig != null && itemConfig.Value.Parameters().Count > 0 && itemConfig.Value.Parameters().TryGetValue(12, out num) && num != 0)
		{
			InfoDisplayController.Instance.OpenInfoDisplay(num, null, null, false, null);
		}
	}

	// Token: 0x0600FAFB RID: 64251 RVA: 0x003CCF64 File Offset: 0x003CB164
	public void RequestReadDisplayInfo(int displayId)
	{
		ReadDisplayInfoRequest readDisplayInfoRequest = ReadDisplayInfoRequest.Create();
		readDisplayInfoRequest.DisplayId = displayId;
		Net.Instance.Call(ERequestMessageId.ReadDisplayInfoRequest, readDisplayInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ReadDisplayInfoResponse readDisplayInfoResponse = (ReadDisplayInfoResponse)msg;
			if (readDisplayInfoResponse != null && readDisplayInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(readDisplayInfoResponse.ErrorCode, 21345, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17001346 RID: 4934
	// (get) Token: 0x0600FAFC RID: 64252 RVA: 0x003CCFAE File Offset: 0x003CB1AE
	public static InfoDisplayController Instance
	{
		get
		{
			return InfoDisplayController._Instance;
		}
	}

	// Token: 0x0600FAFD RID: 64253 RVA: 0x003CCFB5 File Offset: 0x003CB1B5
	public static InfoDisplayController GetOrCreateInstance()
	{
		if (InfoDisplayController._Instance == null)
		{
			InfoDisplayController.CreateInstance();
		}
		return InfoDisplayController._Instance;
	}

	// Token: 0x0600FAFE RID: 64254 RVA: 0x003CCFC9 File Offset: 0x003CB1C9
	public static bool CreateInstance()
	{
		if (InfoDisplayController._Instance != null)
		{
			return true;
		}
		InfoDisplayController._Instance = new InfoDisplayController();
		return true;
	}

	// Token: 0x0600FAFF RID: 64255 RVA: 0x003CCFDF File Offset: 0x003CB1DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FB00 RID: 64256 RVA: 0x003CCFE1 File Offset: 0x003CB1E1
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayController._Instance = null;
	}

	// Token: 0x0600FB01 RID: 64257 RVA: 0x003CCFE9 File Offset: 0x003CB1E9
	static InfoDisplayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayController.CreateStaticDefaultValue), new Action(InfoDisplayController.ResetStaticDefaultValue));
	}

	// Token: 0x040074D2 RID: 29906
	private double LastOpenTime;

	// Token: 0x040074D3 RID: 29907
	public const int INFO_DISPLAY_ITEM_TYPE = 12;

	// Token: 0x040074D4 RID: 29908
	[Nullable(2)]
	private static InfoDisplayController _Instance;

	// Token: 0x0200857D RID: 34173
	[NullableContext(0)]
	public enum EInfoDisplayViewEnum
	{
		// Token: 0x0402B76F RID: 178031
		TypeOne = 1,
		// Token: 0x0402B770 RID: 178032
		TypeTwo,
		// Token: 0x0402B771 RID: 178033
		TypeThree,
		// Token: 0x0402B772 RID: 178034
		TypeFour,
		// Token: 0x0402B773 RID: 178035
		TypeFive
	}
}
