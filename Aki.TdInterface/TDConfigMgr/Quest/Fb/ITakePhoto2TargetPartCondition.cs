using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001503 RID: 5379
	public class ITakePhoto2TargetPartCondition
	{
		// Token: 0x060079CD RID: 31181 RVA: 0x00122F04 File Offset: 0x00121104
		public static ITakePhoto2TargetPartCondition Create(ITakePhoto2TargetPartCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPartCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x060079CE RID: 31182 RVA: 0x00122F24 File Offset: 0x00121124
		public virtual List<string> Tags
		{
			get
			{
				if (this._TagsInited)
				{
					return this._TagsCache;
				}
				this._TagsInited = true;
				int tagsLength = this.Instance.TagsLength;
				this._TagsCache = new List<string>(tagsLength);
				for (int i = 0; i < tagsLength; i++)
				{
					this._TagsCache.Add(this.Instance.Tags(i));
				}
				return this._TagsCache;
			}
		}

		// Token: 0x04004617 RID: 17943
		private ITakePhoto2TargetPartCondition Instance;

		// Token: 0x04004618 RID: 17944
		private List<string> _TagsCache;

		// Token: 0x04004619 RID: 17945
		private bool _TagsInited;
	}
}
