using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A46 RID: 19014
	public class ICheckHasFollowShooterT
	{
		// Token: 0x170089A8 RID: 35240
		// (get) Token: 0x0601DC68 RID: 121960 RVA: 0x0042FBC2 File Offset: 0x0042DDC2
		// (set) Token: 0x0601DC69 RID: 121961 RVA: 0x0042FBCA File Offset: 0x0042DDCA
		public ECondition Type { get; set; }

		// Token: 0x170089A9 RID: 35241
		// (get) Token: 0x0601DC6A RID: 121962 RVA: 0x0042FBD3 File Offset: 0x0042DDD3
		// (set) Token: 0x0601DC6B RID: 121963 RVA: 0x0042FBDB File Offset: 0x0042DDDB
		public bool Has { get; set; }

		// Token: 0x170089AA RID: 35242
		// (get) Token: 0x0601DC6C RID: 121964 RVA: 0x0042FBE4 File Offset: 0x0042DDE4
		// (set) Token: 0x0601DC6D RID: 121965 RVA: 0x0042FBEC File Offset: 0x0042DDEC
		public int Id { get; set; }

		// Token: 0x0601DC6E RID: 121966 RVA: 0x0042FBF5 File Offset: 0x0042DDF5
		public ICheckHasFollowShooterT()
		{
			this.Type = ECondition.CompareVar;
			this.Has = false;
			this.Id = 0;
		}
	}
}
