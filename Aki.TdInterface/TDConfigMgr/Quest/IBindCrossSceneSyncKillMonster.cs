using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF0 RID: 4080
	public class IBindCrossSceneSyncKillMonster
	{
		// Token: 0x0600596A RID: 22890 RVA: 0x000DA614 File Offset: 0x000D8814
		private IBindCrossSceneSyncKillMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBindCrossSceneSyncKillMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBindCrossSceneSyncKillMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBindCrossSceneSyncKillMonster_SetValue());
			}
			return result;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x000DA64C File Offset: 0x000D884C
		public static IBindCrossSceneSyncKillMonster Create([Nullable(2)] IBindCrossSceneSyncKillMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBindCrossSceneSyncKillMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x000DA65F File Offset: 0x000D885F
		public static IBindCrossSceneSyncKillMonster CreateFromSetValue([Nullable(2)] IBindCrossSceneSyncKillMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBindCrossSceneSyncKillMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x000DA672 File Offset: 0x000D8872
		public IBindCrossSceneSyncKillMonster_SetValue ToSetValue()
		{
			return new IBindCrossSceneSyncKillMonster_SetValue
			{
				EntityBundleIds = this.EntityBundleIds
			};
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x000DA685 File Offset: 0x000D8885
		// (set) Token: 0x0600596F RID: 22895 RVA: 0x000DA6AC File Offset: 0x000D88AC
		public virtual List<int> EntityBundleIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityBundleIds;
				}
				IBindCrossSceneSyncKillMonster_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityBundleIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityBundleIds = value;
			}
		}

		// Token: 0x040035DE RID: 13790
		[Nullable(2)]
		protected IBindCrossSceneSyncKillMonster FbInstance;

		// Token: 0x040035DF RID: 13791
		[Nullable(2)]
		protected IBindCrossSceneSyncKillMonster_SetValue PocoInterface;
	}
}
