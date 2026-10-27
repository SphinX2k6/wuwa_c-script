using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000672 RID: 1650
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshRule
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x00060724 File Offset: 0x0005E924
		private IRefreshRule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRefreshRule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRefreshRule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRefreshRule_SetValue());
			}
			return result;
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0006075C File Offset: 0x0005E95C
		public static IRefreshRule Create([Nullable(2)] IRefreshRule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshRule
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0006076F File Offset: 0x0005E96F
		public static IRefreshRule CreateFromSetValue([Nullable(2)] IRefreshRule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRefreshRule
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00060782 File Offset: 0x0005E982
		public IRefreshRule_SetValue ToSetValue()
		{
			return new IRefreshRule_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00060795 File Offset: 0x0005E995
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x000607C0 File Offset: 0x0005E9C0
		public virtual ERefreshRule Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshRule.CD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001865 RID: 6245
		[Nullable(2)]
		protected IRefreshRule FbInstance;

		// Token: 0x04001866 RID: 6246
		[Nullable(2)]
		protected IRefreshRule_SetValue PocoInterface;
	}
}
