using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200558D RID: 21901
	[NullableContext(1)]
	[Nullable(0)]
	public class TTrackTarget_Int : TTrackTarget
	{
		// Token: 0x06037CFB RID: 228603 RVA: 0x00D39804 File Offset: 0x00D37A04
		public TTrackTarget_Int(int Value)
		{
		}

		// Token: 0x06037CFC RID: 228604 RVA: 0x00D39813 File Offset: 0x00D37A13
		public static implicit operator int(TTrackTarget_Int target)
		{
			return target.Value;
		}

		// Token: 0x06037CFD RID: 228605 RVA: 0x00D3981B File Offset: 0x00D37A1B
		public new static implicit operator TTrackTarget_Int(int value)
		{
			return new TTrackTarget_Int(value);
		}

		// Token: 0x06037CFE RID: 228606 RVA: 0x00D39824 File Offset: 0x00D37A24
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			TTrackTarget_Int ttrackTarget_Int = obj as TTrackTarget_Int;
			return ttrackTarget_Int != null && this.Value == ttrackTarget_Int.Value;
		}

		// Token: 0x06037CFF RID: 228607 RVA: 0x00D3984B File Offset: 0x00D37A4B
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x0401D563 RID: 120163
		public int Value = Value;
	}
}
