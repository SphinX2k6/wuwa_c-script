using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AE RID: 2222
	public class IWuWaGoLevelData
	{
		// Token: 0x06002FE1 RID: 12257 RVA: 0x0007B160 File Offset: 0x00079360
		private IWuWaGoLevelData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoLevelData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoLevelData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoLevelData_SetValue());
			}
			return result;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0007B198 File Offset: 0x00079398
		public static IWuWaGoLevelData Create([Nullable(2)] IWuWaGoLevelData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoLevelData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0007B1AB File Offset: 0x000793AB
		public static IWuWaGoLevelData CreateFromSetValue([Nullable(2)] IWuWaGoLevelData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoLevelData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0007B1BE File Offset: 0x000793BE
		public IWuWaGoLevelData_SetValue ToSetValue()
		{
			return new IWuWaGoLevelData_SetValue
			{
				Key = this.Key,
				GridDatas = this.GridDatas,
				RoleInfos = this.RoleInfos
			};
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x0007B1E9 File Offset: 0x000793E9
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x0007B214 File Offset: 0x00079414
		public virtual string Key
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Key;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Key;
			}
			set
			{
				this.GetOrCreatePoco().Key = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x0007B224 File Offset: 0x00079424
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x0007B2B7 File Offset: 0x000794B7
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
				else
				{
					IWuWaGoLevelData_SetValue pocoInterface = this.PocoInterface;
					this._GridDatasCache = ((pocoInterface != null) ? pocoInterface.GridDatas : null);
				}
				return this._GridDatasCache;
			}
			set
			{
				this.GetOrCreatePoco().GridDatas = value;
				this._GridDatasInited = false;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x0007B2CC File Offset: 0x000794CC
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x0007B35F File Offset: 0x0007955F
		public virtual List<IWuWaGoRoleInfo> RoleInfos
		{
			get
			{
				if (this._RoleInfosInited)
				{
					return this._RoleInfosCache;
				}
				this._RoleInfosInited = true;
				if (this.FbInstance != null)
				{
					List<IWuWaGoRoleInfo> roleInfos = this.FbInstance.RoleInfos;
					if (roleInfos != null)
					{
						this._RoleInfosCache = new List<IWuWaGoRoleInfo>(roleInfos.Count);
						for (int i = 0; i < roleInfos.Count; i++)
						{
							this._RoleInfosCache.Add(IWuWaGoRoleInfo.Create(roleInfos[i]));
						}
					}
				}
				else
				{
					IWuWaGoLevelData_SetValue pocoInterface = this.PocoInterface;
					this._RoleInfosCache = ((pocoInterface != null) ? pocoInterface.RoleInfos : null);
				}
				return this._RoleInfosCache;
			}
			set
			{
				this.GetOrCreatePoco().RoleInfos = value;
				this._RoleInfosInited = false;
			}
		}

		// Token: 0x04001F9B RID: 8091
		[Nullable(2)]
		protected IWuWaGoLevelData FbInstance;

		// Token: 0x04001F9C RID: 8092
		[Nullable(2)]
		protected IWuWaGoLevelData_SetValue PocoInterface;

		// Token: 0x04001F9D RID: 8093
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x04001F9E RID: 8094
		private bool _GridDatasInited;

		// Token: 0x04001F9F RID: 8095
		private List<IWuWaGoRoleInfo> _RoleInfosCache;

		// Token: 0x04001FA0 RID: 8096
		private bool _RoleInfosInited;
	}
}
