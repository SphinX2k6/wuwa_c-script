using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230A RID: 8970
	public class IWhiteCatWarning : ICommonTipType
	{
		// Token: 0x0600C37A RID: 50042 RVA: 0x001C115C File Offset: 0x001BF35C
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

		// Token: 0x0600C37B RID: 50043 RVA: 0x001C1194 File Offset: 0x001BF394
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

		// Token: 0x0600C37C RID: 50044 RVA: 0x001C11A7 File Offset: 0x001BF3A7
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

		// Token: 0x0600C37D RID: 50045 RVA: 0x001C11BA File Offset: 0x001BF3BA
		public new IWhiteCatWarning_SetValue ToSetValue()
		{
			return new IWhiteCatWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600C37E RID: 50046 RVA: 0x001C11D9 File Offset: 0x001BF3D9
		// (set) Token: 0x0600C37F RID: 50047 RVA: 0x001C1204 File Offset: 0x001BF404
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

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600C380 RID: 50048 RVA: 0x001C1212 File Offset: 0x001BF412
		// (set) Token: 0x0600C381 RID: 50049 RVA: 0x001C123D File Offset: 0x001BF43D
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

		// Token: 0x0400748B RID: 29835
		[Nullable(2)]
		protected new IWhiteCatWarning FbInstance;

		// Token: 0x0400748C RID: 29836
		[Nullable(2)]
		protected new IWhiteCatWarning_SetValue PocoInterface;
	}
}
