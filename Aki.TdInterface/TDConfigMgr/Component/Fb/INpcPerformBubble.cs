using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C79 RID: 3193
	public class INpcPerformBubble
	{
		// Token: 0x060048E3 RID: 18659 RVA: 0x000B81E5 File Offset: 0x000B63E5
		public static INpcPerformBubble Create(INpcPerformBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x000B8204 File Offset: 0x000B6404
		public virtual IBubbleIndex Bubble
		{
			get
			{
				if (this._BubbleInited)
				{
					return this._BubbleCache;
				}
				this._BubbleInited = true;
				this._BubbleCache = IBubbleIndex.Create(this.Instance.Bubble);
				return this._BubbleCache;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x000B8238 File Offset: 0x000B6438
		public virtual int Rate
		{
			get
			{
				return this.Instance.Rate;
			}
		}

		// Token: 0x04002902 RID: 10498
		private INpcPerformBubble Instance;

		// Token: 0x04002903 RID: 10499
		[Nullable(2)]
		private IBubbleIndex _BubbleCache;

		// Token: 0x04002904 RID: 10500
		private bool _BubbleInited;
	}
}
