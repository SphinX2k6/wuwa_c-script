using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200558B RID: 21899
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Vector : TTrackTarget
	{
		// Token: 0x06037CF1 RID: 228593 RVA: 0x00D39745 File Offset: 0x00D37945
		public TTrackTarget_Vector(Vector Value)
		{
		}

		// Token: 0x06037CF2 RID: 228594 RVA: 0x00D39754 File Offset: 0x00D37954
		public static implicit operator Vector(TTrackTarget_Vector target)
		{
			return target.Value;
		}

		// Token: 0x06037CF3 RID: 228595 RVA: 0x00D3975C File Offset: 0x00D3795C
		public new static implicit operator TTrackTarget_Vector(Vector value)
		{
			return new TTrackTarget_Vector(value);
		}

		// Token: 0x06037CF4 RID: 228596 RVA: 0x00D39764 File Offset: 0x00D37964
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Vector ttrackTarget_Vector = obj as TTrackTarget_Vector;
			return ttrackTarget_Vector != null && this.Value.Equals(ttrackTarget_Vector.Value, 9.999999747378752E-05);
		}

		// Token: 0x06037CF5 RID: 228597 RVA: 0x00D39797 File Offset: 0x00D37997
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x0401D561 RID: 120161
		public Vector Value = Value;
	}
}
