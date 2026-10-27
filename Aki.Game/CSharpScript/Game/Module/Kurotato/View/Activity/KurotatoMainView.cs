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
	// Token: 0x0200578A RID: 22410
	[NullableContext(2)]
	[Nullable(0)]
	public class KurotatoMainView : UiViewBase
	{
		// Token: 0x06038ED0 RID: 233168 RVA: 0x00D87B56 File Offset: 0x00D85D56
		[NullableContext(1)]
		public KurotatoMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038ED1 RID: 233169 RVA: 0x00D87B60 File Offset: 0x00D85D60
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

		// Token: 0x06038ED2 RID: 233170 RVA: 0x00D87C70 File Offset: 0x00D85E70
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038ED3 RID: 233171 RVA: 0x00D87CB4 File Offset: 0x00D85EB4
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

		// Token: 0x06038ED4 RID: 233172 RVA: 0x00D87D18 File Offset: 0x00D85F18
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

		// Token: 0x06038ED5 RID: 233173 RVA: 0x00D87D42 File Offset: 0x00D85F42
		private void ClearTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06038ED6 RID: 233174 RVA: 0x00D87D64 File Offset: 0x00D85F64
		private void OnTimerTick(float delta)
		{
			this.RefreshInfiniteStageEntrance();
			this.RefreshBottomTimeText();
		}

		// Token: 0x06038ED7 RID: 233175 RVA: 0x00D87D74 File Offset: 0x00D85F74
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

		// Token: 0x06038ED8 RID: 233176 RVA: 0x00D87DCF File Offset: 0x00D85FCF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06038ED9 RID: 233177 RVA: 0x00D87DED File Offset: 0x00D85FED
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06038EDA RID: 233178 RVA: 0x00D87E0B File Offset: 0x00D8600B
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityBaseData.Id != id)
			{
				return;
			}
			this.RefreshMainView();
		}

		// Token: 0x06038EDB RID: 233179 RVA: 0x00D87E24 File Offset: 0x00D86024
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

		// Token: 0x06038EDC RID: 233180 RVA: 0x00D87EB8 File Offset: 0x00D860B8
		private void RefreshBottomTimeText()
		{
			bool uiactive = this.ActivityBaseData.CheckIfInLimitTime();
			base.GetItem(4).SetUIActive(uiactive);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
			this.LimitTimeRewardBtn.SetLimitTimeText(remainTimeText ?? "");
		}

		// Token: 0x06038EDD RID: 233181 RVA: 0x00D87F0E File Offset: 0x00D8610E
		private void OnNormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoNormalRewardView, null, null);
		}

		// Token: 0x06038EDE RID: 233182 RVA: 0x00D87F21 File Offset: 0x00D86121
		private void OnLimitTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoLimitedTimeRewardView, null, null);
		}

		// Token: 0x06038EDF RID: 233183 RVA: 0x00D87F34 File Offset: 0x00D86134
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

		// Token: 0x06038EE0 RID: 233184 RVA: 0x00D87F74 File Offset: 0x00D86174
		private void OnInfiniteStageEntranceClick()
		{
			KurotatoLevelSelectViewData param = new KurotatoLevelSelectViewData
			{
				LevelMode = EKurotatoLevelMode.Endless,
				LevelId = 0
			};
			UiManager.Instance.OpenView(EUiViewName.KurotatoLevelSelectView, param, null);
		}

		// Token: 0x06038EE1 RID: 233185 RVA: 0x00D87FA6 File Offset: 0x00D861A6
		private void OnCollectBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoHandBookView, null, null);
		}

		// Token: 0x06038EE2 RID: 233186 RVA: 0x00D87FB9 File Offset: 0x00D861B9
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DD74 RID: 122228
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DD75 RID: 122229
		private KurotatoNormalRewardButton NormalRewardBtn;

		// Token: 0x0401DD76 RID: 122230
		private KurotatoLimitTimeRewardButton LimitTimeRewardBtn;

		// Token: 0x0401DD77 RID: 122231
		private KurotatoStageEntrance TeachStageEntrance;

		// Token: 0x0401DD78 RID: 122232
		private KurotatoStageEntranceEndless InfiniteStageEntrance;

		// Token: 0x0401DD79 RID: 122233
		private KurotatoStageEntranceEndlessLock InfiniteStageEntranceLock;

		// Token: 0x0401DD7A RID: 122234
		private KurotatoCollectBtn CollectBtn;

		// Token: 0x0401DD7B RID: 122235
		protected KurotatoActivityData ActivityBaseData;

		// Token: 0x0401DD7C RID: 122236
		private TimerHandle TimerHandle;

		// Token: 0x0200B9B0 RID: 47536
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403824B RID: 229963
			Caption,
			// Token: 0x0403824C RID: 229964
			TeachStageEntrance,
			// Token: 0x0403824D RID: 229965
			InfiniteStageEntrance,
			// Token: 0x0403824E RID: 229966
			InfiniteStageEntranceLock,
			// Token: 0x0403824F RID: 229967
			LimitTimeRewardBtn,
			// Token: 0x04038250 RID: 229968
			NormalRewardBtn,
			// Token: 0x04038251 RID: 229969
			CollectBtn
		}
	}
}
