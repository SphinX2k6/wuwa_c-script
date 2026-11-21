using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016D2 RID: 5842
	public class DriveMotorInSpecConfig : ActionParams
	{
		// Token: 0x060082D3 RID: 33491 RVA: 0x001395A0 File Offset: 0x001377A0
		private DriveMotorInSpecConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DriveMotorInSpecConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DriveMotorInSpecConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DriveMotorInSpecConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x001395D8 File Offset: 0x001377D8
		public static DriveMotorInSpecConfig Create([Nullable(2)] DriveMotorInSpecConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DriveMotorInSpecConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082D5 RID: 33493 RVA: 0x001395EB File Offset: 0x001377EB
		public static DriveMotorInSpecConfig CreateFromSetValue([Nullable(2)] DriveMotorInSpecConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DriveMotorInSpecConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082D6 RID: 33494 RVA: 0x00139600 File Offset: 0x00137800
		public DriveMotorInSpecConfig_SetValue ToSetValue()
		{
			return new DriveMotorInSpecConfig_SetValue
			{
				MotorParamsChangeConfig = this.MotorParamsChangeConfig,
				IsEnableNitrogen = this.IsEnableNitrogen,
				DisableInput = this.DisableInput,
				Duration = this.Duration,
				IsAffectedByTimeStop = this.IsAffectedByTimeStop,
				CanBeInterrupted = this.CanBeInterrupted
			};
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x0013965A File Offset: 0x0013785A
		// (set) Token: 0x060082D8 RID: 33496 RVA: 0x00139681 File Offset: 0x00137881
		public virtual IMotorParamsChangeConfig MotorParamsChangeConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotorParamsChangeConfig;
				}
				DriveMotorInSpecConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MotorParamsChangeConfig;
			}
			set
			{
				this.GetOrCreatePoco().MotorParamsChangeConfig = value;
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x00139690 File Offset: 0x00137890
		// (set) Token: 0x060082DA RID: 33498 RVA: 0x001396CA File Offset: 0x001378CA
		public virtual bool? IsEnableNitrogen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnableNitrogen;
				}
				DriveMotorInSpecConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsEnableNitrogen;
			}
			set
			{
				this.GetOrCreatePoco().IsEnableNitrogen = value;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x060082DB RID: 33499 RVA: 0x001396D8 File Offset: 0x001378D8
		// (set) Token: 0x060082DC RID: 33500 RVA: 0x001396FF File Offset: 0x001378FF
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
				DriveMotorInSpecConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x060082DD RID: 33501 RVA: 0x0013970D File Offset: 0x0013790D
		// (set) Token: 0x060082DE RID: 33502 RVA: 0x0013973C File Offset: 0x0013793C
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x0013974C File Offset: 0x0013794C
		// (set) Token: 0x060082E0 RID: 33504 RVA: 0x00139786 File Offset: 0x00137986
		public virtual bool? IsAffectedByTimeStop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAffectedByTimeStop;
				}
				DriveMotorInSpecConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAffectedByTimeStop;
			}
			set
			{
				this.GetOrCreatePoco().IsAffectedByTimeStop = value;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x00139794 File Offset: 0x00137994
		// (set) Token: 0x060082E2 RID: 33506 RVA: 0x001397CE File Offset: 0x001379CE
		public virtual bool? CanBeInterrupted
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanBeInterrupted;
				}
				DriveMotorInSpecConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanBeInterrupted;
			}
			set
			{
				this.GetOrCreatePoco().CanBeInterrupted = value;
			}
		}

		// Token: 0x04004AF4 RID: 19188
		[Nullable(2)]
		protected new DriveMotorInSpecConfig FbInstance;

		// Token: 0x04004AF5 RID: 19189
		[Nullable(2)]
		protected DriveMotorInSpecConfig_SetValue PocoInterface;
	}
}
