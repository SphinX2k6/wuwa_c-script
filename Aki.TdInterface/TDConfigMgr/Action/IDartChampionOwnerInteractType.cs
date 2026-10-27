using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001966 RID: 6502
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartChampionOwnerInteractType : IDartInteractTypeBase
	{
		// Token: 0x06008B49 RID: 35657 RVA: 0x00147980 File Offset: 0x00145B80
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

		// Token: 0x06008B4A RID: 35658 RVA: 0x001479B8 File Offset: 0x00145BB8
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

		// Token: 0x06008B4B RID: 35659 RVA: 0x001479CB File Offset: 0x00145BCB
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

		// Token: 0x06008B4C RID: 35660 RVA: 0x001479DE File Offset: 0x00145BDE
		public new IDartChampionOwnerInteractType_SetValue ToSetValue()
		{
			return new IDartChampionOwnerInteractType_SetValue
			{
				Type = this.Type,
				CompetitorId = this.CompetitorId
			};
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x001479FD File Offset: 0x00145BFD
		// (set) Token: 0x06008B4E RID: 35662 RVA: 0x00147A28 File Offset: 0x00145C28
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

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x06008B4F RID: 35663 RVA: 0x00147A36 File Offset: 0x00145C36
		// (set) Token: 0x06008B50 RID: 35664 RVA: 0x00147A61 File Offset: 0x00145C61
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

		// Token: 0x040056ED RID: 22253
		[Nullable(2)]
		protected new IDartChampionOwnerInteractType FbInstance;

		// Token: 0x040056EE RID: 22254
		[Nullable(2)]
		protected new IDartChampionOwnerInteractType_SetValue PocoInterface;
	}
}
