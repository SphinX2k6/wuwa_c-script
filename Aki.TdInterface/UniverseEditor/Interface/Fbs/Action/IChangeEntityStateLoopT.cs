using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006965 RID: 26981
	public class IChangeEntityStateLoopT
	{
		// Token: 0x1700C69F RID: 50847
		// (get) Token: 0x0602E422 RID: 189474 RVA: 0x006511B6 File Offset: 0x0064F3B6
		// (set) Token: 0x0602E423 RID: 189475 RVA: 0x006511BE File Offset: 0x0064F3BE
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700C6A0 RID: 50848
		// (get) Token: 0x0602E424 RID: 189476 RVA: 0x006511C7 File Offset: 0x0064F3C7
		// (set) Token: 0x0602E425 RID: 189477 RVA: 0x006511CF File Offset: 0x0064F3CF
		public int EntityId { get; set; }

		// Token: 0x1700C6A1 RID: 50849
		// (get) Token: 0x0602E426 RID: 189478 RVA: 0x006511D8 File Offset: 0x0064F3D8
		// (set) Token: 0x0602E427 RID: 189479 RVA: 0x006511E0 File Offset: 0x0064F3E0
		public ELoopStateType Circulation { get; set; }

		// Token: 0x0602E428 RID: 189480 RVA: 0x006511E9 File Offset: 0x0064F3E9
		public IChangeEntityStateLoopT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
			this.Circulation = ELoopStateType.Prev;
		}
	}
}
