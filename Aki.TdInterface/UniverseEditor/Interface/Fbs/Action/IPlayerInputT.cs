using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFA RID: 27898
	public class IPlayerInputT
	{
		// Token: 0x1700CFC3 RID: 53187
		// (get) Token: 0x06031319 RID: 201497 RVA: 0x006AC716 File Offset: 0x006AA916
		// (set) Token: 0x0603131A RID: 201498 RVA: 0x006AC71E File Offset: 0x006AA91E
		public EPlayerInputType Input { get; set; }

		// Token: 0x0603131B RID: 201499 RVA: 0x006AC727 File Offset: 0x006AA927
		public IPlayerInputT()
		{
			this.Input = EPlayerInputType.None;
		}
	}
}
