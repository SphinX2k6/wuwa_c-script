using System;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006201 RID: 25089
	public class PassThroughPortalParam
	{
		// Token: 0x0603C432 RID: 246834 RVA: 0x0112C1A1 File Offset: 0x0112A3A1
		public PassThroughPortalParam()
		{
		}

		// Token: 0x0603C433 RID: 246835 RVA: 0x0112C1A9 File Offset: 0x0112A3A9
		public PassThroughPortalParam(CharacterManipulateComponent.EPassThroughPortalType type, long portalPairId, float distance)
		{
			this.Type = type;
			this.PortalPairId = portalPairId;
			this.Distance = distance;
		}

		// Token: 0x0401FE8F RID: 130703
		public CharacterManipulateComponent.EPassThroughPortalType Type;

		// Token: 0x0401FE90 RID: 130704
		public long PortalPairId;

		// Token: 0x0401FE91 RID: 130705
		public float Distance;
	}
}
