using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200084A RID: 2122
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPerformComponent_SetValue
	{
		// Token: 0x04001ECE RID: 7886
		public bool? Disabled;

		// Token: 0x04001ECF RID: 7887
		public bool? EdIsLocked;

		// Token: 0x04001ED0 RID: 7888
		public IBaseRoleNpcPerform SpecialNpcPerformConfig;

		// Token: 0x04001ED1 RID: 7889
		public bool IsStare;

		// Token: 0x04001ED2 RID: 7890
		public INpcHitShow NpcHitShow;

		// Token: 0x04001ED3 RID: 7891
		public bool IsShowStrike;

		// Token: 0x04001ED4 RID: 7892
		public INpcBumpShow NpcBumpShow;

		// Token: 0x04001ED5 RID: 7893
		public INpcAwakeShow ShowOnAwake;

		// Token: 0x04001ED6 RID: 7894
		public INpcStandbyShowMode ShowOnStandby;

		// Token: 0x04001ED7 RID: 7895
		public INpcPerformOnInteract ShowOnInteract;

		// Token: 0x04001ED8 RID: 7896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IConditionalNpcPerformOnInteract> ConditionalShowOnInteracts;

		// Token: 0x04001ED9 RID: 7897
		public INpcUiInteractType ShowOnUiInteract;

		// Token: 0x04001EDA RID: 7898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcRideInVehiclePerformType> ShowOnRideInVehicle;

		// Token: 0x04001EDB RID: 7899
		public INpcPerformOnMonsterCloseby NpcMonsterClosePerform;

		// Token: 0x04001EDC RID: 7900
		public INpcPerformState NpcPerformState;

		// Token: 0x04001EDD RID: 7901
		public INpcDeathInteract DeathInteract;

		// Token: 0x04001EDE RID: 7902
		public bool? FixedPosition;

		// Token: 0x04001EDF RID: 7903
		public string DefaultAbpState;

		// Token: 0x04001EE0 RID: 7904
		public int? DefaultFaceExpressionId;

		// Token: 0x04001EE1 RID: 7905
		public INpcDefaultPerform DefaultPerform;

		// Token: 0x04001EE2 RID: 7906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INpcSpecialMarkBase> NpcSpecialMarks;
	}
}
