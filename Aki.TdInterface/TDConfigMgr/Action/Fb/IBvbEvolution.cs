using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D10 RID: 11536
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbEvolution : IBvbPlayerOperationType
	{
		// Token: 0x0600FC54 RID: 64596 RVA: 0x00247E4D File Offset: 0x0024604D
		[NullableContext(0)]
		public static IBvbEvolution Create(IBvbEvolution? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEvolution
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x0600FC55 RID: 64597 RVA: 0x00247E6C File Offset: 0x0024606C
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x0600FC56 RID: 64598 RVA: 0x00247E7C File Offset: 0x0024607C
		public virtual int? HandCardIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HandCardIndex);
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x0600FC57 RID: 64599 RVA: 0x00247EB4 File Offset: 0x002460B4
		public virtual int? BoardPosIndex
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.BoardPosIndex);
			}
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x0600FC58 RID: 64600 RVA: 0x00247EEC File Offset: 0x002460EC
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this._BoardPosIndexListInited)
				{
					return this._BoardPosIndexListCache;
				}
				this._BoardPosIndexListInited = true;
				if ((this.Instance.NullMask & 4) == 0)
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

		// Token: 0x040089CE RID: 35278
		private IBvbEvolution Instance;

		// Token: 0x040089CF RID: 35279
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040089D0 RID: 35280
		private bool _BoardPosIndexListInited;
	}
}
