using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C1A RID: 19482
	public class IEntityStateConditionT
	{
		// Token: 0x17008D89 RID: 36233
		// (get) Token: 0x0601EDD7 RID: 126423 RVA: 0x004521E7 File Offset: 0x004503E7
		// (set) Token: 0x0601EDD8 RID: 126424 RVA: 0x004521EF File Offset: 0x004503EF
		public int EntityId { get; set; }

		// Token: 0x17008D8A RID: 36234
		// (get) Token: 0x0601EDD9 RID: 126425 RVA: 0x004521F8 File Offset: 0x004503F8
		// (set) Token: 0x0601EDDA RID: 126426 RVA: 0x00452200 File Offset: 0x00450400
		public string State { get; set; }

		// Token: 0x0601EDDB RID: 126427 RVA: 0x00452209 File Offset: 0x00450409
		public IEntityStateConditionT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
