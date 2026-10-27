using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069AA RID: 27050
	public class InteractSecondConfirmContext : GeneralContext
	{
		// Token: 0x0604346F RID: 275567 RVA: 0x01066455 File Offset: 0x01064655
		public InteractSecondConfirmContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.InteractSecondConfirm);
		}

		// Token: 0x06043470 RID: 275568 RVA: 0x0106646C File Offset: 0x0106466C
		[NullableContext(1)]
		public static InteractSecondConfirmContext Create(int handle, CommonInteractOption option)
		{
			InteractSecondConfirmContext interactSecondConfirmContext = GeneralContext.GetObj(EGeneralContextType.InteractSecondConfirm, null, () => new InteractSecondConfirmContext()) as InteractSecondConfirmContext;
			interactSecondConfirmContext.Handle = handle;
			interactSecondConfirmContext.Option = option;
			return interactSecondConfirmContext;
		}

		// Token: 0x040230BF RID: 143551
		public int Handle;

		// Token: 0x040230C0 RID: 143552
		[Nullable(2)]
		public CommonInteractOption Option;

		// Token: 0x040230C1 RID: 143553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, bool, CommonInteractOption> ConfirmCallback;
	}
}
