using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F6F RID: 3951
[NullableContext(2)]
[Nullable(0)]
public class DrinksTopStepPanel : UiPanelBase
{
	// Token: 0x06006510 RID: 25872 RVA: 0x001416B0 File Offset: 0x0013F8B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06006511 RID: 25873 RVA: 0x0014174C File Offset: 0x0013F94C
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksTopStepPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksTopStepPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006512 RID: 25874 RVA: 0x00141790 File Offset: 0x0013F990
	public void UpdateStep()
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		this.RefreshTitle(curStep);
		foreach (DrinksTopStepItem drinksTopStepItem in this.StepItemList)
		{
			drinksTopStepItem.UpdateCurState(curStep);
		}
	}

	// Token: 0x06006513 RID: 25875 RVA: 0x001417F4 File Offset: 0x0013F9F4
	public void UpdateStepItem()
	{
		foreach (DrinksTopStepItem drinksTopStepItem in this.StepItemList)
		{
			drinksTopStepItem.UpdateStepItem();
		}
	}

	// Token: 0x06006514 RID: 25876 RVA: 0x00141844 File Offset: 0x0013FA44
	protected void RefreshTitle(EDrinksPlayStep step)
	{
		DrinksStepConfig? stepConfig = DrinksConfig.Instance.GetStepConfig(step);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), stepConfig.Value.StepTitle, Array.Empty<object>());
	}

	// Token: 0x04002DF1 RID: 11761
	protected int CurStep;

	// Token: 0x04002DF2 RID: 11762
	[Nullable(1)]
	protected List<DrinksTopStepItem> StepItemList = new List<DrinksTopStepItem>();

	// Token: 0x04002DF3 RID: 11763
	protected DrinksTopStepItem StepItem1;

	// Token: 0x04002DF4 RID: 11764
	protected DrinksTopStepItem StepItem2;

	// Token: 0x04002DF5 RID: 11765
	protected DrinksTopStepItem StepItem3;

	// Token: 0x04002DF6 RID: 11766
	protected DrinksTopStepItem StepItem4;

	// Token: 0x04002DF7 RID: 11767
	protected DrinksTopStepItem StepItem5;

	// Token: 0x020075BA RID: 30138
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x04026E8D RID: 159373
		public const int Title = 0;

		// Token: 0x04026E8E RID: 159374
		public const int TogStep1 = 1;

		// Token: 0x04026E8F RID: 159375
		public const int TogStep2 = 2;

		// Token: 0x04026E90 RID: 159376
		public const int TogStep3 = 3;

		// Token: 0x04026E91 RID: 159377
		public const int TogStep4 = 4;

		// Token: 0x04026E92 RID: 159378
		public const int TogStep5 = 5;
	}
}
