using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D14 RID: 11540
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbRecycleBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x0600FC67 RID: 64615 RVA: 0x00248126 File Offset: 0x00246326
		[NullableContext(0)]
		public static IBvbRecycleBoardCard Create(IBvbRecycleBoardCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbRecycleBoardCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x0600FC68 RID: 64616 RVA: 0x00248145 File Offset: 0x00246345
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x0600FC69 RID: 64617 RVA: 0x00248154 File Offset: 0x00246354
		public virtual int? BoardPosIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.BoardPosIndex);
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x0600FC6A RID: 64618 RVA: 0x0024818C File Offset: 0x0024638C
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this._BoardPosIndexListInited)
				{
					return this._BoardPosIndexListCache;
				}
				this._BoardPosIndexListInited = true;
				if ((this.Instance.NullMask & 2) == 0)
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

		// Token: 0x040089D6 RID: 35286
		private IBvbRecycleBoardCard Instance;

		// Token: 0x040089D7 RID: 35287
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040089D8 RID: 35288
		private bool _BoardPosIndexListInited;
	}
}
