using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146C RID: 5228
	[NullableContext(2)]
	[Nullable(0)]
	public class ITetrisSingleGrid
	{
		// Token: 0x060076F3 RID: 30451 RVA: 0x0011C4CA File Offset: 0x0011A6CA
		[NullableContext(1)]
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

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x060076F4 RID: 30452 RVA: 0x0011C4E9 File Offset: 0x0011A6E9
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

		// Token: 0x04004522 RID: 17698
		private ITetrisSingleGrid Instance;

		// Token: 0x04004523 RID: 17699
		private ITetrisSingleBlock _BlockCache;

		// Token: 0x04004524 RID: 17700
		private bool _BlockInited;
	}
}
