using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B35 RID: 6965
	public class IDisableInRangeMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x060093E1 RID: 37857 RVA: 0x001599C4 File Offset: 0x00157BC4
		private IDisableInRangeMotorRadioOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableInRangeMotorRadioOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableInRangeMotorRadioOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableInRangeMotorRadioOperation_SetValue());
			}
			return result;
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x001599FC File Offset: 0x00157BFC
		public static IDisableInRangeMotorRadioOperation Create([Nullable(2)] IDisableInRangeMotorRadioOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableInRangeMotorRadioOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x00159A0F File Offset: 0x00157C0F
		public static IDisableInRangeMotorRadioOperation CreateFromSetValue([Nullable(2)] IDisableInRangeMotorRadioOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableInRangeMotorRadioOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00159A22 File Offset: 0x00157C22
		public new IDisableInRangeMotorRadioOperation_SetValue ToSetValue()
		{
			return new IDisableInRangeMotorRadioOperation_SetValue
			{
				Type = this.Type,
				RangeKey = this.RangeKey,
				DisableRangeType = this.DisableRangeType
			};
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x060093E5 RID: 37861 RVA: 0x00159A4D File Offset: 0x00157C4D
		// (set) Token: 0x060093E6 RID: 37862 RVA: 0x00159A78 File Offset: 0x00157C78
		public override EMotorRadioOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x060093E7 RID: 37863 RVA: 0x00159A86 File Offset: 0x00157C86
		// (set) Token: 0x060093E8 RID: 37864 RVA: 0x00159AB1 File Offset: 0x00157CB1
		public virtual string RangeKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RangeKey;
			}
			set
			{
				this.GetOrCreatePoco().RangeKey = value;
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x060093E9 RID: 37865 RVA: 0x00159ABF File Offset: 0x00157CBF
		// (set) Token: 0x060093EA RID: 37866 RVA: 0x00159AE6 File Offset: 0x00157CE6
		public virtual IMotorRadioDisableRange DisableRangeType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableRangeType;
				}
				IDisableInRangeMotorRadioOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableRangeType;
			}
			set
			{
				this.GetOrCreatePoco().DisableRangeType = value;
			}
		}

		// Token: 0x04005BD6 RID: 23510
		[Nullable(2)]
		protected new IDisableInRangeMotorRadioOperation FbInstance;

		// Token: 0x04005BD7 RID: 23511
		[Nullable(2)]
		protected new IDisableInRangeMotorRadioOperation_SetValue PocoInterface;
	}
}
