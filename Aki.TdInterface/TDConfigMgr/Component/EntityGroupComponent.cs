using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FD RID: 253
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityGroupComponent : IComponentBase
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
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

		// Token: 0x06000405 RID: 1029 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
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

		// Token: 0x06000406 RID: 1030 RVA: 0x0001D1FB File Offset: 0x0001B3FB
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

		// Token: 0x06000407 RID: 1031 RVA: 0x0001D210 File Offset: 0x0001B410
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001D26C File Offset: 0x0001B46C
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0001D2A6 File Offset: 0x0001B4A6
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

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0001D2DE File Offset: 0x0001B4DE
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

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0001D313 File Offset: 0x0001B513
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

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001D324 File Offset: 0x0001B524
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0001D3B7 File Offset: 0x0001B5B7
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

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0001D42D File Offset: 0x0001B62D
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001D444 File Offset: 0x0001B644
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0001D4A5 File Offset: 0x0001B6A5
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

		// Token: 0x04000547 RID: 1351
		[Nullable(2)]
		protected new EntityGroupComponent FbInstance;

		// Token: 0x04000548 RID: 1352
		[Nullable(2)]
		protected new EntityGroupComponent_SetValue PocoInterface;

		// Token: 0x04000549 RID: 1353
		private List<IEntityStateTrigger> _StateTriggersCache;

		// Token: 0x0400054A RID: 1354
		private bool _StateTriggersInited;

		// Token: 0x0400054B RID: 1355
		private IFinishStateTrigger _FinishStateCache;

		// Token: 0x0400054C RID: 1356
		private bool _FinishStateInited;

		// Token: 0x0400054D RID: 1357
		private IFailureStateTrigger _FailureStateCache;

		// Token: 0x0400054E RID: 1358
		private bool _FailureStateInited;
	}
}
