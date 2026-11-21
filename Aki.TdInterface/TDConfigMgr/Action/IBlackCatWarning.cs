using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001995 RID: 6549
	public class IBlackCatWarning : ICommonTipType
	{
		// Token: 0x06008B3F RID: 35647 RVA: 0x0014A6C0 File Offset: 0x001488C0
		private IBlackCatWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBlackCatWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBlackCatWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBlackCatWarning_SetValue());
			}
			return result;
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x0014A6F8 File Offset: 0x001488F8
		public static IBlackCatWarning Create([Nullable(2)] IBlackCatWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlackCatWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x0014A70B File Offset: 0x0014890B
		public static IBlackCatWarning CreateFromSetValue([Nullable(2)] IBlackCatWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBlackCatWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x0014A71E File Offset: 0x0014891E
		public new IBlackCatWarning_SetValue ToSetValue()
		{
			return new IBlackCatWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x06008B43 RID: 35651 RVA: 0x0014A73D File Offset: 0x0014893D
		// (set) Token: 0x06008B44 RID: 35652 RVA: 0x0014A768 File Offset: 0x00148968
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

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x0014A776 File Offset: 0x00148976
		// (set) Token: 0x06008B46 RID: 35654 RVA: 0x0014A7A1 File Offset: 0x001489A1
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

		// Token: 0x040057F7 RID: 22519
		[Nullable(2)]
		protected new IBlackCatWarning FbInstance;

		// Token: 0x040057F8 RID: 22520
		[Nullable(2)]
		protected new IBlackCatWarning_SetValue PocoInterface;
	}
}
