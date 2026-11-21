using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017DA RID: 6106
public class OnlineSettingView : UiViewBase
{
	// Token: 0x0600EEF5 RID: 61173 RVA: 0x004623C2 File Offset: 0x004605C2
	[NullableContext(1)]
	public OnlineSettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EEF6 RID: 61174 RVA: 0x004623CC File Offset: 0x004605CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickSettingConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EEF7 RID: 61175 RVA: 0x00462493 File Offset: 0x00460693
	protected override void OnBeforeShow()
	{
		this.EditSetting = OnlineModel.Instance.CurrentPermissionsSetting;
		this.InitSettingToggle();
	}

	// Token: 0x0600EEF8 RID: 61176 RVA: 0x004624AB File Offset: 0x004606AB
	protected override void OnBeforeDestroy()
	{
		if (this.SettingButtonType != null)
		{
			this.SettingButtonType.Clear();
		}
		this.SettingButtonType = null;
	}

	// Token: 0x0600EEF9 RID: 61177 RVA: 0x004624C8 File Offset: 0x004606C8
	private void InitSettingToggle()
	{
		this.SettingButtonType = new Dictionary<int, OnlineHallSettingButton>();
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(0);
		this.CreateSettingButton(item.GetOwner(), 0);
		for (int i = 1; i < 4; i++)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, item2);
			this.CreateSettingButton(uuiitem.GetOwner(), i);
		}
		this.EditSetting = OnlineModel.Instance.CurrentPermissionsSetting;
		foreach (KeyValuePair<int, OnlineHallSettingButton> keyValuePair in this.SettingButtonType)
		{
			if (keyValuePair.Key == (int)this.EditSetting)
			{
				keyValuePair.Value.SetSelected(true);
			}
			else
			{
				keyValuePair.Value.SetSelected(false);
			}
		}
	}

	// Token: 0x0600EEFA RID: 61178 RVA: 0x004625A0 File Offset: 0x004607A0
	[NullableContext(1)]
	private void CreateSettingButton(AActor uiContainerActor, int type)
	{
		OnlineHallSettingButton onlineHallSettingButton = new OnlineHallSettingButton(uiContainerActor, (WorldEnterPermission)type);
		onlineHallSettingButton.BindOnSettingButtonClickedCallback(new Action<WorldEnterPermission>(this.OnClickSettingBtn));
		onlineHallSettingButton.BindCanToggleExecuteChange(new Func<WorldEnterPermission, bool>(this.CanToggleChange));
		this.SettingButtonType.Add(type, onlineHallSettingButton);
	}

	// Token: 0x0600EEFB RID: 61179 RVA: 0x004625E6 File Offset: 0x004607E6
	private bool CanToggleChange(WorldEnterPermission type)
	{
		return this.EditSetting != type;
	}

	// Token: 0x0600EEFC RID: 61180 RVA: 0x004625F4 File Offset: 0x004607F4
	private void OnClickSettingConfirmBtn()
	{
		OnlineController.Instance.WorldEnterPermissionsRequest(this.EditSetting);
		base.CloseMe(null);
	}

	// Token: 0x0600EEFD RID: 61181 RVA: 0x00462610 File Offset: 0x00460810
	private void OnClickSettingBtn(WorldEnterPermission type)
	{
		this.EditSetting = type;
		foreach (KeyValuePair<int, OnlineHallSettingButton> keyValuePair in this.SettingButtonType)
		{
			if (keyValuePair.Key == (int)this.EditSetting)
			{
				keyValuePair.Value.SetSelected(true);
			}
			else
			{
				keyValuePair.Value.SetSelected(false);
			}
		}
	}

	// Token: 0x0400871F RID: 34591
	private const int SETTING_COUNT_ID = 4;

	// Token: 0x04008720 RID: 34592
	private WorldEnterPermission EditSetting;

	// Token: 0x04008721 RID: 34593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineHallSettingButton> SettingButtonType;

	// Token: 0x020079FC RID: 31228
	private enum EOnlineSettingView
	{
		// Token: 0x040278A8 RID: 161960
		SettingToggleGroup,
		// Token: 0x040278A9 RID: 161961
		SettingToggle,
		// Token: 0x040278AA RID: 161962
		SettingConfirm
	}
}
