using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200041B RID: 1051
public class DrinksQTESectionItem : UiPanelBase
{
	// Token: 0x06003877 RID: 14455 RVA: 0x001489AC File Offset: 0x00146BAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06003878 RID: 14456 RVA: 0x00148A1C File Offset: 0x00146C1C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.Layout = new GenericLayout<DrinksQTESectionFlaovr, IQTEFlavorInfo>(base.GetHorizontalLayout(2), new Func<DrinksQTESectionFlaovr>(this.CreateFlavor), null, false, true);
	}

	// Token: 0x06003879 RID: 14457 RVA: 0x00148A50 File Offset: 0x00146C50
	public void ApplyDrinkData(int drinkId)
	{
		DrinksDrinkBase? drinkBase = DrinksConfig.Instance.GetDrinkBase(drinkId);
		List<IQTEFlavorInfo> list = new List<IQTEFlavorInfo>();
		foreach (KeyValuePair<int, int> keyValuePair in drinkBase.Value.Flavor())
		{
			QTEFlavorInfo item = new QTEFlavorInfo
			{
				Type = (EDrinksFlavorType)keyValuePair.Key,
				Value = keyValuePair.Value
			};
			list.Add(item);
		}
		this.Layout.RefreshByData(list, null, false);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha(1f);
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x00148B04 File Offset: 0x00146D04
	public void SetIsSelected(bool value)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAlpha(value ? 1f : 0.5f);
		}
		if (value)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x00148B54 File Offset: 0x00146D54
	[NullableContext(1)]
	private DrinksQTESectionFlaovr CreateFlavor()
	{
		return new DrinksQTESectionFlaovr();
	}

	// Token: 0x04002E60 RID: 11872
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DrinksQTESectionFlaovr, IQTEFlavorInfo> Layout;

	// Token: 0x04002E61 RID: 11873
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02006745 RID: 26437
	private static class ESection
	{
		// Token: 0x040221AC RID: 139692
		public const int PanelHighLight = 0;

		// Token: 0x040221AD RID: 139693
		public const int TxtContent = 1;

		// Token: 0x040221AE RID: 139694
		public const int FlavorLayout = 2;

		// Token: 0x040221AF RID: 139695
		public const int FlavorItem = 3;
	}
}
