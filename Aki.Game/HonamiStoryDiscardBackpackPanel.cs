using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001353 RID: 4947
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryDiscardBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600C3BE RID: 50110 RVA: 0x003A0B8C File Offset: 0x0039ED8C
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

	// Token: 0x0600C3BF RID: 50111 RVA: 0x003A0C28 File Offset: 0x0039EE28
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

	// Token: 0x0600C3C0 RID: 50112 RVA: 0x003A0D20 File Offset: 0x0039EF20
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

	// Token: 0x0600C3C1 RID: 50113 RVA: 0x003A0D84 File Offset: 0x0039EF84
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

	// Token: 0x0600C3C2 RID: 50114 RVA: 0x003A0E34 File Offset: 0x0039F034
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

	// Token: 0x0600C3C3 RID: 50115 RVA: 0x003A0E9C File Offset: 0x0039F09C
	public override void OnHoverEnd()
	{
		if (this.CurrentDiscardItem != null)
		{
			this.CurrentDiscardItem.Active.SetUIActive(false);
			this.CurrentDiscardItem.NotActive.SetUIActive(true);
			this.CurrentDiscardItem = null;
		}
	}

	// Token: 0x0600C3C4 RID: 50116 RVA: 0x003A0ED0 File Offset: 0x0039F0D0
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

	// Token: 0x0600C3C5 RID: 50117 RVA: 0x003A0F34 File Offset: 0x0039F134
	public override int GetBackpackType()
	{
		return 4;
	}

	// Token: 0x0600C3C6 RID: 50118 RVA: 0x003A0F37 File Offset: 0x0039F137
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase item)
	{
		return null;
	}

	// Token: 0x0600C3C7 RID: 50119 RVA: 0x003A0F3A File Offset: 0x0039F13A
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600C3C8 RID: 50120 RVA: 0x003A0F3D File Offset: 0x0039F13D
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600C3C9 RID: 50121 RVA: 0x003A0F40 File Offset: 0x0039F140
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem)
	{
		return new HashSet<HonamiStoryItemDataBase>();
	}

	// Token: 0x0600C3CA RID: 50122 RVA: 0x003A0F47 File Offset: 0x0039F147
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
	}

	// Token: 0x0600C3CB RID: 50123 RVA: 0x003A0F49 File Offset: 0x0039F149
	public override List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext)
	{
		return new List<HonamiStoryGridItemBase>();
	}

	// Token: 0x0600C3CC RID: 50124 RVA: 0x003A0F50 File Offset: 0x0039F150
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

	// Token: 0x04006FCF RID: 28623
	private readonly List<IDiscardPair> DiscardItemList = new List<IDiscardPair>();

	// Token: 0x04006FD0 RID: 28624
	[Nullable(2)]
	private IDiscardPair CurrentDiscardItem;

	// Token: 0x020075C5 RID: 30149
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040263C1 RID: 156609
		LeftDiscardItem,
		// Token: 0x040263C2 RID: 156610
		LeftNotHovering,
		// Token: 0x040263C3 RID: 156611
		LeftIsHovering,
		// Token: 0x040263C4 RID: 156612
		RightDiscardItem,
		// Token: 0x040263C5 RID: 156613
		RightNotHovering,
		// Token: 0x040263C6 RID: 156614
		RightIsHovering
	}
}
