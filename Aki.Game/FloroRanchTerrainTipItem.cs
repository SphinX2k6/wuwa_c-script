using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BA6 RID: 7078
public class FloroRanchTerrainTipItem : UiPanelBase
{
	// Token: 0x0600D2BE RID: 53950 RVA: 0x003072AC File Offset: 0x003054AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D2BF RID: 53951 RVA: 0x00307318 File Offset: 0x00305518
	protected override void OnStart()
	{
		ITermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(1),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.FloroRanch,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600D2C0 RID: 53952 RVA: 0x0030735E File Offset: 0x0030555E
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
	}

	// Token: 0x0600D2C1 RID: 53953 RVA: 0x00307371 File Offset: 0x00305571
	[NullableContext(1)]
	public void RefreshInfoTipByEntity(FloroRanchEntityBase terrainEntity)
	{
		this.RefreshTerrainTip(terrainEntity);
	}

	// Token: 0x0600D2C2 RID: 53954 RVA: 0x0030737C File Offset: 0x0030557C
	[NullableContext(1)]
	private void RefreshTerrainTip(FloroRanchEntityBase terrainEntity)
	{
		if (terrainEntity == null)
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
			return;
		}
		else
		{
			FloroRanchTerrainDataComponent floroRanchTerrainDataComponent = terrainEntity.CheckGetComponent<FloroRanchTerrainDataComponent>();
			FloroRanchTerrainData floroRanchTerrainData = (floroRanchTerrainDataComponent != null) ? floroRanchTerrainDataComponent.TerrainData : null;
			if (floroRanchTerrainData == null)
			{
				UUIItem rootItem2 = base.GetRootItem();
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetUIActive(false);
				return;
			}
			else
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetText(floroRanchTerrainData.Name, true);
				}
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.SetText(floroRanchTerrainData.Desc, true);
				}
				UUIItem rootItem3 = base.GetRootItem();
				if (rootItem3 == null)
				{
					return;
				}
				rootItem3.SetUIActive(true);
				return;
			}
		}
	}

	// Token: 0x02008147 RID: 33095
	private class EComponentDefine
	{
		// Token: 0x0402A31F RID: 172831
		public const int TerrainName = 0;

		// Token: 0x0402A320 RID: 172832
		public const int TerrainDesc = 1;
	}
}
