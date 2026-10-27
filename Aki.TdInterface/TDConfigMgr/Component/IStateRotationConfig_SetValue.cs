using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200071C RID: 1820
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateRotationConfig_SetValue
	{
		// Token: 0x04001A6C RID: 6764
		[Nullable(1)]
		public string State;

		// Token: 0x04001A6D RID: 6765
		public bool IsLoop;

		// Token: 0x04001A6E RID: 6766
		public IStartRotationConfig StartRotationConfig;

		// Token: 0x04001A6F RID: 6767
		public string RotatePoint;

		// Token: 0x04001A70 RID: 6768
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IRotationConfig> RotationConfig;

		// Token: 0x04001A71 RID: 6769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IKeyRotatorConfig> KeyRotatorConfig;

		// Token: 0x04001A72 RID: 6770
		public bool? KeepLastRotation;
	}
}
