using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F5B RID: 16219
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SSpecialEnergyBarKey : IEqualityOperators<SSpecialEnergyBarKey, SSpecialEnergyBarKey, bool>, IEquatable<SSpecialEnergyBarKey>, IUnrealScriptStruct
	{
		// Token: 0x06029510 RID: 169232 RVA: 0x009C11AE File Offset: 0x009BF3AE
		public SSpecialEnergyBarKey(int Action, int ActionType)
		{
			this.Action = Action;
			this.ActionType = ActionType;
		}

		// Token: 0x06029511 RID: 169233 RVA: 0x009C11BE File Offset: 0x009BF3BE
		public static bool operator ==(SSpecialEnergyBarKey left, SSpecialEnergyBarKey right)
		{
			return left.Action == right.Action && left.ActionType == right.ActionType;
		}

		// Token: 0x06029512 RID: 169234 RVA: 0x009C11DE File Offset: 0x009BF3DE
		public static bool operator !=(SSpecialEnergyBarKey left, SSpecialEnergyBarKey right)
		{
			return !(left == right);
		}

		// Token: 0x06029513 RID: 169235 RVA: 0x009C11EA File Offset: 0x009BF3EA
		public bool Equals(SSpecialEnergyBarKey other)
		{
			return this == other;
		}

		// Token: 0x06029514 RID: 169236 RVA: 0x009C11F8 File Offset: 0x009BF3F8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSpecialEnergyBarKey)
			{
				SSpecialEnergyBarKey other = (SSpecialEnergyBarKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029515 RID: 169237 RVA: 0x009C121D File Offset: 0x009BF41D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Action, this.ActionType);
		}

		// Token: 0x06029516 RID: 169238 RVA: 0x009C1230 File Offset: 0x009BF430
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBarKey._ScriptStructPtr != 0) ? SSpecialEnergyBarKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey", ref SSpecialEnergyBarKey._ScriptStructPtr);
		}

		// Token: 0x040152AE RID: 86702
		[FieldOffset(0)]
		public int Action;

		// Token: 0x040152AF RID: 86703
		[FieldOffset(4)]
		public int ActionType;

		// Token: 0x040152B0 RID: 86704
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey";

		// Token: 0x040152B1 RID: 86705
		private static IntPtr _ScriptStructPtr;
	}
}
