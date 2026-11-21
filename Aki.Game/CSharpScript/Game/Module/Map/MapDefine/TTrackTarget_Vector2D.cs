using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004562 RID: 17762
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Vector2D : TTrackTarget
	{
		// Token: 0x0602CBF4 RID: 183284 RVA: 0x00C8747C File Offset: 0x00C8567C
		public TTrackTarget_Vector2D(Vector2D Value)
		{
		}

		// Token: 0x0602CBF5 RID: 183285 RVA: 0x00C8748B File Offset: 0x00C8568B
		public static implicit operator Vector2D(TTrackTarget_Vector2D target)
		{
			return target.Value;
		}

		// Token: 0x0602CBF6 RID: 183286 RVA: 0x00C87493 File Offset: 0x00C85693
		public new static implicit operator TTrackTarget_Vector2D(Vector2D value)
		{
			return new TTrackTarget_Vector2D(value);
		}

		// Token: 0x0602CBF7 RID: 183287 RVA: 0x00C8749C File Offset: 0x00C8569C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Vector2D ttrackTarget_Vector2D = obj as TTrackTarget_Vector2D;
			return ttrackTarget_Vector2D != null && this.Value.Equals(ttrackTarget_Vector2D.Value, 9.999999747378752E-05);
		}

		// Token: 0x0602CBF8 RID: 183288 RVA: 0x00C874CF File Offset: 0x00C856CF
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x04017FED RID: 98285
		public Vector2D Value = Value;
	}
}
