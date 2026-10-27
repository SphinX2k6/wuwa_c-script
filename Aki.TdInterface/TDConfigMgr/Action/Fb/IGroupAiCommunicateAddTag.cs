using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F6 RID: 9974
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiCommunicateAddTag : IGroupAiCommunicateMode
	{
		// Token: 0x0600DEB2 RID: 57010 RVA: 0x002107F8 File Offset: 0x0020E9F8
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

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x0600DEB3 RID: 57011 RVA: 0x00210817 File Offset: 0x0020EA17
		public override EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x0600DEB4 RID: 57012 RVA: 0x00210824 File Offset: 0x0020EA24
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

		// Token: 0x04007B9A RID: 31642
		private IGroupAiCommunicateAddTag Instance;

		// Token: 0x04007B9B RID: 31643
		private List<string> _TagsCache;

		// Token: 0x04007B9C RID: 31644
		private bool _TagsInited;
	}
}
