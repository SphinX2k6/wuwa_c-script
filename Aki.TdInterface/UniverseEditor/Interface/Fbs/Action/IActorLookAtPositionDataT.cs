using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674C RID: 26444
	public class IActorLookAtPositionDataT
	{
		// Token: 0x1700C049 RID: 49225
		// (get) Token: 0x0602CD07 RID: 183559 RVA: 0x00621217 File Offset: 0x0061F417
		// (set) Token: 0x0602CD08 RID: 183560 RVA: 0x0062121F File Offset: 0x0061F41F
		public EActorLookAtMode Type { get; set; }

		// Token: 0x1700C04A RID: 49226
		// (get) Token: 0x0602CD09 RID: 183561 RVA: 0x00621228 File Offset: 0x0061F428
		// (set) Token: 0x0602CD0A RID: 183562 RVA: 0x00621230 File Offset: 0x0061F430
		public bool Lock { get; set; }

		// Token: 0x1700C04B RID: 49227
		// (get) Token: 0x0602CD0B RID: 183563 RVA: 0x00621239 File Offset: 0x0061F439
		// (set) Token: 0x0602CD0C RID: 183564 RVA: 0x00621241 File Offset: 0x0061F441
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C04C RID: 49228
		// (get) Token: 0x0602CD0D RID: 183565 RVA: 0x0062124A File Offset: 0x0061F44A
		// (set) Token: 0x0602CD0E RID: 183566 RVA: 0x00621252 File Offset: 0x0061F452
		public byte NullMask { get; set; }

		// Token: 0x0602CD0F RID: 183567 RVA: 0x0062125B File Offset: 0x0061F45B
		public IActorLookAtPositionDataT()
		{
			this.Type = EActorLookAtMode.Talker;
			this.Lock = false;
			this.Pos = null;
			this.NullMask = 0;
		}
	}
}
