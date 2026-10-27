using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B5 RID: 8373
	[NullableContext(1)]
	[Nullable(0)]
	public class IWhiteCatWarning : ICommonTipType
	{
		// Token: 0x0600B822 RID: 47138 RVA: 0x001AA514 File Offset: 0x001A8714
		private IWhiteCatWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWhiteCatWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWhiteCatWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWhiteCatWarning_SetValue());
			}
			return result;
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x001AA54C File Offset: 0x001A874C
		public static IWhiteCatWarning Create([Nullable(2)] IWhiteCatWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWhiteCatWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x001AA55F File Offset: 0x001A875F
		public static IWhiteCatWarning CreateFromSetValue([Nullable(2)] IWhiteCatWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWhiteCatWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x001AA572 File Offset: 0x001A8772
		public new IWhiteCatWarning_SetValue ToSetValue()
		{
			return new IWhiteCatWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x001AA591 File Offset: 0x001A8791
		// (set) Token: 0x0600B827 RID: 47143 RVA: 0x001AA5BC File Offset: 0x001A87BC
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

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B828 RID: 47144 RVA: 0x001AA5CA File Offset: 0x001A87CA
		// (set) Token: 0x0600B829 RID: 47145 RVA: 0x001AA5F5 File Offset: 0x001A87F5
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

		// Token: 0x04006E6D RID: 28269
		[Nullable(2)]
		protected new IWhiteCatWarning FbInstance;

		// Token: 0x04006E6E RID: 28270
		[Nullable(2)]
		protected new IWhiteCatWarning_SetValue PocoInterface;
	}
}
