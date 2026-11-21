using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004561 RID: 17761
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Vector : TTrackTarget
	{
		// Token: 0x0602CBEF RID: 183279 RVA: 0x00C8741D File Offset: 0x00C8561D
		public TTrackTarget_Vector(Vector Value)
		{
		}

		// Token: 0x0602CBF0 RID: 183280 RVA: 0x00C8742C File Offset: 0x00C8562C
		public static implicit operator Vector(TTrackTarget_Vector target)
		{
			return target.Value;
		}

		// Token: 0x0602CBF1 RID: 183281 RVA: 0x00C87434 File Offset: 0x00C85634
		public new static implicit operator TTrackTarget_Vector(Vector value)
		{
			return new TTrackTarget_Vector(value);
		}

		// Token: 0x0602CBF2 RID: 183282 RVA: 0x00C8743C File Offset: 0x00C8563C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Vector ttrackTarget_Vector = obj as TTrackTarget_Vector;
			return ttrackTarget_Vector != null && this.Value.Equals(ttrackTarget_Vector.Value, 9.999999747378752E-05);
		}

		// Token: 0x0602CBF3 RID: 183283 RVA: 0x00C8746F File Offset: 0x00C8566F
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x04017FEC RID: 98284
		public Vector Value = Value;
	}
}
