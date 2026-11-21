using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000735 RID: 1845
	[NullableContext(2)]
	[Nullable(0)]
	public class IScaleUpSpiritPerformConfig
	{
		// Token: 0x0600272E RID: 10030 RVA: 0x00068F80 File Offset: 0x00067180
		[NullableContext(0)]
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

		// Token: 0x0600272F RID: 10031 RVA: 0x00068FB8 File Offset: 0x000671B8
		[NullableContext(0)]
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

		// Token: 0x06002730 RID: 10032 RVA: 0x00068FCB File Offset: 0x000671CB
		[NullableContext(0)]
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

		// Token: 0x06002731 RID: 10033 RVA: 0x00068FDE File Offset: 0x000671DE
		[NullableContext(0)]
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x00069018 File Offset: 0x00067218
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x00069052 File Offset: 0x00067252
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

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x00069060 File Offset: 0x00067260
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00069087 File Offset: 0x00067287
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

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x00069095 File Offset: 0x00067295
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x000690BC File Offset: 0x000672BC
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000690CC File Offset: 0x000672CC
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x00069106 File Offset: 0x00067306
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

		// Token: 0x04001ACB RID: 6859
		protected IScaleUpSpiritPerformConfig FbInstance;

		// Token: 0x04001ACC RID: 6860
		protected IScaleUpSpiritPerformConfig_SetValue PocoInterface;
	}
}
