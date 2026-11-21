using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004560 RID: 17760
	public class IShowUiAllT
	{
		// Token: 0x17007C12 RID: 31762
		// (get) Token: 0x06019D3C RID: 105788 RVA: 0x003AF4CE File Offset: 0x003AD6CE
		// (set) Token: 0x06019D3D RID: 105789 RVA: 0x003AF4D6 File Offset: 0x003AD6D6
		public EShowUiType Type { get; set; }

		// Token: 0x06019D3E RID: 105790 RVA: 0x003AF4DF File Offset: 0x003AD6DF
		public IShowUiAllT()
		{
			this.Type = EShowUiType.All;
		}
	}
}
