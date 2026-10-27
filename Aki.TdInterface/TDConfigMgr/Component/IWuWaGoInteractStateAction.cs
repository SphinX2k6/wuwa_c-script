using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000807 RID: 2055
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoInteractStateAction
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x00073B18 File Offset: 0x00071D18
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

		// Token: 0x06002C9A RID: 11418 RVA: 0x00073B50 File Offset: 0x00071D50
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

		// Token: 0x06002C9B RID: 11419 RVA: 0x00073B63 File Offset: 0x00071D63
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

		// Token: 0x06002C9C RID: 11420 RVA: 0x00073B76 File Offset: 0x00071D76
		public IWuWaGoInteractStateAction_SetValue ToSetValue()
		{
			return new IWuWaGoInteractStateAction_SetValue
			{
				EntityState = this.EntityState,
				ActionList = this.ActionList
			};
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x00073B95 File Offset: 0x00071D95
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x00073BC0 File Offset: 0x00071DC0
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x00073BD0 File Offset: 0x00071DD0
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x00073C63 File Offset: 0x00071E63
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

		// Token: 0x04001D83 RID: 7555
		[Nullable(2)]
		protected IWuWaGoInteractStateAction FbInstance;

		// Token: 0x04001D84 RID: 7556
		[Nullable(2)]
		protected IWuWaGoInteractStateAction_SetValue PocoInterface;

		// Token: 0x04001D85 RID: 7557
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionListCache;

		// Token: 0x04001D86 RID: 7558
		private bool _ActionListInited;
	}
}
