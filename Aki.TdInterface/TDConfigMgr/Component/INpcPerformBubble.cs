using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005CB RID: 1483
	public class INpcPerformBubble
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x00055D40 File Offset: 0x00053F40
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

		// Token: 0x06001E41 RID: 7745 RVA: 0x00055D78 File Offset: 0x00053F78
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

		// Token: 0x06001E42 RID: 7746 RVA: 0x00055D8B File Offset: 0x00053F8B
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

		// Token: 0x06001E43 RID: 7747 RVA: 0x00055D9E File Offset: 0x00053F9E
		public INpcPerformBubble_SetValue ToSetValue()
		{
			return new INpcPerformBubble_SetValue
			{
				Bubble = this.Bubble,
				Rate = this.Rate
			};
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00055DC0 File Offset: 0x00053FC0
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00055E21 File Offset: 0x00054021
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00055E36 File Offset: 0x00054036
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00055E61 File Offset: 0x00054061
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

		// Token: 0x0400159B RID: 5531
		[Nullable(2)]
		protected INpcPerformBubble FbInstance;

		// Token: 0x0400159C RID: 5532
		[Nullable(2)]
		protected INpcPerformBubble_SetValue PocoInterface;

		// Token: 0x0400159D RID: 5533
		private IBubbleIndex _BubbleCache;

		// Token: 0x0400159E RID: 5534
		private bool _BubbleInited;
	}
}
