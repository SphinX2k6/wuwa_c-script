using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAB RID: 2987
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformBubble
	{
		// Token: 0x0600448A RID: 17546 RVA: 0x000AE121 File Offset: 0x000AC321
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

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x000AE140 File Offset: 0x000AC340
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x000AE174 File Offset: 0x000AC374
		public virtual int Rate
		{
			get
			{
				return this.Instance.Rate;
			}
		}

		// Token: 0x040026BA RID: 9914
		private INpcPerformBubble Instance;

		// Token: 0x040026BB RID: 9915
		[Nullable(2)]
		private IBubbleIndex _BubbleCache;

		// Token: 0x040026BC RID: 9916
		private bool _BubbleInited;
	}
}
