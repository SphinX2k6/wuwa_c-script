using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB4 RID: 19124
	public struct ICheckJigsawItemPlaceIndex : IFlatbufferObject
	{
		// Token: 0x17008A9E RID: 35486
		// (get) Token: 0x0601E048 RID: 122952 RVA: 0x00436990 File Offset: 0x00434B90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E049 RID: 122953 RVA: 0x0043699D File Offset: 0x00434B9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E04A RID: 122954 RVA: 0x004369A4 File Offset: 0x00434BA4
		public static ICheckJigsawItemPlaceIndex GetRootAsICheckJigsawItemPlaceIndex(ByteBuffer _bb)
		{
			return ICheckJigsawItemPlaceIndex.GetRootAsICheckJigsawItemPlaceIndex(_bb, default(ICheckJigsawItemPlaceIndex));
		}

		// Token: 0x0601E04B RID: 122955 RVA: 0x004369C0 File Offset: 0x00434BC0
		public static ICheckJigsawItemPlaceIndex GetRootAsICheckJigsawItemPlaceIndex(ByteBuffer _bb, ICheckJigsawItemPlaceIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E04C RID: 122956 RVA: 0x004369DD File Offset: 0x00434BDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E04D RID: 122957 RVA: 0x004369EC File Offset: 0x00434BEC
		public ICheckJigsawItemPlaceIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A9F RID: 35487
		// (get) Token: 0x0601E04E RID: 122958 RVA: 0x004369FC File Offset: 0x00434BFC
		public ECheckJigsawInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
				}
				return (ECheckJigsawInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AA0 RID: 35488
		// (get) Token: 0x0601E04F RID: 122959 RVA: 0x00436A38 File Offset: 0x00434C38
		public int ItemEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AA1 RID: 35489
		// (get) Token: 0x0601E050 RID: 122960 RVA: 0x00436A74 File Offset: 0x00434C74
		public int FoundationEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AA2 RID: 35490
		// (get) Token: 0x0601E051 RID: 122961 RVA: 0x00436AB0 File Offset: 0x00434CB0
		public IPieceIndex? PlaceIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPieceIndex?(default(IPieceIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008AA3 RID: 35491
		// (get) Token: 0x0601E052 RID: 122962 RVA: 0x00436B10 File Offset: 0x00434D10
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E053 RID: 122963 RVA: 0x00436B4D File Offset: 0x00434D4D
		public static Offset<ICheckJigsawItemPlaceIndex> CreateICheckJigsawItemPlaceIndex(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex, int ItemEntityId = 0, int FoundationEntityId = 0, Offset<IPieceIndex> PlaceIndexOffset = default(Offset<IPieceIndex>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(5);
			ICheckJigsawItemPlaceIndex.AddPlaceIndex(builder, PlaceIndexOffset);
			ICheckJigsawItemPlaceIndex.AddFoundationEntityId(builder, FoundationEntityId);
			ICheckJigsawItemPlaceIndex.AddItemEntityId(builder, ItemEntityId);
			ICheckJigsawItemPlaceIndex.AddCompare(builder, Compare);
			ICheckJigsawItemPlaceIndex.AddType(builder, Type);
			return ICheckJigsawItemPlaceIndex.EndICheckJigsawItemPlaceIndex(builder);
		}

		// Token: 0x0601E054 RID: 122964 RVA: 0x00436B81 File Offset: 0x00434D81
		public static void StartICheckJigsawItemPlaceIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E055 RID: 122965 RVA: 0x00436B8A File Offset: 0x00434D8A
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E056 RID: 122966 RVA: 0x00436B95 File Offset: 0x00434D95
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x0601E057 RID: 122967 RVA: 0x00436BA0 File Offset: 0x00434DA0
		public static void AddFoundationEntityId(FlatBufferBuilder builder, int foundationEntityId)
		{
			builder.AddInt(2, foundationEntityId, 0);
		}

		// Token: 0x0601E058 RID: 122968 RVA: 0x00436BAB File Offset: 0x00434DAB
		public static void AddPlaceIndex(FlatBufferBuilder builder, Offset<IPieceIndex> placeIndexOffset)
		{
			builder.AddOffset(3, placeIndexOffset.Value, 0);
		}

		// Token: 0x0601E059 RID: 122969 RVA: 0x00436BBB File Offset: 0x00434DBB
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(4, (byte)compare, 0);
		}

		// Token: 0x0601E05A RID: 122970 RVA: 0x00436BC6 File Offset: 0x00434DC6
		public static Offset<ICheckJigsawItemPlaceIndex> EndICheckJigsawItemPlaceIndex(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawItemPlaceIndex>(builder.EndTable());
		}

		// Token: 0x0601E05B RID: 122971 RVA: 0x00436BD4 File Offset: 0x00434DD4
		public ICheckJigsawItemPlaceIndexT UnPack()
		{
			ICheckJigsawItemPlaceIndexT checkJigsawItemPlaceIndexT = new ICheckJigsawItemPlaceIndexT();
			this.UnPackTo(checkJigsawItemPlaceIndexT);
			return checkJigsawItemPlaceIndexT;
		}

		// Token: 0x0601E05C RID: 122972 RVA: 0x00436BF0 File Offset: 0x00434DF0
		public void UnPackTo(ICheckJigsawItemPlaceIndexT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.FoundationEntityId = this.FoundationEntityId;
			_o.PlaceIndex = ((this.PlaceIndex != null) ? this.PlaceIndex.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E05D RID: 122973 RVA: 0x00436C5C File Offset: 0x00434E5C
		public static Offset<ICheckJigsawItemPlaceIndex> Pack(FlatBufferBuilder builder, ICheckJigsawItemPlaceIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawItemPlaceIndex>);
			}
			Offset<IPieceIndex> placeIndexOffset = (_o.PlaceIndex == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.PlaceIndex);
			return ICheckJigsawItemPlaceIndex.CreateICheckJigsawItemPlaceIndex(builder, _o.Type, _o.ItemEntityId, _o.FoundationEntityId, placeIndexOffset, _o.Compare);
		}

		// Token: 0x0400D330 RID: 54064
		private Table __p;
	}
}
