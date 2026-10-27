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
	// Token: 0x02005784 RID: 22404
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewKurotato : ActivitySubViewBase
	{
		// Token: 0x17008879 RID: 34937
		// (get) Token: 0x06038E93 RID: 233107 RVA: 0x00D869BC File Offset: 0x00D84BBC
		protected new KurotatoActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as KurotatoActivityData;
			}
		}

		// Token: 0x06038E94 RID: 233108 RVA: 0x00D869CC File Offset: 0x00D84BCC
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

		// Token: 0x06038E95 RID: 233109 RVA: 0x00D86A58 File Offset: 0x00D84C58
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewKurotato.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewKurotato.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E96 RID: 233110 RVA: 0x00D86A9C File Offset: 0x00D84C9C
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

		// Token: 0x06038E97 RID: 233111 RVA: 0x00D86B05 File Offset: 0x00D84D05
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

		// Token: 0x06038E98 RID: 233112 RVA: 0x00D86B28 File Offset: 0x00D84D28
		protected override void OnTimer(float gap)
		{
			this.RefreshBottomTimeText();
		}

		// Token: 0x06038E99 RID: 233113 RVA: 0x00D86B30 File Offset: 0x00D84D30
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

		// Token: 0x06038E9A RID: 233114 RVA: 0x00D86BEC File Offset: 0x00D84DEC
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

		// Token: 0x06038E9B RID: 233115 RVA: 0x00D86C54 File Offset: 0x00D84E54
		private bool GetFunctionRedDotState()
		{
			return this.ActivityBaseData.IsActHaveRedDot();
		}

		// Token: 0x06038E9C RID: 233116 RVA: 0x00D86C61 File Offset: 0x00D84E61
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

		// Token: 0x06038E9D RID: 233117 RVA: 0x00D86C7F File Offset: 0x00D84E7F
		private void OnLimitedTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoLimitedTimeRewardView, null, null);
		}

		// Token: 0x06038E9E RID: 233118 RVA: 0x00D86C92 File Offset: 0x00D84E92
		private void OnNormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoNormalRewardView, null, null);
		}

		// Token: 0x0401DD60 RID: 122208
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401DD61 RID: 122209
		protected KurotatoLimitTimeRewardButton LimitedTimeRewardBtn;

		// Token: 0x0401DD62 RID: 122210
		protected KurotatoNormalRewardButton NormalRewardBtn;

		// Token: 0x0200B9A6 RID: 47526
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04038221 RID: 229921
			CommonActionInfo,
			// Token: 0x04038222 RID: 229922
			LimitedTimeRewardBtn,
			// Token: 0x04038223 RID: 229923
			NormalRewardBtn
		}
	}
}
