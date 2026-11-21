using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7B RID: 11643
	public class SeqEventAddTagToSelf : ActionParams
	{
		// Token: 0x0600FDF8 RID: 65016 RVA: 0x0024A7A8 File Offset: 0x002489A8
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

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x0600FDF9 RID: 65017 RVA: 0x0024A7C8 File Offset: 0x002489C8
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

		// Token: 0x04008AA9 RID: 35497
		private ISeqEventAddTagToSelf Instance;

		// Token: 0x04008AAA RID: 35498
		private List<int> _TagsCache;

		// Token: 0x04008AAB RID: 35499
		private bool _TagsInited;
	}
}
