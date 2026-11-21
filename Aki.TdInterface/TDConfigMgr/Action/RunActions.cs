using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E0 RID: 9184
	public class RunActions : ActionParams
	{
		// Token: 0x0600C804 RID: 51204 RVA: 0x001C9948 File Offset: 0x001C7B48
		private RunActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RunActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RunActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RunActions_SetValue());
			}
			return result;
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x001C9980 File Offset: 0x001C7B80
		public static RunActions Create([Nullable(2)] RunActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RunActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x001C9993 File Offset: 0x001C7B93
		public static RunActions CreateFromSetValue([Nullable(2)] RunActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RunActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x001C99A6 File Offset: 0x001C7BA6
		public RunActions_SetValue ToSetValue()
		{
			return new RunActions_SetValue
			{
				ActionList = this.ActionList
			};
		}

		// Token: 0x17003C4A RID: 15434
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x001C99BC File Offset: 0x001C7BBC
		// (set) Token: 0x0600C809 RID: 51209 RVA: 0x001C9A4F File Offset: 0x001C7C4F
		public virtual List<ActionInfo> ActionList
		{
			get
			{
				if (this._ActionListInited)
				{
					return this._ActionListCache;
				}
				this._ActionListInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actionList = this.FbInstance.ActionList;
					if (actionList != null)
					{
						this._ActionListCache = new List<ActionInfo>(actionList.Count);
						for (int i = 0; i < actionList.Count; i++)
						{
							this._ActionListCache.Add(ActionInfo.Create(actionList[i]));
						}
					}
				}
				else
				{
					RunActions_SetValue pocoInterface = this.PocoInterface;
					this._ActionListCache = ((pocoInterface != null) ? pocoInterface.ActionList : null);
				}
				return this._ActionListCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionList = value;
				this._ActionListInited = false;
			}
		}

		// Token: 0x040076C1 RID: 30401
		[Nullable(2)]
		protected new RunActions FbInstance;

		// Token: 0x040076C2 RID: 30402
		[Nullable(2)]
		protected RunActions_SetValue PocoInterface;

		// Token: 0x040076C3 RID: 30403
		private List<ActionInfo> _ActionListCache;

		// Token: 0x040076C4 RID: 30404
		private bool _ActionListInited;
	}
}
