using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B2 RID: 5042
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetPartCondition
	{
		// Token: 0x06007326 RID: 29478 RVA: 0x00114848 File Offset: 0x00112A48
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

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06007327 RID: 29479 RVA: 0x00114868 File Offset: 0x00112A68
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

		// Token: 0x04004296 RID: 17046
		private ITakePhoto2TargetPartCondition Instance;

		// Token: 0x04004297 RID: 17047
		private List<string> _TagsCache;

		// Token: 0x04004298 RID: 17048
		private bool _TagsInited;
	}
}
