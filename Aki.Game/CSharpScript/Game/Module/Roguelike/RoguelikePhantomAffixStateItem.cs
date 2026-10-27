using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DBF RID: 19903
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikePhantomAffixStateItem : GridProxyAbstract<IRoguelikePhantomAffixStateItemData>
	{
		// Token: 0x0603361F RID: 210463 RVA: 0x00BFF348 File Offset: 0x00BFD548
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

		// Token: 0x06033620 RID: 210464 RVA: 0x00BFF3B1 File Offset: 0x00BFD5B1
		[NullableContext(1)]
		public override void Refresh(IRoguelikePhantomAffixStateItemData data, bool isSelected, int gridIndex)
		{
			this.SetUnlockState(data.IsUnlock);
		}

		// Token: 0x06033621 RID: 210465 RVA: 0x00BFF3BF File Offset: 0x00BFD5BF
		private void SetUnlockState(bool isUnlock)
		{
			base.GetItem(0).SetUIActive(isUnlock);
			base.GetItem(1).SetUIActive(!isUnlock);
		}

		// Token: 0x0200AF37 RID: 44855
		private class EComponents
		{
			// Token: 0x0403534E RID: 217934
			public const int SprConfirm = 0;

			// Token: 0x0403534F RID: 217935
			public const int SprDis = 1;
		}
	}
}
