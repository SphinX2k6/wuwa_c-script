using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000737 RID: 1847
	public class IScanTraceEffect
	{
		// Token: 0x0600273C RID: 10044 RVA: 0x00069124 File Offset: 0x00067324
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

		// Token: 0x0600273D RID: 10045 RVA: 0x0006915C File Offset: 0x0006735C
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

		// Token: 0x0600273E RID: 10046 RVA: 0x0006916F File Offset: 0x0006736F
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

		// Token: 0x0600273F RID: 10047 RVA: 0x00069182 File Offset: 0x00067382
		public IScanTraceEffect_SetValue ToSetValue()
		{
			return new IScanTraceEffect_SetValue
			{
				Effect = this.Effect,
				Target = this.Target
			};
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000691A1 File Offset: 0x000673A1
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x000691CC File Offset: 0x000673CC
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000691DA File Offset: 0x000673DA
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x00069205 File Offset: 0x00067405
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

		// Token: 0x04001AD1 RID: 6865
		[Nullable(2)]
		protected IScanTraceEffect FbInstance;

		// Token: 0x04001AD2 RID: 6866
		[Nullable(2)]
		protected IScanTraceEffect_SetValue PocoInterface;
	}
}
