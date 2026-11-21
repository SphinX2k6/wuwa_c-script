using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D88 RID: 15752
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePhantomAffixStateItem : GridProxyAbstract<IRoguelikePhantomAffixStateItemData>
	{
		// Token: 0x0602848C RID: 165004 RVA: 0x00B48888 File Offset: 0x00B46A88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602848D RID: 165005 RVA: 0x00B488F1 File Offset: 0x00B46AF1
		[NullableContext(1)]
		public override void Refresh(IRoguelikePhantomAffixStateItemData data, bool isSelected, int gridIndex)
		{
			this.SetUnlockState(data.IsUnlock);
		}

		// Token: 0x0602848E RID: 165006 RVA: 0x00B488FF File Offset: 0x00B46AFF
		private void SetUnlockState(bool isUnlock)
		{
			base.GetItem(0).SetUIActive(isUnlock);
			base.GetItem(1).SetUIActive(!isUnlock);
		}

		// Token: 0x0200996C RID: 39276
		private class EComponents
		{
			// Token: 0x0402FD83 RID: 195971
			public const int SprConfirm = 0;

			// Token: 0x0402FD84 RID: 195972
			public const int SprDis = 1;
		}
	}
}
