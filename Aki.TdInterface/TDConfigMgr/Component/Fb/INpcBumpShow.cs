using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7B RID: 3195
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcBumpShow
	{
		// Token: 0x060048EC RID: 18668 RVA: 0x000B82C2 File Offset: 0x000B64C2
		[NullableContext(0)]
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

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x000B82E1 File Offset: 0x000B64E1
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

		// Token: 0x04002908 RID: 10504
		private INpcBumpShow Instance;

		// Token: 0x04002909 RID: 10505
		private INpcPerformBubble _BumpBubbleCache;

		// Token: 0x0400290A RID: 10506
		private bool _BumpBubbleInited;
	}
}
