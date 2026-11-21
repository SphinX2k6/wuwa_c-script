using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B06 RID: 23302
	public class InteractSecondConfirmContext : GeneralContext
	{
		// Token: 0x060394A7 RID: 234663 RVA: 0x0100A6BD File Offset: 0x010088BD
		public InteractSecondConfirmContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.InteractSecondConfirm);
		}

		// Token: 0x060394A8 RID: 234664 RVA: 0x0100A6D4 File Offset: 0x010088D4
		[NullableContext(1)]
		public static InteractSecondConfirmContext Create(int handle, CommonInteractOption option)
		{
			InteractSecondConfirmContext interactSecondConfirmContext = GeneralContext.GetObj(EGeneralContextType.InteractSecondConfirm, null, () => new InteractSecondConfirmContext()) as InteractSecondConfirmContext;
			interactSecondConfirmContext.Handle = handle;
			interactSecondConfirmContext.Option = option;
			return interactSecondConfirmContext;
		}

		// Token: 0x0401E2A9 RID: 123561
		public int Handle;

		// Token: 0x0401E2AA RID: 123562
		[Nullable(2)]
		public CommonInteractOption Option;

		// Token: 0x0401E2AB RID: 123563
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, bool, CommonInteractOption> ConfirmCallback;
	}
}
