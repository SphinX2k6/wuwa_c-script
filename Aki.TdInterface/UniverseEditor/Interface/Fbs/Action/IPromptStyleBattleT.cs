using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007547 RID: 30023
	public class IPromptStyleBattleT
	{
		// Token: 0x1700DCDB RID: 56539
		// (get) Token: 0x06034A67 RID: 215655 RVA: 0x00715536 File Offset: 0x00713736
		// (set) Token: 0x06034A68 RID: 215656 RVA: 0x0071553E File Offset: 0x0071373E
		public EPromptStyle Type { get; set; }

		// Token: 0x06034A69 RID: 215657 RVA: 0x00715547 File Offset: 0x00713747
		public IPromptStyleBattleT()
		{
			this.Type = EPromptStyle.Default;
		}
	}
}
