using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A29 RID: 10793
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbSelectCard : IBvbPlayerOperationType
	{
		// Token: 0x0600EDD8 RID: 60888 RVA: 0x0022A901 File Offset: 0x00228B01
		[NullableContext(1)]
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

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x0600EDD9 RID: 60889 RVA: 0x0022A920 File Offset: 0x00228B20
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x0600EDDA RID: 60890 RVA: 0x0022A930 File Offset: 0x00228B30
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

		// Token: 0x040082E9 RID: 33513
		private IBvbSelectCard Instance;

		// Token: 0x040082EA RID: 33514
		private List<int> _CardIdListCache;

		// Token: 0x040082EB RID: 33515
		private bool _CardIdListInited;
	}
}
