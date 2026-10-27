using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729C RID: 29340
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class CapabilityData
	{
		// Token: 0x06047FA7 RID: 294823 RVA: 0x01270BDB File Offset: 0x0126EDDB
		protected CapabilityData(ICapabilityGameObject ownerGameObject = null)
		{
		}

		// Token: 0x06047FA8 RID: 294824
		public abstract void OnAdded();

		// Token: 0x06047FA9 RID: 294825
		public abstract void OnRemoved();

		// Token: 0x04025EEA RID: 155370
		public ICapabilityGameObject OwnerGameObject = ownerGameObject;
	}
}
