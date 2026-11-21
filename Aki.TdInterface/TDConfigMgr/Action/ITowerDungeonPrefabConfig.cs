using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200221B RID: 8731
	public class ITowerDungeonPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600BE58 RID: 48728 RVA: 0x001B7B8C File Offset: 0x001B5D8C
		private ITowerDungeonPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITowerDungeonPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITowerDungeonPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITowerDungeonPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x001B7BC4 File Offset: 0x001B5DC4
		public static ITowerDungeonPrefabConfig Create([Nullable(2)] ITowerDungeonPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITowerDungeonPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x001B7BD7 File Offset: 0x001B5DD7
		public static ITowerDungeonPrefabConfig CreateFromSetValue([Nullable(2)] ITowerDungeonPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITowerDungeonPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x001B7BEA File Offset: 0x001B5DEA
		public new ITowerDungeonPrefabConfig_SetValue ToSetValue()
		{
			return new ITowerDungeonPrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600BE5C RID: 48732 RVA: 0x001B7C09 File Offset: 0x001B5E09
		// (set) Token: 0x0600BE5D RID: 48733 RVA: 0x001B7C34 File Offset: 0x001B5E34
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

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600BE5E RID: 48734 RVA: 0x001B7C42 File Offset: 0x001B5E42
		// (set) Token: 0x0600BE5F RID: 48735 RVA: 0x001B7C6D File Offset: 0x001B5E6D
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

		// Token: 0x0400722A RID: 29226
		[Nullable(2)]
		protected new ITowerDungeonPrefabConfig FbInstance;

		// Token: 0x0400722B RID: 29227
		[Nullable(2)]
		protected new ITowerDungeonPrefabConfig_SetValue PocoInterface;
	}
}
