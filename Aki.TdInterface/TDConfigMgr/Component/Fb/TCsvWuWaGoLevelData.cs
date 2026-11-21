using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5E RID: 3934
	public class TCsvWuWaGoLevelData
	{
		// Token: 0x06005825 RID: 22565 RVA: 0x000D7815 File Offset: 0x000D5A15
		public static TCsvWuWaGoLevelData Create(TCsvWuWaGoLevelData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvWuWaGoLevelData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x000D7834 File Offset: 0x000D5A34
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x000D7844 File Offset: 0x000D5A44
		public virtual List<IWuWaGoGridData> GridDatas
		{
			get
			{
				if (this._GridDatasInited)
				{
					return this._GridDatasCache;
				}
				this._GridDatasInited = true;
				int gridDatasLength = this.Instance.GridDatasLength;
				this._GridDatasCache = new List<IWuWaGoGridData>(gridDatasLength);
				for (int i = 0; i < gridDatasLength; i++)
				{
					this._GridDatasCache.Add(IWuWaGoGridData.Create(this.Instance.GridDatas(i)));
				}
				return this._GridDatasCache;
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x000D78B0 File Offset: 0x000D5AB0
		public virtual List<IWuWaGoRoleInfo> RoleList
		{
			get
			{
				if (this._RoleListInited)
				{
					return this._RoleListCache;
				}
				this._RoleListInited = true;
				int roleListLength = this.Instance.RoleListLength;
				this._RoleListCache = new List<IWuWaGoRoleInfo>(roleListLength);
				for (int i = 0; i < roleListLength; i++)
				{
					this._RoleListCache.Add(IWuWaGoRoleInfo.Create(this.Instance.RoleList(i)));
				}
				return this._RoleListCache;
			}
		}

		// Token: 0x0400329D RID: 12957
		private TCsvWuWaGoLevelData Instance;

		// Token: 0x0400329E RID: 12958
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x0400329F RID: 12959
		private bool _GridDatasInited;

		// Token: 0x040032A0 RID: 12960
		private List<IWuWaGoRoleInfo> _RoleListCache;

		// Token: 0x040032A1 RID: 12961
		private bool _RoleListInited;
	}
}
