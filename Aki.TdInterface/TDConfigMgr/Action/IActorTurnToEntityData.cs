using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191B RID: 6427
	public class IActorTurnToEntityData : IActorTurnToData
	{
		// Token: 0x060086D5 RID: 34517 RVA: 0x00140A08 File Offset: 0x0013EC08
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

		// Token: 0x060086D6 RID: 34518 RVA: 0x00140A40 File Offset: 0x0013EC40
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

		// Token: 0x060086D7 RID: 34519 RVA: 0x00140A53 File Offset: 0x0013EC53
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

		// Token: 0x060086D8 RID: 34520 RVA: 0x00140A66 File Offset: 0x0013EC66
		public new IActorTurnToEntityData_SetValue ToSetValue()
		{
			return new IActorTurnToEntityData_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x060086D9 RID: 34521 RVA: 0x00140A85 File Offset: 0x0013EC85
		// (set) Token: 0x060086DA RID: 34522 RVA: 0x00140AB0 File Offset: 0x0013ECB0
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

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x060086DB RID: 34523 RVA: 0x00140ABE File Offset: 0x0013ECBE
		// (set) Token: 0x060086DC RID: 34524 RVA: 0x00140AE9 File Offset: 0x0013ECE9
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

		// Token: 0x0400556F RID: 21871
		[Nullable(2)]
		protected new IActorTurnToEntityData FbInstance;

		// Token: 0x04005570 RID: 21872
		[Nullable(2)]
		protected new IActorTurnToEntityData_SetValue PocoInterface;
	}
}
