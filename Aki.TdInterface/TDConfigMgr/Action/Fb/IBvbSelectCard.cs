using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D16 RID: 11542
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbSelectCard : IBvbPlayerOperationType
	{
		// Token: 0x0600FC70 RID: 64624 RVA: 0x002482B5 File Offset: 0x002464B5
		[NullableContext(0)]
		public static IBvbSelectCard Create(IBvbSelectCard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbSelectCard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x0600FC71 RID: 64625 RVA: 0x002482D4 File Offset: 0x002464D4
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x0600FC72 RID: 64626 RVA: 0x002482E4 File Offset: 0x002464E4
		public virtual List<int> CardIdList
		{
			get
			{
				if (this._CardIdListInited)
				{
					return this._CardIdListCache;
				}
				this._CardIdListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int cardIdListLength = this.Instance.CardIdListLength;
				this._CardIdListCache = new List<int>(cardIdListLength);
				for (int i = 0; i < cardIdListLength; i++)
				{
					this._CardIdListCache.Add(this.Instance.CardIdList(i));
				}
				return this._CardIdListCache;
			}
		}

		// Token: 0x040089DC RID: 35292
		private IBvbSelectCard Instance;

		// Token: 0x040089DD RID: 35293
		private List<int> _CardIdListCache;

		// Token: 0x040089DE RID: 35294
		private bool _CardIdListInited;
	}
}
