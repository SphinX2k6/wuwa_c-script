using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CF RID: 10447
	public class IInteractOptionConfirmBox
	{
		// Token: 0x0600E88E RID: 59534 RVA: 0x00225D5B File Offset: 0x00223F5B
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

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x0600E88F RID: 59535 RVA: 0x00225D7A File Offset: 0x00223F7A
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

		// Token: 0x04008019 RID: 32793
		private IInteractOptionConfirmBox Instance;

		// Token: 0x0400801A RID: 32794
		private IInteractionConfirmBoxType _TypeCache;

		// Token: 0x0400801B RID: 32795
		private bool _TypeInited;
	}
}
