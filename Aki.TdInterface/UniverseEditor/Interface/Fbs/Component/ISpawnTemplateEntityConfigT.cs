using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F76 RID: 24438
	public class ISpawnTemplateEntityConfigT
	{
		// Token: 0x1700B4FE RID: 46334
		// (get) Token: 0x06029161 RID: 168289 RVA: 0x0059C8A8 File Offset: 0x0059AAA8
		// (set) Token: 0x06029162 RID: 168290 RVA: 0x0059C8B0 File Offset: 0x0059AAB0
		public string TemplateBpType { get; set; }

		// Token: 0x1700B4FF RID: 46335
		// (get) Token: 0x06029163 RID: 168291 RVA: 0x0059C8B9 File Offset: 0x0059AAB9
		// (set) Token: 0x06029164 RID: 168292 RVA: 0x0059C8C1 File Offset: 0x0059AAC1
		public IVectorInfoT PosOffset { get; set; }

		// Token: 0x1700B500 RID: 46336
		// (get) Token: 0x06029165 RID: 168293 RVA: 0x0059C8CA File Offset: 0x0059AACA
		// (set) Token: 0x06029166 RID: 168294 RVA: 0x0059C8D2 File Offset: 0x0059AAD2
		public IVectorInfoT RotOffset { get; set; }

		// Token: 0x1700B501 RID: 46337
		// (get) Token: 0x06029167 RID: 168295 RVA: 0x0059C8DB File Offset: 0x0059AADB
		// (set) Token: 0x06029168 RID: 168296 RVA: 0x0059C8E3 File Offset: 0x0059AAE3
		public List<ETemplateEntityGroupType> GroupTypes { get; set; }

		// Token: 0x1700B502 RID: 46338
		// (get) Token: 0x06029169 RID: 168297 RVA: 0x0059C8EC File Offset: 0x0059AAEC
		// (set) Token: 0x0602916A RID: 168298 RVA: 0x0059C8F4 File Offset: 0x0059AAF4
		public byte NullMask { get; set; }

		// Token: 0x0602916B RID: 168299 RVA: 0x0059C8FD File Offset: 0x0059AAFD
		public ISpawnTemplateEntityConfigT()
		{
			this.TemplateBpType = null;
			this.PosOffset = null;
			this.RotOffset = null;
			this.GroupTypes = null;
			this.NullMask = 0;
		}
	}
}
