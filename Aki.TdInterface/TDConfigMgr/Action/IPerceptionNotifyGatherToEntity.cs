using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED1 RID: 7889
	public class IPerceptionNotifyGatherToEntity : IBattleStatePerceptionBehaviorType
	{
		// Token: 0x0600A7F3 RID: 42995 RVA: 0x0017DDB0 File Offset: 0x0017BFB0
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

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x0017DDE8 File Offset: 0x0017BFE8
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

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x0017DDFB File Offset: 0x0017BFFB
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

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x0017DE0E File Offset: 0x0017C00E
		public new IPerceptionNotifyGatherToEntity_SetValue ToSetValue()
		{
			return new IPerceptionNotifyGatherToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x0017DE2D File Offset: 0x0017C02D
		// (set) Token: 0x0600A7F8 RID: 43000 RVA: 0x0017DE58 File Offset: 0x0017C058
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

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x0017DE66 File Offset: 0x0017C066
		// (set) Token: 0x0600A7FA RID: 43002 RVA: 0x0017DE91 File Offset: 0x0017C091
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

		// Token: 0x04006509 RID: 25865
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToEntity FbInstance;

		// Token: 0x0400650A RID: 25866
		[Nullable(2)]
		protected new IPerceptionNotifyGatherToEntity_SetValue PocoInterface;
	}
}
