using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006609 RID: 26121
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingDockQuestChildItem : GridProxyAbstract<IFishingDockQuestChildItemData>
	{
		// Token: 0x06041769 RID: 268137 RVA: 0x00FDA394 File Offset: 0x00FD8594
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

		// Token: 0x0604176A RID: 268138 RVA: 0x00FDA41E File Offset: 0x00FD861E
		protected override void OnStart()
		{
			base.GetText(1).SetUIActive(true);
		}

		// Token: 0x0604176B RID: 268139 RVA: 0x00FDA430 File Offset: 0x00FD8630
		[NullableContext(1)]
		public override void Refresh(IFishingDockQuestChildItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DesText, new <>z__ReadOnlySingleElementList<object>(data.MaxCount));
			base.GetText(1).SetText(string.Concat(new string[]
			{
				"(",
				Math.Min(data.CurrentCount, data.MaxCount).ToString(),
				"/",
				data.MaxCount.ToString(),
				")"
			}), true);
			base.GetItem(2).SetUIActive(data.CurrentCount >= data.MaxCount);
			base.GetText(1).useChangeColor = (data.CurrentCount >= data.MaxCount);
			base.GetText(0).useChangeColor = (data.CurrentCount >= data.MaxCount);
		}

		// Token: 0x0200C814 RID: 51220
		private class EComponentDefine
		{
			// Token: 0x0403C6BD RID: 247485
			public const int TargetText = 0;

			// Token: 0x0403C6BE RID: 247486
			public const int TargetCountText = 1;

			// Token: 0x0403C6BF RID: 247487
			public const int FinishItem = 2;
		}
	}
}
