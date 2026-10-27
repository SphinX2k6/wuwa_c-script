using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000561 RID: 1377
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcModel_SetValue
	{
		// Token: 0x04001425 RID: 5157
		public EModelType Type;

		// Token: 0x04001426 RID: 5158
		public string BlueprintPath;

		// Token: 0x04001427 RID: 5159
		[Nullable(2)]
		public INpcModelConfig NpcModel;

		// Token: 0x04001428 RID: 5160
		public string Abp;

		// Token: 0x04001429 RID: 5161
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> BattleSockets;

		// Token: 0x0400142A RID: 5162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> NormalSockets;

		// Token: 0x0400142B RID: 5163
		public float? LookingUpAngle;

		// Token: 0x0400142C RID: 5164
		public EBodyType? BodyType;

		// Token: 0x0400142D RID: 5165
		public float? NameZaxisOffset;
	}
}
