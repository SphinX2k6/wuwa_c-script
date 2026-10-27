using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200625A RID: 25178
	public struct IBvbSelectCard : IFlatbufferObject
	{
		// Token: 0x1700BBA6 RID: 48038
		// (get) Token: 0x0602B6DA RID: 177882 RVA: 0x005FA3A4 File Offset: 0x005F85A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6DB RID: 177883 RVA: 0x005FA3B1 File Offset: 0x005F85B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6DC RID: 177884 RVA: 0x005FA3B8 File Offset: 0x005F85B8
		public static IBvbSelectCard GetRootAsIBvbSelectCard(ByteBuffer _bb)
		{
			return IBvbSelectCard.GetRootAsIBvbSelectCard(_bb, default(IBvbSelectCard));
		}

		// Token: 0x0602B6DD RID: 177885 RVA: 0x005FA3D4 File Offset: 0x005F85D4
		public static IBvbSelectCard GetRootAsIBvbSelectCard(ByteBuffer _bb, IBvbSelectCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B6DE RID: 177886 RVA: 0x005FA3F1 File Offset: 0x005F85F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B6DF RID: 177887 RVA: 0x005FA400 File Offset: 0x005F8600
		public IBvbSelectCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBA7 RID: 48039
		// (get) Token: 0x0602B6E0 RID: 177888 RVA: 0x005FA410 File Offset: 0x005F8610
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B6E1 RID: 177889 RVA: 0x005FA44C File Offset: 0x005F864C
		public int CardIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BBA8 RID: 48040
		// (get) Token: 0x0602B6E2 RID: 177890 RVA: 0x005FA48C File Offset: 0x005F868C
		public int CardIdListLength
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

		// Token: 0x0602B6E3 RID: 177891 RVA: 0x005FA4B7 File Offset: 0x005F86B7
		public Span<int> GetCardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602B6E4 RID: 177892 RVA: 0x005FA4C6 File Offset: 0x005F86C6
		public int[] GetCardIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700BBA9 RID: 48041
		// (get) Token: 0x0602B6E5 RID: 177893 RVA: 0x005FA4D4 File Offset: 0x005F86D4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B6E6 RID: 177894 RVA: 0x005FA510 File Offset: 0x005F8710
		public static Offset<IBvbSelectCard> CreateIBvbSelectCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, VectorOffset CardIdListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbSelectCard.AddCardIdList(builder, CardIdListOffset);
			IBvbSelectCard.AddNullMask(builder, NullMask);
			IBvbSelectCard.AddType(builder, Type);
			return IBvbSelectCard.EndIBvbSelectCard(builder);
		}

		// Token: 0x0602B6E7 RID: 177895 RVA: 0x005FA534 File Offset: 0x005F8734
		public static void StartIBvbSelectCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B6E8 RID: 177896 RVA: 0x005FA53D File Offset: 0x005F873D
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B6E9 RID: 177897 RVA: 0x005FA548 File Offset: 0x005F8748
		public static void AddCardIdList(FlatBufferBuilder builder, VectorOffset cardIdListOffset)
		{
			builder.AddOffset(1, cardIdListOffset.Value, 0);
		}

		// Token: 0x0602B6EA RID: 177898 RVA: 0x005FA558 File Offset: 0x005F8758
		public static VectorOffset CreateCardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B6EB RID: 177899 RVA: 0x005FA58F File Offset: 0x005F878F
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B6EC RID: 177900 RVA: 0x005FA5A9 File Offset: 0x005F87A9
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B6ED RID: 177901 RVA: 0x005FA5C7 File Offset: 0x005F87C7
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B6EE RID: 177902 RVA: 0x005FA5E0 File Offset: 0x005F87E0
		public static void StartCardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B6EF RID: 177903 RVA: 0x005FA5EB File Offset: 0x005F87EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602B6F0 RID: 177904 RVA: 0x005FA5F6 File Offset: 0x005F87F6
		public static Offset<IBvbSelectCard> EndIBvbSelectCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSelectCard>(builder.EndTable());
		}

		// Token: 0x0602B6F1 RID: 177905 RVA: 0x005FA604 File Offset: 0x005F8804
		public IBvbSelectCardT UnPack()
		{
			IBvbSelectCardT bvbSelectCardT = new IBvbSelectCardT();
			this.UnPackTo(bvbSelectCardT);
			return bvbSelectCardT;
		}

		// Token: 0x0602B6F2 RID: 177906 RVA: 0x005FA620 File Offset: 0x005F8820
		public void UnPackTo(IBvbSelectCardT _o)
		{
			_o.Type = this.Type;
			_o.CardIdList = new List<int>();
			for (int i = 0; i < this.CardIdListLength; i++)
			{
				_o.CardIdList.Add(this.CardIdList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B6F3 RID: 177907 RVA: 0x005FA674 File Offset: 0x005F8874
		public static Offset<IBvbSelectCard> Pack(FlatBufferBuilder builder, IBvbSelectCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSelectCard>);
			}
			VectorOffset cardIdListOffset = default(VectorOffset);
			if (_o.CardIdList != null)
			{
				int[] data = _o.CardIdList.ToArray();
				cardIdListOffset = IBvbSelectCard.CreateCardIdListVector(builder, data);
			}
			return IBvbSelectCard.CreateIBvbSelectCard(builder, _o.Type, cardIdListOffset, _o.NullMask);
		}

		// Token: 0x040107B6 RID: 67510
		private Table __p;
	}
}
