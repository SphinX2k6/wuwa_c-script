using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641B RID: 25627
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class CapabilityData
	{
		// Token: 0x0603E36D RID: 254829 RVA: 0x01211BD7 File Offset: 0x0120FDD7
		protected CapabilityData(ICapabilityGameObject ownerGameObject = null)
		{
		}

		// Token: 0x0603E36E RID: 254830
		public abstract void OnAdded();

		// Token: 0x0603E36F RID: 254831
		public abstract void OnRemoved();

		// Token: 0x040211BD RID: 135613
		public ICapabilityGameObject OwnerGameObject = ownerGameObject;
	}
}
