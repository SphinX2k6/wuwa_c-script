using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.LevelPlay
{
	// Token: 0x02004691 RID: 18065
	[NullableContext(1)]
	[Nullable(0)]
	public class LoopVolumeRuntime
	{
		// Token: 0x0602D68F RID: 185999 RVA: 0x00CB66A3 File Offset: 0x00CB48A3
		public LoopVolumeRuntime(AKuroLoopTeleportVolume volume)
		{
			this.Volume = volume;
		}

		// Token: 0x0602D690 RID: 186000 RVA: 0x00CB66C8 File Offset: 0x00CB48C8
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
			AKuroLoopTeleportVolume volume = this.Volume;
			if (volume != null && volume.IsValid())
			{
				this.Volume.bEnabled = enabled;
			}
		}

		// Token: 0x0401850B RID: 99595
		public readonly AKuroLoopTeleportVolume Volume;

		// Token: 0x0401850C RID: 99596
		[Nullable(2)]
		public AVolume BoundsVolume;

		// Token: 0x0401850D RID: 99597
		public readonly Vector Center = Vector.Create();

		// Token: 0x0401850E RID: 99598
		public readonly Vector Extent = Vector.Create();

		// Token: 0x0401850F RID: 99599
		public float BufferDistance;

		// Token: 0x04018510 RID: 99600
		public bool Entered;

		// Token: 0x04018511 RID: 99601
		public bool Enabled;
	}
}
