using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs
{
	// Token: 0x02003BC9 RID: 15305
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 68)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/Configs/SCommonRainSpawnerConfig.SCommonRainSpawnerConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 68)]
	public struct SCommonRainSpawnerConfig : IEqualityOperators<SCommonRainSpawnerConfig, SCommonRainSpawnerConfig, bool>, IEquatable<SCommonRainSpawnerConfig>, IUnrealScriptStruct
	{
		// Token: 0x06022511 RID: 140561 RVA: 0x00905798 File Offset: 0x00903998
		public SCommonRainSpawnerConfig(int Index, bool UseArraySpawner, int ArraySize, float ArrayLength, float ArraySpawnerRate, float ArraySpawnerTimeWiggle, float ArraySpawnerPositionWiggle, bool UseRandomSpawner, float RandomSpawnRate, float RandomSpawnInnerRadius, float RandomSpawnOuterRadius, float LifeTimeMin, float LifeTimeMax, float ScaleMin, float ScaleMax, float BaseMassMin, float BaseMassMax)
		{
			this.Index = Index;
			this.UseArraySpawner = UseArraySpawner;
			this.ArraySize = ArraySize;
			this.ArrayLength = ArrayLength;
			this.ArraySpawnerRate = ArraySpawnerRate;
			this.ArraySpawnerTimeWiggle = ArraySpawnerTimeWiggle;
			this.ArraySpawnerPositionWiggle = ArraySpawnerPositionWiggle;
			this.UseRandomSpawner = UseRandomSpawner;
			this.RandomSpawnRate = RandomSpawnRate;
			this.RandomSpawnInnerRadius = RandomSpawnInnerRadius;
			this.RandomSpawnOuterRadius = RandomSpawnOuterRadius;
			this.LifeTimeMin = LifeTimeMin;
			this.LifeTimeMax = LifeTimeMax;
			this.ScaleMin = ScaleMin;
			this.ScaleMax = ScaleMax;
			this.BaseMassMin = BaseMassMin;
			this.BaseMassMax = BaseMassMax;
		}

		// Token: 0x06022512 RID: 140562 RVA: 0x0090582C File Offset: 0x00903A2C
		public static bool operator ==(SCommonRainSpawnerConfig left, SCommonRainSpawnerConfig right)
		{
			return left.Index == right.Index && left.UseArraySpawner == right.UseArraySpawner && left.ArraySize == right.ArraySize && left.ArrayLength == right.ArrayLength && left.ArraySpawnerRate == right.ArraySpawnerRate && left.ArraySpawnerTimeWiggle == right.ArraySpawnerTimeWiggle && left.ArraySpawnerPositionWiggle == right.ArraySpawnerPositionWiggle && left.UseRandomSpawner == right.UseRandomSpawner && left.RandomSpawnRate == right.RandomSpawnRate && left.RandomSpawnInnerRadius == right.RandomSpawnInnerRadius && left.RandomSpawnOuterRadius == right.RandomSpawnOuterRadius && left.LifeTimeMin == right.LifeTimeMin && left.LifeTimeMax == right.LifeTimeMax && left.ScaleMin == right.ScaleMin && left.ScaleMax == right.ScaleMax && left.BaseMassMin == right.BaseMassMin && left.BaseMassMax == right.BaseMassMax;
		}

		// Token: 0x06022513 RID: 140563 RVA: 0x0090593E File Offset: 0x00903B3E
		public static bool operator !=(SCommonRainSpawnerConfig left, SCommonRainSpawnerConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06022514 RID: 140564 RVA: 0x0090594A File Offset: 0x00903B4A
		public bool Equals(SCommonRainSpawnerConfig other)
		{
			return this == other;
		}

		// Token: 0x06022515 RID: 140565 RVA: 0x00905958 File Offset: 0x00903B58
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SCommonRainSpawnerConfig)
			{
				SCommonRainSpawnerConfig other = (SCommonRainSpawnerConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06022516 RID: 140566 RVA: 0x00905980 File Offset: 0x00903B80
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<int>(this.Index);
			hashCode.Add<bool>(this.UseArraySpawner);
			hashCode.Add<int>(this.ArraySize);
			hashCode.Add<float>(this.ArrayLength);
			hashCode.Add<float>(this.ArraySpawnerRate);
			hashCode.Add<float>(this.ArraySpawnerTimeWiggle);
			hashCode.Add<float>(this.ArraySpawnerPositionWiggle);
			hashCode.Add<bool>(this.UseRandomSpawner);
			hashCode.Add<float>(this.RandomSpawnRate);
			hashCode.Add<float>(this.RandomSpawnInnerRadius);
			hashCode.Add<float>(this.RandomSpawnOuterRadius);
			hashCode.Add<float>(this.LifeTimeMin);
			hashCode.Add<float>(this.LifeTimeMax);
			hashCode.Add<float>(this.ScaleMin);
			hashCode.Add<float>(this.ScaleMax);
			hashCode.Add<float>(this.BaseMassMin);
			hashCode.Add<float>(this.BaseMassMax);
			return hashCode.ToHashCode();
		}

		// Token: 0x06022517 RID: 140567 RVA: 0x00905A79 File Offset: 0x00903C79
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonRainSpawnerConfig._ScriptStructPtr != 0) ? SCommonRainSpawnerConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Rain2/Configs/SCommonRainSpawnerConfig.SCommonRainSpawnerConfig", ref SCommonRainSpawnerConfig._ScriptStructPtr);
		}

		// Token: 0x04010D4A RID: 68938
		[FieldOffset(0)]
		public int Index;

		// Token: 0x04010D4B RID: 68939
		[FieldOffset(4)]
		public bool UseArraySpawner;

		// Token: 0x04010D4C RID: 68940
		[FieldOffset(8)]
		public int ArraySize;

		// Token: 0x04010D4D RID: 68941
		[FieldOffset(12)]
		public float ArrayLength;

		// Token: 0x04010D4E RID: 68942
		[FieldOffset(16)]
		public float ArraySpawnerRate;

		// Token: 0x04010D4F RID: 68943
		[FieldOffset(20)]
		public float ArraySpawnerTimeWiggle;

		// Token: 0x04010D50 RID: 68944
		[FieldOffset(24)]
		public float ArraySpawnerPositionWiggle;

		// Token: 0x04010D51 RID: 68945
		[FieldOffset(28)]
		public bool UseRandomSpawner;

		// Token: 0x04010D52 RID: 68946
		[FieldOffset(32)]
		public float RandomSpawnRate;

		// Token: 0x04010D53 RID: 68947
		[FieldOffset(36)]
		public float RandomSpawnInnerRadius;

		// Token: 0x04010D54 RID: 68948
		[FieldOffset(40)]
		public float RandomSpawnOuterRadius;

		// Token: 0x04010D55 RID: 68949
		[FieldOffset(44)]
		public float LifeTimeMin;

		// Token: 0x04010D56 RID: 68950
		[FieldOffset(48)]
		public float LifeTimeMax;

		// Token: 0x04010D57 RID: 68951
		[FieldOffset(52)]
		public float ScaleMin;

		// Token: 0x04010D58 RID: 68952
		[FieldOffset(56)]
		public float ScaleMax;

		// Token: 0x04010D59 RID: 68953
		[FieldOffset(60)]
		public float BaseMassMin;

		// Token: 0x04010D5A RID: 68954
		[FieldOffset(64)]
		public float BaseMassMax;

		// Token: 0x04010D5B RID: 68955
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/Configs/SCommonRainSpawnerConfig.SCommonRainSpawnerConfig";

		// Token: 0x04010D5C RID: 68956
		private static IntPtr _ScriptStructPtr;
	}
}
