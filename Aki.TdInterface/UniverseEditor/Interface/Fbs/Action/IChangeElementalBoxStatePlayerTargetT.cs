using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D6 RID: 25302
	public class IChangeElementalBoxStatePlayerTargetT
	{
		// Token: 0x1700BCDF RID: 48351
		// (get) Token: 0x0602BBCD RID: 179149 RVA: 0x00604A7E File Offset: 0x00602C7E
		// (set) Token: 0x0602BBCE RID: 179150 RVA: 0x00604A86 File Offset: 0x00602C86
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x0602BBCF RID: 179151 RVA: 0x00604A8F File Offset: 0x00602C8F
		public IChangeElementalBoxStatePlayerTargetT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
		}
	}
}
