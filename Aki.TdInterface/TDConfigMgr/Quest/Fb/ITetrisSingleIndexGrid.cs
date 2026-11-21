using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C7 RID: 5575
	public class ITetrisSingleIndexGrid
	{
		// Token: 0x06007DC8 RID: 32200 RVA: 0x0012B201 File Offset: 0x00129401
		public static ITetrisSingleIndexGrid Create(ITetrisSingleIndexGrid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleIndexGrid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x0012B220 File Offset: 0x00129420
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06007DCA RID: 32202 RVA: 0x0012B22D File Offset: 0x0012942D
		public virtual ITetrisSingleGrid Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				this._ValueCache = ITetrisSingleGrid.Create(this.Instance.Value);
				return this._ValueCache;
			}
		}

		// Token: 0x040048C5 RID: 18629
		private ITetrisSingleIndexGrid Instance;

		// Token: 0x040048C6 RID: 18630
		[Nullable(2)]
		private ITetrisSingleGrid _ValueCache;

		// Token: 0x040048C7 RID: 18631
		private bool _ValueInited;
	}
}
