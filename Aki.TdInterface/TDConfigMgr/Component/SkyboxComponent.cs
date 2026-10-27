using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000899 RID: 2201
	[NullableContext(2)]
	[Nullable(0)]
	public class SkyboxComponent : IComponentBase
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x0007E3F8 File Offset: 0x0007C5F8
		[NullableContext(1)]
		private SkyboxComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SkyboxComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SkyboxComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SkyboxComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0007E430 File Offset: 0x0007C630
		[NullableContext(1)]
		public static SkyboxComponent Create([Nullable(2)] SkyboxComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SkyboxComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0007E443 File Offset: 0x0007C643
		[NullableContext(1)]
		public static SkyboxComponent CreateFromSetValue([Nullable(2)] SkyboxComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SkyboxComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x0007E458 File Offset: 0x0007C658
		[NullableContext(1)]
		public new SkyboxComponent_SetValue ToSetValue()
		{
			return new SkyboxComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WeatherDataAsset = this.WeatherDataAsset,
				PPTODDataAsset = this.PPTODDataAsset,
				SkyboxSetting = this.SkyboxSetting,
				FadeTime = this.FadeTime,
				Priority = this.Priority,
				TriggerMode = this.TriggerMode
			};
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x0007E4CC File Offset: 0x0007C6CC
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x0007E506 File Offset: 0x0007C706
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x0007E514 File Offset: 0x0007C714
		// (set) Token: 0x06003126 RID: 12582 RVA: 0x0007E53E File Offset: 0x0007C73E
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x0007E54C File Offset: 0x0007C74C
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x0007E573 File Offset: 0x0007C773
		public virtual string WeatherDataAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeatherDataAsset;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WeatherDataAsset;
			}
			set
			{
				this.GetOrCreatePoco().WeatherDataAsset = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x0007E581 File Offset: 0x0007C781
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x0007E5A8 File Offset: 0x0007C7A8
		public virtual string PPTODDataAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PPTODDataAsset;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PPTODDataAsset;
			}
			set
			{
				this.GetOrCreatePoco().PPTODDataAsset = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x0007E5B8 File Offset: 0x0007C7B8
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x0007E5F2 File Offset: 0x0007C7F2
		public virtual int? SkyboxSetting
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkyboxSetting;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkyboxSetting;
			}
			set
			{
				this.GetOrCreatePoco().SkyboxSetting = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x0007E600 File Offset: 0x0007C800
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x0007E63A File Offset: 0x0007C83A
		public virtual float? FadeTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeTime;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeTime = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x0007E648 File Offset: 0x0007C848
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x0007E682 File Offset: 0x0007C882
		public virtual float? Priority
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Priority;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Priority;
			}
			set
			{
				this.GetOrCreatePoco().Priority = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x0007E690 File Offset: 0x0007C890
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x0007E6B7 File Offset: 0x0007C8B7
		public virtual ISkyboxTrigger TriggerMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerMode;
				}
				SkyboxComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TriggerMode;
			}
			set
			{
				this.GetOrCreatePoco().TriggerMode = value;
			}
		}

		// Token: 0x0400204B RID: 8267
		protected new SkyboxComponent FbInstance;

		// Token: 0x0400204C RID: 8268
		protected new SkyboxComponent_SetValue PocoInterface;
	}
}
