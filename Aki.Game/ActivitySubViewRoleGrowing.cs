using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012A8 RID: 4776
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewRoleGrowing : ActivitySubViewBase
{
	// Token: 0x0600830B RID: 33547 RVA: 0x001BDFA0 File Offset: 0x001BC1A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600830C RID: 33548 RVA: 0x001BDFE8 File Offset: 0x001BC1E8
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x0600830D RID: 33549 RVA: 0x001BDFFC File Offset: 0x001BC1FC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewRoleGrowing.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleGrowing.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600830E RID: 33550 RVA: 0x001BE03F File Offset: 0x001BC23F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x0600830F RID: 33551 RVA: 0x001BE05D File Offset: 0x001BC25D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06008310 RID: 33552 RVA: 0x001BE07B File Offset: 0x001BC27B
	protected override void OnStart()
	{
	}

	// Token: 0x06008311 RID: 33553 RVA: 0x001BE07D File Offset: 0x001BC27D
	protected override void OnBeforeShow()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetBtnText("LongShanStage_Join01", Array.Empty<object>());
		}
		this.RefreshRedDot();
	}

	// Token: 0x06008312 RID: 33554 RVA: 0x001BE0A0 File Offset: 0x001BC2A0
	private void OnClickDetail(ActivityBaseData data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleGrowingMainView, this.ActivityData, null);
		});
	}

	// Token: 0x06008313 RID: 33555 RVA: 0x001BE0BE File Offset: 0x001BC2BE
	protected override void OnRefreshView()
	{
		EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityData.Id);
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.RefreshView();
		}
		this.OnDataUpdate();
	}

	// Token: 0x06008314 RID: 33556 RVA: 0x001BE0F2 File Offset: 0x001BC2F2
	private void OnDataUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06008315 RID: 33557 RVA: 0x001BE0FC File Offset: 0x001BC2FC
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.CheckAnyStageRed();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		commonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x04003B13 RID: 15123
	protected ActivityLongShanData ActivityData;

	// Token: 0x04003B14 RID: 15124
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x020078C3 RID: 30915
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C94 RID: 162964
		public const int CommonActionInfo = 0;
	}
}
