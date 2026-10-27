using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029D1 RID: 10705
public class ShipTowerSharePanel : UiPanelBase
{
	// Token: 0x060162FB RID: 90875 RVA: 0x0059C7F0 File Offset: 0x0059A9F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
	}

	// Token: 0x060162FC RID: 90876 RVA: 0x0059C8B8 File Offset: 0x0059AAB8
	protected override void OnStart()
	{
		ShipTowerRecordShareData shipTowerRecordShareData = this.OpenParam as ShipTowerRecordShareData;
		if (shipTowerRecordShareData == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(shipTowerRecordShareData.TotalScore.ToString(), true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(shipTowerRecordShareData.TotalWave.ToString(), true);
		}
		UUIText text3 = base.GetText(5);
		if (text3 != null)
		{
			text3.SetText(shipTowerRecordShareData.DateText, true);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			bool flag = shipTowerRecordShareData.GradeResId != null;
			texture.SetUIActive(flag);
			if (flag)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(shipTowerRecordShareData.GradeResId);
				base.SetTextureByPath(resourcePath, texture, null, null);
			}
		}
		UUIItem item = base.GetItem(4);
		AUIBaseActor gridActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
		this.LineupLayout = new GenericLayout<ShipTowerShareLineupItem, ShipTowerRecordItemData>(base.GetVerticalLayout(3), () => new ShipTowerShareLineupItem(), gridActor, false, true);
		this.LineupLayout.RefreshByData(shipTowerRecordShareData.RecordList, null, false);
	}

	// Token: 0x060162FD RID: 90877 RVA: 0x0059C9CF File Offset: 0x0059ABCF
	[NullableContext(2)]
	public AActor GetBlurOverrideActor()
	{
		AUIBaseActor rootActor = this.RootActor;
		TsUiBlur tsUiBlur = ((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur;
		if (tsUiBlur == null)
		{
			return null;
		}
		return tsUiBlur.OverrideItem;
	}

	// Token: 0x0400A52D RID: 42285
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerShareLineupItem, ShipTowerRecordItemData> LineupLayout;

	// Token: 0x02008FF9 RID: 36857
	private enum EShipTowerSharePanelComp
	{
		// Token: 0x0402E9EC RID: 190956
		TxtJifenNum,
		// Token: 0x0402E9ED RID: 190957
		TxtLunciNum,
		// Token: 0x0402E9EE RID: 190958
		TexScore,
		// Token: 0x0402E9EF RID: 190959
		PnlLineup,
		// Token: 0x0402E9F0 RID: 190960
		LineupItem,
		// Token: 0x0402E9F1 RID: 190961
		TxtDate,
		// Token: 0x0402E9F2 RID: 190962
		PnlTips,
		// Token: 0x0402E9F3 RID: 190963
		TxtTips
	}
}
