using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000106 RID: 262
	public class EntityGroupComponent : IComponentBase
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x0001DB24 File Offset: 0x0001BD24
		private EntityGroupComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityGroupComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityGroupComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityGroupComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001DB5C File Offset: 0x0001BD5C
		public static EntityGroupComponent Create([Nullable(2)] EntityGroupComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityGroupComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001DB6F File Offset: 0x0001BD6F
		public static EntityGroupComponent CreateFromSetValue([Nullable(2)] EntityGroupComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityGroupComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001DB84 File Offset: 0x0001BD84
		public new EntityGroupComponent_SetValue ToSetValue()
		{
			return new EntityGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				EntityIds = this.EntityIds,
				StateTriggers = this.StateTriggers,
				FinishState = this.FinishState,
				FailureState = this.FailureState
			};
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0001DC1A File Offset: 0x0001BE1A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001DC28 File Offset: 0x0001BE28
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0001DC52 File Offset: 0x0001BE52
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001DC60 File Offset: 0x0001BE60
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0001DC87 File Offset: 0x0001BE87
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				EntityGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001DC98 File Offset: 0x0001BE98
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0001DD2B File Offset: 0x0001BF2B
		public virtual List<IEntityStateTrigger> StateTriggers
		{
			get
			{
				if (this._StateTriggersInited)
				{
					return this._StateTriggersCache;
				}
				this._StateTriggersInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityStateTrigger> stateTriggers = this.FbInstance.StateTriggers;
					if (stateTriggers != null)
					{
						this._StateTriggersCache = new List<IEntityStateTrigger>(stateTriggers.Count);
						for (int i = 0; i < stateTriggers.Count; i++)
						{
							this._StateTriggersCache.Add(IEntityStateTrigger.Create(stateTriggers[i]));
						}
					}
				}
				else
				{
					EntityGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._StateTriggersCache = ((pocoInterface != null) ? pocoInterface.StateTriggers : null);
				}
				return this._StateTriggersCache;
			}
			set
			{
				this.GetOrCreatePoco().StateTriggers = value;
				this._StateTriggersInited = false;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0001DD40 File Offset: 0x0001BF40
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0001DDA1 File Offset: 0x0001BFA1
		public virtual IFinishStateTrigger FinishState
		{
			get
			{
				if (this._FinishStateInited)
				{
					return this._FinishStateCache;
				}
				this._FinishStateInited = true;
				if (this.FbInstance != null)
				{
					this._FinishStateCache = IFinishStateTrigger.Create(this.FbInstance.FinishState);
				}
				else
				{
					EntityGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._FinishStateCache = ((pocoInterface != null) ? pocoInterface.FinishState : null);
				}
				return this._FinishStateCache;
			}
			set
			{
				this.GetOrCreatePoco().FinishState = value;
				this._FinishStateInited = false;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0001DE19 File Offset: 0x0001C019
		[Nullable(2)]
		public virtual IFailureStateTrigger FailureState
		{
			[NullableContext(2)]
			get
			{
				if (this._FailureStateInited)
				{
					return this._FailureStateCache;
				}
				this._FailureStateInited = true;
				if (this.FbInstance != null)
				{
					this._FailureStateCache = IFailureStateTrigger.Create(this.FbInstance.FailureState);
				}
				else
				{
					EntityGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._FailureStateCache = ((pocoInterface != null) ? pocoInterface.FailureState : null);
				}
				return this._FailureStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FailureState = value;
				this._FailureStateInited = false;
			}
		}

		// Token: 0x04000571 RID: 1393
		[Nullable(2)]
		protected new EntityGroupComponent FbInstance;

		// Token: 0x04000572 RID: 1394
		[Nullable(2)]
		protected new EntityGroupComponent_SetValue PocoInterface;

		// Token: 0x04000573 RID: 1395
		private List<IEntityStateTrigger> _StateTriggersCache;

		// Token: 0x04000574 RID: 1396
		private bool _StateTriggersInited;

		// Token: 0x04000575 RID: 1397
		private IFinishStateTrigger _FinishStateCache;

		// Token: 0x04000576 RID: 1398
		private bool _FinishStateInited;

		// Token: 0x04000577 RID: 1399
		private IFailureStateTrigger _FailureStateCache;

		// Token: 0x04000578 RID: 1400
		private bool _FailureStateInited;
	}
}
