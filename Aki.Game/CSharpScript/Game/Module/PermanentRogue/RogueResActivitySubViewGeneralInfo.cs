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
	// Token: 0x020042D2 RID: 17106
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueResActivitySubViewGeneralInfo : UiPanelBase
	{
		// Token: 0x0602B4DE RID: 177374 RVA: 0x00C2A3D4 File Offset: 0x00C285D4
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

		// Token: 0x0602B4DF RID: 177375 RVA: 0x00C2A444 File Offset: 0x00C28644
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResActivitySubViewGeneralInfo.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B4E0 RID: 177376 RVA: 0x00C2A488 File Offset: 0x00C28688
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

		// Token: 0x0602B4E1 RID: 177377 RVA: 0x00C2A5F7 File Offset: 0x00C287F7
		public void OnRefreshView()
		{
			this.RefreshFunction();
		}

		// Token: 0x0602B4E2 RID: 177378 RVA: 0x00C2A600 File Offset: 0x00C28800
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

		// Token: 0x0602B4E3 RID: 177379 RVA: 0x00C2A66F File Offset: 0x00C2886F
		[NullableContext(1)]
		public void SetData(ActivityBaseData data)
		{
			this.ActivityBaseData = data;
		}

		// Token: 0x0602B4E4 RID: 177380 RVA: 0x00C2A678 File Offset: 0x00C28878
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

		// Token: 0x0602B4E5 RID: 177381 RVA: 0x00C2A696 File Offset: 0x00C28896
		public void SetClickFunc([Nullable(new byte[]
		{
			1,
			2
		})] Action<ActivityBaseData> clickFunc)
		{
			this.ClickFunc = clickFunc;
		}

		// Token: 0x0602B4E6 RID: 177382 RVA: 0x00C2A69F File Offset: 0x00C2889F
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

		// Token: 0x0602B4E7 RID: 177383 RVA: 0x00C2A6BD File Offset: 0x00C288BD
		public void SetFunctionRedDotVisible(bool bVisible)
		{
			ActivityFunctionalTypeA functionalComponent = this.FunctionalComponent;
			if (functionalComponent == null)
			{
				return;
			}
			functionalComponent.SetFunctionRedDotVisible(bVisible);
		}

		// Token: 0x0602B4E8 RID: 177384 RVA: 0x00C2A6D0 File Offset: 0x00C288D0
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

		// Token: 0x0602B4E9 RID: 177385 RVA: 0x00C2A6E3 File Offset: 0x00C288E3
		[NullableContext(1)]
		public void SetSubTitleTextById(string textId)
		{
			this.TitleComponent.SetSubTitleVisible(true);
			this.TitleComponent.SetSubTitleByTextId(textId, Array.Empty<string>());
		}

		// Token: 0x0602B4EA RID: 177386 RVA: 0x00C2A702 File Offset: 0x00C28902
		public ActivityFunctionalTypeA GetFunctional()
		{
			return this.FunctionalComponent;
		}

		// Token: 0x040175AD RID: 95661
		protected ActivityBaseData ActivityBaseData;

		// Token: 0x040175AE RID: 95662
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x040175AF RID: 95663
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x040175B0 RID: 95664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x040175B1 RID: 95665
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x040175B2 RID: 95666
		private Action<ActivityBaseData> ClickFunc;
	}
}
