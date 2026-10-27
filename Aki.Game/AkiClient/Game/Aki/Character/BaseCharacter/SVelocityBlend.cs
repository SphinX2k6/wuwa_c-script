using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433A RID: 17210
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SVelocityBlend.SVelocityBlend")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SVelocityBlend : IEqualityOperators<SVelocityBlend, SVelocityBlend, bool>, IEquatable<SVelocityBlend>, IUnrealScriptStruct
	{
		// Token: 0x0602CA3A RID: 182842 RVA: 0x00A249E9 File Offset: 0x00A22BE9
		public SVelocityBlend(float 前, float 后, float 左, float 右)
		{
			this.前 = 前;
			this.后 = 后;
			this.左 = 左;
			this.右 = 右;
		}

		// Token: 0x0602CA3B RID: 182843 RVA: 0x00A24A08 File Offset: 0x00A22C08
		public static bool operator ==(SVelocityBlend left, SVelocityBlend right)
		{
			return left.前 == right.前 && left.后 == right.后 && left.左 == right.左 && left.右 == right.右;
		}

		// Token: 0x0602CA3C RID: 182844 RVA: 0x00A24A44 File Offset: 0x00A22C44
		public static bool operator !=(SVelocityBlend left, SVelocityBlend right)
		{
			return !(left == right);
		}

		// Token: 0x0602CA3D RID: 182845 RVA: 0x00A24A50 File Offset: 0x00A22C50
		public bool Equals(SVelocityBlend other)
		{
			return this == other;
		}

		// Token: 0x0602CA3E RID: 182846 RVA: 0x00A24A60 File Offset: 0x00A22C60
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SVelocityBlend)
			{
				SVelocityBlend other = (SVelocityBlend)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602CA3F RID: 182847 RVA: 0x00A24A85 File Offset: 0x00A22C85
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.前, this.后, this.左, this.右);
		}

		// Token: 0x0602CA40 RID: 182848 RVA: 0x00A24AA4 File Offset: 0x00A22CA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVelocityBlend._ScriptStructPtr != 0) ? SVelocityBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SVelocityBlend.SVelocityBlend", ref SVelocityBlend._ScriptStructPtr);
		}

		// Token: 0x0401787B RID: 96379
		[FieldOffset(0)]
		public float 前;

		// Token: 0x0401787C RID: 96380
		[FieldOffset(4)]
		public float 后;

		// Token: 0x0401787D RID: 96381
		[FieldOffset(8)]
		public float 左;

		// Token: 0x0401787E RID: 96382
		[FieldOffset(12)]
		public float 右;

		// Token: 0x0401787F RID: 96383
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SVelocityBlend.SVelocityBlend";

		// Token: 0x04017880 RID: 96384
		private static IntPtr _ScriptStructPtr;
	}
}
