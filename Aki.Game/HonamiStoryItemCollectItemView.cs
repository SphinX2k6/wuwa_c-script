using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013BB RID: 5051
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryItemCollectItemView : GridProxyAbstract<HonamiStoryItemCollectionData>
{
	// Token: 0x0600C82B RID: 51243 RVA: 0x003B9A80 File Offset: 0x003B7C80
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

	// Token: 0x0600C82C RID: 51244 RVA: 0x003B9B2C File Offset: 0x003B7D2C
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
		this.ItemIconBox = new SmallItemGrid();
		this.ItemIconBox.Initialize(base.GetItem(1).GetOwner());
	}

	// Token: 0x0600C82D RID: 51245 RVA: 0x003B9B78 File Offset: 0x003B7D78
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

	// Token: 0x0600C82E RID: 51246 RVA: 0x003B9CCA File Offset: 0x003B7ECA
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600C82F RID: 51247 RVA: 0x003B9CDD File Offset: 0x003B7EDD
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C830 RID: 51248 RVA: 0x003B9CF0 File Offset: 0x003B7EF0
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

	// Token: 0x040071D9 RID: 29145
	private HonamiStoryItemCollectionData ItemData;

	// Token: 0x040071DA RID: 29146
	private SmallItemGrid ItemIconBox;

	// Token: 0x040071DB RID: 29147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, HonamiStoryItemCollectionData> OnClickToggleBack;

	// Token: 0x040071DC RID: 29148
	public Func<int, bool> CanToggleChange;

	// Token: 0x0200767B RID: 30331
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026775 RID: 157557
		TogIllustrated,
		// Token: 0x04026776 RID: 157558
		ItemBaseBox,
		// Token: 0x04026777 RID: 157559
		TxtTitle,
		// Token: 0x04026778 RID: 157560
		TxtDesc,
		// Token: 0x04026779 RID: 157561
		SprGift
	}
}
