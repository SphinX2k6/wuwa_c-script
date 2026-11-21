using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E69 RID: 15977
	public class ICommonHotFixVarT
	{
		// Token: 0x17006BDF RID: 27615
		// (get) Token: 0x06015873 RID: 88179 RVA: 0x0031A9AC File Offset: 0x00318BAC
		// (set) Token: 0x06015874 RID: 88180 RVA: 0x0031A9B4 File Offset: 0x00318BB4
		public ESystemVarName Type { get; set; }

		// Token: 0x17006BE0 RID: 27616
		// (get) Token: 0x06015875 RID: 88181 RVA: 0x0031A9BD File Offset: 0x00318BBD
		// (set) Token: 0x06015876 RID: 88182 RVA: 0x0031A9C5 File Offset: 0x00318BC5
		public string VarName { get; set; }

		// Token: 0x17006BE1 RID: 27617
		// (get) Token: 0x06015877 RID: 88183 RVA: 0x0031A9CE File Offset: 0x00318BCE
		// (set) Token: 0x06015878 RID: 88184 RVA: 0x0031A9D6 File Offset: 0x00318BD6
		public string VarParams { get; set; }

		// Token: 0x06015879 RID: 88185 RVA: 0x0031A9DF File Offset: 0x00318BDF
		public ICommonHotFixVarT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}
