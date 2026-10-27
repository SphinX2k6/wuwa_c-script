using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A27 RID: 10791
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbRecycleBoardCard : IBvbPlayerOperationType
	{
		// Token: 0x0600EDCF RID: 60879 RVA: 0x0022A772 File Offset: 0x00228972
		[NullableContext(1)]
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

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x0022A791 File Offset: 0x00228991
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x0022A7A0 File Offset: 0x002289A0
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

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x0600EDD2 RID: 60882 RVA: 0x0022A7D8 File Offset: 0x002289D8
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

		// Token: 0x040082E3 RID: 33507
		private IBvbRecycleBoardCard Instance;

		// Token: 0x040082E4 RID: 33508
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040082E5 RID: 33509
		private bool _BoardPosIndexListInited;
	}
}
