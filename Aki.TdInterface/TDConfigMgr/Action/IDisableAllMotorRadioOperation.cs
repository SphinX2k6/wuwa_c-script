using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B29 RID: 6953
	public class IDisableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600938F RID: 37775 RVA: 0x00158F6C File Offset: 0x0015716C
		private IDisableAllMotorRadioOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAllMotorRadioOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAllMotorRadioOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAllMotorRadioOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00158FA4 File Offset: 0x001571A4
		public static IDisableAllMotorRadioOperation Create([Nullable(2)] IDisableAllMotorRadioOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAllMotorRadioOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00158FB7 File Offset: 0x001571B7
		public static IDisableAllMotorRadioOperation CreateFromSetValue([Nullable(2)] IDisableAllMotorRadioOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAllMotorRadioOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x00158FCA File Offset: 0x001571CA
		public new IDisableAllMotorRadioOperation_SetValue ToSetValue()
		{
			return new IDisableAllMotorRadioOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x06009393 RID: 37779 RVA: 0x00158FDD File Offset: 0x001571DD
		// (set) Token: 0x06009394 RID: 37780 RVA: 0x00159008 File Offset: 0x00157208
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

		// Token: 0x04005BB1 RID: 23473
		[Nullable(2)]
		protected new IDisableAllMotorRadioOperation FbInstance;

		// Token: 0x04005BB2 RID: 23474
		[Nullable(2)]
		protected new IDisableAllMotorRadioOperation_SetValue PocoInterface;
	}
}
