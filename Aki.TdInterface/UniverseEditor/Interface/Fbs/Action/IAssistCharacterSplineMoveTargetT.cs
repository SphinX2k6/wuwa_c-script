using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006812 RID: 26642
	public class IAssistCharacterSplineMoveTargetT
	{
		// Token: 0x1700C3D3 RID: 50131
		// (get) Token: 0x0602D829 RID: 186409 RVA: 0x0063AC24 File Offset: 0x00638E24
		// (set) Token: 0x0602D82A RID: 186410 RVA: 0x0063AC2C File Offset: 0x00638E2C
		public ESplineMoveTargetType Type { get; set; }

		// Token: 0x1700C3D4 RID: 50132
		// (get) Token: 0x0602D82B RID: 186411 RVA: 0x0063AC35 File Offset: 0x00638E35
		// (set) Token: 0x0602D82C RID: 186412 RVA: 0x0063AC3D File Offset: 0x00638E3D
		public int TrailRoleId { get; set; }

		// Token: 0x0602D82D RID: 186413 RVA: 0x0063AC46 File Offset: 0x00638E46
		public IAssistCharacterSplineMoveTargetT()
		{
			this.Type = ESplineMoveTargetType.Entity;
			this.TrailRoleId = 0;
		}
	}
}
