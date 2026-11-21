using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015FE RID: 5630
	public class AvgPlayRoleAction : ActionParams
	{
		// Token: 0x06007F27 RID: 32551 RVA: 0x0012F5C8 File Offset: 0x0012D7C8
		private AvgPlayRoleAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgPlayRoleAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgPlayRoleAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgPlayRoleAction_SetValue());
			}
			return result;
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x0012F600 File Offset: 0x0012D800
		public static AvgPlayRoleAction Create([Nullable(2)] AvgPlayRoleAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgPlayRoleAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x0012F613 File Offset: 0x0012D813
		public static AvgPlayRoleAction CreateFromSetValue([Nullable(2)] AvgPlayRoleAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgPlayRoleAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x0012F626 File Offset: 0x0012D826
		public AvgPlayRoleAction_SetValue ToSetValue()
		{
			return new AvgPlayRoleAction_SetValue
			{
				RoleActionList = this.RoleActionList
			};
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x0012F63C File Offset: 0x0012D83C
		// (set) Token: 0x06007F2C RID: 32556 RVA: 0x0012F6CF File Offset: 0x0012D8CF
		public virtual List<IAvgPlayRoleActionItem> RoleActionList
		{
			get
			{
				if (this._RoleActionListInited)
				{
					return this._RoleActionListCache;
				}
				this._RoleActionListInited = true;
				if (this.FbInstance != null)
				{
					List<IAvgPlayRoleActionItem> roleActionList = this.FbInstance.RoleActionList;
					if (roleActionList != null)
					{
						this._RoleActionListCache = new List<IAvgPlayRoleActionItem>(roleActionList.Count);
						for (int i = 0; i < roleActionList.Count; i++)
						{
							this._RoleActionListCache.Add(IAvgPlayRoleActionItem.Create(roleActionList[i]));
						}
					}
				}
				else
				{
					AvgPlayRoleAction_SetValue pocoInterface = this.PocoInterface;
					this._RoleActionListCache = ((pocoInterface != null) ? pocoInterface.RoleActionList : null);
				}
				return this._RoleActionListCache;
			}
			set
			{
				this.GetOrCreatePoco().RoleActionList = value;
				this._RoleActionListInited = false;
			}
		}

		// Token: 0x0400498E RID: 18830
		[Nullable(2)]
		protected new AvgPlayRoleAction FbInstance;

		// Token: 0x0400498F RID: 18831
		[Nullable(2)]
		protected AvgPlayRoleAction_SetValue PocoInterface;

		// Token: 0x04004990 RID: 18832
		private List<IAvgPlayRoleActionItem> _RoleActionListCache;

		// Token: 0x04004991 RID: 18833
		private bool _RoleActionListInited;
	}
}
