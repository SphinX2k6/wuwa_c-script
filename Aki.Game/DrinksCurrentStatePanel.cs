using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200040D RID: 1037
[NullableContext(1)]
[Nullable(0)]
public class DrinksCurrentStatePanel : UiPanelBase
{
	// Token: 0x06003814 RID: 14356 RVA: 0x0014652C File Offset: 0x0014472C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06003815 RID: 14357 RVA: 0x00146588 File Offset: 0x00144788
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksCurrentStatePanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksCurrentStatePanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003816 RID: 14358 RVA: 0x001465CC File Offset: 0x001447CC
	protected override void OnStart()
	{
		foreach (DrinksFlavorValueItem drinksFlavorValueItem in this.ItemList)
		{
			drinksFlavorValueItem.RefreshState(false, new string[]
			{
				"0"
			}, false);
		}
	}

	// Token: 0x06003817 RID: 14359 RVA: 0x0014662C File Offset: 0x0014482C
	public void RefreshItem(EDrinksFlavorType id, bool isActive, string value, string plus = "", bool needAlpha = false)
	{
		List<string> list = new List<string>
		{
			value
		};
		if (plus != "")
		{
			list.Add(plus);
		}
		this.ItemList[(int)id].RefreshState(isActive, list.ToArray(), needAlpha);
	}

	// Token: 0x06003818 RID: 14360 RVA: 0x00146678 File Offset: 0x00144878
	public void UpdateStep()
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		int[] currentFlavorValueOnStart = DrinksModel.Instance.GetCurrentFlavorValueOnStart();
		DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
		if (curStep == EDrinksPlayStep.Drink1)
		{
			this.OnDrinkSelected(currentPlayData.DrinkBase[0]);
			return;
		}
		if (curStep == EDrinksPlayStep.Drink2)
		{
			this.OnDrinkSelected(currentPlayData.DrinkBase[1]);
			return;
		}
		if (curStep == EDrinksPlayStep.Batching)
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (currentPlayData.Batching != null)
			{
				foreach (int item in currentPlayData.Batching)
				{
					hashSet.Add(item);
				}
			}
			this.OnBatchingSelected(hashSet);
			return;
		}
		for (int i = 0; i < currentFlavorValueOnStart.Length; i++)
		{
			this.RefreshItem((EDrinksFlavorType)i, false, currentFlavorValueOnStart[i].ToString(), "", false);
		}
	}

	// Token: 0x06003819 RID: 14361 RVA: 0x00146764 File Offset: 0x00144964
	public void RefreshOnEnterSeq()
	{
		int[] currentFlavorValueForce = DrinksModel.Instance.GetCurrentFlavorValueForce();
		for (int i = 0; i < currentFlavorValueForce.Length; i++)
		{
			this.RefreshItem((EDrinksFlavorType)i, false, currentFlavorValueForce[i].ToString(), "", false);
		}
	}

	// Token: 0x0600381A RID: 14362 RVA: 0x001467A4 File Offset: 0x001449A4
	public void OnDrinkSelected(int id)
	{
		int[] currentFlavorValue = DrinksModel.Instance.GetCurrentFlavorValue();
		if (id == 0)
		{
			for (int i = 0; i < 3; i++)
			{
				this.RefreshItem((EDrinksFlavorType)i, false, currentFlavorValue[i].ToString(), "", false);
			}
			return;
		}
		DrinksDrinkBase? drinkBase = DrinksConfig.Instance.GetDrinkBase(id);
		Dictionary<int, int[]> drinksFlavorRange = DrinksModel.Instance.GetDrinksFlavorRange(drinkBase.Value.DrinkId);
		for (int j = 0; j < 3; j++)
		{
			if (drinkBase.Value.Flavor().ContainsKey(j))
			{
				int[] array = drinksFlavorRange[j];
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentFlavorValue[j] + array[0]);
				defaultInterpolatedStringHandler.AppendLiteral("~");
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentFlavorValue[j] + array[1]);
				string plus = defaultInterpolatedStringHandler.ToStringAndClear();
				EDrinksFlavorType id2 = (EDrinksFlavorType)j;
				bool isActive = drinkBase.Value.Flavor().ContainsKey(j);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentFlavorValue[j]);
				this.RefreshItem(id2, isActive, defaultInterpolatedStringHandler.ToStringAndClear(), plus, true);
			}
			else
			{
				EDrinksFlavorType id3 = (EDrinksFlavorType)j;
				bool isActive2 = drinkBase.Value.Flavor().ContainsKey(j);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(currentFlavorValue[j]);
				this.RefreshItem(id3, isActive2, defaultInterpolatedStringHandler.ToStringAndClear(), "", true);
			}
		}
	}

	// Token: 0x0600381B RID: 14363 RVA: 0x00146908 File Offset: 0x00144B08
	public void OnBatchingSelected(HashSet<int> set)
	{
		int[] currentFlavorValue = DrinksModel.Instance.GetCurrentFlavorValue();
		int[] array = new int[3];
		foreach (int id in set)
		{
			foreach (KeyValuePair<int, int> keyValuePair in DrinksConfig.Instance.GetBatching(id).Value.Flavor())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				array[key] += value;
			}
		}
		for (int i = 0; i < 3; i++)
		{
			this.RefreshItem((EDrinksFlavorType)i, array[i] != 0, currentFlavorValue[i].ToString(), (array[i] == 0) ? "" : (currentFlavorValue[i] + array[i]).ToString(), set.Count > 0);
		}
	}

	// Token: 0x04002E36 RID: 11830
	protected List<DrinksFlavorValueItem> ItemList = new List<DrinksFlavorValueItem>();

	// Token: 0x04002E37 RID: 11831
	[Nullable(2)]
	protected DrinksFlavorValueItem Item0;

	// Token: 0x04002E38 RID: 11832
	[Nullable(2)]
	protected DrinksFlavorValueItem Item1;

	// Token: 0x04002E39 RID: 11833
	[Nullable(2)]
	protected DrinksFlavorValueItem Item2;

	// Token: 0x02006737 RID: 26423
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x04022177 RID: 139639
		public const int Item0 = 0;

		// Token: 0x04022178 RID: 139640
		public const int Item1 = 1;

		// Token: 0x04022179 RID: 139641
		public const int Item2 = 2;
	}
}
