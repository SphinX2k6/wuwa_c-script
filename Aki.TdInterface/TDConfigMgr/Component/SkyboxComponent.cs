using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093C RID: 2364
	[NullableContext(2)]
	[Nullable(0)]
	public class SkyboxComponent : IComponentBase
	{
		// Token: 0x0600345B RID: 13403 RVA: 0x000858E0 File Offset: 0x00083AE0
		[NullableContext(0)]
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

		// Token: 0x0600345C RID: 13404 RVA: 0x00085918 File Offset: 0x00083B18
		[NullableContext(0)]
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

		// Token: 0x0600345D RID: 13405 RVA: 0x0008592B File Offset: 0x00083B2B
		[NullableContext(0)]
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

		// Token: 0x0600345E RID: 13406 RVA: 0x00085940 File Offset: 0x00083B40
		[NullableContext(0)]
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

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x000859B4 File Offset: 0x00083BB4
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x000859EE File Offset: 0x00083BEE
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

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x000859FC File Offset: 0x00083BFC
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x00085A26 File Offset: 0x00083C26
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

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x00085A34 File Offset: 0x00083C34
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x00085A5B File Offset: 0x00083C5B
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

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x00085A69 File Offset: 0x00083C69
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x00085A90 File Offset: 0x00083C90
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

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x00085AA0 File Offset: 0x00083CA0
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x00085ADA File Offset: 0x00083CDA
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

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x00085AE8 File Offset: 0x00083CE8
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x00085B22 File Offset: 0x00083D22
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

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x00085B30 File Offset: 0x00083D30
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x00085B6A File Offset: 0x00083D6A
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

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x00085B78 File Offset: 0x00083D78
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x00085B9F File Offset: 0x00083D9F
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

		// Token: 0x0400225D RID: 8797
		protected new SkyboxComponent FbInstance;

		// Token: 0x0400225E RID: 8798
		protected new SkyboxComponent_SetValue PocoInterface;
	}
}
