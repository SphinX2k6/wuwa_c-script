using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC0 RID: 16064
	public class IRequiredVector2T
	{
		// Token: 0x17006CC6 RID: 27846
		// (get) Token: 0x06015BDE RID: 89054 RVA: 0x00321194 File Offset: 0x0031F394
		// (set) Token: 0x06015BDF RID: 89055 RVA: 0x0032119C File Offset: 0x0031F39C
		public float X { get; set; }

		// Token: 0x17006CC7 RID: 27847
		// (get) Token: 0x06015BE0 RID: 89056 RVA: 0x003211A5 File Offset: 0x0031F3A5
		// (set) Token: 0x06015BE1 RID: 89057 RVA: 0x003211AD File Offset: 0x0031F3AD
		public float Y { get; set; }

		// Token: 0x06015BE2 RID: 89058 RVA: 0x003211B6 File Offset: 0x0031F3B6
		public IRequiredVector2T()
		{
			this.X = 0f;
			this.Y = 0f;
		}
	}
}
