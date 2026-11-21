using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Enum
{
	// Token: 0x020032A8 RID: 12968
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Enum/EPerformanceRoleState.EPerformanceRoleState")]
	public enum EPerformanceRoleState : byte
	{
		// Token: 0x04011A1A RID: 72218
		None,
		// Token: 0x04011A1B RID: 72219
		Attribute,
		// Token: 0x04011A1C RID: 72220
		Attribute_Inten,
		// Token: 0x04011A1D RID: 72221
		Attribute_Perform,
		// Token: 0x04011A1E RID: 72222
		Skill_Head,
		// Token: 0x04011A1F RID: 72223
		Skill,
		// Token: 0x04011A20 RID: 72224
		Weapon,
		// Token: 0x04011A21 RID: 72225
		Resonance,
		// Token: 0x04011A22 RID: 72226
		Chip,
		// Token: 0x04011A23 RID: 72227
		CreateRole_Forward,
		// Token: 0x04011A24 RID: 72228
		CreateRole_Back,
		// Token: 0x04011A25 RID: 72229
		CreateRole_Idle,
		// Token: 0x04011A26 RID: 72230
		RoleBreach,
		// Token: 0x04011A27 RID: 72231
		Favor,
		// Token: 0x04011A28 RID: 72232
		Favor_Experience,
		// Token: 0x04011A29 RID: 72233
		Favor_Voice,
		// Token: 0x04011A2A RID: 72234
		Favor_Action,
		// Token: 0x04011A2B RID: 72235
		CreateRole_Head,
		// Token: 0x04011A2C RID: 72236
		CreateRole_Login,
		// Token: 0x04011A2D RID: 72237
		RoleElement,
		// Token: 0x04011A2E RID: 72238
		RoleElement_Stand,
		// Token: 0x04011A2F RID: 72239
		RoleElement_End,
		// Token: 0x04011A30 RID: 72240
		EPerformanceRoleState_MAX
	}
}
