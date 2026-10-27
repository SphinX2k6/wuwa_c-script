using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002797 RID: 10135
	[NullableContext(1)]
	[Nullable(0)]
	public class HideGroup : ActionParams
	{
		// Token: 0x0600E196 RID: 57750 RVA: 0x002156B0 File Offset: 0x002138B0
		public static HideGroup Create(IHideGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x0600E197 RID: 57751 RVA: 0x002156CF File Offset: 0x002138CF
		public virtual string GroupKey
		{
			get
			{
				return this.Instance.GroupKey;
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x0600E198 RID: 57752 RVA: 0x002156DC File Offset: 0x002138DC
		public virtual IHideGroupType HideConfig
		{
			get
			{
				if (this._HideConfigInited)
				{
					return this._HideConfigCache;
				}
				this._HideConfigInited = true;
				this._HideConfigCache = ActionReadHelper.ReadHideGroup_HideConfig(this.Instance);
				return this._HideConfigCache;
			}
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x0600E199 RID: 57753 RVA: 0x0021570C File Offset: 0x0021390C
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsHidePasserByNpc);
			}
		}

		// Token: 0x04007D19 RID: 32025
		private IHideGroup Instance;

		// Token: 0x04007D1A RID: 32026
		private IHideGroupType _HideConfigCache;

		// Token: 0x04007D1B RID: 32027
		private bool _HideConfigInited;
	}
}
