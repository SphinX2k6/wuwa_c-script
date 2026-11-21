using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D9 RID: 29657
	public struct IPerceptionNotifyGatherToEntity : IFlatbufferObject
	{
		// Token: 0x1700D9E8 RID: 55784
		// (get) Token: 0x06033E20 RID: 212512 RVA: 0x006FF215 File Offset: 0x006FD415
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E21 RID: 212513 RVA: 0x006FF222 File Offset: 0x006FD422
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E22 RID: 212514 RVA: 0x006FF22C File Offset: 0x006FD42C
		public static IPerceptionNotifyGatherToEntity GetRootAsIPerceptionNotifyGatherToEntity(ByteBuffer _bb)
		{
			return IPerceptionNotifyGatherToEntity.GetRootAsIPerceptionNotifyGatherToEntity(_bb, default(IPerceptionNotifyGatherToEntity));
		}

		// Token: 0x06033E23 RID: 212515 RVA: 0x006FF248 File Offset: 0x006FD448
		public static IPerceptionNotifyGatherToEntity GetRootAsIPerceptionNotifyGatherToEntity(ByteBuffer _bb, IPerceptionNotifyGatherToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E24 RID: 212516 RVA: 0x006FF265 File Offset: 0x006FD465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E25 RID: 212517 RVA: 0x006FF274 File Offset: 0x006FD474
		public IPerceptionNotifyGatherToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9E9 RID: 55785
		// (get) Token: 0x06033E26 RID: 212518 RVA: 0x006FF284 File Offset: 0x006FD484
		public EBattleStatePerceptionBehavior Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return (EBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9EA RID: 55786
		// (get) Token: 0x06033E27 RID: 212519 RVA: 0x006FF2C0 File Offset: 0x006FD4C0
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033E28 RID: 212520 RVA: 0x006FF2FC File Offset: 0x006FD4FC
		public static Offset<IPerceptionNotifyGatherToEntity> CreateIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer, int EntityId = 0)
		{
			builder.StartTable(2);
			IPerceptionNotifyGatherToEntity.AddEntityId(builder, EntityId);
			IPerceptionNotifyGatherToEntity.AddType(builder, Type);
			return IPerceptionNotifyGatherToEntity.EndIPerceptionNotifyGatherToEntity(builder);
		}

		// Token: 0x06033E29 RID: 212521 RVA: 0x006FF319 File Offset: 0x006FD519
		public static void StartIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033E2A RID: 212522 RVA: 0x006FF322 File Offset: 0x006FD522
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033E2B RID: 212523 RVA: 0x006FF32D File Offset: 0x006FD52D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06033E2C RID: 212524 RVA: 0x006FF338 File Offset: 0x006FD538
		public static Offset<IPerceptionNotifyGatherToEntity> EndIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPerceptionNotifyGatherToEntity>(builder.EndTable());
		}

		// Token: 0x06033E2D RID: 212525 RVA: 0x006FF348 File Offset: 0x006FD548
		public IPerceptionNotifyGatherToEntityT UnPack()
		{
			IPerceptionNotifyGatherToEntityT perceptionNotifyGatherToEntityT = new IPerceptionNotifyGatherToEntityT();
			this.UnPackTo(perceptionNotifyGatherToEntityT);
			return perceptionNotifyGatherToEntityT;
		}

		// Token: 0x06033E2E RID: 212526 RVA: 0x006FF363 File Offset: 0x006FD563
		public void UnPackTo(IPerceptionNotifyGatherToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06033E2F RID: 212527 RVA: 0x006FF380 File Offset: 0x006FD580
		public static Offset<IPerceptionNotifyGatherToEntity> Pack(FlatBufferBuilder builder, IPerceptionNotifyGatherToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerceptionNotifyGatherToEntity>);
			}
			return IPerceptionNotifyGatherToEntity.CreateIPerceptionNotifyGatherToEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0401251D RID: 75037
		private Table __p;
	}
}
