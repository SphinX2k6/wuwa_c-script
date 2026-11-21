using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015C5 RID: 5573
	[NullableContext(2)]
	[Nullable(0)]
	public class ITetrisSingleGrid
	{
		// Token: 0x06007DC1 RID: 32193 RVA: 0x0012B0E2 File Offset: 0x001292E2
		[NullableContext(0)]
		public static ITetrisSingleGrid Create(ITetrisSingleGrid? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleGrid
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x0012B101 File Offset: 0x00129301
		public virtual ITetrisSingleBlock Block
		{
			get
			{
				if (this._BlockInited)
				{
					return this._BlockCache;
				}
				this._BlockInited = true;
				this._BlockCache = ITetrisSingleBlock.Create(this.Instance.Block);
				return this._BlockCache;
			}
		}

		// Token: 0x040048BD RID: 18621
		private ITetrisSingleGrid Instance;

		// Token: 0x040048BE RID: 18622
		private ITetrisSingleBlock _BlockCache;

		// Token: 0x040048BF RID: 18623
		private bool _BlockInited;
	}
}
