using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E8 RID: 744
	public class ICycleModeType
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00033594 File Offset: 0x00031794
		private ICycleModeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICycleModeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICycleModeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICycleModeType_SetValue());
			}
			return result;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000335CC File Offset: 0x000317CC
		public static ICycleModeType Create([Nullable(2)] ICycleModeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000335DF File Offset: 0x000317DF
		public static ICycleModeType CreateFromSetValue([Nullable(2)] ICycleModeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000335F2 File Offset: 0x000317F2
		public ICycleModeType_SetValue ToSetValue()
		{
			return new ICycleModeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00033605 File Offset: 0x00031805
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00033630 File Offset: 0x00031830
		public virtual EPatrolCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000CA4 RID: 3236
		[Nullable(2)]
		protected ICycleModeType FbInstance;

		// Token: 0x04000CA5 RID: 3237
		[Nullable(2)]
		protected ICycleModeType_SetValue PocoInterface;
	}
}
