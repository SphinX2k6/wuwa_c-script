using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F5B RID: 3931
[NullableContext(1)]
[Nullable(0)]
public class DrinksFlavorBubblePanel : UiPanelBase
{
	// Token: 0x06006492 RID: 25746 RVA: 0x0013E71E File Offset: 0x0013C91E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06006493 RID: 25747 RVA: 0x0013E758 File Offset: 0x0013C958
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksFlavorBubblePanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksFlavorBubblePanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006494 RID: 25748 RVA: 0x0013E79C File Offset: 0x0013C99C
	protected override void OnAfterShow()
	{
		Vector originPos = this.OriginPos;
		FVector uiworldPosition = this.RootItem.GetUIWorldPosition();
		originPos.FromUeVector(uiworldPosition);
	}

	// Token: 0x06006495 RID: 25749 RVA: 0x0013E7C2 File Offset: 0x0013C9C2
	public void RefreshOnStart()
	{
		this.Bubble1.SetUiActive(false);
		this.Bubble2.SetUiActive(false);
	}

	// Token: 0x06006496 RID: 25750 RVA: 0x0013E7DC File Offset: 0x0013C9DC
	public void Refresh()
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
		int[] array = new int[3];
		if (curStep == EDrinksPlayStep.Batching)
		{
			if (currentPlayData.Batching == null)
			{
				return;
			}
			using (IEnumerator<int> enumerator = currentPlayData.Batching.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int id = enumerator.Current;
					foreach (KeyValuePair<int, int> keyValuePair in DrinksConfig.Instance.GetBatching(id).Value.Flavor())
					{
						array[keyValuePair.Key] += keyValuePair.Value;
					}
				}
				goto IL_127;
			}
		}
		int index = (curStep > EDrinksPlayStep.Drink1) ? 1 : 0;
		foreach (KeyValuePair<int, int> keyValuePair2 in DrinksConfig.Instance.GetDrinkBase(currentPlayData.DrinkBase[index]).Value.Flavor())
		{
			array[keyValuePair2.Key] = keyValuePair2.Value;
		}
		IL_127:
		int num = 0;
		for (int i = 0; i < 3; i++)
		{
			if (array[i] > 0)
			{
				if (num < this.BubbleList.Count)
				{
					this.UpdateBubble(num, i, array[i]);
				}
				num++;
			}
		}
		for (int j = num; j < this.BubbleList.Count; j++)
		{
			this.BubbleList[j].SetUiActive(false);
		}
	}

	// Token: 0x06006497 RID: 25751 RVA: 0x0013E9A0 File Offset: 0x0013CBA0
	private void UpdateBubble(int index, int type, int value)
	{
		FVector uiworldPosition = this.RootItem.GetUIWorldPosition();
		float val = uiworldPosition.X + this.RootItem.GetWidth() / 2f * (float)((index < 1) ? -1 : 1);
		float min = uiworldPosition.Z + this.RootItem.GetHeight() / 2f;
		float max = uiworldPosition.Z - this.RootItem.GetHeight() / 2f;
		float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(Math.Min(uiworldPosition.X, val), Math.Max(uiworldPosition.X, val));
		float randomFloatNumber2 = MathUtils.Instance.GetRandomFloatNumber(min, max);
		this.BubbleList[index].SetUiActive(true);
		this.BubbleList[index].Refresh((EDrinksFlavorType)type, value, randomFloatNumber, randomFloatNumber2);
	}

	// Token: 0x04002DA6 RID: 11686
	protected DrinksFlavorBubble Bubble1;

	// Token: 0x04002DA7 RID: 11687
	protected DrinksFlavorBubble Bubble2;

	// Token: 0x04002DA8 RID: 11688
	protected List<DrinksFlavorBubble> BubbleList = new List<DrinksFlavorBubble>();

	// Token: 0x04002DA9 RID: 11689
	protected Vector OriginPos = Vector.Create();

	// Token: 0x020075A7 RID: 30119
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x04026E3C RID: 159292
		public const int Bubble1 = 0;

		// Token: 0x04026E3D RID: 159293
		public const int Bubble2 = 1;
	}
}
