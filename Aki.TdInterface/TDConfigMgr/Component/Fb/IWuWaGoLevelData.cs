using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E00 RID: 3584
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelData
	{
		// Token: 0x0600512A RID: 20778 RVA: 0x000C84DA File Offset: 0x000C66DA
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

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600512B RID: 20779 RVA: 0x000C84F9 File Offset: 0x000C66F9
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x000C8508 File Offset: 0x000C6708
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600512D RID: 20781 RVA: 0x000C8574 File Offset: 0x000C6774
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

		// Token: 0x04002EAD RID: 11949
		private IWuWaGoLevelData Instance;

		// Token: 0x04002EAE RID: 11950
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x04002EAF RID: 11951
		private bool _GridDatasInited;

		// Token: 0x04002EB0 RID: 11952
		private List<IWuWaGoRoleInfo> _RoleInfosCache;

		// Token: 0x04002EB1 RID: 11953
		private bool _RoleInfosInited;
	}
}
