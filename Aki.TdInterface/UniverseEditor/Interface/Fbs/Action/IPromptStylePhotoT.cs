using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD5 RID: 28117
	public class IPromptStylePhotoT
	{
		// Token: 0x1700D19C RID: 53660
		// (get) Token: 0x06031AA1 RID: 203425 RVA: 0x006BA2B6 File Offset: 0x006B84B6
		// (set) Token: 0x06031AA2 RID: 203426 RVA: 0x006BA2BE File Offset: 0x006B84BE
		public EPromptStyle Type { get; set; }

		// Token: 0x06031AA3 RID: 203427 RVA: 0x006BA2C7 File Offset: 0x006B84C7
		public IPromptStylePhotoT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
