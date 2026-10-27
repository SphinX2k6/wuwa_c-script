using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005500 RID: 21760
	public struct ILiftFloorSeqMark : IFlatbufferObject
	{
		// Token: 0x1700A0A8 RID: 41128
		// (get) Token: 0x06023EEF RID: 147183 RVA: 0x004F7C9A File Offset: 0x004F5E9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EF0 RID: 147184 RVA: 0x004F7CA7 File Offset: 0x004F5EA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EF1 RID: 147185 RVA: 0x004F7CB0 File Offset: 0x004F5EB0
		public static ILiftFloorSeqMark GetRootAsILiftFloorSeqMark(ByteBuffer _bb)
		{
			return ILiftFloorSeqMark.GetRootAsILiftFloorSeqMark(_bb, default(ILiftFloorSeqMark));
		}

		// Token: 0x06023EF2 RID: 147186 RVA: 0x004F7CCC File Offset: 0x004F5ECC
		public static ILiftFloorSeqMark GetRootAsILiftFloorSeqMark(ByteBuffer _bb, ILiftFloorSeqMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023EF3 RID: 147187 RVA: 0x004F7CE9 File Offset: 0x004F5EE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023EF4 RID: 147188 RVA: 0x004F7CF8 File Offset: 0x004F5EF8
		public ILiftFloorSeqMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0A9 RID: 41129
		// (get) Token: 0x06023EF5 RID: 147189 RVA: 0x004F7D08 File Offset: 0x004F5F08
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

		// Token: 0x1700A0AA RID: 41130
		// (get) Token: 0x06023EF6 RID: 147190 RVA: 0x004F7D44 File Offset: 0x004F5F44
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

		// Token: 0x06023EF7 RID: 147191 RVA: 0x004F7D7B File Offset: 0x004F5F7B
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023EF8 RID: 147192 RVA: 0x004F7D8A File Offset: 0x004F5F8A
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023EF9 RID: 147193 RVA: 0x004F7D98 File Offset: 0x004F5F98
		public static Offset<ILiftFloorSeqMark> CreateILiftFloorSeqMark(FlatBufferBuilder builder, int Floor = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILiftFloorSeqMark.AddMark(builder, MarkOffset);
			ILiftFloorSeqMark.AddFloor(builder, Floor);
			return ILiftFloorSeqMark.EndILiftFloorSeqMark(builder);
		}

		// Token: 0x06023EFA RID: 147194 RVA: 0x004F7DB5 File Offset: 0x004F5FB5
		public static void StartILiftFloorSeqMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023EFB RID: 147195 RVA: 0x004F7DBE File Offset: 0x004F5FBE
		public static void AddFloor(FlatBufferBuilder builder, int floor)
		{
			builder.AddInt(0, floor, 0);
		}

		// Token: 0x06023EFC RID: 147196 RVA: 0x004F7DC9 File Offset: 0x004F5FC9
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x06023EFD RID: 147197 RVA: 0x004F7DD9 File Offset: 0x004F5FD9
		public static Offset<ILiftFloorSeqMark> EndILiftFloorSeqMark(FlatBufferBuilder builder)
		{
			return new Offset<ILiftFloorSeqMark>(builder.EndTable());
		}

		// Token: 0x06023EFE RID: 147198 RVA: 0x004F7DE8 File Offset: 0x004F5FE8
		public ILiftFloorSeqMarkT UnPack()
		{
			ILiftFloorSeqMarkT liftFloorSeqMarkT = new ILiftFloorSeqMarkT();
			this.UnPackTo(liftFloorSeqMarkT);
			return liftFloorSeqMarkT;
		}

		// Token: 0x06023EFF RID: 147199 RVA: 0x004F7E03 File Offset: 0x004F6003
		public void UnPackTo(ILiftFloorSeqMarkT _o)
		{
			_o.Floor = this.Floor;
			_o.Mark = this.Mark;
		}

		// Token: 0x06023F00 RID: 147200 RVA: 0x004F7E20 File Offset: 0x004F6020
		public static Offset<ILiftFloorSeqMark> Pack(FlatBufferBuilder builder, ILiftFloorSeqMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftFloorSeqMark>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return ILiftFloorSeqMark.CreateILiftFloorSeqMark(builder, _o.Floor, markOffset);
		}

		// Token: 0x0400E7EF RID: 59375
		private Table __p;
	}
}
