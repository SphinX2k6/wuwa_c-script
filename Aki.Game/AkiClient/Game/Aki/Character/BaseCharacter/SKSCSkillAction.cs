using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004320 RID: 17184
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SKSCSkillAction.SKSCSkillAction")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SKSCSkillAction : IEqualityOperators<SKSCSkillAction, SKSCSkillAction, bool>, IEquatable<SKSCSkillAction>, IUnrealScriptStruct
	{
		// Token: 0x0602C7C8 RID: 182216 RVA: 0x00A20D28 File Offset: 0x00A1EF28
		public SKSCSkillAction(TEnumAsByte<EKSCSkillActionType> ActionType, int SkillIndex)
		{
			this.ActionType = ActionType;
			this.SkillIndex = SkillIndex;
		}

		// Token: 0x0602C7C9 RID: 182217 RVA: 0x00A20D38 File Offset: 0x00A1EF38
		public static bool operator ==(SKSCSkillAction left, SKSCSkillAction right)
		{
			return left.ActionType == right.ActionType && left.SkillIndex == right.SkillIndex;
		}

		// Token: 0x0602C7CA RID: 182218 RVA: 0x00A20D5D File Offset: 0x00A1EF5D
		public static bool operator !=(SKSCSkillAction left, SKSCSkillAction right)
		{
			return !(left == right);
		}

		// Token: 0x0602C7CB RID: 182219 RVA: 0x00A20D69 File Offset: 0x00A1EF69
		public bool Equals(SKSCSkillAction other)
		{
			return this == other;
		}

		// Token: 0x0602C7CC RID: 182220 RVA: 0x00A20D78 File Offset: 0x00A1EF78
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SKSCSkillAction)
			{
				SKSCSkillAction other = (SKSCSkillAction)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C7CD RID: 182221 RVA: 0x00A20D9D File Offset: 0x00A1EF9D
		public override int GetHashCode()
		{
			return HashCode.Combine<TEnumAsByte<EKSCSkillActionType>, int>(this.ActionType, this.SkillIndex);
		}

		// Token: 0x0602C7CE RID: 182222 RVA: 0x00A20DB0 File Offset: 0x00A1EFB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SKSCSkillAction._ScriptStructPtr != 0) ? SKSCSkillAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SKSCSkillAction.SKSCSkillAction", ref SKSCSkillAction._ScriptStructPtr);
		}

		// Token: 0x04017734 RID: 96052
		[FieldOffset(0)]
		public TEnumAsByte<EKSCSkillActionType> ActionType;

		// Token: 0x04017735 RID: 96053
		[FieldOffset(4)]
		public int SkillIndex;

		// Token: 0x04017736 RID: 96054
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SKSCSkillAction.SKSCSkillAction";

		// Token: 0x04017737 RID: 96055
		private static IntPtr _ScriptStructPtr;
	}
}
