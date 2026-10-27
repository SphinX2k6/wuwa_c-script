using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E71 RID: 7793
	[NullableContext(1)]
	[Nullable(0)]
	public class ISingleAxisSpringArmSoftZoneConfig
	{
		// Token: 0x0600A6CA RID: 42698 RVA: 0x00179558 File Offset: 0x00177758
		private ISingleAxisSpringArmSoftZoneConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISingleAxisSpringArmSoftZoneConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISingleAxisSpringArmSoftZoneConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISingleAxisSpringArmSoftZoneConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x00179590 File Offset: 0x00177790
		public static ISingleAxisSpringArmSoftZoneConfig Create([Nullable(2)] ISingleAxisSpringArmSoftZoneConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISingleAxisSpringArmSoftZoneConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x001795A3 File Offset: 0x001777A3
		public static ISingleAxisSpringArmSoftZoneConfig CreateFromSetValue([Nullable(2)] ISingleAxisSpringArmSoftZoneConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISingleAxisSpringArmSoftZoneConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x001795B6 File Offset: 0x001777B6
		public ISingleAxisSpringArmSoftZoneConfig_SetValue ToSetValue()
		{
			return new ISingleAxisSpringArmSoftZoneConfig_SetValue
			{
				MaxOffsetDistance = this.MaxOffsetDistance,
				MinOffsetDistance = this.MinOffsetDistance,
				MaxInterpolationSpeed = this.MaxInterpolationSpeed,
				MinInterpolationSpeed = this.MinInterpolationSpeed
			};
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x001795F0 File Offset: 0x001777F0
		// (set) Token: 0x0600A6CF RID: 42703 RVA: 0x0017962A File Offset: 0x0017782A
		public virtual float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				ISingleAxisSpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A6D0 RID: 42704 RVA: 0x00179638 File Offset: 0x00177838
		// (set) Token: 0x0600A6D1 RID: 42705 RVA: 0x00179672 File Offset: 0x00177872
		public virtual float? MinOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinOffsetDistance;
				}
				ISingleAxisSpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinOffsetDistance = value;
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x00179680 File Offset: 0x00177880
		// (set) Token: 0x0600A6D3 RID: 42707 RVA: 0x001796BA File Offset: 0x001778BA
		public virtual float? MaxInterpolationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxInterpolationSpeed;
				}
				ISingleAxisSpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxInterpolationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxInterpolationSpeed = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x001796C8 File Offset: 0x001778C8
		// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x00179702 File Offset: 0x00177902
		public virtual float? MinInterpolationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinInterpolationSpeed;
				}
				ISingleAxisSpringArmSoftZoneConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinInterpolationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MinInterpolationSpeed = value;
			}
		}

		// Token: 0x0400639A RID: 25498
		[Nullable(2)]
		protected ISingleAxisSpringArmSoftZoneConfig FbInstance;

		// Token: 0x0400639B RID: 25499
		[Nullable(2)]
		protected ISingleAxisSpringArmSoftZoneConfig_SetValue PocoInterface;
	}
}
