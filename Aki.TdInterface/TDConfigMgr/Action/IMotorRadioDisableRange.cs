using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E15 RID: 7701
	public class IMotorRadioDisableRange
	{
		// Token: 0x0600A3CF RID: 41935 RVA: 0x001767E4 File Offset: 0x001749E4
		private IMotorRadioDisableRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioDisableRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioDisableRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioDisableRange_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x0017681C File Offset: 0x00174A1C
		public static IMotorRadioDisableRange Create([Nullable(2)] IMotorRadioDisableRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioDisableRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x0017682F File Offset: 0x00174A2F
		public static IMotorRadioDisableRange CreateFromSetValue([Nullable(2)] IMotorRadioDisableRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioDisableRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x00176842 File Offset: 0x00174A42
		public IMotorRadioDisableRange_SetValue ToSetValue()
		{
			return new IMotorRadioDisableRange_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x00176855 File Offset: 0x00174A55
		// (set) Token: 0x0600A3D4 RID: 41940 RVA: 0x00176880 File Offset: 0x00174A80
		public virtual EMotorRadioDisableRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400632B RID: 25387
		[Nullable(2)]
		protected IMotorRadioDisableRange FbInstance;

		// Token: 0x0400632C RID: 25388
		[Nullable(2)]
		protected IMotorRadioDisableRange_SetValue PocoInterface;
	}
}
