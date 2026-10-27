using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006462 RID: 25698
	[NullableContext(2)]
	[Nullable(0)]
	public class MoonSignInDetailView : UiViewBase
	{
		// Token: 0x0604094B RID: 264523 RVA: 0x00FA12BD File Offset: 0x00F9F4BD
		[NullableContext(1)]
		public MoonSignInDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604094C RID: 264524 RVA: 0x00FA12C8 File Offset: 0x00F9F4C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickGoOnBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickPreviousBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickNextBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickBackBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604094D RID: 264525 RVA: 0x00FA14C1 File Offset: 0x00F9F6C1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0604094E RID: 264526 RVA: 0x00FA14DF File Offset: 0x00F9F6DF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0604094F RID: 264527 RVA: 0x00FA1500 File Offset: 0x00F9F700
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040950 RID: 264528 RVA: 0x00FA1544 File Offset: 0x00F9F744
		protected override void OnStart()
		{
			IMoonSignInDetailViewOpenData moonSignInDetailViewOpenData = this.OpenParam as IMoonSignInDetailViewOpenData;
			this.CurrentMoonId = moonSignInDetailViewOpenData.MoonId;
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			if (moonSignInDetailViewOpenData.Wishing != null && moonSignInDetailViewOpenData.Wishing.Value)
			{
				this.OpenWishingPanel();
				return;
			}
			this.OpenIllustratedPanel();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start02", false, null, false);
		}

		// Token: 0x06040951 RID: 264529 RVA: 0x00FA15D0 File Offset: 0x00F9F7D0
		private void OpenWishingPanel()
		{
			IllustratedUnLockItem illustratedUnLockItem = this.IllustratedUnLockItem;
			if (illustratedUnLockItem != null)
			{
				illustratedUnLockItem.SetUiActive(true);
			}
			IllustratedLockItem illustratedLockItem = this.IllustratedLockItem;
			if (illustratedLockItem != null)
			{
				illustratedLockItem.SetUiActive(false);
			}
			IllustratedUnLockItem illustratedUnLockItem2 = this.IllustratedUnLockItem;
			if (illustratedUnLockItem2 != null)
			{
				illustratedUnLockItem2.RefreshItem(this.CurrentMoonId);
			}
			PhaseOfMoon? phaseOfMoon;
			this.HandleWishingReward = ((MoonSignInConfig.Instance.GetPhaseOfMoonById(this.CurrentMoonId) != null) ? phaseOfMoon.GetValueOrDefault().Reward : 0);
			WishingItem wishingItem = this.WishingItem;
			if (wishingItem != null)
			{
				wishingItem.RefreshItem(this.CurrentMoonId);
			}
			WishingItem wishingItem2 = this.WishingItem;
			if (wishingItem2 != null)
			{
				wishingItem2.SetUiActive(true);
			}
			base.GetItem(10).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
		}

		// Token: 0x06040952 RID: 264530 RVA: 0x00FA16C9 File Offset: 0x00F9F8C9
		private void CloseWishingPanel()
		{
			WishingItem wishingItem = this.WishingItem;
			if (wishingItem == null)
			{
				return;
			}
			wishingItem.SetUiActive(false);
		}

		// Token: 0x06040953 RID: 264531 RVA: 0x00FA16DC File Offset: 0x00F9F8DC
		private void OpenIllustratedPanel()
		{
			this.CloseWishingPanel();
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			bool flag = data.CheckPhaseLock(this.CurrentMoonId);
			IllustratedUnLockItem illustratedUnLockItem = this.IllustratedUnLockItem;
			if (illustratedUnLockItem != null)
			{
				illustratedUnLockItem.SetUiActive(!flag);
			}
			IllustratedLockItem illustratedLockItem = this.IllustratedLockItem;
			if (illustratedLockItem != null)
			{
				illustratedLockItem.SetUiActive(flag);
			}
			if (flag)
			{
				IllustratedLockItem illustratedLockItem2 = this.IllustratedLockItem;
				if (illustratedLockItem2 != null)
				{
					illustratedLockItem2.RefreshItem(this.CurrentMoonId);
				}
			}
			else
			{
				IllustratedUnLockItem illustratedUnLockItem2 = this.IllustratedUnLockItem;
				if (illustratedUnLockItem2 != null)
				{
					illustratedUnLockItem2.RefreshItem(this.CurrentMoonId);
				}
			}
			base.GetItem(10).SetUIActive(true);
			base.GetItem(11).SetUIActive(true);
		}

		// Token: 0x06040954 RID: 264532 RVA: 0x00FA1784 File Offset: 0x00F9F984
		private void OpenHandleRewardView()
		{
			this.CloseWishingPanel();
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.HandleWishingReward);
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (TItem titem in dropPackagePreviewItemList)
			{
				RewardItemData item = new RewardItemData(titem.ItemData.ItemId, titem.Count, null, EDropItemType.Normal);
				list.Add(item);
			}
			ItemRewardController.Instance.OpenCommonRewardView(1009, list, null);
			this.HandleWishingReward = 0;
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetItem(10).SetUIActive(true);
			base.GetItem(11).SetUIActive(true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Next", false, null, false);
			}
			IllustratedUnLockItem illustratedUnLockItem = this.IllustratedUnLockItem;
			if (illustratedUnLockItem == null)
			{
				return;
			}
			illustratedUnLockItem.RefreshShareBtn();
		}

		// Token: 0x06040955 RID: 264533 RVA: 0x00FA18AC File Offset: 0x00F9FAAC
		private void OnClickGoOnBtn()
		{
			if (this.HandleWishingReward != 0)
			{
				this.OpenHandleRewardView();
			}
		}

		// Token: 0x06040956 RID: 264534 RVA: 0x00FA18BC File Offset: 0x00F9FABC
		private void OnClickPreviousBtn()
		{
			if (this.HandleWishingReward != 0)
			{
				this.OpenHandleRewardView();
			}
			else
			{
				this.CurrentMoonId--;
				if (this.CurrentMoonId <= 0)
				{
					this.CurrentMoonId = 10;
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06040957 RID: 264535 RVA: 0x00FA192C File Offset: 0x00F9FB2C
		private void OnClickNextBtn()
		{
			if (this.HandleWishingReward != 0)
			{
				this.OpenHandleRewardView();
			}
			else
			{
				this.CurrentMoonId++;
				if (this.CurrentMoonId > 10)
				{
					this.CurrentMoonId = 1;
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06040958 RID: 264536 RVA: 0x00FA199B File Offset: 0x00F9FB9B
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040959 RID: 264537 RVA: 0x00FA19A4 File Offset: 0x00F9FBA4
		[NullableContext(1)]
		private void OnActivitySequenceEmitEvent(string name)
		{
			if (name == "Enter")
			{
				this.OpenIllustratedPanel();
			}
		}

		// Token: 0x0604095A RID: 264538 RVA: 0x00FA19BC File Offset: 0x00F9FBBC
		private void SetNextAndBackBtnUiActive(bool active)
		{
			base.GetItem(10).SetUIActive(active);
			base.GetItem(11).SetUIActive(active);
			base.GetButton(6).RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x0604095B RID: 264539 RVA: 0x00FA19FF File Offset: 0x00F9FBFF
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0402194B RID: 137547
		private int CurrentMoonId;

		// Token: 0x0402194C RID: 137548
		private IllustratedUnLockItem IllustratedUnLockItem;

		// Token: 0x0402194D RID: 137549
		private IllustratedLockItem IllustratedLockItem;

		// Token: 0x0402194E RID: 137550
		private WishingItem WishingItem;

		// Token: 0x0402194F RID: 137551
		private int HandleWishingReward;

		// Token: 0x04021950 RID: 137552
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C688 RID: 50824
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403BEE6 RID: 245478
			public const int GoOnBtn = 0;

			// Token: 0x0403BEE7 RID: 245479
			public const int PreviousBtn = 1;

			// Token: 0x0403BEE8 RID: 245480
			public const int NextBtn = 2;

			// Token: 0x0403BEE9 RID: 245481
			public const int IllustratedUnLockItem = 3;

			// Token: 0x0403BEEA RID: 245482
			public const int IllustratedLockItem = 4;

			// Token: 0x0403BEEB RID: 245483
			public const int WishingItem = 5;

			// Token: 0x0403BEEC RID: 245484
			public const int BackBtn = 6;

			// Token: 0x0403BEED RID: 245485
			public const int NextBtnItem = 10;

			// Token: 0x0403BEEE RID: 245486
			public const int PreviousBtnItem = 11;
		}
	}
}
