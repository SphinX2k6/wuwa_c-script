using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004761 RID: 18273
	[NullableContext(2)]
	[Nullable(0)]
	public class KurotatoMainView : UiViewBase
	{
		// Token: 0x0602DDE0 RID: 187872 RVA: 0x00CD68B2 File Offset: 0x00CD4AB2
		[NullableContext(1)]
		public KurotatoMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DDE1 RID: 187873 RVA: 0x00CD68BC File Offset: 0x00CD4ABC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DDE2 RID: 187874 RVA: 0x00CD69CC File Offset: 0x00CD4BCC
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DDE3 RID: 187875 RVA: 0x00CD6A10 File Offset: 0x00CD4C10
		protected override void OnBeforeShow()
		{
			this.RefreshMainView();
			KurotatoNormalRewardButton normalRewardBtn = this.NormalRewardBtn;
			if (normalRewardBtn != null)
			{
				normalRewardBtn.BindRedDot();
			}
			KurotatoLimitTimeRewardButton limitTimeRewardBtn = this.LimitTimeRewardBtn;
			if (limitTimeRewardBtn != null)
			{
				limitTimeRewardBtn.BindRedDot();
			}
			this.ClearTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerTick), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602DDE4 RID: 187876 RVA: 0x00CD6A74 File Offset: 0x00CD4C74
		protected override void OnBeforeHide()
		{
			KurotatoNormalRewardButton normalRewardBtn = this.NormalRewardBtn;
			if (normalRewardBtn != null)
			{
				normalRewardBtn.UnBindRedDot();
			}
			KurotatoLimitTimeRewardButton limitTimeRewardBtn = this.LimitTimeRewardBtn;
			if (limitTimeRewardBtn != null)
			{
				limitTimeRewardBtn.UnBindRedDot();
			}
			this.ClearTimer();
		}

		// Token: 0x0602DDE5 RID: 187877 RVA: 0x00CD6A9E File Offset: 0x00CD4C9E
		private void ClearTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602DDE6 RID: 187878 RVA: 0x00CD6AC0 File Offset: 0x00CD4CC0
		private void OnTimerTick(float delta)
		{
			this.RefreshInfiniteStageEntrance();
			this.RefreshBottomTimeText();
		}

		// Token: 0x0602DDE7 RID: 187879 RVA: 0x00CD6AD0 File Offset: 0x00CD4CD0
		private void RefreshInfiniteStageEntrance()
		{
			bool flag = this.ActivityBaseData.IsStageEntranceUnLock(EKurotatoLevelMode.Endless);
			base.GetItem(2).SetUIActive(flag);
			base.GetItem(3).SetUIActive(!flag);
			if (flag)
			{
				KurotatoStageEntranceEndless infiniteStageEntrance = this.InfiniteStageEntrance;
				if (infiniteStageEntrance == null)
				{
					return;
				}
				infiniteStageEntrance.RefreshView();
				return;
			}
			else
			{
				KurotatoStageEntranceEndlessLock infiniteStageEntranceLock = this.InfiniteStageEntranceLock;
				if (infiniteStageEntranceLock == null)
				{
					return;
				}
				infiniteStageEntranceLock.RefreshView();
				return;
			}
		}

		// Token: 0x0602DDE8 RID: 187880 RVA: 0x00CD6B2B File Offset: 0x00CD4D2B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0602DDE9 RID: 187881 RVA: 0x00CD6B49 File Offset: 0x00CD4D49
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0602DDEA RID: 187882 RVA: 0x00CD6B67 File Offset: 0x00CD4D67
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityBaseData.Id != id)
			{
				return;
			}
			this.RefreshMainView();
		}

		// Token: 0x0602DDEB RID: 187883 RVA: 0x00CD6B80 File Offset: 0x00CD4D80
		public void RefreshMainView()
		{
			KurotatoStageEntrance teachStageEntrance = this.TeachStageEntrance;
			if (teachStageEntrance != null)
			{
				teachStageEntrance.RefreshView();
			}
			KurotatoCollectBtn collectBtn = this.CollectBtn;
			if (collectBtn != null)
			{
				collectBtn.RefreshView();
			}
			if (this.ActivityBaseData == null)
			{
				return;
			}
			ValueTuple<int, int> normalRewardProgress = this.ActivityBaseData.GetNormalRewardProgress();
			int item = normalRewardProgress.Item1;
			int item2 = normalRewardProgress.Item2;
			KurotatoNormalRewardButton normalRewardBtn = this.NormalRewardBtn;
			if (normalRewardBtn != null)
			{
				normalRewardBtn.SetProgressNumText(item, item2);
			}
			ValueTuple<int, int> limitedTimeRewardProgress = this.ActivityBaseData.GetLimitedTimeRewardProgress();
			int item3 = limitedTimeRewardProgress.Item1;
			int item4 = limitedTimeRewardProgress.Item2;
			KurotatoLimitTimeRewardButton limitTimeRewardBtn = this.LimitTimeRewardBtn;
			if (limitTimeRewardBtn != null)
			{
				limitTimeRewardBtn.SetProgressNumText(item3, item4);
			}
			this.RefreshInfiniteStageEntrance();
		}

		// Token: 0x0602DDEC RID: 187884 RVA: 0x00CD6C14 File Offset: 0x00CD4E14
		private void RefreshBottomTimeText()
		{
			bool uiactive = this.ActivityBaseData.CheckIfInLimitTime();
			base.GetItem(4).SetUIActive(uiactive);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
			this.LimitTimeRewardBtn.SetLimitTimeText(remainTimeText ?? "");
		}

		// Token: 0x0602DDED RID: 187885 RVA: 0x00CD6C6A File Offset: 0x00CD4E6A
		private void OnNormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoNormalRewardView, null, null);
		}

		// Token: 0x0602DDEE RID: 187886 RVA: 0x00CD6C7D File Offset: 0x00CD4E7D
		private void OnLimitTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoLimitedTimeRewardView, null, null);
		}

		// Token: 0x0602DDEF RID: 187887 RVA: 0x00CD6C90 File Offset: 0x00CD4E90
		private void OnTeachStageEntranceClick()
		{
			int latestUnfinishedLevelId = this.ActivityBaseData.GetLatestUnfinishedLevelId(1);
			KurotatoLevelSelectViewData param = new KurotatoLevelSelectViewData
			{
				LevelMode = EKurotatoLevelMode.Teach,
				LevelId = latestUnfinishedLevelId
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoLevelSelectView, param, null);
		}

		// Token: 0x0602DDF0 RID: 187888 RVA: 0x00CD6CD0 File Offset: 0x00CD4ED0
		private void OnInfiniteStageEntranceClick()
		{
			KurotatoLevelSelectViewData param = new KurotatoLevelSelectViewData
			{
				LevelMode = EKurotatoLevelMode.Endless,
				LevelId = 0
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoLevelSelectView, param, null);
		}

		// Token: 0x0602DDF1 RID: 187889 RVA: 0x00CD6D02 File Offset: 0x00CD4F02
		private void OnCollectBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoHandBookView, null, null);
		}

		// Token: 0x0602DDF2 RID: 187890 RVA: 0x00CD6D15 File Offset: 0x00CD4F15
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401880A RID: 100362
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401880B RID: 100363
		private KurotatoNormalRewardButton NormalRewardBtn;

		// Token: 0x0401880C RID: 100364
		private KurotatoLimitTimeRewardButton LimitTimeRewardBtn;

		// Token: 0x0401880D RID: 100365
		private KurotatoStageEntrance TeachStageEntrance;

		// Token: 0x0401880E RID: 100366
		private KurotatoStageEntranceEndless InfiniteStageEntrance;

		// Token: 0x0401880F RID: 100367
		private KurotatoStageEntranceEndlessLock InfiniteStageEntranceLock;

		// Token: 0x04018810 RID: 100368
		private KurotatoCollectBtn CollectBtn;

		// Token: 0x04018811 RID: 100369
		protected KurotatoActivityData ActivityBaseData;

		// Token: 0x04018812 RID: 100370
		private TimerHandle TimerHandle;

		// Token: 0x0200A3C6 RID: 41926
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032C3C RID: 207932
			Caption,
			// Token: 0x04032C3D RID: 207933
			TeachStageEntrance,
			// Token: 0x04032C3E RID: 207934
			InfiniteStageEntrance,
			// Token: 0x04032C3F RID: 207935
			InfiniteStageEntranceLock,
			// Token: 0x04032C40 RID: 207936
			LimitTimeRewardBtn,
			// Token: 0x04032C41 RID: 207937
			NormalRewardBtn,
			// Token: 0x04032C42 RID: 207938
			CollectBtn
		}
	}
}
