using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005073 RID: 20595
	public class IDaNpcModelT
	{
		// Token: 0x1700956A RID: 38250
		// (get) Token: 0x06021033 RID: 135219 RVA: 0x004961EB File Offset: 0x004943EB
		// (set) Token: 0x06021034 RID: 135220 RVA: 0x004961F3 File Offset: 0x004943F3
		public ENpcModelType Type { get; set; }

		// Token: 0x1700956B RID: 38251
		// (get) Token: 0x06021035 RID: 135221 RVA: 0x004961FC File Offset: 0x004943FC
		// (set) Token: 0x06021036 RID: 135222 RVA: 0x00496204 File Offset: 0x00494404
		public string Da { get; set; }

		// Token: 0x06021037 RID: 135223 RVA: 0x0049620D File Offset: 0x0049440D
		public IDaNpcModelT()
		{
			this.Type = ENpcModelType.Mesh;
			this.Da = null;
		}
	}
}
