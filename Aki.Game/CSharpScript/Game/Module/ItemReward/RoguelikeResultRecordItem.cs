using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047DB RID: 18395
	internal class RoguelikeResultRecordItem : UiPanelBase
	{
		// Token: 0x0602E397 RID: 189335 RVA: 0x00CE49A8 File Offset: 0x00CE2BA8
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

		// Token: 0x0602E398 RID: 189336 RVA: 0x00CE4A32 File Offset: 0x00CE2C32
		[NullableContext(1)]
		public void Refresh(IRoguelikeBossChallengeData data)
		{
			base.GetText(1).SetText(TimeUtil.Instance.GetTimeString((double)data.PassTime), true);
			base.GetItem(2).SetUIActive(data.IsNewRecord);
		}

		// Token: 0x0200A415 RID: 42005
		private class ERoguelikeResultRecordComponent
		{
			// Token: 0x04032D89 RID: 208265
			public const int TxtTitle = 0;

			// Token: 0x04032D8A RID: 208266
			public const int TxtNum = 1;

			// Token: 0x04032D8B RID: 208267
			public const int NewTagItem = 2;
		}
	}
}
