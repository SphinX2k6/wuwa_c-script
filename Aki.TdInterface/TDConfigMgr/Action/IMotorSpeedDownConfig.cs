using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E23 RID: 7715
	public class IMotorSpeedDownConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600A415 RID: 42005 RVA: 0x00176F7C File Offset: 0x0017517C
		private IMotorSpeedDownConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSpeedDownConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSpeedDownConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSpeedDownConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x00176FB4 File Offset: 0x001751B4
		public static IMotorSpeedDownConfig Create([Nullable(2)] IMotorSpeedDownConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSpeedDownConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x00176FC7 File Offset: 0x001751C7
		public static IMotorSpeedDownConfig CreateFromSetValue([Nullable(2)] IMotorSpeedDownConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSpeedDownConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00176FDA File Offset: 0x001751DA
		public new IMotorSpeedDownConfig_SetValue ToSetValue()
		{
			return new IMotorSpeedDownConfig_SetValue
			{
				Type = this.Type,
				SpeedDownTagId = this.SpeedDownTagId
			};
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x00176FF9 File Offset: 0x001751F9
		// (set) Token: 0x0600A41A RID: 42010 RVA: 0x00177024 File Offset: 0x00175224
		public override EMotorParamsChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorParamsChangeType.SpeedUp;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600A41B RID: 42011 RVA: 0x00177032 File Offset: 0x00175232
		// (set) Token: 0x0600A41C RID: 42012 RVA: 0x0017705D File Offset: 0x0017525D
		public virtual EMotorSpeedDownConfig SpeedDownTagId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedDownTagId;
				}
				if (this.PocoInterface == null)
				{
					return (EMotorSpeedDownConfig)0;
				}
				return this.PocoInterface.SpeedDownTagId;
			}
			set
			{
				this.GetOrCreatePoco().SpeedDownTagId = value;
			}
		}

		// Token: 0x0400634B RID: 25419
		[Nullable(2)]
		protected new IMotorSpeedDownConfig FbInstance;

		// Token: 0x0400634C RID: 25420
		[Nullable(2)]
		protected new IMotorSpeedDownConfig_SetValue PocoInterface;
	}
}
