using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AF RID: 2223
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritLauncherComponent : IComponentBase
	{
		// Token: 0x060031D3 RID: 12755 RVA: 0x0007FD08 File Offset: 0x0007DF08
		private SunSpiritLauncherComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SunSpiritLauncherComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SunSpiritLauncherComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SunSpiritLauncherComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0007FD40 File Offset: 0x0007DF40
		public static SunSpiritLauncherComponent Create([Nullable(2)] SunSpiritLauncherComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SunSpiritLauncherComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x0007FD53 File Offset: 0x0007DF53
		public static SunSpiritLauncherComponent CreateFromSetValue([Nullable(2)] SunSpiritLauncherComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SunSpiritLauncherComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0007FD68 File Offset: 0x0007DF68
		public new SunSpiritLauncherComponent_SetValue ToSetValue()
		{
			return new SunSpiritLauncherComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				AreaId = this.AreaId,
				NeedsCount = this.NeedsCount,
				SunSpiritGearId = this.SunSpiritGearId
			};
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0007FDF2 File Offset: 0x0007DFF2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SunSpiritLauncherComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060031D9 RID: 12761 RVA: 0x0007FE00 File Offset: 0x0007E000
		// (set) Token: 0x060031DA RID: 12762 RVA: 0x0007FE2A File Offset: 0x0007E02A
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

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060031DB RID: 12763 RVA: 0x0007FE38 File Offset: 0x0007E038
		// (set) Token: 0x060031DC RID: 12764 RVA: 0x0007FE63 File Offset: 0x0007E063
		public virtual int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x0007FE71 File Offset: 0x0007E071
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x0007FE9C File Offset: 0x0007E09C
		public virtual int NeedsCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NeedsCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NeedsCount;
			}
			set
			{
				this.GetOrCreatePoco().NeedsCount = value;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x0007FEAA File Offset: 0x0007E0AA
		// (set) Token: 0x060031E0 RID: 12768 RVA: 0x0007FED5 File Offset: 0x0007E0D5
		public virtual int SunSpiritGearId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SunSpiritGearId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SunSpiritGearId;
			}
			set
			{
				this.GetOrCreatePoco().SunSpiritGearId = value;
			}
		}

		// Token: 0x040020AC RID: 8364
		[Nullable(2)]
		protected new SunSpiritLauncherComponent FbInstance;

		// Token: 0x040020AD RID: 8365
		[Nullable(2)]
		protected new SunSpiritLauncherComponent_SetValue PocoInterface;
	}
}
