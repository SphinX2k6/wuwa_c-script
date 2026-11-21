using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D15 RID: 11541
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbUseItemCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x0600FC6C RID: 64620 RVA: 0x00248209 File Offset: 0x00246409
		[NullableContext(0)]
		public static IBvbUseItemCardSkill Create(IBvbUseItemCardSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbUseItemCardSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x0600FC6D RID: 64621 RVA: 0x00248228 File Offset: 0x00246428
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x0600FC6E RID: 64622 RVA: 0x00248238 File Offset: 0x00246438
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this._BoardPosIndexListInited)
				{
					return this._BoardPosIndexListCache;
				}
				this._BoardPosIndexListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int boardPosIndexListLength = this.Instance.BoardPosIndexListLength;
				this._BoardPosIndexListCache = new List<int>(boardPosIndexListLength);
				for (int i = 0; i < boardPosIndexListLength; i++)
				{
					this._BoardPosIndexListCache.Add(this.Instance.BoardPosIndexList(i));
				}
				return this._BoardPosIndexListCache;
			}
		}

		// Token: 0x040089D9 RID: 35289
		private IBvbUseItemCardSkill Instance;

		// Token: 0x040089DA RID: 35290
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040089DB RID: 35291
		private bool _BoardPosIndexListInited;
	}
}
