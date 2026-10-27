using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000034 RID: 52
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffConsumerComponent : IComponentBase
	{
		// Token: 0x060001DC RID: 476 RVA: 0x000182D4 File Offset: 0x000164D4
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

		// Token: 0x060001DD RID: 477 RVA: 0x0001830C File Offset: 0x0001650C
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

		// Token: 0x060001DE RID: 478 RVA: 0x0001831F File Offset: 0x0001651F
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

		// Token: 0x060001DF RID: 479 RVA: 0x00018334 File Offset: 0x00016534
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00018384 File Offset: 0x00016584
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000183BE File Offset: 0x000165BE
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000183CC File Offset: 0x000165CC
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000183F6 File Offset: 0x000165F6
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00018404 File Offset: 0x00016604
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00018430 File Offset: 0x00016630
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00018440 File Offset: 0x00016640
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0001847A File Offset: 0x0001667A
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00018488 File Offset: 0x00016688
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000184C2 File Offset: 0x000166C2
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

		// Token: 0x04000135 RID: 309
		[Nullable(2)]
		protected new BuffConsumerComponent FbInstance;

		// Token: 0x04000136 RID: 310
		[Nullable(2)]
		protected new BuffConsumerComponent_SetValue PocoInterface;
	}
}
