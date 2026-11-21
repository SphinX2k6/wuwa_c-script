using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A9 RID: 25001
	public class NearestRoadway : IClear
	{
		// Token: 0x0603C040 RID: 245824 RVA: 0x0110F211 File Offset: 0x0110D411
		public bool ClearObject()
		{
			this.NearestPos.Reset();
			this.Roadway = null;
			return true;
		}

		// Token: 0x0401FB7F RID: 129919
		[Nullable(1)]
		public Vector NearestPos = Vector.Create();

		// Token: 0x0401FB80 RID: 129920
		[Nullable(2)]
		public UKuroRoadway Roadway;
	}
}
