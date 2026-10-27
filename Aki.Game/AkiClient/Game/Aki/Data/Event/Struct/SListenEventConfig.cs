using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Event.Struct
{
	// Token: 0x02003F88 RID: 16264
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Event/Struct/SListenEventConfig.SListenEventConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SListenEventConfig : IEqualityOperators<SListenEventConfig, SListenEventConfig, bool>, IEquatable<SListenEventConfig>, IUnrealScriptStruct
	{
		// Token: 0x06029854 RID: 170068 RVA: 0x009C616F File Offset: 0x009C436F
		public SListenEventConfig(int ConditionGroupID, int EventGroupID)
		{
			this.ConditionGroupID = ConditionGroupID;
			this.EventGroupID = EventGroupID;
		}

		// Token: 0x06029855 RID: 170069 RVA: 0x009C617F File Offset: 0x009C437F
		public static bool operator ==(SListenEventConfig left, SListenEventConfig right)
		{
			return left.ConditionGroupID == right.ConditionGroupID && left.EventGroupID == right.EventGroupID;
		}

		// Token: 0x06029856 RID: 170070 RVA: 0x009C619F File Offset: 0x009C439F
		public static bool operator !=(SListenEventConfig left, SListenEventConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06029857 RID: 170071 RVA: 0x009C61AB File Offset: 0x009C43AB
		public bool Equals(SListenEventConfig other)
		{
			return this == other;
		}

		// Token: 0x06029858 RID: 170072 RVA: 0x009C61BC File Offset: 0x009C43BC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SListenEventConfig)
			{
				SListenEventConfig other = (SListenEventConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029859 RID: 170073 RVA: 0x009C61E1 File Offset: 0x009C43E1
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.ConditionGroupID, this.EventGroupID);
		}

		// Token: 0x0602985A RID: 170074 RVA: 0x009C61F4 File Offset: 0x009C43F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SListenEventConfig._ScriptStructPtr != 0) ? SListenEventConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Event/Struct/SListenEventConfig.SListenEventConfig", ref SListenEventConfig._ScriptStructPtr);
		}

		// Token: 0x04015487 RID: 87175
		[FieldOffset(0)]
		public int ConditionGroupID;

		// Token: 0x04015488 RID: 87176
		[FieldOffset(4)]
		public int EventGroupID;

		// Token: 0x04015489 RID: 87177
		public const string __ObjectPath = "/Game/Aki/Data/Event/Struct/SListenEventConfig.SListenEventConfig";

		// Token: 0x0401548A RID: 87178
		private static IntPtr _ScriptStructPtr;
	}
}
