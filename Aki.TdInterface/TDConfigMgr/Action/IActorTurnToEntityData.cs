using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200179A RID: 6042
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnToEntityData : IActorTurnToData
	{
		// Token: 0x06007FE5 RID: 32741 RVA: 0x001317A8 File Offset: 0x0012F9A8
		private IActorTurnToEntityData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToEntityData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToEntityData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToEntityData_SetValue());
			}
			return result;
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x001317E0 File Offset: 0x0012F9E0
		public static IActorTurnToEntityData Create([Nullable(2)] IActorTurnToEntityData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToEntityData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x001317F3 File Offset: 0x0012F9F3
		public static IActorTurnToEntityData CreateFromSetValue([Nullable(2)] IActorTurnToEntityData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToEntityData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00131806 File Offset: 0x0012FA06
		public new IActorTurnToEntityData_SetValue ToSetValue()
		{
			return new IActorTurnToEntityData_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00131825 File Offset: 0x0012FA25
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x00131850 File Offset: 0x0012FA50
		public override EActorTurnToMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorTurnToMode.Talker;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x0013185E File Offset: 0x0012FA5E
		// (set) Token: 0x06007FEC RID: 32748 RVA: 0x00131889 File Offset: 0x0012FA89
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04005139 RID: 20793
		[Nullable(2)]
		protected new IActorTurnToEntityData FbInstance;

		// Token: 0x0400513A RID: 20794
		[Nullable(2)]
		protected new IActorTurnToEntityData_SetValue PocoInterface;
	}
}
