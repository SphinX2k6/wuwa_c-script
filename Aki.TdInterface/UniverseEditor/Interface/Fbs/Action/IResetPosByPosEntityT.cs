using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA1 RID: 28321
	public class IResetPosByPosEntityT
	{
		// Token: 0x1700D2E0 RID: 53984
		// (get) Token: 0x060320EB RID: 205035 RVA: 0x006C5178 File Offset: 0x006C3378
		// (set) Token: 0x060320EC RID: 205036 RVA: 0x006C5180 File Offset: 0x006C3380
		public EResetPosType Type { get; set; }

		// Token: 0x1700D2E1 RID: 53985
		// (get) Token: 0x060320ED RID: 205037 RVA: 0x006C5189 File Offset: 0x006C3389
		// (set) Token: 0x060320EE RID: 205038 RVA: 0x006C5191 File Offset: 0x006C3391
		public int Entity { get; set; }

		// Token: 0x060320EF RID: 205039 RVA: 0x006C519A File Offset: 0x006C339A
		public IResetPosByPosEntityT()
		{
			this.Type = EResetPosType.PosEntity;
			this.Entity = 0;
		}
	}
}
