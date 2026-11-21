using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A72 RID: 14962
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardView : UiTickViewBase
	{
		// Token: 0x06026725 RID: 157477 RVA: 0x00AC494F File Offset: 0x00AC2B4F
		public TrapDefenseRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026726 RID: 157478 RVA: 0x00AC4958 File Offset: 0x00AC2B58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026727 RID: 157479 RVA: 0x00AC4A68 File Offset: 0x00AC2C68
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026728 RID: 157480 RVA: 0x00AC4AAC File Offset: 0x00AC2CAC
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.ViewModelReward.RegisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.CaptionItem.SetHelpCallBack(delegate
			{
				int helpIdFixedReward = TrapDefenseConfig.Instance.GetHelpIdFixedReward();
				HelpController.Instance.OpenHelpById(helpIdFixedReward);
			});
			this.SpecialRewardItem.Refresh(TrapDefenseModel.Instance.RewardData.SpecialRewardData);
			this.LayoutTabs.SelectGridProxy(0, false);
			this.HasStartAnimPlayed = true;
		}

		// Token: 0x06026729 RID: 157481 RVA: 0x00AC4B55 File Offset: 0x00AC2D55
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.OnRewardUpdate));
		}

		// Token: 0x0602672A RID: 157482 RVA: 0x00AC4B73 File Offset: 0x00AC2D73
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.OnRewardUpdate));
		}

		// Token: 0x0602672B RID: 157483 RVA: 0x00AC4B94 File Offset: 0x00AC2D94
		protected override void OnTick(float deltaTime)
		{
			string limitRewardRemainTimeStr = TrapDefenseModel.Instance.RewardData.GetLimitRewardRemainTimeStr();
			base.GetText(3).SetText(limitRewardRemainTimeStr, true);
		}

		// Token: 0x0602672C RID: 157484 RVA: 0x00AC4BBF File Offset: 0x00AC2DBF
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelReward.UnregisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
			TrapDefenseModel.Instance.ViewModelReward.Clear();
		}

		// Token: 0x0602672D RID: 157485 RVA: 0x00AC4BEC File Offset: 0x00AC2DEC
		private void OnSelectedTypeChange(ETrapDefenseRewardType type)
		{
			if (this.HasStartAnimPlayed)
			{
				this.LayoutRewards.GetGenericLayout().GetUiAnimController().StartTime = 0f;
			}
			this.LayoutRewards.RefreshByData(TrapDefenseModel.Instance.RewardData.GetRewardListByType(type), null, true);
		}

		// Token: 0x0602672E RID: 157486 RVA: 0x00AC4C38 File Offset: 0x00AC2E38
		private void OnRewardUpdate()
		{
			ETrapDefenseRewardType curSelectRewardType = TrapDefenseModel.Instance.ViewModelReward.CurSelectRewardType;
			List<TrapDefenseRewardItemData> rewardListByType = TrapDefenseModel.Instance.RewardData.GetRewardListByType(curSelectRewardType);
			this.LayoutTabs.RefreshByData(TrapDefenseModel.Instance.ViewModelReward.GetRewardTypeDataList(), null, false);
			this.LayoutRewards.RefreshByData(rewardListByType, null, false);
			this.SpecialRewardItem.Refresh(TrapDefenseModel.Instance.RewardData.SpecialRewardData);
		}

		// Token: 0x0602672F RID: 157487 RVA: 0x00AC4CAA File Offset: 0x00AC2EAA
		private void OnClaimReward(TrapDefenseRewardItemData data)
		{
			TrapDefenseModel.Instance.RewardData.RequestClaimRewardByType(data.Type);
		}

		// Token: 0x04015151 RID: 86353
		private GenericLayout<TrapDefenseRewardTabItem, TrapDefenseRewardTabData> LayoutTabs;

		// Token: 0x04015152 RID: 86354
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015153 RID: 86355
		private GenericScrollViewNew<TrapDefenseRewardItem, TrapDefenseRewardItemData> LayoutRewards;

		// Token: 0x04015154 RID: 86356
		private TrapDefenseSpecialRewardItem SpecialRewardItem;

		// Token: 0x04015155 RID: 86357
		private bool HasStartAnimPlayed;

		// Token: 0x0200965A RID: 38490
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EEFB RID: 192251
			public const int ItemCaption = 0;

			// Token: 0x0402EEFC RID: 192252
			public const int LayoutTabs = 1;

			// Token: 0x0402EEFD RID: 192253
			public const int ItemTab = 2;

			// Token: 0x0402EEFE RID: 192254
			public const int TextTime = 3;

			// Token: 0x0402EEFF RID: 192255
			public const int LayoutRewards = 4;

			// Token: 0x0402EF00 RID: 192256
			public const int ItemReward = 5;

			// Token: 0x0402EF01 RID: 192257
			public const int ItemSpecialReward = 6;
		}
	}
}
