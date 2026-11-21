using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D0F RID: 11535
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbDeploy : IBvbPlayerOperationType
	{
		// Token: 0x0600FC4E RID: 64590 RVA: 0x00247D31 File Offset: 0x00245F31
		[NullableContext(0)]
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

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x0600FC4F RID: 64591 RVA: 0x00247D50 File Offset: 0x00245F50
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x0600FC50 RID: 64592 RVA: 0x00247D60 File Offset: 0x00245F60
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

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x0600FC51 RID: 64593 RVA: 0x00247D98 File Offset: 0x00245F98
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

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x0600FC52 RID: 64594 RVA: 0x00247DD0 File Offset: 0x00245FD0
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

		// Token: 0x040089CB RID: 35275
		private IBvbDeploy Instance;

		// Token: 0x040089CC RID: 35276
		private List<int> _BoardPosIndexListCache;

		// Token: 0x040089CD RID: 35277
		private bool _BoardPosIndexListInited;
	}
}
