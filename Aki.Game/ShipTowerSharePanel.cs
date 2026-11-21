using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F4C RID: 8012
public class ShipTowerSharePanel : UiPanelBase
{
	// Token: 0x06013D01 RID: 81153 RVA: 0x005C77A8 File Offset: 0x005C59A8
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

	// Token: 0x06013D02 RID: 81154 RVA: 0x005C7870 File Offset: 0x005C5A70
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

	// Token: 0x06013D03 RID: 81155 RVA: 0x005C7987 File Offset: 0x005C5B87
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

	// Token: 0x0400A917 RID: 43287
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerShareLineupItem, ShipTowerRecordItemData> LineupLayout;

	// Token: 0x02008240 RID: 33344
	private enum EShipTowerSharePanelComp
	{
		// Token: 0x0402A0E4 RID: 172260
		TxtJifenNum,
		// Token: 0x0402A0E5 RID: 172261
		TxtLunciNum,
		// Token: 0x0402A0E6 RID: 172262
		TexScore,
		// Token: 0x0402A0E7 RID: 172263
		PnlLineup,
		// Token: 0x0402A0E8 RID: 172264
		LineupItem,
		// Token: 0x0402A0E9 RID: 172265
		TxtDate,
		// Token: 0x0402A0EA RID: 172266
		PnlTips,
		// Token: 0x0402A0EB RID: 172267
		TxtTips
	}
}
