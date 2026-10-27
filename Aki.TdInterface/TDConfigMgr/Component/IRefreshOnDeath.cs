using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066E RID: 1646
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshOnDeath : IRefreshConditionBase
	{
		// Token: 0x06002336 RID: 9014 RVA: 0x000605AC File Offset: 0x0005E7AC
		private IRefreshOnDeath_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshOnDeath 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshOnDeath_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshOnDeath_SetValue());
			}
			return result;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x000605E4 File Offset: 0x0005E7E4
		public static IRefreshOnDeath Create([Nullable(2)] IRefreshOnDeath instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x000605F7 File Offset: 0x0005E7F7
		public static IRefreshOnDeath CreateFromSetValue([Nullable(2)] IRefreshOnDeath_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0006060A File Offset: 0x0005E80A
		public new IRefreshOnDeath_SetValue ToSetValue()
		{
			return new IRefreshOnDeath_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x0006061D File Offset: 0x0005E81D
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00060648 File Offset: 0x0005E848
		public override ERewardDropType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERewardDropType.Death;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400185F RID: 6239
		[Nullable(2)]
		protected new IRefreshOnDeath FbInstance;

		// Token: 0x04001860 RID: 6240
		[Nullable(2)]
		protected new IRefreshOnDeath_SetValue PocoInterface;
	}
}
