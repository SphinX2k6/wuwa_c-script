using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E05 RID: 7685
	public class IMotorConstraintConfig
	{
		// Token: 0x0600A361 RID: 41825 RVA: 0x00175AF8 File Offset: 0x00173CF8
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

		// Token: 0x0600A362 RID: 41826 RVA: 0x00175B30 File Offset: 0x00173D30
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

		// Token: 0x0600A363 RID: 41827 RVA: 0x00175B43 File Offset: 0x00173D43
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

		// Token: 0x0600A364 RID: 41828 RVA: 0x00175B56 File Offset: 0x00173D56
		public IMotorConstraintConfig_SetValue ToSetValue()
		{
			return new IMotorConstraintConfig_SetValue
			{
				DisableInput = this.DisableInput
			};
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x00175B69 File Offset: 0x00173D69
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x00175B90 File Offset: 0x00173D90
		[Nullable(2)]
		public virtual List<EPlayerInputConstraintType> DisableInput
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DisableInput = value;
			}
		}

		// Token: 0x040062FA RID: 25338
		[Nullable(2)]
		protected IMotorConstraintConfig FbInstance;

		// Token: 0x040062FB RID: 25339
		[Nullable(2)]
		protected IMotorConstraintConfig_SetValue PocoInterface;
	}
}
