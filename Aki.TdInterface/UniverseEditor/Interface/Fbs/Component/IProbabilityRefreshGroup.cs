using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D88 RID: 23944
	public struct IProbabilityRefreshGroup : IFlatbufferObject
	{
		// Token: 0x1700B03A RID: 45114
		// (get) Token: 0x06027DEF RID: 163311 RVA: 0x0057429A File Offset: 0x0057249A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DF0 RID: 163312 RVA: 0x005742A7 File Offset: 0x005724A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DF1 RID: 163313 RVA: 0x005742B0 File Offset: 0x005724B0
		public static IProbabilityRefreshGroup GetRootAsIProbabilityRefreshGroup(ByteBuffer _bb)
		{
			return IProbabilityRefreshGroup.GetRootAsIProbabilityRefreshGroup(_bb, default(IProbabilityRefreshGroup));
		}

		// Token: 0x06027DF2 RID: 163314 RVA: 0x005742CC File Offset: 0x005724CC
		public static IProbabilityRefreshGroup GetRootAsIProbabilityRefreshGroup(ByteBuffer _bb, IProbabilityRefreshGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DF3 RID: 163315 RVA: 0x005742E9 File Offset: 0x005724E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DF4 RID: 163316 RVA: 0x005742F8 File Offset: 0x005724F8
		public IProbabilityRefreshGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B03B RID: 45115
		// (get) Token: 0x06027DF5 RID: 163317 RVA: 0x00574308 File Offset: 0x00572508
		public string CheckOccupation
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

		// Token: 0x06027DF6 RID: 163318 RVA: 0x0057433F File Offset: 0x0057253F
		public Span<byte> GetCheckOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06027DF7 RID: 163319 RVA: 0x0057434E File Offset: 0x0057254E
		public byte[] GetCheckOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06027DF8 RID: 163320 RVA: 0x0057435C File Offset: 0x0057255C
		public IProbabilityRefreshItem? RefreshItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IProbabilityRefreshItem?(default(IProbabilityRefreshItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B03C RID: 45116
		// (get) Token: 0x06027DF9 RID: 163321 RVA: 0x005743BC File Offset: 0x005725BC
		public int RefreshItemsLength
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

		// Token: 0x06027DFA RID: 163322 RVA: 0x005743E7 File Offset: 0x005725E7
		public static Offset<IProbabilityRefreshGroup> CreateIProbabilityRefreshGroup(FlatBufferBuilder builder, StringOffset CheckOccupationOffset = default(StringOffset), VectorOffset RefreshItemsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IProbabilityRefreshGroup.AddRefreshItems(builder, RefreshItemsOffset);
			IProbabilityRefreshGroup.AddCheckOccupation(builder, CheckOccupationOffset);
			return IProbabilityRefreshGroup.EndIProbabilityRefreshGroup(builder);
		}

		// Token: 0x06027DFB RID: 163323 RVA: 0x00574404 File Offset: 0x00572604
		public static void StartIProbabilityRefreshGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027DFC RID: 163324 RVA: 0x0057440D File Offset: 0x0057260D
		public static void AddCheckOccupation(FlatBufferBuilder builder, StringOffset checkOccupationOffset)
		{
			builder.AddOffset(0, checkOccupationOffset.Value, 0);
		}

		// Token: 0x06027DFD RID: 163325 RVA: 0x0057441D File Offset: 0x0057261D
		public static void AddRefreshItems(FlatBufferBuilder builder, VectorOffset refreshItemsOffset)
		{
			builder.AddOffset(1, refreshItemsOffset.Value, 0);
		}

		// Token: 0x06027DFE RID: 163326 RVA: 0x00574430 File Offset: 0x00572630
		public static VectorOffset CreateRefreshItemsVector(FlatBufferBuilder builder, Offset<IProbabilityRefreshItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027DFF RID: 163327 RVA: 0x00574470 File Offset: 0x00572670
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, Offset<IProbabilityRefreshItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IProbabilityRefreshItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E00 RID: 163328 RVA: 0x0057448A File Offset: 0x0057268A
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IProbabilityRefreshItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IProbabilityRefreshItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E01 RID: 163329 RVA: 0x005744A8 File Offset: 0x005726A8
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IProbabilityRefreshItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027E02 RID: 163330 RVA: 0x005744C1 File Offset: 0x005726C1
		public static void StartRefreshItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027E03 RID: 163331 RVA: 0x005744CC File Offset: 0x005726CC
		public static Offset<IProbabilityRefreshGroup> EndIProbabilityRefreshGroup(FlatBufferBuilder builder)
		{
			return new Offset<IProbabilityRefreshGroup>(builder.EndTable());
		}

		// Token: 0x06027E04 RID: 163332 RVA: 0x005744DC File Offset: 0x005726DC
		public IProbabilityRefreshGroupT UnPack()
		{
			IProbabilityRefreshGroupT probabilityRefreshGroupT = new IProbabilityRefreshGroupT();
			this.UnPackTo(probabilityRefreshGroupT);
			return probabilityRefreshGroupT;
		}

		// Token: 0x06027E05 RID: 163333 RVA: 0x005744F8 File Offset: 0x005726F8
		public void UnPackTo(IProbabilityRefreshGroupT _o)
		{
			_o.CheckOccupation = this.CheckOccupation;
			_o.RefreshItems = new List<IProbabilityRefreshItemT>();
			for (int i = 0; i < this.RefreshItemsLength; i++)
			{
				_o.RefreshItems.Add((this.RefreshItems(i) != null) ? this.RefreshItems(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027E06 RID: 163334 RVA: 0x00574564 File Offset: 0x00572764
		public static Offset<IProbabilityRefreshGroup> Pack(FlatBufferBuilder builder, IProbabilityRefreshGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProbabilityRefreshGroup>);
			}
			StringOffset checkOccupationOffset = (_o.CheckOccupation == null) ? default(StringOffset) : builder.CreateString(_o.CheckOccupation);
			VectorOffset refreshItemsOffset = default(VectorOffset);
			if (_o.RefreshItems != null)
			{
				Offset<IProbabilityRefreshItem>[] array = new Offset<IProbabilityRefreshItem>[_o.RefreshItems.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IProbabilityRefreshItem.Pack(builder, _o.RefreshItems[i]);
				}
				refreshItemsOffset = IProbabilityRefreshGroup.CreateRefreshItemsVector(builder, array);
			}
			return IProbabilityRefreshGroup.CreateIProbabilityRefreshGroup(builder, checkOccupationOffset, refreshItemsOffset);
		}

		// Token: 0x0400F919 RID: 63769
		private Table __p;
	}
}
