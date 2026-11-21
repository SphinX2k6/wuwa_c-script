using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EDE RID: 16094
	public class ISystemVarDefineT
	{
		// Token: 0x17006CF6 RID: 27894
		// (get) Token: 0x06015CF3 RID: 89331 RVA: 0x0032313C File Offset: 0x0032133C
		// (set) Token: 0x06015CF4 RID: 89332 RVA: 0x00323144 File Offset: 0x00321344
		public string Name { get; set; }

		// Token: 0x17006CF7 RID: 27895
		// (get) Token: 0x06015CF5 RID: 89333 RVA: 0x0032314D File Offset: 0x0032134D
		// (set) Token: 0x06015CF6 RID: 89334 RVA: 0x00323155 File Offset: 0x00321355
		public string Type { get; set; }

		// Token: 0x17006CF8 RID: 27896
		// (get) Token: 0x06015CF7 RID: 89335 RVA: 0x0032315E File Offset: 0x0032135E
		// (set) Token: 0x06015CF8 RID: 89336 RVA: 0x00323166 File Offset: 0x00321366
		public ESystemModuleName ModuleName { get; set; }

		// Token: 0x17006CF9 RID: 27897
		// (get) Token: 0x06015CF9 RID: 89337 RVA: 0x0032316F File Offset: 0x0032136F
		// (set) Token: 0x06015CFA RID: 89338 RVA: 0x00323177 File Offset: 0x00321377
		public string CnName { get; set; }

		// Token: 0x17006CFA RID: 27898
		// (get) Token: 0x06015CFB RID: 89339 RVA: 0x00323180 File Offset: 0x00321380
		// (set) Token: 0x06015CFC RID: 89340 RVA: 0x00323188 File Offset: 0x00321388
		public bool Readonly { get; set; }

		// Token: 0x17006CFB RID: 27899
		// (get) Token: 0x06015CFD RID: 89341 RVA: 0x00323191 File Offset: 0x00321391
		// (set) Token: 0x06015CFE RID: 89342 RVA: 0x00323199 File Offset: 0x00321399
		public bool HasArgs { get; set; }

		// Token: 0x06015CFF RID: 89343 RVA: 0x003231A2 File Offset: 0x003213A2
		public ISystemVarDefineT()
		{
			this.Name = null;
			this.Type = null;
			this.ModuleName = ESystemModuleName.Common;
			this.CnName = null;
			this.Readonly = false;
			this.HasArgs = false;
		}
	}
}
