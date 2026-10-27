using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A25 RID: 10789
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbChangeBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x0600EDC6 RID: 60870 RVA: 0x0022A622 File Offset: 0x00228822
		[NullableContext(1)]
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

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x0600EDC7 RID: 60871 RVA: 0x0022A641 File Offset: 0x00228841
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x0600EDC8 RID: 60872 RVA: 0x0022A650 File Offset: 0x00228850
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

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x0600EDC9 RID: 60873 RVA: 0x0022A688 File Offset: 0x00228888
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

		// Token: 0x040082DF RID: 33503
		private IBvbChangeBoardCard Instance;

		// Token: 0x040082E0 RID: 33504
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040082E1 RID: 33505
		private bool _BoardPosIndexListInited;
	}
}
