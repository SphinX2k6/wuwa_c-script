using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E0 RID: 9952
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTag : ISendBattleStateType
	{
		// Token: 0x0600DE59 RID: 56921 RVA: 0x0020FD36 File Offset: 0x0020DF36
		public static ISetBattleTag Create(ISetBattleTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0600DE5A RID: 56922 RVA: 0x0020FD55 File Offset: 0x0020DF55
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x0600DE5B RID: 56923 RVA: 0x0020FD64 File Offset: 0x0020DF64
		public virtual List<ISetEntityTag> SetTags
		{
			get
			{
				if (this._SetTagsInited)
				{
					return this._SetTagsCache;
				}
				this._SetTagsInited = true;
				int setTagsLength = this.Instance.SetTagsLength;
				this._SetTagsCache = new List<ISetEntityTag>(setTagsLength);
				for (int i = 0; i < setTagsLength; i++)
				{
					this._SetTagsCache.Add(ISetEntityTag.Create(this.Instance.SetTags(i)));
				}
				return this._SetTagsCache;
			}
		}

		// Token: 0x04007B6C RID: 31596
		private ISetBattleTag Instance;

		// Token: 0x04007B6D RID: 31597
		private List<ISetEntityTag> _SetTagsCache;

		// Token: 0x04007B6E RID: 31598
		private bool _SetTagsInited;
	}
}
