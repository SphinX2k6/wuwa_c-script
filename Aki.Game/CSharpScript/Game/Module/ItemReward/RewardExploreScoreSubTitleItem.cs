using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047DF RID: 18399
	public class RewardExploreScoreSubTitleItem : UiPanelBase
	{
		// Token: 0x0602E3AD RID: 189357 RVA: 0x00CE5070 File Offset: 0x00CE3270
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

		// Token: 0x0602E3AE RID: 189358 RVA: 0x00CE50D9 File Offset: 0x00CE32D9
		[NullableContext(1)]
		public void RefreshText(IRewardExploreScoreBelongHalfAreaItem data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DescriptionTextId, Array.Empty<object>());
			base.GetText(1).SetText(data.Target, true);
		}

		// Token: 0x0200A41F RID: 42015
		private class EChildType
		{
			// Token: 0x04032DAB RID: 208299
			public const int DesText = 0;

			// Token: 0x04032DAC RID: 208300
			public const int NumText = 1;
		}
	}
}
