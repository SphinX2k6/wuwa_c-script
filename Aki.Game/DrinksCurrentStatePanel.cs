using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F58 RID: 3928
[NullableContext(1)]
[Nullable(0)]
public class DrinksCurrentStatePanel : UiPanelBase
{
	// Token: 0x0600647C RID: 25724 RVA: 0x0013DC90 File Offset: 0x0013BE90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600647D RID: 25725 RVA: 0x0013DCEC File Offset: 0x0013BEEC
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksCurrentStatePanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksCurrentStatePanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600647E RID: 25726 RVA: 0x0013DD30 File Offset: 0x0013BF30
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

	// Token: 0x0600647F RID: 25727 RVA: 0x0013DD90 File Offset: 0x0013BF90
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

	// Token: 0x06006480 RID: 25728 RVA: 0x0013DDDC File Offset: 0x0013BFDC
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

	// Token: 0x06006481 RID: 25729 RVA: 0x0013DEC8 File Offset: 0x0013C0C8
	public void RefreshOnEnterSeq()
	{
		int[] currentFlavorValueForce = DrinksModel.Instance.GetCurrentFlavorValueForce();
		for (int i = 0; i < currentFlavorValueForce.Length; i++)
		{
			this.RefreshItem((EDrinksFlavorType)i, false, currentFlavorValueForce[i].ToString(), "", false);
		}
	}

	// Token: 0x06006482 RID: 25730 RVA: 0x0013DF08 File Offset: 0x0013C108
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

	// Token: 0x06006483 RID: 25731 RVA: 0x0013E06C File Offset: 0x0013C26C
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

	// Token: 0x04002D9D RID: 11677
	protected List<DrinksFlavorValueItem> ItemList = new List<DrinksFlavorValueItem>();

	// Token: 0x04002D9E RID: 11678
	[Nullable(2)]
	protected DrinksFlavorValueItem Item0;

	// Token: 0x04002D9F RID: 11679
	[Nullable(2)]
	protected DrinksFlavorValueItem Item1;

	// Token: 0x04002DA0 RID: 11680
	[Nullable(2)]
	protected DrinksFlavorValueItem Item2;

	// Token: 0x020075A3 RID: 30115
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x04026E2C RID: 159276
		public const int Item0 = 0;

		// Token: 0x04026E2D RID: 159277
		public const int Item1 = 1;

		// Token: 0x04026E2E RID: 159278
		public const int Item2 = 2;
	}
}
