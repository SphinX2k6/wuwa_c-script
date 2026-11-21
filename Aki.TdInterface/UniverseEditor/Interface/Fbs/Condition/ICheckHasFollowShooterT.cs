using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F0C RID: 20236
	public class ICheckHasFollowShooterT
	{
		// Token: 0x17009084 RID: 36996
		// (get) Token: 0x0601F70B RID: 128779 RVA: 0x00460D4E File Offset: 0x0045EF4E
		// (set) Token: 0x0601F70C RID: 128780 RVA: 0x00460D56 File Offset: 0x0045EF56
		public ECondition Type { get; set; }

		// Token: 0x17009085 RID: 36997
		// (get) Token: 0x0601F70D RID: 128781 RVA: 0x00460D5F File Offset: 0x0045EF5F
		// (set) Token: 0x0601F70E RID: 128782 RVA: 0x00460D67 File Offset: 0x0045EF67
		public bool Has { get; set; }

		// Token: 0x17009086 RID: 36998
		// (get) Token: 0x0601F70F RID: 128783 RVA: 0x00460D70 File Offset: 0x0045EF70
		// (set) Token: 0x0601F710 RID: 128784 RVA: 0x00460D78 File Offset: 0x0045EF78
		public int Id { get; set; }

		// Token: 0x0601F711 RID: 128785 RVA: 0x00460D81 File Offset: 0x0045EF81
		public ICheckHasFollowShooterT()
		{
			this.Type = ECondition.CompareVar;
			this.Has = false;
			this.Id = 0;
		}
	}
}
