using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Enum
{
	// Token: 0x020040B4 RID: 16564
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Enum/EPerformanceRoleState.EPerformanceRoleState")]
	public enum EPerformanceRoleState : byte
	{
		// Token: 0x04016261 RID: 90721
		None,
		// Token: 0x04016262 RID: 90722
		Attribute,
		// Token: 0x04016263 RID: 90723
		Attribute_Inten,
		// Token: 0x04016264 RID: 90724
		Attribute_Perform,
		// Token: 0x04016265 RID: 90725
		Skill_Head,
		// Token: 0x04016266 RID: 90726
		Skill,
		// Token: 0x04016267 RID: 90727
		Weapon,
		// Token: 0x04016268 RID: 90728
		Resonance,
		// Token: 0x04016269 RID: 90729
		Chip,
		// Token: 0x0401626A RID: 90730
		CreateRole_Forward,
		// Token: 0x0401626B RID: 90731
		CreateRole_Back,
		// Token: 0x0401626C RID: 90732
		CreateRole_Idle,
		// Token: 0x0401626D RID: 90733
		RoleBreach,
		// Token: 0x0401626E RID: 90734
		Favor,
		// Token: 0x0401626F RID: 90735
		Favor_Experience,
		// Token: 0x04016270 RID: 90736
		Favor_Voice,
		// Token: 0x04016271 RID: 90737
		Favor_Action,
		// Token: 0x04016272 RID: 90738
		CreateRole_Head,
		// Token: 0x04016273 RID: 90739
		CreateRole_Login,
		// Token: 0x04016274 RID: 90740
		RoleElement,
		// Token: 0x04016275 RID: 90741
		RoleElement_Stand,
		// Token: 0x04016276 RID: 90742
		RoleElement_End,
		// Token: 0x04016277 RID: 90743
		EPerformanceRoleState_MAX
	}
}
