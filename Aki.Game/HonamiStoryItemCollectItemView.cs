using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EF9 RID: 7929
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryItemCollectItemView : GridProxyAbstract<HonamiStoryItemCollectionData>
{
	// Token: 0x0600F40C RID: 62476 RVA: 0x003ADF8C File Offset: 0x003AC18C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600F40D RID: 62477 RVA: 0x003AE038 File Offset: 0x003AC238
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
		this.ItemIconBox = new SmallItemGrid();
		this.ItemIconBox.Initialize(base.GetItem(1).GetOwner());
	}

	// Token: 0x0600F40E RID: 62478 RVA: 0x003AE084 File Offset: 0x003AC284
	[NullableContext(1)]
	public override void Refresh(HonamiStoryItemCollectionData itemData, bool isSelected, int gridIndex)
	{
		this.ItemData = itemData;
		base.GetExtendToggle(0).SetEnable(this.ItemData.State == EHonamiStoryCollectState.Unfinished);
		base.GetSprite(4).SetUIActive(this.ItemData.State == EHonamiStoryCollectState.Finished);
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = itemData,
			ItemConfigId = new int?(itemData.Id)
		};
		this.ItemIconBox.Apply<PropSmallItemGrid>(parameters);
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(itemData.Id);
		this.ItemIconBox.SetIconByPath(honamiStoryItem.Value.IconSmall);
		this.ItemIconBox.SetQuality(new int?(itemData.Id));
		this.ItemIconBox.SetLockBlackVisible(itemData.State == EHonamiStoryCollectState.Unfinished);
		if (this.ItemData.State != EHonamiStoryCollectState.Unfinished)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.ItemData.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.ItemData.Desc, Array.Empty<object>());
			return;
		}
		base.GetText(2).SetText("???", true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.ItemData.GetConfig.Access, Array.Empty<object>());
	}

	// Token: 0x0600F40F RID: 62479 RVA: 0x003AE1D6 File Offset: 0x003AC3D6
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600F410 RID: 62480 RVA: 0x003AE1E9 File Offset: 0x003AC3E9
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F411 RID: 62481 RVA: 0x003AE1FC File Offset: 0x003AC3FC
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.ItemData != null)
		{
			Action<int, HonamiStoryItemCollectionData> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GridIndex, this.ItemData);
		}
	}

	// Token: 0x040070F8 RID: 28920
	private HonamiStoryItemCollectionData ItemData;

	// Token: 0x040070F9 RID: 28921
	private SmallItemGrid ItemIconBox;

	// Token: 0x040070FA RID: 28922
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, HonamiStoryItemCollectionData> OnClickToggleBack;

	// Token: 0x040070FB RID: 28923
	public Func<int, bool> CanToggleChange;

	// Token: 0x020084F6 RID: 34038
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B451 RID: 177233
		TogIllustrated,
		// Token: 0x0402B452 RID: 177234
		ItemBaseBox,
		// Token: 0x0402B453 RID: 177235
		TxtTitle,
		// Token: 0x0402B454 RID: 177236
		TxtDesc,
		// Token: 0x0402B455 RID: 177237
		SprGift
	}
}
