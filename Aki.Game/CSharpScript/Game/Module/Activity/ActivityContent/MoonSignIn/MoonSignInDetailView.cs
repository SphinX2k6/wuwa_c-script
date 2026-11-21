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
	// Token: 0x020053E0 RID: 21472
	[NullableContext(2)]
	[Nullable(0)]
	public class MoonSignInDetailView : UiViewBase
	{
		// Token: 0x0603560C RID: 218636 RVA: 0x00EE8239 File Offset: 0x00EE6439
		[NullableContext(1)]
		public MoonSignInDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603560D RID: 218637 RVA: 0x00EE8244 File Offset: 0x00EE6444
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

		// Token: 0x0603560E RID: 218638 RVA: 0x00EE843D File Offset: 0x00EE663D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603560F RID: 218639 RVA: 0x00EE845B File Offset: 0x00EE665B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x06035610 RID: 218640 RVA: 0x00EE847C File Offset: 0x00EE667C
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035611 RID: 218641 RVA: 0x00EE84C0 File Offset: 0x00EE66C0
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

		// Token: 0x06035612 RID: 218642 RVA: 0x00EE854C File Offset: 0x00EE674C
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

		// Token: 0x06035613 RID: 218643 RVA: 0x00EE8645 File Offset: 0x00EE6845
		private void CloseWishingPanel()
		{
			WishingItem wishingItem = this.WishingItem;
			if (wishingItem == null)
			{
				return;
			}
			wishingItem.SetUiActive(false);
		}

		// Token: 0x06035614 RID: 218644 RVA: 0x00EE8658 File Offset: 0x00EE6858
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

		// Token: 0x06035615 RID: 218645 RVA: 0x00EE8700 File Offset: 0x00EE6900
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

		// Token: 0x06035616 RID: 218646 RVA: 0x00EE8828 File Offset: 0x00EE6A28
		private void OnClickGoOnBtn()
		{
			if (this.HandleWishingReward != 0)
			{
				this.OpenHandleRewardView();
			}
		}

		// Token: 0x06035617 RID: 218647 RVA: 0x00EE8838 File Offset: 0x00EE6A38
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

		// Token: 0x06035618 RID: 218648 RVA: 0x00EE88A8 File Offset: 0x00EE6AA8
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

		// Token: 0x06035619 RID: 218649 RVA: 0x00EE8917 File Offset: 0x00EE6B17
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603561A RID: 218650 RVA: 0x00EE8920 File Offset: 0x00EE6B20
		[NullableContext(1)]
		private void OnActivitySequenceEmitEvent(string name)
		{
			if (name == "Enter")
			{
				this.OpenIllustratedPanel();
			}
		}

		// Token: 0x0603561B RID: 218651 RVA: 0x00EE8938 File Offset: 0x00EE6B38
		private void SetNextAndBackBtnUiActive(bool active)
		{
			base.GetItem(10).SetUIActive(active);
			base.GetItem(11).SetUIActive(active);
			base.GetButton(6).RootUIComp.Get().SetUIActive(active);
		}

		// Token: 0x0603561C RID: 218652 RVA: 0x00EE897B File Offset: 0x00EE6B7B
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0401C27A RID: 115322
		private int CurrentMoonId;

		// Token: 0x0401C27B RID: 115323
		private IllustratedUnLockItem IllustratedUnLockItem;

		// Token: 0x0401C27C RID: 115324
		private IllustratedLockItem IllustratedLockItem;

		// Token: 0x0401C27D RID: 115325
		private WishingItem WishingItem;

		// Token: 0x0401C27E RID: 115326
		private int HandleWishingReward;

		// Token: 0x0401C27F RID: 115327
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B06E RID: 45166
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036841 RID: 223297
			public const int GoOnBtn = 0;

			// Token: 0x04036842 RID: 223298
			public const int PreviousBtn = 1;

			// Token: 0x04036843 RID: 223299
			public const int NextBtn = 2;

			// Token: 0x04036844 RID: 223300
			public const int IllustratedUnLockItem = 3;

			// Token: 0x04036845 RID: 223301
			public const int IllustratedLockItem = 4;

			// Token: 0x04036846 RID: 223302
			public const int WishingItem = 5;

			// Token: 0x04036847 RID: 223303
			public const int BackBtn = 6;

			// Token: 0x04036848 RID: 223304
			public const int NextBtnItem = 10;

			// Token: 0x04036849 RID: 223305
			public const int PreviousBtnItem = 11;
		}
	}
}
