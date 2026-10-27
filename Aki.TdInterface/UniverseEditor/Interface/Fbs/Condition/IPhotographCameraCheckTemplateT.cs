using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C77 RID: 19575
	public class IPhotographCameraCheckTemplateT
	{
		// Token: 0x17008E2F RID: 36399
		// (get) Token: 0x0601F0B5 RID: 127157 RVA: 0x00456E94 File Offset: 0x00455094
		// (set) Token: 0x0601F0B6 RID: 127158 RVA: 0x00456E9C File Offset: 0x0045509C
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x17008E30 RID: 36400
		// (get) Token: 0x0601F0B7 RID: 127159 RVA: 0x00456EA5 File Offset: 0x004550A5
		// (set) Token: 0x0601F0B8 RID: 127160 RVA: 0x00456EAD File Offset: 0x004550AD
		public int TemplateId { get; set; }

		// Token: 0x0601F0B9 RID: 127161 RVA: 0x00456EB6 File Offset: 0x004550B6
		public IPhotographCameraCheckTemplateT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.TemplateId = 0;
		}
	}
}
