using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C8 RID: 1480
	public class INpcModel_SetValue
	{
		// Token: 0x0400158F RID: 5519
		public EModelType Type;

		// Token: 0x04001590 RID: 5520
		public string BlueprintPath;

		// Token: 0x04001591 RID: 5521
		[Nullable(2)]
		public INpcModelConfig NpcModel;

		// Token: 0x04001592 RID: 5522
		public string Abp;

		// Token: 0x04001593 RID: 5523
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> BattleSockets;

		// Token: 0x04001594 RID: 5524
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> NormalSockets;

		// Token: 0x04001595 RID: 5525
		public float? LookingUpAngle;

		// Token: 0x04001596 RID: 5526
		public EBodyType? BodyType;

		// Token: 0x04001597 RID: 5527
		public float? NameZaxisOffset;
	}
}
