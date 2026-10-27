using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DF8 RID: 15864
	public class IEnterDungeonT
	{
		// Token: 0x17006DA3 RID: 28067
		// (get) Token: 0x060162FF RID: 90879 RVA: 0x0033452A File Offset: 0x0033272A
		// (set) Token: 0x06016300 RID: 90880 RVA: 0x00334532 File Offset: 0x00332732
		public EDungeonConditionType Type { get; set; }

		// Token: 0x06016301 RID: 90881 RVA: 0x0033453B File Offset: 0x0033273B
		public IEnterDungeonT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
		}
	}
}
