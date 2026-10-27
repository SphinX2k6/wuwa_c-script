using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000668 RID: 1640
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshConditionBase
	{
		// Token: 0x06002314 RID: 8980 RVA: 0x000601C8 File Offset: 0x0005E3C8
		private IRefreshConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00060200 File Offset: 0x0005E400
		public static IRefreshConditionBase Create([Nullable(2)] IRefreshConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00060213 File Offset: 0x0005E413
		public static IRefreshConditionBase CreateFromSetValue([Nullable(2)] IRefreshConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00060226 File Offset: 0x0005E426
		public IRefreshConditionBase_SetValue ToSetValue()
		{
			return new IRefreshConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00060239 File Offset: 0x0005E439
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x00060264 File Offset: 0x0005E464
		public virtual ERewardDropType Type
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

		// Token: 0x0400184F RID: 6223
		[Nullable(2)]
		protected IRefreshConditionBase FbInstance;

		// Token: 0x04001850 RID: 6224
		[Nullable(2)]
		protected IRefreshConditionBase_SetValue PocoInterface;
	}
}
