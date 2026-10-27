using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02005F80 RID: 24448
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewUniversal : ActivitySubViewBase
	{
		// Token: 0x17008FDD RID: 36829
		// (get) Token: 0x0603E0B2 RID: 254130 RVA: 0x00EFAD8E File Offset: 0x00EF8F8E
		protected new ActivityUniversalData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityUniversalData;
			}
		}

		// Token: 0x0603E0B3 RID: 254131 RVA: 0x00EFAD9C File Offset: 0x00EF8F9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E0B4 RID: 254132 RVA: 0x00EFAE47 File Offset: 0x00EF9047
		protected override void OnSetData()
		{
		}

		// Token: 0x0603E0B5 RID: 254133 RVA: 0x00EFAE4C File Offset: 0x00EF904C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewUniversal.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewUniversal.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E0B6 RID: 254134 RVA: 0x00EFAE90 File Offset: 0x00EF9090
		protected override void OnStart()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			UniversalActivity? extraConfig = this.ActivityBaseData.GetExtraConfig();
			if (localConfig == null || extraConfig == null)
			{
				return;
			}
			string descTheme = localConfig.Value.DescTheme;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			string desc = localConfig.Value.Desc;
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("CollectActivity_Button_ahead", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
			this.OnRefreshView();
		}

		// Token: 0x0603E0B7 RID: 254135 RVA: 0x00EFAFE0 File Offset: 0x00EF91E0
		protected override void OnRefreshView()
		{
			this.RefreshCondition();
			this.RefreshTimerText();
		}

		// Token: 0x0603E0B8 RID: 254136 RVA: 0x00EFAFF0 File Offset: 0x00EF91F0
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x0603E0B9 RID: 254137 RVA: 0x00EFB02D File Offset: 0x00EF922D
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				ActivityUniversalController.Instance.ActivityFunctionExecute(this.ActivityBaseData.Id);
			});
		}

		// Token: 0x0603E0BA RID: 254138 RVA: 0x00EFB04C File Offset: 0x00EF924C
		private void RefreshCondition()
		{
			UniversalActivity? extraConfig = this.ActivityBaseData.GetExtraConfig();
			if (extraConfig == null)
			{
				return;
			}
			bool flag = this.ActivityBaseData.IsUnLock();
			bool flag2 = extraConfig.Value.FunctionType == 0;
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			if (flag)
			{
				ActivityButtonItem functionButton = this.FunctionalComponent.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetUiActive(!flag2 || !preGuideQuestFinishState);
				}
			}
			else
			{
				ActivityButtonItem functionButton2 = this.FunctionalComponent.FunctionButton;
				if (functionButton2 != null)
				{
					functionButton2.SetUiActive(false);
				}
			}
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
		}

		// Token: 0x04020671 RID: 132721
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04020672 RID: 132722
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04020673 RID: 132723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04020674 RID: 132724
		private ActivityFunctionalTypeA FunctionalComponent;
	}
}
