using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200121D RID: 4637
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvTetrisBoardData
	{
		// Token: 0x06006920 RID: 26912 RVA: 0x000FA974 File Offset: 0x000F8B74
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

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06006921 RID: 26913 RVA: 0x000FA987 File Offset: 0x000F8B87
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x000FA994 File Offset: 0x000F8B94
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

		// Token: 0x04003EDE RID: 16094
		private TCsvTetrisBoardData FbInstance;

		// Token: 0x04003EDF RID: 16095
		private ITetrisBoard _DataCache;

		// Token: 0x04003EE0 RID: 16096
		private bool _DataInited;
	}
}
