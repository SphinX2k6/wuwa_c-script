using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C97 RID: 3223
	public class INpcPerformOnMonsterCloseby
	{
		// Token: 0x060049BB RID: 18875 RVA: 0x000B9CB6 File Offset: 0x000B7EB6
		public static INpcPerformOnMonsterCloseby Create(INpcPerformOnMonsterCloseby? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcPerformOnMonsterCloseby
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060049BC RID: 18876 RVA: 0x000B9CD5 File Offset: 0x000B7ED5
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x000B9CE2 File Offset: 0x000B7EE2
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				this._MontageCache = IMontageId.Create(this.Instance.Montage);
				return this._MontageCache;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x000B9D16 File Offset: 0x000B7F16
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

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x000B9D4A File Offset: 0x000B7F4A
		public virtual int BubbleRate
		{
			get
			{
				return this.Instance.BubbleRate;
			}
		}

		// Token: 0x040029BC RID: 10684
		private INpcPerformOnMonsterCloseby Instance;

		// Token: 0x040029BD RID: 10685
		[Nullable(2)]
		private IMontageId _MontageCache;

		// Token: 0x040029BE RID: 10686
		private bool _MontageInited;

		// Token: 0x040029BF RID: 10687
		[Nullable(2)]
		private IBubbleIndex _BubbleCache;

		// Token: 0x040029C0 RID: 10688
		private bool _BubbleInited;
	}
}
