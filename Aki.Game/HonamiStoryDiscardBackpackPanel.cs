using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001E91 RID: 7825
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryDiscardBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600EF9F RID: 61343 RVA: 0x00394FD0 File Offset: 0x003931D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600EFA0 RID: 61344 RVA: 0x0039506C File Offset: 0x0039326C
	protected override void OnStart()
	{
		this.DiscardItemList.Clear();
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
		{
			this.DiscardItemList.Add(new DiscardPair
			{
				NotActive = base.GetItem(4),
				Active = base.GetItem(5)
			});
			if (HonamiStoryUtil.IsMobileView())
			{
				this.DiscardItemList.Add(new DiscardPair
				{
					NotActive = base.GetItem(1),
					Active = base.GetItem(2)
				});
			}
			foreach (IDiscardPair discardPair in this.DiscardItemList)
			{
				discardPair.Active.SetUIActive(false);
				discardPair.NotActive.SetUIActive(true);
			}
		}
	}

	// Token: 0x0600EFA1 RID: 61345 RVA: 0x00395164 File Offset: 0x00393364
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		if (!HonamiStoryUtil.CheckInHonamiStoryDungeon())
		{
			return true;
		}
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(3, false);
		if (backPackData != null && backPackData.GetItemDataByInstanceId(item.GetIncId(), false) != null)
		{
			return true;
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		UUIItem item3 = base.GetItem(0);
		if (item3 != null)
		{
			item3.SetUIActive(HonamiStoryUtil.IsMobileView());
		}
		return true;
	}

	// Token: 0x0600EFA2 RID: 61346 RVA: 0x003951C8 File Offset: 0x003933C8
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		if (!HonamiStoryUtil.CheckInHonamiStoryDungeon())
		{
			return;
		}
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(3, false);
		if (backPackData != null && backPackData.GetItemDataByInstanceId(item.GetIncId(), false) != null)
		{
			return;
		}
		foreach (IDiscardPair discardPair in this.DiscardItemList)
		{
			discardPair.Active.SetUIActive(false);
			discardPair.NotActive.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(0);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(false);
	}

	// Token: 0x0600EFA3 RID: 61347 RVA: 0x00395278 File Offset: 0x00393478
	public override void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent)
	{
		IDiscardPair hoverDiscardItem = this.GetHoverDiscardItem(eventData);
		if (operateAgent.StartOperateBackpack.GetBackpackType() == 0 || operateAgent.StartOperateBackpack.GetBackpackType() == 2)
		{
			return;
		}
		if (hoverDiscardItem == null)
		{
			return;
		}
		if (this.CurrentDiscardItem == hoverDiscardItem)
		{
			return;
		}
		this.CurrentDiscardItem = hoverDiscardItem;
		this.CurrentDiscardItem.Active.SetUIActive(true);
		this.CurrentDiscardItem.NotActive.SetUIActive(false);
	}

	// Token: 0x0600EFA4 RID: 61348 RVA: 0x003952E0 File Offset: 0x003934E0
	public override void OnHoverEnd()
	{
		if (this.CurrentDiscardItem != null)
		{
			this.CurrentDiscardItem.Active.SetUIActive(false);
			this.CurrentDiscardItem.NotActive.SetUIActive(true);
			this.CurrentDiscardItem = null;
		}
	}

	// Token: 0x0600EFA5 RID: 61349 RVA: 0x00395314 File Offset: 0x00393514
	public override bool CheckDragItemInViewport(ULGUIPointerEventData eventData)
	{
		foreach (IDiscardPair discardPair in this.DiscardItemList)
		{
			if (HonamiStoryUtil.CheckEventDataInItemViewport(eventData, discardPair.Active, true))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600EFA6 RID: 61350 RVA: 0x00395378 File Offset: 0x00393578
	public override int GetBackpackType()
	{
		return 4;
	}

	// Token: 0x0600EFA7 RID: 61351 RVA: 0x0039537B File Offset: 0x0039357B
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase item)
	{
		return null;
	}

	// Token: 0x0600EFA8 RID: 61352 RVA: 0x0039537E File Offset: 0x0039357E
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600EFA9 RID: 61353 RVA: 0x00395381 File Offset: 0x00393581
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600EFAA RID: 61354 RVA: 0x00395384 File Offset: 0x00393584
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem)
	{
		return new HashSet<HonamiStoryItemDataBase>();
	}

	// Token: 0x0600EFAB RID: 61355 RVA: 0x0039538B File Offset: 0x0039358B
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
	}

	// Token: 0x0600EFAC RID: 61356 RVA: 0x0039538D File Offset: 0x0039358D
	public override List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext)
	{
		return new List<HonamiStoryGridItemBase>();
	}

	// Token: 0x0600EFAD RID: 61357 RVA: 0x00395394 File Offset: 0x00393594
	[return: Nullable(2)]
	private IDiscardPair GetHoverDiscardItem(ULGUIPointerEventData eventData)
	{
		foreach (IDiscardPair discardPair in this.DiscardItemList)
		{
			if (HonamiStoryUtil.CheckEventDataInItemViewport(eventData, discardPair.Active, true))
			{
				return discardPair;
			}
		}
		return null;
	}

	// Token: 0x04006EEE RID: 28398
	private readonly List<IDiscardPair> DiscardItemList = new List<IDiscardPair>();

	// Token: 0x04006EEF RID: 28399
	[Nullable(2)]
	private IDiscardPair CurrentDiscardItem;

	// Token: 0x02008440 RID: 33856
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B09D RID: 176285
		LeftDiscardItem,
		// Token: 0x0402B09E RID: 176286
		LeftNotHovering,
		// Token: 0x0402B09F RID: 176287
		LeftIsHovering,
		// Token: 0x0402B0A0 RID: 176288
		RightDiscardItem,
		// Token: 0x0402B0A1 RID: 176289
		RightNotHovering,
		// Token: 0x0402B0A2 RID: 176290
		RightIsHovering
	}
}
