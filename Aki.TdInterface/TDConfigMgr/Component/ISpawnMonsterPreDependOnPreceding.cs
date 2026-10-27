using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006EE RID: 1774
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterPreDependOnPreceding : ISpawnMonsterPreConditonType
	{
		// Token: 0x06002638 RID: 9784 RVA: 0x000666F4 File Offset: 0x000648F4
		private ISpawnMonsterPreDependOnPreceding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterPreDependOnPreceding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterPreDependOnPreceding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterPreDependOnPreceding_SetValue());
			}
			return result;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0006672C File Offset: 0x0006492C
		public static ISpawnMonsterPreDependOnPreceding Create([Nullable(2)] ISpawnMonsterPreDependOnPreceding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x0006673F File Offset: 0x0006493F
		public static ISpawnMonsterPreDependOnPreceding CreateFromSetValue([Nullable(2)] ISpawnMonsterPreDependOnPreceding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterPreDependOnPreceding
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00066752 File Offset: 0x00064952
		public new ISpawnMonsterPreDependOnPreceding_SetValue ToSetValue()
		{
			return new ISpawnMonsterPreDependOnPreceding_SetValue
			{
				Type = this.Type,
				Ids = this.Ids
			};
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00066771 File Offset: 0x00064971
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0006679C File Offset: 0x0006499C
		public override ESpawnMonsterPreCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000667AA File Offset: 0x000649AA
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x000667D1 File Offset: 0x000649D1
		public virtual List<int> Ids
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Ids;
				}
				ISpawnMonsterPreDependOnPreceding_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Ids;
			}
			set
			{
				this.GetOrCreatePoco().Ids = value;
			}
		}

		// Token: 0x040019FA RID: 6650
		[Nullable(2)]
		protected new ISpawnMonsterPreDependOnPreceding FbInstance;

		// Token: 0x040019FB RID: 6651
		[Nullable(2)]
		protected new ISpawnMonsterPreDependOnPreceding_SetValue PocoInterface;
	}
}
