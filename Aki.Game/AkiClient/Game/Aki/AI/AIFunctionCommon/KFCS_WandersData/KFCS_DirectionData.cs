using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004444 RID: 17476
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_DirectionData.KFCS_DirectionData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct KFCS_DirectionData : IEqualityOperators<KFCS_DirectionData, KFCS_DirectionData, bool>, IEquatable<KFCS_DirectionData>, IUnrealScriptStruct
	{
		// Token: 0x0602D3C2 RID: 185282 RVA: 0x00A37610 File Offset: 0x00A35810
		public KFCS_DirectionData(float 前走转向速度, float 后走转向速度, float 左走转向速度, float 右走转向速度, float 前跑转向速度)
		{
			this.前走转向速度 = 前走转向速度;
			this.后走转向速度 = 后走转向速度;
			this.左走转向速度 = 左走转向速度;
			this.右走转向速度 = 右走转向速度;
			this.前跑转向速度 = 前跑转向速度;
		}

		// Token: 0x0602D3C3 RID: 185283 RVA: 0x00A37638 File Offset: 0x00A35838
		public static bool operator ==(KFCS_DirectionData left, KFCS_DirectionData right)
		{
			return left.前走转向速度 == right.前走转向速度 && left.后走转向速度 == right.后走转向速度 && left.左走转向速度 == right.左走转向速度 && left.右走转向速度 == right.右走转向速度 && left.前跑转向速度 == right.前跑转向速度;
		}

		// Token: 0x0602D3C4 RID: 185284 RVA: 0x00A3768D File Offset: 0x00A3588D
		public static bool operator !=(KFCS_DirectionData left, KFCS_DirectionData right)
		{
			return !(left == right);
		}

		// Token: 0x0602D3C5 RID: 185285 RVA: 0x00A37699 File Offset: 0x00A35899
		public bool Equals(KFCS_DirectionData other)
		{
			return this == other;
		}

		// Token: 0x0602D3C6 RID: 185286 RVA: 0x00A376A8 File Offset: 0x00A358A8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is KFCS_DirectionData)
			{
				KFCS_DirectionData other = (KFCS_DirectionData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602D3C7 RID: 185287 RVA: 0x00A376CD File Offset: 0x00A358CD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, float>(this.前走转向速度, this.后走转向速度, this.左走转向速度, this.右走转向速度, this.前跑转向速度);
		}

		// Token: 0x0602D3C8 RID: 185288 RVA: 0x00A376F2 File Offset: 0x00A358F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (KFCS_DirectionData._ScriptStructPtr != 0) ? KFCS_DirectionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_DirectionData.KFCS_DirectionData", ref KFCS_DirectionData._ScriptStructPtr);
		}

		// Token: 0x04018108 RID: 98568
		[FieldOffset(0)]
		public float 前走转向速度;

		// Token: 0x04018109 RID: 98569
		[FieldOffset(4)]
		public float 后走转向速度;

		// Token: 0x0401810A RID: 98570
		[FieldOffset(8)]
		public float 左走转向速度;

		// Token: 0x0401810B RID: 98571
		[FieldOffset(12)]
		public float 右走转向速度;

		// Token: 0x0401810C RID: 98572
		[FieldOffset(16)]
		public float 前跑转向速度;

		// Token: 0x0401810D RID: 98573
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_DirectionData.KFCS_DirectionData";

		// Token: 0x0401810E RID: 98574
		private static IntPtr _ScriptStructPtr;
	}
}
