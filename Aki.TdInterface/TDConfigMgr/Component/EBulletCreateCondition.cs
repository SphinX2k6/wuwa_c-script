using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000080 RID: 128
	[EnumExtensions]
	public enum EBulletCreateCondition
	{
		// Token: 0x04000283 RID: 643
		OnHit,
		// Token: 0x04000284 RID: 644
		OnMatching,
		// Token: 0x04000285 RID: 645
		OnCollision,
		// Token: 0x04000286 RID: 646
		[EnumStringMember("OnThrowDelayTime")]
		OnThrowTriggerTime,
		// Token: 0x04000287 RID: 647
		OpenGravityCollision
	}
}
