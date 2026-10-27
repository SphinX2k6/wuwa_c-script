using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000694 RID: 1684
	[NullableContext(2)]
	[Nullable(0)]
	public class IScaleUpSpiritPerformConfig
	{
		// Token: 0x06002412 RID: 9234 RVA: 0x00061FB8 File Offset: 0x000601B8
		[NullableContext(1)]
		private IScaleUpSpiritPerformConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IScaleUpSpiritPerformConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IScaleUpSpiritPerformConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IScaleUpSpiritPerformConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00061FF0 File Offset: 0x000601F0
		[NullableContext(1)]
		public static IScaleUpSpiritPerformConfig Create([Nullable(2)] IScaleUpSpiritPerformConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScaleUpSpiritPerformConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00062003 File Offset: 0x00060203
		[NullableContext(1)]
		public static IScaleUpSpiritPerformConfig CreateFromSetValue([Nullable(2)] IScaleUpSpiritPerformConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IScaleUpSpiritPerformConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00062016 File Offset: 0x00060216
		[NullableContext(1)]
		public IScaleUpSpiritPerformConfig_SetValue ToSetValue()
		{
			return new IScaleUpSpiritPerformConfig_SetValue
			{
				IsInitHide = this.IsInitHide,
				AppearEffectDa = this.AppearEffectDa,
				ScaleUpEffectDa = this.ScaleUpEffectDa,
				ScaleUpPerformTag = this.ScaleUpPerformTag
			};
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x00062050 File Offset: 0x00060250
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x0006208A File Offset: 0x0006028A
		public virtual bool? IsInitHide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsInitHide;
				}
				IScaleUpSpiritPerformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsInitHide;
			}
			set
			{
				this.GetOrCreatePoco().IsInitHide = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x00062098 File Offset: 0x00060298
		// (set) Token: 0x06002419 RID: 9241 RVA: 0x000620BF File Offset: 0x000602BF
		public virtual string AppearEffectDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppearEffectDa;
				}
				IScaleUpSpiritPerformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppearEffectDa;
			}
			set
			{
				this.GetOrCreatePoco().AppearEffectDa = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x000620CD File Offset: 0x000602CD
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x000620F4 File Offset: 0x000602F4
		public virtual string ScaleUpEffectDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScaleUpEffectDa;
				}
				IScaleUpSpiritPerformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScaleUpEffectDa;
			}
			set
			{
				this.GetOrCreatePoco().ScaleUpEffectDa = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x00062104 File Offset: 0x00060304
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x0006213E File Offset: 0x0006033E
		public virtual int? ScaleUpPerformTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScaleUpPerformTag;
				}
				IScaleUpSpiritPerformConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScaleUpPerformTag;
			}
			set
			{
				this.GetOrCreatePoco().ScaleUpPerformTag = value;
			}
		}

		// Token: 0x040018CE RID: 6350
		protected IScaleUpSpiritPerformConfig FbInstance;

		// Token: 0x040018CF RID: 6351
		protected IScaleUpSpiritPerformConfig_SetValue PocoInterface;
	}
}
