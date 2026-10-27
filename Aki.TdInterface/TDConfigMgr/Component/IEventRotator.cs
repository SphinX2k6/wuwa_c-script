using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033F RID: 831
	[NullableContext(1)]
	[Nullable(0)]
	public class IEventRotator
	{
		// Token: 0x0600106C RID: 4204 RVA: 0x00038DCC File Offset: 0x00036FCC
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

		// Token: 0x0600106D RID: 4205 RVA: 0x00038E04 File Offset: 0x00037004
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

		// Token: 0x0600106E RID: 4206 RVA: 0x00038E17 File Offset: 0x00037017
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

		// Token: 0x0600106F RID: 4207 RVA: 0x00038E2A File Offset: 0x0003702A
		public IEventRotator_SetValue ToSetValue()
		{
			return new IEventRotator_SetValue
			{
				StartActions = this.StartActions,
				EndActions = this.EndActions
			};
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00038E4C File Offset: 0x0003704C
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00038EDF File Offset: 0x000370DF
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00038EF4 File Offset: 0x000370F4
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00038F87 File Offset: 0x00037187
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

		// Token: 0x04000DCD RID: 3533
		[Nullable(2)]
		protected IEventRotator FbInstance;

		// Token: 0x04000DCE RID: 3534
		[Nullable(2)]
		protected IEventRotator_SetValue PocoInterface;

		// Token: 0x04000DCF RID: 3535
		private List<Aki.TDConfigMgr.Action.ActionInfo> _StartActionsCache;

		// Token: 0x04000DD0 RID: 3536
		private bool _StartActionsInited;

		// Token: 0x04000DD1 RID: 3537
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EndActionsCache;

		// Token: 0x04000DD2 RID: 3538
		private bool _EndActionsInited;
	}
}
