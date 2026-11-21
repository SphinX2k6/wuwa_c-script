using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E6F RID: 15983
	public class IDecalParamsT
	{
		// Token: 0x17006BED RID: 27629
		// (get) Token: 0x060158B2 RID: 88242 RVA: 0x0031B2BE File Offset: 0x003194BE
		// (set) Token: 0x060158B3 RID: 88243 RVA: 0x0031B2C6 File Offset: 0x003194C6
		public EParamsPreset Type { get; set; }

		// Token: 0x17006BEE RID: 27630
		// (get) Token: 0x060158B4 RID: 88244 RVA: 0x0031B2CF File Offset: 0x003194CF
		// (set) Token: 0x060158B5 RID: 88245 RVA: 0x0031B2D7 File Offset: 0x003194D7
		public float SpreadRadius { get; set; }

		// Token: 0x17006BEF RID: 27631
		// (get) Token: 0x060158B6 RID: 88246 RVA: 0x0031B2E0 File Offset: 0x003194E0
		// (set) Token: 0x060158B7 RID: 88247 RVA: 0x0031B2E8 File Offset: 0x003194E8
		public float SpreadTime { get; set; }

		// Token: 0x060158B8 RID: 88248 RVA: 0x0031B2F1 File Offset: 0x003194F1
		public IDecalParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.SpreadRadius = 0f;
			this.SpreadTime = 0f;
		}
	}
}
