using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2E RID: 7214
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSpeedUpConfig : IMotorParamsChangeConfig
	{
		// Token: 0x06009AC7 RID: 39623 RVA: 0x00163D3C File Offset: 0x00161F3C
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

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00163D74 File Offset: 0x00161F74
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

		// Token: 0x06009AC9 RID: 39625 RVA: 0x00163D87 File Offset: 0x00161F87
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

		// Token: 0x06009ACA RID: 39626 RVA: 0x00163D9A File Offset: 0x00161F9A
		public new IMotorSpeedUpConfig_SetValue ToSetValue()
		{
			return new IMotorSpeedUpConfig_SetValue
			{
				Type = this.Type,
				SpeedUpTagId = this.SpeedUpTagId
			};
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06009ACB RID: 39627 RVA: 0x00163DB9 File Offset: 0x00161FB9
		// (set) Token: 0x06009ACC RID: 39628 RVA: 0x00163DE4 File Offset: 0x00161FE4
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

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06009ACD RID: 39629 RVA: 0x00163DF2 File Offset: 0x00161FF2
		// (set) Token: 0x06009ACE RID: 39630 RVA: 0x00163E1D File Offset: 0x0016201D
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

		// Token: 0x04005E18 RID: 24088
		[Nullable(2)]
		protected new IMotorSpeedUpConfig FbInstance;

		// Token: 0x04005E19 RID: 24089
		[Nullable(2)]
		protected new IMotorSpeedUpConfig_SetValue PocoInterface;
	}
}
