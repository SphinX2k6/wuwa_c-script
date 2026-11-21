using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BD RID: 1981
	public class IStateRotationConfig_SetValue
	{
		// Token: 0x04001C6D RID: 7277
		public string State;

		// Token: 0x04001C6E RID: 7278
		public bool IsLoop;

		// Token: 0x04001C6F RID: 7279
		[Nullable(2)]
		public IStartRotationConfig StartRotationConfig;

		// Token: 0x04001C70 RID: 7280
		[Nullable(2)]
		public string RotatePoint;

		// Token: 0x04001C71 RID: 7281
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IRotationConfig> RotationConfig;

		// Token: 0x04001C72 RID: 7282
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IKeyRotatorConfig> KeyRotatorConfig;

		// Token: 0x04001C73 RID: 7283
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAxisAngleMethodConfig> AxisAngleMethodConfig;

		// Token: 0x04001C74 RID: 7284
		public bool? KeepLastRotation;
	}
}
