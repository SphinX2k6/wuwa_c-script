using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x0200425A RID: 16986
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SInputCaches : IEqualityOperators<SInputCaches, SInputCaches, bool>, IEquatable<SInputCaches>, IUnrealScriptStruct
	{
		// Token: 0x0602C056 RID: 180310 RVA: 0x00A12048 File Offset: 0x00A10248
		public SInputCaches(float 按下, float 抬起, float 长按)
		{
			this.按下 = 按下;
			this.抬起 = 抬起;
			this.长按 = 长按;
		}

		// Token: 0x0602C057 RID: 180311 RVA: 0x00A1205F File Offset: 0x00A1025F
		public static bool operator ==(SInputCaches left, SInputCaches right)
		{
			return left.按下 == right.按下 && left.抬起 == right.抬起 && left.长按 == right.长按;
		}

		// Token: 0x0602C058 RID: 180312 RVA: 0x00A1208D File Offset: 0x00A1028D
		public static bool operator !=(SInputCaches left, SInputCaches right)
		{
			return !(left == right);
		}

		// Token: 0x0602C059 RID: 180313 RVA: 0x00A12099 File Offset: 0x00A10299
		public bool Equals(SInputCaches other)
		{
			return this == other;
		}

		// Token: 0x0602C05A RID: 180314 RVA: 0x00A120A8 File Offset: 0x00A102A8
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

		// Token: 0x0602C05B RID: 180315 RVA: 0x00A120CD File Offset: 0x00A102CD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.按下, this.抬起, this.长按);
		}

		// Token: 0x0602C05C RID: 180316 RVA: 0x00A120E6 File Offset: 0x00A102E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCaches._ScriptStructPtr != 0) ? SInputCaches._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches", ref SInputCaches._ScriptStructPtr);
		}

		// Token: 0x04016FF0 RID: 94192
		[FieldOffset(0)]
		public float 按下;

		// Token: 0x04016FF1 RID: 94193
		[FieldOffset(4)]
		public float 抬起;

		// Token: 0x04016FF2 RID: 94194
		[FieldOffset(8)]
		public float 长按;

		// Token: 0x04016FF3 RID: 94195
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputCaches.SInputCaches";

		// Token: 0x04016FF4 RID: 94196
		private static IntPtr _ScriptStructPtr;
	}
}
