using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A5 RID: 5285
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgPlayRoleAction : ActionParams
	{
		// Token: 0x0600785A RID: 30810 RVA: 0x0012097C File Offset: 0x0011EB7C
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

		// Token: 0x0600785B RID: 30811 RVA: 0x001209B4 File Offset: 0x0011EBB4
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

		// Token: 0x0600785C RID: 30812 RVA: 0x001209C7 File Offset: 0x0011EBC7
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

		// Token: 0x0600785D RID: 30813 RVA: 0x001209DA File Offset: 0x0011EBDA
		public AvgPlayRoleAction_SetValue ToSetValue()
		{
			return new AvgPlayRoleAction_SetValue
			{
				RoleActionList = this.RoleActionList
			};
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x001209F0 File Offset: 0x0011EBF0
		// (set) Token: 0x0600785F RID: 30815 RVA: 0x00120A83 File Offset: 0x0011EC83
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

		// Token: 0x040045F3 RID: 17907
		[Nullable(2)]
		protected new AvgPlayRoleAction FbInstance;

		// Token: 0x040045F4 RID: 17908
		[Nullable(2)]
		protected AvgPlayRoleAction_SetValue PocoInterface;

		// Token: 0x040045F5 RID: 17909
		private List<IAvgPlayRoleActionItem> _RoleActionListCache;

		// Token: 0x040045F6 RID: 17910
		private bool _RoleActionListInited;
	}
}
