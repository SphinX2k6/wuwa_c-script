using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004079 RID: 16505
	public enum ITriggerShape_Union : byte
	{
		// Token: 0x0400BC21 RID: 48161
		NONE,
		// Token: 0x0400BC22 RID: 48162
		ITriggerShape,
		// Token: 0x0400BC23 RID: 48163
		IBoxTriggerShape,
		// Token: 0x0400BC24 RID: 48164
		ISphereTriggerShape,
		// Token: 0x0400BC25 RID: 48165
		IHollowSphereTriggerShape,
		// Token: 0x0400BC26 RID: 48166
		ICylinderTriggerShape,
		// Token: 0x0400BC27 RID: 48167
		IHollowCylinderTriggerShape,
		// Token: 0x0400BC28 RID: 48168
		IConeTriggerShape,
		// Token: 0x0400BC29 RID: 48169
		IVolumeTriggerShape,
		// Token: 0x0400BC2A RID: 48170
		IActorRefVolume,
		// Token: 0x0400BC2B RID: 48171
		IActorCollisionTriggerShape,
		// Token: 0x0400BC2C RID: 48172
		ICombinationTriggerShape,
		// Token: 0x0400BC2D RID: 48173
		ISpotlightTriggerShape
	}
}
