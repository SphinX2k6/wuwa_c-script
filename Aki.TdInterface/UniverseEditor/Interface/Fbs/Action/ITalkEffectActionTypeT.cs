using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AB RID: 29355
	public class ITalkEffectActionTypeT
	{
		// Token: 0x1700D9BC RID: 55740
		// (get) Token: 0x06034169 RID: 213353 RVA: 0x007005B6 File Offset: 0x006FE7B6
		// (set) Token: 0x0603416A RID: 213354 RVA: 0x007005BE File Offset: 0x006FE7BE
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x0603416B RID: 213355 RVA: 0x007005C7 File Offset: 0x006FE7C7
		public ITalkEffectActionTypeT()
		{
			this.Type = ETalkEffectActionType.Play;
		}
	}
}
