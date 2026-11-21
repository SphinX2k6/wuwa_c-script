using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047E0 RID: 18400
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReached : UiPanelBase
	{
		// Token: 0x0602E3B0 RID: 189360 RVA: 0x00CE5112 File Offset: 0x00CE3312
		public RewardExploreTargetReached(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0602E3B1 RID: 189361 RVA: 0x00CE5124 File Offset: 0x00CE3324
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0602E3B2 RID: 189362 RVA: 0x00CE5198 File Offset: 0x00CE3398
		public void Refresh(IRewardExploreTargetReached rewardExploreBarData)
		{
			this.SetTargetSpriteActive(rewardExploreBarData.IsReached);
			this.SetDescriptionText(rewardExploreBarData.DescriptionTextId, rewardExploreBarData.Target);
		}

		// Token: 0x0602E3B3 RID: 189363 RVA: 0x00CE51B8 File Offset: 0x00CE33B8
		private void SetTargetSpriteActive(bool active)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(active);
		}

		// Token: 0x0602E3B4 RID: 189364 RVA: 0x00CE51CC File Offset: 0x00CE33CC
		private void SetDescriptionText(string descriptionTextId, List<string> target)
		{
			UUIText text = base.GetText(1);
			if (StringUtils.IsEmpty(descriptionTextId))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, descriptionTextId, target);
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}

		// Token: 0x0200A420 RID: 42016
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04032DAD RID: 208301
			public const int TargetSprite = 0;

			// Token: 0x04032DAE RID: 208302
			public const int DescriptionText = 1;
		}
	}
}
