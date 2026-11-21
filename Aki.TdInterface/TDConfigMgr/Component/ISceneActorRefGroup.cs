using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000739 RID: 1849
	public class ISceneActorRefGroup
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x00069224 File Offset: 0x00067424
		private ISceneActorRefGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneActorRefGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneActorRefGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneActorRefGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0006925C File Offset: 0x0006745C
		public static ISceneActorRefGroup Create([Nullable(2)] ISceneActorRefGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneActorRefGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0006926F File Offset: 0x0006746F
		public static ISceneActorRefGroup CreateFromSetValue([Nullable(2)] ISceneActorRefGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneActorRefGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00069282 File Offset: 0x00067482
		public ISceneActorRefGroup_SetValue ToSetValue()
		{
			return new ISceneActorRefGroup_SetValue
			{
				EntityState = this.EntityState,
				Actions = this.Actions
			};
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000692A1 File Offset: 0x000674A1
		// (set) Token: 0x0600274B RID: 10059 RVA: 0x000692CC File Offset: 0x000674CC
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000692DC File Offset: 0x000674DC
		// (set) Token: 0x0600274D RID: 10061 RVA: 0x0006936F File Offset: 0x0006756F
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					ISceneActorRefGroup_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001AD5 RID: 6869
		[Nullable(2)]
		protected ISceneActorRefGroup FbInstance;

		// Token: 0x04001AD6 RID: 6870
		[Nullable(2)]
		protected ISceneActorRefGroup_SetValue PocoInterface;

		// Token: 0x04001AD7 RID: 6871
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001AD8 RID: 6872
		private bool _ActionsInited;
	}
}
