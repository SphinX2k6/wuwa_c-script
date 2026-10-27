using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C16 RID: 7190
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorConstraintConfig
	{
		// Token: 0x06009A31 RID: 39473 RVA: 0x00162BAC File Offset: 0x00160DAC
		[NullableContext(1)]
		private IMotorConstraintConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorConstraintConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorConstraintConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorConstraintConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x00162BE4 File Offset: 0x00160DE4
		[NullableContext(1)]
		public static IMotorConstraintConfig Create([Nullable(2)] IMotorConstraintConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorConstraintConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00162BF7 File Offset: 0x00160DF7
		[NullableContext(1)]
		public static IMotorConstraintConfig CreateFromSetValue([Nullable(2)] IMotorConstraintConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorConstraintConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x00162C0A File Offset: 0x00160E0A
		[NullableContext(1)]
		public IMotorConstraintConfig_SetValue ToSetValue()
		{
			return new IMotorConstraintConfig_SetValue
			{
				DisableInput = this.DisableInput
			};
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x00162C1D File Offset: 0x00160E1D
		// (set) Token: 0x06009A36 RID: 39478 RVA: 0x00162C44 File Offset: 0x00160E44
		public virtual List<EPlayerInputConstraintType> DisableInput
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableInput;
				}
				IMotorConstraintConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableInput;
			}
			set
			{
				this.GetOrCreatePoco().DisableInput = value;
			}
		}

		// Token: 0x04005DD3 RID: 24019
		protected IMotorConstraintConfig FbInstance;

		// Token: 0x04005DD4 RID: 24020
		protected IMotorConstraintConfig_SetValue PocoInterface;
	}
}
