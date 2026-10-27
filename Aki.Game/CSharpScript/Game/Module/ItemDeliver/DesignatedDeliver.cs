using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x02005818 RID: 22552
	public class DesignatedDeliver : Deliver
	{
		// Token: 0x060394F4 RID: 234740 RVA: 0x00D977F4 File Offset: 0x00D959F4
		public DesignatedDeliver()
		{
			this.Type = EDeliverType.DesignatedDeliver;
			this.ItemSlotInfo = new List<DesignatedDeliverSlot>();
		}

		// Token: 0x0401DF82 RID: 122754
		[Nullable(1)]
		public List<DesignatedDeliverSlot> ItemSlotInfo;
	}
}
