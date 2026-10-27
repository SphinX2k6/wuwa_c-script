using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080B RID: 2059
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelData
	{
		// Token: 0x06002CB1 RID: 11441 RVA: 0x00073DFC File Offset: 0x00071FFC
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

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00073E34 File Offset: 0x00072034
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

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00073E47 File Offset: 0x00072047
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

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00073E5A File Offset: 0x0007205A
		public IWuWaGoLevelData_SetValue ToSetValue()
		{
			return new IWuWaGoLevelData_SetValue
			{
				Key = this.Key,
				GridDatas = this.GridDatas,
				RoleInfos = this.RoleInfos
			};
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x00073E85 File Offset: 0x00072085
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x00073EB0 File Offset: 0x000720B0
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00073EC0 File Offset: 0x000720C0
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00073F53 File Offset: 0x00072153
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x00073F68 File Offset: 0x00072168
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00073FFB File Offset: 0x000721FB
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

		// Token: 0x04001D8F RID: 7567
		[Nullable(2)]
		protected IWuWaGoLevelData FbInstance;

		// Token: 0x04001D90 RID: 7568
		[Nullable(2)]
		protected IWuWaGoLevelData_SetValue PocoInterface;

		// Token: 0x04001D91 RID: 7569
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x04001D92 RID: 7570
		private bool _GridDatasInited;

		// Token: 0x04001D93 RID: 7571
		private List<IWuWaGoRoleInfo> _RoleInfosCache;

		// Token: 0x04001D94 RID: 7572
		private bool _RoleInfosInited;
	}
}
