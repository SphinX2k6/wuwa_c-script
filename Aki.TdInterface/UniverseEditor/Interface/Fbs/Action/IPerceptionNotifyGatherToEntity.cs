using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C72 RID: 27762
	public struct IPerceptionNotifyGatherToEntity : IFlatbufferObject
	{
		// Token: 0x1700CECD RID: 52941
		// (get) Token: 0x06030EC5 RID: 200389 RVA: 0x006A4D15 File Offset: 0x006A2F15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EC6 RID: 200390 RVA: 0x006A4D22 File Offset: 0x006A2F22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EC7 RID: 200391 RVA: 0x006A4D2C File Offset: 0x006A2F2C
		public static IPerceptionNotifyGatherToEntity GetRootAsIPerceptionNotifyGatherToEntity(ByteBuffer _bb)
		{
			return IPerceptionNotifyGatherToEntity.GetRootAsIPerceptionNotifyGatherToEntity(_bb, default(IPerceptionNotifyGatherToEntity));
		}

		// Token: 0x06030EC8 RID: 200392 RVA: 0x006A4D48 File Offset: 0x006A2F48
		public static IPerceptionNotifyGatherToEntity GetRootAsIPerceptionNotifyGatherToEntity(ByteBuffer _bb, IPerceptionNotifyGatherToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030EC9 RID: 200393 RVA: 0x006A4D65 File Offset: 0x006A2F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030ECA RID: 200394 RVA: 0x006A4D74 File Offset: 0x006A2F74
		public IPerceptionNotifyGatherToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CECE RID: 52942
		// (get) Token: 0x06030ECB RID: 200395 RVA: 0x006A4D84 File Offset: 0x006A2F84
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

		// Token: 0x1700CECF RID: 52943
		// (get) Token: 0x06030ECC RID: 200396 RVA: 0x006A4DC0 File Offset: 0x006A2FC0
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

		// Token: 0x06030ECD RID: 200397 RVA: 0x006A4DFC File Offset: 0x006A2FFC
		public static Offset<IPerceptionNotifyGatherToEntity> CreateIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer, int EntityId = 0)
		{
			builder.StartTable(2);
			IPerceptionNotifyGatherToEntity.AddEntityId(builder, EntityId);
			IPerceptionNotifyGatherToEntity.AddType(builder, Type);
			return IPerceptionNotifyGatherToEntity.EndIPerceptionNotifyGatherToEntity(builder);
		}

		// Token: 0x06030ECE RID: 200398 RVA: 0x006A4E19 File Offset: 0x006A3019
		public static void StartIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030ECF RID: 200399 RVA: 0x006A4E22 File Offset: 0x006A3022
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030ED0 RID: 200400 RVA: 0x006A4E2D File Offset: 0x006A302D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06030ED1 RID: 200401 RVA: 0x006A4E38 File Offset: 0x006A3038
		public static Offset<IPerceptionNotifyGatherToEntity> EndIPerceptionNotifyGatherToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPerceptionNotifyGatherToEntity>(builder.EndTable());
		}

		// Token: 0x06030ED2 RID: 200402 RVA: 0x006A4E48 File Offset: 0x006A3048
		public IPerceptionNotifyGatherToEntityT UnPack()
		{
			IPerceptionNotifyGatherToEntityT perceptionNotifyGatherToEntityT = new IPerceptionNotifyGatherToEntityT();
			this.UnPackTo(perceptionNotifyGatherToEntityT);
			return perceptionNotifyGatherToEntityT;
		}

		// Token: 0x06030ED3 RID: 200403 RVA: 0x006A4E63 File Offset: 0x006A3063
		public void UnPackTo(IPerceptionNotifyGatherToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06030ED4 RID: 200404 RVA: 0x006A4E80 File Offset: 0x006A3080
		public static Offset<IPerceptionNotifyGatherToEntity> Pack(FlatBufferBuilder builder, IPerceptionNotifyGatherToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerceptionNotifyGatherToEntity>);
			}
			return IPerceptionNotifyGatherToEntity.CreateIPerceptionNotifyGatherToEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040115C5 RID: 71109
		private Table __p;
	}
}
