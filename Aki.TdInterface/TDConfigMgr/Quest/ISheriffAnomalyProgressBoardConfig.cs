using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200112E RID: 4398
	[NullableContext(1)]
	[Nullable(0)]
	public class ISheriffAnomalyProgressBoardConfig
	{
		// Token: 0x060063F0 RID: 25584 RVA: 0x000F0A44 File Offset: 0x000EEC44
		private ISheriffAnomalyProgressBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffAnomalyProgressBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffAnomalyProgressBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffAnomalyProgressBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x000F0A7C File Offset: 0x000EEC7C
		public static ISheriffAnomalyProgressBoardConfig Create([Nullable(2)] ISheriffAnomalyProgressBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x000F0A8F File Offset: 0x000EEC8F
		public static ISheriffAnomalyProgressBoardConfig CreateFromSetValue([Nullable(2)] ISheriffAnomalyProgressBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x000F0AA2 File Offset: 0x000EECA2
		public ISheriffAnomalyProgressBoardConfig_SetValue ToSetValue()
		{
			return new ISheriffAnomalyProgressBoardConfig_SetValue
			{
				AnomalyId = this.AnomalyId
			};
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x000F0AB5 File Offset: 0x000EECB5
		// (set) Token: 0x060063F5 RID: 25589 RVA: 0x000F0AE0 File Offset: 0x000EECE0
		public virtual int AnomalyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnomalyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AnomalyId;
			}
			set
			{
				this.GetOrCreatePoco().AnomalyId = value;
			}
		}

		// Token: 0x04003C20 RID: 15392
		[Nullable(2)]
		protected ISheriffAnomalyProgressBoardConfig FbInstance;

		// Token: 0x04003C21 RID: 15393
		[Nullable(2)]
		protected ISheriffAnomalyProgressBoardConfig_SetValue PocoInterface;
	}
}
