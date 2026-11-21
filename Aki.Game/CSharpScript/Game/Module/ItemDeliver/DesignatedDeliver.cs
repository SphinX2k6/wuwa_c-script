using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047EF RID: 18415
	public class DesignatedDeliver : Deliver
	{
		// Token: 0x0602E408 RID: 189448 RVA: 0x00CE6684 File Offset: 0x00CE4884
		public DesignatedDeliver()
		{
			this.Type = EDeliverType.DesignatedDeliver;
			this.ItemSlotInfo = new List<DesignatedDeliverSlot>();
		}

		// Token: 0x04018A19 RID: 100889
		[Nullable(1)]
		public List<DesignatedDeliverSlot> ItemSlotInfo;
	}
}
