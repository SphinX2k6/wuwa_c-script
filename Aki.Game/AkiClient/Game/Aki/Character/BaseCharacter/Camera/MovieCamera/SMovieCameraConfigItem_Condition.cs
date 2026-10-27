using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DC RID: 17372
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_Condition.SMovieCameraConfigItem_Condition")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct SMovieCameraConfigItem_Condition : IEqualityOperators<SMovieCameraConfigItem_Condition, SMovieCameraConfigItem_Condition, bool>, IEquatable<SMovieCameraConfigItem_Condition>, IUnrealScriptStruct
	{
		// Token: 0x0602CFFF RID: 184319 RVA: 0x00A2E189 File Offset: 0x00A2C389
		public SMovieCameraConfigItem_Condition(TEnumAsByte<EMovieCameraItem_ConditionType> ConditionType)
		{
			this.ConditionType = ConditionType;
		}

		// Token: 0x0602D000 RID: 184320 RVA: 0x00A2E192 File Offset: 0x00A2C392
		public static bool operator ==(SMovieCameraConfigItem_Condition left, SMovieCameraConfigItem_Condition right)
		{
			return left.ConditionType == right.ConditionType;
		}

		// Token: 0x0602D001 RID: 184321 RVA: 0x00A2E1A5 File Offset: 0x00A2C3A5
		public static bool operator !=(SMovieCameraConfigItem_Condition left, SMovieCameraConfigItem_Condition right)
		{
			return !(left == right);
		}

		// Token: 0x0602D002 RID: 184322 RVA: 0x00A2E1B1 File Offset: 0x00A2C3B1
		public bool Equals(SMovieCameraConfigItem_Condition other)
		{
			return this == other;
		}

		// Token: 0x0602D003 RID: 184323 RVA: 0x00A2E1C0 File Offset: 0x00A2C3C0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMovieCameraConfigItem_Condition)
			{
				SMovieCameraConfigItem_Condition other = (SMovieCameraConfigItem_Condition)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602D004 RID: 184324 RVA: 0x00A2E1E5 File Offset: 0x00A2C3E5
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EMovieCameraItem_ConditionType>>(this.ConditionType);
		}

		// Token: 0x0602D005 RID: 184325 RVA: 0x00A2E1F2 File Offset: 0x00A2C3F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_Condition._ScriptStructPtr != 0) ? SMovieCameraConfigItem_Condition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_Condition.SMovieCameraConfigItem_Condition", ref SMovieCameraConfigItem_Condition._ScriptStructPtr);
		}

		// Token: 0x04017E1A RID: 97818
		[FieldOffset(0)]
		public TEnumAsByte<EMovieCameraItem_ConditionType> ConditionType;

		// Token: 0x04017E1B RID: 97819
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_Condition.SMovieCameraConfigItem_Condition";

		// Token: 0x04017E1C RID: 97820
		private static IntPtr _ScriptStructPtr;
	}
}
