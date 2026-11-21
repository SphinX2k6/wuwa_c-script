using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B73 RID: 7027
	public class IEnableInRangeMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600953D RID: 38205 RVA: 0x0015C034 File Offset: 0x0015A234
		private IEnableInRangeMotorRadioOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableInRangeMotorRadioOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableInRangeMotorRadioOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableInRangeMotorRadioOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x0015C06C File Offset: 0x0015A26C
		public static IEnableInRangeMotorRadioOperation Create([Nullable(2)] IEnableInRangeMotorRadioOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableInRangeMotorRadioOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x0015C07F File Offset: 0x0015A27F
		public static IEnableInRangeMotorRadioOperation CreateFromSetValue([Nullable(2)] IEnableInRangeMotorRadioOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableInRangeMotorRadioOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x0015C092 File Offset: 0x0015A292
		public new IEnableInRangeMotorRadioOperation_SetValue ToSetValue()
		{
			return new IEnableInRangeMotorRadioOperation_SetValue
			{
				Type = this.Type,
				RangeKey = this.RangeKey
			};
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x0015C0B1 File Offset: 0x0015A2B1
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x0015C0DC File Offset: 0x0015A2DC
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

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x0015C0EA File Offset: 0x0015A2EA
		// (set) Token: 0x06009544 RID: 38212 RVA: 0x0015C115 File Offset: 0x0015A315
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

		// Token: 0x04005C6F RID: 23663
		[Nullable(2)]
		protected new IEnableInRangeMotorRadioOperation FbInstance;

		// Token: 0x04005C70 RID: 23664
		[Nullable(2)]
		protected new IEnableInRangeMotorRadioOperation_SetValue PocoInterface;
	}
}
