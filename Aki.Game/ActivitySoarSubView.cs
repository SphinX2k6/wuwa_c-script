using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001508 RID: 5384
[NullableContext(2)]
[Nullable(0)]
public class ActivitySoarSubView : ActivitySubViewBase
{
	// Token: 0x060099A5 RID: 39333 RVA: 0x00213E3C File Offset: 0x0021203C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060099A6 RID: 39334 RVA: 0x00213F6B File Offset: 0x0021216B
	protected override void OnSetData()
	{
		this.ActivityData = (ActivitySoarData)this.ActivityBaseData;
	}

	// Token: 0x060099A7 RID: 39335 RVA: 0x00213F80 File Offset: 0x00212180
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySoarSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySoarSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060099A8 RID: 39336 RVA: 0x00213FC4 File Offset: 0x002121C4
	protected override void OnRefreshView()
	{
		bool flag = FunctionModel.Instance.IsOpen(10026010);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		UUINiagara uiNiagara = base.GetUiNiagara(7);
		if (uiNiagara != null)
		{
			uiNiagara.SetUIActive(flag);
		}
		string textStringId = flag ? "JinZhouFly_FunctionUnLock" : "JinZhouFly_FunctionLock";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
		string textStringId2 = flag ? "JinZhouFly_FunctionUnLockDes" : "JinZhouFly_FunctionLockDes";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId2, Array.Empty<object>());
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.RefreshView();
		}
		bool redPointShowState = this.ActivityData.RedPointShowState;
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 != null)
		{
			commonInfoPanel2.SetFunctionRedDotVisible(redPointShowState);
		}
		if (QuestNewModel.Instance.CheckQuestFinished(this.ActivityData.GetQuestId()))
		{
			ActivitySubViewGeneralInfo commonInfoPanel3 = this.CommonInfoPanel;
			ActivityFunctionalTypeA activityFunctionalTypeA = (commonInfoPanel3 != null) ? commonInfoPanel3.GetFunctional() : null;
			activityFunctionalTypeA.FunctionButton.SetUiActive(false);
			activityFunctionalTypeA.SetPanelConditionVisible(false);
			activityFunctionalTypeA.SetActivatePanelConditionVisible(true);
			activityFunctionalTypeA.SetActivateTextByTextId("DangoMonopoly_title_21", Array.Empty<string>());
		}
	}

	// Token: 0x060099A9 RID: 39337 RVA: 0x002140EC File Offset: 0x002122EC
	protected override void OnTimer(float gap)
	{
		if (this.IsShowConfirmBox)
		{
			return;
		}
		if (!this.ActivityData.CheckIfInShowTime())
		{
			this.IsShowConfirmBox = true;
			ActivityModel.Instance.RefreshShowingActivities();
		}
	}

	// Token: 0x060099AA RID: 39338 RVA: 0x00214115 File Offset: 0x00212315
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityData.SaveFirstClick();
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityData.GetQuestId(), null);
		});
	}

	// Token: 0x04004377 RID: 17271
	protected ActivitySoarData ActivityData;

	// Token: 0x04004378 RID: 17272
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04004379 RID: 17273
	private bool IsShowConfirmBox;

	// Token: 0x02007B40 RID: 31552
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028885 RID: 166021
		public const int ItemCommonInfo = 0;

		// Token: 0x04028886 RID: 166022
		public const int SpriteUnlock = 1;

		// Token: 0x04028887 RID: 166023
		public const int ItemLock = 2;

		// Token: 0x04028888 RID: 166024
		public const int TextState = 3;

		// Token: 0x04028889 RID: 166025
		public const int ItemMale = 4;

		// Token: 0x0402888A RID: 166026
		public const int ItemFemale = 5;

		// Token: 0x0402888B RID: 166027
		public const int TextDesc = 6;

		// Token: 0x0402888C RID: 166028
		public const int NiagaraUnlock = 7;
	}
}
