using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200007D RID: 125
	[EnumExtensions]
	public enum EBulletCreateCondition
	{
		// Token: 0x04000274 RID: 628
		OnHit,
		// Token: 0x04000275 RID: 629
		OnMatching,
		// Token: 0x04000276 RID: 630
		OnCollision,
		// Token: 0x04000277 RID: 631
		[EnumStringMember("OnThrowDelayTime")]
		OnThrowTriggerTime,
		// Token: 0x04000278 RID: 632
		OpenGravityCollision
	}
}
