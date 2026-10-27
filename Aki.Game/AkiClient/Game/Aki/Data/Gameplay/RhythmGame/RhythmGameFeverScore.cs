using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x02003F33 RID: 16179
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFeverScore.RhythmGameFeverScore")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct RhythmGameFeverScore : IEqualityOperators<RhythmGameFeverScore, RhythmGameFeverScore, bool>, IEquatable<RhythmGameFeverScore>, IUnrealScriptStruct
	{
		// Token: 0x06029268 RID: 168552 RVA: 0x009BD02B File Offset: 0x009BB22B
		public RhythmGameFeverScore(int Perfect分数, int Great分数, int Good分数, int Bad分数, int Miss分数)
		{
			this.Perfect分数 = Perfect分数;
			this.Great分数 = Great分数;
			this.Good分数 = Good分数;
			this.Bad分数 = Bad分数;
			this.Miss分数 = Miss分数;
		}

		// Token: 0x06029269 RID: 168553 RVA: 0x009BD054 File Offset: 0x009BB254
		public static bool operator ==(RhythmGameFeverScore left, RhythmGameFeverScore right)
		{
			return left.Perfect分数 == right.Perfect分数 && left.Great分数 == right.Great分数 && left.Good分数 == right.Good分数 && left.Bad分数 == right.Bad分数 && left.Miss分数 == right.Miss分数;
		}

		// Token: 0x0602926A RID: 168554 RVA: 0x009BD0A9 File Offset: 0x009BB2A9
		public static bool operator !=(RhythmGameFeverScore left, RhythmGameFeverScore right)
		{
			return !(left == right);
		}

		// Token: 0x0602926B RID: 168555 RVA: 0x009BD0B5 File Offset: 0x009BB2B5
		public bool Equals(RhythmGameFeverScore other)
		{
			return this == other;
		}

		// Token: 0x0602926C RID: 168556 RVA: 0x009BD0C4 File Offset: 0x009BB2C4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is RhythmGameFeverScore)
			{
				RhythmGameFeverScore other = (RhythmGameFeverScore)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602926D RID: 168557 RVA: 0x009BD0E9 File Offset: 0x009BB2E9
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int, int>(this.Perfect分数, this.Great分数, this.Good分数, this.Bad分数, this.Miss分数);
		}

		// Token: 0x0602926E RID: 168558 RVA: 0x009BD10E File Offset: 0x009BB30E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGameFeverScore._ScriptStructPtr != 0) ? RhythmGameFeverScore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFeverScore.RhythmGameFeverScore", ref RhythmGameFeverScore._ScriptStructPtr);
		}

		// Token: 0x0401511F RID: 86303
		[FieldOffset(0)]
		public int Perfect分数;

		// Token: 0x04015120 RID: 86304
		[FieldOffset(4)]
		public int Great分数;

		// Token: 0x04015121 RID: 86305
		[FieldOffset(8)]
		public int Good分数;

		// Token: 0x04015122 RID: 86306
		[FieldOffset(12)]
		public int Bad分数;

		// Token: 0x04015123 RID: 86307
		[FieldOffset(16)]
		public int Miss分数;

		// Token: 0x04015124 RID: 86308
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGameFeverScore.RhythmGameFeverScore";

		// Token: 0x04015125 RID: 86309
		private static IntPtr _ScriptStructPtr;
	}
}
