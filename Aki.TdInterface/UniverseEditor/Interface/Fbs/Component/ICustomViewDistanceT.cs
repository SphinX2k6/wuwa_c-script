using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C3 RID: 21955
	public class ICustomViewDistanceT
	{
		// Token: 0x17009D31 RID: 40241
		// (get) Token: 0x06022EE5 RID: 143077 RVA: 0x004CF13C File Offset: 0x004CD33C
		// (set) Token: 0x06022EE6 RID: 143078 RVA: 0x004CF144 File Offset: 0x004CD344
		public EViewDistanceType Type { get; set; }

		// Token: 0x17009D32 RID: 40242
		// (get) Token: 0x06022EE7 RID: 143079 RVA: 0x004CF14D File Offset: 0x004CD34D
		// (set) Token: 0x06022EE8 RID: 143080 RVA: 0x004CF155 File Offset: 0x004CD355
		public int Distance { get; set; }

		// Token: 0x06022EE9 RID: 143081 RVA: 0x004CF15E File Offset: 0x004CD35E
		public ICustomViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
			this.Distance = 0;
		}
	}
}
