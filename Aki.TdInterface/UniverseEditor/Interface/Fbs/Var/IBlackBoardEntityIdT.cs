using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DEB RID: 15851
	public class IBlackBoardEntityIdT
	{
		// Token: 0x17006B0E RID: 27406
		// (get) Token: 0x0601547F RID: 87167 RVA: 0x00313DA5 File Offset: 0x00311FA5
		// (set) Token: 0x06015480 RID: 87168 RVA: 0x00313DAD File Offset: 0x00311FAD
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B0F RID: 27407
		// (get) Token: 0x06015481 RID: 87169 RVA: 0x00313DB6 File Offset: 0x00311FB6
		// (set) Token: 0x06015482 RID: 87170 RVA: 0x00313DBE File Offset: 0x00311FBE
		public string Key { get; set; }

		// Token: 0x17006B10 RID: 27408
		// (get) Token: 0x06015483 RID: 87171 RVA: 0x00313DC7 File Offset: 0x00311FC7
		// (set) Token: 0x06015484 RID: 87172 RVA: 0x00313DCF File Offset: 0x00311FCF
		public int EntityId { get; set; }

		// Token: 0x06015485 RID: 87173 RVA: 0x00313DD8 File Offset: 0x00311FD8
		public IBlackBoardEntityIdT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.EntityId = 0;
		}
	}
}
