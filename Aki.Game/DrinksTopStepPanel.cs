using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000424 RID: 1060
[NullableContext(2)]
[Nullable(0)]
public class DrinksTopStepPanel : UiPanelBase
{
	// Token: 0x060038A8 RID: 14504 RVA: 0x00149F4C File Offset: 0x0014814C
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

	// Token: 0x060038A9 RID: 14505 RVA: 0x00149FE8 File Offset: 0x001481E8
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksTopStepPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksTopStepPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x0014A02C File Offset: 0x0014822C
	public void UpdateStep()
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		this.RefreshTitle(curStep);
		foreach (DrinksTopStepItem drinksTopStepItem in this.StepItemList)
		{
			drinksTopStepItem.UpdateCurState(curStep);
		}
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x0014A090 File Offset: 0x00148290
	public void UpdateStepItem()
	{
		foreach (DrinksTopStepItem drinksTopStepItem in this.StepItemList)
		{
			drinksTopStepItem.UpdateStepItem();
		}
	}

	// Token: 0x060038AC RID: 14508 RVA: 0x0014A0E0 File Offset: 0x001482E0
	protected void RefreshTitle(EDrinksPlayStep step)
	{
		DrinksStepConfig? stepConfig = DrinksConfig.Instance.GetStepConfig(step);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), stepConfig.Value.StepTitle, Array.Empty<object>());
	}

	// Token: 0x04002E8A RID: 11914
	protected int CurStep;

	// Token: 0x04002E8B RID: 11915
	[Nullable(1)]
	protected List<DrinksTopStepItem> StepItemList = new List<DrinksTopStepItem>();

	// Token: 0x04002E8C RID: 11916
	protected DrinksTopStepItem StepItem1;

	// Token: 0x04002E8D RID: 11917
	protected DrinksTopStepItem StepItem2;

	// Token: 0x04002E8E RID: 11918
	protected DrinksTopStepItem StepItem3;

	// Token: 0x04002E8F RID: 11919
	protected DrinksTopStepItem StepItem4;

	// Token: 0x04002E90 RID: 11920
	protected DrinksTopStepItem StepItem5;

	// Token: 0x0200674E RID: 26446
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x040221D8 RID: 139736
		public const int Title = 0;

		// Token: 0x040221D9 RID: 139737
		public const int TogStep1 = 1;

		// Token: 0x040221DA RID: 139738
		public const int TogStep2 = 2;

		// Token: 0x040221DB RID: 139739
		public const int TogStep3 = 3;

		// Token: 0x040221DC RID: 139740
		public const int TogStep4 = 4;

		// Token: 0x040221DD RID: 139741
		public const int TogStep5 = 5;
	}
}
