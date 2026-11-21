using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6B RID: 7531
	public class ILiveScOperation
	{
		// Token: 0x06009FEB RID: 40939 RVA: 0x0016F00C File Offset: 0x0016D20C
		private ILiveScOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveScOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveScOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveScOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x0016F044 File Offset: 0x0016D244
		public static ILiveScOperation Create([Nullable(2)] ILiveScOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveScOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x0016F057 File Offset: 0x0016D257
		public static ILiveScOperation CreateFromSetValue([Nullable(2)] ILiveScOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveScOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x0016F06A File Offset: 0x0016D26A
		public ILiveScOperation_SetValue ToSetValue()
		{
			return new ILiveScOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x06009FEF RID: 40943 RVA: 0x0016F07D File Offset: 0x0016D27D
		// (set) Token: 0x06009FF0 RID: 40944 RVA: 0x0016F0A8 File Offset: 0x0016D2A8
		public virtual ELiveScOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveScOperationType.Send;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006144 RID: 24900
		[Nullable(2)]
		protected ILiveScOperation FbInstance;

		// Token: 0x04006145 RID: 24901
		[Nullable(2)]
		protected ILiveScOperation_SetValue PocoInterface;
	}
}
