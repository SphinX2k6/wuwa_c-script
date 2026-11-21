using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732E RID: 29486
	public struct INpcLookAtEntity : IFlatbufferObject
	{
		// Token: 0x1700D81F RID: 55327
		// (get) Token: 0x060336BE RID: 210622 RVA: 0x006EEC60 File Offset: 0x006ECE60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336BF RID: 210623 RVA: 0x006EEC6D File Offset: 0x006ECE6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336C0 RID: 210624 RVA: 0x006EEC74 File Offset: 0x006ECE74
		public static INpcLookAtEntity GetRootAsINpcLookAtEntity(ByteBuffer _bb)
		{
			return INpcLookAtEntity.GetRootAsINpcLookAtEntity(_bb, default(INpcLookAtEntity));
		}

		// Token: 0x060336C1 RID: 210625 RVA: 0x006EEC90 File Offset: 0x006ECE90
		public static INpcLookAtEntity GetRootAsINpcLookAtEntity(ByteBuffer _bb, INpcLookAtEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336C2 RID: 210626 RVA: 0x006EECAD File Offset: 0x006ECEAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336C3 RID: 210627 RVA: 0x006EECBC File Offset: 0x006ECEBC
		public INpcLookAtEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D820 RID: 55328
		// (get) Token: 0x060336C4 RID: 210628 RVA: 0x006EECCC File Offset: 0x006ECECC
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D821 RID: 55329
		// (get) Token: 0x060336C5 RID: 210629 RVA: 0x006EED08 File Offset: 0x006ECF08
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

		// Token: 0x060336C6 RID: 210630 RVA: 0x006EED44 File Offset: 0x006ECF44
		public static Offset<INpcLookAtEntity> CreateINpcLookAtEntity(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			INpcLookAtEntity.AddEntityId(builder, EntityId);
			INpcLookAtEntity.AddType(builder, Type);
			return INpcLookAtEntity.EndINpcLookAtEntity(builder);
		}

		// Token: 0x060336C7 RID: 210631 RVA: 0x006EED61 File Offset: 0x006ECF61
		public static void StartINpcLookAtEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060336C8 RID: 210632 RVA: 0x006EED6A File Offset: 0x006ECF6A
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060336C9 RID: 210633 RVA: 0x006EED75 File Offset: 0x006ECF75
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060336CA RID: 210634 RVA: 0x006EED80 File Offset: 0x006ECF80
		public static Offset<INpcLookAtEntity> EndINpcLookAtEntity(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtEntity>(builder.EndTable());
		}

		// Token: 0x060336CB RID: 210635 RVA: 0x006EED90 File Offset: 0x006ECF90
		public INpcLookAtEntityT UnPack()
		{
			INpcLookAtEntityT npcLookAtEntityT = new INpcLookAtEntityT();
			this.UnPackTo(npcLookAtEntityT);
			return npcLookAtEntityT;
		}

		// Token: 0x060336CC RID: 210636 RVA: 0x006EEDAB File Offset: 0x006ECFAB
		public void UnPackTo(INpcLookAtEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060336CD RID: 210637 RVA: 0x006EEDC8 File Offset: 0x006ECFC8
		public static Offset<INpcLookAtEntity> Pack(FlatBufferBuilder builder, INpcLookAtEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtEntity>);
			}
			return INpcLookAtEntity.CreateINpcLookAtEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040123F9 RID: 74745
		private Table __p;
	}
}
