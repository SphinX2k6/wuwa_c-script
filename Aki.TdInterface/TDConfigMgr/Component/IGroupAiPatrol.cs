using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000453 RID: 1107
	public class IGroupAiPatrol : IGroupAiMode
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x000453AC File Offset: 0x000435AC
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

		// Token: 0x0600161A RID: 5658 RVA: 0x000453E4 File Offset: 0x000435E4
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

		// Token: 0x0600161B RID: 5659 RVA: 0x000453F7 File Offset: 0x000435F7
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

		// Token: 0x0600161C RID: 5660 RVA: 0x0004540C File Offset: 0x0004360C
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00045472 File Offset: 0x00043672
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x0004549D File Offset: 0x0004369D
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

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x000454AB File Offset: 0x000436AB
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x000454D6 File Offset: 0x000436D6
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

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x000454E4 File Offset: 0x000436E4
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x0004550F File Offset: 0x0004370F
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00045520 File Offset: 0x00043720
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x0004555A File Offset: 0x0004375A
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

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00045568 File Offset: 0x00043768
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x000455A2 File Offset: 0x000437A2
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x000455B0 File Offset: 0x000437B0
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x000455EA File Offset: 0x000437EA
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

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x000455F8 File Offset: 0x000437F8
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00045659 File Offset: 0x00043859
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

		// Token: 0x0400113B RID: 4411
		[Nullable(2)]
		protected new IGroupAiPatrol FbInstance;

		// Token: 0x0400113C RID: 4412
		[Nullable(2)]
		protected new IGroupAiPatrol_SetValue PocoInterface;

		// Token: 0x0400113D RID: 4413
		private IGroupAiEcologyGameplayAbp _EcologyGameplayAbpCache;

		// Token: 0x0400113E RID: 4414
		private bool _EcologyGameplayAbpInited;
	}
}
