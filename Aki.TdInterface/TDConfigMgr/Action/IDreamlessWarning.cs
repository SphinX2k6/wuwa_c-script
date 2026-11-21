using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B51 RID: 6993
	public class IDreamlessWarning : ICommonTipType
	{
		// Token: 0x06009491 RID: 38033 RVA: 0x0015ADF0 File Offset: 0x00158FF0
		private IDreamlessWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDreamlessWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDreamlessWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDreamlessWarning_SetValue());
			}
			return result;
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0015AE28 File Offset: 0x00159028
		public static IDreamlessWarning Create([Nullable(2)] IDreamlessWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x0015AE3B File Offset: 0x0015903B
		public static IDreamlessWarning CreateFromSetValue([Nullable(2)] IDreamlessWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDreamlessWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x0015AE4E File Offset: 0x0015904E
		public new IDreamlessWarning_SetValue ToSetValue()
		{
			return new IDreamlessWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x06009495 RID: 38037 RVA: 0x0015AE6D File Offset: 0x0015906D
		// (set) Token: 0x06009496 RID: 38038 RVA: 0x0015AE98 File Offset: 0x00159098
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x06009497 RID: 38039 RVA: 0x0015AEA6 File Offset: 0x001590A6
		// (set) Token: 0x06009498 RID: 38040 RVA: 0x0015AED1 File Offset: 0x001590D1
		public virtual string WarningText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningText;
			}
			set
			{
				this.GetOrCreatePoco().WarningText = value;
			}
		}

		// Token: 0x04005C24 RID: 23588
		[Nullable(2)]
		protected new IDreamlessWarning FbInstance;

		// Token: 0x04005C25 RID: 23589
		[Nullable(2)]
		protected new IDreamlessWarning_SetValue PocoInterface;
	}
}
