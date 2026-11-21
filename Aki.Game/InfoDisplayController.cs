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

// Token: 0x02001454 RID: 5204
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class InfoDisplayController : ControllerBase
{
	// Token: 0x0600CF12 RID: 53010 RVA: 0x003D85E4 File Offset: 0x003D67E4
	public bool OpenInfoDisplay(int reactId, TOpenViewCallBack finishCallback = null, object param = null, bool inPlot = false, ELayerType? layerType = null, string extraTopDesc = null)
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
		InfoDisplayModel.Instance.SetExtraTopDesc(extraTopDesc);
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

	// Token: 0x0600CF13 RID: 53011 RVA: 0x003D8748 File Offset: 0x003D6948
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

	// Token: 0x0600CF14 RID: 53012 RVA: 0x003D87AC File Offset: 0x003D69AC
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
		bool flag = this.OpenInfoDisplay(list[0], finishCallback, param, inPlot, layerType, null);
		if (flag)
		{
			InfoDisplayModel.Instance.SetGroupInfo(list);
		}
		return flag;
	}

	// Token: 0x0600CF15 RID: 53013 RVA: 0x003D89E4 File Offset: 0x003D6BE4
	public bool OpenInfoDisplayByItem(int itemId, string extraTopDesc = null)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		int num;
		if (itemConfig == null || !itemConfig.Value.Parameters().TryGetValue(12, out num) || num == 0)
		{
			return false;
		}
		this.OpenInfoDisplay(num, null, null, false, null, extraTopDesc);
		return true;
	}

	// Token: 0x0600CF16 RID: 53014 RVA: 0x003D8A3E File Offset: 0x003D6C3E
	public void OpenInfoDisplayImgView()
	{
		UiManager.Instance.OpenView(EUiViewName.InfoDisplayImgView, null, null);
	}

	// Token: 0x0600CF17 RID: 53015 RVA: 0x003D8A51 File Offset: 0x003D6C51
	public void OpenInfoDisplayAttachmentBigImgView()
	{
		UiManager.Instance.OpenView(EUiViewName.InfoDisplayAttachmentBigImgView, null, null);
	}

	// Token: 0x0600CF18 RID: 53016 RVA: 0x003D8A64 File Offset: 0x003D6C64
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x0600CF19 RID: 53017 RVA: 0x003D8A6D File Offset: 0x003D6C6D
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x0600CF1A RID: 53018 RVA: 0x003D8A76 File Offset: 0x003D6C76
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
	}

	// Token: 0x0600CF1B RID: 53019 RVA: 0x003D8A94 File Offset: 0x003D6C94
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
	}

	// Token: 0x0600CF1C RID: 53020 RVA: 0x003D8AB4 File Offset: 0x003D6CB4
	private void OnItemUse(int configId, int useCount)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		int num;
		if (itemConfig != null && itemConfig.Value.Parameters().Count > 0 && itemConfig.Value.Parameters().TryGetValue(12, out num) && num != 0)
		{
			InfoDisplayController.Instance.OpenInfoDisplay(num, null, null, false, null, null);
		}
	}

	// Token: 0x0600CF1D RID: 53021 RVA: 0x003D8B24 File Offset: 0x003D6D24
	public void RequestReadDisplayInfo(int displayId)
	{
		ReadDisplayInfoRequest readDisplayInfoRequest = ReadDisplayInfoRequest.Create();
		readDisplayInfoRequest.DisplayId = displayId;
		Net.Instance.Call(ERequestMessageId.ReadDisplayInfoRequest, readDisplayInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ReadDisplayInfoResponse readDisplayInfoResponse = (ReadDisplayInfoResponse)msg;
			if (readDisplayInfoResponse != null && readDisplayInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(readDisplayInfoResponse.ErrorCode, 20372, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17001370 RID: 4976
	// (get) Token: 0x0600CF1E RID: 53022 RVA: 0x003D8B6E File Offset: 0x003D6D6E
	[Nullable(1)]
	public static InfoDisplayController Instance
	{
		[NullableContext(1)]
		get
		{
			return InfoDisplayController._Instance;
		}
	}

	// Token: 0x0600CF1F RID: 53023 RVA: 0x003D8B75 File Offset: 0x003D6D75
	[NullableContext(1)]
	public static InfoDisplayController GetOrCreateInstance()
	{
		if (InfoDisplayController._Instance == null)
		{
			InfoDisplayController.CreateInstance();
		}
		return InfoDisplayController._Instance;
	}

	// Token: 0x0600CF20 RID: 53024 RVA: 0x003D8B89 File Offset: 0x003D6D89
	public static bool CreateInstance()
	{
		if (InfoDisplayController._Instance != null)
		{
			return true;
		}
		InfoDisplayController._Instance = new InfoDisplayController();
		return true;
	}

	// Token: 0x0600CF21 RID: 53025 RVA: 0x003D8B9F File Offset: 0x003D6D9F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CF22 RID: 53026 RVA: 0x003D8BA1 File Offset: 0x003D6DA1
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayController._Instance = null;
	}

	// Token: 0x0600CF23 RID: 53027 RVA: 0x003D8BA9 File Offset: 0x003D6DA9
	static InfoDisplayController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayController.CreateStaticDefaultValue), new Action(InfoDisplayController.ResetStaticDefaultValue));
	}

	// Token: 0x040075B4 RID: 30132
	private double LastOpenTime;

	// Token: 0x040075B5 RID: 30133
	public const int INFO_DISPLAY_ITEM_TYPE = 12;

	// Token: 0x040075B6 RID: 30134
	private static InfoDisplayController _Instance;

	// Token: 0x02007702 RID: 30466
	[NullableContext(0)]
	public enum EInfoDisplayViewEnum
	{
		// Token: 0x04026A92 RID: 158354
		TypeOne = 1,
		// Token: 0x04026A93 RID: 158355
		TypeTwo,
		// Token: 0x04026A94 RID: 158356
		TypeThree,
		// Token: 0x04026A95 RID: 158357
		TypeFour,
		// Token: 0x04026A96 RID: 158358
		TypeFive
	}
}
