using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003EA1 RID: 16033
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleSkillTypeInfo.SRoleSkillTypeInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SRoleSkillTypeInfo : IEqualityOperators<SRoleSkillTypeInfo, SRoleSkillTypeInfo, bool>, IEquatable<SRoleSkillTypeInfo>, IUnrealScriptStruct
	{
		// Token: 0x060288F1 RID: 166129 RVA: 0x009AF284 File Offset: 0x009AD484
		public SRoleSkillTypeInfo(FName 技能类别名称)
		{
			this.技能类别名称 = 技能类别名称;
		}

		// Token: 0x060288F2 RID: 166130 RVA: 0x009AF28D File Offset: 0x009AD48D
		public static bool operator ==(SRoleSkillTypeInfo left, SRoleSkillTypeInfo right)
		{
			return left.技能类别名称 == right.技能类别名称;
		}

		// Token: 0x060288F3 RID: 166131 RVA: 0x009AF2A0 File Offset: 0x009AD4A0
		public static bool operator !=(SRoleSkillTypeInfo left, SRoleSkillTypeInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060288F4 RID: 166132 RVA: 0x009AF2AC File Offset: 0x009AD4AC
		public bool Equals(SRoleSkillTypeInfo other)
		{
			return this == other;
		}

		// Token: 0x060288F5 RID: 166133 RVA: 0x009AF2BC File Offset: 0x009AD4BC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SRoleSkillTypeInfo)
			{
				SRoleSkillTypeInfo other = (SRoleSkillTypeInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060288F6 RID: 166134 RVA: 0x009AF2E1 File Offset: 0x009AD4E1
		public override int GetHashCode()
		{
			return HashCode.Combine<FName>(this.技能类别名称);
		}

		// Token: 0x060288F7 RID: 166135 RVA: 0x009AF2EE File Offset: 0x009AD4EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSkillTypeInfo._ScriptStructPtr != 0) ? SRoleSkillTypeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleSkillTypeInfo.SRoleSkillTypeInfo", ref SRoleSkillTypeInfo._ScriptStructPtr);
		}

		// Token: 0x04014AF8 RID: 84728
		[FieldOffset(0)]
		public FName 技能类别名称;

		// Token: 0x04014AF9 RID: 84729
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleSkillTypeInfo.SRoleSkillTypeInfo";

		// Token: 0x04014AFA RID: 84730
		private static IntPtr _ScriptStructPtr;
	}
}
