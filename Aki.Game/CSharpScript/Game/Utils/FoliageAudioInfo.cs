using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200346E RID: 13422
	public class FoliageAudioInfo
	{
		// Token: 0x04012DBF RID: 77247
		[Nullable(2)]
		public UPhysicalMaterial PhysicalMaterial;

		// Token: 0x04012DC0 RID: 77248
		public FName FoliageName = FNameUtil.NONE;

		// Token: 0x04012DC1 RID: 77249
		public bool IsAudioShrub;

		// Token: 0x04012DC2 RID: 77250
		public bool IsHitFoliage;

		// Token: 0x04012DC3 RID: 77251
		public FName AudioShrubTag = FNameUtil.NONE;
	}
}
