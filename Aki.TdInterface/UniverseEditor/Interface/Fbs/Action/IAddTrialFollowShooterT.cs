using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A3 RID: 26531
	public class IAddTrialFollowShooterT
	{
		// Token: 0x1700C11C RID: 49436
		// (get) Token: 0x0602D082 RID: 184450 RVA: 0x00627CF7 File Offset: 0x00625EF7
		// (set) Token: 0x0602D083 RID: 184451 RVA: 0x00627CFF File Offset: 0x00625EFF
		public int Id { get; set; }

		// Token: 0x1700C11D RID: 49437
		// (get) Token: 0x0602D084 RID: 184452 RVA: 0x00627D08 File Offset: 0x00625F08
		// (set) Token: 0x0602D085 RID: 184453 RVA: 0x00627D10 File Offset: 0x00625F10
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x0602D086 RID: 184454 RVA: 0x00627D19 File Offset: 0x00625F19
		public IAddTrialFollowShooterT()
		{
			this.Id = 0;
			this.ActiveRange = null;
		}
	}
}
