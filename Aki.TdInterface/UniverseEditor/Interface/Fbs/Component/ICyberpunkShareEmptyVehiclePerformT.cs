using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C6 RID: 21958
	public class ICyberpunkShareEmptyVehiclePerformT
	{
		// Token: 0x17009D36 RID: 40246
		// (get) Token: 0x06022EFD RID: 143101 RVA: 0x004CF373 File Offset: 0x004CD573
		// (set) Token: 0x06022EFE RID: 143102 RVA: 0x004CF37B File Offset: 0x004CD57B
		public EVehicleType Type { get; set; }

		// Token: 0x17009D37 RID: 40247
		// (get) Token: 0x06022EFF RID: 143103 RVA: 0x004CF384 File Offset: 0x004CD584
		// (set) Token: 0x06022F00 RID: 143104 RVA: 0x004CF38C File Offset: 0x004CD58C
		public string Montage { get; set; }

		// Token: 0x06022F01 RID: 143105 RVA: 0x004CF395 File Offset: 0x004CD595
		public ICyberpunkShareEmptyVehiclePerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
