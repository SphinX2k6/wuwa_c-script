using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280A RID: 10250
	public class AvgPlayRoleAction : ActionParams
	{
		// Token: 0x0600E446 RID: 58438 RVA: 0x0021C292 File Offset: 0x0021A492
		public static AvgPlayRoleAction Create(IAvgPlayRoleAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgPlayRoleAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x0600E447 RID: 58439 RVA: 0x0021C2B4 File Offset: 0x0021A4B4
		public virtual List<IAvgPlayRoleActionItem> RoleActionList
		{
			get
			{
				if (this._RoleActionListInited)
				{
					return this._RoleActionListCache;
				}
				this._RoleActionListInited = true;
				int roleActionListLength = this.Instance.RoleActionListLength;
				this._RoleActionListCache = new List<IAvgPlayRoleActionItem>(roleActionListLength);
				for (int i = 0; i < roleActionListLength; i++)
				{
					this._RoleActionListCache.Add(IAvgPlayRoleActionItem.Create(this.Instance.RoleActionList(i)));
				}
				return this._RoleActionListCache;
			}
		}

		// Token: 0x04007D5C RID: 32092
		private IAvgPlayRoleAction Instance;

		// Token: 0x04007D5D RID: 32093
		private List<IAvgPlayRoleActionItem> _RoleActionListCache;

		// Token: 0x04007D5E RID: 32094
		private bool _RoleActionListInited;
	}
}
