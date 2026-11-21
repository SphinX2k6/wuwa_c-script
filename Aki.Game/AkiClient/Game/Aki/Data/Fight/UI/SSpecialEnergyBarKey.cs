using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FE RID: 12798
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SSpecialEnergyBarKey : IEqualityOperators<SSpecialEnergyBarKey, SSpecialEnergyBarKey, bool>, IEquatable<SSpecialEnergyBarKey>, IUnrealScriptStruct
	{
		// Token: 0x0601FDB8 RID: 130488 RVA: 0x00937811 File Offset: 0x00935A11
		public SSpecialEnergyBarKey(int Action, int ActionType)
		{
			this.Action = Action;
			this.ActionType = ActionType;
		}

		// Token: 0x0601FDB9 RID: 130489 RVA: 0x00937821 File Offset: 0x00935A21
		public static bool operator ==(SSpecialEnergyBarKey left, SSpecialEnergyBarKey right)
		{
			return left.Action == right.Action && left.ActionType == right.ActionType;
		}

		// Token: 0x0601FDBA RID: 130490 RVA: 0x00937841 File Offset: 0x00935A41
		public static bool operator !=(SSpecialEnergyBarKey left, SSpecialEnergyBarKey right)
		{
			return !(left == right);
		}

		// Token: 0x0601FDBB RID: 130491 RVA: 0x0093784D File Offset: 0x00935A4D
		public bool Equals(SSpecialEnergyBarKey other)
		{
			return this == other;
		}

		// Token: 0x0601FDBC RID: 130492 RVA: 0x0093785C File Offset: 0x00935A5C
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

		// Token: 0x0601FDBD RID: 130493 RVA: 0x00937881 File Offset: 0x00935A81
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Action, this.ActionType);
		}

		// Token: 0x0601FDBE RID: 130494 RVA: 0x00937894 File Offset: 0x00935A94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialEnergyBarKey._ScriptStructPtr != 0) ? SSpecialEnergyBarKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey", ref SSpecialEnergyBarKey._ScriptStructPtr);
		}

		// Token: 0x040111B5 RID: 70069
		[FieldOffset(0)]
		public int Action;

		// Token: 0x040111B6 RID: 70070
		[FieldOffset(4)]
		public int ActionType;

		// Token: 0x040111B7 RID: 70071
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SSpecialEnergyBarKey.SSpecialEnergyBarKey";

		// Token: 0x040111B8 RID: 70072
		private static IntPtr _ScriptStructPtr;
	}
}
