using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x0200652E RID: 25902
	public class IBulletConfigT
	{
		// Token: 0x1700BF1A RID: 48922
		// (get) Token: 0x0602C268 RID: 180840 RVA: 0x006036EB File Offset: 0x006018EB
		// (set) Token: 0x0602C269 RID: 180841 RVA: 0x006036F3 File Offset: 0x006018F3
		public int Id { get; set; }

		// Token: 0x1700BF1B RID: 48923
		// (get) Token: 0x0602C26A RID: 180842 RVA: 0x006036FC File Offset: 0x006018FC
		// (set) Token: 0x0602C26B RID: 180843 RVA: 0x00603704 File Offset: 0x00601904
		public string Name { get; set; }

		// Token: 0x0602C26C RID: 180844 RVA: 0x0060370D File Offset: 0x0060190D
		public IBulletConfigT()
		{
			this.Id = 0;
			this.Name = null;
		}
	}
}
