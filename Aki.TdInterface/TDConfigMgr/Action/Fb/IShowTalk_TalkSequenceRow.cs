using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B11 RID: 11025
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalk_TalkSequenceRow
	{
		// Token: 0x0600F15B RID: 61787 RVA: 0x0022FF65 File Offset: 0x0022E165
		public static IShowTalk_TalkSequenceRow Create(IShowTalk_TalkSequenceRow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalk_TalkSequenceRow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x0600F15C RID: 61788 RVA: 0x0022FF84 File Offset: 0x0022E184
		public virtual List<int> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<int>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(this.Instance.Items(i));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x040084BD RID: 33981
		private IShowTalk_TalkSequenceRow Instance;

		// Token: 0x040084BE RID: 33982
		private List<int> _ItemsCache;

		// Token: 0x040084BF RID: 33983
		private bool _ItemsInited;
	}
}
