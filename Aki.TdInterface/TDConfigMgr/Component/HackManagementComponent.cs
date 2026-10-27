using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000191 RID: 401
	[NullableContext(1)]
	[Nullable(0)]
	public class HackManagementComponent : IComponentBase
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x000212F8 File Offset: 0x0001F4F8
		private HackManagementComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HackManagementComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HackManagementComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HackManagementComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00021330 File Offset: 0x0001F530
		public static HackManagementComponent Create([Nullable(2)] HackManagementComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HackManagementComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00021343 File Offset: 0x0001F543
		public static HackManagementComponent CreateFromSetValue([Nullable(2)] HackManagementComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HackManagementComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00021356 File Offset: 0x0001F556
		public new HackManagementComponent_SetValue ToSetValue()
		{
			return new HackManagementComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MaxHackingCount = this.MaxHackingCount,
				ValidDistance = this.ValidDistance
			};
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00021390 File Offset: 0x0001F590
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x000213CA File Offset: 0x0001F5CA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				HackManagementComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x000213D8 File Offset: 0x0001F5D8
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00021402 File Offset: 0x0001F602
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00021410 File Offset: 0x0001F610
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0002143B File Offset: 0x0001F63B
		public virtual int MaxHackingCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxHackingCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxHackingCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxHackingCount = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00021449 File Offset: 0x0001F649
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00021478 File Offset: 0x0001F678
		public virtual float ValidDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ValidDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ValidDistance;
			}
			set
			{
				this.GetOrCreatePoco().ValidDistance = value;
			}
		}

		// Token: 0x0400079A RID: 1946
		[Nullable(2)]
		protected new HackManagementComponent FbInstance;

		// Token: 0x0400079B RID: 1947
		[Nullable(2)]
		protected new HackManagementComponent_SetValue PocoInterface;
	}
}
