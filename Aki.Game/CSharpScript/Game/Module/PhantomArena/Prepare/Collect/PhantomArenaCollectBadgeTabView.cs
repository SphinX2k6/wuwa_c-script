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
	// Token: 0x02004187 RID: 16775
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCollectBadgeTabView : UiTabViewBase
	{
		// Token: 0x0602A7ED RID: 174061 RVA: 0x00BFD2A0 File Offset: 0x00BFB4A0
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

		// Token: 0x0602A7EE RID: 174062 RVA: 0x00BFD3F4 File Offset: 0x00BFB5F4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaCollectBadgeTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaCollectBadgeTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A7EF RID: 174063 RVA: 0x00BFD438 File Offset: 0x00BFB638
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CollectRewardItem, int>(base.GetHorizontalLayout(2), new Func<CollectRewardItem>(this.CreateRewardItem), null, false, true);
			this.BadgeScroll = new GenericScrollViewNew<CollectBadgeGroupItem, CollectBadgeGroupData>(base.GetScrollViewWithScrollbar(4), new Func<CollectBadgeGroupItem>(this.CreateBadgeGroupItem), null, false, null);
			this.SkillLayout = new GenericLayout<CollectBadgeSkillItem, BadgeGroupSkillData>(base.GetVerticalLayout(8), new Func<CollectBadgeSkillItem>(this.CreateSkillItem), null, false, true);
		}

		// Token: 0x0602A7F0 RID: 174064 RVA: 0x00BFD4A8 File Offset: 0x00BFB6A8
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(this.OnBadgeRewardUpdate));
		}

		// Token: 0x0602A7F1 RID: 174065 RVA: 0x00BFD4C6 File Offset: 0x00BFB6C6
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(this.OnBadgeRewardUpdate));
		}

		// Token: 0x0602A7F2 RID: 174066 RVA: 0x00BFD4E4 File Offset: 0x00BFB6E4
		private CollectRewardItem CreateRewardItem()
		{
			return new CollectRewardItem
			{
				RewardType = ECollectRewardType.Badge,
				CallbackClickReward = new Action<int, UUIItem>(this.OnClickReward)
			};
		}

		// Token: 0x0602A7F3 RID: 174067 RVA: 0x00BFD504 File Offset: 0x00BFB704
		private CollectBadgeGroupItem CreateBadgeGroupItem()
		{
			return new CollectBadgeGroupItem
			{
				CallbackClickBadge = new Action<int, CollectBadgeGroupItem>(this.OnClickBadge),
				CallbackCanChange = new Func<int, EToggleState, bool>(this.OnCanChange)
			};
		}

		// Token: 0x0602A7F4 RID: 174068 RVA: 0x00BFD52F File Offset: 0x00BFB72F
		private CollectBadgeSkillItem CreateSkillItem()
		{
			return new CollectBadgeSkillItem();
		}

		// Token: 0x0602A7F5 RID: 174069 RVA: 0x00BFD536 File Offset: 0x00BFB736
		protected override void OnBeforeShow()
		{
			this.RefreshBadge();
			this.RefreshReward();
		}

		// Token: 0x0602A7F6 RID: 174070 RVA: 0x00BFD544 File Offset: 0x00BFB744
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0602A7F7 RID: 174071 RVA: 0x00BFD56C File Offset: 0x00BFB76C
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

		// Token: 0x0602A7F8 RID: 174072 RVA: 0x00BFD5F4 File Offset: 0x00BFB7F4
		private void RefreshBadge()
		{
			List<CollectBadgeGroupData> collectBadgeGroupDataList = PhantomArenaModel.Instance.GetCollectBadgeGroupDataList(this.ActivityId);
			this.BadgeScroll.RefreshByData(collectBadgeGroupDataList, new Action(this.OnRefreshBadgeFinish), false);
		}

		// Token: 0x0602A7F9 RID: 174073 RVA: 0x00BFD62C File Offset: 0x00BFB82C
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

		// Token: 0x0602A7FA RID: 174074 RVA: 0x00BFD7A4 File Offset: 0x00BFB9A4
		private void RefreshReward()
		{
			List<int> badgeRewardConfigList = PhantomArenaModel.Instance.GetBadgeRewardConfigList(this.ActivityId);
			this.RewardLayout.RefreshByData(badgeRewardConfigList, null, false);
			int badgeUnlockCount = PhantomArenaModel.Instance.GetBadgeUnlockCount(this.ActivityId);
			base.GetArtText(0).SetText(badgeUnlockCount.ToString());
			float badgeRewardProgress = PhantomArenaModel.Instance.GetBadgeRewardProgress(this.ActivityId);
			base.GetSprite(1).SetFillAmount(badgeRewardProgress);
		}

		// Token: 0x0602A7FB RID: 174075 RVA: 0x00BFD814 File Offset: 0x00BFBA14
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

		// Token: 0x0602A7FC RID: 174076 RVA: 0x00BFD8A8 File Offset: 0x00BFBAA8
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

		// Token: 0x0602A7FD RID: 174077 RVA: 0x00BFD915 File Offset: 0x00BFBB15
		private void OnBadgeRewardUpdate()
		{
			this.RefreshReward();
		}

		// Token: 0x0602A7FE RID: 174078 RVA: 0x00BFD920 File Offset: 0x00BFBB20
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

		// Token: 0x0602A7FF RID: 174079 RVA: 0x00BFD96E File Offset: 0x00BFBB6E
		private bool OnCanChange(int badgeId, EToggleState state)
		{
			return true;
		}

		// Token: 0x04017122 RID: 94498
		protected int ActivityId;

		// Token: 0x04017123 RID: 94499
		private int CurrentBadge;

		// Token: 0x04017124 RID: 94500
		private CollectBadgeGroupItem CurrentGroup;

		// Token: 0x04017125 RID: 94501
		private GenericLayout<CollectBadgeSkillItem, BadgeGroupSkillData> SkillLayout;

		// Token: 0x04017126 RID: 94502
		private GenericLayout<CollectRewardItem, int> RewardLayout;

		// Token: 0x04017127 RID: 94503
		private CollectRewardPopup RewardPopup;

		// Token: 0x04017128 RID: 94504
		private GenericScrollViewNew<CollectBadgeGroupItem, CollectBadgeGroupData> BadgeScroll;

		// Token: 0x02009D78 RID: 40312
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F88 RID: 200584
			public const int TextArtNum = 0;

			// Token: 0x04030F89 RID: 200585
			public const int SpriteBar = 1;

			// Token: 0x04030F8A RID: 200586
			public const int LayoutReward = 2;

			// Token: 0x04030F8B RID: 200587
			public const int PanelReward = 3;

			// Token: 0x04030F8C RID: 200588
			public const int ScrollBadge = 4;

			// Token: 0x04030F8D RID: 200589
			public const int ItemBadgeType = 5;

			// Token: 0x04030F8E RID: 200590
			public const int TextName = 6;

			// Token: 0x04030F8F RID: 200591
			public const int IconBadge = 7;

			// Token: 0x04030F90 RID: 200592
			public const int LayoutSkill = 8;

			// Token: 0x04030F91 RID: 200593
			public const int PanelDesc = 9;

			// Token: 0x04030F92 RID: 200594
			public const int TextDesc = 10;

			// Token: 0x04030F93 RID: 200595
			public const int PanelUnlock = 11;

			// Token: 0x04030F94 RID: 200596
			public const int PanelLock = 12;

			// Token: 0x04030F95 RID: 200597
			public const int TextGroupTitle = 13;
		}
	}
}
