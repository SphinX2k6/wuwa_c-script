using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAC RID: 2988
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcHitShow
	{
		// Token: 0x0600448E RID: 17550 RVA: 0x000AE189 File Offset: 0x000AC389
		public static INpcHitShow Create(INpcHitShow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcHitShow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x000AE1A8 File Offset: 0x000AC3A8
		public virtual string HitMontage
		{
			get
			{
				return this.Instance.HitMontage;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x000AE1B5 File Offset: 0x000AC3B5
		public virtual IBubbleIndex HitBubble
		{
			get
			{
				if (this._HitBubbleInited)
				{
					return this._HitBubbleCache;
				}
				this._HitBubbleInited = true;
				this._HitBubbleCache = IBubbleIndex.Create(this.Instance.HitBubble);
				return this._HitBubbleCache;
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x000AE1E9 File Offset: 0x000AC3E9
		public virtual int BubbleRate
		{
			get
			{
				return this.Instance.BubbleRate;
			}
		}

		// Token: 0x040026BD RID: 9917
		private INpcHitShow Instance;

		// Token: 0x040026BE RID: 9918
		[Nullable(2)]
		private IBubbleIndex _HitBubbleCache;

		// Token: 0x040026BF RID: 9919
		private bool _HitBubbleInited;
	}
}
