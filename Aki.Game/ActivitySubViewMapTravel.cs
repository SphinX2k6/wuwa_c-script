using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200078C RID: 1932
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMapTravel : ActivitySubViewBase
{
	// Token: 0x17000B92 RID: 2962
	// (get) Token: 0x0600589E RID: 22686 RVA: 0x001CD721 File Offset: 0x001CB921
	// (set) Token: 0x0600589F RID: 22687 RVA: 0x001CD729 File Offset: 0x001CB929
	protected ActivityMapTravelData ActivityData { get; set; }

	// Token: 0x17000B93 RID: 2963
	// (get) Token: 0x060058A0 RID: 22688 RVA: 0x001CD732 File Offset: 0x001CB932
	// (set) Token: 0x060058A1 RID: 22689 RVA: 0x001CD73A File Offset: 0x001CB93A
	protected ActivitySubViewGeneralInfo GeneralActivityInfo { get; set; }

	// Token: 0x17000B94 RID: 2964
	// (get) Token: 0x060058A2 RID: 22690 RVA: 0x001CD743 File Offset: 0x001CB943
	// (set) Token: 0x060058A3 RID: 22691 RVA: 0x001CD74B File Offset: 0x001CB94B
	private MapTravelExpComponent ExpComponent { get; set; }

	// Token: 0x060058A4 RID: 22692 RVA: 0x001CD754 File Offset: 0x001CB954
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityMapTravelData)this.ActivityBaseData;
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x001CD768 File Offset: 0x001CB968
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060058A6 RID: 22694 RVA: 0x001CD814 File Offset: 0x001CBA14
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMapTravel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMapTravel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060058A7 RID: 22695 RVA: 0x001CD857 File Offset: 0x001CBA57
	protected override void OnRefreshView()
	{
		this.RefreshExpComponent();
		this.RefreshButton();
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x001CD865 File Offset: 0x001CBA65
	private void OnBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.MapTravelMainView, this.ActivityData, null);
		});
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x001CD884 File Offset: 0x001CBA84
	private void RefreshExpComponent()
	{
		this.ExpComponent.SetProgress(this.ActivityData.GetCurrentExp(), this.ActivityData.GetCurrentTargetExp(), this.ActivityData.TravelLevel == this.ActivityData.MaxTravelLevel);
		this.ExpComponent.SetLevel(this.ActivityData.TravelLevel);
	}

	// Token: 0x060058AA RID: 22698 RVA: 0x001CD8E0 File Offset: 0x001CBAE0
	private void RefreshButton()
	{
		this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityData.RedPointShowState);
	}

	// Token: 0x02006A73 RID: 27251
	[NullableContext(0)]
	private class EViewDefine
	{
		// Token: 0x0402307B RID: 143483
		public const int CommonActivityInfo = 0;

		// Token: 0x0402307C RID: 143484
		public const int ProgressItem = 1;

		// Token: 0x0402307D RID: 143485
		public const int PanelMale = 2;

		// Token: 0x0402307E RID: 143486
		public const int PanelFemale = 3;
	}
}
