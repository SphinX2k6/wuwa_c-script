using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712B RID: 28971
	public class ILiveSetParamT
	{
		// Token: 0x1700D422 RID: 54306
		// (get) Token: 0x06032548 RID: 206152 RVA: 0x006CE1D5 File Offset: 0x006CC3D5
		// (set) Token: 0x06032549 RID: 206153 RVA: 0x006CE1DD File Offset: 0x006CC3DD
		public TLiveParamConfigUnion Param { get; set; }

		// Token: 0x0603254A RID: 206154 RVA: 0x006CE1E6 File Offset: 0x006CC3E6
		public ILiveSetParamT()
		{
			this.Param = null;
		}
	}
}
