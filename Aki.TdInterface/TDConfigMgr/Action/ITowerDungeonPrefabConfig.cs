using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD4 RID: 8148
	[NullableContext(1)]
	[Nullable(0)]
	public class ITowerDungeonPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600B342 RID: 45890 RVA: 0x001A1620 File Offset: 0x0019F820
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

		// Token: 0x0600B343 RID: 45891 RVA: 0x001A1658 File Offset: 0x0019F858
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

		// Token: 0x0600B344 RID: 45892 RVA: 0x001A166B File Offset: 0x0019F86B
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

		// Token: 0x0600B345 RID: 45893 RVA: 0x001A167E File Offset: 0x0019F87E
		public new ITowerDungeonPrefabConfig_SetValue ToSetValue()
		{
			return new ITowerDungeonPrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x001A169D File Offset: 0x0019F89D
		// (set) Token: 0x0600B347 RID: 45895 RVA: 0x001A16C8 File Offset: 0x0019F8C8
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

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x001A16D6 File Offset: 0x0019F8D6
		// (set) Token: 0x0600B349 RID: 45897 RVA: 0x001A1701 File Offset: 0x0019F901
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

		// Token: 0x04006C28 RID: 27688
		[Nullable(2)]
		protected new ITowerDungeonPrefabConfig FbInstance;

		// Token: 0x04006C29 RID: 27689
		[Nullable(2)]
		protected new ITowerDungeonPrefabConfig_SetValue PocoInterface;
	}
}
