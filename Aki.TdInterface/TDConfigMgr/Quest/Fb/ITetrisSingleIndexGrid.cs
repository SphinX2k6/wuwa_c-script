using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146E RID: 5230
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisSingleIndexGrid
	{
		// Token: 0x060076FA RID: 30458 RVA: 0x0011C5E9 File Offset: 0x0011A7E9
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

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x0011C608 File Offset: 0x0011A808
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x060076FC RID: 30460 RVA: 0x0011C615 File Offset: 0x0011A815
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

		// Token: 0x0400452A RID: 17706
		private ITetrisSingleIndexGrid Instance;

		// Token: 0x0400452B RID: 17707
		[Nullable(2)]
		private ITetrisSingleGrid _ValueCache;

		// Token: 0x0400452C RID: 17708
		private bool _ValueInited;
	}
}
