using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006436 RID: 25654
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSpecificLocLocation : CameraSpecificLockTarget
	{
		// Token: 0x0603E47F RID: 255103 RVA: 0x012198ED File Offset: 0x01217AED
		public CameraSpecificLocLocation(Vector location, int priority, int id, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal) : base(ECameraSpecificLockType.Location, id, priority, group)
		{
		}

		// Token: 0x17007673 RID: 30323
		// (get) Token: 0x0603E480 RID: 255104 RVA: 0x01219901 File Offset: 0x01217B01
		public Vector Location { get; } = location;
	}
}
