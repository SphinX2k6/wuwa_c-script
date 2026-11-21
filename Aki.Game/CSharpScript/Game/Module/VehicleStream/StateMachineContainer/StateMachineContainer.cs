using System;

namespace CSharpScript.Game.Module.VehicleStream.StateMachineContainer
{
	// Token: 0x02003835 RID: 14389
	public abstract class StateMachineContainer
	{
		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x060255EE RID: 153070
		public abstract EStateContainerType Type { get; }

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x060255EF RID: 153071
		public abstract int Id { get; }
	}
}
