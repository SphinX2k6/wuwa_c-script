using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.PathPoints
{
	// Token: 0x02003E5C RID: 15964
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathPoints/SNpcPathPoint.SNpcPathPoint")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SNpcPathPoint : IEqualityOperators<SNpcPathPoint, SNpcPathPoint, bool>, IEquatable<SNpcPathPoint>, IUnrealScriptStruct
	{
		// Token: 0x0602822F RID: 164399 RVA: 0x009A4FCC File Offset: 0x009A31CC
		public SNpcPathPoint(FName LandName, FVector Position)
		{
			this.LandName = LandName;
			this.Position = Position;
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x009A4FDC File Offset: 0x009A31DC
		public static bool operator ==(SNpcPathPoint left, SNpcPathPoint right)
		{
			return left.LandName == right.LandName && left.Position == right.Position;
		}

		// Token: 0x06028231 RID: 164401 RVA: 0x009A5004 File Offset: 0x009A3204
		public static bool operator !=(SNpcPathPoint left, SNpcPathPoint right)
		{
			return !(left == right);
		}

		// Token: 0x06028232 RID: 164402 RVA: 0x009A5010 File Offset: 0x009A3210
		public bool Equals(SNpcPathPoint other)
		{
			return this == other;
		}

		// Token: 0x06028233 RID: 164403 RVA: 0x009A5020 File Offset: 0x009A3220
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SNpcPathPoint)
			{
				SNpcPathPoint other = (SNpcPathPoint)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028234 RID: 164404 RVA: 0x009A5045 File Offset: 0x009A3245
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FVector>(this.LandName, this.Position);
		}

		// Token: 0x06028235 RID: 164405 RVA: 0x009A5058 File Offset: 0x009A3258
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcPathPoint._ScriptStructPtr != 0) ? SNpcPathPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/PathPoints/SNpcPathPoint.SNpcPathPoint", ref SNpcPathPoint._ScriptStructPtr);
		}

		// Token: 0x040146DA RID: 83674
		[FieldOffset(0)]
		public FName LandName;

		// Token: 0x040146DB RID: 83675
		[FieldOffset(12)]
		public FVector Position;

		// Token: 0x040146DC RID: 83676
		public const string __ObjectPath = "/Game/Aki/GamePlay/PathPoints/SNpcPathPoint.SNpcPathPoint";

		// Token: 0x040146DD RID: 83677
		private static IntPtr _ScriptStructPtr;
	}
}
