using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EB RID: 29675
	public struct IPerformerAiMoveToEntity : IFlatbufferObject
	{
		// Token: 0x1700D9FD RID: 55805
		// (get) Token: 0x06033E96 RID: 212630 RVA: 0x006FFDFC File Offset: 0x006FDFFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E97 RID: 212631 RVA: 0x006FFE09 File Offset: 0x006FE009
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E98 RID: 212632 RVA: 0x006FFE10 File Offset: 0x006FE010
		public static IPerformerAiMoveToEntity GetRootAsIPerformerAiMoveToEntity(ByteBuffer _bb)
		{
			return IPerformerAiMoveToEntity.GetRootAsIPerformerAiMoveToEntity(_bb, default(IPerformerAiMoveToEntity));
		}

		// Token: 0x06033E99 RID: 212633 RVA: 0x006FFE2C File Offset: 0x006FE02C
		public static IPerformerAiMoveToEntity GetRootAsIPerformerAiMoveToEntity(ByteBuffer _bb, IPerformerAiMoveToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E9A RID: 212634 RVA: 0x006FFE49 File Offset: 0x006FE049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E9B RID: 212635 RVA: 0x006FFE58 File Offset: 0x006FE058
		public IPerformerAiMoveToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9FE RID: 55806
		// (get) Token: 0x06033E9C RID: 212636 RVA: 0x006FFE68 File Offset: 0x006FE068
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9FF RID: 55807
		// (get) Token: 0x06033E9D RID: 212637 RVA: 0x006FFEA4 File Offset: 0x006FE0A4
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

		// Token: 0x06033E9E RID: 212638 RVA: 0x006FFEE0 File Offset: 0x006FE0E0
		public static Offset<IPerformerAiMoveToEntity> CreateIPerformerAiMoveToEntity(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position, int EntityId = 0)
		{
			builder.StartTable(2);
			IPerformerAiMoveToEntity.AddEntityId(builder, EntityId);
			IPerformerAiMoveToEntity.AddType(builder, Type);
			return IPerformerAiMoveToEntity.EndIPerformerAiMoveToEntity(builder);
		}

		// Token: 0x06033E9F RID: 212639 RVA: 0x006FFEFD File Offset: 0x006FE0FD
		public static void StartIPerformerAiMoveToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033EA0 RID: 212640 RVA: 0x006FFF06 File Offset: 0x006FE106
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EA1 RID: 212641 RVA: 0x006FFF11 File Offset: 0x006FE111
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06033EA2 RID: 212642 RVA: 0x006FFF1C File Offset: 0x006FE11C
		public static Offset<IPerformerAiMoveToEntity> EndIPerformerAiMoveToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToEntity>(builder.EndTable());
		}

		// Token: 0x06033EA3 RID: 212643 RVA: 0x006FFF2C File Offset: 0x006FE12C
		public IPerformerAiMoveToEntityT UnPack()
		{
			IPerformerAiMoveToEntityT performerAiMoveToEntityT = new IPerformerAiMoveToEntityT();
			this.UnPackTo(performerAiMoveToEntityT);
			return performerAiMoveToEntityT;
		}

		// Token: 0x06033EA4 RID: 212644 RVA: 0x006FFF47 File Offset: 0x006FE147
		public void UnPackTo(IPerformerAiMoveToEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06033EA5 RID: 212645 RVA: 0x006FFF64 File Offset: 0x006FE164
		public static Offset<IPerformerAiMoveToEntity> Pack(FlatBufferBuilder builder, IPerformerAiMoveToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToEntity>);
			}
			return IPerformerAiMoveToEntity.CreateIPerformerAiMoveToEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04012531 RID: 75057
		private Table __p;
	}
}
