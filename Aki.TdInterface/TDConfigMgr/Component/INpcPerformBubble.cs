using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000564 RID: 1380
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformBubble
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x00050F84 File Offset: 0x0004F184
		private INpcPerformBubble_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcPerformBubble 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcPerformBubble_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcPerformBubble_SetValue());
			}
			return result;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00050FBC File Offset: 0x0004F1BC
		public static INpcPerformBubble Create([Nullable(2)] INpcPerformBubble instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformBubble
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00050FCF File Offset: 0x0004F1CF
		public static INpcPerformBubble CreateFromSetValue([Nullable(2)] INpcPerformBubble_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcPerformBubble
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00050FE2 File Offset: 0x0004F1E2
		public INpcPerformBubble_SetValue ToSetValue()
		{
			return new INpcPerformBubble_SetValue
			{
				Bubble = this.Bubble,
				Rate = this.Rate
			};
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00051004 File Offset: 0x0004F204
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00051065 File Offset: 0x0004F265
		public virtual IBubbleIndex Bubble
		{
			get
			{
				if (this._BubbleInited)
				{
					return this._BubbleCache;
				}
				this._BubbleInited = true;
				if (this.FbInstance != null)
				{
					this._BubbleCache = IBubbleIndex.Create(this.FbInstance.Bubble);
				}
				else
				{
					INpcPerformBubble_SetValue pocoInterface = this.PocoInterface;
					this._BubbleCache = ((pocoInterface != null) ? pocoInterface.Bubble : null);
				}
				return this._BubbleCache;
			}
			set
			{
				this.GetOrCreatePoco().Bubble = value;
				this._BubbleInited = false;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0005107A File Offset: 0x0004F27A
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x000510A5 File Offset: 0x0004F2A5
		public virtual int Rate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Rate;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Rate;
			}
			set
			{
				this.GetOrCreatePoco().Rate = value;
			}
		}

		// Token: 0x04001431 RID: 5169
		[Nullable(2)]
		protected INpcPerformBubble FbInstance;

		// Token: 0x04001432 RID: 5170
		[Nullable(2)]
		protected INpcPerformBubble_SetValue PocoInterface;

		// Token: 0x04001433 RID: 5171
		private IBubbleIndex _BubbleCache;

		// Token: 0x04001434 RID: 5172
		private bool _BubbleInited;
	}
}
