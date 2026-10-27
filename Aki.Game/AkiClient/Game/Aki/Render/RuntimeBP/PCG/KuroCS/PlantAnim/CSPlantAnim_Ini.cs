using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.PlantAnim
{
	// Token: 0x02003C89 RID: 15497
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 40)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/CSPlantAnim_Ini.CSPlantAnim_Ini")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 40)]
	public struct CSPlantAnim_Ini : IEqualityOperators<CSPlantAnim_Ini, CSPlantAnim_Ini, bool>, IEquatable<CSPlantAnim_Ini>, IUnrealScriptStruct
	{
		// Token: 0x060242F1 RID: 148209 RVA: 0x00937344 File Offset: 0x00935544
		public CSPlantAnim_Ini(int ID, FVector P, FVector N, FVector DIr)
		{
			this.ID = ID;
			this.P = P;
			this.N = N;
			this.DIr = DIr;
		}

		// Token: 0x060242F2 RID: 148210 RVA: 0x00937364 File Offset: 0x00935564
		public static bool operator ==(CSPlantAnim_Ini left, CSPlantAnim_Ini right)
		{
			return left.ID == right.ID && left.P == right.P && left.N == right.N && left.DIr == right.DIr;
		}

		// Token: 0x060242F3 RID: 148211 RVA: 0x009373B8 File Offset: 0x009355B8
		public static bool operator !=(CSPlantAnim_Ini left, CSPlantAnim_Ini right)
		{
			return !(left == right);
		}

		// Token: 0x060242F4 RID: 148212 RVA: 0x009373C4 File Offset: 0x009355C4
		public bool Equals(CSPlantAnim_Ini other)
		{
			return this == other;
		}

		// Token: 0x060242F5 RID: 148213 RVA: 0x009373D4 File Offset: 0x009355D4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is CSPlantAnim_Ini)
			{
				CSPlantAnim_Ini other = (CSPlantAnim_Ini)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060242F6 RID: 148214 RVA: 0x009373F9 File Offset: 0x009355F9
		public override int GetHashCode()
		{
			return HashCode.Combine<int, FVector, FVector, FVector>(this.ID, this.P, this.N, this.DIr);
		}

		// Token: 0x060242F7 RID: 148215 RVA: 0x00937418 File Offset: 0x00935618
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (CSPlantAnim_Ini._ScriptStructPtr != 0) ? CSPlantAnim_Ini._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/CSPlantAnim_Ini.CSPlantAnim_Ini", ref CSPlantAnim_Ini._ScriptStructPtr);
		}

		// Token: 0x04011EBF RID: 73407
		[FieldOffset(0)]
		public int ID;

		// Token: 0x04011EC0 RID: 73408
		[FieldOffset(4)]
		public FVector P;

		// Token: 0x04011EC1 RID: 73409
		[FieldOffset(16)]
		public FVector N;

		// Token: 0x04011EC2 RID: 73410
		[FieldOffset(28)]
		public FVector DIr;

		// Token: 0x04011EC3 RID: 73411
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/CSPlantAnim_Ini.CSPlantAnim_Ini";

		// Token: 0x04011EC4 RID: 73412
		private static IntPtr _ScriptStructPtr;
	}
}
