using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002561 RID: 9569
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgPlayRoleAction : ActionParams
	{
		// Token: 0x0600D6DC RID: 55004 RVA: 0x00200696 File Offset: 0x001FE896
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

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x0600D6DD RID: 55005 RVA: 0x002006B8 File Offset: 0x001FE8B8
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

		// Token: 0x040076FF RID: 30463
		private IAvgPlayRoleAction Instance;

		// Token: 0x04007700 RID: 30464
		private List<IAvgPlayRoleActionItem> _RoleActionListCache;

		// Token: 0x04007701 RID: 30465
		private bool _RoleActionListInited;
	}
}
