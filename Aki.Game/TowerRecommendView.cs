using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BFF RID: 11263
public class TowerRecommendView : UiViewBase
{
	// Token: 0x06017655 RID: 95829 RVA: 0x005F4DC4 File Offset: 0x005F2FC4
	[NullableContext(1)]
	public TowerRecommendView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06017656 RID: 95830 RVA: 0x005F4DCD File Offset: 0x005F2FCD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06017657 RID: 95831 RVA: 0x005F4E06 File Offset: 0x005F3006
	protected override void OnStart()
	{
		this.FormationScroll = new GenericScrollViewNew<TowerRecommendItem, TowerRecommendFormation>(base.GetScrollViewWithScrollbar(0), new Func<TowerRecommendItem>(this.RefreshItem), null, false, null);
		this.RefreshView();
	}

	// Token: 0x06017658 RID: 95832 RVA: 0x005F4E2F File Offset: 0x005F302F
	protected override void OnBeforeDestroy()
	{
		this.FormationScroll = null;
	}

	// Token: 0x06017659 RID: 95833 RVA: 0x005F4E38 File Offset: 0x005F3038
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

	// Token: 0x0601765A RID: 95834 RVA: 0x005F4EEC File Offset: 0x005F30EC
	[NullableContext(1)]
	private TowerRecommendItem RefreshItem()
	{
		return new TowerRecommendItem();
	}

	// Token: 0x0400AF07 RID: 44807
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<TowerRecommendItem, TowerRecommendFormation> FormationScroll;

	// Token: 0x020091C6 RID: 37318
	private enum EChildType
	{
		// Token: 0x0402F2B0 RID: 193200
		ScrollView,
		// Token: 0x0402F2B1 RID: 193201
		TipText
	}
}
