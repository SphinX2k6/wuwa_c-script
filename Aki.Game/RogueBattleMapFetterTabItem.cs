using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C5B RID: 7259
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RogueBattleMapFetterTabItem : GridProxyAbstract<IRogueBattleMapFetterTabInfo>
{
	// Token: 0x06012004 RID: 73732 RVA: 0x0054B994 File Offset: 0x00549B94
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

	// Token: 0x06012005 RID: 73733 RVA: 0x0054BA3D File Offset: 0x00549C3D
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RogueBattleMapFetterTabChildItem, int>(base.GetVerticalLayout(3), new Func<RogueBattleMapFetterTabChildItem>(this.InitItem), null, false, true);
		EventSystem.Instance.Add(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnClickSelected));
	}

	// Token: 0x06012006 RID: 73734 RVA: 0x0054BA7C File Offset: 0x00549C7C
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnClickSelected));
	}

	// Token: 0x06012007 RID: 73735 RVA: 0x0054BA9C File Offset: 0x00549C9C
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

	// Token: 0x06012008 RID: 73736 RVA: 0x0054BB90 File Offset: 0x00549D90
	private void SelectedTab(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06012009 RID: 73737 RVA: 0x0054BBB6 File Offset: 0x00549DB6
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

	// Token: 0x0601200A RID: 73738 RVA: 0x0054BBEC File Offset: 0x00549DEC
	private RogueBattleMapFetterTabChildItem InitItem()
	{
		return new RogueBattleMapFetterTabChildItem
		{
			CanExecuteChangeFunction = new Func<int, EToggleState, bool>(this.CanExecuteChangeFunction)
		};
	}

	// Token: 0x0601200B RID: 73739 RVA: 0x0054BC08 File Offset: 0x00549E08
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

	// Token: 0x0601200C RID: 73740 RVA: 0x0054BCC4 File Offset: 0x00549EC4
	private bool CanExecuteChangeFunction(int bondId, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			int? currentSelected = this.CurrentSelected;
			return !(currentSelected.GetValueOrDefault() == bondId & currentSelected != null);
		}
		return true;
	}

	// Token: 0x04009CF7 RID: 40183
	[Nullable(2)]
	private IRogueBattleMapFetterTabInfo BondData;

	// Token: 0x04009CF8 RID: 40184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RogueBattleMapFetterTabChildItem, int> Layout;

	// Token: 0x04009CF9 RID: 40185
	private int? CurrentSelected;
}
