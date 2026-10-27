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
	// Token: 0x02004ACA RID: 19146
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardView : UiTickViewBase
	{
		// Token: 0x06031995 RID: 203157 RVA: 0x00B8099B File Offset: 0x00B7EB9B
		public TrapDefenseRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031996 RID: 203158 RVA: 0x00B809A4 File Offset: 0x00B7EBA4
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

		// Token: 0x06031997 RID: 203159 RVA: 0x00B80AB4 File Offset: 0x00B7ECB4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031998 RID: 203160 RVA: 0x00B80AF8 File Offset: 0x00B7ECF8
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

		// Token: 0x06031999 RID: 203161 RVA: 0x00B80BA1 File Offset: 0x00B7EDA1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.OnRewardUpdate));
		}

		// Token: 0x0603199A RID: 203162 RVA: 0x00B80BBF File Offset: 0x00B7EDBF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.OnRewardUpdate));
		}

		// Token: 0x0603199B RID: 203163 RVA: 0x00B80BE0 File Offset: 0x00B7EDE0
		protected override void OnTick(float deltaTime)
		{
			string limitRewardRemainTimeStr = TrapDefenseModel.Instance.RewardData.GetLimitRewardRemainTimeStr();
			base.GetText(3).SetText(limitRewardRemainTimeStr, true);
		}

		// Token: 0x0603199C RID: 203164 RVA: 0x00B80C0B File Offset: 0x00B7EE0B
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelReward.UnregisterOnSelectRewardTypeChange(new Action<ETrapDefenseRewardType>(this.OnSelectedTypeChange));
			TrapDefenseModel.Instance.ViewModelReward.Clear();
		}

		// Token: 0x0603199D RID: 203165 RVA: 0x00B80C38 File Offset: 0x00B7EE38
		private void OnSelectedTypeChange(ETrapDefenseRewardType type)
		{
			if (this.HasStartAnimPlayed)
			{
				this.LayoutRewards.GetGenericLayout().GetUiAnimController().StartTime = 0f;
			}
			this.LayoutRewards.RefreshByData(TrapDefenseModel.Instance.RewardData.GetRewardListByType(type), null, true);
		}

		// Token: 0x0603199E RID: 203166 RVA: 0x00B80C84 File Offset: 0x00B7EE84
		private void OnRewardUpdate()
		{
			ETrapDefenseRewardType curSelectRewardType = TrapDefenseModel.Instance.ViewModelReward.CurSelectRewardType;
			List<TrapDefenseRewardItemData> rewardListByType = TrapDefenseModel.Instance.RewardData.GetRewardListByType(curSelectRewardType);
			this.LayoutTabs.RefreshByData(TrapDefenseModel.Instance.ViewModelReward.GetRewardTypeDataList(), null, false);
			this.LayoutRewards.RefreshByData(rewardListByType, null, false);
			this.SpecialRewardItem.Refresh(TrapDefenseModel.Instance.RewardData.SpecialRewardData);
		}

		// Token: 0x0603199F RID: 203167 RVA: 0x00B80CF6 File Offset: 0x00B7EEF6
		private void OnClaimReward(TrapDefenseRewardItemData data)
		{
			TrapDefenseModel.Instance.RewardData.RequestClaimRewardByType(data.Type);
		}

		// Token: 0x0401A7FF RID: 108543
		private GenericLayout<TrapDefenseRewardTabItem, TrapDefenseRewardTabData> LayoutTabs;

		// Token: 0x0401A800 RID: 108544
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401A801 RID: 108545
		private GenericScrollViewNew<TrapDefenseRewardItem, TrapDefenseRewardItemData> LayoutRewards;

		// Token: 0x0401A802 RID: 108546
		private TrapDefenseSpecialRewardItem SpecialRewardItem;

		// Token: 0x0401A803 RID: 108547
		private bool HasStartAnimPlayed;

		// Token: 0x0200AC3A RID: 44090
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403454A RID: 214346
			public const int ItemCaption = 0;

			// Token: 0x0403454B RID: 214347
			public const int LayoutTabs = 1;

			// Token: 0x0403454C RID: 214348
			public const int ItemTab = 2;

			// Token: 0x0403454D RID: 214349
			public const int TextTime = 3;

			// Token: 0x0403454E RID: 214350
			public const int LayoutRewards = 4;

			// Token: 0x0403454F RID: 214351
			public const int ItemReward = 5;

			// Token: 0x04034550 RID: 214352
			public const int ItemSpecialReward = 6;
		}
	}
}
