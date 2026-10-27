using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005302 RID: 21250
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueResActivitySubViewGeneralInfo : UiPanelBase
	{
		// Token: 0x060365E2 RID: 222690 RVA: 0x00CDCA04 File Offset: 0x00CDAC04
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x060365E3 RID: 222691 RVA: 0x00CDCA74 File Offset: 0x00CDAC74
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060365E4 RID: 222692 RVA: 0x00CDCAB8 File Offset: 0x00CDACB8
		protected override void OnStart()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			string descTheme = localConfig.Value.DescTheme;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(flag);
			this.TitleComponent.SetTimeTextVisible(false);
			if (flag)
			{
				string descThemeIcon = localConfig.Value.DescThemeIcon;
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
				if (!string.IsNullOrEmpty(descThemeIcon))
				{
					ActivityTitleTypeA titleComponent = this.TitleComponent;
					if (titleComponent != null)
					{
						titleComponent.SetSubTitleIconByPath(descThemeIcon, null);
					}
				}
			}
			string desc = localConfig.Value.Desc;
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
			this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.FunctionExecute));
			this.FunctionalComponent.FunctionButton.SetLocalTextNew("CollectActivity_reward", Array.Empty<object>());
			this.OnRefreshView();
		}

		// Token: 0x060365E5 RID: 222693 RVA: 0x00CDCC27 File Offset: 0x00CDAE27
		public void OnRefreshView()
		{
			this.RefreshFunction();
		}

		// Token: 0x060365E6 RID: 222694 RVA: 0x00CDCC30 File Offset: 0x00CDAE30
		public void RefreshFunction()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent != null)
			{
				ActivityButtonItem functionButton = functionalComponent.FunctionButton;
				if (functionButton != null)
				{
					functionButton.SetUiActive(flag);
				}
			}
			ActivityFunctionalTypeA functionalComponent2 = this.FunctionalComponent;
			if (functionalComponent2 != null)
			{
				functionalComponent2.SetPanelConditionVisible(!flag);
			}
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
		}

		// Token: 0x060365E7 RID: 222695 RVA: 0x00CDCC9F File Offset: 0x00CDAE9F
		[NullableContext(1)]
		public void SetData(ActivityBaseData data)
		{
			this.ActivityBaseData = data;
		}

		// Token: 0x060365E8 RID: 222696 RVA: 0x00CDCCA8 File Offset: 0x00CDAEA8
		[NullableContext(1)]
		public void SetBtnText(string textId, params object[] args)
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functionalComponent.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetLocalTextNew(textId, args);
		}

		// Token: 0x060365E9 RID: 222697 RVA: 0x00CDCCC6 File Offset: 0x00CDAEC6
		public void SetClickFunc([Nullable(new byte[]
		{
			1,
			2
		})] Action<ActivityBaseData> clickFunc)
		{
			this.ClickFunc = clickFunc;
		}

		// Token: 0x060365EA RID: 222698 RVA: 0x00CDCCCF File Offset: 0x00CDAECF
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				Action<ActivityBaseData> clickFunc = this.ClickFunc;
				if (clickFunc == null)
				{
					return;
				}
				clickFunc(this.ActivityBaseData);
			});
		}

		// Token: 0x060365EB RID: 222699 RVA: 0x00CDCCED File Offset: 0x00CDAEED
		public void SetFunctionRedDotVisible(bool bVisible)
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			functionalComponent.SetFunctionRedDotVisible(bVisible);
		}

		// Token: 0x060365EC RID: 222700 RVA: 0x00CDCD00 File Offset: 0x00CDAF00
		[NullableContext(1)]
		public void SetRewardButtonFunction(Action buttonFunction)
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			functionalComponent.SetRewardButtonFunction(buttonFunction);
		}

		// Token: 0x060365ED RID: 222701 RVA: 0x00CDCD13 File Offset: 0x00CDAF13
		[NullableContext(1)]
		public void SetSubTitleTextById(string textId)
		{
			this.TitleComponent.SetSubTitleVisible(true);
			this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
		}

		// Token: 0x060365EE RID: 222702 RVA: 0x00CDCD32 File Offset: 0x00CDAF32
		public ActivityFunctionalTypeA GetFunctional()
		{
			return this.FunctionalComponent;
		}

		// Token: 0x0401CB77 RID: 117623
		protected ActivityBaseData ActivityBaseData;

		// Token: 0x0401CB78 RID: 117624
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401CB79 RID: 117625
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401CB7A RID: 117626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401CB7B RID: 117627
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401CB7C RID: 117628
		private Action<ActivityBaseData> ClickFunc;
	}
}
