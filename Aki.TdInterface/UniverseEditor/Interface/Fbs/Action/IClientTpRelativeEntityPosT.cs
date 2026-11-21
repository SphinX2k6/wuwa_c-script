using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A81 RID: 27265
	public class IClientTpRelativeEntityPosT
	{
		// Token: 0x1700C83D RID: 51261
		// (get) Token: 0x0602EC80 RID: 191616 RVA: 0x0066020E File Offset: 0x0065E40E
		// (set) Token: 0x0602EC81 RID: 191617 RVA: 0x00660216 File Offset: 0x0065E416
		public EClientTeleportType Type { get; set; }

		// Token: 0x1700C83E RID: 51262
		// (get) Token: 0x0602EC82 RID: 191618 RVA: 0x0066021F File Offset: 0x0065E41F
		// (set) Token: 0x0602EC83 RID: 191619 RVA: 0x00660227 File Offset: 0x0065E427
		public int SourcePosEntityId { get; set; }

		// Token: 0x1700C83F RID: 51263
		// (get) Token: 0x0602EC84 RID: 191620 RVA: 0x00660230 File Offset: 0x0065E430
		// (set) Token: 0x0602EC85 RID: 191621 RVA: 0x00660238 File Offset: 0x0065E438
		public int TargetPosEntityId { get; set; }

		// Token: 0x0602EC86 RID: 191622 RVA: 0x00660241 File Offset: 0x0065E441
		public IClientTpRelativeEntityPosT()
		{
			this.Type = EClientTeleportType.RelativeEntityPos;
			this.SourcePosEntityId = 0;
			this.TargetPosEntityId = 0;
		}
	}
}
