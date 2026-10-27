using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022F6 RID: 8950
public class OnlineSettingView : UiViewBase
{
	// Token: 0x06011A5D RID: 72285 RVA: 0x004556F6 File Offset: 0x004538F6
	[NullableContext(1)]
	public OnlineSettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A5E RID: 72286 RVA: 0x00455700 File Offset: 0x00453900
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

	// Token: 0x06011A5F RID: 72287 RVA: 0x004557C7 File Offset: 0x004539C7
	protected override void OnBeforeShow()
	{
		this.EditSetting = OnlineModel.Instance.CurrentPermissionsSetting;
		this.InitSettingToggle();
	}

	// Token: 0x06011A60 RID: 72288 RVA: 0x004557DF File Offset: 0x004539DF
	protected override void OnBeforeDestroy()
	{
		if (this.SettingButtonType != null)
		{
			this.SettingButtonType.Clear();
		}
		this.SettingButtonType = null;
	}

	// Token: 0x06011A61 RID: 72289 RVA: 0x004557FC File Offset: 0x004539FC
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

	// Token: 0x06011A62 RID: 72290 RVA: 0x004558D4 File Offset: 0x00453AD4
	[NullableContext(1)]
	private void CreateSettingButton(AActor uiContainerActor, int type)
	{
		OnlineHallSettingButton onlineHallSettingButton = new OnlineHallSettingButton(uiContainerActor, (WorldEnterPermission)type);
		onlineHallSettingButton.BindOnSettingButtonClickedCallback(new Action<WorldEnterPermission>(this.OnClickSettingBtn));
		onlineHallSettingButton.BindCanToggleExecuteChange(new Func<WorldEnterPermission, bool>(this.CanToggleChange));
		this.SettingButtonType.Add(type, onlineHallSettingButton);
	}

	// Token: 0x06011A63 RID: 72291 RVA: 0x0045591A File Offset: 0x00453B1A
	private bool CanToggleChange(WorldEnterPermission type)
	{
		return this.EditSetting != type;
	}

	// Token: 0x06011A64 RID: 72292 RVA: 0x00455928 File Offset: 0x00453B28
	private void OnClickSettingConfirmBtn()
	{
		OnlineController.Instance.WorldEnterPermissionsRequest(this.EditSetting);
		base.CloseMe(null);
	}

	// Token: 0x06011A65 RID: 72293 RVA: 0x00455944 File Offset: 0x00453B44
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

	// Token: 0x040085E1 RID: 34273
	private const int SETTING_COUNT_ID = 4;

	// Token: 0x040085E2 RID: 34274
	private WorldEnterPermission EditSetting;

	// Token: 0x040085E3 RID: 34275
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, OnlineHallSettingButton> SettingButtonType;

	// Token: 0x02008878 RID: 34936
	private enum EOnlineSettingView
	{
		// Token: 0x0402C5A6 RID: 181670
		SettingToggleGroup,
		// Token: 0x0402C5A7 RID: 181671
		SettingToggle,
		// Token: 0x0402C5A8 RID: 181672
		SettingConfirm
	}
}
