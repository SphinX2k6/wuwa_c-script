using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E78 RID: 24184
	public struct TCsvReignsData : IFlatbufferObject
	{
		// Token: 0x1700B4C8 RID: 46280
		// (get) Token: 0x060296CE RID: 169678 RVA: 0x005AD5B4 File Offset: 0x005AB7B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296CF RID: 169679 RVA: 0x005AD5C1 File Offset: 0x005AB7C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296D0 RID: 169680 RVA: 0x005AD5C8 File Offset: 0x005AB7C8
		public static TCsvReignsData GetRootAsTCsvReignsData(ByteBuffer _bb)
		{
			return TCsvReignsData.GetRootAsTCsvReignsData(_bb, default(TCsvReignsData));
		}

		// Token: 0x060296D1 RID: 169681 RVA: 0x005AD5E4 File Offset: 0x005AB7E4
		public static TCsvReignsData GetRootAsTCsvReignsData(ByteBuffer _bb, TCsvReignsData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296D2 RID: 169682 RVA: 0x005AD601 File Offset: 0x005AB801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296D3 RID: 169683 RVA: 0x005AD610 File Offset: 0x005AB810
		public TCsvReignsData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4C9 RID: 46281
		// (get) Token: 0x060296D4 RID: 169684 RVA: 0x005AD620 File Offset: 0x005AB820
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

		// Token: 0x060296D5 RID: 169685 RVA: 0x005AD65C File Offset: 0x005AB85C
		public IReignsPropertyConfig? BaseProperty(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IReignsPropertyConfig?(default(IReignsPropertyConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B4CA RID: 46282
		// (get) Token: 0x060296D6 RID: 169686 RVA: 0x005AD6BC File Offset: 0x005AB8BC
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

		// Token: 0x060296D7 RID: 169687 RVA: 0x005AD6E8 File Offset: 0x005AB8E8
		public IReignsEnding? EndingList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IReignsEnding?(default(IReignsEnding).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B4CB RID: 46283
		// (get) Token: 0x060296D8 RID: 169688 RVA: 0x005AD748 File Offset: 0x005AB948
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

		// Token: 0x060296D9 RID: 169689 RVA: 0x005AD773 File Offset: 0x005AB973
		public static Offset<TCsvReignsData> CreateTCsvReignsData(FlatBufferBuilder builder, int Id = 0, VectorOffset BasePropertyOffset = default(VectorOffset), VectorOffset EndingListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			TCsvReignsData.AddEndingList(builder, EndingListOffset);
			TCsvReignsData.AddBaseProperty(builder, BasePropertyOffset);
			TCsvReignsData.AddId(builder, Id);
			return TCsvReignsData.EndTCsvReignsData(builder);
		}

		// Token: 0x060296DA RID: 169690 RVA: 0x005AD797 File Offset: 0x005AB997
		public static void StartTCsvReignsData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060296DB RID: 169691 RVA: 0x005AD7A0 File Offset: 0x005AB9A0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060296DC RID: 169692 RVA: 0x005AD7AB File Offset: 0x005AB9AB
		public static void AddBaseProperty(FlatBufferBuilder builder, VectorOffset basePropertyOffset)
		{
			builder.AddOffset(1, basePropertyOffset.Value, 0);
		}

		// Token: 0x060296DD RID: 169693 RVA: 0x005AD7BC File Offset: 0x005AB9BC
		public static VectorOffset CreateBasePropertyVector(FlatBufferBuilder builder, Offset<IReignsPropertyConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060296DE RID: 169694 RVA: 0x005AD7FC File Offset: 0x005AB9FC
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, Offset<IReignsPropertyConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReignsPropertyConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060296DF RID: 169695 RVA: 0x005AD816 File Offset: 0x005ABA16
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReignsPropertyConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReignsPropertyConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060296E0 RID: 169696 RVA: 0x005AD834 File Offset: 0x005ABA34
		public static VectorOffset CreateBasePropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReignsPropertyConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060296E1 RID: 169697 RVA: 0x005AD84D File Offset: 0x005ABA4D
		public static void StartBasePropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060296E2 RID: 169698 RVA: 0x005AD858 File Offset: 0x005ABA58
		public static void AddEndingList(FlatBufferBuilder builder, VectorOffset endingListOffset)
		{
			builder.AddOffset(2, endingListOffset.Value, 0);
		}

		// Token: 0x060296E3 RID: 169699 RVA: 0x005AD868 File Offset: 0x005ABA68
		public static VectorOffset CreateEndingListVector(FlatBufferBuilder builder, Offset<IReignsEnding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060296E4 RID: 169700 RVA: 0x005AD8A8 File Offset: 0x005ABAA8
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, Offset<IReignsEnding>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IReignsEnding>>(data);
			return builder.EndVector();
		}

		// Token: 0x060296E5 RID: 169701 RVA: 0x005AD8C2 File Offset: 0x005ABAC2
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IReignsEnding>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IReignsEnding>>(data);
			return builder.EndVector();
		}

		// Token: 0x060296E6 RID: 169702 RVA: 0x005AD8E0 File Offset: 0x005ABAE0
		public static VectorOffset CreateEndingListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IReignsEnding>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060296E7 RID: 169703 RVA: 0x005AD8F9 File Offset: 0x005ABAF9
		public static void StartEndingListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060296E8 RID: 169704 RVA: 0x005AD904 File Offset: 0x005ABB04
		public static Offset<TCsvReignsData> EndTCsvReignsData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvReignsData>(builder.EndTable());
		}

		// Token: 0x060296E9 RID: 169705 RVA: 0x005AD914 File Offset: 0x005ABB14
		public TCsvReignsDataT UnPack()
		{
			TCsvReignsDataT tcsvReignsDataT = new TCsvReignsDataT();
			this.UnPackTo(tcsvReignsDataT);
			return tcsvReignsDataT;
		}

		// Token: 0x060296EA RID: 169706 RVA: 0x005AD930 File Offset: 0x005ABB30
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

		// Token: 0x060296EB RID: 169707 RVA: 0x005AD9F0 File Offset: 0x005ABBF0
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

		// Token: 0x0400F8A6 RID: 63654
		private Table __p;
	}
}
