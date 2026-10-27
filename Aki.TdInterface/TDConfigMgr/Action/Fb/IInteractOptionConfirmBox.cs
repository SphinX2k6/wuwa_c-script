using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200260F RID: 9743
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractOptionConfirmBox
	{
		// Token: 0x0600DAC1 RID: 56001 RVA: 0x00209607 File Offset: 0x00207807
		public static IInteractOptionConfirmBox Create(IInteractOptionConfirmBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractOptionConfirmBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x0600DAC2 RID: 56002 RVA: 0x00209626 File Offset: 0x00207826
		public virtual IInteractionConfirmBoxType Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = ActionReadHelper.ReadIInteractOptionConfirmBox_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x0400797F RID: 31103
		private IInteractOptionConfirmBox Instance;

		// Token: 0x04007980 RID: 31104
		private IInteractionConfirmBoxType _TypeCache;

		// Token: 0x04007981 RID: 31105
		private bool _TypeInited;
	}
}
