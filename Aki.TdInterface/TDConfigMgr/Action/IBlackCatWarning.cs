using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200180A RID: 6154
	[NullableContext(1)]
	[Nullable(0)]
	public class IBlackCatWarning : ICommonTipType
	{
		// Token: 0x0600841B RID: 33819 RVA: 0x0013AF1C File Offset: 0x0013911C
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

		// Token: 0x0600841C RID: 33820 RVA: 0x0013AF54 File Offset: 0x00139154
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

		// Token: 0x0600841D RID: 33821 RVA: 0x0013AF67 File Offset: 0x00139167
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

		// Token: 0x0600841E RID: 33822 RVA: 0x0013AF7A File Offset: 0x0013917A
		public new IBlackCatWarning_SetValue ToSetValue()
		{
			return new IBlackCatWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600841F RID: 33823 RVA: 0x0013AF99 File Offset: 0x00139199
		// (set) Token: 0x06008420 RID: 33824 RVA: 0x0013AFC4 File Offset: 0x001391C4
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

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x06008421 RID: 33825 RVA: 0x0013AFD2 File Offset: 0x001391D2
		// (set) Token: 0x06008422 RID: 33826 RVA: 0x0013AFFD File Offset: 0x001391FD
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

		// Token: 0x040053AC RID: 21420
		[Nullable(2)]
		protected new IBlackCatWarning FbInstance;

		// Token: 0x040053AD RID: 21421
		[Nullable(2)]
		protected new IBlackCatWarning_SetValue PocoInterface;
	}
}
