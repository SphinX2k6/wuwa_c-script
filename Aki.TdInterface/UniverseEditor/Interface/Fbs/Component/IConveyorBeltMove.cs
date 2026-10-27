using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005033 RID: 20531
	public struct IConveyorBeltMove : IFlatbufferObject
	{
		// Token: 0x17009500 RID: 38144
		// (get) Token: 0x06020E4D RID: 134733 RVA: 0x00492F1C File Offset: 0x0049111C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E4E RID: 134734 RVA: 0x00492F29 File Offset: 0x00491129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E4F RID: 134735 RVA: 0x00492F30 File Offset: 0x00491130
		public static IConveyorBeltMove GetRootAsIConveyorBeltMove(ByteBuffer _bb)
		{
			return IConveyorBeltMove.GetRootAsIConveyorBeltMove(_bb, default(IConveyorBeltMove));
		}

		// Token: 0x06020E50 RID: 134736 RVA: 0x00492F4C File Offset: 0x0049114C
		public static IConveyorBeltMove GetRootAsIConveyorBeltMove(ByteBuffer _bb, IConveyorBeltMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E51 RID: 134737 RVA: 0x00492F69 File Offset: 0x00491169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E52 RID: 134738 RVA: 0x00492F78 File Offset: 0x00491178
		public IConveyorBeltMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009501 RID: 38145
		// (get) Token: 0x06020E53 RID: 134739 RVA: 0x00492F88 File Offset: 0x00491188
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

		// Token: 0x06020E54 RID: 134740 RVA: 0x00492FC4 File Offset: 0x004911C4
		public static Offset<IConveyorBeltMove> CreateIConveyorBeltMove(FlatBufferBuilder builder, EConveyorBeltMoveType Type = EConveyorBeltMoveType.FixSpeed)
		{
			builder.StartTable(1);
			IConveyorBeltMove.AddType(builder, Type);
			return IConveyorBeltMove.EndIConveyorBeltMove(builder);
		}

		// Token: 0x06020E55 RID: 134741 RVA: 0x00492FDA File Offset: 0x004911DA
		public static void StartIConveyorBeltMove(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020E56 RID: 134742 RVA: 0x00492FE3 File Offset: 0x004911E3
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E57 RID: 134743 RVA: 0x00492FEE File Offset: 0x004911EE
		public static Offset<IConveyorBeltMove> EndIConveyorBeltMove(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltMove>(builder.EndTable());
		}

		// Token: 0x06020E58 RID: 134744 RVA: 0x00492FFC File Offset: 0x004911FC
		public IConveyorBeltMoveT UnPack()
		{
			IConveyorBeltMoveT conveyorBeltMoveT = new IConveyorBeltMoveT();
			this.UnPackTo(conveyorBeltMoveT);
			return conveyorBeltMoveT;
		}

		// Token: 0x06020E59 RID: 134745 RVA: 0x00493017 File Offset: 0x00491217
		public void UnPackTo(IConveyorBeltMoveT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020E5A RID: 134746 RVA: 0x00493028 File Offset: 0x00491228
		public static Offset<IConveyorBeltMove> Pack(FlatBufferBuilder builder, IConveyorBeltMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltMove>);
			}
			return IConveyorBeltMove.CreateIConveyorBeltMove(builder, _o.Type);
		}

		// Token: 0x0400E023 RID: 57379
		private Table __p;
	}
}
