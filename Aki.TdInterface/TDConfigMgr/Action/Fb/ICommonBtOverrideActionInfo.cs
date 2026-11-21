using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D6D RID: 11629
	public class ICommonBtOverrideActionInfo : ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x0600FDBD RID: 64957 RVA: 0x0024A1A8 File Offset: 0x002483A8
		public static ICommonBtOverrideActionInfo Create(ICommonBtOverrideActionInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideActionInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x0600FDBE RID: 64958 RVA: 0x0024A1C7 File Offset: 0x002483C7
		public override ECommonBtPlaceholderTargetType Type
		{
			get
			{
				return (ECommonBtPlaceholderTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x0600FDBF RID: 64959 RVA: 0x0024A1D4 File Offset: 0x002483D4
		public virtual ActionInfo Action
		{
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				this._ActionCache = ActionInfo.Create(this.Instance.Action);
				return this._ActionCache;
			}
		}

		// Token: 0x04008A87 RID: 35463
		private ICommonBtOverrideActionInfo Instance;

		// Token: 0x04008A88 RID: 35464
		[Nullable(2)]
		private ActionInfo _ActionCache;

		// Token: 0x04008A89 RID: 35465
		private bool _ActionInited;
	}
}
