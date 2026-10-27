using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x0200598F RID: 22927
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantActivityInfoPanel : UiPanelBase
	{
		// Token: 0x0603A2D7 RID: 238295 RVA: 0x00DD3FF0 File Offset: 0x00DD21F0
		public GiantActivityInfoPanel(ActivityBaseData ActivityBaseData, Action OnEnterClick)
		{
			this.ActivityBaseData = ActivityBaseData;
			this.OnEnterClick = OnEnterClick;
		}

		// Token: 0x0603A2D8 RID: 238296 RVA: 0x00DD4008 File Offset: 0x00DD2208
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

		// Token: 0x0603A2D9 RID: 238297 RVA: 0x00DD40B4 File Offset: 0x00DD22B4
		protected override UniTask OnBeforeStartAsync()
		{
			GiantActivityInfoPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantActivityInfoPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A2DA RID: 238298 RVA: 0x00DD40F7 File Offset: 0x00DD22F7
		public void SetTitle(string text)
		{
			ActivityTitleTypeA title = this.Title;
			if (title != null)
			{
				title.SetActivityBaseData(this.ActivityBaseData);
			}
			ActivityTitleTypeA title2 = this.Title;
			if (title2 == null)
			{
				return;
			}
			title2.SetTitleByText(text);
		}

		// Token: 0x0603A2DB RID: 238299 RVA: 0x00DD4121 File Offset: 0x00DD2321
		public void SetTimer(bool visible, string text)
		{
			ActivityTitleTypeA title = this.Title;
			if (title != null)
			{
				title.SetTimeTextVisible(visible);
			}
			if (visible)
			{
				ActivityTitleTypeA title2 = this.Title;
				if (title2 == null)
				{
					return;
				}
				title2.SetTimeTextByText(text);
			}
		}

		// Token: 0x0603A2DC RID: 238300 RVA: 0x00DD4149 File Offset: 0x00DD2349
		public void SetDesc(string textId)
		{
			ActivityDescriptionTypeA desc = this.Desc;
			if (desc == null)
			{
				return;
			}
			desc.SetContentByTextId(textId, Array.Empty<string>());
		}

		// Token: 0x0603A2DD RID: 238301 RVA: 0x00DD4161 File Offset: 0x00DD2361
		public void SetReward(List<TItem> rewardList)
		{
			ActivityRewardList<CommonItemSmallItemGrid, TItem> reward = this.Reward;
			if (reward == null)
			{
				return;
			}
			reward.RefreshItemLayout(rewardList, null);
		}

		// Token: 0x0603A2DE RID: 238302 RVA: 0x00DD4178 File Offset: 0x00DD2378
		public void RefreshFunctionArea()
		{
			IActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "GiantSystemEnterText",
				UnlockBtnFunction = this.OnEnterClick
			};
			ActivityFunctionalTypeA bottom = this.Bottom;
			if (bottom != null)
			{
				bottom.RefreshGeneralPerformance(parameters);
			}
			ActivityFunctionalTypeA bottom2 = this.Bottom;
			if (bottom2 == null)
			{
				return;
			}
			bottom2.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
		}

		// Token: 0x0401E59B RID: 124315
		[Nullable(2)]
		private ActivityTitleTypeA Title;

		// Token: 0x0401E59C RID: 124316
		[Nullable(2)]
		private ActivityDescriptionTypeA Desc;

		// Token: 0x0401E59D RID: 124317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> Reward;

		// Token: 0x0401E59E RID: 124318
		[Nullable(2)]
		private ActivityFunctionalTypeA Bottom;

		// Token: 0x0401E59F RID: 124319
		private readonly ActivityBaseData ActivityBaseData;

		// Token: 0x0401E5A0 RID: 124320
		private readonly Action OnEnterClick;

		// Token: 0x0200BC10 RID: 48144
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04038C3E RID: 232510
			Title,
			// Token: 0x04038C3F RID: 232511
			Desc,
			// Token: 0x04038C40 RID: 232512
			Reward,
			// Token: 0x04038C41 RID: 232513
			Bottom
		}
	}
}
