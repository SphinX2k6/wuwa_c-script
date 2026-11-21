using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007550 RID: 30032
	public class IPromptStylePhotoT
	{
		// Token: 0x1700DCE4 RID: 56548
		// (get) Token: 0x06034A9D RID: 215709 RVA: 0x0071599E File Offset: 0x00713B9E
		// (set) Token: 0x06034A9E RID: 215710 RVA: 0x007159A6 File Offset: 0x00713BA6
		public EPromptStyle Type { get; set; }

		// Token: 0x06034A9F RID: 215711 RVA: 0x007159AF File Offset: 0x00713BAF
		public IPromptStylePhotoT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
