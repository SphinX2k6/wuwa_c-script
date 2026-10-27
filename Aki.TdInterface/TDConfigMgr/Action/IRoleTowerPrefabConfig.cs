using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCE RID: 7630
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600A365 RID: 41829 RVA: 0x001730B8 File Offset: 0x001712B8
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

		// Token: 0x0600A366 RID: 41830 RVA: 0x001730F0 File Offset: 0x001712F0
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

		// Token: 0x0600A367 RID: 41831 RVA: 0x00173103 File Offset: 0x00171303
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

		// Token: 0x0600A368 RID: 41832 RVA: 0x00173116 File Offset: 0x00171316
		public new IRoleTowerPrefabConfig_SetValue ToSetValue()
		{
			return new IRoleTowerPrefabConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600A369 RID: 41833 RVA: 0x00173129 File Offset: 0x00171329
		// (set) Token: 0x0600A36A RID: 41834 RVA: 0x00173154 File Offset: 0x00171354
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

		// Token: 0x040061F9 RID: 25081
		[Nullable(2)]
		protected new IRoleTowerPrefabConfig FbInstance;

		// Token: 0x040061FA RID: 25082
		[Nullable(2)]
		protected new IRoleTowerPrefabConfig_SetValue PocoInterface;
	}
}
