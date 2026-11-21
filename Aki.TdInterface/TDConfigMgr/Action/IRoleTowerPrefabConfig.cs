using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE5 RID: 8165
	public class IRoleTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600AD6F RID: 44399 RVA: 0x001877E0 File Offset: 0x001859E0
		private IRoleTowerPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x00187818 File Offset: 0x00185A18
		public static IRoleTowerPrefabConfig Create([Nullable(2)] IRoleTowerPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x0018782B File Offset: 0x00185A2B
		public static IRoleTowerPrefabConfig CreateFromSetValue([Nullable(2)] IRoleTowerPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x0018783E File Offset: 0x00185A3E
		public new IRoleTowerPrefabConfig_SetValue ToSetValue()
		{
			return new IRoleTowerPrefabConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600AD73 RID: 44403 RVA: 0x00187851 File Offset: 0x00185A51
		// (set) Token: 0x0600AD74 RID: 44404 RVA: 0x0018787C File Offset: 0x00185A7C
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

		// Token: 0x04006781 RID: 26497
		[Nullable(2)]
		protected new IRoleTowerPrefabConfig FbInstance;

		// Token: 0x04006782 RID: 26498
		[Nullable(2)]
		protected new IRoleTowerPrefabConfig_SetValue PocoInterface;
	}
}
