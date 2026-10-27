using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005808 RID: 22536
	public class RewardExploreScoreSubTitleItem : UiPanelBase
	{
		// Token: 0x06039499 RID: 234649 RVA: 0x00D96208 File Offset: 0x00D94408
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603949A RID: 234650 RVA: 0x00D96271 File Offset: 0x00D94471
		[NullableContext(1)]
		public void RefreshText(IRewardExploreScoreBelongHalfAreaItem data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DescriptionTextId, Array.Empty<object>());
			base.GetText(1).SetText(data.Target, true);
		}

		// Token: 0x0200BA09 RID: 47625
		private class EChildType
		{
			// Token: 0x040383BE RID: 230334
			public const int DesText = 0;

			// Token: 0x040383BF RID: 230335
			public const int NumText = 1;
		}
	}
}
