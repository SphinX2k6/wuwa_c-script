using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002175 RID: 8565
public class TowerGuidePanel : UiPanelBase
{
	// Token: 0x06015058 RID: 86104 RVA: 0x0061FF08 File Offset: 0x0061E108
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

	// Token: 0x06015059 RID: 86105 RVA: 0x0061FFD4 File Offset: 0x0061E1D4
	protected override void OnStart()
	{
		this.BuffShowLayout = new GenericScrollViewNew<TowerBuffShowItem, long>(base.GetScrollViewWithScrollbar(4), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, null);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ImgHelp_DailyTower_001_UI");
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "TowerGuideDes", Array.Empty<object>());
	}

	// Token: 0x0601505A RID: 86106 RVA: 0x00620048 File Offset: 0x0061E248
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
		this.BuffShowLayout.RefreshByData(towerInfo.Value.ShowBuffs(), null, false);
	}

	// Token: 0x0601505B RID: 86107 RVA: 0x00620096 File Offset: 0x0061E296
	[NullableContext(1)]
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x0400B2FC RID: 45820
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x02008401 RID: 33793
	private enum EChildType
	{
		// Token: 0x0402A96F RID: 174447
		ItemOffset,
		// Token: 0x0402A970 RID: 174448
		TxtSubTitle,
		// Token: 0x0402A971 RID: 174449
		TxtTutorials,
		// Token: 0x0402A972 RID: 174450
		TexPicture,
		// Token: 0x0402A973 RID: 174451
		ScrollBuff
	}
}
