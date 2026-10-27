using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DE RID: 6622
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x06008DD5 RID: 36309 RVA: 0x0014C12C File Offset: 0x0014A32C
		private IEnableAllMotorRadioOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableAllMotorRadioOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableAllMotorRadioOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableAllMotorRadioOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x0014C164 File Offset: 0x0014A364
		public static IEnableAllMotorRadioOperation Create([Nullable(2)] IEnableAllMotorRadioOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAllMotorRadioOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x0014C177 File Offset: 0x0014A377
		public static IEnableAllMotorRadioOperation CreateFromSetValue([Nullable(2)] IEnableAllMotorRadioOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableAllMotorRadioOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x0014C18A File Offset: 0x0014A38A
		public new IEnableAllMotorRadioOperation_SetValue ToSetValue()
		{
			return new IEnableAllMotorRadioOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x0014C19D File Offset: 0x0014A39D
		// (set) Token: 0x06008DDA RID: 36314 RVA: 0x0014C1C8 File Offset: 0x0014A3C8
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

		// Token: 0x0400580B RID: 22539
		[Nullable(2)]
		protected new IEnableAllMotorRadioOperation FbInstance;

		// Token: 0x0400580C RID: 22540
		[Nullable(2)]
		protected new IEnableAllMotorRadioOperation_SetValue PocoInterface;
	}
}
