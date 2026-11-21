using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A89 RID: 23177
	public struct ILiftFloorSeqMarkConfig : IFlatbufferObject
	{
		// Token: 0x1700A8E7 RID: 43239
		// (get) Token: 0x06025FC1 RID: 155585 RVA: 0x00534FF1 File Offset: 0x005331F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025FC2 RID: 155586 RVA: 0x00534FFE File Offset: 0x005331FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025FC3 RID: 155587 RVA: 0x00535008 File Offset: 0x00533208
		public static ILiftFloorSeqMarkConfig GetRootAsILiftFloorSeqMarkConfig(ByteBuffer _bb)
		{
			return ILiftFloorSeqMarkConfig.GetRootAsILiftFloorSeqMarkConfig(_bb, default(ILiftFloorSeqMarkConfig));
		}

		// Token: 0x06025FC4 RID: 155588 RVA: 0x00535024 File Offset: 0x00533224
		public static ILiftFloorSeqMarkConfig GetRootAsILiftFloorSeqMarkConfig(ByteBuffer _bb, ILiftFloorSeqMarkConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025FC5 RID: 155589 RVA: 0x00535041 File Offset: 0x00533241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025FC6 RID: 155590 RVA: 0x00535050 File Offset: 0x00533250
		public ILiftFloorSeqMarkConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8E8 RID: 43240
		// (get) Token: 0x06025FC7 RID: 155591 RVA: 0x00535060 File Offset: 0x00533260
		public string SequencePath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025FC8 RID: 155592 RVA: 0x00535097 File Offset: 0x00533297
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025FC9 RID: 155593 RVA: 0x005350A6 File Offset: 0x005332A6
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06025FCA RID: 155594 RVA: 0x005350B4 File Offset: 0x005332B4
		public ILiftFloorSeqMark? FloorMarks(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILiftFloorSeqMark?(default(ILiftFloorSeqMark).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A8E9 RID: 43241
		// (get) Token: 0x06025FCB RID: 155595 RVA: 0x00535114 File Offset: 0x00533314
		public int FloorMarksLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06025FCC RID: 155596 RVA: 0x0053513F File Offset: 0x0053333F
		public static Offset<ILiftFloorSeqMarkConfig> CreateILiftFloorSeqMarkConfig(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset), VectorOffset FloorMarksOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILiftFloorSeqMarkConfig.AddFloorMarks(builder, FloorMarksOffset);
			ILiftFloorSeqMarkConfig.AddSequencePath(builder, SequencePathOffset);
			return ILiftFloorSeqMarkConfig.EndILiftFloorSeqMarkConfig(builder);
		}

		// Token: 0x06025FCD RID: 155597 RVA: 0x0053515C File Offset: 0x0053335C
		public static void StartILiftFloorSeqMarkConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025FCE RID: 155598 RVA: 0x00535165 File Offset: 0x00533365
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x06025FCF RID: 155599 RVA: 0x00535175 File Offset: 0x00533375
		public static void AddFloorMarks(FlatBufferBuilder builder, VectorOffset floorMarksOffset)
		{
			builder.AddOffset(1, floorMarksOffset.Value, 0);
		}

		// Token: 0x06025FD0 RID: 155600 RVA: 0x00535188 File Offset: 0x00533388
		public static VectorOffset CreateFloorMarksVector(FlatBufferBuilder builder, Offset<ILiftFloorSeqMark>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025FD1 RID: 155601 RVA: 0x005351C8 File Offset: 0x005333C8
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, Offset<ILiftFloorSeqMark>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILiftFloorSeqMark>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025FD2 RID: 155602 RVA: 0x005351E2 File Offset: 0x005333E2
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILiftFloorSeqMark>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILiftFloorSeqMark>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025FD3 RID: 155603 RVA: 0x00535200 File Offset: 0x00533400
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILiftFloorSeqMark>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025FD4 RID: 155604 RVA: 0x00535219 File Offset: 0x00533419
		public static void StartFloorMarksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025FD5 RID: 155605 RVA: 0x00535224 File Offset: 0x00533424
		public static Offset<ILiftFloorSeqMarkConfig> EndILiftFloorSeqMarkConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiftFloorSeqMarkConfig>(builder.EndTable());
		}

		// Token: 0x06025FD6 RID: 155606 RVA: 0x00535234 File Offset: 0x00533434
		public ILiftFloorSeqMarkConfigT UnPack()
		{
			ILiftFloorSeqMarkConfigT liftFloorSeqMarkConfigT = new ILiftFloorSeqMarkConfigT();
			this.UnPackTo(liftFloorSeqMarkConfigT);
			return liftFloorSeqMarkConfigT;
		}

		// Token: 0x06025FD7 RID: 155607 RVA: 0x00535250 File Offset: 0x00533450
		public void UnPackTo(ILiftFloorSeqMarkConfigT _o)
		{
			_o.SequencePath = this.SequencePath;
			_o.FloorMarks = new List<ILiftFloorSeqMarkT>();
			for (int i = 0; i < this.FloorMarksLength; i++)
			{
				_o.FloorMarks.Add((this.FloorMarks(i) != null) ? this.FloorMarks(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025FD8 RID: 155608 RVA: 0x005352BC File Offset: 0x005334BC
		public static Offset<ILiftFloorSeqMarkConfig> Pack(FlatBufferBuilder builder, ILiftFloorSeqMarkConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftFloorSeqMarkConfig>);
			}
			StringOffset sequencePathOffset = (_o.SequencePath == null) ? default(StringOffset) : builder.CreateString(_o.SequencePath);
			VectorOffset floorMarksOffset = default(VectorOffset);
			if (_o.FloorMarks != null)
			{
				Offset<ILiftFloorSeqMark>[] array = new Offset<ILiftFloorSeqMark>[_o.FloorMarks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILiftFloorSeqMark.Pack(builder, _o.FloorMarks[i]);
				}
				floorMarksOffset = ILiftFloorSeqMarkConfig.CreateFloorMarksVector(builder, array);
			}
			return ILiftFloorSeqMarkConfig.CreateILiftFloorSeqMarkConfig(builder, sequencePathOffset, floorMarksOffset);
		}

		// Token: 0x0400F423 RID: 62499
		private Table __p;
	}
}
