using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054B RID: 1355
	public class IMechHookInteractConfig
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x0004FC84 File Offset: 0x0004DE84
		private IMechHookInteractConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechHookInteractConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechHookInteractConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechHookInteractConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0004FCBC File Offset: 0x0004DEBC
		public static IMechHookInteractConfig Create([Nullable(2)] IMechHookInteractConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookInteractConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0004FCCF File Offset: 0x0004DECF
		public static IMechHookInteractConfig CreateFromSetValue([Nullable(2)] IMechHookInteractConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechHookInteractConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		public IMechHookInteractConfig_SetValue ToSetValue()
		{
			return new IMechHookInteractConfig_SetValue
			{
				InteractType = this.InteractType,
				MechHookAcceleration = this.MechHookAcceleration,
				SectorRange = this.SectorRange,
				Radius = this.Radius,
				NonInteractiveInnerRadius = this.NonInteractiveInnerRadius
			};
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0004FD32 File Offset: 0x0004DF32
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0004FD59 File Offset: 0x0004DF59
		public virtual IMechHookInteractType InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				IMechHookInteractConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0004FD68 File Offset: 0x0004DF68
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0004FDC9 File Offset: 0x0004DFC9
		[Nullable(2)]
		public virtual IMechHookAcceleration MechHookAcceleration
		{
			[NullableContext(2)]
			get
			{
				if (this._MechHookAccelerationInited)
				{
					return this._MechHookAccelerationCache;
				}
				this._MechHookAccelerationInited = true;
				if (this.FbInstance != null)
				{
					this._MechHookAccelerationCache = IMechHookAcceleration.Create(this.FbInstance.MechHookAcceleration);
				}
				else
				{
					IMechHookInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._MechHookAccelerationCache = ((pocoInterface != null) ? pocoInterface.MechHookAcceleration : null);
				}
				return this._MechHookAccelerationCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MechHookAcceleration = value;
				this._MechHookAccelerationInited = false;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0004FE41 File Offset: 0x0004E041
		[Nullable(2)]
		public virtual IInteractSectorRange SectorRange
		{
			[NullableContext(2)]
			get
			{
				if (this._SectorRangeInited)
				{
					return this._SectorRangeCache;
				}
				this._SectorRangeInited = true;
				if (this.FbInstance != null)
				{
					this._SectorRangeCache = IInteractSectorRange.Create(this.FbInstance.SectorRange);
				}
				else
				{
					IMechHookInteractConfig_SetValue pocoInterface = this.PocoInterface;
					this._SectorRangeCache = ((pocoInterface != null) ? pocoInterface.SectorRange : null);
				}
				return this._SectorRangeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SectorRange = value;
				this._SectorRangeInited = false;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0004FE58 File Offset: 0x0004E058
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0004FE92 File Offset: 0x0004E092
		public virtual float? Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				IMechHookInteractConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0004FEA0 File Offset: 0x0004E0A0
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0004FEDA File Offset: 0x0004E0DA
		public virtual float? NonInteractiveInnerRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NonInteractiveInnerRadius;
				}
				IMechHookInteractConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NonInteractiveInnerRadius;
			}
			set
			{
				this.GetOrCreatePoco().NonInteractiveInnerRadius = value;
			}
		}

		// Token: 0x04001402 RID: 5122
		[Nullable(2)]
		protected IMechHookInteractConfig FbInstance;

		// Token: 0x04001403 RID: 5123
		[Nullable(2)]
		protected IMechHookInteractConfig_SetValue PocoInterface;

		// Token: 0x04001404 RID: 5124
		private IMechHookAcceleration _MechHookAccelerationCache;

		// Token: 0x04001405 RID: 5125
		private bool _MechHookAccelerationInited;

		// Token: 0x04001406 RID: 5126
		private IInteractSectorRange _SectorRangeCache;

		// Token: 0x04001407 RID: 5127
		private bool _SectorRangeInited;
	}
}
