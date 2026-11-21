using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A8 RID: 424
	public class HackManagementComponent : IComponentBase
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x00021ED4 File Offset: 0x000200D4
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

		// Token: 0x060005D9 RID: 1497 RVA: 0x00021F0C File Offset: 0x0002010C
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

		// Token: 0x060005DA RID: 1498 RVA: 0x00021F1F File Offset: 0x0002011F
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

		// Token: 0x060005DB RID: 1499 RVA: 0x00021F32 File Offset: 0x00020132
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00021F6C File Offset: 0x0002016C
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00021FA6 File Offset: 0x000201A6
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00021FB4 File Offset: 0x000201B4
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00021FDE File Offset: 0x000201DE
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00021FEC File Offset: 0x000201EC
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00022017 File Offset: 0x00020217
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00022025 File Offset: 0x00020225
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00022054 File Offset: 0x00020254
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

		// Token: 0x040007F0 RID: 2032
		[Nullable(2)]
		protected new HackManagementComponent FbInstance;

		// Token: 0x040007F1 RID: 2033
		[Nullable(2)]
		protected new HackManagementComponent_SetValue PocoInterface;
	}
}
