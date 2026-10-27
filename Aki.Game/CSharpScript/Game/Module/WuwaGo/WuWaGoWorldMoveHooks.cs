using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200470B RID: 18187
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoWorldMoveHooks : IWuWaGoWorldMoveHooks
	{
		// Token: 0x170076C5 RID: 30405
		// (get) Token: 0x0602F88F RID: 194703 RVA: 0x00B03835 File Offset: 0x00B01A35
		// (set) Token: 0x0602F890 RID: 194704 RVA: 0x00B0383D File Offset: 0x00B01A3D
		public Action OnStart { get; set; }

		// Token: 0x170076C6 RID: 30406
		// (get) Token: 0x0602F891 RID: 194705 RVA: 0x00B03846 File Offset: 0x00B01A46
		// (set) Token: 0x0602F892 RID: 194706 RVA: 0x00B0384E File Offset: 0x00B01A4E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Vector> OnRunning { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170076C7 RID: 30407
		// (get) Token: 0x0602F893 RID: 194707 RVA: 0x00B03857 File Offset: 0x00B01A57
		// (set) Token: 0x0602F894 RID: 194708 RVA: 0x00B0385F File Offset: 0x00B01A5F
		public Action OnEnterSettle { get; set; }

		// Token: 0x170076C8 RID: 30408
		// (get) Token: 0x0602F895 RID: 194709 RVA: 0x00B03868 File Offset: 0x00B01A68
		// (set) Token: 0x0602F896 RID: 194710 RVA: 0x00B03870 File Offset: 0x00B01A70
		public Action OnFinish { get; set; }
	}
}
