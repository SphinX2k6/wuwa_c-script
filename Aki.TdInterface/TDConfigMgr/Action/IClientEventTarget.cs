using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A3B RID: 6715
	public class IClientEventTarget
	{
		// Token: 0x06008ECF RID: 36559 RVA: 0x00150F48 File Offset: 0x0014F148
		private IClientEventTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00150F80 File Offset: 0x0014F180
		public static IClientEventTarget Create([Nullable(2)] IClientEventTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x00150F93 File Offset: 0x0014F193
		public static IClientEventTarget CreateFromSetValue([Nullable(2)] IClientEventTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x00150FA6 File Offset: 0x0014F1A6
		public IClientEventTarget_SetValue ToSetValue()
		{
			return new IClientEventTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x06008ED3 RID: 36563 RVA: 0x00150FB9 File Offset: 0x0014F1B9
		// (set) Token: 0x06008ED4 RID: 36564 RVA: 0x00150FE4 File Offset: 0x0014F1E4
		public virtual EClientEventTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventTarget.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040059A4 RID: 22948
		[Nullable(2)]
		protected IClientEventTarget FbInstance;

		// Token: 0x040059A5 RID: 22949
		[Nullable(2)]
		protected IClientEventTarget_SetValue PocoInterface;
	}
}
