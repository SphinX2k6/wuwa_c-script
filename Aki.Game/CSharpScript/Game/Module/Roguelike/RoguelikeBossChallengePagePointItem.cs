using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D98 RID: 15768
	internal class RoguelikeBossChallengePagePointItem : GridProxyAbstract<bool>
	{
		// Token: 0x060284F5 RID: 165109 RVA: 0x00B49FE8 File Offset: 0x00B481E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060284F6 RID: 165110 RVA: 0x00B4A030 File Offset: 0x00B48230
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			this.OnDeselected(false);
		}

		// Token: 0x060284F7 RID: 165111 RVA: 0x00B4A039 File Offset: 0x00B48239
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x060284F8 RID: 165112 RVA: 0x00B4A048 File Offset: 0x00B48248
		public override void OnDeselected(bool fireEvent)
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x0200997B RID: 39291
		private class EPagePointComponents
		{
			// Token: 0x0402FDB9 RID: 196025
			public const int PnlDot = 0;
		}
	}
}
