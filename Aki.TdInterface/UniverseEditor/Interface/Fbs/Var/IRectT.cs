using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EBD RID: 16061
	public class IRectT
	{
		// Token: 0x17006CC1 RID: 27841
		// (get) Token: 0x06015BC8 RID: 89032 RVA: 0x00320F42 File Offset: 0x0031F142
		// (set) Token: 0x06015BC9 RID: 89033 RVA: 0x00320F4A File Offset: 0x0031F14A
		public IVector2T Min { get; set; }

		// Token: 0x17006CC2 RID: 27842
		// (get) Token: 0x06015BCA RID: 89034 RVA: 0x00320F53 File Offset: 0x0031F153
		// (set) Token: 0x06015BCB RID: 89035 RVA: 0x00320F5B File Offset: 0x0031F15B
		public IVector2T Max { get; set; }

		// Token: 0x06015BCC RID: 89036 RVA: 0x00320F64 File Offset: 0x0031F164
		public IRectT()
		{
			this.Min = null;
			this.Max = null;
		}
	}
}
