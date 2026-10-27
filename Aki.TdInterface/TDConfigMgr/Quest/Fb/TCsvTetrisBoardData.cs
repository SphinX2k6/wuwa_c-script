using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001478 RID: 5240
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvTetrisBoardData
	{
		// Token: 0x06007734 RID: 30516 RVA: 0x0011CC62 File Offset: 0x0011AE62
		public static TCsvTetrisBoardData Create(TCsvTetrisBoardData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvTetrisBoardData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x0011CC81 File Offset: 0x0011AE81
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x0011CC8E File Offset: 0x0011AE8E
		public virtual ITetrisBoard Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				this._DataCache = ITetrisBoard.Create(this.Instance.Data);
				return this._DataCache;
			}
		}

		// Token: 0x04004550 RID: 17744
		private TCsvTetrisBoardData Instance;

		// Token: 0x04004551 RID: 17745
		[Nullable(2)]
		private ITetrisBoard _DataCache;

		// Token: 0x04004552 RID: 17746
		private bool _DataInited;
	}
}
