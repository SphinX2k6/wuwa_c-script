using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002290 RID: 8848
public class WeeklyRoguePhantomRewardItem : GridProxyAbstract<WeeklyRoguePhantomRewardInfo>
{
	// Token: 0x06015DF4 RID: 89588 RVA: 0x006577E8 File Offset: 0x006559E8
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

	// Token: 0x06015DF5 RID: 89589 RVA: 0x006578C0 File Offset: 0x00655AC0
	protected override void OnStart()
	{
		this.InventoryGiftItem = new InventoryGiftCellItem();
		this.InventoryGiftItem.Initialize(base.GetItem(0).GetOwner());
		base.GetExtendToggle(3).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		this.ElementLayout = new GenericLayout<WeeklyRogueRewardFetterItem, int>(base.GetHorizontalLayout(4), new Func<WeeklyRogueRewardFetterItem>(this.CreateFetter), null, false, true);
	}

	// Token: 0x06015DF6 RID: 89590 RVA: 0x00657930 File Offset: 0x00655B30
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
		List<int> data2 = new List<int>
		{
			blackFlowerConfig.Value.IconId1,
			blackFlowerConfig.Value.IconId2
		};
		GenericLayout<WeeklyRogueRewardFetterItem, int> elementLayout = this.ElementLayout;
		if (elementLayout != null)
		{
			elementLayout.RefreshByData(data2, null, false);
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

	// Token: 0x06015DF7 RID: 89591 RVA: 0x00657AC6 File Offset: 0x00655CC6
	[NullableContext(1)]
	private WeeklyRogueRewardFetterItem CreateFetter()
	{
		return new WeeklyRogueRewardFetterItem();
	}

	// Token: 0x06015DF8 RID: 89592 RVA: 0x00657ACD File Offset: 0x00655CCD
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null)
		{
			this.SetSelected(this.IsSelectOnCb(this.SilentAreaId), false);
		}
	}

	// Token: 0x06015DF9 RID: 89593 RVA: 0x00657AF0 File Offset: 0x00655CF0
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		base.GetExtendToggle(3).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(bSelectOn);
	}

	// Token: 0x06015DFA RID: 89594 RVA: 0x00657B2E File Offset: 0x00655D2E
	private void OnClickReduce()
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06015DFB RID: 89595 RVA: 0x00657B38 File Offset: 0x00655D38
	private void OnToggleStateChange(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		base.GetButton(2).RootUIComp.Get().SetUIActive(flag);
		if (this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(base.GetExtendToggle(3), base.GetButton(2), this.SilentAreaId, flag);
		}
	}

	// Token: 0x0400B81B RID: 47131
	protected WeeklyRoguePhantomRewardInfo Data;

	// Token: 0x0400B81C RID: 47132
	protected int SilentAreaId;

	// Token: 0x0400B81D RID: 47133
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<WeeklyRogueRewardFetterItem, int> ElementLayout;

	// Token: 0x0400B81E RID: 47134
	[Nullable(1)]
	protected InventoryGiftCellItem InventoryGiftItem;

	// Token: 0x0400B81F RID: 47135
	[Nullable(2)]
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x0400B820 RID: 47136
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<UUIExtendToggle, UUIButtonComponent, int, bool> OnToggleStateChangeFunction;

	// Token: 0x020084EC RID: 34028
	private enum EDefine
	{
		// Token: 0x0402AD97 RID: 175511
		Item,
		// Token: 0x0402AD98 RID: 175512
		TxtName,
		// Token: 0x0402AD99 RID: 175513
		BtnReduce,
		// Token: 0x0402AD9A RID: 175514
		Toggle,
		// Token: 0x0402AD9B RID: 175515
		ElementLayout,
		// Token: 0x0402AD9C RID: 175516
		ElementItem,
		// Token: 0x0402AD9D RID: 175517
		PanelLock
	}
}
