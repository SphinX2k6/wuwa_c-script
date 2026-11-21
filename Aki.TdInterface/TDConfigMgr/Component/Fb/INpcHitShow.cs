using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7A RID: 3194
	public class INpcHitShow
	{
		// Token: 0x060048E7 RID: 18663 RVA: 0x000B824D File Offset: 0x000B644D
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

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x000B826C File Offset: 0x000B646C
		public virtual string HitMontage
		{
			get
			{
				return this.Instance.HitMontage;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x000B8279 File Offset: 0x000B6479
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

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x000B82AD File Offset: 0x000B64AD
		public virtual int BubbleRate
		{
			get
			{
				return this.Instance.BubbleRate;
			}
		}

		// Token: 0x04002905 RID: 10501
		private INpcHitShow Instance;

		// Token: 0x04002906 RID: 10502
		[Nullable(2)]
		private IBubbleIndex _HitBubbleCache;

		// Token: 0x04002907 RID: 10503
		private bool _HitBubbleInited;
	}
}
