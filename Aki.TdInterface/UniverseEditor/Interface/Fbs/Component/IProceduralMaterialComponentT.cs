using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8F RID: 23951
	public class IProceduralMaterialComponentT
	{
		// Token: 0x1700B04A RID: 45130
		// (get) Token: 0x06027E3F RID: 163391 RVA: 0x00574D21 File Offset: 0x00572F21
		// (set) Token: 0x06027E40 RID: 163392 RVA: 0x00574D29 File Offset: 0x00572F29
		public bool Disabled { get; set; }

		// Token: 0x1700B04B RID: 45131
		// (get) Token: 0x06027E41 RID: 163393 RVA: 0x00574D32 File Offset: 0x00572F32
		// (set) Token: 0x06027E42 RID: 163394 RVA: 0x00574D3A File Offset: 0x00572F3A
		public List<ICustomPrimitiveDataConfigT> ProceduralMaterialConfigs { get; set; }

		// Token: 0x1700B04C RID: 45132
		// (get) Token: 0x06027E43 RID: 163395 RVA: 0x00574D43 File Offset: 0x00572F43
		// (set) Token: 0x06027E44 RID: 163396 RVA: 0x00574D4B File Offset: 0x00572F4B
		public byte NullMask { get; set; }

		// Token: 0x06027E45 RID: 163397 RVA: 0x00574D54 File Offset: 0x00572F54
		public IProceduralMaterialComponentT()
		{
			this.Disabled = false;
			this.ProceduralMaterialConfigs = null;
			this.NullMask = 0;
		}
	}
}
