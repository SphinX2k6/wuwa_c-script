using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001299 RID: 4761
[NullableContext(2)]
[Nullable(0)]
public class HandBookChipDesItem : UiPanelBase
{
	// Token: 0x0600BC9E RID: 48286 RVA: 0x0037BF9C File Offset: 0x0037A19C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClicked))
		};
	}

	// Token: 0x0600BC9F RID: 48287 RVA: 0x0037C05B File Offset: 0x0037A25B
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
	}

	// Token: 0x0600BCA0 RID: 48288 RVA: 0x0037C06A File Offset: 0x0037A26A
	private void OnToggleClicked(EToggleState state)
	{
		if (this.OnChildToggleCallback != null && state == EToggleState.ETT_Checked)
		{
			this.OnChildToggleCallback(this.ChipConfig.Value, this.Toggle);
		}
	}

	// Token: 0x0600BCA1 RID: 48289 RVA: 0x0037C094 File Offset: 0x0037A294
	public void Refresh(int data, bool isSelect)
	{
		ChipHandBook? chipHandBookConfig = HandBookConfig.Instance.GetChipHandBookConfig(data);
		this.ChipConfig = chipHandBookConfig;
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, chipHandBookConfig.Value.Id);
		bool isLock = handBookInfo == null;
		this.IsLock = isLock;
		base.GetItem(1).SetUIActive(this.IsLock);
		base.GetText(2).SetUIActive(!this.IsLock);
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(chipHandBookConfig.Value.Id);
		base.GetText(2).SetText(infoDisplayTitle, true);
		base.GetText(3).SetText(ConfigMultiTextLang.GetLocalTextNew("Text_Unknown_Text", null), true);
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(5);
		bool uiactive = handBookInfo != null && !handBookInfo.IsRead;
		item2.SetUIActive(this.IsLock);
		if (this.IsLock)
		{
			item.SetUIActive(false);
		}
		else
		{
			item.SetUIActive(uiactive);
		}
		if (isSelect)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}
	}

	// Token: 0x0600BCA2 RID: 48290 RVA: 0x0037C1A3 File Offset: 0x0037A3A3
	[NullableContext(1)]
	public void BindChildToggleCallback(TChildChipToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600BCA3 RID: 48291 RVA: 0x0037C1AC File Offset: 0x0037A3AC
	public void RefreshNewState()
	{
		if (this.ChipConfig == null)
		{
			return;
		}
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Chip, this.ChipConfig.Value.Id);
		bool uiactive = handBookInfo != null && !handBookInfo.IsRead;
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x04006C70 RID: 27760
	private TChildChipToggleFunction OnChildToggleCallback;

	// Token: 0x04006C71 RID: 27761
	private ChipHandBook? ChipConfig;

	// Token: 0x04006C72 RID: 27762
	private bool IsLock;

	// Token: 0x04006C73 RID: 27763
	private UUIExtendToggle Toggle;
}
