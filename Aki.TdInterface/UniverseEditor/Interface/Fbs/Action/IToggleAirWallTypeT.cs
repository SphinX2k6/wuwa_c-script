using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD9 RID: 31705
	public class IToggleAirWallTypeT
	{
		// Token: 0x1700ED7F RID: 60799
		// (get) Token: 0x06039256 RID: 234070 RVA: 0x007B8D6E File Offset: 0x007B6F6E
		// (set) Token: 0x06039257 RID: 234071 RVA: 0x007B8D76 File Offset: 0x007B6F76
		public EToggleAirWall Type { get; set; }

		// Token: 0x06039258 RID: 234072 RVA: 0x007B8D7F File Offset: 0x007B6F7F
		public IToggleAirWallTypeT()
		{
			this.Type = EToggleAirWall.Open;
		}
	}
}
