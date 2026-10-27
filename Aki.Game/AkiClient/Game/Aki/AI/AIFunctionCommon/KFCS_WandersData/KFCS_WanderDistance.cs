using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004446 RID: 17478
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDistance.KFCS_WanderDistance")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct KFCS_WanderDistance : IEqualityOperators<KFCS_WanderDistance, KFCS_WanderDistance, bool>, IEquatable<KFCS_WanderDistance>, IUnrealScriptStruct
	{
		// Token: 0x0602D3F5 RID: 185333 RVA: 0x00A37A68 File Offset: 0x00A35C68
		public KFCS_WanderDistance(float 近距离边界, float 远距离边界, float 追停距离, float 极近距离边界, float 极远距离界限)
		{
			this.近距离边界 = 近距离边界;
			this.远距离边界 = 远距离边界;
			this.追停距离 = 追停距离;
			this.极近距离边界 = 极近距离边界;
			this.极远距离界限 = 极远距离界限;
		}

		// Token: 0x0602D3F6 RID: 185334 RVA: 0x00A37A90 File Offset: 0x00A35C90
		public static bool operator ==(KFCS_WanderDistance left, KFCS_WanderDistance right)
		{
			return left.近距离边界 == right.近距离边界 && left.远距离边界 == right.远距离边界 && left.追停距离 == right.追停距离 && left.极近距离边界 == right.极近距离边界 && left.极远距离界限 == right.极远距离界限;
		}

		// Token: 0x0602D3F7 RID: 185335 RVA: 0x00A37AE5 File Offset: 0x00A35CE5
		public static bool operator !=(KFCS_WanderDistance left, KFCS_WanderDistance right)
		{
			return !(left == right);
		}

		// Token: 0x0602D3F8 RID: 185336 RVA: 0x00A37AF1 File Offset: 0x00A35CF1
		public bool Equals(KFCS_WanderDistance other)
		{
			return this == other;
		}

		// Token: 0x0602D3F9 RID: 185337 RVA: 0x00A37B00 File Offset: 0x00A35D00
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is KFCS_WanderDistance)
			{
				KFCS_WanderDistance other = (KFCS_WanderDistance)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602D3FA RID: 185338 RVA: 0x00A37B25 File Offset: 0x00A35D25
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.近距离边界, this.远距离边界, this.追停距离, this.极近距离边界, this.极远距离界限);
		}

		// Token: 0x0602D3FB RID: 185339 RVA: 0x00A37B4A File Offset: 0x00A35D4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (KFCS_WanderDistance._ScriptStructPtr != 0) ? KFCS_WanderDistance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDistance.KFCS_WanderDistance", ref KFCS_WanderDistance._ScriptStructPtr);
		}

		// Token: 0x04018123 RID: 98595
		[FieldOffset(0)]
		public float 近距离边界;

		// Token: 0x04018124 RID: 98596
		[FieldOffset(4)]
		public float 远距离边界;

		// Token: 0x04018125 RID: 98597
		[FieldOffset(8)]
		public float 追停距离;

		// Token: 0x04018126 RID: 98598
		[FieldOffset(12)]
		public float 极近距离边界;

		// Token: 0x04018127 RID: 98599
		[FieldOffset(16)]
		public float 极远距离界限;

		// Token: 0x04018128 RID: 98600
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDistance.KFCS_WanderDistance";

		// Token: 0x04018129 RID: 98601
		private static IntPtr _ScriptStructPtr;
	}
}
