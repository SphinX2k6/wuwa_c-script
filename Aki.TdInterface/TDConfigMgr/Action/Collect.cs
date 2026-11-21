using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200166C RID: 5740
	public class Collect : ActionParams
	{
		// Token: 0x0600815F RID: 33119 RVA: 0x00133594 File Offset: 0x00131794
		private Collect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Collect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Collect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Collect_SetValue());
			}
			return result;
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x001335CC File Offset: 0x001317CC
		public static Collect Create([Nullable(2)] Collect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Collect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x001335DF File Offset: 0x001317DF
		public static Collect CreateFromSetValue([Nullable(2)] Collect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Collect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x001335F2 File Offset: 0x001317F2
		public Collect_SetValue ToSetValue()
		{
			return new Collect_SetValue
			{
				TargetEntity = this.TargetEntity
			};
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x00133608 File Offset: 0x00131808
		// (set) Token: 0x06008164 RID: 33124 RVA: 0x00133642 File Offset: 0x00131842
		public virtual int? TargetEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntity;
				}
				Collect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntity = value;
			}
		}

		// Token: 0x04004A99 RID: 19097
		[Nullable(2)]
		protected new Collect FbInstance;

		// Token: 0x04004A9A RID: 19098
		[Nullable(2)]
		protected Collect_SetValue PocoInterface;
	}
}
