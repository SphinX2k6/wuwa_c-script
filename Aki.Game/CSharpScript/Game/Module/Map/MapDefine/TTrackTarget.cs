using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005589 RID: 21897
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TTrackTarget
	{
		// Token: 0x06037CE7 RID: 228583 RVA: 0x00D396BB File Offset: 0x00D378BB
		public static implicit operator TTrackTarget(AActor value)
		{
			return new TTrackTarget_AActor(value);
		}

		// Token: 0x06037CE8 RID: 228584 RVA: 0x00D396C3 File Offset: 0x00D378C3
		public static implicit operator TTrackTarget(Vector value)
		{
			return new TTrackTarget_Vector(value);
		}

		// Token: 0x06037CE9 RID: 228585 RVA: 0x00D396CB File Offset: 0x00D378CB
		public static implicit operator TTrackTarget(Vector2D value)
		{
			return new TTrackTarget_Vector2D(value);
		}

		// Token: 0x06037CEA RID: 228586 RVA: 0x00D396D3 File Offset: 0x00D378D3
		public static implicit operator TTrackTarget(int value)
		{
			return new TTrackTarget_Int(value);
		}

		// Token: 0x06037CEB RID: 228587 RVA: 0x00D396DB File Offset: 0x00D378DB
		public static implicit operator TTrackTarget(float value)
		{
			return new TTrackTarget_Int((int)value);
		}

		// Token: 0x06037CEC RID: 228588 RVA: 0x00D396E4 File Offset: 0x00D378E4
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
