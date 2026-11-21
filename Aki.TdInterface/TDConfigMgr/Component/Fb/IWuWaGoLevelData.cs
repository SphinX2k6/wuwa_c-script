using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EFC RID: 3836
	public class IWuWaGoLevelData
	{
		// Token: 0x06005651 RID: 22097 RVA: 0x000D3DA2 File Offset: 0x000D1FA2
		public static IWuWaGoLevelData Create(IWuWaGoLevelData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoLevelData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x000D3DC1 File Offset: 0x000D1FC1
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06005653 RID: 22099 RVA: 0x000D3DD0 File Offset: 0x000D1FD0
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

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06005654 RID: 22100 RVA: 0x000D3E3C File Offset: 0x000D203C
		public virtual List<IWuWaGoRoleInfo> RoleInfos
		{
			get
			{
				if (this._RoleInfosInited)
				{
					return this._RoleInfosCache;
				}
				this._RoleInfosInited = true;
				int roleInfosLength = this.Instance.RoleInfosLength;
				this._RoleInfosCache = new List<IWuWaGoRoleInfo>(roleInfosLength);
				for (int i = 0; i < roleInfosLength; i++)
				{
					this._RoleInfosCache.Add(IWuWaGoRoleInfo.Create(this.Instance.RoleInfos(i)));
				}
				return this._RoleInfosCache;
			}
		}

		// Token: 0x04003175 RID: 12661
		private IWuWaGoLevelData Instance;

		// Token: 0x04003176 RID: 12662
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x04003177 RID: 12663
		private bool _GridDatasInited;

		// Token: 0x04003178 RID: 12664
		private List<IWuWaGoRoleInfo> _RoleInfosCache;

		// Token: 0x04003179 RID: 12665
		private bool _RoleInfosInited;
	}
}
