using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AC4 RID: 23236
	public class ActionSetSeqCameraTransform : ActionParams
	{
		// Token: 0x0401E1DF RID: 123359
		[Nullable(2)]
		public Transform Transform;

		// Token: 0x0401E1E0 RID: 123360
		public float? Fov;

		// Token: 0x0401E1E1 RID: 123361
		public float? Aperture;

		// Token: 0x0401E1E2 RID: 123362
		public float? FocalLength;

		// Token: 0x0401E1E3 RID: 123363
		public float? FocusDistance;
	}
}
