using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A6 RID: 422
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent : IComponentBase
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00021C6C File Offset: 0x0001FE6C
		[NullableContext(0)]
		private GuideLineCreatorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("GuideLineCreatorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			GuideLineCreatorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new GuideLineCreatorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00021CA4 File Offset: 0x0001FEA4
		[NullableContext(0)]
		public static GuideLineCreatorComponent Create([Nullable(2)] GuideLineCreatorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GuideLineCreatorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00021CB7 File Offset: 0x0001FEB7
		[NullableContext(0)]
		public static GuideLineCreatorComponent CreateFromSetValue([Nullable(2)] GuideLineCreatorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new GuideLineCreatorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00021CCC File Offset: 0x0001FECC
		[NullableContext(0)]
		public new GuideLineCreatorComponent_SetValue ToSetValue()
		{
			return new GuideLineCreatorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ColorChangeOption = this.ColorChangeOption,
				SplineEntityId = this.SplineEntityId,
				ScanOption = this.ScanOption
			};
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00021D1C File Offset: 0x0001FF1C
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00021D56 File Offset: 0x0001FF56
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				GuideLineCreatorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00021D64 File Offset: 0x0001FF64
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00021D8E File Offset: 0x0001FF8E
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00021D9C File Offset: 0x0001FF9C
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00021DFD File Offset: 0x0001FFFD
		public virtual IColorChangeStrategyOfRGB ColorChangeOption
		{
			get
			{
				if (this._ColorChangeOptionInited)
				{
					return this._ColorChangeOptionCache;
				}
				this._ColorChangeOptionInited = true;
				if (this.FbInstance != null)
				{
					this._ColorChangeOptionCache = IColorChangeStrategyOfRGB.Create(this.FbInstance.ColorChangeOption);
				}
				else
				{
					GuideLineCreatorComponent_SetValue pocoInterface = this.PocoInterface;
					this._ColorChangeOptionCache = ((pocoInterface != null) ? pocoInterface.ColorChangeOption : null);
				}
				return this._ColorChangeOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().ColorChangeOption = value;
				this._ColorChangeOptionInited = false;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00021E12 File Offset: 0x00020012
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00021E3D File Offset: 0x0002003D
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00021E4C File Offset: 0x0002004C
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00021EAD File Offset: 0x000200AD
		public virtual IGuideLineCreatorScanOption ScanOption
		{
			get
			{
				if (this._ScanOptionInited)
				{
					return this._ScanOptionCache;
				}
				this._ScanOptionInited = true;
				if (this.FbInstance != null)
				{
					this._ScanOptionCache = IGuideLineCreatorScanOption.Create(this.FbInstance.ScanOption);
				}
				else
				{
					GuideLineCreatorComponent_SetValue pocoInterface = this.PocoInterface;
					this._ScanOptionCache = ((pocoInterface != null) ? pocoInterface.ScanOption : null);
				}
				return this._ScanOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().ScanOption = value;
				this._ScanOptionInited = false;
			}
		}

		// Token: 0x040007E5 RID: 2021
		protected new GuideLineCreatorComponent FbInstance;

		// Token: 0x040007E6 RID: 2022
		protected new GuideLineCreatorComponent_SetValue PocoInterface;

		// Token: 0x040007E7 RID: 2023
		[Nullable(0)]
		private IColorChangeStrategyOfRGB _ColorChangeOptionCache;

		// Token: 0x040007E8 RID: 2024
		private bool _ColorChangeOptionInited;

		// Token: 0x040007E9 RID: 2025
		[Nullable(0)]
		private IGuideLineCreatorScanOption _ScanOptionCache;

		// Token: 0x040007EA RID: 2026
		private bool _ScanOptionInited;
	}
}
