using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200040A RID: 1034
[NullableContext(1)]
[Nullable(0)]
public class DrinksBubblePanel : UiPanelBase
{
	// Token: 0x06003803 RID: 14339 RVA: 0x001460A8 File Offset: 0x001442A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06003804 RID: 14340 RVA: 0x00146104 File Offset: 0x00144304
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksBubblePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksBubblePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003805 RID: 14341 RVA: 0x00146147 File Offset: 0x00144347
	protected override void OnBeforeShow()
	{
		this.Bubble1.SetUiActive(false);
		this.Bubble2.SetUiActive(false);
		this.Bubble3.SetUiActive(false);
	}

	// Token: 0x06003806 RID: 14342 RVA: 0x00146170 File Offset: 0x00144370
	public void UpdateState(bool isEnd)
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
		if (curStep == EDrinksPlayStep.Ornament)
		{
			this.Bubble1.SetIsVisible(false, false);
			this.Bubble2.SetIsVisible(false, false);
			this.Bubble3.SetIsVisible(false, false);
			return;
		}
		if (curStep == EDrinksPlayStep.Drink1)
		{
			this.Bubble2.SetIsVisible(false, false);
			this.Bubble3.SetIsVisible(false, false);
			this.Bubble1.SetIsVisible(currentPlayData.DrinkBase[0] != 0, isEnd);
			if (currentPlayData.DrinkBase[0] != 0)
			{
				this.Bubble1.Update(false, currentPlayData.DrinkBase[0]);
				return;
			}
		}
		else if (curStep == EDrinksPlayStep.Drink2)
		{
			this.Bubble2.SetIsVisible(false, false);
			this.Bubble3.SetIsVisible(false, false);
			this.Bubble1.SetIsVisible(currentPlayData.DrinkBase[1] != 0, isEnd);
			if (currentPlayData.DrinkBase[1] != 0)
			{
				this.Bubble1.Update(false, currentPlayData.DrinkBase[1]);
				return;
			}
		}
		else
		{
			IReadOnlyList<int> readOnlyList = currentPlayData.Batching ?? Array.Empty<int>();
			int count = readOnlyList.Count;
			this.Bubble2.SetIsVisible(count == 2, isEnd);
			this.Bubble3.SetIsVisible(count == 2, isEnd);
			this.Bubble1.SetIsVisible(count == 1, isEnd);
			if (count == 1)
			{
				this.Bubble1.Update(true, readOnlyList[0]);
				return;
			}
			if (count == 2)
			{
				this.Bubble2.Update(true, readOnlyList[0]);
				this.Bubble3.Update(true, readOnlyList[1]);
			}
		}
	}

	// Token: 0x06003807 RID: 14343 RVA: 0x0014630D File Offset: 0x0014450D
	public void HideBubble()
	{
		this.Bubble1.SetIsVisible(false, false);
		this.Bubble2.SetIsVisible(false, false);
		this.Bubble3.SetIsVisible(false, false);
	}

	// Token: 0x04002E32 RID: 11826
	protected DrinksBubbleItem Bubble1;

	// Token: 0x04002E33 RID: 11827
	protected DrinksBubbleItem Bubble2;

	// Token: 0x04002E34 RID: 11828
	protected DrinksBubbleItem Bubble3;

	// Token: 0x02006733 RID: 26419
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x0402216E RID: 139630
		public const int Bubble1 = 0;

		// Token: 0x0402216F RID: 139631
		public const int Bubble2 = 1;

		// Token: 0x04022170 RID: 139632
		public const int Bubble3 = 2;
	}
}
