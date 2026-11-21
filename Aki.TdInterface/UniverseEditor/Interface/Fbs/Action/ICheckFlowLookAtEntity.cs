using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D2 RID: 27090
	public struct ICheckFlowLookAtEntity : IFlatbufferObject
	{
		// Token: 0x1700C759 RID: 51033
		// (get) Token: 0x0602E7A1 RID: 190369 RVA: 0x00657739 File Offset: 0x00655939
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7A2 RID: 190370 RVA: 0x00657746 File Offset: 0x00655946
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7A3 RID: 190371 RVA: 0x00657750 File Offset: 0x00655950
		public static ICheckFlowLookAtEntity GetRootAsICheckFlowLookAtEntity(ByteBuffer _bb)
		{
			return ICheckFlowLookAtEntity.GetRootAsICheckFlowLookAtEntity(_bb, default(ICheckFlowLookAtEntity));
		}

		// Token: 0x0602E7A4 RID: 190372 RVA: 0x0065776C File Offset: 0x0065596C
		public static ICheckFlowLookAtEntity GetRootAsICheckFlowLookAtEntity(ByteBuffer _bb, ICheckFlowLookAtEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7A5 RID: 190373 RVA: 0x00657789 File Offset: 0x00655989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7A6 RID: 190374 RVA: 0x00657798 File Offset: 0x00655998
		public ICheckFlowLookAtEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C75A RID: 51034
		// (get) Token: 0x0602E7A7 RID: 190375 RVA: 0x006577A8 File Offset: 0x006559A8
		public ECheckFlowLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return (ECheckFlowLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C75B RID: 51035
		// (get) Token: 0x0602E7A8 RID: 190376 RVA: 0x006577E4 File Offset: 0x006559E4
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

		// Token: 0x0602E7A9 RID: 190377 RVA: 0x00657820 File Offset: 0x00655A20
		public static Offset<ICheckFlowLookAtEntity> CreateICheckFlowLookAtEntity(FlatBufferBuilder builder, ECheckFlowLookAtTargetType Type = ECheckFlowLookAtTargetType.Entity, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckFlowLookAtEntity.AddEntityId(builder, EntityId);
			ICheckFlowLookAtEntity.AddType(builder, Type);
			return ICheckFlowLookAtEntity.EndICheckFlowLookAtEntity(builder);
		}

		// Token: 0x0602E7AA RID: 190378 RVA: 0x0065783D File Offset: 0x00655A3D
		public static void StartICheckFlowLookAtEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E7AB RID: 190379 RVA: 0x00657846 File Offset: 0x00655A46
		public static void AddType(FlatBufferBuilder builder, ECheckFlowLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E7AC RID: 190380 RVA: 0x00657851 File Offset: 0x00655A51
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E7AD RID: 190381 RVA: 0x0065785C File Offset: 0x00655A5C
		public static Offset<ICheckFlowLookAtEntity> EndICheckFlowLookAtEntity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtEntity>(builder.EndTable());
		}

		// Token: 0x0602E7AE RID: 190382 RVA: 0x0065786C File Offset: 0x00655A6C
		public ICheckFlowLookAtEntityT UnPack()
		{
			ICheckFlowLookAtEntityT checkFlowLookAtEntityT = new ICheckFlowLookAtEntityT();
			this.UnPackTo(checkFlowLookAtEntityT);
			return checkFlowLookAtEntityT;
		}

		// Token: 0x0602E7AF RID: 190383 RVA: 0x00657887 File Offset: 0x00655A87
		public void UnPackTo(ICheckFlowLookAtEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602E7B0 RID: 190384 RVA: 0x006578A4 File Offset: 0x00655AA4
		public static Offset<ICheckFlowLookAtEntity> Pack(FlatBufferBuilder builder, ICheckFlowLookAtEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtEntity>);
			}
			return ICheckFlowLookAtEntity.CreateICheckFlowLookAtEntity(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04011744 RID: 71492
		private Table __p;
	}
}
