using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248F RID: 9359
	public class StopUiScreenEffect : ActionParams
	{
		// Token: 0x0600CB98 RID: 52120 RVA: 0x001D0630 File Offset: 0x001CE830
		private StopUiScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("StopUiScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			StopUiScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new StopUiScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x001D0668 File Offset: 0x001CE868
		public static StopUiScreenEffect Create([Nullable(2)] StopUiScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new StopUiScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x001D067B File Offset: 0x001CE87B
		public static StopUiScreenEffect CreateFromSetValue([Nullable(2)] StopUiScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new StopUiScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x001D068E File Offset: 0x001CE88E
		public StopUiScreenEffect_SetValue ToSetValue()
		{
			return new StopUiScreenEffect_SetValue
			{
				EffectDaPath = this.EffectDaPath
			};
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600CB9C RID: 52124 RVA: 0x001D06A1 File Offset: 0x001CE8A1
		// (set) Token: 0x0600CB9D RID: 52125 RVA: 0x001D06CC File Offset: 0x001CE8CC
		public virtual string EffectDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectDaPath;
			}
			set
			{
				this.GetOrCreatePoco().EffectDaPath = value;
			}
		}

		// Token: 0x040078B0 RID: 30896
		[Nullable(2)]
		protected new StopUiScreenEffect FbInstance;

		// Token: 0x040078B1 RID: 30897
		[Nullable(2)]
		protected StopUiScreenEffect_SetValue PocoInterface;
	}
}
