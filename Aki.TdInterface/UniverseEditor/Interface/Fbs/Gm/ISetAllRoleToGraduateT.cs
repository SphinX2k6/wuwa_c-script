using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468B RID: 18059
	public class ISetAllRoleToGraduateT
	{
		// Token: 0x17008035 RID: 32821
		// (get) Token: 0x0601B6B1 RID: 112305 RVA: 0x003E53C2 File Offset: 0x003E35C2
		// (set) Token: 0x0601B6B2 RID: 112306 RVA: 0x003E53CA File Offset: 0x003E35CA
		public EGmCommand Type { get; set; }

		// Token: 0x0601B6B3 RID: 112307 RVA: 0x003E53D3 File Offset: 0x003E35D3
		public ISetAllRoleToGraduateT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
