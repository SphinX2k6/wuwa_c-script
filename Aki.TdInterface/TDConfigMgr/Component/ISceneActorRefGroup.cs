using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000698 RID: 1688
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneActorRefGroup
	{
		// Token: 0x0600242A RID: 9258 RVA: 0x0006225C File Offset: 0x0006045C
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

		// Token: 0x0600242B RID: 9259 RVA: 0x00062294 File Offset: 0x00060494
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

		// Token: 0x0600242C RID: 9260 RVA: 0x000622A7 File Offset: 0x000604A7
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

		// Token: 0x0600242D RID: 9261 RVA: 0x000622BA File Offset: 0x000604BA
		public ISceneActorRefGroup_SetValue ToSetValue()
		{
			return new ISceneActorRefGroup_SetValue
			{
				EntityState = this.EntityState,
				Actions = this.Actions
			};
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000622D9 File Offset: 0x000604D9
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x00062304 File Offset: 0x00060504
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x00062314 File Offset: 0x00060514
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x000623A7 File Offset: 0x000605A7
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

		// Token: 0x040018D8 RID: 6360
		[Nullable(2)]
		protected ISceneActorRefGroup FbInstance;

		// Token: 0x040018D9 RID: 6361
		[Nullable(2)]
		protected ISceneActorRefGroup_SetValue PocoInterface;

		// Token: 0x040018DA RID: 6362
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040018DB RID: 6363
		private bool _ActionsInited;
	}
}
