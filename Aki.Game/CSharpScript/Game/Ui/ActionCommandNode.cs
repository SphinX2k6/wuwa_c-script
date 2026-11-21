using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003542 RID: 13634
	internal class ActionCommandNode : IActionCommandNode
	{
		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06022AC9 RID: 142025 RVA: 0x009DDCE8 File Offset: 0x009DBEE8
		// (set) Token: 0x06022ACA RID: 142026 RVA: 0x009DDCF0 File Offset: 0x009DBEF0
		public EActionCommandType ActionCommand { get; set; }

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06022ACB RID: 142027 RVA: 0x009DDCF9 File Offset: 0x009DBEF9
		// (set) Token: 0x06022ACC RID: 142028 RVA: 0x009DDD01 File Offset: 0x009DBF01
		public bool Processed { get; set; }
	}
}
