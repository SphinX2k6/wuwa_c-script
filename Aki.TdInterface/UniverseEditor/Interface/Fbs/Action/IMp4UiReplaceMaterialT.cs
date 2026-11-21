using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CF RID: 29391
	public class IMp4UiReplaceMaterialT
	{
		// Token: 0x1700D78C RID: 55180
		// (get) Token: 0x060333F3 RID: 209907 RVA: 0x006E9F4B File Offset: 0x006E814B
		// (set) Token: 0x060333F4 RID: 209908 RVA: 0x006E9F53 File Offset: 0x006E8153
		public EPlayMovieProgramSpecialConfigType Type { get; set; }

		// Token: 0x1700D78D RID: 55181
		// (get) Token: 0x060333F5 RID: 209909 RVA: 0x006E9F5C File Offset: 0x006E815C
		// (set) Token: 0x060333F6 RID: 209910 RVA: 0x006E9F64 File Offset: 0x006E8164
		public string Mp4UiReplaceMaterial { get; set; }

		// Token: 0x060333F7 RID: 209911 RVA: 0x006E9F6D File Offset: 0x006E816D
		public IMp4UiReplaceMaterialT()
		{
			this.Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
			this.Mp4UiReplaceMaterial = null;
		}
	}
}
