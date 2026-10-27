using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EAC RID: 7852
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemTipsDetail : UiPanelBase
{
	// Token: 0x0600F169 RID: 61801 RVA: 0x003A1080 File Offset: 0x0039F280
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

	// Token: 0x0600F16A RID: 61802 RVA: 0x003A1160 File Offset: 0x0039F360
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryItemTipsDetail.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryItemTipsDetail.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F16B RID: 61803 RVA: 0x003A11A4 File Offset: 0x0039F3A4
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

	// Token: 0x0600F16C RID: 61804 RVA: 0x003A1241 File Offset: 0x0039F441
	public void AddHotKey(UUIItem hotKeyItem)
	{
		hotKeyItem.SetUIActive(true);
		hotKeyItem.SetUIParent(base.GetItem(4), false);
	}

	// Token: 0x0600F16D RID: 61805 RVA: 0x003A1258 File Offset: 0x0039F458
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

	// Token: 0x04006FAC RID: 28588
	private const int TIPS_OFFSET_WIDTH = 50;

	// Token: 0x04006FAD RID: 28589
	[Nullable(2)]
	private HonamiStoryWeaponTagItem TagItem;

	// Token: 0x02008480 RID: 33920
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B213 RID: 176659
		TxtName,
		// Token: 0x0402B214 RID: 176660
		TexIcon,
		// Token: 0x0402B215 RID: 176661
		TxtPrice,
		// Token: 0x0402B216 RID: 176662
		PnlList,
		// Token: 0x0402B217 RID: 176663
		PnlKeyDown,
		// Token: 0x0402B218 RID: 176664
		PnlKeyUp,
		// Token: 0x0402B219 RID: 176665
		PnlLocalOffsetX,
		// Token: 0x0402B21A RID: 176666
		PnlCheckOffsetY,
		// Token: 0x0402B21B RID: 176667
		PnlTypeTabItem
	}
}
