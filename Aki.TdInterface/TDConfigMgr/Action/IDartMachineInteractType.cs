using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196C RID: 6508
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartMachineInteractType : IDartInteractTypeBase
	{
		// Token: 0x06008B67 RID: 35687 RVA: 0x00147C7C File Offset: 0x00145E7C
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

		// Token: 0x06008B68 RID: 35688 RVA: 0x00147CB4 File Offset: 0x00145EB4
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

		// Token: 0x06008B69 RID: 35689 RVA: 0x00147CC7 File Offset: 0x00145EC7
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

		// Token: 0x06008B6A RID: 35690 RVA: 0x00147CDA File Offset: 0x00145EDA
		public new IDartMachineInteractType_SetValue ToSetValue()
		{
			return new IDartMachineInteractType_SetValue
			{
				Type = this.Type,
				CanInviteCompetitorIds = this.CanInviteCompetitorIds,
				ChampionId = this.ChampionId
			};
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06008B6B RID: 35691 RVA: 0x00147D05 File Offset: 0x00145F05
		// (set) Token: 0x06008B6C RID: 35692 RVA: 0x00147D30 File Offset: 0x00145F30
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

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06008B6D RID: 35693 RVA: 0x00147D3E File Offset: 0x00145F3E
		// (set) Token: 0x06008B6E RID: 35694 RVA: 0x00147D65 File Offset: 0x00145F65
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

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x06008B6F RID: 35695 RVA: 0x00147D74 File Offset: 0x00145F74
		// (set) Token: 0x06008B70 RID: 35696 RVA: 0x00147DAE File Offset: 0x00145FAE
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

		// Token: 0x040056F9 RID: 22265
		[Nullable(2)]
		protected new IDartMachineInteractType FbInstance;

		// Token: 0x040056FA RID: 22266
		[Nullable(2)]
		protected new IDartMachineInteractType_SetValue PocoInterface;
	}
}
