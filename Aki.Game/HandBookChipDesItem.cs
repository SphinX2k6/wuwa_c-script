using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DD7 RID: 7639
[NullableContext(2)]
[Nullable(0)]
public class HandBookChipDesItem : UiPanelBase
{
	// Token: 0x0600E87F RID: 59519 RVA: 0x003702B0 File Offset: 0x0036E4B0
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

	// Token: 0x0600E880 RID: 59520 RVA: 0x0037036F File Offset: 0x0036E56F
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
	}

	// Token: 0x0600E881 RID: 59521 RVA: 0x0037037E File Offset: 0x0036E57E
	private void OnToggleClicked(EToggleState state)
	{
		if (this.OnChildToggleCallback != null && state == EToggleState.ETT_Checked)
		{
			this.OnChildToggleCallback(this.ChipConfig.Value, this.Toggle);
		}
	}

	// Token: 0x0600E882 RID: 59522 RVA: 0x003703A8 File Offset: 0x0036E5A8
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

	// Token: 0x0600E883 RID: 59523 RVA: 0x003704B7 File Offset: 0x0036E6B7
	[NullableContext(1)]
	public void BindChildToggleCallback(TChildChipToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600E884 RID: 59524 RVA: 0x003704C0 File Offset: 0x0036E6C0
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

	// Token: 0x04006B8F RID: 27535
	private TChildChipToggleFunction OnChildToggleCallback;

	// Token: 0x04006B90 RID: 27536
	private ChipHandBook? ChipConfig;

	// Token: 0x04006B91 RID: 27537
	private bool IsLock;

	// Token: 0x04006B92 RID: 27538
	private UUIExtendToggle Toggle;
}
