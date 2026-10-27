using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208D RID: 8333
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformancePlayScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B732 RID: 46898 RVA: 0x001A891C File Offset: 0x001A6B1C
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

		// Token: 0x0600B733 RID: 46899 RVA: 0x001A8954 File Offset: 0x001A6B54
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

		// Token: 0x0600B734 RID: 46900 RVA: 0x001A8967 File Offset: 0x001A6B67
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

		// Token: 0x0600B735 RID: 46901 RVA: 0x001A897A File Offset: 0x001A6B7A
		public new IVisualNovelPerformancePlayScreenEffect_SetValue ToSetValue()
		{
			return new IVisualNovelPerformancePlayScreenEffect_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				ScreenEffectDa = this.ScreenEffectDa,
				DestroyCountdown = this.DestroyCountdown
			};
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600B736 RID: 46902 RVA: 0x001A89B1 File Offset: 0x001A6BB1
		// (set) Token: 0x0600B737 RID: 46903 RVA: 0x001A89DC File Offset: 0x001A6BDC
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

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600B738 RID: 46904 RVA: 0x001A89EC File Offset: 0x001A6BEC
		// (set) Token: 0x0600B739 RID: 46905 RVA: 0x001A8A26 File Offset: 0x001A6C26
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

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600B73A RID: 46906 RVA: 0x001A8A34 File Offset: 0x001A6C34
		// (set) Token: 0x0600B73B RID: 46907 RVA: 0x001A8A5F File Offset: 0x001A6C5F
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

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x001A8A70 File Offset: 0x001A6C70
		// (set) Token: 0x0600B73D RID: 46909 RVA: 0x001A8AAA File Offset: 0x001A6CAA
		public virtual float? DestroyCountdown
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DestroyCountdown;
				}
				IVisualNovelPerformancePlayScreenEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DestroyCountdown;
			}
			set
			{
				this.GetOrCreatePoco().DestroyCountdown = value;
			}
		}

		// Token: 0x04006E01 RID: 28161
		[Nullable(2)]
		protected new IVisualNovelPerformancePlayScreenEffect FbInstance;

		// Token: 0x04006E02 RID: 28162
		[Nullable(2)]
		protected new IVisualNovelPerformancePlayScreenEffect_SetValue PocoInterface;
	}
}
