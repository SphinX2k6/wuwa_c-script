using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C10 RID: 11280
	public class IInteractiveItemsFunction : EnableFunction
	{
		// Token: 0x0600F852 RID: 63570 RVA: 0x00241AF8 File Offset: 0x0023FCF8
		public static IInteractiveItemsFunction Create(IInteractiveItemsFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractiveItemsFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x0600F853 RID: 63571 RVA: 0x00241B17 File Offset: 0x0023FD17
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x0600F854 RID: 63572 RVA: 0x00241B24 File Offset: 0x0023FD24
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x040087E0 RID: 34784
		private IInteractiveItemsFunction Instance;
	}
}
