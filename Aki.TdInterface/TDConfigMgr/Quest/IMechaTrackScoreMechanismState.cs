using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001135 RID: 4405
	public class IMechaTrackScoreMechanismState : IMechaTrackScoreDetectionType
	{
		// Token: 0x0600617E RID: 24958 RVA: 0x000EB160 File Offset: 0x000E9360
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

		// Token: 0x0600617F RID: 24959 RVA: 0x000EB198 File Offset: 0x000E9398
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

		// Token: 0x06006180 RID: 24960 RVA: 0x000EB1AB File Offset: 0x000E93AB
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

		// Token: 0x06006181 RID: 24961 RVA: 0x000EB1BE File Offset: 0x000E93BE
		public new IMechaTrackScoreMechanismState_SetValue ToSetValue()
		{
			return new IMechaTrackScoreMechanismState_SetValue
			{
				Type = this.Type,
				MechanismStateTypes = this.MechanismStateTypes
			};
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006182 RID: 24962 RVA: 0x000EB1DD File Offset: 0x000E93DD
		// (set) Token: 0x06006183 RID: 24963 RVA: 0x000EB208 File Offset: 0x000E9408
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

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x000EB218 File Offset: 0x000E9418
		// (set) Token: 0x06006185 RID: 24965 RVA: 0x000EB2AB File Offset: 0x000E94AB
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

		// Token: 0x04003A68 RID: 14952
		[Nullable(2)]
		protected new IMechaTrackScoreMechanismState FbInstance;

		// Token: 0x04003A69 RID: 14953
		[Nullable(2)]
		protected new IMechaTrackScoreMechanismState_SetValue PocoInterface;

		// Token: 0x04003A6A RID: 14954
		private List<IMechaTrackScoreMechanismStateType> _MechanismStateTypesCache;

		// Token: 0x04003A6B RID: 14955
		private bool _MechanismStateTypesInited;
	}
}
