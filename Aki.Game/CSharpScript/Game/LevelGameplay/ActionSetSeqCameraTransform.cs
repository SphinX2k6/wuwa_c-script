using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006968 RID: 26984
	public class ActionSetSeqCameraTransform : ActionParams
	{
		// Token: 0x04022FF5 RID: 143349
		[Nullable(2)]
		public Transform Transform;

		// Token: 0x04022FF6 RID: 143350
		public float? Fov;

		// Token: 0x04022FF7 RID: 143351
		public float? Aperture;

		// Token: 0x04022FF8 RID: 143352
		public float? FocalLength;

		// Token: 0x04022FF9 RID: 143353
		public float? FocusDistance;
	}
}
