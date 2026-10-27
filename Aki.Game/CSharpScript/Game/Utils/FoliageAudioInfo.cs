using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004546 RID: 17734
	public class FoliageAudioInfo
	{
		// Token: 0x04018785 RID: 100229
		[Nullable(2)]
		public UPhysicalMaterial PhysicalMaterial;

		// Token: 0x04018786 RID: 100230
		public FName FoliageName = FNameUtil.NONE;

		// Token: 0x04018787 RID: 100231
		public bool IsAudioShrub;

		// Token: 0x04018788 RID: 100232
		public bool IsHitFoliage;

		// Token: 0x04018789 RID: 100233
		public FName AudioShrubTag = FNameUtil.NONE;
	}
}
