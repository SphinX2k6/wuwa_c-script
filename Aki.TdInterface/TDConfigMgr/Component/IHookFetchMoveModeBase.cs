using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000436 RID: 1078
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookFetchMoveModeBase
	{
		// Token: 0x060015C5 RID: 5573 RVA: 0x00043DE4 File Offset: 0x00041FE4
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

		// Token: 0x060015C6 RID: 5574 RVA: 0x00043E1C File Offset: 0x0004201C
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x00043E2F File Offset: 0x0004202F
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

		// Token: 0x060015C8 RID: 5576 RVA: 0x00043E42 File Offset: 0x00042042
		public IHookFetchMoveModeBase_SetValue ToSetValue()
		{
			return new IHookFetchMoveModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00043E55 File Offset: 0x00042055
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x00043E80 File Offset: 0x00042080
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

		// Token: 0x040010C2 RID: 4290
		[Nullable(2)]
		protected IHookFetchMoveModeBase FbInstance;

		// Token: 0x040010C3 RID: 4291
		[Nullable(2)]
		protected IHookFetchMoveModeBase_SetValue PocoInterface;
	}
}
