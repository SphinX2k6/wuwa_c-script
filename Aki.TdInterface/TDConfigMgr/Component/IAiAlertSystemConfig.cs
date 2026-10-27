using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B1 RID: 433
	[NullableContext(1)]
	[Nullable(0)]
	public class IAiAlertSystemConfig
	{
		// Token: 0x060006B2 RID: 1714 RVA: 0x000237DC File Offset: 0x000219DC
		private IAiAlertSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAiAlertSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAiAlertSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAiAlertSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00023814 File Offset: 0x00021A14
		public static IAiAlertSystemConfig Create([Nullable(2)] IAiAlertSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiAlertSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00023827 File Offset: 0x00021A27
		public static IAiAlertSystemConfig CreateFromSetValue([Nullable(2)] IAiAlertSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAiAlertSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002383A File Offset: 0x00021A3A
		public IAiAlertSystemConfig_SetValue ToSetValue()
		{
			return new IAiAlertSystemConfig_SetValue
			{
				AreaId = this.AreaId,
				PlayerHatredDeltaValue = this.PlayerHatredDeltaValue
			};
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00023859 File Offset: 0x00021A59
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00023884 File Offset: 0x00021A84
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

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00023894 File Offset: 0x00021A94
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x000238CE File Offset: 0x00021ACE
		public virtual float? PlayerHatredDeltaValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerHatredDeltaValue;
				}
				IAiAlertSystemConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerHatredDeltaValue;
			}
			set
			{
				this.GetOrCreatePoco().PlayerHatredDeltaValue = value;
			}
		}

		// Token: 0x0400083F RID: 2111
		[Nullable(2)]
		protected IAiAlertSystemConfig FbInstance;

		// Token: 0x04000840 RID: 2112
		[Nullable(2)]
		protected IAiAlertSystemConfig_SetValue PocoInterface;
	}
}
