using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200475B RID: 18267
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewKurotato : ActivitySubViewBase
	{
		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x0602DDA3 RID: 187811 RVA: 0x00CD5700 File Offset: 0x00CD3900
		protected new KurotatoActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as KurotatoActivityData;
			}
		}

		// Token: 0x0602DDA4 RID: 187812 RVA: 0x00CD5710 File Offset: 0x00CD3910
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

		// Token: 0x0602DDA5 RID: 187813 RVA: 0x00CD579C File Offset: 0x00CD399C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewKurotato.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewKurotato.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DDA6 RID: 187814 RVA: 0x00CD57E0 File Offset: 0x00CD39E0
		protected override void OnBeforeShow()
		{
			this.OnRefreshView();
			KurotatoNormalRewardButton normalRewardBtn = this.NormalRewardBtn;
			if (normalRewardBtn != null)
			{
				normalRewardBtn.BindRedDot();
			}
			KurotatoLimitTimeRewardButton limitedTimeRewardBtn = this.LimitedTimeRewardBtn;
			if (limitedTimeRewardBtn != null)
			{
				limitedTimeRewardBtn.BindRedDot();
			}
			bool flag = this.ActivityBaseData.IsUnLock();
			bool flag2 = this.ActivityBaseData.CheckIfInLimitTime();
			base.GetItem(1).SetUIActive(flag && flag2);
			base.GetItem(2).SetUIActive(flag);
		}

		// Token: 0x0602DDA7 RID: 187815 RVA: 0x00CD5849 File Offset: 0x00CD3A49
		protected override void OnBeforeHide()
		{
			KurotatoNormalRewardButton normalRewardBtn = this.NormalRewardBtn;
			if (normalRewardBtn != null)
			{
				normalRewardBtn.UnBindRedDot();
			}
			KurotatoLimitTimeRewardButton limitedTimeRewardBtn = this.LimitedTimeRewardBtn;
			if (limitedTimeRewardBtn == null)
			{
				return;
			}
			limitedTimeRewardBtn.UnBindRedDot();
		}

		// Token: 0x0602DDA8 RID: 187816 RVA: 0x00CD586C File Offset: 0x00CD3A6C
		protected override void OnTimer(float gap)
		{
			this.RefreshBottomTimeText();
		}

		// Token: 0x0602DDA9 RID: 187817 RVA: 0x00CD5874 File Offset: 0x00CD3A74
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
			if (commonInfoPanel2 != null)
			{
				commonInfoPanel2.SetFunctionRedDotVisible(this.GetFunctionRedDotState());
			}
			if (this.ActivityBaseData.GetUnFinishPreGuideQuestId() > 0)
			{
				this.CommonInfoPanel.SetBtnText("Kurotato_Task_Go_To", Array.Empty<object>());
			}
			else
			{
				this.CommonInfoPanel.SetBtnText("Kurotato_Go_To", Array.Empty<object>());
			}
			ValueTuple<int, int> normalRewardProgress = this.ActivityBaseData.GetNormalRewardProgress();
			int item = normalRewardProgress.Item1;
			int item2 = normalRewardProgress.Item2;
			this.NormalRewardBtn.SetProgressNumText(item, item2);
			ValueTuple<int, int> limitedTimeRewardProgress = this.ActivityBaseData.GetLimitedTimeRewardProgress();
			int item3 = limitedTimeRewardProgress.Item1;
			int item4 = limitedTimeRewardProgress.Item2;
			this.LimitedTimeRewardBtn.SetProgressNumText(item3, item4);
		}

		// Token: 0x0602DDAA RID: 187818 RVA: 0x00CD5930 File Offset: 0x00CD3B30
		private void RefreshBottomTimeText()
		{
			bool flag = this.ActivityBaseData.CheckIfInLimitTime();
			bool flag2 = this.ActivityBaseData.IsUnLock();
			base.GetItem(1).SetUIActive(flag2 && flag);
			if (!flag)
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
			this.LimitedTimeRewardBtn.SetLimitTimeText(remainTimeText ?? "");
		}

		// Token: 0x0602DDAB RID: 187819 RVA: 0x00CD5998 File Offset: 0x00CD3B98
		private bool GetFunctionRedDotState()
		{
			return this.ActivityBaseData.IsActHaveRedDot();
		}

		// Token: 0x0602DDAC RID: 187820 RVA: 0x00CD59A5 File Offset: 0x00CD3BA5
		private void OnEnterBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("MowingTowerMultiTips", Array.Empty<object>());
					return;
				}
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.KurotatoMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x0602DDAD RID: 187821 RVA: 0x00CD59C3 File Offset: 0x00CD3BC3
		private void OnLimitedTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoLimitedTimeRewardView, null, null);
		}

		// Token: 0x0602DDAE RID: 187822 RVA: 0x00CD59D6 File Offset: 0x00CD3BD6
		private void OnNormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoNormalRewardView, null, null);
		}

		// Token: 0x040187F6 RID: 100342
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x040187F7 RID: 100343
		protected KurotatoLimitTimeRewardButton LimitedTimeRewardBtn;

		// Token: 0x040187F8 RID: 100344
		protected KurotatoNormalRewardButton NormalRewardBtn;

		// Token: 0x0200A3BD RID: 41917
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032C13 RID: 207891
			CommonActionInfo,
			// Token: 0x04032C14 RID: 207892
			LimitedTimeRewardBtn,
			// Token: 0x04032C15 RID: 207893
			NormalRewardBtn
		}
	}
}
