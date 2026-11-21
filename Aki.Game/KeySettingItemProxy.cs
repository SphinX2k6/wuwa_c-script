using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using UnrealEngine;

// Token: 0x020014FA RID: 5370
[NullableContext(1)]
[Nullable(0)]
public class KeySettingItemProxy
{
	// Token: 0x0600D681 RID: 54913 RVA: 0x003F9E73 File Offset: 0x003F8073
	public KeySettingItemProxy(IKeySettingItem item)
	{
		this.Item = item;
	}

	// Token: 0x0600D682 RID: 54914 RVA: 0x003F9E84 File Offset: 0x003F8084
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

	// Token: 0x0600D683 RID: 54915 RVA: 0x003F9F10 File Offset: 0x003F8110
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

	// Token: 0x0600D684 RID: 54916 RVA: 0x003F9F8C File Offset: 0x003F818C
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

	// Token: 0x0600D685 RID: 54917 RVA: 0x003F9FE6 File Offset: 0x003F81E6
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

	// Token: 0x0600D686 RID: 54918 RVA: 0x003FA014 File Offset: 0x003F8214
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

	// Token: 0x0600D687 RID: 54919 RVA: 0x003FA068 File Offset: 0x003F8268
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

	// Token: 0x0600D688 RID: 54920 RVA: 0x003FA29C File Offset: 0x003F849C
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

	// Token: 0x0600D689 RID: 54921 RVA: 0x003FA344 File Offset: 0x003F8544
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

	// Token: 0x0600D68A RID: 54922 RVA: 0x003FA390 File Offset: 0x003F8590
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

	// Token: 0x0600D68B RID: 54923 RVA: 0x003FA42D File Offset: 0x003F862D
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

	// Token: 0x0600D68C RID: 54924 RVA: 0x003FA450 File Offset: 0x003F8650
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

	// Token: 0x0600D68D RID: 54925 RVA: 0x003FA4D4 File Offset: 0x003F86D4
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

	// Token: 0x0600D68E RID: 54926 RVA: 0x003FA585 File Offset: 0x003F8785
	private void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
	{
		if (data == this.KeySettingRowData)
		{
			this.Refresh(data, KeySettingViewModel.InputControllerType);
		}
	}

	// Token: 0x0400784C RID: 30796
	[Nullable(2)]
	private KeySettingRowData KeySettingRowData;

	// Token: 0x0400784D RID: 30797
	private CSharpScript.Game.Module.Menu.EInputControllerType InputControllerType;

	// Token: 0x0400784E RID: 30798
	[Nullable(2)]
	private LevelSequencePlayer LoopSequencePlayer;

	// Token: 0x0400784F RID: 30799
	private readonly IKeySettingItem Item;
}
