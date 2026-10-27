using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x02005817 RID: 22551
	public class ArbitraryDeliver : Deliver
	{
		// Token: 0x060394F3 RID: 234739 RVA: 0x00D977DA File Offset: 0x00D959DA
		public ArbitraryDeliver()
		{
			this.Type = EDeliverType.ArbitraryDeliver;
			this.ItemSlotInfo = new List<ArbitraryDiliverSlot>();
		}

		// Token: 0x0401DF81 RID: 122753
		[Nullable(1)]
		public List<ArbitraryDiliverSlot> ItemSlotInfo;
	}
}
