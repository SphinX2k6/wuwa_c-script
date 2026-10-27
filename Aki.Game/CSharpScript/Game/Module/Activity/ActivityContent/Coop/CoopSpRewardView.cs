using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068E4 RID: 26852
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopSpRewardView : UiViewBase
	{
		// Token: 0x06042FD4 RID: 274388 RVA: 0x010514C7 File Offset: 0x0104F6C7
		public CoopSpRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042FD5 RID: 274389 RVA: 0x010514D0 File Offset: 0x0104F6D0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
			};
		}

		// Token: 0x06042FD6 RID: 274390 RVA: 0x0105154D File Offset: 0x0104F74D
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as CoopActivityData);
			this.RewardLayout = new GenericScrollViewNew<CoopSpRewardItem, CoopSpRewardData>(base.GetScrollViewWithScrollbar(1), new Func<CoopSpRewardItem>(this.CreateRewardItem), null, false, null);
			this.RefreshRewardLayout(true);
		}

		// Token: 0x06042FD7 RID: 274391 RVA: 0x01051588 File Offset: 0x0104F788
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.OnCoopSpUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06042FD8 RID: 274392 RVA: 0x010515C2 File Offset: 0x0104F7C2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.OnCoopSpUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06042FD9 RID: 274393 RVA: 0x010515FC File Offset: 0x0104F7FC
		private void OnDataUpdate()
		{
			this.RefreshRewardLayout(false);
		}

		// Token: 0x06042FDA RID: 274394 RVA: 0x01051605 File Offset: 0x0104F805
		private void RefreshRewardLayout(bool isPlayAnim = false)
		{
			this.RewardLayout.RefreshByData(this.ActivityData.CoopSpRewardDataList, delegate
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}, isPlayAnim);
		}

		// Token: 0x06042FDB RID: 274395 RVA: 0x0105162A File Offset: 0x0104F82A
		private CoopSpRewardItem CreateRewardItem()
		{
			return new CoopSpRewardItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x06042FDC RID: 274396 RVA: 0x01051643 File Offset: 0x0104F843
		private void OnRewardBtnClick()
		{
			CoopActivityController.Instance.RequestCoopSpReward(this.ActivityData);
		}

		// Token: 0x06042FDD RID: 274397 RVA: 0x01051655 File Offset: 0x0104F855
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04022DF4 RID: 142836
		[Nullable(2)]
		private CoopActivityData ActivityData;

		// Token: 0x04022DF5 RID: 142837
		private GenericScrollViewNew<CoopSpRewardItem, CoopSpRewardData> RewardLayout;
	}
}
