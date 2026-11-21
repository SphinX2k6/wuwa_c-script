using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200136E RID: 4974
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsDetail : UiPanelBase
{
	// Token: 0x0600C588 RID: 50568 RVA: 0x003ACB88 File Offset: 0x003AAD88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x0600C589 RID: 50569 RVA: 0x003ACC68 File Offset: 0x003AAE68
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemTipsDetail.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemTipsDetail.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C58A RID: 50570 RVA: 0x003ACCAC File Offset: 0x003AAEAC
	public void Refresh(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetName(), Array.Empty<object>());
		base.GetText(2).SetText(data.GetSellPrice().ToString(), true);
		base.GetItem(8).SetUIActive(false);
		if (data.GetItemType() != EHonamiStoryItemType.Normal)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData = data as HonamiStoryEquipItemData;
			if (honamiStoryEquipItemData == null)
			{
				return;
			}
			if (honamiStoryEquipItemData.GetBuffTempIdList(false).Count == 0)
			{
				return;
			}
			if (honamiStoryEquipItemData.GetWeaponTag() == 0)
			{
				return;
			}
			this.TagItem.Refresh(honamiStoryEquipItemData.GetWeaponTag(), false, -1);
			base.GetItem(8).SetUIActive(true);
		}
	}

	// Token: 0x0600C58B RID: 50571 RVA: 0x003ACD49 File Offset: 0x003AAF49
	public void AddHotKey(UUIItem hotKeyItem)
	{
		hotKeyItem.SetUIActive(true);
		hotKeyItem.SetUIParent(base.GetItem(4), false);
	}

	// Token: 0x0600C58C RID: 50572 RVA: 0x003ACD60 File Offset: 0x003AAF60
	public void SetAutoLocation(UUIItem gridItem)
	{
		float x = base.GetText(0).GetTextRenderSize().X;
		Vector adaptiveTipsPosition = LguiUtil.Instance.GetAdaptiveTipsPosition(gridItem, this.RootItem, x + 50f);
		float width = base.GetItem(6).Width;
		float num = (gridItem.Height > gridItem.Width) ? (-gridItem.Width / 2f) : (-gridItem.Height / 2f);
		adaptiveTipsPosition.X += (double)width;
		adaptiveTipsPosition.Z += (double)num;
		FVector fvector = adaptiveTipsPosition.ToUeVectorOld();
		this.RootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x0400708D RID: 28813
	private const int TIPS_OFFSET_WIDTH = 50;

	// Token: 0x0400708E RID: 28814
	[Nullable(2)]
	private HonamiStoryWeaponTagItem TagItem;

	// Token: 0x02007605 RID: 30213
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026537 RID: 156983
		TxtName,
		// Token: 0x04026538 RID: 156984
		TexIcon,
		// Token: 0x04026539 RID: 156985
		TxtPrice,
		// Token: 0x0402653A RID: 156986
		PnlList,
		// Token: 0x0402653B RID: 156987
		PnlKeyDown,
		// Token: 0x0402653C RID: 156988
		PnlKeyUp,
		// Token: 0x0402653D RID: 156989
		PnlLocalOffsetX,
		// Token: 0x0402653E RID: 156990
		PnlCheckOffsetY,
		// Token: 0x0402653F RID: 156991
		PnlTypeTabItem
	}
}
