using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200048F RID: 1167
	public class IHookFetchMoveModeBase
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x00047B2C File Offset: 0x00045D2C
		private IHookFetchMoveModeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookFetchMoveModeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookFetchMoveModeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookFetchMoveModeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00047B64 File Offset: 0x00045D64
		public static IHookFetchMoveModeBase Create([Nullable(2)] IHookFetchMoveModeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveModeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00047B77 File Offset: 0x00045D77
		public static IHookFetchMoveModeBase CreateFromSetValue([Nullable(2)] IHookFetchMoveModeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookFetchMoveModeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00047B8A File Offset: 0x00045D8A
		public IHookFetchMoveModeBase_SetValue ToSetValue()
		{
			return new IHookFetchMoveModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00047B9D File Offset: 0x00045D9D
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00047BC8 File Offset: 0x00045DC8
		public virtual EHookFetchMoveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookFetchMoveMode.Uniform;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011E4 RID: 4580
		[Nullable(2)]
		protected IHookFetchMoveModeBase FbInstance;

		// Token: 0x040011E5 RID: 4581
		[Nullable(2)]
		protected IHookFetchMoveModeBase_SetValue PocoInterface;
	}
}
