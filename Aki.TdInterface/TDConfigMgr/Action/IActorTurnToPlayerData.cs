using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191D RID: 6429
	public class IActorTurnToPlayerData : IActorTurnToData
	{
		// Token: 0x060086DF RID: 34527 RVA: 0x00140B08 File Offset: 0x0013ED08
		private IActorTurnToPlayerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnToPlayerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnToPlayerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnToPlayerData_SetValue());
			}
			return result;
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x00140B40 File Offset: 0x0013ED40
		public static IActorTurnToPlayerData Create([Nullable(2)] IActorTurnToPlayerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnToPlayerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x00140B53 File Offset: 0x0013ED53
		public static IActorTurnToPlayerData CreateFromSetValue([Nullable(2)] IActorTurnToPlayerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnToPlayerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00140B66 File Offset: 0x0013ED66
		public new IActorTurnToPlayerData_SetValue ToSetValue()
		{
			return new IActorTurnToPlayerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x00140B79 File Offset: 0x0013ED79
		// (set) Token: 0x060086E4 RID: 34532 RVA: 0x00140BA4 File Offset: 0x0013EDA4
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

		// Token: 0x04005573 RID: 21875
		[Nullable(2)]
		protected new IActorTurnToPlayerData FbInstance;

		// Token: 0x04005574 RID: 21876
		[Nullable(2)]
		protected new IActorTurnToPlayerData_SetValue PocoInterface;
	}
}
