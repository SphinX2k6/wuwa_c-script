using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005592 RID: 21906
	public struct IConveyorBeltMove : IFlatbufferObject
	{
		// Token: 0x17009CE1 RID: 40161
		// (get) Token: 0x06022D6D RID: 142701 RVA: 0x004CC96C File Offset: 0x004CAB6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D6E RID: 142702 RVA: 0x004CC979 File Offset: 0x004CAB79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D6F RID: 142703 RVA: 0x004CC980 File Offset: 0x004CAB80
		public static IConveyorBeltMove GetRootAsIConveyorBeltMove(ByteBuffer _bb)
		{
			return IConveyorBeltMove.GetRootAsIConveyorBeltMove(_bb, default(IConveyorBeltMove));
		}

		// Token: 0x06022D70 RID: 142704 RVA: 0x004CC99C File Offset: 0x004CAB9C
		public static IConveyorBeltMove GetRootAsIConveyorBeltMove(ByteBuffer _bb, IConveyorBeltMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D71 RID: 142705 RVA: 0x004CC9B9 File Offset: 0x004CABB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D72 RID: 142706 RVA: 0x004CC9C8 File Offset: 0x004CABC8
		public IConveyorBeltMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CE2 RID: 40162
		// (get) Token: 0x06022D73 RID: 142707 RVA: 0x004CC9D8 File Offset: 0x004CABD8
		public EConveyorBeltMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltMoveType.FixSpeed;
				}
				return (EConveyorBeltMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022D74 RID: 142708 RVA: 0x004CCA14 File Offset: 0x004CAC14
		public static Offset<IConveyorBeltMove> CreateIConveyorBeltMove(FlatBufferBuilder builder, EConveyorBeltMoveType Type = EConveyorBeltMoveType.FixSpeed)
		{
			builder.StartTable(1);
			IConveyorBeltMove.AddType(builder, Type);
			return IConveyorBeltMove.EndIConveyorBeltMove(builder);
		}

		// Token: 0x06022D75 RID: 142709 RVA: 0x004CCA2A File Offset: 0x004CAC2A
		public static void StartIConveyorBeltMove(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022D76 RID: 142710 RVA: 0x004CCA33 File Offset: 0x004CAC33
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022D77 RID: 142711 RVA: 0x004CCA3E File Offset: 0x004CAC3E
		public static Offset<IConveyorBeltMove> EndIConveyorBeltMove(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltMove>(builder.EndTable());
		}

		// Token: 0x06022D78 RID: 142712 RVA: 0x004CCA4C File Offset: 0x004CAC4C
		public IConveyorBeltMoveT UnPack()
		{
			IConveyorBeltMoveT conveyorBeltMoveT = new IConveyorBeltMoveT();
			this.UnPackTo(conveyorBeltMoveT);
			return conveyorBeltMoveT;
		}

		// Token: 0x06022D79 RID: 142713 RVA: 0x004CCA67 File Offset: 0x004CAC67
		public void UnPackTo(IConveyorBeltMoveT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022D7A RID: 142714 RVA: 0x004CCA78 File Offset: 0x004CAC78
		public static Offset<IConveyorBeltMove> Pack(FlatBufferBuilder builder, IConveyorBeltMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltMove>);
			}
			return IConveyorBeltMove.CreateIConveyorBeltMove(builder, _o.Type);
		}

		// Token: 0x0400EC19 RID: 60441
		private Table __p;
	}
}
