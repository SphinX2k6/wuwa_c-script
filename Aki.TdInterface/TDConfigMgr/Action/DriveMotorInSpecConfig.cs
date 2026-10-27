using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001574 RID: 5492
	[NullableContext(1)]
	[Nullable(0)]
	public class DriveMotorInSpecConfig : ActionParams
	{
		// Token: 0x06007BF5 RID: 31733 RVA: 0x0012A4F4 File Offset: 0x001286F4
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

		// Token: 0x06007BF6 RID: 31734 RVA: 0x0012A52C File Offset: 0x0012872C
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

		// Token: 0x06007BF7 RID: 31735 RVA: 0x0012A53F File Offset: 0x0012873F
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

		// Token: 0x06007BF8 RID: 31736 RVA: 0x0012A554 File Offset: 0x00128754
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

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x0012A5AE File Offset: 0x001287AE
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x0012A5D5 File Offset: 0x001287D5
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

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x0012A5E4 File Offset: 0x001287E4
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x0012A61E File Offset: 0x0012881E
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

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x0012A62C File Offset: 0x0012882C
		// (set) Token: 0x06007BFE RID: 31742 RVA: 0x0012A653 File Offset: 0x00128853
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

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x06007BFF RID: 31743 RVA: 0x0012A661 File Offset: 0x00128861
		// (set) Token: 0x06007C00 RID: 31744 RVA: 0x0012A690 File Offset: 0x00128890
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

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x06007C01 RID: 31745 RVA: 0x0012A6A0 File Offset: 0x001288A0
		// (set) Token: 0x06007C02 RID: 31746 RVA: 0x0012A6DA File Offset: 0x001288DA
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

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x0012A6E8 File Offset: 0x001288E8
		// (set) Token: 0x06007C04 RID: 31748 RVA: 0x0012A722 File Offset: 0x00128922
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

		// Token: 0x04004754 RID: 18260
		[Nullable(2)]
		protected new DriveMotorInSpecConfig FbInstance;

		// Token: 0x04004755 RID: 18261
		[Nullable(2)]
		protected DriveMotorInSpecConfig_SetValue PocoInterface;
	}
}
