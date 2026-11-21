using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF1 RID: 6897
	public class IDartChampionOwnerInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600927F RID: 37503 RVA: 0x001573BC File Offset: 0x001555BC
		private IDartChampionOwnerInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartChampionOwnerInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartChampionOwnerInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartChampionOwnerInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x001573F4 File Offset: 0x001555F4
		public static IDartChampionOwnerInteractType Create([Nullable(2)] IDartChampionOwnerInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartChampionOwnerInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x00157407 File Offset: 0x00155607
		public static IDartChampionOwnerInteractType CreateFromSetValue([Nullable(2)] IDartChampionOwnerInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartChampionOwnerInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x0015741A File Offset: 0x0015561A
		public new IDartChampionOwnerInteractType_SetValue ToSetValue()
		{
			return new IDartChampionOwnerInteractType_SetValue
			{
				Type = this.Type,
				CompetitorId = this.CompetitorId
			};
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x06009283 RID: 37507 RVA: 0x00157439 File Offset: 0x00155639
		// (set) Token: 0x06009284 RID: 37508 RVA: 0x00157464 File Offset: 0x00155664
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

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x00157472 File Offset: 0x00155672
		// (set) Token: 0x06009286 RID: 37510 RVA: 0x0015749D File Offset: 0x0015569D
		public virtual int CompetitorId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompetitorId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CompetitorId;
			}
			set
			{
				this.GetOrCreatePoco().CompetitorId = value;
			}
		}

		// Token: 0x04005B41 RID: 23361
		[Nullable(2)]
		protected new IDartChampionOwnerInteractType FbInstance;

		// Token: 0x04005B42 RID: 23362
		[Nullable(2)]
		protected new IDartChampionOwnerInteractType_SetValue PocoInterface;
	}
}
