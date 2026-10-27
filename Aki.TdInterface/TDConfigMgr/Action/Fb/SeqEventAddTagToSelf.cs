using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A87 RID: 10887
	[NullableContext(1)]
	[Nullable(0)]
	public class SeqEventAddTagToSelf : ActionParams
	{
		// Token: 0x0600EF42 RID: 61250 RVA: 0x0022CA9C File Offset: 0x0022AC9C
		public static SeqEventAddTagToSelf Create(ISeqEventAddTagToSelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeqEventAddTagToSelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x0600EF43 RID: 61251 RVA: 0x0022CABC File Offset: 0x0022ACBC
		public virtual List<int> Tags
		{
			get
			{
				if (this._TagsInited)
				{
					return this._TagsCache;
				}
				this._TagsInited = true;
				int tagsLength = this.Instance.TagsLength;
				this._TagsCache = new List<int>(tagsLength);
				for (int i = 0; i < tagsLength; i++)
				{
					this._TagsCache.Add(this.Instance.Tags(i));
				}
				return this._TagsCache;
			}
		}

		// Token: 0x040083A5 RID: 33701
		private ISeqEventAddTagToSelf Instance;

		// Token: 0x040083A6 RID: 33702
		private List<int> _TagsCache;

		// Token: 0x040083A7 RID: 33703
		private bool _TagsInited;
	}
}
