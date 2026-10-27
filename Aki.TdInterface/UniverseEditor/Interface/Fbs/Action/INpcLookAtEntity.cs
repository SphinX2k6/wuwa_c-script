using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCA RID: 27594
	public struct INpcLookAtEntity : IFlatbufferObject
	{
		// Token: 0x1700CD13 RID: 52499
		// (get) Token: 0x060307A2 RID: 198562 RVA: 0x00695360 File Offset: 0x00693560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060307A3 RID: 198563 RVA: 0x0069536D File Offset: 0x0069356D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060307A4 RID: 198564 RVA: 0x00695374 File Offset: 0x00693574
		public static INpcLookAtEntity GetRootAsINpcLookAtEntity(ByteBuffer _bb)
		{
			return INpcLookAtEntity.GetRootAsINpcLookAtEntity(_bb, default(INpcLookAtEntity));
		}

		// Token: 0x060307A5 RID: 198565 RVA: 0x00695390 File Offset: 0x00693590
		public static INpcLookAtEntity GetRootAsINpcLookAtEntity(ByteBuffer _bb, INpcLookAtEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060307A6 RID: 198566 RVA: 0x006953AD File Offset: 0x006935AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060307A7 RID: 198567 RVA: 0x006953BC File Offset: 0x006935BC
		public INpcLookAtEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD14 RID: 52500
		// (get) Token: 0x060307A8 RID: 198568 RVA: 0x006953CC File Offset: 0x006935CC
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

		// Token: 0x1700CD15 RID: 52501
		// (get) Token: 0x060307A9 RID: 198569 RVA: 0x00695408 File Offset: 0x00693608
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

		// Token: 0x060307AA RID: 198570 RVA: 0x00695444 File Offset: 0x00693644
		public static Offset<INpcLookAtEntity> CreateINpcLookAtEntity(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player, int EntityId = 0)
		{
			builder.StartTable(2);
			INpcLookAtEntity.AddEntityId(builder, EntityId);
			INpcLookAtEntity.AddType(builder, Type);
			return INpcLookAtEntity.EndINpcLookAtEntity(builder);
		}

		// Token: 0x060307AB RID: 198571 RVA: 0x00695461 File Offset: 0x00693661
		public static void StartINpcLookAtEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060307AC RID: 198572 RVA: 0x0069546A File Offset: 0x0069366A
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307AD RID: 198573 RVA: 0x00695475 File Offset: 0x00693675
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060307AE RID: 198574 RVA: 0x00695480 File Offset: 0x00693680
		public static Offset<INpcLookAtEntity> EndINpcLookAtEntity(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtEntity>(builder.EndTable());
		}

		// Token: 0x060307AF RID: 198575 RVA: 0x00695490 File Offset: 0x00693690
		public INpcLookAtEntityT UnPack()
		{
			INpcLookAtEntityT npcLookAtEntityT = new INpcLookAtEntityT();
			this.UnPackTo(npcLookAtEntityT);
			return npcLookAtEntityT;
		}

		// Token: 0x060307B0 RID: 198576 RVA: 0x006954AB File Offset: 0x006936AB
		public void UnPackTo(INpcLookAtEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x060307B1 RID: 198577 RVA: 0x006954C8 File Offset: 0x006936C8
		public static Offset<INpcLookAtEntity> Pack(FlatBufferBuilder builder, INpcLookAtEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtEntity>);
			}
			return INpcLookAtEntity.CreateINpcLookAtEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040114AA RID: 70826
		private Table __p;
	}
}
