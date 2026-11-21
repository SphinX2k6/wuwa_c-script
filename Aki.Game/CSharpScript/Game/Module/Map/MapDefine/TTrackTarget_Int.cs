using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004563 RID: 17763
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Int : TTrackTarget
	{
		// Token: 0x0602CBF9 RID: 183289 RVA: 0x00C874DC File Offset: 0x00C856DC
		public TTrackTarget_Int(int Value)
		{
		}

		// Token: 0x0602CBFA RID: 183290 RVA: 0x00C874EB File Offset: 0x00C856EB
		public static implicit operator int(TTrackTarget_Int target)
		{
			return target.Value;
		}

		// Token: 0x0602CBFB RID: 183291 RVA: 0x00C874F3 File Offset: 0x00C856F3
		public new static implicit operator TTrackTarget_Int(int value)
		{
			return new TTrackTarget_Int(value);
		}

		// Token: 0x0602CBFC RID: 183292 RVA: 0x00C874FC File Offset: 0x00C856FC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Int ttrackTarget_Int = obj as TTrackTarget_Int;
			return ttrackTarget_Int != null && this.Value == ttrackTarget_Int.Value;
		}

		// Token: 0x0602CBFD RID: 183293 RVA: 0x00C87523 File Offset: 0x00C85723
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x04017FEE RID: 98286
		public int Value = Value;
	}
}
