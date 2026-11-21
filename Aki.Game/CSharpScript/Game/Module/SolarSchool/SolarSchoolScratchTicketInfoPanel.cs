using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005947 RID: 22855
	public class SolarSchoolScratchTicketInfoPanel : UiPanelBase
	{
		// Token: 0x06038512 RID: 230674 RVA: 0x00FBEAD8 File Offset: 0x00FBCCD8
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

		// Token: 0x06038513 RID: 230675 RVA: 0x00FBEB84 File Offset: 0x00FBCD84
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolScratchTicketInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolScratchTicketInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038514 RID: 230676 RVA: 0x00FBEBC7 File Offset: 0x00FBCDC7
		protected override void OnStart()
		{
			ActivityTitleTypeA titleComponent = this.TitleComponent;
			if (titleComponent != null)
			{
				titleComponent.SetTitleByTextId("SolarSchoolFes_lotteryname", Array.Empty<string>());
			}
			ActivityDescriptionTypeA descriptionComponent = this.DescriptionComponent;
			if (descriptionComponent == null)
			{
				return;
			}
			descriptionComponent.SetContentByTextId("SolarSchoolFes_lotterydesc", Array.Empty<string>());
		}

		// Token: 0x06038515 RID: 230677 RVA: 0x00FBEBFE File Offset: 0x00FBCDFE
		[NullableContext(1)]
		public void RefreshRewardList(IReadOnlyList<SolarSchoolScratchTicketRewardShow> rewards)
		{
			ActivityRewardList<SolarSchoolScratchTicketRewardItemGrid, SolarSchoolScratchTicketRewardShow> rewardListComponent = this.RewardListComponent;
			if (rewardListComponent == null)
			{
				return;
			}
			rewardListComponent.RefreshItemLayout(rewards, null);
		}

		// Token: 0x0401DA8A RID: 121482
		[Nullable(2)]
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401DA8B RID: 121483
		[Nullable(2)]
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401DA8C RID: 121484
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private ActivityRewardList<SolarSchoolScratchTicketRewardItemGrid, SolarSchoolScratchTicketRewardShow> RewardListComponent;

		// Token: 0x0200B4FE RID: 46334
		private enum EComponents
		{
			// Token: 0x04037F68 RID: 229224
			ComActivityTitle,
			// Token: 0x04037F69 RID: 229225
			ComActivityDescript,
			// Token: 0x04037F6A RID: 229226
			ComActivityReward,
			// Token: 0x04037F6B RID: 229227
			ComActivityRogueBottom
		}
	}
}
