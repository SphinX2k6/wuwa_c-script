using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064BB RID: 25787
	public struct TCsvReignsData : IFlatbufferObject
	{
		// Token: 0x1700BE33 RID: 48691
		// (get) Token: 0x0602BD76 RID: 179574 RVA: 0x005F6558 File Offset: 0x005F4758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD77 RID: 179575 RVA: 0x005F6565 File Offset: 0x005F4765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD78 RID: 179576 RVA: 0x005F656C File Offset: 0x005F476C
		public static TCsvReignsData GetRootAsTCsvReignsData(ByteBuffer _bb)
		{
			return TCsvReignsData.GetRootAsTCsvReignsData(_bb, default(TCsvReignsData));
		}

		// Token: 0x0602BD79 RID: 179577 RVA: 0x005F6588 File Offset: 0x005F4788
		public static TCsvReignsData GetRootAsTCsvReignsData(ByteBuffer _bb, TCsvReignsData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD7A RID: 179578 RVA: 0x005F65A5 File Offset: 0x005F47A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD7B RID: 179579 RVA: 0x005F65B4 File Offset: 0x005F47B4
		public TCsvReignsData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE34 RID: 48692
		// (get) Token: 0x0602BD7C RID: 179580 RVA: 0x005F65C4 File Offset: 0x005F47C4
		public int Id
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

		// Token: 0x0602BD7D RID: 179581 RVA: 0x005F6600 File Offset: 0x005F4800
		public IReignsPropertyConfig? BaseProperty(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IReignsPropertyConfig?(default(IReignsPropertyConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BE35 RID: 48693
		// (get) Token: 0x0602BD7E RID: 179582 RVA: 0x005F6660 File Offset: 0x005F4860
		public int BasePropertyLength
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

		// Token: 0x0602BD7F RID: 179583 RVA: 0x005F668C File Offset: 0x005F488C
		public IReignsEnding? EndingList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IReignsEnding?(default(IReignsEnding).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BE36 RID: 48694
		// (get) Token: 0x0602BD80 RID: 179584 RVA: 0x005F66EC File Offset: 0x005F48EC
		public int EndingListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602BD81 RID: 179585 RVA: 0x005F6717 File Offset: 0x005F4917
		public static Offset<TCsvReignsData> CreateTCsvReignsData(FlatBufferBuilder builder, int Id = 0, VectorOffset BasePropertyOffset = default(VectorOffset), VectorOffset EndingListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			TCsvReignsData.AddEndingList(builder, EndingListOffset);
			TCsvReignsData.AddBaseProperty(builder, BasePropertyOffset);
			TCsvReignsData.AddId(builder, Id);
			return TCsvReignsData.EndTCsvReignsData(builder);
		}

		// Token: 0x0602BD82 RID: 179586 RVA: 0x005F673B File Offset: 0x005F493B
		public static void StartTCsvReignsData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BD83 RID: 179587 RVA: 0x005F6744 File Offset: 0x005F4944
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602BD84 RID: 179588 RVA: 0x005F674F File Offset: 0x005F494F
		public static void AddBaseProperty(FlatBufferBuilder builder, VectorOffset basePropertyOffset)
		{
			builder.AddOffset(1, basePropertyOffset.Value, 0);
		}

		// Token: 0x0602BD85 RID: 179589 RVA: 0x005F6760 File Offset: 0x005F4960
		public static VectorOffset CreateBasePropertyVector(FlatBufferBuilder builder, Offset<IReignsPropertyConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BD86 RID: 179590 RVA: 0x005F67A0 File Offset: 0x005F49A0
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, Offset<IReignsPropertyConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReignsPropertyConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD87 RID: 179591 RVA: 0x005F67BA File Offset: 0x005F49BA
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReignsPropertyConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReignsPropertyConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD88 RID: 179592 RVA: 0x005F67D8 File Offset: 0x005F49D8
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReignsPropertyConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BD89 RID: 179593 RVA: 0x005F67F1 File Offset: 0x005F49F1
		public static void StartBasePropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BD8A RID: 179594 RVA: 0x005F67FC File Offset: 0x005F49FC
		public static void AddEndingList(FlatBufferBuilder builder, VectorOffset endingListOffset)
		{
			builder.AddOffset(2, endingListOffset.Value, 0);
		}

		// Token: 0x0602BD8B RID: 179595 RVA: 0x005F680C File Offset: 0x005F4A0C
		public static VectorOffset CreateEndingListVector(FlatBufferBuilder builder, Offset<IReignsEnding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BD8C RID: 179596 RVA: 0x005F684C File Offset: 0x005F4A4C
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, Offset<IReignsEnding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReignsEnding>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD8D RID: 179597 RVA: 0x005F6866 File Offset: 0x005F4A66
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReignsEnding>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReignsEnding>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BD8E RID: 179598 RVA: 0x005F6884 File Offset: 0x005F4A84
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReignsEnding>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BD8F RID: 179599 RVA: 0x005F689D File Offset: 0x005F4A9D
		public static void StartEndingListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BD90 RID: 179600 RVA: 0x005F68A8 File Offset: 0x005F4AA8
		public static Offset<TCsvReignsData> EndTCsvReignsData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvReignsData>(builder.EndTable());
		}

		// Token: 0x0602BD91 RID: 179601 RVA: 0x005F68B8 File Offset: 0x005F4AB8
		public TCsvReignsDataT UnPack()
		{
			TCsvReignsDataT tcsvReignsDataT = new TCsvReignsDataT();
			this.UnPackTo(tcsvReignsDataT);
			return tcsvReignsDataT;
		}

		// Token: 0x0602BD92 RID: 179602 RVA: 0x005F68D4 File Offset: 0x005F4AD4
		public void UnPackTo(TCsvReignsDataT _o)
		{
			_o.Id = this.Id;
			_o.BaseProperty = new List<IReignsPropertyConfigT>();
			for (int i = 0; i < this.BasePropertyLength; i++)
			{
				_o.BaseProperty.Add((this.BaseProperty(i) != null) ? this.BaseProperty(i).Value.UnPack() : null);
			}
			_o.EndingList = new List<IReignsEndingT>();
			for (int j = 0; j < this.EndingListLength; j++)
			{
				_o.EndingList.Add((this.EndingList(j) != null) ? this.EndingList(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BD93 RID: 179603 RVA: 0x005F6994 File Offset: 0x005F4B94
		public static Offset<TCsvReignsData> Pack(FlatBufferBuilder builder, TCsvReignsDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvReignsData>);
			}
			VectorOffset basePropertyOffset = default(VectorOffset);
			if (_o.BaseProperty != null)
			{
				Offset<IReignsPropertyConfig>[] array = new Offset<IReignsPropertyConfig>[_o.BaseProperty.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IReignsPropertyConfig.Pack(builder, _o.BaseProperty[i]);
				}
				basePropertyOffset = TCsvReignsData.CreateBasePropertyVector(builder, array);
			}
			VectorOffset endingListOffset = default(VectorOffset);
			if (_o.EndingList != null)
			{
				Offset<IReignsEnding>[] array2 = new Offset<IReignsEnding>[_o.EndingList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IReignsEnding.Pack(builder, _o.EndingList[j]);
				}
				endingListOffset = TCsvReignsData.CreateEndingListVector(builder, array2);
			}
			return TCsvReignsData.CreateTCsvReignsData(builder, _o.Id, basePropertyOffset, endingListOffset);
		}

		// Token: 0x04010609 RID: 67081
		private Table __p;
	}
}
