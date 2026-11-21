using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200075C RID: 1884
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewRoleGrowing : ActivitySubViewBase
{
	// Token: 0x060056A2 RID: 22178 RVA: 0x001C6D30 File Offset: 0x001C4F30
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

	// Token: 0x060056A3 RID: 22179 RVA: 0x001C6D78 File Offset: 0x001C4F78
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x001C6D8C File Offset: 0x001C4F8C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewRoleGrowing.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoleGrowing.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x001C6DCF File Offset: 0x001C4FCF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060056A6 RID: 22182 RVA: 0x001C6DED File Offset: 0x001C4FED
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x001C6E0B File Offset: 0x001C500B
	protected override void OnStart()
	{
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x001C6E0D File Offset: 0x001C500D
	protected override void OnBeforeShow()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetBtnText("LongShanStage_Join01", Array.Empty<object>());
		}
		this.RefreshRedDot();
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x001C6E30 File Offset: 0x001C5030
	private void OnClickDetail(ActivityBaseData data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleGrowingMainView, this.ActivityData, null);
		});
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x001C6E4E File Offset: 0x001C504E
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

	// Token: 0x060056AB RID: 22187 RVA: 0x001C6E82 File Offset: 0x001C5082
	private void OnDataUpdate()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x001C6E8C File Offset: 0x001C508C
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

	// Token: 0x04003BAB RID: 15275
	protected ActivityLongShanData ActivityData;

	// Token: 0x04003BAC RID: 15276
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x02006A4D RID: 27213
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022FC2 RID: 143298
		public const int CommonActionInfo = 0;
	}
}
