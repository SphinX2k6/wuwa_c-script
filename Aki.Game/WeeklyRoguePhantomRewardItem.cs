using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D36 RID: 11574
public class WeeklyRoguePhantomRewardItem : GridProxyAbstract<WeeklyRoguePhantomRewardInfo>
{
	// Token: 0x06018552 RID: 99666 RVA: 0x006317D4 File Offset: 0x0062F9D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickReduce))
		};
	}

	// Token: 0x06018553 RID: 99667 RVA: 0x006318AC File Offset: 0x0062FAAC
	protected override void OnStart()
	{
		this.InventoryGiftItem = new InventoryGiftCellItem();
		this.InventoryGiftItem.Initialize(base.GetItem(0).GetOwner());
		base.GetExtendToggle(3).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		this.ElementLayout = new GenericLayout<WeeklyRogueRewardFetterItem, int>(base.GetHorizontalLayout(4), new Func<WeeklyRogueRewardFetterItem>(this.CreateFetter), null, false, true);
	}

	// Token: 0x06018554 RID: 99668 RVA: 0x0063191C File Offset: 0x0062FB1C
	public override void Refresh(WeeklyRoguePhantomRewardInfo data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		RogueWeeklyBF? blackFlowerConfig = WeeklyRogueConfig.Instance.GetBlackFlowerConfig(data.AreaAwardId);
		if (blackFlowerConfig == null)
		{
			return;
		}
		this.SilentAreaId = blackFlowerConfig.Value.Id;
		GiftItemData giftItemData = new GiftItemData(blackFlowerConfig.Value.ShowItemId, 0, 0);
		this.InventoryGiftItem.RefreshByConfigId(giftItemData);
		List<int> source = new List<int>
		{
			blackFlowerConfig.Value.IconId1,
			blackFlowerConfig.Value.IconId2
		};
		GenericLayout<WeeklyRogueRewardFetterItem, int> elementLayout = this.ElementLayout;
		if (elementLayout != null)
		{
			elementLayout.RefreshByData(source.ToList<int>(), null, false);
		}
		SilentAreaDetection? silentAreaDetectionConfById = AdventureGuideConfig.Instance.GetSilentAreaDetectionConfById(blackFlowerConfig.Value.SilentAreaDetectionId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), silentAreaDetectionConfById.Value.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!data.IsActive);
		}
		if (data.IsActive)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.RootUIComp.Get().SetRaycastTarget(true);
			}
			if (this.IsSelectOnCb != null)
			{
				this.SetSelected(this.IsSelectOnCb(data.AreaAwardId), false);
			}
			return;
		}
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(3);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.RootUIComp.Get().SetRaycastTarget(false);
	}

	// Token: 0x06018555 RID: 99669 RVA: 0x00631AB7 File Offset: 0x0062FCB7
	[NullableContext(1)]
	private WeeklyRogueRewardFetterItem CreateFetter()
	{
		return new WeeklyRogueRewardFetterItem();
	}

	// Token: 0x06018556 RID: 99670 RVA: 0x00631ABE File Offset: 0x0062FCBE
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null)
		{
			this.SetSelected(this.IsSelectOnCb(this.SilentAreaId), false);
		}
	}

	// Token: 0x06018557 RID: 99671 RVA: 0x00631AE0 File Offset: 0x0062FCE0
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		base.GetExtendToggle(3).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(bSelectOn);
	}

	// Token: 0x06018558 RID: 99672 RVA: 0x00631B1E File Offset: 0x0062FD1E
	private void OnClickReduce()
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06018559 RID: 99673 RVA: 0x00631B28 File Offset: 0x0062FD28
	private void OnToggleStateChange(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
		if (this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(base.GetExtendToggle(3), base.GetButton(2), this.SilentAreaId, flag);
		}
	}

	// Token: 0x0400B4A6 RID: 46246
	protected WeeklyRoguePhantomRewardInfo Data;

	// Token: 0x0400B4A7 RID: 46247
	protected int SilentAreaId;

	// Token: 0x0400B4A8 RID: 46248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueRewardFetterItem, int> ElementLayout;

	// Token: 0x0400B4A9 RID: 46249
	[Nullable(1)]
	protected InventoryGiftCellItem InventoryGiftItem;

	// Token: 0x0400B4AA RID: 46250
	[Nullable(2)]
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x0400B4AB RID: 46251
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<UUIExtendToggle, UUIButtonComponent, int, bool> OnToggleStateChangeFunction;

	// Token: 0x020092C5 RID: 37573
	private enum EDefine
	{
		// Token: 0x0402F70F RID: 194319
		Item,
		// Token: 0x0402F710 RID: 194320
		TxtName,
		// Token: 0x0402F711 RID: 194321
		BtnReduce,
		// Token: 0x0402F712 RID: 194322
		Toggle,
		// Token: 0x0402F713 RID: 194323
		ElementLayout,
		// Token: 0x0402F714 RID: 194324
		ElementItem,
		// Token: 0x0402F715 RID: 194325
		PanelLock
	}
}
