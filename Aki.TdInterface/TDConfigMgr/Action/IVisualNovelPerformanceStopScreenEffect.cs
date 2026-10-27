using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002095 RID: 8341
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceStopScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B76C RID: 46956 RVA: 0x001A9064 File Offset: 0x001A7264
		private IVisualNovelPerformanceStopScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceStopScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceStopScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceStopScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x001A909C File Offset: 0x001A729C
		public static IVisualNovelPerformanceStopScreenEffect Create([Nullable(2)] IVisualNovelPerformanceStopScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x001A90AF File Offset: 0x001A72AF
		public static IVisualNovelPerformanceStopScreenEffect CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceStopScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x001A90C2 File Offset: 0x001A72C2
		public new IVisualNovelPerformanceStopScreenEffect_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceStopScreenEffect_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				ScreenEffectDa = this.ScreenEffectDa
			};
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600B770 RID: 46960 RVA: 0x001A90ED File Offset: 0x001A72ED
		// (set) Token: 0x0600B771 RID: 46961 RVA: 0x001A9118 File Offset: 0x001A7318
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x001A9128 File Offset: 0x001A7328
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x001A9162 File Offset: 0x001A7362
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceStopScreenEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600B774 RID: 46964 RVA: 0x001A9170 File Offset: 0x001A7370
		// (set) Token: 0x0600B775 RID: 46965 RVA: 0x001A919B File Offset: 0x001A739B
		public virtual string ScreenEffectDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScreenEffectDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ScreenEffectDa;
			}
			set
			{
				this.GetOrCreatePoco().ScreenEffectDa = value;
			}
		}

		// Token: 0x04006E1C RID: 28188
		[Nullable(2)]
		protected new IVisualNovelPerformanceStopScreenEffect FbInstance;

		// Token: 0x04006E1D RID: 28189
		[Nullable(2)]
		protected new IVisualNovelPerformanceStopScreenEffect_SetValue PocoInterface;
	}
}
