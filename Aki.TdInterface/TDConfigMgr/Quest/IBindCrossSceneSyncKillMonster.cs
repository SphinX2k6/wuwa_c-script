using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EDA RID: 3802
	[NullableContext(1)]
	[Nullable(0)]
	public class IBindCrossSceneSyncKillMonster
	{
		// Token: 0x060053EE RID: 21486 RVA: 0x000CE46C File Offset: 0x000CC66C
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

		// Token: 0x060053EF RID: 21487 RVA: 0x000CE4A4 File Offset: 0x000CC6A4
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

		// Token: 0x060053F0 RID: 21488 RVA: 0x000CE4B7 File Offset: 0x000CC6B7
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

		// Token: 0x060053F1 RID: 21489 RVA: 0x000CE4CA File Offset: 0x000CC6CA
		public IBindCrossSceneSyncKillMonster_SetValue ToSetValue()
		{
			return new IBindCrossSceneSyncKillMonster_SetValue
			{
				EntityBundleIds = this.EntityBundleIds
			};
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x000CE4DD File Offset: 0x000CC6DD
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x000CE504 File Offset: 0x000CC704
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

		// Token: 0x040032D1 RID: 13009
		[Nullable(2)]
		protected IBindCrossSceneSyncKillMonster FbInstance;

		// Token: 0x040032D2 RID: 13010
		[Nullable(2)]
		protected IBindCrossSceneSyncKillMonster_SetValue PocoInterface;
	}
}
