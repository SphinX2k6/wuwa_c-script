using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018F RID: 399
	[NullableContext(2)]
	[Nullable(0)]
	public class GuideLineCreatorComponent : IComponentBase
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00021090 File Offset: 0x0001F290
		[NullableContext(1)]
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

		// Token: 0x060005B5 RID: 1461 RVA: 0x000210C8 File Offset: 0x0001F2C8
		[NullableContext(1)]
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

		// Token: 0x060005B6 RID: 1462 RVA: 0x000210DB File Offset: 0x0001F2DB
		[NullableContext(1)]
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

		// Token: 0x060005B7 RID: 1463 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[NullableContext(1)]
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

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00021140 File Offset: 0x0001F340
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0002117A File Offset: 0x0001F37A
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00021188 File Offset: 0x0001F388
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x000211B2 File Offset: 0x0001F3B2
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000211C0 File Offset: 0x0001F3C0
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00021221 File Offset: 0x0001F421
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00021236 File Offset: 0x0001F436
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00021261 File Offset: 0x0001F461
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00021270 File Offset: 0x0001F470
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000212D1 File Offset: 0x0001F4D1
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

		// Token: 0x0400078F RID: 1935
		protected new GuideLineCreatorComponent FbInstance;

		// Token: 0x04000790 RID: 1936
		protected new GuideLineCreatorComponent_SetValue PocoInterface;

		// Token: 0x04000791 RID: 1937
		[Nullable(1)]
		private IColorChangeStrategyOfRGB _ColorChangeOptionCache;

		// Token: 0x04000792 RID: 1938
		private bool _ColorChangeOptionInited;

		// Token: 0x04000793 RID: 1939
		[Nullable(1)]
		private IGuideLineCreatorScanOption _ScanOptionCache;

		// Token: 0x04000794 RID: 1940
		private bool _ScanOptionInited;
	}
}
