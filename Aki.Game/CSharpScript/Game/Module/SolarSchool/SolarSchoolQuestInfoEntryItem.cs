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
	// Token: 0x020059E5 RID: 23013
	public class SolarSchoolQuestInfoEntryItem : GridProxyAbstract<int>
	{
		// Token: 0x06038AEA RID: 232170 RVA: 0x00FDD436 File Offset: 0x00FDB636
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038AEB RID: 232171 RVA: 0x00FDD449 File Offset: 0x00FDB649
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotSolarSchoolQuestItem, base.GetItem(3), this.QuestId);
		}

		// Token: 0x06038AEC RID: 232172 RVA: 0x00FDD468 File Offset: 0x00FDB668
		public UniTask PlayPendingSuccessAsync()
		{
			SolarSchoolQuestInfoEntryItem.<PlayPendingSuccessAsync>d__5 <PlayPendingSuccessAsync>d__;
			<PlayPendingSuccessAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPendingSuccessAsync>d__.<>4__this = this;
			<PlayPendingSuccessAsync>d__.<>1__state = -1;
			<PlayPendingSuccessAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoEntryItem.<PlayPendingSuccessAsync>d__5>(ref <PlayPendingSuccessAsync>d__);
			return <PlayPendingSuccessAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AED RID: 232173 RVA: 0x00FDD4AC File Offset: 0x00FDB6AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038AEE RID: 232174 RVA: 0x00FDD5B8 File Offset: 0x00FDB7B8
		public override void Refresh(int questId, bool isSelected, int gridIndex)
		{
			this.QuestId = questId;
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(questId);
			SolarSchoolSingleQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(questId);
			if (quest == null || questData == null)
			{
				return;
			}
			bool uiactive = questData.CanClaimProgressReward();
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotSolarSchoolQuestItem, base.GetItem(3), null, this.QuestId);
			base.GetItem(4).SetUIActive(uiactive);
			int rewardProgress = questData.GetRewardProgress();
			int targetProgress = questData.GetTargetProgress();
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(quest.Value.MainDesc, null);
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(questData.IsItemRewardUnlocked() ? "SolarSchool_QuestPanel_Status2" : "SolarSchool_QuestPanel_Status1", null);
			base.GetItem(1).SetUIActive(questData.ProgressRewarded);
			base.GetItem(1).SetAlpha(questData.PendingSuccess ? 0f : 1f);
			if (questData.QuestType == ESolarSchoolQuestShowType.Important)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(localTextNew, true);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(localTextNew + StringUtils.Format(localTextNew2, new string[]
				{
					rewardProgress.ToString(),
					targetProgress.ToString()
				}), true);
				return;
			}
		}

		// Token: 0x06038AEF RID: 232175 RVA: 0x00FDD6F4 File Offset: 0x00FDB8F4
		[NullableContext(2)]
		public UUIItem GetGuideEntryItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x06038AF0 RID: 232176 RVA: 0x00FDD708 File Offset: 0x00FDB908
		private void OnButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolQuestDetailView, new SolarSchoolQuestDetailViewParam
			{
				QuestId = this.QuestId
			}, null);
		}

		// Token: 0x0401DD94 RID: 122260
		private int QuestId;

		// Token: 0x0401DD95 RID: 122261
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B596 RID: 46486
		private class EComponents
		{
			// Token: 0x0403826E RID: 229998
			public const int PnlRoot = 0;

			// Token: 0x0403826F RID: 229999
			public const int PnlCheck = 1;

			// Token: 0x04038270 RID: 230000
			public const int TxtContent = 2;

			// Token: 0x04038271 RID: 230001
			public const int ItemRedDot = 3;

			// Token: 0x04038272 RID: 230002
			public const int ItemGift = 4;
		}
	}
}
