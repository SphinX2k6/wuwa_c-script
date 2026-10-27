using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005809 RID: 22537
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReached : UiPanelBase
	{
		// Token: 0x0603949C RID: 234652 RVA: 0x00D962AA File Offset: 0x00D944AA
		public RewardExploreTargetReached(AActor rootActor)
		{
			base.CreateThenShowByActor(rootActor, null);
		}

		// Token: 0x0603949D RID: 234653 RVA: 0x00D962BC File Offset: 0x00D944BC
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

		// Token: 0x0603949E RID: 234654 RVA: 0x00D96330 File Offset: 0x00D94530
		public void Refresh(IRewardExploreTargetReached rewardExploreBarData)
		{
			this.SetTargetSpriteActive(rewardExploreBarData.IsReached);
			this.SetDescriptionText(rewardExploreBarData.DescriptionTextId, rewardExploreBarData.Target);
		}

		// Token: 0x0603949F RID: 234655 RVA: 0x00D96350 File Offset: 0x00D94550
		private void SetTargetSpriteActive(bool active)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(active);
		}

		// Token: 0x060394A0 RID: 234656 RVA: 0x00D96364 File Offset: 0x00D94564
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

		// Token: 0x0200BA0A RID: 47626
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040383C0 RID: 230336
			public const int TargetSprite = 0;

			// Token: 0x040383C1 RID: 230337
			public const int DescriptionText = 1;
		}
	}
}
