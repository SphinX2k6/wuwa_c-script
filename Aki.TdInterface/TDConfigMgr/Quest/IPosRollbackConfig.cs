using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001189 RID: 4489
	public class IPosRollbackConfig
	{
		// Token: 0x060063C0 RID: 25536 RVA: 0x000EFF8C File Offset: 0x000EE18C
		private IPosRollbackConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPosRollbackConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPosRollbackConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPosRollbackConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x000EFFC4 File Offset: 0x000EE1C4
		public static IPosRollbackConfig Create([Nullable(2)] IPosRollbackConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPosRollbackConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x000EFFD7 File Offset: 0x000EE1D7
		public static IPosRollbackConfig CreateFromSetValue([Nullable(2)] IPosRollbackConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPosRollbackConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x000EFFEA File Offset: 0x000EE1EA
		public IPosRollbackConfig_SetValue ToSetValue()
		{
			return new IPosRollbackConfig_SetValue
			{
				RangeEntityId = this.RangeEntityId,
				PositionEntityId = this.PositionEntityId,
				GravityFlip = this.GravityFlip
			};
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x000F0018 File Offset: 0x000EE218
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x000F0052 File Offset: 0x000EE252
		public virtual int? RangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntityId;
				}
				IPosRollbackConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntityId = value;
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x000F0060 File Offset: 0x000EE260
		// (set) Token: 0x060063C7 RID: 25543 RVA: 0x000F008B File Offset: 0x000EE28B
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x000F009C File Offset: 0x000EE29C
		// (set) Token: 0x060063C9 RID: 25545 RVA: 0x000F00D6 File Offset: 0x000EE2D6
		public virtual bool? GravityFlip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravityFlip;
				}
				IPosRollbackConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravityFlip;
			}
			set
			{
				this.GetOrCreatePoco().GravityFlip = value;
			}
		}

		// Token: 0x04003BC3 RID: 15299
		[Nullable(2)]
		protected IPosRollbackConfig FbInstance;

		// Token: 0x04003BC4 RID: 15300
		[Nullable(2)]
		protected IPosRollbackConfig_SetValue PocoInterface;
	}
}
