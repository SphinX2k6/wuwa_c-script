using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F3 RID: 2035
	[NullableContext(1)]
	[Nullable(0)]
	public class IWorldLevelTable : IWorldLevelBonusType
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x00072FC4 File Offset: 0x000711C4
		private IWorldLevelTable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWorldLevelTable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWorldLevelTable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWorldLevelTable_SetValue());
			}
			return result;
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00072FFC File Offset: 0x000711FC
		public static IWorldLevelTable Create([Nullable(2)] IWorldLevelTable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWorldLevelTable
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x0007300F File Offset: 0x0007120F
		public static IWorldLevelTable CreateFromSetValue([Nullable(2)] IWorldLevelTable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWorldLevelTable
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00073022 File Offset: 0x00071222
		public new IWorldLevelTable_SetValue ToSetValue()
		{
			return new IWorldLevelTable_SetValue
			{
				Type = this.Type,
				WorldLevelBonusId = this.WorldLevelBonusId
			};
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x00073041 File Offset: 0x00071241
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x0007306C File Offset: 0x0007126C
		public override EWorldLevelBonus Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x0007307C File Offset: 0x0007127C
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x000730B6 File Offset: 0x000712B6
		public virtual int? WorldLevelBonusId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WorldLevelBonusId;
				}
				IWorldLevelTable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WorldLevelBonusId;
			}
			set
			{
				this.GetOrCreatePoco().WorldLevelBonusId = value;
			}
		}

		// Token: 0x04001D50 RID: 7504
		[Nullable(2)]
		protected new IWorldLevelTable FbInstance;

		// Token: 0x04001D51 RID: 7505
		[Nullable(2)]
		protected new IWorldLevelTable_SetValue PocoInterface;
	}
}
