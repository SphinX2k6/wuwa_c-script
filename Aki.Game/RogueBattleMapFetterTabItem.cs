using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002770 RID: 10096
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RogueBattleMapFetterTabItem : GridProxyAbstract<IRogueBattleMapFetterTabInfo>
{
	// Token: 0x06014B21 RID: 84769 RVA: 0x0053CB84 File Offset: 0x0053AD84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06014B22 RID: 84770 RVA: 0x0053CC2D File Offset: 0x0053AE2D
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RogueBattleMapFetterTabChildItem, int>(base.GetVerticalLayout(3), new Func<RogueBattleMapFetterTabChildItem>(this.InitItem), null, false, true);
		EventSystem.Instance.Add(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnClickSelected));
	}

	// Token: 0x06014B23 RID: 84771 RVA: 0x0053CC6C File Offset: 0x0053AE6C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnClickSelected));
	}

	// Token: 0x06014B24 RID: 84772 RVA: 0x0053CC8C File Offset: 0x0053AE8C
	public override void Refresh(IRogueBattleMapFetterTabInfo data, bool isSelected, int gridIndex)
	{
		this.BondData = data;
		List<int> list = new List<int>();
		foreach (int item in data.Config)
		{
			list.Add(item);
		}
		this.Layout.RefreshByData(list, delegate
		{
			this.Layout.BindLateUpdate(delegate(float _)
			{
				EventSystem.Instance.Emit(EEventName.RogueResMapSummaryFettersSubTabUpdate);
				this.Layout.UnBindLateUpdate();
			});
		}, false);
		this.Layout.SetActive(data.IsSelected);
		this.SelectedTab(data.IsSelected);
		int id = data.Config[0];
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(id);
		RogueResSynergyType? rogueResBondTypeById = RogueBattleConfig.Instance.GetRogueResBondTypeById(rogueResBond.Value.Rarity);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueResBondTypeById.Value.SynergyTypeName, Array.Empty<object>());
	}

	// Token: 0x06014B25 RID: 84773 RVA: 0x0053CD80 File Offset: 0x0053AF80
	private void SelectedTab(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06014B26 RID: 84774 RVA: 0x0053CDA6 File Offset: 0x0053AFA6
	private void OnClickToggle(EToggleState state)
	{
		this.BondData.IsSelected = !this.BondData.IsSelected;
		GenericLayout<RogueBattleMapFetterTabChildItem, int> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.SetActive(this.BondData.IsSelected);
	}

	// Token: 0x06014B27 RID: 84775 RVA: 0x0053CDDC File Offset: 0x0053AFDC
	private RogueBattleMapFetterTabChildItem InitItem()
	{
		return new RogueBattleMapFetterTabChildItem
		{
			CanExecuteChangeFunction = new Func<int, EToggleState, bool>(this.CanExecuteChangeFunction)
		};
	}

	// Token: 0x06014B28 RID: 84776 RVA: 0x0053CDF8 File Offset: 0x0053AFF8
	private void OnClickSelected(int bondId)
	{
		int? currentSelected = this.CurrentSelected;
		this.CurrentSelected = (this.BondData.Config.Contains(bondId) ? new int?(bondId) : null);
		if (currentSelected != null)
		{
			int index = this.BondData.Config.IndexOf(currentSelected.Value);
			RogueBattleMapFetterTabChildItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(index);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetSelected(false);
			}
		}
		if (this.CurrentSelected == null)
		{
			return;
		}
		int gridIndex = this.BondData.Config.IndexOf(bondId);
		this.Layout.SelectGridProxy(gridIndex, false);
		RogueBattleMapFetterTabChildItem selectedProxy = this.Layout.GetSelectedProxy();
		if (selectedProxy == null)
		{
			return;
		}
		selectedProxy.SetSelected(true);
	}

	// Token: 0x06014B29 RID: 84777 RVA: 0x0053CEB4 File Offset: 0x0053B0B4
	private bool CanExecuteChangeFunction(int bondId, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			int? currentSelected = this.CurrentSelected;
			return !(currentSelected.GetValueOrDefault() == bondId & currentSelected != null);
		}
		return true;
	}

	// Token: 0x04009B9F RID: 39839
	[Nullable(2)]
	private IRogueBattleMapFetterTabInfo BondData;

	// Token: 0x04009BA0 RID: 39840
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RogueBattleMapFetterTabChildItem, int> Layout;

	// Token: 0x04009BA1 RID: 39841
	private int? CurrentSelected;
}
