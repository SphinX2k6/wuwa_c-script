using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F7 RID: 9975
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiCommunicateRemoveTag : IGroupAiCommunicateMode
	{
		// Token: 0x0600DEB6 RID: 57014 RVA: 0x00210890 File Offset: 0x0020EA90
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

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x0600DEB7 RID: 57015 RVA: 0x002108AF File Offset: 0x0020EAAF
		public override EGroupAiCommunicateType Type
		{
			get
			{
				return (EGroupAiCommunicateType)this.Instance.Type;
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x0600DEB8 RID: 57016 RVA: 0x002108BC File Offset: 0x0020EABC
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

		// Token: 0x04007B9D RID: 31645
		private IGroupAiCommunicateRemoveTag Instance;

		// Token: 0x04007B9E RID: 31646
		private List<string> _TagsCache;

		// Token: 0x04007B9F RID: 31647
		private bool _TagsInited;
	}
}
