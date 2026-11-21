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

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A85 RID: 19077
	public class DreamLinkRewardViewEnergy : UiViewBase
	{
		// Token: 0x0602FBF1 RID: 195569 RVA: 0x00D52223 File Offset: 0x00D50423
		[NullableContext(1)]
		public DreamLinkRewardViewEnergy(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FBF2 RID: 195570 RVA: 0x00D5222C File Offset: 0x00D5042C
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

		// Token: 0x0602FBF3 RID: 195571 RVA: 0x00D522B8 File Offset: 0x00D504B8
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRewardViewEnergy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRewardViewEnergy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBF4 RID: 195572 RVA: 0x00D522FB File Offset: 0x00D504FB
		protected override void OnStart()
		{
			this.ActivityDataBase = DreamLinkController.Instance.GetCurrentActivityData();
		}

		// Token: 0x0602FBF5 RID: 195573 RVA: 0x00D5230D File Offset: 0x00D5050D
		protected override void OnBeforeShow()
		{
			this.RefreshLayout();
			this.RefreshEnergy();
		}

		// Token: 0x0602FBF6 RID: 195574 RVA: 0x00D5231C File Offset: 0x00D5051C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.OnLayoutRefresh));
		}

		// Token: 0x0602FBF7 RID: 195575 RVA: 0x00D5233A File Offset: 0x00D5053A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.OnLayoutRefresh));
		}

		// Token: 0x0602FBF8 RID: 195576 RVA: 0x00D52358 File Offset: 0x00D50558
		[NullableContext(1)]
		private DreamLinkRewardEnergyItem CreateTaskItem()
		{
			DreamLinkRewardEnergyItem dreamLinkRewardEnergyItem = new DreamLinkRewardEnergyItem();
			dreamLinkRewardEnergyItem.SetBtnClickCallback(delegate
			{
				int[] ids = NoLinq.WhereSelectToArray<DreamLinkRewardData, int>(this.ActivityDataBase.GetEnergyRewardDataList(), (DreamLinkRewardData data) => data.Status == EActivityTaskState.FinishedAndUnclaimed, (DreamLinkRewardData data) => data.Id);
				DreamLinkController.Instance.MultiEnergyRewardRequest(ids);
			});
			return dreamLinkRewardEnergyItem;
		}

		// Token: 0x0602FBF9 RID: 195577 RVA: 0x00D52371 File Offset: 0x00D50571
		private void OnLayoutRefresh()
		{
			this.RefreshLayout();
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityDataBase.Id);
		}

		// Token: 0x0602FBFA RID: 195578 RVA: 0x00D52398 File Offset: 0x00D50598
		private UniTask RefreshLayout()
		{
			DreamLinkRewardViewEnergy.<RefreshLayout>d__13 <RefreshLayout>d__;
			<RefreshLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLayout>d__.<>4__this = this;
			<RefreshLayout>d__.<>1__state = -1;
			<RefreshLayout>d__.<>t__builder.Start<DreamLinkRewardViewEnergy.<RefreshLayout>d__13>(ref <RefreshLayout>d__);
			return <RefreshLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBFB RID: 195579 RVA: 0x00D523DC File Offset: 0x00D505DC
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

		// Token: 0x04019597 RID: 103831
		[Nullable(2)]
		private DreamLinkData ActivityDataBase;

		// Token: 0x04019598 RID: 103832
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x04019599 RID: 103833
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkRewardEnergyItem, DreamLinkRewardData> TaskLayout;

		// Token: 0x0200A6F6 RID: 42742
		private class EComponentDefine
		{
			// Token: 0x0403397F RID: 211327
			public const int Layout = 0;

			// Token: 0x04033980 RID: 211328
			public const int CaptionItem = 1;

			// Token: 0x04033981 RID: 211329
			public const int Text = 2;
		}
	}
}
