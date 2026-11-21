using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009C0 RID: 2496
[NullableContext(2)]
[Nullable(0)]
public class ActivitySoarSubView : ActivitySubViewBase
{
	// Token: 0x06006D83 RID: 28035 RVA: 0x0021DBF4 File Offset: 0x0021BDF4
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

	// Token: 0x06006D84 RID: 28036 RVA: 0x0021DD23 File Offset: 0x0021BF23
	protected override void OnSetData()
	{
		this.ActivityData = (ActivitySoarData)this.ActivityBaseData;
	}

	// Token: 0x06006D85 RID: 28037 RVA: 0x0021DD38 File Offset: 0x0021BF38
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySoarSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySoarSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006D86 RID: 28038 RVA: 0x0021DD7C File Offset: 0x0021BF7C
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

	// Token: 0x06006D87 RID: 28039 RVA: 0x0021DEA4 File Offset: 0x0021C0A4
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

	// Token: 0x06006D88 RID: 28040 RVA: 0x0021DECD File Offset: 0x0021C0CD
	private void OnConfirmBtnClick(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			this.ActivityData.SaveFirstClick();
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityData.GetQuestId(), null);
		});
	}

	// Token: 0x0400441D RID: 17437
	protected ActivitySoarData ActivityData;

	// Token: 0x0400441E RID: 17438
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0400441F RID: 17439
	private bool IsShowConfirmBox;

	// Token: 0x02006CCB RID: 27851
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023BC1 RID: 146369
		public const int ItemCommonInfo = 0;

		// Token: 0x04023BC2 RID: 146370
		public const int SpriteUnlock = 1;

		// Token: 0x04023BC3 RID: 146371
		public const int ItemLock = 2;

		// Token: 0x04023BC4 RID: 146372
		public const int TextState = 3;

		// Token: 0x04023BC5 RID: 146373
		public const int ItemMale = 4;

		// Token: 0x04023BC6 RID: 146374
		public const int ItemFemale = 5;

		// Token: 0x04023BC7 RID: 146375
		public const int TextDesc = 6;

		// Token: 0x04023BC8 RID: 146376
		public const int NiagaraUnlock = 7;
	}
}
