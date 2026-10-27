using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F55 RID: 3925
[NullableContext(1)]
[Nullable(0)]
public class DrinksBubblePanel : UiPanelBase
{
	// Token: 0x0600646B RID: 25707 RVA: 0x0013D80C File Offset: 0x0013BA0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600646C RID: 25708 RVA: 0x0013D868 File Offset: 0x0013BA68
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksBubblePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksBubblePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600646D RID: 25709 RVA: 0x0013D8AB File Offset: 0x0013BAAB
	protected override void OnBeforeShow()
	{
		this.Bubble1.SetUiActive(false);
		this.Bubble2.SetUiActive(false);
		this.Bubble3.SetUiActive(false);
	}

	// Token: 0x0600646E RID: 25710 RVA: 0x0013D8D4 File Offset: 0x0013BAD4
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

	// Token: 0x0600646F RID: 25711 RVA: 0x0013DA71 File Offset: 0x0013BC71
	public void HideBubble()
	{
		this.Bubble1.SetIsVisible(false, false);
		this.Bubble2.SetIsVisible(false, false);
		this.Bubble3.SetIsVisible(false, false);
	}

	// Token: 0x04002D99 RID: 11673
	protected DrinksBubbleItem Bubble1;

	// Token: 0x04002D9A RID: 11674
	protected DrinksBubbleItem Bubble2;

	// Token: 0x04002D9B RID: 11675
	protected DrinksBubbleItem Bubble3;

	// Token: 0x0200759F RID: 30111
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x04026E23 RID: 159267
		public const int Bubble1 = 0;

		// Token: 0x04026E24 RID: 159268
		public const int Bubble2 = 1;

		// Token: 0x04026E25 RID: 159269
		public const int Bubble3 = 2;
	}
}
