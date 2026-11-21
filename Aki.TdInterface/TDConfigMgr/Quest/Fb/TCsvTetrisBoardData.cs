using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015D1 RID: 5585
	public class TCsvTetrisBoardData
	{
		// Token: 0x06007E01 RID: 32257 RVA: 0x0012B86D File Offset: 0x00129A6D
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

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0012B88C File Offset: 0x00129A8C
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x0012B899 File Offset: 0x00129A99
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

		// Token: 0x040048EB RID: 18667
		private TCsvTetrisBoardData Instance;

		// Token: 0x040048EC RID: 18668
		[Nullable(2)]
		private ITetrisBoard _DataCache;

		// Token: 0x040048ED RID: 18669
		private bool _DataInited;
	}
}
