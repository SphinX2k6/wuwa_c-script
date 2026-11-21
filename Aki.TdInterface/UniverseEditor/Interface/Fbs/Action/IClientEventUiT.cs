using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A24 RID: 27172
	public class IClientEventUiT
	{
		// Token: 0x1700C7BD RID: 51133
		// (get) Token: 0x0602E9CF RID: 190927 RVA: 0x0065B162 File Offset: 0x00659362
		// (set) Token: 0x0602E9D0 RID: 190928 RVA: 0x0065B16A File Offset: 0x0065936A
		public EClientEventUiType Type { get; set; }

		// Token: 0x0602E9D1 RID: 190929 RVA: 0x0065B173 File Offset: 0x00659373
		public IClientEventUiT()
		{
			this.Type = EClientEventUiType.PlayPiano;
		}
	}
}
