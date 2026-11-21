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
	// Token: 0x02004968 RID: 18792
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantActivityInfoPanel : UiPanelBase
	{
		// Token: 0x0602F1FD RID: 193021 RVA: 0x00D23480 File Offset: 0x00D21680
		public GiantActivityInfoPanel(ActivityBaseData ActivityBaseData, Action OnEnterClick)
		{
			this.ActivityBaseData = ActivityBaseData;
			this.OnEnterClick = OnEnterClick;
		}

		// Token: 0x0602F1FE RID: 193022 RVA: 0x00D23498 File Offset: 0x00D21698
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

		// Token: 0x0602F1FF RID: 193023 RVA: 0x00D23544 File Offset: 0x00D21744
		protected override UniTask OnBeforeStartAsync()
		{
			GiantActivityInfoPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantActivityInfoPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F200 RID: 193024 RVA: 0x00D23587 File Offset: 0x00D21787
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

		// Token: 0x0602F201 RID: 193025 RVA: 0x00D235B1 File Offset: 0x00D217B1
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

		// Token: 0x0602F202 RID: 193026 RVA: 0x00D235D9 File Offset: 0x00D217D9
		public void SetDesc(string textId)
		{
			ActivityDescriptionTypeA desc = this.Desc;
			if (desc == null)
			{
				return;
			}
			desc.SetContentByTextId(textId, Array.Empty<string>());
		}

		// Token: 0x0602F203 RID: 193027 RVA: 0x00D235F1 File Offset: 0x00D217F1
		public void SetReward(List<TItem> rewardList)
		{
			ActivityRewardList<CommonItemSmallItemGrid, TItem> reward = this.Reward;
			if (reward == null)
			{
				return;
			}
			reward.RefreshItemLayout(rewardList, null);
		}

		// Token: 0x0602F204 RID: 193028 RVA: 0x00D23608 File Offset: 0x00D21808
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

		// Token: 0x04019039 RID: 102457
		[Nullable(2)]
		private ActivityTitleTypeA Title;

		// Token: 0x0401903A RID: 102458
		[Nullable(2)]
		private ActivityDescriptionTypeA Desc;

		// Token: 0x0401903B RID: 102459
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> Reward;

		// Token: 0x0401903C RID: 102460
		[Nullable(2)]
		private ActivityFunctionalTypeA Bottom;

		// Token: 0x0401903D RID: 102461
		private readonly ActivityBaseData ActivityBaseData;

		// Token: 0x0401903E RID: 102462
		private readonly Action OnEnterClick;

		// Token: 0x0200A61B RID: 42523
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403360D RID: 210445
			Title,
			// Token: 0x0403360E RID: 210446
			Desc,
			// Token: 0x0403360F RID: 210447
			Reward,
			// Token: 0x04033610 RID: 210448
			Bottom
		}
	}
}
