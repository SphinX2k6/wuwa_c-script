using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000386 RID: 902
	public class IEventRotator
	{
		// Token: 0x0600119E RID: 4510 RVA: 0x0003BD98 File Offset: 0x00039F98
		private IEventRotator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEventRotator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEventRotator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEventRotator_SetValue());
			}
			return result;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003BDD0 File Offset: 0x00039FD0
		public static IEventRotator Create([Nullable(2)] IEventRotator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEventRotator
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003BDE3 File Offset: 0x00039FE3
		public static IEventRotator CreateFromSetValue([Nullable(2)] IEventRotator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEventRotator
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0003BDF6 File Offset: 0x00039FF6
		public IEventRotator_SetValue ToSetValue()
		{
			return new IEventRotator_SetValue
			{
				StartActions = this.StartActions,
				EndActions = this.EndActions
			};
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0003BE18 File Offset: 0x0003A018
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0003BEAB File Offset: 0x0003A0AB
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> StartActions
		{
			get
			{
				if (this._StartActionsInited)
				{
					return this._StartActionsCache;
				}
				this._StartActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> startActions = this.FbInstance.StartActions;
					if (startActions != null)
					{
						this._StartActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(startActions.Count);
						for (int i = 0; i < startActions.Count; i++)
						{
							this._StartActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(startActions[i]));
						}
					}
				}
				else
				{
					IEventRotator_SetValue pocoInterface = this.PocoInterface;
					this._StartActionsCache = ((pocoInterface != null) ? pocoInterface.StartActions : null);
				}
				return this._StartActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().StartActions = value;
				this._StartActionsInited = false;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0003BEC0 File Offset: 0x0003A0C0
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0003BF53 File Offset: 0x0003A153
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EndActions
		{
			get
			{
				if (this._EndActionsInited)
				{
					return this._EndActionsCache;
				}
				this._EndActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> endActions = this.FbInstance.EndActions;
					if (endActions != null)
					{
						this._EndActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(endActions.Count);
						for (int i = 0; i < endActions.Count; i++)
						{
							this._EndActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(endActions[i]));
						}
					}
				}
				else
				{
					IEventRotator_SetValue pocoInterface = this.PocoInterface;
					this._EndActionsCache = ((pocoInterface != null) ? pocoInterface.EndActions : null);
				}
				return this._EndActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().EndActions = value;
				this._EndActionsInited = false;
			}
		}

		// Token: 0x04000EB8 RID: 3768
		[Nullable(2)]
		protected IEventRotator FbInstance;

		// Token: 0x04000EB9 RID: 3769
		[Nullable(2)]
		protected IEventRotator_SetValue PocoInterface;

		// Token: 0x04000EBA RID: 3770
		private List<Aki.TDConfigMgr.Action.ActionInfo> _StartActionsCache;

		// Token: 0x04000EBB RID: 3771
		private bool _StartActionsInited;

		// Token: 0x04000EBC RID: 3772
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EndActionsCache;

		// Token: 0x04000EBD RID: 3773
		private bool _EndActionsInited;
	}
}
