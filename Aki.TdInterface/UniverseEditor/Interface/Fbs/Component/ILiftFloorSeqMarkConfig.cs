using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005503 RID: 21763
	public struct ILiftFloorSeqMarkConfig : IFlatbufferObject
	{
		// Token: 0x1700A0AD RID: 41133
		// (get) Token: 0x06023F07 RID: 147207 RVA: 0x004F7ECD File Offset: 0x004F60CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023F08 RID: 147208 RVA: 0x004F7EDA File Offset: 0x004F60DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023F09 RID: 147209 RVA: 0x004F7EE4 File Offset: 0x004F60E4
		public static ILiftFloorSeqMarkConfig GetRootAsILiftFloorSeqMarkConfig(ByteBuffer _bb)
		{
			return ILiftFloorSeqMarkConfig.GetRootAsILiftFloorSeqMarkConfig(_bb, default(ILiftFloorSeqMarkConfig));
		}

		// Token: 0x06023F0A RID: 147210 RVA: 0x004F7F00 File Offset: 0x004F6100
		public static ILiftFloorSeqMarkConfig GetRootAsILiftFloorSeqMarkConfig(ByteBuffer _bb, ILiftFloorSeqMarkConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F0B RID: 147211 RVA: 0x004F7F1D File Offset: 0x004F611D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F0C RID: 147212 RVA: 0x004F7F2C File Offset: 0x004F612C
		public ILiftFloorSeqMarkConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0AE RID: 41134
		// (get) Token: 0x06023F0D RID: 147213 RVA: 0x004F7F3C File Offset: 0x004F613C
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

		// Token: 0x06023F0E RID: 147214 RVA: 0x004F7F73 File Offset: 0x004F6173
		public Span<byte> GetSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023F0F RID: 147215 RVA: 0x004F7F82 File Offset: 0x004F6182
		public byte[] GetSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06023F10 RID: 147216 RVA: 0x004F7F90 File Offset: 0x004F6190
		public ILiftFloorSeqMark? FloorMarks(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILiftFloorSeqMark?(default(ILiftFloorSeqMark).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0AF RID: 41135
		// (get) Token: 0x06023F11 RID: 147217 RVA: 0x004F7FF0 File Offset: 0x004F61F0
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

		// Token: 0x06023F12 RID: 147218 RVA: 0x004F801B File Offset: 0x004F621B
		public static Offset<ILiftFloorSeqMarkConfig> CreateILiftFloorSeqMarkConfig(FlatBufferBuilder builder, StringOffset SequencePathOffset = default(StringOffset), VectorOffset FloorMarksOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILiftFloorSeqMarkConfig.AddFloorMarks(builder, FloorMarksOffset);
			ILiftFloorSeqMarkConfig.AddSequencePath(builder, SequencePathOffset);
			return ILiftFloorSeqMarkConfig.EndILiftFloorSeqMarkConfig(builder);
		}

		// Token: 0x06023F13 RID: 147219 RVA: 0x004F8038 File Offset: 0x004F6238
		public static void StartILiftFloorSeqMarkConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023F14 RID: 147220 RVA: 0x004F8041 File Offset: 0x004F6241
		public static void AddSequencePath(FlatBufferBuilder builder, StringOffset sequencePathOffset)
		{
			builder.AddOffset(0, sequencePathOffset.Value, 0);
		}

		// Token: 0x06023F15 RID: 147221 RVA: 0x004F8051 File Offset: 0x004F6251
		public static void AddFloorMarks(FlatBufferBuilder builder, VectorOffset floorMarksOffset)
		{
			builder.AddOffset(1, floorMarksOffset.Value, 0);
		}

		// Token: 0x06023F16 RID: 147222 RVA: 0x004F8064 File Offset: 0x004F6264
		public static VectorOffset CreateFloorMarksVector(FlatBufferBuilder builder, Offset<ILiftFloorSeqMark>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023F17 RID: 147223 RVA: 0x004F80A4 File Offset: 0x004F62A4
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, Offset<ILiftFloorSeqMark>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILiftFloorSeqMark>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F18 RID: 147224 RVA: 0x004F80BE File Offset: 0x004F62BE
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILiftFloorSeqMark>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILiftFloorSeqMark>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023F19 RID: 147225 RVA: 0x004F80DC File Offset: 0x004F62DC
		public static VectorOffset CreateFloorMarksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILiftFloorSeqMark>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023F1A RID: 147226 RVA: 0x004F80F5 File Offset: 0x004F62F5
		public static void StartFloorMarksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023F1B RID: 147227 RVA: 0x004F8100 File Offset: 0x004F6300
		public static Offset<ILiftFloorSeqMarkConfig> EndILiftFloorSeqMarkConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiftFloorSeqMarkConfig>(builder.EndTable());
		}

		// Token: 0x06023F1C RID: 147228 RVA: 0x004F8110 File Offset: 0x004F6310
		public ILiftFloorSeqMarkConfigT UnPack()
		{
			ILiftFloorSeqMarkConfigT liftFloorSeqMarkConfigT = new ILiftFloorSeqMarkConfigT();
			this.UnPackTo(liftFloorSeqMarkConfigT);
			return liftFloorSeqMarkConfigT;
		}

		// Token: 0x06023F1D RID: 147229 RVA: 0x004F812C File Offset: 0x004F632C
		public void UnPackTo(ILiftFloorSeqMarkConfigT _o)
		{
			_o.SequencePath = this.SequencePath;
			_o.FloorMarks = new List<ILiftFloorSeqMarkT>();
			for (int i = 0; i < this.FloorMarksLength; i++)
			{
				_o.FloorMarks.Add((this.FloorMarks(i) != null) ? this.FloorMarks(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023F1E RID: 147230 RVA: 0x004F8198 File Offset: 0x004F6398
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

		// Token: 0x0400E7F2 RID: 59378
		private Table __p;
	}
}
