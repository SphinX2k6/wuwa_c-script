using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components.SubComponents
{
	// Token: 0x0200554E RID: 21838
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkSelectComponent : MarkSelectComponent
	{
		// Token: 0x06037B8B RID: 228235 RVA: 0x00D388D1 File Offset: 0x00D36AD1
		protected override string GetSelectSequenceName()
		{
			return "Start";
		}

		// Token: 0x06037B8C RID: 228236 RVA: 0x00D388D8 File Offset: 0x00D36AD8
		protected override string GetUnSelectSequenceName()
		{
			return "Close";
		}
	}
}
