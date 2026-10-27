using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007028 RID: 28712
	public class NearestRoadway : IClear
	{
		// Token: 0x06045E69 RID: 286313 RVA: 0x01165291 File Offset: 0x01163491
		public bool ClearObject()
		{
			this.NearestPos.Reset();
			this.Roadway = null;
			return true;
		}

		// Token: 0x040248C9 RID: 149705
		[Nullable(1)]
		public Vector NearestPos = Vector.Create();

		// Token: 0x040248CA RID: 149706
		[Nullable(2)]
		public UKuroRoadway Roadway;
	}
}
