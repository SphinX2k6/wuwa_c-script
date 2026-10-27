using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000696 RID: 1686
	[NullableContext(1)]
	[Nullable(0)]
	public class IScanTraceEffect
	{
		// Token: 0x06002420 RID: 9248 RVA: 0x0006215C File Offset: 0x0006035C
		private IScanTraceEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IScanTraceEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IScanTraceEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IScanTraceEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00062194 File Offset: 0x00060394
		public static IScanTraceEffect Create([Nullable(2)] IScanTraceEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IScanTraceEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x000621A7 File Offset: 0x000603A7
		public static IScanTraceEffect CreateFromSetValue([Nullable(2)] IScanTraceEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IScanTraceEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000621BA File Offset: 0x000603BA
		public IScanTraceEffect_SetValue ToSetValue()
		{
			return new IScanTraceEffect_SetValue
			{
				Effect = this.Effect,
				Target = this.Target
			};
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x000621D9 File Offset: 0x000603D9
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00062204 File Offset: 0x00060404
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x00062212 File Offset: 0x00060412
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x0006223D File Offset: 0x0006043D
		public virtual int Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x040018D4 RID: 6356
		[Nullable(2)]
		protected IScanTraceEffect FbInstance;

		// Token: 0x040018D5 RID: 6357
		[Nullable(2)]
		protected IScanTraceEffect_SetValue PocoInterface;
	}
}
