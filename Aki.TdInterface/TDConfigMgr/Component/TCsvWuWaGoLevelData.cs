using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BB RID: 2235
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvWuWaGoLevelData
	{
		// Token: 0x06003236 RID: 12854 RVA: 0x00080BB5 File Offset: 0x0007EDB5
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x00080BC8 File Offset: 0x0007EDC8
		public virtual string Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x00080BD8 File Offset: 0x0007EDD8
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

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x00080C54 File Offset: 0x0007EE54
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

		// Token: 0x040020E9 RID: 8425
		private TCsvWuWaGoLevelData FbInstance;

		// Token: 0x040020EA RID: 8426
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x040020EB RID: 8427
		private bool _GridDatasInited;

		// Token: 0x040020EC RID: 8428
		private List<IWuWaGoRoleInfo> _RoleListCache;

		// Token: 0x040020ED RID: 8429
		private bool _RoleListInited;
	}
}
