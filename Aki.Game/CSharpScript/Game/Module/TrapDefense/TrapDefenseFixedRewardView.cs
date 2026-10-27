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
	// Token: 0x02004A8F RID: 19087
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseFixedRewardView : UiViewBase
	{
		// Token: 0x06031797 RID: 202647 RVA: 0x00B77B36 File Offset: 0x00B75D36
		public TrapDefenseFixedRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031798 RID: 202648 RVA: 0x00B77B50 File Offset: 0x00B75D50
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

		// Token: 0x06031799 RID: 202649 RVA: 0x00B77BDC File Offset: 0x00B75DDC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseFixedRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseFixedRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603179A RID: 202650 RVA: 0x00B77C1F File Offset: 0x00B75E1F
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x0603179B RID: 202651 RVA: 0x00B77C27 File Offset: 0x00B75E27
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseRewardUpdate, new Action(this.EventTrapDefenseRewardUpdate));
		}

		// Token: 0x0603179C RID: 202652 RVA: 0x00B77C45 File Offset: 0x00B75E45
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseRewardUpdate, new Action(this.EventTrapDefenseRewardUpdate));
		}

		// Token: 0x0603179D RID: 202653 RVA: 0x00B77C63 File Offset: 0x00B75E63
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603179E RID: 202654 RVA: 0x00B77C65 File Offset: 0x00B75E65
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603179F RID: 202655 RVA: 0x00B77C68 File Offset: 0x00B75E68
		public void OnBtnHelp()
		{
			int helpIdFixedReward = TrapDefenseConfig.Instance.GetHelpIdFixedReward();
			HelpController.Instance.OpenHelpById(helpIdFixedReward);
		}

		// Token: 0x060317A0 RID: 202656 RVA: 0x00B77C8B File Offset: 0x00B75E8B
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060317A1 RID: 202657 RVA: 0x00B77C94 File Offset: 0x00B75E94
		public TrapDefenseRewardItem CreateItemReward()
		{
			return new TrapDefenseRewardItem
			{
				OnClaimRewardCallback = new Action<TrapDefenseRewardItemData>(this.OnClaimReward)
			};
		}

		// Token: 0x060317A2 RID: 202658 RVA: 0x00B77CAD File Offset: 0x00B75EAD
		public void UpdateData()
		{
			this.ScrollFixedReward.RefreshByData(this.ViewModel.GetFixedRewardDataList(), null, true);
		}

		// Token: 0x060317A3 RID: 202659 RVA: 0x00B77CC7 File Offset: 0x00B75EC7
		public void EventTrapDefenseRewardUpdate()
		{
			this.UpdateData();
		}

		// Token: 0x060317A4 RID: 202660 RVA: 0x00B77CCF File Offset: 0x00B75ECF
		private void OnClaimReward(TrapDefenseRewardItemData _)
		{
			TrapDefenseModel.Instance.RewardData.RequestFixedReward();
		}

		// Token: 0x0401A741 RID: 108353
		public TrapDefenseFixedRewardViewModel ViewModel = TrapDefenseModel.Instance.ViewModelFixedReward;

		// Token: 0x0401A742 RID: 108354
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401A743 RID: 108355
		public GenericScrollViewNew<TrapDefenseRewardItem, TrapDefenseRewardItemData> ScrollFixedReward;

		// Token: 0x0200ABE0 RID: 44000
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040343B6 RID: 213942
			public const int ItemCaption = 0;

			// Token: 0x040343B7 RID: 213943
			public const int ScrollReward = 1;

			// Token: 0x040343B8 RID: 213944
			public const int ItemReward = 2;
		}
	}
}
