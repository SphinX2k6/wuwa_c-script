using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200363B RID: 13883
	[NullableContext(2)]
	[Nullable(0)]
	public class WuWaGoWorldMoveHooks : IWuWaGoWorldMoveHooks
	{
		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x06024055 RID: 147541 RVA: 0x00A33505 File Offset: 0x00A31705
		// (set) Token: 0x06024056 RID: 147542 RVA: 0x00A3350D File Offset: 0x00A3170D
		public Action OnStart { get; set; }

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x06024057 RID: 147543 RVA: 0x00A33516 File Offset: 0x00A31716
		// (set) Token: 0x06024058 RID: 147544 RVA: 0x00A3351E File Offset: 0x00A3171E
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

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x06024059 RID: 147545 RVA: 0x00A33527 File Offset: 0x00A31727
		// (set) Token: 0x0602405A RID: 147546 RVA: 0x00A3352F File Offset: 0x00A3172F
		public Action OnEnterSettle { get; set; }

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x0602405B RID: 147547 RVA: 0x00A33538 File Offset: 0x00A31738
		// (set) Token: 0x0602405C RID: 147548 RVA: 0x00A33540 File Offset: 0x00A31740
		public Action OnFinish { get; set; }
	}
}
