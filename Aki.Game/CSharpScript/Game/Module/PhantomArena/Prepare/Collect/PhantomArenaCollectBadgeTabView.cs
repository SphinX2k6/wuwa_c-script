using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B7 RID: 20919
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectBadgeTabView : UiTabViewBase
	{
		// Token: 0x060358F2 RID: 219378 RVA: 0x00CAFC64 File Offset: 0x00CADE64
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText))
			};
		}

		// Token: 0x060358F3 RID: 219379 RVA: 0x00CAFDB8 File Offset: 0x00CADFB8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectBadgeTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectBadgeTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358F4 RID: 219380 RVA: 0x00CAFDFC File Offset: 0x00CADFFC
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CollectRewardItem, int>(base.GetHorizontalLayout(2), new Func<CollectRewardItem>(this.CreateRewardItem), null, false, true);
			this.BadgeScroll = new GenericScrollViewNew<CollectBadgeGroupItem, CollectBadgeGroupData>(base.GetScrollViewWithScrollbar(4), new Func<CollectBadgeGroupItem>(this.CreateBadgeGroupItem), null, false, null);
			this.SkillLayout = new GenericLayout<CollectBadgeSkillItem, BadgeGroupSkillData>(base.GetVerticalLayout(8), new Func<CollectBadgeSkillItem>(this.CreateSkillItem), null, false, true);
		}

		// Token: 0x060358F5 RID: 219381 RVA: 0x00CAFE6C File Offset: 0x00CAE06C
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(this.OnBadgeRewardUpdate));
		}

		// Token: 0x060358F6 RID: 219382 RVA: 0x00CAFE8A File Offset: 0x00CAE08A
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(this.OnBadgeRewardUpdate));
		}

		// Token: 0x060358F7 RID: 219383 RVA: 0x00CAFEA8 File Offset: 0x00CAE0A8
		private CollectRewardItem CreateRewardItem()
		{
			return new CollectRewardItem
			{
				RewardType = ECollectRewardType.Badge,
				CallbackClickReward = new Action<int, UUIItem>(this.OnClickReward)
			};
		}

		// Token: 0x060358F8 RID: 219384 RVA: 0x00CAFEC8 File Offset: 0x00CAE0C8
		private CollectBadgeGroupItem CreateBadgeGroupItem()
		{
			return new CollectBadgeGroupItem
			{
				CallbackClickBadge = new Action<int, CollectBadgeGroupItem>(this.OnClickBadge),
				CallbackCanChange = new Func<int, EToggleState, bool>(this.OnCanChange)
			};
		}

		// Token: 0x060358F9 RID: 219385 RVA: 0x00CAFEF3 File Offset: 0x00CAE0F3
		private CollectBadgeSkillItem CreateSkillItem()
		{
			return new CollectBadgeSkillItem();
		}

		// Token: 0x060358FA RID: 219386 RVA: 0x00CAFEFA File Offset: 0x00CAE0FA
		protected override void OnBeforeShow()
		{
			this.RefreshBadge();
			this.RefreshReward();
		}

		// Token: 0x060358FB RID: 219387 RVA: 0x00CAFF08 File Offset: 0x00CAE108
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x060358FC RID: 219388 RVA: 0x00CAFF30 File Offset: 0x00CAE130
		private void OnRefreshBadgeFinish()
		{
			int num = 0;
			int num2 = 0;
			List<CollectBadgeGroupData> collectBadgeGroupDataList = PhantomArenaModel.Instance.GetCollectBadgeGroupDataList(this.ActivityId);
			int currentBadge = (collectBadgeGroupDataList != null && collectBadgeGroupDataList.Count > num && collectBadgeGroupDataList[num].BadgeIdList.Count > num2) ? collectBadgeGroupDataList[num].BadgeIdList[num2] : 0;
			CollectBadgeGroupItem scrollItemByIndex = this.BadgeScroll.GetScrollItemByIndex(num);
			this.CurrentBadge = currentBadge;
			this.CurrentGroup = scrollItemByIndex;
			if (scrollItemByIndex != null)
			{
				scrollItemByIndex.SetSelectByIndex(num2);
			}
			this.RefreshInfo();
		}

		// Token: 0x060358FD RID: 219389 RVA: 0x00CAFFB8 File Offset: 0x00CAE1B8
		private void RefreshBadge()
		{
			List<CollectBadgeGroupData> collectBadgeGroupDataList = PhantomArenaModel.Instance.GetCollectBadgeGroupDataList(this.ActivityId);
			this.BadgeScroll.RefreshByData(collectBadgeGroupDataList, new Action(this.OnRefreshBadgeFinish), false);
		}

		// Token: 0x060358FE RID: 219390 RVA: 0x00CAFFF0 File Offset: 0x00CAE1F0
		private void RefreshInfo()
		{
			if (this.CurrentBadge <= 0)
			{
				return;
			}
			int phantomBattleBadgeGroupIdById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeGroupIdById(this.CurrentBadge);
			List<BadgeGroupSkillData> badgeSkillByGroupId = PhantomArenaModel.Instance.GetBadgeSkillByGroupId(phantomBattleBadgeGroupIdById);
			this.SkillLayout.RefreshByData(badgeSkillByGroupId, null, false);
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(this.CurrentBadge);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), phantomBattleBadgeById.Name, Array.Empty<object>());
			bool flag = PhantomArenaModel.Instance.IsBadgeUnlock(this.CurrentBadge);
			base.GetItem(12).SetUIActive(!flag);
			base.GetItem(11).SetUIActive(flag);
			string textStringId = phantomBattleBadgeById.Desc;
			if (!flag)
			{
				textStringId = ConditionConfig.Instance.GetConditionGroupConfig(phantomBattleBadgeById.ConditionGroup).Value.HintText;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), textStringId, Array.Empty<object>());
			BadgeGroupCollectCountData badgeCollectCountByGroupId = PhantomArenaModel.Instance.GetBadgeCollectCountByGroupId(phantomBattleBadgeGroupIdById);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "PrefabTextItem_3661046131_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				badgeCollectCountByGroupId.Now,
				badgeCollectCountByGroupId.Need
			}));
			UUISprite sprite = base.GetSprite(7);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = !flag;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.SetSpriteByPath(phantomBattleBadgeById.ShowIcon, sprite, false, null, null);
		}

		// Token: 0x060358FF RID: 219391 RVA: 0x00CB0168 File Offset: 0x00CAE368
		private void RefreshReward()
		{
			List<int> badgeRewardConfigList = PhantomArenaModel.Instance.GetBadgeRewardConfigList(this.ActivityId);
			this.RewardLayout.RefreshByData(badgeRewardConfigList, null, false);
			int badgeUnlockCount = PhantomArenaModel.Instance.GetBadgeUnlockCount(this.ActivityId);
			base.GetArtText(0).SetText(badgeUnlockCount.ToString());
			float badgeRewardProgress = PhantomArenaModel.Instance.GetBadgeRewardProgress(this.ActivityId);
			base.GetSprite(1).SetFillAmount(badgeRewardProgress);
		}

		// Token: 0x06035900 RID: 219392 RVA: 0x00CB01D8 File Offset: 0x00CAE3D8
		private void RequestReward()
		{
			List<int> badgeRewardConfigList = PhantomArenaModel.Instance.GetBadgeRewardConfigList(this.ActivityId);
			List<int> list = new List<int>();
			foreach (int num in badgeRewardConfigList)
			{
				if (PhantomArenaModel.Instance.GetBadgeRewardStateById(num) == ECollectRewardState.Finish)
				{
					list.Add(num);
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			PhantomArenaController.Instance.BadgeRewardRequest(list.ToArray(), this.ActivityId);
		}

		// Token: 0x06035901 RID: 219393 RVA: 0x00CB026C File Offset: 0x00CAE46C
		private void OnClickReward(int rewardId, UUIItem root)
		{
			if (PhantomArenaModel.Instance.GetBadgeRewardStateById(rewardId) == ECollectRewardState.Finish)
			{
				this.RequestReward();
				return;
			}
			List<RewardTuple> badgeRewardPopupTupleData = PhantomArenaModel.Instance.GetBadgeRewardPopupTupleData(rewardId);
			RewardPopupData data = new RewardPopupData
			{
				RewardLists = badgeRewardPopupTupleData,
				MountItem = root,
				PosBias = new FVector?(new FVector(0f, 30f, 0f))
			};
			this.RewardPopup.Refresh(data);
		}

		// Token: 0x06035902 RID: 219394 RVA: 0x00CB02D9 File Offset: 0x00CAE4D9
		private void OnBadgeRewardUpdate()
		{
			this.RefreshReward();
		}

		// Token: 0x06035903 RID: 219395 RVA: 0x00CB02E4 File Offset: 0x00CAE4E4
		private void OnClickBadge(int badgeId, CollectBadgeGroupItem groupItem)
		{
			if (this.CurrentGroup != null && this.CurrentBadge != badgeId)
			{
				this.CurrentGroup.SetDeselect();
			}
			this.CurrentBadge = badgeId;
			this.CurrentGroup = groupItem;
			this.CurrentGroup.SetSelect(this.CurrentBadge);
			this.RefreshInfo();
		}

		// Token: 0x06035904 RID: 219396 RVA: 0x00CB0332 File Offset: 0x00CAE532
		private bool OnCanChange(int badgeId, EToggleState state)
		{
			return true;
		}

		// Token: 0x0401C6ED RID: 116461
		protected int ActivityId;

		// Token: 0x0401C6EE RID: 116462
		private int CurrentBadge;

		// Token: 0x0401C6EF RID: 116463
		private CollectBadgeGroupItem CurrentGroup;

		// Token: 0x0401C6F0 RID: 116464
		private GenericLayout<CollectBadgeSkillItem, BadgeGroupSkillData> SkillLayout;

		// Token: 0x0401C6F1 RID: 116465
		private GenericLayout<CollectRewardItem, int> RewardLayout;

		// Token: 0x0401C6F2 RID: 116466
		private CollectRewardPopup RewardPopup;

		// Token: 0x0401C6F3 RID: 116467
		private GenericScrollViewNew<CollectBadgeGroupItem, CollectBadgeGroupData> BadgeScroll;

		// Token: 0x0200B340 RID: 45888
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036535 RID: 222517
			public const int TextArtNum = 0;

			// Token: 0x04036536 RID: 222518
			public const int SpriteBar = 1;

			// Token: 0x04036537 RID: 222519
			public const int LayoutReward = 2;

			// Token: 0x04036538 RID: 222520
			public const int PanelReward = 3;

			// Token: 0x04036539 RID: 222521
			public const int ScrollBadge = 4;

			// Token: 0x0403653A RID: 222522
			public const int ItemBadgeType = 5;

			// Token: 0x0403653B RID: 222523
			public const int TextName = 6;

			// Token: 0x0403653C RID: 222524
			public const int IconBadge = 7;

			// Token: 0x0403653D RID: 222525
			public const int LayoutSkill = 8;

			// Token: 0x0403653E RID: 222526
			public const int PanelDesc = 9;

			// Token: 0x0403653F RID: 222527
			public const int TextDesc = 10;

			// Token: 0x04036540 RID: 222528
			public const int PanelUnlock = 11;

			// Token: 0x04036541 RID: 222529
			public const int PanelLock = 12;

			// Token: 0x04036542 RID: 222530
			public const int TextGroupTitle = 13;
		}
	}
}
