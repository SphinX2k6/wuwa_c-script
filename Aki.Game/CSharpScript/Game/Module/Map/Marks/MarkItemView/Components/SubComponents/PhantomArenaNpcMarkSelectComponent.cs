using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components.SubComponents
{
	// Token: 0x02004520 RID: 17696
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkSelectComponent : MarkSelectComponent
	{
		// Token: 0x0602CA5B RID: 182875 RVA: 0x00C863A5 File Offset: 0x00C845A5
		protected override string GetSelectSequenceName()
		{
			return "Start";
		}

		// Token: 0x0602CA5C RID: 182876 RVA: 0x00C863AC File Offset: 0x00C845AC
		protected override string GetUnSelectSequenceName()
		{
			return "Close";
		}
	}
}
