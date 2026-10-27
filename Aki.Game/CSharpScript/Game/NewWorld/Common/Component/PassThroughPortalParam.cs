using System;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007080 RID: 28800
	public class PassThroughPortalParam
	{
		// Token: 0x06046222 RID: 287266 RVA: 0x01182A40 File Offset: 0x01180C40
		public PassThroughPortalParam()
		{
		}

		// Token: 0x06046223 RID: 287267 RVA: 0x01182A48 File Offset: 0x01180C48
		public PassThroughPortalParam(CharacterManipulateComponent.EPassThroughPortalType type, long portalPairId, float distance)
		{
			this.Type = type;
			this.PortalPairId = portalPairId;
			this.Distance = distance;
		}

		// Token: 0x04024BD4 RID: 150484
		public CharacterManipulateComponent.EPassThroughPortalType Type;

		// Token: 0x04024BD5 RID: 150485
		public long PortalPairId;

		// Token: 0x04024BD6 RID: 150486
		public float Distance;
	}
}
