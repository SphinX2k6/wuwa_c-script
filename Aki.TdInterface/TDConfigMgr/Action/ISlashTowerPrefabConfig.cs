using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B8 RID: 8376
	public class ISlashTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600B1DA RID: 45530 RVA: 0x0018FB9C File Offset: 0x0018DD9C
		private ISlashTowerPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlashTowerPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlashTowerPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlashTowerPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x0018FBD4 File Offset: 0x0018DDD4
		public static ISlashTowerPrefabConfig Create([Nullable(2)] ISlashTowerPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlashTowerPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x0018FBE7 File Offset: 0x0018DDE7
		public static ISlashTowerPrefabConfig CreateFromSetValue([Nullable(2)] ISlashTowerPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlashTowerPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x0018FBFA File Offset: 0x0018DDFA
		public new ISlashTowerPrefabConfig_SetValue ToSetValue()
		{
			return new ISlashTowerPrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x0018FC19 File Offset: 0x0018DE19
		// (set) Token: 0x0600B1DF RID: 45535 RVA: 0x0018FC44 File Offset: 0x0018DE44
		public override ECreatePrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECreatePrefabType.PrefabId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600B1E0 RID: 45536 RVA: 0x0018FC52 File Offset: 0x0018DE52
		// (set) Token: 0x0600B1E1 RID: 45537 RVA: 0x0018FC7D File Offset: 0x0018DE7D
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x040069A3 RID: 27043
		[Nullable(2)]
		protected new ISlashTowerPrefabConfig FbInstance;

		// Token: 0x040069A4 RID: 27044
		[Nullable(2)]
		protected new ISlashTowerPrefabConfig_SetValue PocoInterface;
	}
}
