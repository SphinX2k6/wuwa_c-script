using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200217A RID: 8570
public class TowerRecommendView : UiViewBase
{
	// Token: 0x06015086 RID: 86150 RVA: 0x006218EC File Offset: 0x0061FAEC
	[NullableContext(1)]
	public TowerRecommendView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015087 RID: 86151 RVA: 0x006218F5 File Offset: 0x0061FAF5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06015088 RID: 86152 RVA: 0x0062192E File Offset: 0x0061FB2E
	protected override void OnStart()
	{
		this.FormationScroll = new GenericScrollViewNew<TowerRecommendItem, TowerRecommendFormation>(base.GetScrollViewWithScrollbar(0), new Func<TowerRecommendItem>(this.RefreshItem), null, false, null);
		this.RefreshView();
	}

	// Token: 0x06015089 RID: 86153 RVA: 0x00621957 File Offset: 0x0061FB57
	protected override void OnBeforeDestroy()
	{
		this.FormationScroll = null;
	}

	// Token: 0x0601508A RID: 86154 RVA: 0x00621960 File Offset: 0x0061FB60
	private void RefreshView()
	{
		if (TowerModel.Instance.RecommendFormation != null && TowerModel.Instance.RecommendFormation.Length != 0)
		{
			this.FormationScroll.SetActive(true);
			List<TowerRecommendFormation> list = new List<TowerRecommendFormation>();
			int num = TowerModel.Instance.RecommendFormation.Length;
			for (int i = 0; i < num; i++)
			{
				list.Add(TowerModel.Instance.RecommendFormation[i]);
			}
			this.FormationScroll.RefreshByData(list, null, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_DataFromOther_Text", Array.Empty<object>());
			return;
		}
		this.FormationScroll.SetActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_DataCollation_Text", Array.Empty<object>());
	}

	// Token: 0x0601508B RID: 86155 RVA: 0x00621A14 File Offset: 0x0061FC14
	[NullableContext(1)]
	private TowerRecommendItem RefreshItem()
	{
		return new TowerRecommendItem();
	}

	// Token: 0x0400B30C RID: 45836
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerRecommendItem, TowerRecommendFormation> FormationScroll;

	// Token: 0x02008409 RID: 33801
	private enum EChildType
	{
		// Token: 0x0402A9B1 RID: 174513
		ScrollView,
		// Token: 0x0402A9B2 RID: 174514
		TipText
	}
}
