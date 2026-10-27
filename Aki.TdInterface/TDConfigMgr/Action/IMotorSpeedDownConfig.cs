using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2C RID: 7212
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSpeedDownConfig : IMotorParamsChangeConfig
	{
		// Token: 0x06009ABD RID: 39613 RVA: 0x00163C3C File Offset: 0x00161E3C
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

		// Token: 0x06009ABE RID: 39614 RVA: 0x00163C74 File Offset: 0x00161E74
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

		// Token: 0x06009ABF RID: 39615 RVA: 0x00163C87 File Offset: 0x00161E87
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

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00163C9A File Offset: 0x00161E9A
		public new IMotorSpeedDownConfig_SetValue ToSetValue()
		{
			return new IMotorSpeedDownConfig_SetValue
			{
				Type = this.Type,
				SpeedDownTagId = this.SpeedDownTagId
			};
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06009AC1 RID: 39617 RVA: 0x00163CB9 File Offset: 0x00161EB9
		// (set) Token: 0x06009AC2 RID: 39618 RVA: 0x00163CE4 File Offset: 0x00161EE4
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

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009AC3 RID: 39619 RVA: 0x00163CF2 File Offset: 0x00161EF2
		// (set) Token: 0x06009AC4 RID: 39620 RVA: 0x00163D1D File Offset: 0x00161F1D
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

		// Token: 0x04005E14 RID: 24084
		[Nullable(2)]
		protected new IMotorSpeedDownConfig FbInstance;

		// Token: 0x04005E15 RID: 24085
		[Nullable(2)]
		protected new IMotorSpeedDownConfig_SetValue PocoInterface;
	}
}
