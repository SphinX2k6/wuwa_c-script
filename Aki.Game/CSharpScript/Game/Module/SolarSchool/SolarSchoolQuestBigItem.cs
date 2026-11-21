using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E3 RID: 23011
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestBigItem : SolarSchoolQuestNodeItemBase
	{
		// Token: 0x06038AD2 RID: 232146 RVA: 0x00FDCB1C File Offset: 0x00FDAD1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnRootClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038AD3 RID: 232147 RVA: 0x00FDCE00 File Offset: 0x00FDB000
		protected override void OnRefreshNode(SolarSchoolQuest quest, SolarSchoolSingleQuestData questData)
		{
			bool flag = this.ShouldShowUnlocked(questData);
			bool progressRewarded = questData.ProgressRewarded;
			if (questData.IsExpired)
			{
				base.SnapNodeSequence("Gray");
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			this.RefreshIcon(quest, progressRewarded, questData.IsExpired);
			this.RefreshText(quest);
			UUIText text = base.GetText(14);
			string dateStr = base.GetDateStr(quest.EndDayIndex, questData.IsExpired);
			if (text != null)
			{
				text.SetText(dateStr, true);
			}
			this.RefreshProgress(questData);
			this.RefreshGift(questData);
		}

		// Token: 0x06038AD4 RID: 232148 RVA: 0x00FDCEA4 File Offset: 0x00FDB0A4
		[NullableContext(2)]
		protected override UUIItem GetQuestRedDotItem()
		{
			return base.GetItem(15);
		}

		// Token: 0x06038AD5 RID: 232149 RVA: 0x00FDCEB0 File Offset: 0x00FDB0B0
		public override UniTask PlayUnlockAsync()
		{
			SolarSchoolQuestBigItem.<PlayUnlockAsync>d__4 <PlayUnlockAsync>d__;
			<PlayUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAsync>d__.<>4__this = this;
			<PlayUnlockAsync>d__.<>1__state = -1;
			<PlayUnlockAsync>d__.<>t__builder.Start<SolarSchoolQuestBigItem.<PlayUnlockAsync>d__4>(ref <PlayUnlockAsync>d__);
			return <PlayUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AD6 RID: 232150 RVA: 0x00FDCEF4 File Offset: 0x00FDB0F4
		private void RefreshIcon(SolarSchoolQuest quest, bool isFinished, bool isExpired)
		{
			bool flag = quest.ShowType == 3;
			ESolarSchoolInfluence influence = (ESolarSchoolInfluence)quest.Influence;
			bool flag2 = influence > ESolarSchoolInfluence.None;
			UUITexture texture = base.GetTexture(3);
			UUITexture texture2 = base.GetTexture(4);
			SolarSchoolInfluence? solarSchoolInfluence = flag2 ? SolarSchoolConfig.Instance.GetInfluence(influence) : null;
			flag2 = (solarSchoolInfluence != null);
			string path = ((solarSchoolInfluence != null) ? solarSchoolInfluence.GetValueOrDefault().Icon : null) ?? null;
			if (flag)
			{
				if (texture2 != null)
				{
					texture2.SetUIActive(false);
				}
				UUITexture texture3 = base.GetTexture(5);
				if (texture3 != null)
				{
					texture3.SetUIActive(false);
				}
				base.TrySetTextureByPath(path, texture, null, null);
				return;
			}
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			base.TrySetTextureByPath(path, base.GetTexture(5), null, null);
			string path2 = isExpired ? quest.RoleExpireIcon : (isFinished ? quest.RoleFinishIcon : quest.RoleIcon);
			base.TrySetTextureByPath(path2, texture2, null, null);
			if (flag2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), solarSchoolInfluence.Value.Desc, Array.Empty<object>());
			}
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag2);
		}

		// Token: 0x06038AD7 RID: 232151 RVA: 0x00FDD039 File Offset: 0x00FDB239
		private void RefreshText(SolarSchoolQuest quest)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), quest.Name, Array.Empty<object>());
		}

		// Token: 0x06038AD8 RID: 232152 RVA: 0x00FDD058 File Offset: 0x00FDB258
		private bool ShouldShowUnlocked(SolarSchoolSingleQuestData questData)
		{
			return questData.IsExpired || (questData.IsUnlocked && !base.PendingUnlock);
		}

		// Token: 0x06038AD9 RID: 232153 RVA: 0x00FDD078 File Offset: 0x00FDB278
		private void RefreshProgress(SolarSchoolSingleQuestData questData)
		{
			bool uiactive = this.ShouldShowUnlocked(questData);
			bool isExpired = questData.IsExpired;
			bool progressRewarded = questData.ProgressRewarded;
			bool inShowTime = questData.InShowTime;
			int rewardProgress = questData.GetRewardProgress();
			int targetProgress = questData.GetTargetProgress();
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(progressRewarded);
			}
			UUITexture texture = base.GetTexture(11);
			if (texture != null)
			{
				texture.SetUIActive(!progressRewarded && isExpired);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "SolarSchool_QuestTree_Check", new int[]
			{
				rewardProgress,
				targetProgress
			});
			UUIText text = base.GetText(9);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(inShowTime);
		}

		// Token: 0x06038ADA RID: 232154 RVA: 0x00FDD130 File Offset: 0x00FDB330
		private void RefreshGift(SolarSchoolSingleQuestData questData)
		{
			bool uiactive = questData.CanClaimProgressReward();
			UUIItem item = base.GetItem(18);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06038ADB RID: 232155 RVA: 0x00FDD158 File Offset: 0x00FDB358
		private void OnBtnRootClick()
		{
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(base.QuestId);
			if (questData == null)
			{
				return;
			}
			bool isUnlocked = questData.IsUnlocked;
			bool inShowTime = questData.InShowTime;
			bool isExpired = questData.IsExpired;
			if (!inShowTime && !isExpired)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_QuestTree_NotStart", Array.Empty<object>());
				return;
			}
			if (isExpired)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_QuestTree_Completed", Array.Empty<object>());
				return;
			}
			if (isUnlocked)
			{
				base.NotifyClick();
				return;
			}
			Aki.Config.ActivityConditionGroup? conditionGroupConfig = ActivityConditionConfig.Instance.GetConditionGroupConfig(questData.UnlockConditionGroupId);
			if (conditionGroupConfig == null)
			{
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupConfig.Value.HintText, Array.Empty<object>());
		}

		// Token: 0x0200B592 RID: 46482
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038250 RID: 229968
			public const int BtnRoot = 0;

			// Token: 0x04038251 RID: 229969
			public const int PnlUnLock = 1;

			// Token: 0x04038252 RID: 229970
			public const int TexUnlock = 2;

			// Token: 0x04038253 RID: 229971
			public const int TexIconInfluence = 3;

			// Token: 0x04038254 RID: 229972
			public const int TexRole = 4;

			// Token: 0x04038255 RID: 229973
			public const int TexIconInfluenceSmall = 5;

			// Token: 0x04038256 RID: 229974
			public const int PnlLock = 6;

			// Token: 0x04038257 RID: 229975
			public const int TxtTitle = 7;

			// Token: 0x04038258 RID: 229976
			public const int SprProgress = 8;

			// Token: 0x04038259 RID: 229977
			public const int TxtProgress = 9;

			// Token: 0x0403825A RID: 229978
			public const int SprProgressDone = 10;

			// Token: 0x0403825B RID: 229979
			public const int TexProgressUnfinished = 11;

			// Token: 0x0403825C RID: 229980
			public const int SprTagBg = 12;

			// Token: 0x0403825D RID: 229981
			public const int TxtTag = 13;

			// Token: 0x0403825E RID: 229982
			public const int TxtDate = 14;

			// Token: 0x0403825F RID: 229983
			public const int ItemRedPoint = 15;

			// Token: 0x04038260 RID: 229984
			public const int PnlTag = 16;

			// Token: 0x04038261 RID: 229985
			public const int PnlProgress = 17;

			// Token: 0x04038262 RID: 229986
			public const int PnlSolarSchoolGift = 18;
		}
	}
}
