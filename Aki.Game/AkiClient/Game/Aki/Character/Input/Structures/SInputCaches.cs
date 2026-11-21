using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x020032CE RID: 13006
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SInputCaches : IEqualityOperators<SInputCaches, SInputCaches, bool>, IEquatable<SInputCaches>, IUnrealScriptStruct
	{
		// Token: 0x06020F3F RID: 134975 RVA: 0x0095365C File Offset: 0x0095185C
		public SInputCaches(float 按下, float 抬起, float 长按)
		{
			this.按下 = 按下;
			this.抬起 = 抬起;
			this.长按 = 长按;
		}

		// Token: 0x06020F40 RID: 134976 RVA: 0x00953673 File Offset: 0x00951873
		public static bool operator ==(SInputCaches left, SInputCaches right)
		{
			return left.按下 == right.按下 && left.抬起 == right.抬起 && left.长按 == right.长按;
		}

		// Token: 0x06020F41 RID: 134977 RVA: 0x009536A1 File Offset: 0x009518A1
		public static bool operator !=(SInputCaches left, SInputCaches right)
		{
			return !(left == right);
		}

		// Token: 0x06020F42 RID: 134978 RVA: 0x009536AD File Offset: 0x009518AD
		public bool Equals(SInputCaches other)
		{
			return this == other;
		}

		// Token: 0x06020F43 RID: 134979 RVA: 0x009536BC File Offset: 0x009518BC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SInputCaches)
			{
				SInputCaches other = (SInputCaches)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06020F44 RID: 134980 RVA: 0x009536E1 File Offset: 0x009518E1
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.按下, this.抬起, this.长按);
		}

		// Token: 0x06020F45 RID: 134981 RVA: 0x009536FA File Offset: 0x009518FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCaches._ScriptStructPtr != 0) ? SInputCaches._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches", ref SInputCaches._ScriptStructPtr);
		}

		// Token: 0x04011D9E RID: 73118
		[FieldOffset(0)]
		public float 按下;

		// Token: 0x04011D9F RID: 73119
		[FieldOffset(4)]
		public float 抬起;

		// Token: 0x04011DA0 RID: 73120
		[FieldOffset(8)]
		public float 长按;

		// Token: 0x04011DA1 RID: 73121
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches";

		// Token: 0x04011DA2 RID: 73122
		private static IntPtr _ScriptStructPtr;
	}
}
