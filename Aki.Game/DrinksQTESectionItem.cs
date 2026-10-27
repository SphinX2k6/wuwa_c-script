using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F66 RID: 3942
public class DrinksQTESectionItem : UiPanelBase
{
	// Token: 0x060064DF RID: 25823 RVA: 0x00140110 File Offset: 0x0013E310
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

	// Token: 0x060064E0 RID: 25824 RVA: 0x00140180 File Offset: 0x0013E380
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.Layout = new GenericLayout<DrinksQTESectionFlaovr, IQTEFlavorInfo>(base.GetHorizontalLayout(2), new Func<DrinksQTESectionFlaovr>(this.CreateFlavor), null, false, true);
	}

	// Token: 0x060064E1 RID: 25825 RVA: 0x001401B4 File Offset: 0x0013E3B4
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

	// Token: 0x060064E2 RID: 25826 RVA: 0x00140268 File Offset: 0x0013E468
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

	// Token: 0x060064E3 RID: 25827 RVA: 0x001402B8 File Offset: 0x0013E4B8
	[NullableContext(1)]
	private DrinksQTESectionFlaovr CreateFlavor()
	{
		return new DrinksQTESectionFlaovr();
	}

	// Token: 0x04002DC7 RID: 11719
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DrinksQTESectionFlaovr, IQTEFlavorInfo> Layout;

	// Token: 0x04002DC8 RID: 11720
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020075B1 RID: 30129
	private static class ESection
	{
		// Token: 0x04026E61 RID: 159329
		public const int PanelHighLight = 0;

		// Token: 0x04026E62 RID: 159330
		public const int TxtContent = 1;

		// Token: 0x04026E63 RID: 159331
		public const int FlavorLayout = 2;

		// Token: 0x04026E64 RID: 159332
		public const int FlavorItem = 3;
	}
}
