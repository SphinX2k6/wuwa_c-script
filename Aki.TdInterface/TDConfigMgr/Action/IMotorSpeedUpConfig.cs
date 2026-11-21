using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E25 RID: 7717
	public class IMotorSpeedUpConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600A41F RID: 42015 RVA: 0x0017707C File Offset: 0x0017527C
		private IMotorSpeedUpConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSpeedUpConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSpeedUpConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSpeedUpConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x001770B4 File Offset: 0x001752B4
		public static IMotorSpeedUpConfig Create([Nullable(2)] IMotorSpeedUpConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSpeedUpConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x001770C7 File Offset: 0x001752C7
		public static IMotorSpeedUpConfig CreateFromSetValue([Nullable(2)] IMotorSpeedUpConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSpeedUpConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x001770DA File Offset: 0x001752DA
		public new IMotorSpeedUpConfig_SetValue ToSetValue()
		{
			return new IMotorSpeedUpConfig_SetValue
			{
				Type = this.Type,
				SpeedUpTagId = this.SpeedUpTagId
			};
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600A423 RID: 42019 RVA: 0x001770F9 File Offset: 0x001752F9
		// (set) Token: 0x0600A424 RID: 42020 RVA: 0x00177124 File Offset: 0x00175324
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

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600A425 RID: 42021 RVA: 0x00177132 File Offset: 0x00175332
		// (set) Token: 0x0600A426 RID: 42022 RVA: 0x0017715D File Offset: 0x0017535D
		public virtual EMotorSpeedUpConfigTag SpeedUpTagId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedUpTagId;
				}
				if (this.PocoInterface == null)
				{
					return (EMotorSpeedUpConfigTag)0;
				}
				return this.PocoInterface.SpeedUpTagId;
			}
			set
			{
				this.GetOrCreatePoco().SpeedUpTagId = value;
			}
		}

		// Token: 0x0400634F RID: 25423
		[Nullable(2)]
		protected new IMotorSpeedUpConfig FbInstance;

		// Token: 0x04006350 RID: 25424
		[Nullable(2)]
		protected new IMotorSpeedUpConfig_SetValue PocoInterface;
	}
}
