using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000896 RID: 2198
	public class IWorldLevelTable : IWorldLevelBonusType
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x0007A328 File Offset: 0x00078528
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

		// Token: 0x06002F68 RID: 12136 RVA: 0x0007A360 File Offset: 0x00078560
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

		// Token: 0x06002F69 RID: 12137 RVA: 0x0007A373 File Offset: 0x00078573
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

		// Token: 0x06002F6A RID: 12138 RVA: 0x0007A386 File Offset: 0x00078586
		public new IWorldLevelTable_SetValue ToSetValue()
		{
			return new IWorldLevelTable_SetValue
			{
				Type = this.Type,
				WorldLevelBonusId = this.WorldLevelBonusId
			};
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x0007A3A5 File Offset: 0x000785A5
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x0007A3D0 File Offset: 0x000785D0
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x0007A3E0 File Offset: 0x000785E0
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x0007A41A File Offset: 0x0007861A
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

		// Token: 0x04001F5C RID: 8028
		[Nullable(2)]
		protected new IWorldLevelTable FbInstance;

		// Token: 0x04001F5D RID: 8029
		[Nullable(2)]
		protected new IWorldLevelTable_SetValue PocoInterface;
	}
}
