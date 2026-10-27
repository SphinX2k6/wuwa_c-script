using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B89 RID: 27529
	public class IMp4UiReplaceMaterialT
	{
		// Token: 0x1700CCA7 RID: 52391
		// (get) Token: 0x0603059B RID: 198043 RVA: 0x0069192B File Offset: 0x0068FB2B
		// (set) Token: 0x0603059C RID: 198044 RVA: 0x00691933 File Offset: 0x0068FB33
		public EPlayMovieProgramSpecialConfigType Type { get; set; }

		// Token: 0x1700CCA8 RID: 52392
		// (get) Token: 0x0603059D RID: 198045 RVA: 0x0069193C File Offset: 0x0068FB3C
		// (set) Token: 0x0603059E RID: 198046 RVA: 0x00691944 File Offset: 0x0068FB44
		public string Mp4UiReplaceMaterial { get; set; }

		// Token: 0x0603059F RID: 198047 RVA: 0x0069194D File Offset: 0x0068FB4D
		public IMp4UiReplaceMaterialT()
		{
			this.Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
			this.Mp4UiReplaceMaterial = null;
		}
	}
}
