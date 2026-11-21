using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E0B RID: 7691
	public class IMotorParamsChangeConfig
	{
		// Token: 0x0600A39B RID: 41883 RVA: 0x001762B0 File Offset: 0x001744B0
		private IMotorParamsChangeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorParamsChangeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorParamsChangeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorParamsChangeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x001762E8 File Offset: 0x001744E8
		public static IMotorParamsChangeConfig Create([Nullable(2)] IMotorParamsChangeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorParamsChangeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x001762FB File Offset: 0x001744FB
		public static IMotorParamsChangeConfig CreateFromSetValue([Nullable(2)] IMotorParamsChangeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorParamsChangeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x0017630E File Offset: 0x0017450E
		public IMotorParamsChangeConfig_SetValue ToSetValue()
		{
			return new IMotorParamsChangeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A39F RID: 41887 RVA: 0x00176321 File Offset: 0x00174521
		// (set) Token: 0x0600A3A0 RID: 41888 RVA: 0x0017634C File Offset: 0x0017454C
		public virtual EMotorParamsChangeType Type
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

		// Token: 0x04006316 RID: 25366
		[Nullable(2)]
		protected IMotorParamsChangeConfig FbInstance;

		// Token: 0x04006317 RID: 25367
		[Nullable(2)]
		protected IMotorParamsChangeConfig_SetValue PocoInterface;
	}
}
