using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A32 RID: 23090
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolQuestDetailView : UiViewBase
	{
		// Token: 0x06038E1A RID: 232986 RVA: 0x00FED6ED File Offset: 0x00FEB8ED
		[NullableContext(1)]
		public SolarSchoolQuestDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038E1B RID: 232987 RVA: 0x00FED6F8 File Offset: 0x00FEB8F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038E1C RID: 232988 RVA: 0x00FED918 File Offset: 0x00FEBB18
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolQuestDetailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolQuestDetailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E1D RID: 232989 RVA: 0x00FED95B File Offset: 0x00FEBB5B
		protected override void OnStart()
		{
			this.QuestScroll = new GenericScrollViewNew<SolarSchoolQuestItem, SolarSchoolQuestItemData>(base.GetScrollViewWithScrollbar(3), new Func<SolarSchoolQuestItem>(this.CreateQuestItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
			this.MarkQuestUnlockRedDot();
		}

		// Token: 0x06038E1E RID: 232990 RVA: 0x00FED994 File Offset: 0x00FEBB94
		protected override void OnBeforeShow()
		{
			this.RefreshAll();
		}

		// Token: 0x06038E1F RID: 232991 RVA: 0x00FED99C File Offset: 0x00FEBB9C
		[NullableContext(1)]
		private SolarSchoolQuestItem CreateQuestItem()
		{
			return new SolarSchoolQuestItem
			{
				JumpCallback = new Action<int>(this.OnRewardJump),
				HelpCallback = new Action<int>(this.OnRewardHelp)
			};
		}

		// Token: 0x06038E20 RID: 232992 RVA: 0x00FED9C8 File Offset: 0x00FEBBC8
		private void RefreshAll()
		{
			if (this.QuestId == 0)
			{
				return;
			}
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			SolarSchoolRoleSpine? roleSpine = SolarSchoolConfig.Instance.GetRoleSpine(quest.Value.RoleSpineId);
			if (quest == null || roleSpine == null)
			{
				return;
			}
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(roleSpine.Value.RoleId);
			if (role == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), role.Value.Name, Array.Empty<object>());
			this.RefreshQuestScroll(quest.Value);
			this.RefreshBottom(quest.Value);
		}

		// Token: 0x06038E21 RID: 232993 RVA: 0x00FEDA84 File Offset: 0x00FEBC84
		private void MarkQuestUnlockRedDot()
		{
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(this.QuestId);
			if (questData == null)
			{
				return;
			}
			questData.MarkQuestUnlockRedDot();
		}

		// Token: 0x06038E22 RID: 232994 RVA: 0x00FEDAB4 File Offset: 0x00FEBCB4
		private void RefreshQuestScroll(SolarSchoolQuest quest)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolSingleQuestData questData = instance.QuestData.GetQuestData(this.QuestId);
			bool allowJump = instance.CanPlayerFreeChoose() && instance.InstanceType == ESolarSchoolInstanceType.Normal;
			List<SolarSchoolQuestItemData> list = new List<SolarSchoolQuestItemData>();
			foreach (int num in quest.GetQuestRewardListArray())
			{
				if (SolarSchoolConfig.Instance.GetQuestReward(num) != null)
				{
					list.Add(new SolarSchoolQuestItemData
					{
						QuestId = this.QuestId,
						RewardId = num,
						AllowJump = allowJump
					});
				}
			}
			List<SolarSchoolQuestItemData> data = NoLinq.PartitionToList<SolarSchoolQuestItemData>(list, delegate(SolarSchoolQuestItemData item)
			{
				SolarSchoolSingleQuestData questData = questData;
				return questData != null && questData.IsRewardFinished(item.RewardId);
			});
			GenericScrollViewNew<SolarSchoolQuestItem, SolarSchoolQuestItemData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(data, null, true);
		}

		// Token: 0x06038E23 RID: 232995 RVA: 0x00FEDB88 File Offset: 0x00FEBD88
		private void RefreshBottom(SolarSchoolQuest quest)
		{
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(this.QuestId);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(quest.RewardItem > 0);
			}
			if (quest.RewardItem <= 0 || questData == null)
			{
				return;
			}
			int showItemId = quest.ShowItemId;
			SolarSchoolQuestRewardItemGrid rewardItemGrid = this.RewardItemGrid;
			if (rewardItemGrid != null)
			{
				rewardItemGrid.Refresh(showItemId, 0);
			}
			SolarSchoolItem? solarSchoolItem;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), (SolarSchoolConfig.Instance.GetItem(showItemId) != null) ? solarSchoolItem.GetValueOrDefault().Name : null, Array.Empty<object>());
			int rewardProgress = questData.GetRewardProgress();
			int targetProgress = questData.GetTargetProgress();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "SolarSchool_QuestTree_Main", new <>z__ReadOnlySingleElementList<object>(targetProgress));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "SolarSchool_QuestTree_Check", new int[]
			{
				rewardProgress,
				targetProgress
			});
			this.ApplyBarFill(rewardProgress, targetProgress);
			bool progressRewarded = questData.ProgressRewarded;
			bool flag = questData.CanClaimProgressReward();
			UUIText text = base.GetText(9);
			if (text != null)
			{
				text.SetUIActive(!flag && !progressRewarded);
			}
			SolarSchoolBtnItem getBtn = this.GetBtn;
			if (getBtn != null)
			{
				getBtn.SetUiActive(flag);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(progressRewarded);
		}

		// Token: 0x06038E24 RID: 232996 RVA: 0x00FEDCE4 File Offset: 0x00FEBEE4
		private void ApplyBarFill(int current, int target)
		{
			double value = (target <= 0) ? 0.0 : ((double)current / (double)target);
			UUISprite sprite = base.GetSprite(13);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount((float)Math.Clamp(value, 0.0, 1.0));
		}

		// Token: 0x06038E25 RID: 232997 RVA: 0x00FEDD31 File Offset: 0x00FEBF31
		private void OnBtnGetClick()
		{
			if (!SolarSchoolGamePlayModel.Instance.QuestData.TryClaimProgressReward(this.QuestId))
			{
				return;
			}
			this.RefreshAll();
		}

		// Token: 0x06038E26 RID: 232998 RVA: 0x00FEDD54 File Offset: 0x00FEBF54
		private void OnRewardJump(int rewardId)
		{
			List<SolarSchoolJumpAccessInfo> list = SolarSchoolUtils.CollectQuestRewardJumps(rewardId);
			if (list.Count == 0)
			{
				return;
			}
			SolarSchoolUtils.ShowJumpAccessPopup(list, new Action<SolarSchoolJumpAccessInfo>(this.OnJumpAccessSelected), null);
		}

		// Token: 0x06038E27 RID: 232999 RVA: 0x00FEDD84 File Offset: 0x00FEBF84
		private void OnJumpAccessSelected(SolarSchoolJumpAccessInfo info)
		{
			this.CloseSelf();
			SolarSchoolModel.Instance.CloseSettingView();
			SolarSchoolUtils.RunQuestRewardJump(info);
		}

		// Token: 0x06038E28 RID: 233000 RVA: 0x00FEDD9C File Offset: 0x00FEBF9C
		private void OnRewardHelp(int rewardId)
		{
			SolarSchoolQuestReward? solarSchoolQuestReward;
			string text = (SolarSchoolConfig.Instance.GetQuestReward(rewardId) != null) ? solarSchoolQuestReward.GetValueOrDefault().TxtHelpInfo : null;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId(text, Array.Empty<object>());
		}

		// Token: 0x0401DEE4 RID: 122596
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DEE5 RID: 122597
		private SolarSchoolCharacterSpineItem SpineItem;

		// Token: 0x0401DEE6 RID: 122598
		private SolarSchoolQuestRewardItemGrid RewardItemGrid;

		// Token: 0x0401DEE7 RID: 122599
		private SolarSchoolBtnItem GetBtn;

		// Token: 0x0401DEE8 RID: 122600
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolQuestItem, SolarSchoolQuestItemData> QuestScroll;

		// Token: 0x0401DEE9 RID: 122601
		private int QuestId;

		// Token: 0x0200B60F RID: 46607
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040384C4 RID: 230596
			public const int Caption = 0;

			// Token: 0x040384C5 RID: 230597
			public const int SpineItem = 1;

			// Token: 0x040384C6 RID: 230598
			public const int TxtName = 2;

			// Token: 0x040384C7 RID: 230599
			public const int QuestScroll = 3;

			// Token: 0x040384C8 RID: 230600
			public const int QuestItem = 4;

			// Token: 0x040384C9 RID: 230601
			public const int PanelItemReward = 5;

			// Token: 0x040384CA RID: 230602
			public const int ItemRewardGrid = 6;

			// Token: 0x040384CB RID: 230603
			public const int TxtItemName = 7;

			// Token: 0x040384CC RID: 230604
			public const int TxtProgressName = 8;

			// Token: 0x040384CD RID: 230605
			public const int TxtProgressDoing = 9;

			// Token: 0x040384CE RID: 230606
			public const int PanelProgressDone = 10;

			// Token: 0x040384CF RID: 230607
			public const int TexProgressRewardIcon = 11;

			// Token: 0x040384D0 RID: 230608
			public const int TxtProgressCount = 12;

			// Token: 0x040384D1 RID: 230609
			public const int BarProgress = 13;

			// Token: 0x040384D2 RID: 230610
			public const int BtnItemRewardGet = 14;
		}
	}
}
