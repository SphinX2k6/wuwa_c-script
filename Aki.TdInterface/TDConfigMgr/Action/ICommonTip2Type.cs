using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A97 RID: 6807
	public class ICommonTip2Type
	{
		// Token: 0x060090A3 RID: 37027 RVA: 0x00154154 File Offset: 0x00152354
		private ICommonTip2Type_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTip2Type 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTip2Type_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTip2Type_SetValue());
			}
			return result;
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0015418C File Offset: 0x0015238C
		public static ICommonTip2Type Create([Nullable(2)] ICommonTip2Type instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x0015419F File Offset: 0x0015239F
		public static ICommonTip2Type CreateFromSetValue([Nullable(2)] ICommonTip2Type_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090A6 RID: 37030 RVA: 0x001541B2 File Offset: 0x001523B2
		public ICommonTip2Type_SetValue ToSetValue()
		{
			return new ICommonTip2Type_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x060090A7 RID: 37031 RVA: 0x001541C5 File Offset: 0x001523C5
		// (set) Token: 0x060090A8 RID: 37032 RVA: 0x001541F0 File Offset: 0x001523F0
		public virtual ECommonTip2Type Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A70 RID: 23152
		[Nullable(2)]
		protected ICommonTip2Type FbInstance;

		// Token: 0x04005A71 RID: 23153
		[Nullable(2)]
		protected ICommonTip2Type_SetValue PocoInterface;
	}
}
