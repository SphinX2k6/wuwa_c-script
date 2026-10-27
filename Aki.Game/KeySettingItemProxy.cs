using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using UnrealEngine;

// Token: 0x02002027 RID: 8231
[NullableContext(1)]
[Nullable(0)]
public class KeySettingItemProxy
{
	// Token: 0x06010219 RID: 66073 RVA: 0x003ED87B File Offset: 0x003EBA7B
	public KeySettingItemProxy(IKeySettingItem item)
	{
		this.Item = item;
	}

	// Token: 0x0601021A RID: 66074 RVA: 0x003ED88C File Offset: 0x003EBA8C
	public void OnStart()
	{
		this.Item.GetKeySetToggle().OnStateChange.Add(new Action<EToggleState>(this.OnKeySetButtonClicked));
		UUIButtonComponent cancelButton = this.Item.GetCancelButton();
		if (cancelButton != null)
		{
			cancelButton.OnClickCallBack.Bind(new Action(this.OnCancelButtonClicked));
		}
		this.LoopSequencePlayer = new LevelSequencePlayer(this.Item.GetCursorItem());
		KeySettingViewModel.AddOnKeySelectedDelegate(new Action<KeySettingRowData>(this.OnKeySelected));
		KeySettingViewModel.AddOnKeyChangeDelegate(new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnKeyChange));
	}

	// Token: 0x0601021B RID: 66075 RVA: 0x003ED918 File Offset: 0x003EBB18
	public void OnBeforeDestroy()
	{
		this.Item.GetKeySetToggle().OnStateChange.Remove(new Action<EToggleState>(this.OnKeySetButtonClicked));
		UUIButtonComponent cancelButton = this.Item.GetCancelButton();
		if (cancelButton != null)
		{
			cancelButton.OnClickCallBack.Unbind();
		}
		KeySettingViewModel.RemoveOnKeySelectedDelegate(new Action<KeySettingRowData>(this.OnKeySelected));
		KeySettingViewModel.RemoveOnKeyChangeDelegate(new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.OnKeyChange));
		LevelSequencePlayer loopSequencePlayer = this.LoopSequencePlayer;
		if (loopSequencePlayer == null)
		{
			return;
		}
		loopSequencePlayer.Clear();
	}

	// Token: 0x0601021C RID: 66076 RVA: 0x003ED994 File Offset: 0x003EBB94
	public void SetDetailItemVisible(bool bVisible)
	{
		UUIItem detailUiItem = this.Item.GetDetailUiItem();
		if (detailUiItem == null)
		{
			return;
		}
		if (this.KeySettingRowData == null)
		{
			detailUiItem.SetUIActive(false);
			return;
		}
		if (StringUtils.IsEmpty(this.KeySettingRowData.DetailTextId))
		{
			detailUiItem.SetUIActive(false);
			return;
		}
		detailUiItem.SetUIActive(bVisible);
		this.KeySettingRowData.IsExpandDetail = bVisible;
	}

	// Token: 0x0601021D RID: 66077 RVA: 0x003ED9EE File Offset: 0x003EBBEE
	public void Refresh(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		this.KeySettingRowData = data;
		this.InputControllerType = inputControllerType;
		this.RefreshTitleText();
		this.RefreshKeyNameText();
		this.RefreshDetailText();
		this.RefreshLock();
		this.RefreshDisableButton();
	}

	// Token: 0x0601021E RID: 66078 RVA: 0x003EDA1C File Offset: 0x003EBC1C
	private void RefreshTitleText()
	{
		UUIText titleUiText = this.Item.GetTitleUiText();
		string settingName = this.KeySettingRowData.GetSettingName();
		if (StringUtils.IsEmpty(settingName))
		{
			titleUiText.SetText(this.KeySettingRowData.GetActionOrAxisName(), true);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(titleUiText, settingName, Array.Empty<object>());
	}

	// Token: 0x0601021F RID: 66079 RVA: 0x003EDA70 File Offset: 0x003EBC70
	private unsafe void RefreshKeyNameText()
	{
		string buttonTextId = this.KeySettingRowData.ButtonTextId;
		if (buttonTextId != null && !StringUtils.IsBlank(buttonTextId))
		{
			LguiUtil.Instance.SetLocalTextNew(this.Item.GetKeyNameUiText(), buttonTextId, Array.Empty<object>());
			return;
		}
		string linkString = "+";
		List<string> bothActionName = this.KeySettingRowData.BothActionName;
		if (bothActionName != null && bothActionName.Count > 1)
		{
			linkString = "/";
		}
		string currentKeyNameRichText = this.KeySettingRowData.GetCurrentKeyNameRichText(this.InputControllerType, linkString);
		if (currentKeyNameRichText == null || currentKeyNameRichText.Length <= 0)
		{
			InputCombinationActionBinding inputCombinationActionBinding = this.KeySettingRowData.FindCombinationActionBinding();
			InputCombinationAxisBinding combinationAxisBinding = this.KeySettingRowData.CombinationAxisBinding;
			InputActionBinding actionBinding = this.KeySettingRowData.ActionBinding;
			InputAxisBinding axisBinding = this.KeySettingRowData.AxisBinding;
			List<string> list = new List<string>();
			if (actionBinding != null)
			{
				actionBinding.GetKeyNameListByBindingType(list, this.KeySettingRowData.BindingType);
			}
			List<string> list2 = new List<string>();
			if (axisBinding != null)
			{
				axisBinding.GetKeyNameListByBindingType(list2, this.KeySettingRowData.BindingType);
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (inputCombinationActionBinding != null)
			{
				inputCombinationActionBinding.GetKeyMapByBindingType(dictionary, this.KeySettingRowData.BindingType);
			}
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			if (combinationAxisBinding != null)
			{
				combinationAxisBinding.GetKeyMap(dictionary2, this.KeySettingRowData.BindingType);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "刷新按键设置项时，按键名称为空";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionOrAxisName", this.KeySettingRowData.GetActionOrAxisName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsActionOrAxis", this.KeySettingRowData.IsActionOrAxis);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActionBindingKeys", list);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AxisBindingKeys", list2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("combinationActionBindingKeyMap", dictionary);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("combinationAxisBindingKeyMap", dictionary2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			LguiUtil.Instance.SetLocalTextNew(this.Item.GetKeyNameUiText(), "NoneText", Array.Empty<object>());
			return;
		}
		this.Item.GetKeyNameUiText().SetText(currentKeyNameRichText, true);
	}

	// Token: 0x06010220 RID: 66080 RVA: 0x003EDCA4 File Offset: 0x003EBEA4
	private void RefreshDetailText()
	{
		if (this.Item.GetDetailUiItem() == null || this.Item.GetDetailUiText() == null || this.Item.GetDetailSprite() == null)
		{
			return;
		}
		if (this.KeySettingRowData.CanDisable)
		{
			this.Item.GetDetailSprite().SetUIActive(false);
			return;
		}
		string detailTextId = this.KeySettingRowData.DetailTextId;
		if (StringUtils.IsEmpty(detailTextId))
		{
			this.Item.GetDetailSprite().SetUIActive(false);
			return;
		}
		this.Item.GetDetailSprite().SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(this.Item.GetDetailUiText(), detailTextId, Array.Empty<object>());
	}

	// Token: 0x06010221 RID: 66081 RVA: 0x003EDD4C File Offset: 0x003EBF4C
	private void RefreshLock()
	{
		if (this.Item.GetLockSprite() == null)
		{
			return;
		}
		bool isLock = this.KeySettingRowData.IsLock;
		this.Item.GetLockSprite().SetUIActive(isLock);
		this.Item.GetKeySetToggle().SetSelfInteractive(!isLock);
	}

	// Token: 0x06010222 RID: 66082 RVA: 0x003EDD98 File Offset: 0x003EBF98
	private void RefreshDisableButton()
	{
		if (this.KeySettingRowData == null)
		{
			return;
		}
		UUIButtonComponent cancelButton = this.Item.GetCancelButton();
		if (cancelButton == null)
		{
			return;
		}
		AUIBaseActor auibaseActor = cancelButton.GetOwner() as AUIBaseActor;
		UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
		if (uuiitem == null)
		{
			return;
		}
		if (!this.KeySettingRowData.CanDisable)
		{
			uuiitem.SetUIActive(false);
			return;
		}
		if (this.KeySettingRowData.IsLock)
		{
			uuiitem.SetUIActive(false);
			return;
		}
		if (this.KeySettingRowData.IsBothAction())
		{
			uuiitem.SetUIActive(false);
			return;
		}
		if (this.KeySettingRowData.OpenViewType != EKeySettingOpenViewType.None)
		{
			uuiitem.SetUIActive(false);
			return;
		}
		uuiitem.SetUIActive(true);
	}

	// Token: 0x06010223 RID: 66083 RVA: 0x003EDE35 File Offset: 0x003EC035
	private void OnKeySetButtonClicked(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.KeySettingRowData == null)
		{
			return;
		}
		KeySettingViewModel.WaitKeySetting(this.KeySettingRowData, this.Item);
	}

	// Token: 0x06010224 RID: 66084 RVA: 0x003EDE58 File Offset: 0x003EC058
	private void OnCancelButtonClicked()
	{
		if (this.KeySettingRowData == null)
		{
			return;
		}
		if (this.KeySettingRowData.IsBothAction())
		{
			return;
		}
		if (this.KeySettingRowData.OpenViewType != EKeySettingOpenViewType.None)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InputSettings;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "按下清空按键按钮，清空此输入按键";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionOrAxisName", this.KeySettingRowData.GetActionOrAxisName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.KeySettingRowData.DisableKey(this.InputControllerType);
		this.RefreshKeyNameText();
		InputSettings.Instance.SaveKeyMappings();
	}

	// Token: 0x06010225 RID: 66085 RVA: 0x003EDEDC File Offset: 0x003EC0DC
	[NullableContext(2)]
	private void OnKeySelected(KeySettingRowData data)
	{
		UUISprite selectSprite = this.Item.GetSelectSprite();
		if (this.KeySettingRowData == null || selectSprite == null)
		{
			return;
		}
		bool flag = this.KeySettingRowData == data;
		selectSprite.SetUIActive(flag);
		this.Item.GetKeySetToggle().SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.Item.GetKeyNameUiText().SetUIActive(!flag);
		this.Item.GetCursorItem().SetUIActive(flag);
		if (flag)
		{
			LevelSequencePlayer loopSequencePlayer = this.LoopSequencePlayer;
			if (loopSequencePlayer == null)
			{
				return;
			}
			loopSequencePlayer.PlayLevelSequenceByName("Loop".ToString(), false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer loopSequencePlayer2 = this.LoopSequencePlayer;
			if (loopSequencePlayer2 == null)
			{
				return;
			}
			loopSequencePlayer2.StopCurrentSequence(false, false);
			return;
		}
	}

	// Token: 0x06010226 RID: 66086 RVA: 0x003EDF8D File Offset: 0x003EC18D
	private void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (data == this.KeySettingRowData)
		{
			this.Refresh(data, KeySettingViewModel.InputControllerType);
		}
	}

	// Token: 0x04007763 RID: 30563
	[Nullable(2)]
	private KeySettingRowData KeySettingRowData;

	// Token: 0x04007764 RID: 30564
	private CSharpScript.Game.Module.Menu.EInputControllerType InputControllerType;

	// Token: 0x04007765 RID: 30565
	[Nullable(2)]
	private LevelSequencePlayer LoopSequencePlayer;

	// Token: 0x04007766 RID: 30566
	private readonly IKeySettingItem Item;
}
