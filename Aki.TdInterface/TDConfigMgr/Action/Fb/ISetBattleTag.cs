using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A4 RID: 10660
	public class ISetBattleTag : ISendBattleStateType
	{
		// Token: 0x0600EC35 RID: 60469 RVA: 0x0022C576 File Offset: 0x0022A776
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

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x0600EC36 RID: 60470 RVA: 0x0022C595 File Offset: 0x0022A795
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x0600EC37 RID: 60471 RVA: 0x0022C5A4 File Offset: 0x0022A7A4
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

		// Token: 0x0400820C RID: 33292
		private ISetBattleTag Instance;

		// Token: 0x0400820D RID: 33293
		private List<ISetEntityTag> _SetTagsCache;

		// Token: 0x0400820E RID: 33294
		private bool _SetTagsInited;
	}
}
