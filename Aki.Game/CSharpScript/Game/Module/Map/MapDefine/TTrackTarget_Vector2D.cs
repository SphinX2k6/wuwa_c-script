using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200558C RID: 21900
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Vector2D : TTrackTarget
	{
		// Token: 0x06037CF6 RID: 228598 RVA: 0x00D397A4 File Offset: 0x00D379A4
		public TTrackTarget_Vector2D(Vector2D Value)
		{
		}

		// Token: 0x06037CF7 RID: 228599 RVA: 0x00D397B3 File Offset: 0x00D379B3
		public static implicit operator Vector2D(TTrackTarget_Vector2D target)
		{
			return target.Value;
		}

		// Token: 0x06037CF8 RID: 228600 RVA: 0x00D397BB File Offset: 0x00D379BB
		public new static implicit operator TTrackTarget_Vector2D(Vector2D value)
		{
			return new TTrackTarget_Vector2D(value);
		}

		// Token: 0x06037CF9 RID: 228601 RVA: 0x00D397C4 File Offset: 0x00D379C4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Vector2D ttrackTarget_Vector2D = obj as TTrackTarget_Vector2D;
			return ttrackTarget_Vector2D != null && this.Value.Equals(ttrackTarget_Vector2D.Value, 9.999999747378752E-05);
		}

		// Token: 0x06037CFA RID: 228602 RVA: 0x00D397F7 File Offset: 0x00D379F7
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x0401D562 RID: 120162
		public Vector2D Value = Value;
	}
}
