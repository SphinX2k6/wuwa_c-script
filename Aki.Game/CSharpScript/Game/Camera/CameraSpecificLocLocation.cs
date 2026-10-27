using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072B4 RID: 29364
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSpecificLocLocation : CameraSpecificLockTarget
	{
		// Token: 0x0604808E RID: 295054 RVA: 0x012775D4 File Offset: 0x012757D4
		public CameraSpecificLocLocation(Vector location, int priority, int id, ECameraSpecificLockGroup group = ECameraSpecificLockGroup.Normal) : base(ECameraSpecificLockType.Location, id, priority, group)
		{
		}

		// Token: 0x17009F0C RID: 40716
		// (get) Token: 0x0604808F RID: 295055 RVA: 0x012775E8 File Offset: 0x012757E8
		public Vector Location { get; } = location;
	}
}
