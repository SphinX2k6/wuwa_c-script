using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A6 RID: 8358
	public class ISingleAxisSpringArmSoftZoneConfig
	{
		// Token: 0x0600B182 RID: 45442 RVA: 0x0018F258 File Offset: 0x0018D458
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

		// Token: 0x0600B183 RID: 45443 RVA: 0x0018F290 File Offset: 0x0018D490
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

		// Token: 0x0600B184 RID: 45444 RVA: 0x0018F2A3 File Offset: 0x0018D4A3
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

		// Token: 0x0600B185 RID: 45445 RVA: 0x0018F2B6 File Offset: 0x0018D4B6
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

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600B186 RID: 45446 RVA: 0x0018F2F0 File Offset: 0x0018D4F0
		// (set) Token: 0x0600B187 RID: 45447 RVA: 0x0018F32A File Offset: 0x0018D52A
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

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x0018F338 File Offset: 0x0018D538
		// (set) Token: 0x0600B189 RID: 45449 RVA: 0x0018F372 File Offset: 0x0018D572
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

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x0018F380 File Offset: 0x0018D580
		// (set) Token: 0x0600B18B RID: 45451 RVA: 0x0018F3BA File Offset: 0x0018D5BA
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

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x0018F3C8 File Offset: 0x0018D5C8
		// (set) Token: 0x0600B18D RID: 45453 RVA: 0x0018F402 File Offset: 0x0018D602
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

		// Token: 0x0400697E RID: 27006
		[Nullable(2)]
		protected ISingleAxisSpringArmSoftZoneConfig FbInstance;

		// Token: 0x0400697F RID: 27007
		[Nullable(2)]
		protected ISingleAxisSpringArmSoftZoneConfig_SetValue PocoInterface;
	}
}
