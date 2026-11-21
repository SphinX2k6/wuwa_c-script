using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C8 RID: 456
	public class IAiAlertSystemConfig
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x0002443C File Offset: 0x0002263C
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

		// Token: 0x060006C9 RID: 1737 RVA: 0x00024474 File Offset: 0x00022674
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

		// Token: 0x060006CA RID: 1738 RVA: 0x00024487 File Offset: 0x00022687
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

		// Token: 0x060006CB RID: 1739 RVA: 0x0002449A File Offset: 0x0002269A
		public IAiAlertSystemConfig_SetValue ToSetValue()
		{
			return new IAiAlertSystemConfig_SetValue
			{
				AreaId = this.AreaId,
				PlayerHatredDeltaValue = this.PlayerHatredDeltaValue
			};
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000244B9 File Offset: 0x000226B9
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000244E4 File Offset: 0x000226E4
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

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000244F4 File Offset: 0x000226F4
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0002452E File Offset: 0x0002272E
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

		// Token: 0x04000898 RID: 2200
		[Nullable(2)]
		protected IAiAlertSystemConfig FbInstance;

		// Token: 0x04000899 RID: 2201
		[Nullable(2)]
		protected IAiAlertSystemConfig_SetValue PocoInterface;
	}
}
