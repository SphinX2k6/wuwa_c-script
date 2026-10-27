using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A22 RID: 10786
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbDeploy : IBvbPlayerOperationType
	{
		// Token: 0x0600EDB6 RID: 60854 RVA: 0x0022A37E File Offset: 0x0022857E
		[NullableContext(1)]
		public static IBvbDeploy Create(IBvbDeploy? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbDeploy
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x0022A39D File Offset: 0x0022859D
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x0600EDB8 RID: 60856 RVA: 0x0022A3AC File Offset: 0x002285AC
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

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x0022A3E4 File Offset: 0x002285E4
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

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x0022A41C File Offset: 0x0022861C
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

		// Token: 0x040082D8 RID: 33496
		private IBvbDeploy Instance;

		// Token: 0x040082D9 RID: 33497
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040082DA RID: 33498
		private bool _BoardPosIndexListInited;
	}
}
