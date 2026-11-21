using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005C3 RID: 1475
public class AvignonActivitySubView : ActivitySubViewBase
{
	// Token: 0x060045C8 RID: 17864 RVA: 0x0017E313 File Offset: 0x0017C513
	protected override void OnSetData()
	{
		this.ActivityData = (AvignonProtocolData)this.ActivityBaseData;
	}

	// Token: 0x060045C9 RID: 17865 RVA: 0x0017E328 File Offset: 0x0017C528
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x0017E3B4 File Offset: 0x0017C5B4
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonActivitySubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonActivitySubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x0017E3F8 File Offset: 0x0017C5F8
	protected override void OnRefreshView()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityData.Id);
		this.CommonInfoPanel.SetFunctionRedDotVisible(AvignonModel.Instance.CheckRedDot() || this.ActivityData.HasStageRewardRedDot());
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		commonInfoPanel.OnRefreshView();
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x0017E455 File Offset: 0x0017C655
	[NullableContext(2)]
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			AvignonModel.Instance.ReadRedDot();
			UiManager.Instance.OpenView(EUiViewName.AvignonActivityMainView, this.ActivityData, null);
		});
	}

	// Token: 0x04003580 RID: 13696
	[Nullable(2)]
	protected AvignonProtocolData ActivityData;

	// Token: 0x04003581 RID: 13697
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02006864 RID: 26724
	private class EComponents
	{
		// Token: 0x0402269A RID: 140954
		public const int CommonActionInfo = 0;

		// Token: 0x0402269B RID: 140955
		public const int ItemFemale = 1;

		// Token: 0x0402269C RID: 140956
		public const int ItemMale = 2;
	}
}
