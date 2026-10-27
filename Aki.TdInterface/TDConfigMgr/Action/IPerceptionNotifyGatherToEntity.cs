using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CCA RID: 7370
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerceptionNotifyGatherToEntity : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x06009E45 RID: 40517 RVA: 0x0016A150 File Offset: 0x00168350
		private IPerceptionNotifyGatherToEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerceptionNotifyGatherToEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerceptionNotifyGatherToEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerceptionNotifyGatherToEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x0016A188 File Offset: 0x00168388
		public static IPerceptionNotifyGatherToEntity Create([Nullable(2)] IPerceptionNotifyGatherToEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x0016A19B File Offset: 0x0016839B
		public static IPerceptionNotifyGatherToEntity CreateFromSetValue([Nullable(2)] IPerceptionNotifyGatherToEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerceptionNotifyGatherToEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x0016A1AE File Offset: 0x001683AE
		public new IPerceptionNotifyGatherToEntity_SetValue ToSetValue()
		{
			return new IPerceptionNotifyGatherToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x06009E49 RID: 40521 RVA: 0x0016A1CD File Offset: 0x001683CD
		// (set) Token: 0x06009E4A RID: 40522 RVA: 0x0016A1F8 File Offset: 0x001683F8
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

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x0016A206 File Offset: 0x00168406
		// (set) Token: 0x06009E4C RID: 40524 RVA: 0x0016A231 File Offset: 0x00168431
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

		// Token: 0x04005FAD RID: 24493
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToEntity FbInstance;

		// Token: 0x04005FAE RID: 24494
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToEntity_SetValue PocoInterface;
	}
}
