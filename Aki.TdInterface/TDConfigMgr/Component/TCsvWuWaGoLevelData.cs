using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095E RID: 2398
	public class TCsvWuWaGoLevelData
	{
		// Token: 0x06003572 RID: 13682 RVA: 0x0008809D File Offset: 0x0008629D
		public static TCsvWuWaGoLevelData Create([Nullable(2)] TCsvWuWaGoLevelData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvWuWaGoLevelData
			{
				FbInstance = instance
			};
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x000880B0 File Offset: 0x000862B0
		public virtual string Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x000880C0 File Offset: 0x000862C0
		public virtual List<IWuWaGoGridData> GridDatas
		{
			get
			{
				if (this._GridDatasInited)
				{
					return this._GridDatasCache;
				}
				this._GridDatasInited = true;
				if (this.FbInstance != null)
				{
					List<IWuWaGoGridData> gridDatas = this.FbInstance.GridDatas;
					if (gridDatas != null)
					{
						this._GridDatasCache = new List<IWuWaGoGridData>(gridDatas.Count);
						for (int i = 0; i < gridDatas.Count; i++)
						{
							this._GridDatasCache.Add(IWuWaGoGridData.Create(gridDatas[i]));
						}
					}
				}
				return this._GridDatasCache;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x0008813C File Offset: 0x0008633C
		public virtual List<IWuWaGoRoleInfo> RoleList
		{
			get
			{
				if (this._RoleListInited)
				{
					return this._RoleListCache;
				}
				this._RoleListInited = true;
				if (this.FbInstance != null)
				{
					List<IWuWaGoRoleInfo> roleList = this.FbInstance.RoleList;
					if (roleList != null)
					{
						this._RoleListCache = new List<IWuWaGoRoleInfo>(roleList.Count);
						for (int i = 0; i < roleList.Count; i++)
						{
							this._RoleListCache.Add(IWuWaGoRoleInfo.Create(roleList[i]));
						}
					}
				}
				return this._RoleListCache;
			}
		}

		// Token: 0x040022FB RID: 8955
		private TCsvWuWaGoLevelData FbInstance;

		// Token: 0x040022FC RID: 8956
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x040022FD RID: 8957
		private bool _GridDatasInited;

		// Token: 0x040022FE RID: 8958
		private List<IWuWaGoRoleInfo> _RoleListCache;

		// Token: 0x040022FF RID: 8959
		private bool _RoleListInited;
	}
}
