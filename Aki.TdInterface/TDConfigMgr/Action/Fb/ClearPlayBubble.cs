using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002719 RID: 10009
	[NullableContext(1)]
	[Nullable(0)]
	public class ClearPlayBubble : ActionParams
	{
		// Token: 0x0600DF47 RID: 57159 RVA: 0x0021175A File Offset: 0x0020F95A
		public static ClearPlayBubble Create(IClearPlayBubble? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearPlayBubble
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x0600DF48 RID: 57160 RVA: 0x0021177C File Offset: 0x0020F97C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x0600DF49 RID: 57161 RVA: 0x002117E0 File Offset: 0x0020F9E0
		public virtual bool? OnlyClearRedDot
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.OnlyClearRedDot);
			}
		}

		// Token: 0x04007BE9 RID: 31721
		private IClearPlayBubble Instance;

		// Token: 0x04007BEA RID: 31722
		private List<int> _EntityIdsCache;

		// Token: 0x04007BEB RID: 31723
		private bool _EntityIdsInited;
	}
}
