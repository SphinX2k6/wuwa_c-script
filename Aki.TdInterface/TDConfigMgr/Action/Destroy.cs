using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B7 RID: 5815
	public class Destroy : ActionParams
	{
		// Token: 0x0600825D RID: 33373 RVA: 0x00138998 File Offset: 0x00136B98
		private Destroy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Destroy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Destroy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Destroy_SetValue());
			}
			return result;
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x001389D0 File Offset: 0x00136BD0
		public static Destroy Create([Nullable(2)] Destroy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Destroy
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x001389E3 File Offset: 0x00136BE3
		public static Destroy CreateFromSetValue([Nullable(2)] Destroy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Destroy
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x001389F6 File Offset: 0x00136BF6
		public Destroy_SetValue ToSetValue()
		{
			return new Destroy_SetValue
			{
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x06008261 RID: 33377 RVA: 0x00138A0C File Offset: 0x00136C0C
		// (set) Token: 0x06008262 RID: 33378 RVA: 0x00138A46 File Offset: 0x00136C46
		public virtual bool? DelayDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDestroy;
				}
				Destroy_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDestroy;
			}
			set
			{
				this.GetOrCreatePoco().DelayDestroy = value;
			}
		}

		// Token: 0x04004AC1 RID: 19137
		[Nullable(2)]
		protected new Destroy FbInstance;

		// Token: 0x04004AC2 RID: 19138
		[Nullable(2)]
		protected Destroy_SetValue PocoInterface;
	}
}
