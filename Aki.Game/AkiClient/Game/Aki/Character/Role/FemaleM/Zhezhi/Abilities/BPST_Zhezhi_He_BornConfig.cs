using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.FemaleM.Zhezhi.Abilities
{
	// Token: 0x02004096 RID: 16534
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/Zhezhi/Abilities/BPST_Zhezhi_He_BornConfig.BPST_Zhezhi_He_BornConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct BPST_Zhezhi_He_BornConfig : IEqualityOperators<BPST_Zhezhi_He_BornConfig, BPST_Zhezhi_He_BornConfig, bool>, IEquatable<BPST_Zhezhi_He_BornConfig>, IUnrealScriptStruct
	{
		// Token: 0x0602A964 RID: 174436 RVA: 0x009E5448 File Offset: 0x009E3648
		public BPST_Zhezhi_He_BornConfig(FVector BornOffset, float BornAddRot, int SommonID, int SkillID)
		{
			this.BornOffset = BornOffset;
			this.BornAddRot = BornAddRot;
			this.SommonID = SommonID;
			this.SkillID = SkillID;
		}

		// Token: 0x0602A965 RID: 174437 RVA: 0x009E5468 File Offset: 0x009E3668
		public static bool operator ==(BPST_Zhezhi_He_BornConfig left, BPST_Zhezhi_He_BornConfig right)
		{
			return left.BornOffset == right.BornOffset && left.BornAddRot == right.BornAddRot && left.SommonID == right.SommonID && left.SkillID == right.SkillID;
		}

		// Token: 0x0602A966 RID: 174438 RVA: 0x009E54B4 File Offset: 0x009E36B4
		public static bool operator !=(BPST_Zhezhi_He_BornConfig left, BPST_Zhezhi_He_BornConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0602A967 RID: 174439 RVA: 0x009E54C0 File Offset: 0x009E36C0
		public bool Equals(BPST_Zhezhi_He_BornConfig other)
		{
			return this == other;
		}

		// Token: 0x0602A968 RID: 174440 RVA: 0x009E54D0 File Offset: 0x009E36D0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is BPST_Zhezhi_He_BornConfig)
			{
				BPST_Zhezhi_He_BornConfig other = (BPST_Zhezhi_He_BornConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602A969 RID: 174441 RVA: 0x009E54F5 File Offset: 0x009E36F5
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float, int, int>(this.BornOffset, this.BornAddRot, this.SommonID, this.SkillID);
		}

		// Token: 0x0602A96A RID: 174442 RVA: 0x009E5514 File Offset: 0x009E3714
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BPST_Zhezhi_He_BornConfig._ScriptStructPtr != 0) ? BPST_Zhezhi_He_BornConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/FemaleM/Zhezhi/Abilities/BPST_Zhezhi_He_BornConfig.BPST_Zhezhi_He_BornConfig", ref BPST_Zhezhi_He_BornConfig._ScriptStructPtr);
		}

		// Token: 0x04016060 RID: 90208
		[FieldOffset(0)]
		public FVector BornOffset;

		// Token: 0x04016061 RID: 90209
		[FieldOffset(12)]
		public float BornAddRot;

		// Token: 0x04016062 RID: 90210
		[FieldOffset(16)]
		public int SommonID;

		// Token: 0x04016063 RID: 90211
		[FieldOffset(20)]
		public int SkillID;

		// Token: 0x04016064 RID: 90212
		public const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/Zhezhi/Abilities/BPST_Zhezhi_He_BornConfig.BPST_Zhezhi_He_BornConfig";

		// Token: 0x04016065 RID: 90213
		private static IntPtr _ScriptStructPtr;
	}
}
