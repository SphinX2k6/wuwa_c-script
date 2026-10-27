using System;

namespace CSharpScript.Game.Module.VehicleStream.StateMachineContainer
{
	// Token: 0x020048BE RID: 18622
	public abstract class StateMachineContainer
	{
		// Token: 0x17007977 RID: 31095
		// (get) Token: 0x06030AC2 RID: 199362
		public abstract EStateContainerType Type { get; }

		// Token: 0x17007978 RID: 31096
		// (get) Token: 0x06030AC3 RID: 199363
		public abstract int Id { get; }
	}
}
