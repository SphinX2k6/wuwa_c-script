using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DA RID: 10714
	public class UnlockSystemItem : ActionParams
	{
		// Token: 0x0600ED11 RID: 60689 RVA: 0x0022DBBF File Offset: 0x0022BDBF
		public static UnlockSystemItem Create(IUnlockSystemItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockSystemItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x0600ED12 RID: 60690 RVA: 0x0022DBDE File Offset: 0x0022BDDE
		public virtual IUnlockSystemItemType SystemOption
		{
			get
			{
				if (this._SystemOptionInited)
				{
					return this._SystemOptionCache;
				}
				this._SystemOptionInited = true;
				this._SystemOptionCache = ActionReadHelper.ReadUnlockSystemItem_SystemOption(this.Instance);
				return this._SystemOptionCache;
			}
		}

		// Token: 0x04008278 RID: 33400
		private IUnlockSystemItem Instance;

		// Token: 0x04008279 RID: 33401
		private IUnlockSystemItemType _SystemOptionCache;

		// Token: 0x0400827A RID: 33402
		private bool _SystemOptionInited;
	}
}
