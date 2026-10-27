using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006991 RID: 27025
	public class IInteractiveItemsFunctionT
	{
		// Token: 0x1700C865 RID: 51301
		// (get) Token: 0x0602F328 RID: 193320 RVA: 0x0066DAB0 File Offset: 0x0066BCB0
		// (set) Token: 0x0602F329 RID: 193321 RVA: 0x0066DAB8 File Offset: 0x0066BCB8
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700C866 RID: 51302
		// (get) Token: 0x0602F32A RID: 193322 RVA: 0x0066DAC1 File Offset: 0x0066BCC1
		// (set) Token: 0x0602F32B RID: 193323 RVA: 0x0066DAC9 File Offset: 0x0066BCC9
		public bool Enable { get; set; }

		// Token: 0x0602F32C RID: 193324 RVA: 0x0066DAD2 File Offset: 0x0066BCD2
		public IInteractiveItemsFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.Enable = false;
		}
	}
}
