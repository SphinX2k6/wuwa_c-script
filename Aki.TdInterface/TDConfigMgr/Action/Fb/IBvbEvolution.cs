using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A23 RID: 10787
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbEvolution : IBvbPlayerOperationType
	{
		// Token: 0x0600EDBC RID: 60860 RVA: 0x0022A499 File Offset: 0x00228699
		[NullableContext(1)]
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

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x0022A4B8 File Offset: 0x002286B8
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x0600EDBE RID: 60862 RVA: 0x0022A4C8 File Offset: 0x002286C8
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

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x0022A500 File Offset: 0x00228700
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

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x0600EDC0 RID: 60864 RVA: 0x0022A538 File Offset: 0x00228738
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

		// Token: 0x040082DB RID: 33499
		private IBvbEvolution Instance;

		// Token: 0x040082DC RID: 33500
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040082DD RID: 33501
		private bool _BoardPosIndexListInited;
	}
}
