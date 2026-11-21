using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BD RID: 10685
	public class IGroupAiCommunicateRemoveTag : IGroupAiCommunicateMode
	{
		// Token: 0x0600EC9E RID: 60574 RVA: 0x0022D1F8 File Offset: 0x0022B3F8
		public static IGroupAiCommunicateRemoveTag Create(IGroupAiCommunicateRemoveTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateRemoveTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x0022D217 File Offset: 0x0022B417
		public override EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x0600ECA0 RID: 60576 RVA: 0x0022D224 File Offset: 0x0022B424
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

		// Token: 0x04008241 RID: 33345
		private IGroupAiCommunicateRemoveTag Instance;

		// Token: 0x04008242 RID: 33346
		private List<string> _TagsCache;

		// Token: 0x04008243 RID: 33347
		private bool _TagsInited;
	}
}
