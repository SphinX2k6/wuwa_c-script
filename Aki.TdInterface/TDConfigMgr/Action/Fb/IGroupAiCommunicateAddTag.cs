using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BC RID: 10684
	public class IGroupAiCommunicateAddTag : IGroupAiCommunicateMode
	{
		// Token: 0x0600EC9A RID: 60570 RVA: 0x0022D160 File Offset: 0x0022B360
		public static IGroupAiCommunicateAddTag Create(IGroupAiCommunicateAddTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiCommunicateAddTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x0022D17F File Offset: 0x0022B37F
		public override EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x0600EC9C RID: 60572 RVA: 0x0022D18C File Offset: 0x0022B38C
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

		// Token: 0x0400823E RID: 33342
		private IGroupAiCommunicateAddTag Instance;

		// Token: 0x0400823F RID: 33343
		private List<string> _TagsCache;

		// Token: 0x04008240 RID: 33344
		private bool _TagsInited;
	}
}
