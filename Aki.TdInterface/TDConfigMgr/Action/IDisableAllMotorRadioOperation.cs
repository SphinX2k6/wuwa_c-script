using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A2 RID: 6562
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x06008C6B RID: 35947 RVA: 0x0014975C File Offset: 0x0014795C
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

		// Token: 0x06008C6C RID: 35948 RVA: 0x00149794 File Offset: 0x00147994
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

		// Token: 0x06008C6D RID: 35949 RVA: 0x001497A7 File Offset: 0x001479A7
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

		// Token: 0x06008C6E RID: 35950 RVA: 0x001497BA File Offset: 0x001479BA
		public new IDisableAllMotorRadioOperation_SetValue ToSetValue()
		{
			return new IDisableAllMotorRadioOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x06008C6F RID: 35951 RVA: 0x001497CD File Offset: 0x001479CD
		// (set) Token: 0x06008C70 RID: 35952 RVA: 0x001497F8 File Offset: 0x001479F8
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

		// Token: 0x04005768 RID: 22376
		[Nullable(2)]
		protected new IDisableAllMotorRadioOperation FbInstance;

		// Token: 0x04005769 RID: 22377
		[Nullable(2)]
		protected new IDisableAllMotorRadioOperation_SetValue PocoInterface;
	}
}
