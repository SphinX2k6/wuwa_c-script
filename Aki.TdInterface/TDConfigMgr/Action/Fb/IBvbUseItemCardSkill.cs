using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A28 RID: 10792
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbUseItemCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x0600EDD4 RID: 60884 RVA: 0x0022A855 File Offset: 0x00228A55
		[NullableContext(1)]
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

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x0600EDD5 RID: 60885 RVA: 0x0022A874 File Offset: 0x00228A74
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x0600EDD6 RID: 60886 RVA: 0x0022A884 File Offset: 0x00228A84
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

		// Token: 0x040082E6 RID: 33510
		private IBvbUseItemCardSkill Instance;

		// Token: 0x040082E7 RID: 33511
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040082E8 RID: 33512
		private bool _BoardPosIndexListInited;
	}
}
