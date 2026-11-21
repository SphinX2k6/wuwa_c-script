using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C8 RID: 22216
	public class IEntityBatchTypeT
	{
		// Token: 0x17009FE9 RID: 40937
		// (get) Token: 0x0602399E RID: 145822 RVA: 0x004E53EA File Offset: 0x004E35EA
		// (set) Token: 0x0602399F RID: 145823 RVA: 0x004E53F2 File Offset: 0x004E35F2
		public EEntityBatchType Type { get; set; }

		// Token: 0x060239A0 RID: 145824 RVA: 0x004E53FB File Offset: 0x004E35FB
		public IEntityBatchTypeT()
		{
			this.Type = EEntityBatchType.EntityList;
		}
	}
}
