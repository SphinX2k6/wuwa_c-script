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
	// Token: 0x02003A37 RID: 14903
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseFixedRewardView : UiViewBase
	{
		// Token: 0x06026527 RID: 156967 RVA: 0x00ABBAEA File Offset: 0x00AB9CEA
		public TrapDefenseFixedRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026528 RID: 156968 RVA: 0x00ABBB04 File Offset: 0x00AB9D04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026529 RID: 156969 RVA: 0x00ABBB90 File Offset: 0x00AB9D90
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseFixedRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseFixedRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602652A RID: 156970 RVA: 0x00ABBBD3 File Offset: 0x00AB9DD3
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x0602652B RID: 156971 RVA: 0x00ABBBDB File Offset: 0x00AB9DDB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.EventTrapDefenseRewardUpdate));
		}

		// Token: 0x0602652C RID: 156972 RVA: 0x00ABBBF9 File Offset: 0x00AB9DF9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.EventTrapDefenseRewardUpdate));
		}

		// Token: 0x0602652D RID: 156973 RVA: 0x00ABBC17 File Offset: 0x00AB9E17
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602652E RID: 156974 RVA: 0x00ABBC19 File Offset: 0x00AB9E19
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602652F RID: 156975 RVA: 0x00ABBC1C File Offset: 0x00AB9E1C
		public void OnBtnHelp()
		{
			int helpIdFixedReward = TrapDefenseConfig.Instance.GetHelpIdFixedReward();
			HelpController.Instance.OpenHelpById(helpIdFixedReward);
		}

		// Token: 0x06026530 RID: 156976 RVA: 0x00ABBC3F File Offset: 0x00AB9E3F
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026531 RID: 156977 RVA: 0x00ABBC48 File Offset: 0x00AB9E48
		public TrapDefenseRewardItem CreateItemReward()
		{
			return new TrapDefenseRewardItem
			{
				OnClaimRewardCallback = new Action<TrapDefenseRewardItemData>(this.OnClaimReward)
			};
		}

		// Token: 0x06026532 RID: 156978 RVA: 0x00ABBC61 File Offset: 0x00AB9E61
		public void UpdateData()
		{
			this.ScrollFixedReward.RefreshByData(this.ViewModel.GetFixedRewardDataList(), null, true);
		}

		// Token: 0x06026533 RID: 156979 RVA: 0x00ABBC7B File Offset: 0x00AB9E7B
		public void EventTrapDefenseRewardUpdate()
		{
			this.UpdateData();
		}

		// Token: 0x06026534 RID: 156980 RVA: 0x00ABBC83 File Offset: 0x00AB9E83
		private void OnClaimReward(TrapDefenseRewardItemData _)
		{
			TrapDefenseModel.Instance.RewardData.RequestFixedReward();
		}

		// Token: 0x04015093 RID: 86163
		public TrapDefenseFixedRewardViewModel ViewModel = TrapDefenseModel.Instance.ViewModelFixedReward;

		// Token: 0x04015094 RID: 86164
		public PopupCaptionItem PopupCaption;

		// Token: 0x04015095 RID: 86165
		public GenericScrollViewNew<TrapDefenseRewardItem, TrapDefenseRewardItemData> ScrollFixedReward;

		// Token: 0x02009600 RID: 38400
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402ED67 RID: 191847
			public const int ItemCaption = 0;

			// Token: 0x0402ED68 RID: 191848
			public const int ScrollReward = 1;

			// Token: 0x0402ED69 RID: 191849
			public const int ItemReward = 2;
		}
	}
}
