using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001359 RID: 4953
	public class TCsvTetrisBoardData
	{
		// Token: 0x06006F61 RID: 28513 RVA: 0x00108280 File Offset: 0x00106480
		public static TCsvTetrisBoardData Create([Nullable(2)] TCsvTetrisBoardData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvTetrisBoardData
			{
				FbInstance = instance
			};
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x00108293 File Offset: 0x00106493
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x001082A0 File Offset: 0x001064A0
		public virtual ITetrisBoard Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				if (this.FbInstance != null)
				{
					this._DataCache = ITetrisBoard.Create(this.FbInstance.Data);
				}
				return this._DataCache;
			}
		}

		// Token: 0x0400424C RID: 16972
		private TCsvTetrisBoardData FbInstance;

		// Token: 0x0400424D RID: 16973
		private ITetrisBoard _DataCache;

		// Token: 0x0400424E RID: 16974
		private bool _DataInited;
	}
}
