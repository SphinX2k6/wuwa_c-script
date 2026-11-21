using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053E7 RID: 21479
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInRewardView : UiViewBase
	{
		// Token: 0x0603564E RID: 218702 RVA: 0x00EE9EAC File Offset: 0x00EE80AC
		public MoonSignInRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603564F RID: 218703 RVA: 0x00EE9EB8 File Offset: 0x00EE80B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickRewardBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035650 RID: 218704 RVA: 0x00EEA0F4 File Offset: 0x00EE82F4
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035651 RID: 218705 RVA: 0x00EEA137 File Offset: 0x00EE8337
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoonSignRewardRefresh, new Action(this.MoonSignRewardRefresh));
		}

		// Token: 0x06035652 RID: 218706 RVA: 0x00EEA155 File Offset: 0x00EE8355
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoonSignRewardRefresh, new Action(this.MoonSignRewardRefresh));
		}

		// Token: 0x06035653 RID: 218707 RVA: 0x00EEA174 File Offset: 0x00EE8374
		protected override void OnStart()
		{
			this.NormalRewardGenericScrollView = new GenericScrollViewNew<NormalRewardItem, int>(base.GetScrollViewWithScrollbar(1), new Func<NormalRewardItem>(this.InitGridItem), null, false, null);
			this.GrandRewardGenericScrollView = new GenericScrollViewNew<RewardItem, IRewardItemData>(base.GetScrollViewWithScrollbar(6), new Func<RewardItem>(this.InitGrandRewardGridItem), null, false, null);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(13).SetUIActive(true);
			this.NormalRewardGenericScrollView.BindScrollValueChange(delegate(FVector2D progress)
			{
				base.GetItem(12).SetUIActive(progress.X < 1f);
				base.GetItem(13).SetUIActive(progress.X > 0f);
			});
		}

		// Token: 0x06035654 RID: 218708 RVA: 0x00EEA1F6 File Offset: 0x00EE83F6
		protected override void OnBeforeShow()
		{
			this.MoonSignRewardRefresh();
		}

		// Token: 0x06035655 RID: 218709 RVA: 0x00EEA200 File Offset: 0x00EE8400
		private void RefreshGrandRewardScrollView()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(data.Id);
			if (moonSignReward == null)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(moonSignReward.Value.Reward);
			bool moonGrandReward = data.MoonGrandReward;
			List<IRewardItemData> list = new List<IRewardItemData>();
			foreach (TItem itemData in dropPackagePreviewItemList)
			{
				RewardItemDataImpl item = new RewardItemDataImpl
				{
					ItemData = itemData,
					HaveFinish = moonGrandReward
				};
				list.Add(item);
			}
			this.GrandRewardGenericScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x06035656 RID: 218710 RVA: 0x00EEA2C8 File Offset: 0x00EE84C8
		private NormalRewardItem InitGridItem()
		{
			return new NormalRewardItem();
		}

		// Token: 0x06035657 RID: 218711 RVA: 0x00EEA2CF File Offset: 0x00EE84CF
		private RewardItem InitGrandRewardGridItem()
		{
			return new RewardItem();
		}

		// Token: 0x06035658 RID: 218712 RVA: 0x00EEA2D8 File Offset: 0x00EE84D8
		private void MoonSignRewardRefresh()
		{
			GenericScrollViewNew<NormalRewardItem, int> normalRewardGenericScrollView = this.NormalRewardGenericScrollView;
			if (normalRewardGenericScrollView != null)
			{
				MoonSignInData data = MoonSignInController.Instance.GetData();
				normalRewardGenericScrollView.RefreshByData(((data != null) ? data.GetMoonNormalRewardData() : null) ?? new List<int>(), null, false);
			}
			this.RefreshGrandRewardScrollView();
			this.RefreshBtnState();
			this.RefreshDesText();
		}

		// Token: 0x06035659 RID: 218713 RVA: 0x00EEA32C File Offset: 0x00EE852C
		private void RefreshDesText()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(data.Id);
			if (moonSignReward == null)
			{
				return;
			}
			int count = data.HaveSelectMoonPhaseSelectList.Count;
			int needMoonNum = moonSignReward.Value.NeedMoonNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MoonSignInGrandRewardDes", new <>z__ReadOnlyArray<object>(new object[]
			{
				needMoonNum.ToString(),
				count.ToString(),
				needMoonNum.ToString()
			}));
		}

		// Token: 0x0603565A RID: 218714 RVA: 0x00EEA3C0 File Offset: 0x00EE85C0
		private void RefreshBtnState()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			bool moonGrandReward = data.MoonGrandReward;
			bool canGetMoonGrandReward = data.GetCanGetMoonGrandReward();
			base.GetItem(11).SetUIActive(moonGrandReward);
			base.GetItem(10).SetUIActive(!moonGrandReward && !canGetMoonGrandReward);
			base.GetButton(9).RootUIComp.Get().SetUIActive(!moonGrandReward && canGetMoonGrandReward);
		}

		// Token: 0x0603565B RID: 218715 RVA: 0x00EEA430 File Offset: 0x00EE8630
		private void OnClickRewardBtn()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			if (data.GetCanGetMoonGrandReward())
			{
				MoonSignInController.Instance.MoonPhaseRewardRequest(data.Id);
			}
		}

		// Token: 0x0401C287 RID: 115335
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C288 RID: 115336
		private GenericScrollViewNew<NormalRewardItem, int> NormalRewardGenericScrollView;

		// Token: 0x0401C289 RID: 115337
		private GenericScrollViewNew<RewardItem, IRewardItemData> GrandRewardGenericScrollView;

		// Token: 0x0200B07B RID: 45179
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036896 RID: 223382
			public const int CaptionItem = 0;

			// Token: 0x04036897 RID: 223383
			public const int RewardScrollView = 1;

			// Token: 0x04036898 RID: 223384
			public const int RewardContentItem = 2;

			// Token: 0x04036899 RID: 223385
			public const int RewardItem = 3;

			// Token: 0x0403689A RID: 223386
			public const int MoonGrandRewardTitleText = 4;

			// Token: 0x0403689B RID: 223387
			public const int MoonGrandRewardDesText = 5;

			// Token: 0x0403689C RID: 223388
			public const int MoonGrandRewardScrollView = 6;

			// Token: 0x0403689D RID: 223389
			public const int MoonGrandRewardContentItem = 7;

			// Token: 0x0403689E RID: 223390
			public const int MoonGrandRewardItem = 8;

			// Token: 0x0403689F RID: 223391
			public const int RewardBtn = 9;

			// Token: 0x040368A0 RID: 223392
			public const int UnFinishItem = 10;

			// Token: 0x040368A1 RID: 223393
			public const int ObtainedItem = 11;

			// Token: 0x040368A2 RID: 223394
			public const int LeftButton = 12;

			// Token: 0x040368A3 RID: 223395
			public const int RightButton = 13;
		}
	}
}
