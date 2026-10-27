using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E4D RID: 3661
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvWuWaGoLevelData
	{
		// Token: 0x060052A9 RID: 21161 RVA: 0x000CB661 File Offset: 0x000C9861
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

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060052AA RID: 21162 RVA: 0x000CB680 File Offset: 0x000C9880
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x000CB690 File Offset: 0x000C9890
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

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x000CB6FC File Offset: 0x000C98FC
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

		// Token: 0x04002FA6 RID: 12198
		private TCsvWuWaGoLevelData Instance;

		// Token: 0x04002FA7 RID: 12199
		private List<IWuWaGoGridData> _GridDatasCache;

		// Token: 0x04002FA8 RID: 12200
		private bool _GridDatasInited;

		// Token: 0x04002FA9 RID: 12201
		private List<IWuWaGoRoleInfo> _RoleListCache;

		// Token: 0x04002FAA RID: 12202
		private bool _RoleListInited;
	}
}
