using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005834 RID: 22580
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopSpRewardView : UiViewBase
	{
		// Token: 0x06037B2C RID: 228140 RVA: 0x00F92AEF File Offset: 0x00F90CEF
		public CoopSpRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037B2D RID: 228141 RVA: 0x00F92AF8 File Offset: 0x00F90CF8
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

		// Token: 0x06037B2E RID: 228142 RVA: 0x00F92B75 File Offset: 0x00F90D75
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as CoopActivityData);
			this.RewardLayout = new GenericScrollViewNew<CoopSpRewardItem, CoopSpRewardData>(base.GetScrollViewWithScrollbar(1), new Func<CoopSpRewardItem>(this.CreateRewardItem), null, false, null);
			this.RefreshRewardLayout(true);
		}

		// Token: 0x06037B2F RID: 228143 RVA: 0x00F92BB0 File Offset: 0x00F90DB0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCoopLevelUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Add(EEventName.OnCoopSpUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06037B30 RID: 228144 RVA: 0x00F92BEA File Offset: 0x00F90DEA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCoopLevelUpdate, new Action(this.OnDataUpdate));
			EventSystem.Instance.Remove(EEventName.OnCoopSpUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x06037B31 RID: 228145 RVA: 0x00F92C24 File Offset: 0x00F90E24
		private void OnDataUpdate()
		{
			this.RefreshRewardLayout(false);
		}

		// Token: 0x06037B32 RID: 228146 RVA: 0x00F92C2D File Offset: 0x00F90E2D
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

		// Token: 0x06037B33 RID: 228147 RVA: 0x00F92C52 File Offset: 0x00F90E52
		private CoopSpRewardItem CreateRewardItem()
		{
			return new CoopSpRewardItem
			{
				OnRewardBtnClick = new Action(this.OnRewardBtnClick)
			};
		}

		// Token: 0x06037B34 RID: 228148 RVA: 0x00F92C6B File Offset: 0x00F90E6B
		private void OnRewardBtnClick()
		{
			CoopActivityController.Instance.RequestCoopSpReward(this.ActivityData);
		}

		// Token: 0x06037B35 RID: 228149 RVA: 0x00F92C7D File Offset: 0x00F90E7D
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D650 RID: 120400
		[Nullable(2)]
		private CoopActivityData ActivityData;

		// Token: 0x0401D651 RID: 120401
		private GenericScrollViewNew<CoopSpRewardItem, CoopSpRewardData> RewardLayout;
	}
}
