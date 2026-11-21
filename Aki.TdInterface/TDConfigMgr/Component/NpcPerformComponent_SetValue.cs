using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008ED RID: 2285
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent_SetValue
	{
		// Token: 0x040020DD RID: 8413
		public bool? Disabled;

		// Token: 0x040020DE RID: 8414
		public bool? EdIsLocked;

		// Token: 0x040020DF RID: 8415
		public IBaseRoleNpcPerform SpecialNpcPerformConfig;

		// Token: 0x040020E0 RID: 8416
		public bool IsStare;

		// Token: 0x040020E1 RID: 8417
		public INpcHitShow NpcHitShow;

		// Token: 0x040020E2 RID: 8418
		public bool IsShowStrike;

		// Token: 0x040020E3 RID: 8419
		public INpcBumpShow NpcBumpShow;

		// Token: 0x040020E4 RID: 8420
		public INpcAwakeShow ShowOnAwake;

		// Token: 0x040020E5 RID: 8421
		public INpcStandbyShowMode ShowOnStandby;

		// Token: 0x040020E6 RID: 8422
		public INpcPerformOnInteract ShowOnInteract;

		// Token: 0x040020E7 RID: 8423
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IConditionalNpcPerformOnInteract> ConditionalShowOnInteracts;

		// Token: 0x040020E8 RID: 8424
		public INpcUiInteractType ShowOnUiInteract;

		// Token: 0x040020E9 RID: 8425
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcRideInVehiclePerformType> ShowOnRideInVehicle;

		// Token: 0x040020EA RID: 8426
		public INpcPerformOnMonsterCloseby NpcMonsterClosePerform;

		// Token: 0x040020EB RID: 8427
		public INpcPerformState NpcPerformState;

		// Token: 0x040020EC RID: 8428
		public INpcDeathInteract DeathInteract;

		// Token: 0x040020ED RID: 8429
		public bool? FixedPosition;

		// Token: 0x040020EE RID: 8430
		public string DefaultAbpState;

		// Token: 0x040020EF RID: 8431
		public int? DefaultFaceExpressionId;

		// Token: 0x040020F0 RID: 8432
		public INpcDefaultPerform DefaultPerform;

		// Token: 0x040020F1 RID: 8433
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<INpcSpecialMarkBase> NpcSpecialMarks;

		// Token: 0x040020F2 RID: 8434
		public List<EExtraMovementAbility> ExtraMovementAbilities;
	}
}
