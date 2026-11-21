using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000952 RID: 2386
	public class SunSpiritLauncherComponent : IComponentBase
	{
		// Token: 0x0600350F RID: 13583 RVA: 0x000871F0 File Offset: 0x000853F0
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

		// Token: 0x06003510 RID: 13584 RVA: 0x00087228 File Offset: 0x00085428
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

		// Token: 0x06003511 RID: 13585 RVA: 0x0008723B File Offset: 0x0008543B
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

		// Token: 0x06003512 RID: 13586 RVA: 0x00087250 File Offset: 0x00085450
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

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x000872A0 File Offset: 0x000854A0
		// (set) Token: 0x06003514 RID: 13588 RVA: 0x000872DA File Offset: 0x000854DA
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

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x000872E8 File Offset: 0x000854E8
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x00087312 File Offset: 0x00085512
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

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x00087320 File Offset: 0x00085520
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x0008734B File Offset: 0x0008554B
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00087359 File Offset: 0x00085559
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x00087384 File Offset: 0x00085584
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

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x00087392 File Offset: 0x00085592
		// (set) Token: 0x0600351C RID: 13596 RVA: 0x000873BD File Offset: 0x000855BD
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

		// Token: 0x040022BE RID: 8894
		[Nullable(2)]
		protected new SunSpiritLauncherComponent FbInstance;

		// Token: 0x040022BF RID: 8895
		[Nullable(2)]
		protected new SunSpiritLauncherComponent_SetValue PocoInterface;
	}
}
