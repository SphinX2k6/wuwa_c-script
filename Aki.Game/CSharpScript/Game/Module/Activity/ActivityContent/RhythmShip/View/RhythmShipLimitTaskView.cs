using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051A7 RID: 20903
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipLimitTaskView : UiTickViewBase
	{
		// Token: 0x060342AE RID: 213678 RVA: 0x00E98B44 File Offset: 0x00E96D44
		public RhythmShipLimitTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060342AF RID: 213679 RVA: 0x00E98B58 File Offset: 0x00E96D58
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnLookBtnClick))
			};
		}

		// Token: 0x060342B0 RID: 213680 RVA: 0x00E98C17 File Offset: 0x00E96E17
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x060342B1 RID: 213681 RVA: 0x00E98C35 File Offset: 0x00E96E35
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x060342B2 RID: 213682 RVA: 0x00E98C54 File Offset: 0x00E96E54
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipLimitTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipLimitTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060342B3 RID: 213683 RVA: 0x00E98C97 File Offset: 0x00E96E97
		protected override void OnTick(float delta)
		{
			if (this.RefreshTime > 500f)
			{
				this.RefreshTimeText();
				this.RefreshTime = 0f;
			}
			this.RefreshTime += delta;
		}

		// Token: 0x060342B4 RID: 213684 RVA: 0x00E98CC5 File Offset: 0x00E96EC5
		protected override void OnStart()
		{
			this.TitleRemainTimeText = (TextConfig.Instance.GetMultiTextByKey("ActivityRemainingTime") ?? "");
			this.RefreshTaskScrollView();
			this.RefreshTimeText();
		}

		// Token: 0x060342B5 RID: 213685 RVA: 0x00E98CF4 File Offset: 0x00E96EF4
		private void RefreshTaskScrollView()
		{
			List<int> rhythmShipTaskIdByTypeAndActivityId = RhythmShipConfig.Instance.GetRhythmShipTaskIdByTypeAndActivityId(1, RhythmShipModel.Instance.ActivityId);
			List<int> data = RhythmShipModel.Instance.SortTaskItem(rhythmShipTaskIdByTypeAndActivityId, true);
			GenericScrollViewNew<RhythmShipTaskItem, int> taskScrollView = this.TaskScrollView;
			if (taskScrollView == null)
			{
				return;
			}
			taskScrollView.RefreshByData(data, null, true);
		}

		// Token: 0x060342B6 RID: 213686 RVA: 0x00E98D38 File Offset: 0x00E96F38
		private void RefreshTimeText()
		{
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				base.CloseMe(null);
				return;
			}
			if (!activityData.CheckIfInLimitTime())
			{
				base.CloseMe(null);
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(activityData.EndRewardTime, this.TitleRemainTimeText);
			base.GetText(3).SetText(remainTimeText ?? "", true);
		}

		// Token: 0x060342B7 RID: 213687 RVA: 0x00E98D98 File Offset: 0x00E96F98
		private void OnRhythmShipTaskRefresh()
		{
			this.RefreshTaskScrollView();
		}

		// Token: 0x060342B8 RID: 213688 RVA: 0x00E98DA0 File Offset: 0x00E96FA0
		private void OnLookBtnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(80065017, true, null, false);
		}

		// Token: 0x0401BA78 RID: 113272
		private const int REFRESH_TIME = 500;

		// Token: 0x0401BA79 RID: 113273
		private const int REWARD_BUSINESS_CARD_ID = 80065017;

		// Token: 0x0401BA7A RID: 113274
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BA7B RID: 113275
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RhythmShipTaskItem, int> TaskScrollView;

		// Token: 0x0401BA7C RID: 113276
		private string TitleRemainTimeText = "";

		// Token: 0x0401BA7D RID: 113277
		private float RefreshTime;
	}
}
