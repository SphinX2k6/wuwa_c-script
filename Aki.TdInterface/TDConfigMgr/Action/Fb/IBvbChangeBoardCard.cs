using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D12 RID: 11538
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbChangeBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x0600FC5E RID: 64606 RVA: 0x00247FD6 File Offset: 0x002461D6
		[NullableContext(0)]
		public static IBvbChangeBoardCard Create(IBvbChangeBoardCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbChangeBoardCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x0600FC5F RID: 64607 RVA: 0x00247FF5 File Offset: 0x002461F5
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x0600FC60 RID: 64608 RVA: 0x00248004 File Offset: 0x00246204
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

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x0600FC61 RID: 64609 RVA: 0x0024803C File Offset: 0x0024623C
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

		// Token: 0x040089D2 RID: 35282
		private IBvbChangeBoardCard Instance;

		// Token: 0x040089D3 RID: 35283
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040089D4 RID: 35284
		private bool _BoardPosIndexListInited;
	}
}
