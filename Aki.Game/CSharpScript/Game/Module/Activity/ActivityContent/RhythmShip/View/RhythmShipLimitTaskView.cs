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
	// Token: 0x02006229 RID: 25129
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipLimitTaskView : UiTickViewBase
	{
		// Token: 0x0603F5ED RID: 259565 RVA: 0x00F51BEC File Offset: 0x00F4FDEC
		public RhythmShipLimitTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F5EE RID: 259566 RVA: 0x00F51C00 File Offset: 0x00F4FE00
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

		// Token: 0x0603F5EF RID: 259567 RVA: 0x00F51CBF File Offset: 0x00F4FEBF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x0603F5F0 RID: 259568 RVA: 0x00F51CDD File Offset: 0x00F4FEDD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRhythmShipTaskRefresh, new Action(this.OnRhythmShipTaskRefresh));
		}

		// Token: 0x0603F5F1 RID: 259569 RVA: 0x00F51CFC File Offset: 0x00F4FEFC
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipLimitTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipLimitTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F5F2 RID: 259570 RVA: 0x00F51D3F File Offset: 0x00F4FF3F
		protected override void OnTick(float delta)
		{
			if (this.RefreshTime > 500f)
			{
				this.RefreshTimeText();
				this.RefreshTime = 0f;
			}
			this.RefreshTime += delta;
		}

		// Token: 0x0603F5F3 RID: 259571 RVA: 0x00F51D6D File Offset: 0x00F4FF6D
		protected override void OnStart()
		{
			this.TitleRemainTimeText = (TextConfig.Instance.GetMultiTextByKey("ActivityRemainingTime") ?? "");
			this.RefreshTaskScrollView();
			this.RefreshTimeText();
		}

		// Token: 0x0603F5F4 RID: 259572 RVA: 0x00F51D9C File Offset: 0x00F4FF9C
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

		// Token: 0x0603F5F5 RID: 259573 RVA: 0x00F51DE0 File Offset: 0x00F4FFE0
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

		// Token: 0x0603F5F6 RID: 259574 RVA: 0x00F51E40 File Offset: 0x00F50040
		private void OnRhythmShipTaskRefresh()
		{
			this.RefreshTaskScrollView();
		}

		// Token: 0x0603F5F7 RID: 259575 RVA: 0x00F51E48 File Offset: 0x00F50048
		private void OnLookBtnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(80065017, true, null);
		}

		// Token: 0x04021149 RID: 135497
		private const int REFRESH_TIME = 500;

		// Token: 0x0402114A RID: 135498
		private const int REWARD_BUSINESS_CARD_ID = 80065017;

		// Token: 0x0402114B RID: 135499
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402114C RID: 135500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RhythmShipTaskItem, int> TaskScrollView;

		// Token: 0x0402114D RID: 135501
		private string TitleRemainTimeText = "";

		// Token: 0x0402114E RID: 135502
		private float RefreshTime;
	}
}
