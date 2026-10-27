using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.LevelPlay
{
	// Token: 0x020056BA RID: 22202
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopVolumeRuntime
	{
		// Token: 0x06038788 RID: 231304 RVA: 0x00D683E0 File Offset: 0x00D665E0
		public LoopVolumeRuntime(AKuroLoopTeleportVolume volume)
		{
			this.Volume = volume;
		}

		// Token: 0x06038789 RID: 231305 RVA: 0x00D68405 File Offset: 0x00D66605
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
			AKuroLoopTeleportVolume volume = this.Volume;
			if (volume != null && volume.IsValid())
			{
				this.Volume.bEnabled = enabled;
			}
		}

		// Token: 0x0401DA7E RID: 121470
		public readonly AKuroLoopTeleportVolume Volume;

		// Token: 0x0401DA7F RID: 121471
		[Nullable(2)]
		public AVolume BoundsVolume;

		// Token: 0x0401DA80 RID: 121472
		public readonly Vector Center = Vector.Create();

		// Token: 0x0401DA81 RID: 121473
		public readonly Vector Extent = Vector.Create();

		// Token: 0x0401DA82 RID: 121474
		public float BufferDistance;

		// Token: 0x0401DA83 RID: 121475
		public bool Entered;

		// Token: 0x0401DA84 RID: 121476
		public bool Enabled;
	}
}
