using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CB RID: 26827
	public struct IBvbSelectCard : IFlatbufferObject
	{
		// Token: 0x1700C52E RID: 50478
		// (get) Token: 0x0602DE3B RID: 187963 RVA: 0x006451AC File Offset: 0x006433AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE3C RID: 187964 RVA: 0x006451B9 File Offset: 0x006433B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE3D RID: 187965 RVA: 0x006451C0 File Offset: 0x006433C0
		public static IBvbSelectCard GetRootAsIBvbSelectCard(ByteBuffer _bb)
		{
			return IBvbSelectCard.GetRootAsIBvbSelectCard(_bb, default(IBvbSelectCard));
		}

		// Token: 0x0602DE3E RID: 187966 RVA: 0x006451DC File Offset: 0x006433DC
		public static IBvbSelectCard GetRootAsIBvbSelectCard(ByteBuffer _bb, IBvbSelectCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE3F RID: 187967 RVA: 0x006451F9 File Offset: 0x006433F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE40 RID: 187968 RVA: 0x00645208 File Offset: 0x00643408
		public IBvbSelectCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C52F RID: 50479
		// (get) Token: 0x0602DE41 RID: 187969 RVA: 0x00645218 File Offset: 0x00643418
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

		// Token: 0x0602DE42 RID: 187970 RVA: 0x00645254 File Offset: 0x00643454
		public int CardIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C530 RID: 50480
		// (get) Token: 0x0602DE43 RID: 187971 RVA: 0x00645294 File Offset: 0x00643494
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

		// Token: 0x0602DE44 RID: 187972 RVA: 0x006452BF File Offset: 0x006434BF
		public Span<int> GetCardIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602DE45 RID: 187973 RVA: 0x006452CE File Offset: 0x006434CE
		public int[] GetCardIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C531 RID: 50481
		// (get) Token: 0x0602DE46 RID: 187974 RVA: 0x006452DC File Offset: 0x006434DC
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

		// Token: 0x0602DE47 RID: 187975 RVA: 0x00645318 File Offset: 0x00643518
		public static Offset<IBvbSelectCard> CreateIBvbSelectCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, VectorOffset CardIdListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbSelectCard.AddCardIdList(builder, CardIdListOffset);
			IBvbSelectCard.AddNullMask(builder, NullMask);
			IBvbSelectCard.AddType(builder, Type);
			return IBvbSelectCard.EndIBvbSelectCard(builder);
		}

		// Token: 0x0602DE48 RID: 187976 RVA: 0x0064533C File Offset: 0x0064353C
		public static void StartIBvbSelectCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DE49 RID: 187977 RVA: 0x00645345 File Offset: 0x00643545
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DE4A RID: 187978 RVA: 0x00645350 File Offset: 0x00643550
		public static void AddCardIdList(FlatBufferBuilder builder, VectorOffset cardIdListOffset)
		{
			builder.AddOffset(1, cardIdListOffset.Value, 0);
		}

		// Token: 0x0602DE4B RID: 187979 RVA: 0x00645360 File Offset: 0x00643560
		public static VectorOffset CreateCardIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DE4C RID: 187980 RVA: 0x00645397 File Offset: 0x00643597
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE4D RID: 187981 RVA: 0x006453B1 File Offset: 0x006435B1
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DE4E RID: 187982 RVA: 0x006453CF File Offset: 0x006435CF
		public static VectorOffset CreateCardIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DE4F RID: 187983 RVA: 0x006453E8 File Offset: 0x006435E8
		public static void StartCardIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DE50 RID: 187984 RVA: 0x006453F3 File Offset: 0x006435F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602DE51 RID: 187985 RVA: 0x006453FE File Offset: 0x006435FE
		public static Offset<IBvbSelectCard> EndIBvbSelectCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSelectCard>(builder.EndTable());
		}

		// Token: 0x0602DE52 RID: 187986 RVA: 0x0064540C File Offset: 0x0064360C
		public IBvbSelectCardT UnPack()
		{
			IBvbSelectCardT bvbSelectCardT = new IBvbSelectCardT();
			this.UnPackTo(bvbSelectCardT);
			return bvbSelectCardT;
		}

		// Token: 0x0602DE53 RID: 187987 RVA: 0x00645428 File Offset: 0x00643628
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

		// Token: 0x0602DE54 RID: 187988 RVA: 0x0064547C File Offset: 0x0064367C
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

		// Token: 0x040115CB RID: 71115
		private Table __p;
	}
}
