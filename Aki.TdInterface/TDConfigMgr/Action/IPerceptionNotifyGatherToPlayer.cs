using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CCC RID: 7372
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerceptionNotifyGatherToPlayer : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x06009E4F RID: 40527 RVA: 0x0016A250 File Offset: 0x00168450
		private IPerceptionNotifyGatherToPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerceptionNotifyGatherToPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerceptionNotifyGatherToPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerceptionNotifyGatherToPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x0016A288 File Offset: 0x00168488
		public static IPerceptionNotifyGatherToPlayer Create([Nullable(2)] IPerceptionNotifyGatherToPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x0016A29B File Offset: 0x0016849B
		public static IPerceptionNotifyGatherToPlayer CreateFromSetValue([Nullable(2)] IPerceptionNotifyGatherToPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x0016A2AE File Offset: 0x001684AE
		public new IPerceptionNotifyGatherToPlayer_SetValue ToSetValue()
		{
			return new IPerceptionNotifyGatherToPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x0016A2C1 File Offset: 0x001684C1
		// (set) Token: 0x06009E54 RID: 40532 RVA: 0x0016A2EC File Offset: 0x001684EC
		public override EBattleStatePerceptionBehavior Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005FB1 RID: 24497
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToPlayer FbInstance;

		// Token: 0x04005FB2 RID: 24498
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToPlayer_SetValue PocoInterface;
	}
}
