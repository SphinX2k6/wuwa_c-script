using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001065 RID: 4197
public class FloroRanchTerrainTipItem : UiPanelBase
{
	// Token: 0x0600A6CF RID: 42703 RVA: 0x0031238C File Offset: 0x0031058C
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

	// Token: 0x0600A6D0 RID: 42704 RVA: 0x003123F8 File Offset: 0x003105F8
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

	// Token: 0x0600A6D1 RID: 42705 RVA: 0x0031243E File Offset: 0x0031063E
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
	}

	// Token: 0x0600A6D2 RID: 42706 RVA: 0x00312451 File Offset: 0x00310651
	[NullableContext(1)]
	public void RefreshInfoTipByEntity(FloroRanchEntityBase terrainEntity)
	{
		this.RefreshTerrainTip(terrainEntity);
	}

	// Token: 0x0600A6D3 RID: 42707 RVA: 0x0031245C File Offset: 0x0031065C
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

	// Token: 0x020072D5 RID: 29397
	private class EComponentDefine
	{
		// Token: 0x04025653 RID: 153171
		public const int TerrainName = 0;

		// Token: 0x04025654 RID: 153172
		public const int TerrainDesc = 1;
	}
}
