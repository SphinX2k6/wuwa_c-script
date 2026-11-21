using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001617 RID: 5655
	public class CallFunction : ActionParams
	{
		// Token: 0x06007FA9 RID: 32681 RVA: 0x0013057C File Offset: 0x0012E77C
		private CallFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CallFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CallFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CallFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x001305B4 File Offset: 0x0012E7B4
		public static CallFunction Create([Nullable(2)] CallFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x001305C7 File Offset: 0x0012E7C7
		public static CallFunction CreateFromSetValue([Nullable(2)] CallFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CallFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x001305DA File Offset: 0x0012E7DA
		public CallFunction_SetValue ToSetValue()
		{
			return new CallFunction_SetValue
			{
				Name = this.Name
			};
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06007FAD RID: 32685 RVA: 0x001305ED File Offset: 0x0012E7ED
		// (set) Token: 0x06007FAE RID: 32686 RVA: 0x00130618 File Offset: 0x0012E818
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x040049CF RID: 18895
		[Nullable(2)]
		protected new CallFunction FbInstance;

		// Token: 0x040049D0 RID: 18896
		[Nullable(2)]
		protected CallFunction_SetValue PocoInterface;
	}
}
