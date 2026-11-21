using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F97 RID: 8087
	public class IRandomPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600ABF1 RID: 44017 RVA: 0x00185000 File Offset: 0x00183200
		private IRandomPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x00185038 File Offset: 0x00183238
		public static IRandomPrefabConfig Create([Nullable(2)] IRandomPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x0018504B File Offset: 0x0018324B
		public static IRandomPrefabConfig CreateFromSetValue([Nullable(2)] IRandomPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x0018505E File Offset: 0x0018325E
		public new IRandomPrefabConfig_SetValue ToSetValue()
		{
			return new IRandomPrefabConfig_SetValue
			{
				Type = this.Type,
				RandomPrefabId = this.RandomPrefabId
			};
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600ABF5 RID: 44021 RVA: 0x0018507D File Offset: 0x0018327D
		// (set) Token: 0x0600ABF6 RID: 44022 RVA: 0x001850A8 File Offset: 0x001832A8
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

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600ABF7 RID: 44023 RVA: 0x001850B6 File Offset: 0x001832B6
		// (set) Token: 0x0600ABF8 RID: 44024 RVA: 0x001850E1 File Offset: 0x001832E1
		public virtual int RandomPrefabId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RandomPrefabId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RandomPrefabId;
			}
			set
			{
				this.GetOrCreatePoco().RandomPrefabId = value;
			}
		}

		// Token: 0x040066DD RID: 26333
		[Nullable(2)]
		protected new IRandomPrefabConfig FbInstance;

		// Token: 0x040066DE RID: 26334
		[Nullable(2)]
		protected new IRandomPrefabConfig_SetValue PocoInterface;
	}
}
