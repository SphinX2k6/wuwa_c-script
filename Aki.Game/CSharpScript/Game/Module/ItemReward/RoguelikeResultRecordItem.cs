using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02005804 RID: 22532
	internal class RoguelikeResultRecordItem : UiPanelBase
	{
		// Token: 0x06039483 RID: 234627 RVA: 0x00D95B40 File Offset: 0x00D93D40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039484 RID: 234628 RVA: 0x00D95BCA File Offset: 0x00D93DCA
		[NullableContext(1)]
		public void Refresh(IRoguelikeBossChallengeData data)
		{
			base.GetText(1).SetText(TimeUtil.Instance.GetTimeString((double)data.PassTime), true);
			base.GetItem(2).SetUIActive(data.IsNewRecord);
		}

		// Token: 0x0200B9FF RID: 47615
		private class ERoguelikeResultRecordComponent
		{
			// Token: 0x0403839C RID: 230300
			public const int TxtTitle = 0;

			// Token: 0x0403839D RID: 230301
			public const int TxtNum = 1;

			// Token: 0x0403839E RID: 230302
			public const int NewTagItem = 2;
		}
	}
}
