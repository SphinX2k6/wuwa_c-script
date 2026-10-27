using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005781 RID: 22401
	public struct IProbabilityRefreshGroup : IFlatbufferObject
	{
		// Token: 0x1700A716 RID: 42774
		// (get) Token: 0x060258CF RID: 153807 RVA: 0x0052E10E File Offset: 0x0052C30E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258D0 RID: 153808 RVA: 0x0052E11B File Offset: 0x0052C31B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258D1 RID: 153809 RVA: 0x0052E124 File Offset: 0x0052C324
		public static IProbabilityRefreshGroup GetRootAsIProbabilityRefreshGroup(ByteBuffer _bb)
		{
			return IProbabilityRefreshGroup.GetRootAsIProbabilityRefreshGroup(_bb, default(IProbabilityRefreshGroup));
		}

		// Token: 0x060258D2 RID: 153810 RVA: 0x0052E140 File Offset: 0x0052C340
		public static IProbabilityRefreshGroup GetRootAsIProbabilityRefreshGroup(ByteBuffer _bb, IProbabilityRefreshGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258D3 RID: 153811 RVA: 0x0052E15D File Offset: 0x0052C35D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258D4 RID: 153812 RVA: 0x0052E16C File Offset: 0x0052C36C
		public IProbabilityRefreshGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A717 RID: 42775
		// (get) Token: 0x060258D5 RID: 153813 RVA: 0x0052E17C File Offset: 0x0052C37C
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

		// Token: 0x060258D6 RID: 153814 RVA: 0x0052E1B3 File Offset: 0x0052C3B3
		public Span<byte> GetCheckOccupationBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060258D7 RID: 153815 RVA: 0x0052E1C2 File Offset: 0x0052C3C2
		public byte[] GetCheckOccupationArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060258D8 RID: 153816 RVA: 0x0052E1D0 File Offset: 0x0052C3D0
		public IProbabilityRefreshItem? RefreshItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IProbabilityRefreshItem?(default(IProbabilityRefreshItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A718 RID: 42776
		// (get) Token: 0x060258D9 RID: 153817 RVA: 0x0052E230 File Offset: 0x0052C430
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

		// Token: 0x060258DA RID: 153818 RVA: 0x0052E25B File Offset: 0x0052C45B
		public static Offset<IProbabilityRefreshGroup> CreateIProbabilityRefreshGroup(FlatBufferBuilder builder, StringOffset CheckOccupationOffset = default(StringOffset), VectorOffset RefreshItemsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IProbabilityRefreshGroup.AddRefreshItems(builder, RefreshItemsOffset);
			IProbabilityRefreshGroup.AddCheckOccupation(builder, CheckOccupationOffset);
			return IProbabilityRefreshGroup.EndIProbabilityRefreshGroup(builder);
		}

		// Token: 0x060258DB RID: 153819 RVA: 0x0052E278 File Offset: 0x0052C478
		public static void StartIProbabilityRefreshGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060258DC RID: 153820 RVA: 0x0052E281 File Offset: 0x0052C481
		public static void AddCheckOccupation(FlatBufferBuilder builder, StringOffset checkOccupationOffset)
		{
			builder.AddOffset(0, checkOccupationOffset.Value, 0);
		}

		// Token: 0x060258DD RID: 153821 RVA: 0x0052E291 File Offset: 0x0052C491
		public static void AddRefreshItems(FlatBufferBuilder builder, VectorOffset refreshItemsOffset)
		{
			builder.AddOffset(1, refreshItemsOffset.Value, 0);
		}

		// Token: 0x060258DE RID: 153822 RVA: 0x0052E2A4 File Offset: 0x0052C4A4
		public static VectorOffset CreateRefreshItemsVector(FlatBufferBuilder builder, Offset<IProbabilityRefreshItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060258DF RID: 153823 RVA: 0x0052E2E4 File Offset: 0x0052C4E4
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, Offset<IProbabilityRefreshItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IProbabilityRefreshItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060258E0 RID: 153824 RVA: 0x0052E2FE File Offset: 0x0052C4FE
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IProbabilityRefreshItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IProbabilityRefreshItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060258E1 RID: 153825 RVA: 0x0052E31C File Offset: 0x0052C51C
		public static VectorOffset CreateRefreshItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IProbabilityRefreshItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060258E2 RID: 153826 RVA: 0x0052E335 File Offset: 0x0052C535
		public static void StartRefreshItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060258E3 RID: 153827 RVA: 0x0052E340 File Offset: 0x0052C540
		public static Offset<IProbabilityRefreshGroup> EndIProbabilityRefreshGroup(FlatBufferBuilder builder)
		{
			return new Offset<IProbabilityRefreshGroup>(builder.EndTable());
		}

		// Token: 0x060258E4 RID: 153828 RVA: 0x0052E350 File Offset: 0x0052C550
		public IProbabilityRefreshGroupT UnPack()
		{
			IProbabilityRefreshGroupT probabilityRefreshGroupT = new IProbabilityRefreshGroupT();
			this.UnPackTo(probabilityRefreshGroupT);
			return probabilityRefreshGroupT;
		}

		// Token: 0x060258E5 RID: 153829 RVA: 0x0052E36C File Offset: 0x0052C56C
		public void UnPackTo(IProbabilityRefreshGroupT _o)
		{
			_o.CheckOccupation = this.CheckOccupation;
			_o.RefreshItems = new List<IProbabilityRefreshItemT>();
			for (int i = 0; i < this.RefreshItemsLength; i++)
			{
				_o.RefreshItems.Add((this.RefreshItems(i) != null) ? this.RefreshItems(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060258E6 RID: 153830 RVA: 0x0052E3D8 File Offset: 0x0052C5D8
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

		// Token: 0x0400EC2E RID: 60462
		private Table __p;
	}
}
