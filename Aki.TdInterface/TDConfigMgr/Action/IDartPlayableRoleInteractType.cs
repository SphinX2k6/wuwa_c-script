using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200196E RID: 6510
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartPlayableRoleInteractType : IDartInteractTypeBase
	{
		// Token: 0x06008B73 RID: 35699 RVA: 0x00147DCC File Offset: 0x00145FCC
		private IDartPlayableRoleInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartPlayableRoleInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartPlayableRoleInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartPlayableRoleInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x00147E04 File Offset: 0x00146004
		public static IDartPlayableRoleInteractType Create([Nullable(2)] IDartPlayableRoleInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x00147E17 File Offset: 0x00146017
		public static IDartPlayableRoleInteractType CreateFromSetValue([Nullable(2)] IDartPlayableRoleInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x00147E2A File Offset: 0x0014602A
		public new IDartPlayableRoleInteractType_SetValue ToSetValue()
		{
			return new IDartPlayableRoleInteractType_SetValue
			{
				Type = this.Type,
				CompetitorId = this.CompetitorId
			};
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00147E49 File Offset: 0x00146049
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x00147E74 File Offset: 0x00146074
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

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x00147E82 File Offset: 0x00146082
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x00147EAD File Offset: 0x001460AD
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

		// Token: 0x040056FE RID: 22270
		[Nullable(2)]
		protected new IDartPlayableRoleInteractType FbInstance;

		// Token: 0x040056FF RID: 22271
		[Nullable(2)]
		protected new IDartPlayableRoleInteractType_SetValue PocoInterface;
	}
}
