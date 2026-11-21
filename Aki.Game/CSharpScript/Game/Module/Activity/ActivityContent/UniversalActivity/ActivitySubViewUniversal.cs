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
	// Token: 0x02004F67 RID: 20327
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewUniversal : ActivitySubViewBase
	{
		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x0603304C RID: 208972 RVA: 0x00E4CA6E File Offset: 0x00E4AC6E
		protected new ActivityUniversalData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityUniversalData;
			}
		}

		// Token: 0x0603304D RID: 208973 RVA: 0x00E4CA7C File Offset: 0x00E4AC7C
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

		// Token: 0x0603304E RID: 208974 RVA: 0x00E4CB27 File Offset: 0x00E4AD27
		protected override void OnSetData()
		{
		}

		// Token: 0x0603304F RID: 208975 RVA: 0x00E4CB2C File Offset: 0x00E4AD2C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewUniversal.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewUniversal.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033050 RID: 208976 RVA: 0x00E4CB70 File Offset: 0x00E4AD70
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

		// Token: 0x06033051 RID: 208977 RVA: 0x00E4CCC0 File Offset: 0x00E4AEC0
		protected override void OnRefreshView()
		{
			this.RefreshCondition();
			this.RefreshTimerText();
		}

		// Token: 0x06033052 RID: 208978 RVA: 0x00E4CCD0 File Offset: 0x00E4AED0
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

		// Token: 0x06033053 RID: 208979 RVA: 0x00E4CD0D File Offset: 0x00E4AF0D
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

		// Token: 0x06033054 RID: 208980 RVA: 0x00E4CD2C File Offset: 0x00E4AF2C
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

		// Token: 0x0401B143 RID: 110915
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401B144 RID: 110916
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401B145 RID: 110917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401B146 RID: 110918
		private ActivityFunctionalTypeA FunctionalComponent;
	}
}
