using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001009 RID: 4105
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreMechanismState : IMechaTrackScoreDetectionType
	{
		// Token: 0x06005B9E RID: 23454 RVA: 0x000DE520 File Offset: 0x000DC720
		private IMechaTrackScoreMechanismState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackScoreMechanismState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackScoreMechanismState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackScoreMechanismState_SetValue());
			}
			return result;
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x000DE558 File Offset: 0x000DC758
		public static IMechaTrackScoreMechanismState Create([Nullable(2)] IMechaTrackScoreMechanismState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BA0 RID: 23456 RVA: 0x000DE56B File Offset: 0x000DC76B
		public static IMechaTrackScoreMechanismState CreateFromSetValue([Nullable(2)] IMechaTrackScoreMechanismState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x000DE57E File Offset: 0x000DC77E
		public new IMechaTrackScoreMechanismState_SetValue ToSetValue()
		{
			return new IMechaTrackScoreMechanismState_SetValue
			{
				Type = this.Type,
				MechanismStateTypes = this.MechanismStateTypes
			};
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x000DE59D File Offset: 0x000DC79D
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x000DE5C8 File Offset: 0x000DC7C8
		public override EMechaTrackScoreDetectionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechaTrackScoreDetectionType.StuntAction;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x000DE5D8 File Offset: 0x000DC7D8
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x000DE66B File Offset: 0x000DC86B
		public virtual List<IMechaTrackScoreMechanismStateType> MechanismStateTypes
		{
			get
			{
				if (this._MechanismStateTypesInited)
				{
					return this._MechanismStateTypesCache;
				}
				this._MechanismStateTypesInited = true;
				if (this.FbInstance != null)
				{
					List<IMechaTrackScoreMechanismStateType> mechanismStateTypes = this.FbInstance.MechanismStateTypes;
					if (mechanismStateTypes != null)
					{
						this._MechanismStateTypesCache = new List<IMechaTrackScoreMechanismStateType>(mechanismStateTypes.Count);
						for (int i = 0; i < mechanismStateTypes.Count; i++)
						{
							this._MechanismStateTypesCache.Add(IMechaTrackScoreMechanismStateType.Create(mechanismStateTypes[i]));
						}
					}
				}
				else
				{
					IMechaTrackScoreMechanismState_SetValue pocoInterface = this.PocoInterface;
					this._MechanismStateTypesCache = ((pocoInterface != null) ? pocoInterface.MechanismStateTypes : null);
				}
				return this._MechanismStateTypesCache;
			}
			set
			{
				this.GetOrCreatePoco().MechanismStateTypes = value;
				this._MechanismStateTypesInited = false;
			}
		}

		// Token: 0x04003730 RID: 14128
		[Nullable(2)]
		protected new IMechaTrackScoreMechanismState FbInstance;

		// Token: 0x04003731 RID: 14129
		[Nullable(2)]
		protected new IMechaTrackScoreMechanismState_SetValue PocoInterface;

		// Token: 0x04003732 RID: 14130
		private List<IMechaTrackScoreMechanismStateType> _MechanismStateTypesCache;

		// Token: 0x04003733 RID: 14131
		private bool _MechanismStateTypesInited;
	}
}
