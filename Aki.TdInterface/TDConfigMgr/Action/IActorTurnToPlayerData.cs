using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200179C RID: 6044
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnToPlayerData : IActorTurnToData
	{
		// Token: 0x06007FEF RID: 32751 RVA: 0x001318A8 File Offset: 0x0012FAA8
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

		// Token: 0x06007FF0 RID: 32752 RVA: 0x001318E0 File Offset: 0x0012FAE0
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

		// Token: 0x06007FF1 RID: 32753 RVA: 0x001318F3 File Offset: 0x0012FAF3
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

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00131906 File Offset: 0x0012FB06
		public new IActorTurnToPlayerData_SetValue ToSetValue()
		{
			return new IActorTurnToPlayerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x06007FF3 RID: 32755 RVA: 0x00131919 File Offset: 0x0012FB19
		// (set) Token: 0x06007FF4 RID: 32756 RVA: 0x00131944 File Offset: 0x0012FB44
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

		// Token: 0x0400513D RID: 20797
		[Nullable(2)]
		protected new IActorTurnToPlayerData FbInstance;

		// Token: 0x0400513E RID: 20798
		[Nullable(2)]
		protected new IActorTurnToPlayerData_SetValue PocoInterface;
	}
}
