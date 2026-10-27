using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7E RID: 23422
	public class IWindDirectionalStateGradeT
	{
		// Token: 0x1700B106 RID: 45318
		// (get) Token: 0x0602818F RID: 164239 RVA: 0x00583159 File Offset: 0x00581359
		// (set) Token: 0x06028190 RID: 164240 RVA: 0x00583161 File Offset: 0x00581361
		public string State { get; set; }

		// Token: 0x1700B107 RID: 45319
		// (get) Token: 0x06028191 RID: 164241 RVA: 0x0058316A File Offset: 0x0058136A
		// (set) Token: 0x06028192 RID: 164242 RVA: 0x00583172 File Offset: 0x00581372
		public float Speed { get; set; }

		// Token: 0x1700B108 RID: 45320
		// (get) Token: 0x06028193 RID: 164243 RVA: 0x0058317B File Offset: 0x0058137B
		// (set) Token: 0x06028194 RID: 164244 RVA: 0x00583183 File Offset: 0x00581383
		public float Strength { get; set; }

		// Token: 0x06028195 RID: 164245 RVA: 0x0058318C File Offset: 0x0058138C
		public IWindDirectionalStateGradeT()
		{
			this.State = null;
			this.Speed = 0f;
			this.Strength = 0f;
		}
	}
}
