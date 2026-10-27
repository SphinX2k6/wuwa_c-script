using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C74 RID: 15476
	public class IVolumeTriggerShapeT
	{
		// Token: 0x17006ABC RID: 27324
		// (get) Token: 0x060156C1 RID: 87745 RVA: 0x00318AF3 File Offset: 0x00316CF3
		// (set) Token: 0x060156C2 RID: 87746 RVA: 0x00318AFB File Offset: 0x00316CFB
		public ETriggerShape Type { get; set; }

		// Token: 0x17006ABD RID: 27325
		// (get) Token: 0x060156C3 RID: 87747 RVA: 0x00318B04 File Offset: 0x00316D04
		// (set) Token: 0x060156C4 RID: 87748 RVA: 0x00318B0C File Offset: 0x00316D0C
		public string VolumeKey { get; set; }

		// Token: 0x060156C5 RID: 87749 RVA: 0x00318B15 File Offset: 0x00316D15
		public IVolumeTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.VolumeKey = null;
		}
	}
}
