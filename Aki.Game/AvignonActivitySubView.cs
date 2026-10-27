using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200110F RID: 4367
public class AvignonActivitySubView : ActivitySubViewBase
{
	// Token: 0x06007232 RID: 29234 RVA: 0x00175957 File Offset: 0x00173B57
	protected override void OnSetData()
	{
		this.ActivityData = (AvignonProtocolData)this.ActivityBaseData;
	}

	// Token: 0x06007233 RID: 29235 RVA: 0x0017596C File Offset: 0x00173B6C
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

	// Token: 0x06007234 RID: 29236 RVA: 0x001759F8 File Offset: 0x00173BF8
	protected override UniTask OnBeforeStartAsync()
	{
		AvignonActivitySubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AvignonActivitySubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007235 RID: 29237 RVA: 0x00175A3C File Offset: 0x00173C3C
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

	// Token: 0x06007236 RID: 29238 RVA: 0x00175A99 File Offset: 0x00173C99
	[NullableContext(2)]
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			AvignonModel.Instance.ReadRedDot();
			UiManager.Instance.OpenView(EUiViewName.AvignonActivityMainView, this.ActivityData, null);
		});
	}

	// Token: 0x040034E7 RID: 13543
	[Nullable(2)]
	protected AvignonProtocolData ActivityData;

	// Token: 0x040034E8 RID: 13544
	[Nullable(1)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x020076D0 RID: 30416
	private class EComponents
	{
		// Token: 0x04027351 RID: 160593
		public const int CommonActionInfo = 0;

		// Token: 0x04027352 RID: 160594
		public const int ItemFemale = 1;

		// Token: 0x04027353 RID: 160595
		public const int ItemMale = 2;
	}
}
