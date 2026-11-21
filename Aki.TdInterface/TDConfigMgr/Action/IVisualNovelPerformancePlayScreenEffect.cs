using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D8 RID: 8920
	public class IVisualNovelPerformancePlayScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C262 RID: 49762 RVA: 0x001BF194 File Offset: 0x001BD394
		private IVisualNovelPerformancePlayScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformancePlayScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformancePlayScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformancePlayScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x001BF1CC File Offset: 0x001BD3CC
		public static IVisualNovelPerformancePlayScreenEffect Create([Nullable(2)] IVisualNovelPerformancePlayScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePlayScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C264 RID: 49764 RVA: 0x001BF1DF File Offset: 0x001BD3DF
		public static IVisualNovelPerformancePlayScreenEffect CreateFromSetValue([Nullable(2)] IVisualNovelPerformancePlayScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformancePlayScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C265 RID: 49765 RVA: 0x001BF1F2 File Offset: 0x001BD3F2
		public new IVisualNovelPerformancePlayScreenEffect_SetValue ToSetValue()
		{
			return new IVisualNovelPerformancePlayScreenEffect_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x001BF21D File Offset: 0x001BD41D
		// (set) Token: 0x0600C267 RID: 49767 RVA: 0x001BF248 File Offset: 0x001BD448
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

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600C268 RID: 49768 RVA: 0x001BF258 File Offset: 0x001BD458
		// (set) Token: 0x0600C269 RID: 49769 RVA: 0x001BF292 File Offset: 0x001BD492
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformancePlayScreenEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600C26A RID: 49770 RVA: 0x001BF2A0 File Offset: 0x001BD4A0
		// (set) Token: 0x0600C26B RID: 49771 RVA: 0x001BF2C7 File Offset: 0x001BD4C7
		public virtual IVisualNovelPlayScreenEffectConfigBase EffectConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectConfig;
				}
				IVisualNovelPerformancePlayScreenEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectConfig;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
			}
		}

		// Token: 0x0400740E RID: 29710
		[Nullable(2)]
		protected new IVisualNovelPerformancePlayScreenEffect FbInstance;

		// Token: 0x0400740F RID: 29711
		[Nullable(2)]
		protected new IVisualNovelPerformancePlayScreenEffect_SetValue PocoInterface;
	}
}
