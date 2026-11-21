using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200455F RID: 17759
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TTrackTarget
	{
		// Token: 0x0602CBE5 RID: 183269 RVA: 0x00C87393 File Offset: 0x00C85593
		public static implicit operator TTrackTarget(AActor value)
		{
			return new TTrackTarget_AActor(value);
		}

		// Token: 0x0602CBE6 RID: 183270 RVA: 0x00C8739B File Offset: 0x00C8559B
		public static implicit operator TTrackTarget(Vector value)
		{
			return new TTrackTarget_Vector(value);
		}

		// Token: 0x0602CBE7 RID: 183271 RVA: 0x00C873A3 File Offset: 0x00C855A3
		public static implicit operator TTrackTarget(Vector2D value)
		{
			return new TTrackTarget_Vector2D(value);
		}

		// Token: 0x0602CBE8 RID: 183272 RVA: 0x00C873AB File Offset: 0x00C855AB
		public static implicit operator TTrackTarget(int value)
		{
			return new TTrackTarget_Int(value);
		}

		// Token: 0x0602CBE9 RID: 183273 RVA: 0x00C873B3 File Offset: 0x00C855B3
		public static implicit operator TTrackTarget(float value)
		{
			return new TTrackTarget_Int((int)value);
		}

		// Token: 0x0602CBEA RID: 183274 RVA: 0x00C873BC File Offset: 0x00C855BC
		[NullableContext(2)]
		public static implicit operator TEntityIdOrPos(TTrackTarget value)
		{
			TTrackTarget_Vector ttrackTarget_Vector = value as TTrackTarget_Vector;
			if (ttrackTarget_Vector != null)
			{
				return new TEntityIdOrPos_Vector(ttrackTarget_Vector);
			}
			TTrackTarget_Int ttrackTarget_Int = value as TTrackTarget_Int;
			if (ttrackTarget_Int != null)
			{
				return new TEntityIdOrPos_Int(ttrackTarget_Int);
			}
			return null;
		}
	}
}
