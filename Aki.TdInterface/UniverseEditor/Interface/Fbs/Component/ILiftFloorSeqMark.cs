using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A86 RID: 23174
	public struct ILiftFloorSeqMark : IFlatbufferObject
	{
		// Token: 0x1700A8E2 RID: 43234
		// (get) Token: 0x06025FA9 RID: 155561 RVA: 0x00534DBE File Offset: 0x00532FBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FAA RID: 155562 RVA: 0x00534DCB File Offset: 0x00532FCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FAB RID: 155563 RVA: 0x00534DD4 File Offset: 0x00532FD4
		public static ILiftFloorSeqMark GetRootAsILiftFloorSeqMark(ByteBuffer _bb)
		{
			return ILiftFloorSeqMark.GetRootAsILiftFloorSeqMark(_bb, default(ILiftFloorSeqMark));
		}

		// Token: 0x06025FAC RID: 155564 RVA: 0x00534DF0 File Offset: 0x00532FF0
		public static ILiftFloorSeqMark GetRootAsILiftFloorSeqMark(ByteBuffer _bb, ILiftFloorSeqMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FAD RID: 155565 RVA: 0x00534E0D File Offset: 0x0053300D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FAE RID: 155566 RVA: 0x00534E1C File Offset: 0x0053301C
		public ILiftFloorSeqMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8E3 RID: 43235
		// (get) Token: 0x06025FAF RID: 155567 RVA: 0x00534E2C File Offset: 0x0053302C
		public int Floor
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A8E4 RID: 43236
		// (get) Token: 0x06025FB0 RID: 155568 RVA: 0x00534E68 File Offset: 0x00533068
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025FB1 RID: 155569 RVA: 0x00534E9F File Offset: 0x0053309F
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025FB2 RID: 155570 RVA: 0x00534EAE File Offset: 0x005330AE
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06025FB3 RID: 155571 RVA: 0x00534EBC File Offset: 0x005330BC
		public static Offset<ILiftFloorSeqMark> CreateILiftFloorSeqMark(FlatBufferBuilder builder, int Floor = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILiftFloorSeqMark.AddMark(builder, MarkOffset);
			ILiftFloorSeqMark.AddFloor(builder, Floor);
			return ILiftFloorSeqMark.EndILiftFloorSeqMark(builder);
		}

		// Token: 0x06025FB4 RID: 155572 RVA: 0x00534ED9 File Offset: 0x005330D9
		public static void StartILiftFloorSeqMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025FB5 RID: 155573 RVA: 0x00534EE2 File Offset: 0x005330E2
		public static void AddFloor(FlatBufferBuilder builder, int floor)
		{
			builder.AddInt(0, floor, 0);
		}

		// Token: 0x06025FB6 RID: 155574 RVA: 0x00534EED File Offset: 0x005330ED
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x06025FB7 RID: 155575 RVA: 0x00534EFD File Offset: 0x005330FD
		public static Offset<ILiftFloorSeqMark> EndILiftFloorSeqMark(FlatBufferBuilder builder)
		{
			return new Offset<ILiftFloorSeqMark>(builder.EndTable());
		}

		// Token: 0x06025FB8 RID: 155576 RVA: 0x00534F0C File Offset: 0x0053310C
		public ILiftFloorSeqMarkT UnPack()
		{
			ILiftFloorSeqMarkT liftFloorSeqMarkT = new ILiftFloorSeqMarkT();
			this.UnPackTo(liftFloorSeqMarkT);
			return liftFloorSeqMarkT;
		}

		// Token: 0x06025FB9 RID: 155577 RVA: 0x00534F27 File Offset: 0x00533127
		public void UnPackTo(ILiftFloorSeqMarkT _o)
		{
			_o.Floor = this.Floor;
			_o.Mark = this.Mark;
		}

		// Token: 0x06025FBA RID: 155578 RVA: 0x00534F44 File Offset: 0x00533144
		public static Offset<ILiftFloorSeqMark> Pack(FlatBufferBuilder builder, ILiftFloorSeqMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftFloorSeqMark>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return ILiftFloorSeqMark.CreateILiftFloorSeqMark(builder, _o.Floor, markOffset);
		}

		// Token: 0x0400F420 RID: 62496
		private Table __p;
	}
}
