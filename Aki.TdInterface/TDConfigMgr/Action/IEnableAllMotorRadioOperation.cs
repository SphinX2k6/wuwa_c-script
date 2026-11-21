using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6B RID: 7019
	public class IEnableAllMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x06009517 RID: 38167 RVA: 0x0015BC38 File Offset: 0x00159E38
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

		// Token: 0x06009518 RID: 38168 RVA: 0x0015BC70 File Offset: 0x00159E70
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

		// Token: 0x06009519 RID: 38169 RVA: 0x0015BC83 File Offset: 0x00159E83
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

		// Token: 0x0600951A RID: 38170 RVA: 0x0015BC96 File Offset: 0x00159E96
		public new IEnableAllMotorRadioOperation_SetValue ToSetValue()
		{
			return new IEnableAllMotorRadioOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x0015BCA9 File Offset: 0x00159EA9
		// (set) Token: 0x0600951C RID: 38172 RVA: 0x0015BCD4 File Offset: 0x00159ED4
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

		// Token: 0x04005C60 RID: 23648
		[Nullable(2)]
		protected new IEnableAllMotorRadioOperation FbInstance;

		// Token: 0x04005C61 RID: 23649
		[Nullable(2)]
		protected new IEnableAllMotorRadioOperation_SetValue PocoInterface;
	}
}
