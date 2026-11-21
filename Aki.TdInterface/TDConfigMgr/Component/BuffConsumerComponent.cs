using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000034 RID: 52
	public class BuffConsumerComponent : IComponentBase
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00018C48 File Offset: 0x00016E48
		private BuffConsumerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BuffConsumerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BuffConsumerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BuffConsumerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00018C80 File Offset: 0x00016E80
		public static BuffConsumerComponent Create([Nullable(2)] BuffConsumerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BuffConsumerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00018C93 File Offset: 0x00016E93
		public static BuffConsumerComponent CreateFromSetValue([Nullable(2)] BuffConsumerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BuffConsumerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00018CA8 File Offset: 0x00016EA8
		public new BuffConsumerComponent_SetValue ToSetValue()
		{
			return new BuffConsumerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BuffId = this.BuffId,
				BulletId = this.BulletId,
				ProducerEntityId = this.ProducerEntityId
			};
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00018CF8 File Offset: 0x00016EF8
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00018D32 File Offset: 0x00016F32
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				BuffConsumerComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00018D40 File Offset: 0x00016F40
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00018D6A File Offset: 0x00016F6A
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00018D78 File Offset: 0x00016F78
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00018DA4 File Offset: 0x00016FA4
		public virtual long BuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BuffId;
			}
			set
			{
				this.GetOrCreatePoco().BuffId = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00018DB4 File Offset: 0x00016FB4
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00018DEE File Offset: 0x00016FEE
		public virtual long? BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				BuffConsumerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00018DFC File Offset: 0x00016FFC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00018E36 File Offset: 0x00017036
		public virtual int? ProducerEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProducerEntityId;
				}
				BuffConsumerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProducerEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ProducerEntityId = value;
			}
		}

		// Token: 0x0400013A RID: 314
		[Nullable(2)]
		protected new BuffConsumerComponent FbInstance;

		// Token: 0x0400013B RID: 315
		[Nullable(2)]
		protected new BuffConsumerComponent_SetValue PocoInterface;
	}
}
