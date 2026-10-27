using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012D8 RID: 4824
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMapTravel : ActivitySubViewBase
{
	// Token: 0x17000B72 RID: 2930
	// (get) Token: 0x06008503 RID: 34051 RVA: 0x001C48C5 File Offset: 0x001C2AC5
	// (set) Token: 0x06008504 RID: 34052 RVA: 0x001C48CD File Offset: 0x001C2ACD
	protected ActivityMapTravelData ActivityData { get; set; }

	// Token: 0x17000B73 RID: 2931
	// (get) Token: 0x06008505 RID: 34053 RVA: 0x001C48D6 File Offset: 0x001C2AD6
	// (set) Token: 0x06008506 RID: 34054 RVA: 0x001C48DE File Offset: 0x001C2ADE
	protected ActivitySubViewGeneralInfo GeneralActivityInfo { get; set; }

	// Token: 0x17000B74 RID: 2932
	// (get) Token: 0x06008507 RID: 34055 RVA: 0x001C48E7 File Offset: 0x001C2AE7
	// (set) Token: 0x06008508 RID: 34056 RVA: 0x001C48EF File Offset: 0x001C2AEF
	private MapTravelExpComponent ExpComponent { get; set; }

	// Token: 0x06008509 RID: 34057 RVA: 0x001C48F8 File Offset: 0x001C2AF8
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityMapTravelData)this.ActivityBaseData;
	}

	// Token: 0x0600850A RID: 34058 RVA: 0x001C490C File Offset: 0x001C2B0C
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

	// Token: 0x0600850B RID: 34059 RVA: 0x001C49B8 File Offset: 0x001C2BB8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMapTravel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMapTravel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600850C RID: 34060 RVA: 0x001C49FB File Offset: 0x001C2BFB
	protected override void OnRefreshView()
	{
		this.RefreshExpComponent();
		this.RefreshButton();
	}

	// Token: 0x0600850D RID: 34061 RVA: 0x001C4A09 File Offset: 0x001C2C09
	private void OnBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.MapTravelMainView, this.ActivityData, null);
		});
	}

	// Token: 0x0600850E RID: 34062 RVA: 0x001C4A28 File Offset: 0x001C2C28
	private void RefreshExpComponent()
	{
		this.ExpComponent.SetProgress(this.ActivityData.GetCurrentExp(), this.ActivityData.GetCurrentTargetExp(), this.ActivityData.TravelLevel == this.ActivityData.MaxTravelLevel);
		this.ExpComponent.SetLevel(this.ActivityData.TravelLevel);
	}

	// Token: 0x0600850F RID: 34063 RVA: 0x001C4A84 File Offset: 0x001C2C84
	private void RefreshButton()
	{
		this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityData.RedPointShowState);
	}

	// Token: 0x020078E9 RID: 30953
	[NullableContext(0)]
	private class EViewDefine
	{
		// Token: 0x04027D4D RID: 163149
		public const int CommonActivityInfo = 0;

		// Token: 0x04027D4E RID: 163150
		public const int ProgressItem = 1;

		// Token: 0x04027D4F RID: 163151
		public const int PanelMale = 2;

		// Token: 0x04027D50 RID: 163152
		public const int PanelFemale = 3;
	}
}
