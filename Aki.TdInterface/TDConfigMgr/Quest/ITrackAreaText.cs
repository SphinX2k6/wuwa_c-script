using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011AC RID: 4524
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackAreaText
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x000F61E0 File Offset: 0x000F43E0
		private ITrackAreaText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackAreaText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackAreaText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackAreaText_SetValue());
			}
			return result;
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x000F6218 File Offset: 0x000F4418
		public static ITrackAreaText Create([Nullable(2)] ITrackAreaText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackAreaText
			{
				FbInstance = instance
			};
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x000F622B File Offset: 0x000F442B
		public static ITrackAreaText CreateFromSetValue([Nullable(2)] ITrackAreaText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackAreaText
			{
				PocoInterface = value
			};
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x000F623E File Offset: 0x000F443E
		public ITrackAreaText_SetValue ToSetValue()
		{
			return new ITrackAreaText_SetValue
			{
				Show = this.Show,
				Tid = this.Tid,
				EdTid = this.EdTid
			};
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x000F6269 File Offset: 0x000F4469
		// (set) Token: 0x060066C1 RID: 26305 RVA: 0x000F6294 File Offset: 0x000F4494
		public virtual bool Show
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Show;
				}
				return this.PocoInterface != null && this.PocoInterface.Show;
			}
			set
			{
				this.GetOrCreatePoco().Show = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x000F62A2 File Offset: 0x000F44A2
		// (set) Token: 0x060066C3 RID: 26307 RVA: 0x000F62CD File Offset: 0x000F44CD
		public virtual string Tid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Tid;
			}
			set
			{
				this.GetOrCreatePoco().Tid = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x000F62DB File Offset: 0x000F44DB
		// (set) Token: 0x060066C5 RID: 26309 RVA: 0x000F62F2 File Offset: 0x000F44F2
		public virtual string EdTid
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTid;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTid = value;
			}
		}

		// Token: 0x04003DA6 RID: 15782
		[Nullable(2)]
		protected ITrackAreaText FbInstance;

		// Token: 0x04003DA7 RID: 15783
		[Nullable(2)]
		protected ITrackAreaText_SetValue PocoInterface;
	}
}
