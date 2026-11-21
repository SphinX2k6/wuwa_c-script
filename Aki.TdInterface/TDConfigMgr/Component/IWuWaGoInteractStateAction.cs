using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AA RID: 2218
	public class IWuWaGoInteractStateAction
	{
		// Token: 0x06002FC9 RID: 12233 RVA: 0x0007AE7C File Offset: 0x0007907C
		private IWuWaGoInteractStateAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoInteractStateAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoInteractStateAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoInteractStateAction_SetValue());
			}
			return result;
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0007AEB4 File Offset: 0x000790B4
		public static IWuWaGoInteractStateAction Create([Nullable(2)] IWuWaGoInteractStateAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoInteractStateAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0007AEC7 File Offset: 0x000790C7
		public static IWuWaGoInteractStateAction CreateFromSetValue([Nullable(2)] IWuWaGoInteractStateAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoInteractStateAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0007AEDA File Offset: 0x000790DA
		public IWuWaGoInteractStateAction_SetValue ToSetValue()
		{
			return new IWuWaGoInteractStateAction_SetValue
			{
				EntityState = this.EntityState,
				ActionList = this.ActionList
			};
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x0007AEF9 File Offset: 0x000790F9
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x0007AF24 File Offset: 0x00079124
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x0007AF34 File Offset: 0x00079134
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x0007AFC7 File Offset: 0x000791C7
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ActionList
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
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actionList = this.FbInstance.ActionList;
					if (actionList != null)
					{
						this._ActionListCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actionList.Count);
						for (int i = 0; i < actionList.Count; i++)
						{
							this._ActionListCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actionList[i]));
						}
					}
				}
				else
				{
					IWuWaGoInteractStateAction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001F8F RID: 8079
		[Nullable(2)]
		protected IWuWaGoInteractStateAction FbInstance;

		// Token: 0x04001F90 RID: 8080
		[Nullable(2)]
		protected IWuWaGoInteractStateAction_SetValue PocoInterface;

		// Token: 0x04001F91 RID: 8081
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionListCache;

		// Token: 0x04001F92 RID: 8082
		private bool _ActionListInited;
	}
}
