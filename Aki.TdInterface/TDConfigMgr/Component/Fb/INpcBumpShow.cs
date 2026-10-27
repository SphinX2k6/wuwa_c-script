using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAD RID: 2989
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcBumpShow
	{
		// Token: 0x06004493 RID: 17555 RVA: 0x000AE1FE File Offset: 0x000AC3FE
		[NullableContext(1)]
		public static INpcBumpShow Create(INpcBumpShow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcBumpShow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004494 RID: 17556 RVA: 0x000AE21D File Offset: 0x000AC41D
		public virtual INpcPerformBubble BumpBubble
		{
			get
			{
				if (this._BumpBubbleInited)
				{
					return this._BumpBubbleCache;
				}
				this._BumpBubbleInited = true;
				this._BumpBubbleCache = INpcPerformBubble.Create(this.Instance.BumpBubble);
				return this._BumpBubbleCache;
			}
		}

		// Token: 0x040026C0 RID: 9920
		private INpcBumpShow Instance;

		// Token: 0x040026C1 RID: 9921
		private INpcPerformBubble _BumpBubbleCache;

		// Token: 0x040026C2 RID: 9922
		private bool _BumpBubbleInited;
	}
}
