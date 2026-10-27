using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004694 RID: 18068
	public class ISetUnopenedAreaPullbackT
	{
		// Token: 0x17008045 RID: 32837
		// (get) Token: 0x0601B6F5 RID: 112373 RVA: 0x003E5A30 File Offset: 0x003E3C30
		// (set) Token: 0x0601B6F6 RID: 112374 RVA: 0x003E5A38 File Offset: 0x003E3C38
		public EGmCommand Type { get; set; }

		// Token: 0x17008046 RID: 32838
		// (get) Token: 0x0601B6F7 RID: 112375 RVA: 0x003E5A41 File Offset: 0x003E3C41
		// (set) Token: 0x0601B6F8 RID: 112376 RVA: 0x003E5A49 File Offset: 0x003E3C49
		public bool IsOpen { get; set; }

		// Token: 0x0601B6F9 RID: 112377 RVA: 0x003E5A52 File Offset: 0x003E3C52
		public ISetUnopenedAreaPullbackT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsOpen = false;
		}
	}
}
