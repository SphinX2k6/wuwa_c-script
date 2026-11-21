using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF7 RID: 6903
	public class IDartMachineInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600929D RID: 37533 RVA: 0x001576B8 File Offset: 0x001558B8
		private IDartMachineInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartMachineInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartMachineInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartMachineInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x001576F0 File Offset: 0x001558F0
		public static IDartMachineInteractType Create([Nullable(2)] IDartMachineInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartMachineInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00157703 File Offset: 0x00155903
		public static IDartMachineInteractType CreateFromSetValue([Nullable(2)] IDartMachineInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartMachineInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x00157716 File Offset: 0x00155916
		public new IDartMachineInteractType_SetValue ToSetValue()
		{
			return new IDartMachineInteractType_SetValue
			{
				Type = this.Type,
				CanInviteCompetitorIds = this.CanInviteCompetitorIds,
				ChampionId = this.ChampionId
			};
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x060092A1 RID: 37537 RVA: 0x00157741 File Offset: 0x00155941
		// (set) Token: 0x060092A2 RID: 37538 RVA: 0x0015776C File Offset: 0x0015596C
		public override EDartInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDartInteractType.Machine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x0015777A File Offset: 0x0015597A
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x001577A1 File Offset: 0x001559A1
		public virtual List<int> CanInviteCompetitorIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanInviteCompetitorIds;
				}
				IDartMachineInteractType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanInviteCompetitorIds;
			}
			set
			{
				this.GetOrCreatePoco().CanInviteCompetitorIds = value;
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x001577B0 File Offset: 0x001559B0
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x001577EA File Offset: 0x001559EA
		public virtual int? ChampionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChampionId;
				}
				IDartMachineInteractType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChampionId;
			}
			set
			{
				this.GetOrCreatePoco().ChampionId = value;
			}
		}

		// Token: 0x04005B4D RID: 23373
		[Nullable(2)]
		protected new IDartMachineInteractType FbInstance;

		// Token: 0x04005B4E RID: 23374
		[Nullable(2)]
		protected new IDartMachineInteractType_SetValue PocoInterface;
	}
}
