using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E83 RID: 7811
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlashTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600A722 RID: 42786 RVA: 0x00179E9C File Offset: 0x0017809C
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

		// Token: 0x0600A723 RID: 42787 RVA: 0x00179ED4 File Offset: 0x001780D4
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

		// Token: 0x0600A724 RID: 42788 RVA: 0x00179EE7 File Offset: 0x001780E7
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

		// Token: 0x0600A725 RID: 42789 RVA: 0x00179EFA File Offset: 0x001780FA
		public new ISlashTowerPrefabConfig_SetValue ToSetValue()
		{
			return new ISlashTowerPrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A726 RID: 42790 RVA: 0x00179F19 File Offset: 0x00178119
		// (set) Token: 0x0600A727 RID: 42791 RVA: 0x00179F44 File Offset: 0x00178144
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

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x00179F52 File Offset: 0x00178152
		// (set) Token: 0x0600A729 RID: 42793 RVA: 0x00179F7D File Offset: 0x0017817D
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

		// Token: 0x040063BF RID: 25535
		[Nullable(2)]
		protected new ISlashTowerPrefabConfig FbInstance;

		// Token: 0x040063C0 RID: 25536
		[Nullable(2)]
		protected new ISlashTowerPrefabConfig_SetValue PocoInterface;
	}
}
