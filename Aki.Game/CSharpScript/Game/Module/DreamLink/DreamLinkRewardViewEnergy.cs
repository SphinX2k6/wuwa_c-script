using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA9 RID: 23209
	public class DreamLinkRewardViewEnergy : UiViewBase
	{
		// Token: 0x0603ACA5 RID: 240805 RVA: 0x00E01C6F File Offset: 0x00DFFE6F
		[NullableContext(1)]
		public DreamLinkRewardViewEnergy(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ACA6 RID: 240806 RVA: 0x00E01C78 File Offset: 0x00DFFE78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603ACA7 RID: 240807 RVA: 0x00E01D04 File Offset: 0x00DFFF04
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRewardViewEnergy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRewardViewEnergy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACA8 RID: 240808 RVA: 0x00E01D47 File Offset: 0x00DFFF47
		protected override void OnStart()
		{
			this.ActivityDataBase = DreamLinkController.Instance.GetCurrentActivityData();
		}

		// Token: 0x0603ACA9 RID: 240809 RVA: 0x00E01D59 File Offset: 0x00DFFF59
		protected override void OnBeforeShow()
		{
			this.RefreshLayout();
			this.RefreshEnergy();
		}

		// Token: 0x0603ACAA RID: 240810 RVA: 0x00E01D68 File Offset: 0x00DFFF68
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.OnLayoutRefresh));
		}

		// Token: 0x0603ACAB RID: 240811 RVA: 0x00E01D86 File Offset: 0x00DFFF86
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.OnLayoutRefresh));
		}

		// Token: 0x0603ACAC RID: 240812 RVA: 0x00E01DA4 File Offset: 0x00DFFFA4
		[NullableContext(1)]
		private DreamLinkRewardEnergyItem CreateTaskItem()
		{
			DreamLinkRewardEnergyItem dreamLinkRewardEnergyItem = new DreamLinkRewardEnergyItem();
			dreamLinkRewardEnergyItem.SetBtnClickCallback(delegate
			{
				List<DreamLinkRewardData> energyRewardDataList = this.ActivityDataBase.GetEnergyRewardDataList();
				DreamLinkController.Instance.MultiEnergyRewardRequest((from data in energyRewardDataList
				where data.Status == EActivityTaskState.FinishedAndUnclaimed
				select data.Id).ToArray<int>());
			});
			return dreamLinkRewardEnergyItem;
		}

		// Token: 0x0603ACAD RID: 240813 RVA: 0x00E01DBD File Offset: 0x00DFFFBD
		private void OnLayoutRefresh()
		{
			this.RefreshLayout();
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityDataBase.Id);
		}

		// Token: 0x0603ACAE RID: 240814 RVA: 0x00E01DE4 File Offset: 0x00DFFFE4
		private UniTask RefreshLayout()
		{
			DreamLinkRewardViewEnergy.<RefreshLayout>d__13 <RefreshLayout>d__;
			<RefreshLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLayout>d__.<>4__this = this;
			<RefreshLayout>d__.<>1__state = -1;
			<RefreshLayout>d__.<>t__builder.Start<DreamLinkRewardViewEnergy.<RefreshLayout>d__13>(ref <RefreshLayout>d__);
			return <RefreshLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACAF RID: 240815 RVA: 0x00E01E28 File Offset: 0x00E00028
		private void RefreshEnergy()
		{
			int maxEnergy = this.ActivityDataBase.MaxEnergy;
			int energyItemCount = this.ActivityDataBase.GetEnergyItemCount();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DreamLink_Reward_Ins_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				energyItemCount,
				maxEnergy
			}));
		}

		// Token: 0x0401EAF0 RID: 125680
		[Nullable(2)]
		private DreamLinkData ActivityDataBase;

		// Token: 0x0401EAF1 RID: 125681
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401EAF2 RID: 125682
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkRewardEnergyItem, DreamLinkRewardData> TaskLayout;

		// Token: 0x0200BCED RID: 48365
		private class EComponentDefine
		{
			// Token: 0x04038FB4 RID: 233396
			public const int Layout = 0;

			// Token: 0x04038FB5 RID: 233397
			public const int CaptionItem = 1;

			// Token: 0x04038FB6 RID: 233398
			public const int Text = 2;
		}
	}
}
