using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047EE RID: 18414
	public class ArbitraryDeliver : Deliver
	{
		// Token: 0x0602E407 RID: 189447 RVA: 0x00CE666A File Offset: 0x00CE486A
		public ArbitraryDeliver()
		{
			this.Type = EDeliverType.ArbitraryDeliver;
			this.ItemSlotInfo = new List<ArbitraryDiliverSlot>();
		}

		// Token: 0x04018A18 RID: 100888
		[Nullable(1)]
		public List<ArbitraryDiliverSlot> ItemSlotInfo;
	}
}
