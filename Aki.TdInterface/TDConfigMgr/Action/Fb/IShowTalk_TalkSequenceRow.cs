using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2F RID: 11823
	public class IShowTalk_TalkSequenceRow
	{
		// Token: 0x060100AF RID: 65711 RVA: 0x0024E9FB File Offset: 0x0024CBFB
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

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x060100B0 RID: 65712 RVA: 0x0024EA1C File Offset: 0x0024CC1C
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

		// Token: 0x04008C05 RID: 35845
		private IShowTalk_TalkSequenceRow Instance;

		// Token: 0x04008C06 RID: 35846
		private List<int> _ItemsCache;

		// Token: 0x04008C07 RID: 35847
		private bool _ItemsInited;
	}
}
