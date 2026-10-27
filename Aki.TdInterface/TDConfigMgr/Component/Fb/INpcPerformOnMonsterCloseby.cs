using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC9 RID: 3017
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformOnMonsterCloseby
	{
		// Token: 0x06004562 RID: 17762 RVA: 0x000AFBF2 File Offset: 0x000ADDF2
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

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x000AFC11 File Offset: 0x000ADE11
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x000AFC1E File Offset: 0x000ADE1E
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

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x000AFC52 File Offset: 0x000ADE52
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

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x000AFC86 File Offset: 0x000ADE86
		public virtual int BubbleRate
		{
			get
			{
				return this.Instance.BubbleRate;
			}
		}

		// Token: 0x04002774 RID: 10100
		private INpcPerformOnMonsterCloseby Instance;

		// Token: 0x04002775 RID: 10101
		[Nullable(2)]
		private IMontageId _MontageCache;

		// Token: 0x04002776 RID: 10102
		private bool _MontageInited;

		// Token: 0x04002777 RID: 10103
		[Nullable(2)]
		private IBubbleIndex _BubbleCache;

		// Token: 0x04002778 RID: 10104
		private bool _BubbleInited;
	}
}
