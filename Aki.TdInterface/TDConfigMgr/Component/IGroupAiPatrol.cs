using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003FA RID: 1018
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiPatrol : IGroupAiMode
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x00041664 File Offset: 0x0003F864
		private IGroupAiPatrol_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiPatrol 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiPatrol_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiPatrol_SetValue());
			}
			return result;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0004169C File Offset: 0x0003F89C
		public static IGroupAiPatrol Create([Nullable(2)] IGroupAiPatrol instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiPatrol
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000416AF File Offset: 0x0003F8AF
		public static IGroupAiPatrol CreateFromSetValue([Nullable(2)] IGroupAiPatrol_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiPatrol
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x000416C4 File Offset: 0x0003F8C4
		public new IGroupAiPatrol_SetValue ToSetValue()
		{
			return new IGroupAiPatrol_SetValue
			{
				Type = this.Type,
				Leader = this.Leader,
				SplineEntityId = this.SplineEntityId,
				PlayerPlaceholderEntityId = this.PlayerPlaceholderEntityId,
				FormationBasis = this.FormationBasis,
				IsPreciseFormation = this.IsPreciseFormation,
				EcologyGameplayAbp = this.EcologyGameplayAbp
			};
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0004172A File Offset: 0x0003F92A
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00041755 File Offset: 0x0003F955
		public override EGroupAiMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiMode.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00041763 File Offset: 0x0003F963
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0004178E File Offset: 0x0003F98E
		public virtual int Leader
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Leader;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Leader;
			}
			set
			{
				this.GetOrCreatePoco().Leader = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0004179C File Offset: 0x0003F99C
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x000417C7 File Offset: 0x0003F9C7
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x000417D8 File Offset: 0x0003F9D8
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x00041812 File Offset: 0x0003FA12
		public virtual int? PlayerPlaceholderEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerPlaceholderEntityId;
				}
				IGroupAiPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerPlaceholderEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PlayerPlaceholderEntityId = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x00041820 File Offset: 0x0003FA20
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0004185A File Offset: 0x0003FA5A
		public virtual EGroupAiFormationBasis? FormationBasis
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FormationBasis;
				}
				IGroupAiPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FormationBasis;
			}
			set
			{
				this.GetOrCreatePoco().FormationBasis = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00041868 File Offset: 0x0003FA68
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x000418A2 File Offset: 0x0003FAA2
		public virtual bool? IsPreciseFormation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPreciseFormation;
				}
				IGroupAiPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPreciseFormation;
			}
			set
			{
				this.GetOrCreatePoco().IsPreciseFormation = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000418B0 File Offset: 0x0003FAB0
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x00041911 File Offset: 0x0003FB11
		[Nullable(2)]
		public virtual IGroupAiEcologyGameplayAbp EcologyGameplayAbp
		{
			[NullableContext(2)]
			get
			{
				if (this._EcologyGameplayAbpInited)
				{
					return this._EcologyGameplayAbpCache;
				}
				this._EcologyGameplayAbpInited = true;
				if (this.FbInstance != null)
				{
					this._EcologyGameplayAbpCache = IGroupAiEcologyGameplayAbp.Create(this.FbInstance.EcologyGameplayAbp);
				}
				else
				{
					IGroupAiPatrol_SetValue pocoInterface = this.PocoInterface;
					this._EcologyGameplayAbpCache = ((pocoInterface != null) ? pocoInterface.EcologyGameplayAbp : null);
				}
				return this._EcologyGameplayAbpCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EcologyGameplayAbp = value;
				this._EcologyGameplayAbpInited = false;
			}
		}

		// Token: 0x04001019 RID: 4121
		[Nullable(2)]
		protected new IGroupAiPatrol FbInstance;

		// Token: 0x0400101A RID: 4122
		[Nullable(2)]
		protected new IGroupAiPatrol_SetValue PocoInterface;

		// Token: 0x0400101B RID: 4123
		private IGroupAiEcologyGameplayAbp _EcologyGameplayAbpCache;

		// Token: 0x0400101C RID: 4124
		private bool _EcologyGameplayAbpInited;
	}
}
