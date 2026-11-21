using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005587 RID: 21895
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingDockQuestChildItem : GridProxyAbstract<IFishingDockQuestChildItemData>
	{
		// Token: 0x0603642E RID: 222254 RVA: 0x00F21414 File Offset: 0x00F1F614
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

		// Token: 0x0603642F RID: 222255 RVA: 0x00F2149E File Offset: 0x00F1F69E
		protected override void OnStart()
		{
			base.GetText(1).SetUIActive(true);
		}

		// Token: 0x06036430 RID: 222256 RVA: 0x00F214B0 File Offset: 0x00F1F6B0
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

		// Token: 0x0200B1F7 RID: 45559
		private class EComponentDefine
		{
			// Token: 0x04037005 RID: 225285
			public const int TargetText = 0;

			// Token: 0x04037006 RID: 225286
			public const int TargetCountText = 1;

			// Token: 0x04037007 RID: 225287
			public const int FinishItem = 2;
		}
	}
}
