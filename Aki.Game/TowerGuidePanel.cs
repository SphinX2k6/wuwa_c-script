using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BFA RID: 11258
public class TowerGuidePanel : UiPanelBase
{
	// Token: 0x06017627 RID: 95783 RVA: 0x005F33CC File Offset: 0x005F15CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017628 RID: 95784 RVA: 0x005F3498 File Offset: 0x005F1698
	protected override void OnStart()
	{
		this.BuffShowLayout = new GenericScrollViewNew<TowerBuffShowItem, long>(base.GetScrollViewWithScrollbar(4), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, null);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ImgHelp_DailyTower_001_UI");
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerGuideDes", Array.Empty<object>());
	}

	// Token: 0x06017629 RID: 95785 RVA: 0x005F350C File Offset: 0x005F170C
	protected override void OnBeforeShow()
	{
		int currentTowerId = TowerModel.Instance.CurrentTowerId;
		if (currentTowerId == 0)
		{
			return;
		}
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(currentTowerId);
		if (towerInfo == null)
		{
			return;
		}
		this.BuffShowLayout.RefreshByData(towerInfo.Value.ShowBuffs().ToList<long>(), null, false);
	}

	// Token: 0x0601762A RID: 95786 RVA: 0x005F355F File Offset: 0x005F175F
	[NullableContext(1)]
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x0400AEF7 RID: 44791
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x020091BE RID: 37310
	private enum EChildType
	{
		// Token: 0x0402F26E RID: 193134
		ItemOffset,
		// Token: 0x0402F26F RID: 193135
		TxtSubTitle,
		// Token: 0x0402F270 RID: 193136
		TxtTutorials,
		// Token: 0x0402F271 RID: 193137
		TexPicture,
		// Token: 0x0402F272 RID: 193138
		ScrollBuff
	}
}
