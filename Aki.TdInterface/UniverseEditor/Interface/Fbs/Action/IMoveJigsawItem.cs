using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B48 RID: 27464
	public struct IMoveJigsawItem : IFlatbufferObject
	{
		// Token: 0x1700CC10 RID: 52240
		// (get) Token: 0x06030349 RID: 197449 RVA: 0x0068CFDE File Offset: 0x0068B1DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603034A RID: 197450 RVA: 0x0068CFEB File Offset: 0x0068B1EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603034B RID: 197451 RVA: 0x0068CFF4 File Offset: 0x0068B1F4
		public static IMoveJigsawItem GetRootAsIMoveJigsawItem(ByteBuffer _bb)
		{
			return IMoveJigsawItem.GetRootAsIMoveJigsawItem(_bb, default(IMoveJigsawItem));
		}

		// Token: 0x0603034C RID: 197452 RVA: 0x0068D010 File Offset: 0x0068B210
		public static IMoveJigsawItem GetRootAsIMoveJigsawItem(ByteBuffer _bb, IMoveJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603034D RID: 197453 RVA: 0x0068D02D File Offset: 0x0068B22D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603034E RID: 197454 RVA: 0x0068D03C File Offset: 0x0068B23C
		public IMoveJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC11 RID: 52241
		// (get) Token: 0x0603034F RID: 197455 RVA: 0x0068D04C File Offset: 0x0068B24C
		public ESetJigsawItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return (ESetJigsawItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC12 RID: 52242
		// (get) Token: 0x06030350 RID: 197456 RVA: 0x0068D088 File Offset: 0x0068B288
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

		// Token: 0x1700CC13 RID: 52243
		// (get) Token: 0x06030351 RID: 197457 RVA: 0x0068D0C4 File Offset: 0x0068B2C4
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

		// Token: 0x1700CC14 RID: 52244
		// (get) Token: 0x06030352 RID: 197458 RVA: 0x0068D100 File Offset: 0x0068B300
		public IPieceIndex? Destination
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

		// Token: 0x06030353 RID: 197459 RVA: 0x0068D15E File Offset: 0x0068B35E
		public static Offset<IMoveJigsawItem> CreateIMoveJigsawItem(FlatBufferBuilder builder, ESetJigsawItemType Type = ESetJigsawItemType.MoveJigsawItem, int ItemEntityId = 0, int FoundationEntityId = 0, Offset<IPieceIndex> DestinationOffset = default(Offset<IPieceIndex>))
		{
			builder.StartTable(4);
			IMoveJigsawItem.AddDestination(builder, DestinationOffset);
			IMoveJigsawItem.AddFoundationEntityId(builder, FoundationEntityId);
			IMoveJigsawItem.AddItemEntityId(builder, ItemEntityId);
			IMoveJigsawItem.AddType(builder, Type);
			return IMoveJigsawItem.EndIMoveJigsawItem(builder);
		}

		// Token: 0x06030354 RID: 197460 RVA: 0x0068D18A File Offset: 0x0068B38A
		public static void StartIMoveJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030355 RID: 197461 RVA: 0x0068D193 File Offset: 0x0068B393
		public static void AddType(FlatBufferBuilder builder, ESetJigsawItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030356 RID: 197462 RVA: 0x0068D19E File Offset: 0x0068B39E
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x06030357 RID: 197463 RVA: 0x0068D1A9 File Offset: 0x0068B3A9
		public static void AddFoundationEntityId(FlatBufferBuilder builder, int foundationEntityId)
		{
			builder.AddInt(2, foundationEntityId, 0);
		}

		// Token: 0x06030358 RID: 197464 RVA: 0x0068D1B4 File Offset: 0x0068B3B4
		public static void AddDestination(FlatBufferBuilder builder, Offset<IPieceIndex> destinationOffset)
		{
			builder.AddOffset(3, destinationOffset.Value, 0);
		}

		// Token: 0x06030359 RID: 197465 RVA: 0x0068D1C4 File Offset: 0x0068B3C4
		public static Offset<IMoveJigsawItem> EndIMoveJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<IMoveJigsawItem>(builder.EndTable());
		}

		// Token: 0x0603035A RID: 197466 RVA: 0x0068D1D4 File Offset: 0x0068B3D4
		public IMoveJigsawItemT UnPack()
		{
			IMoveJigsawItemT moveJigsawItemT = new IMoveJigsawItemT();
			this.UnPackTo(moveJigsawItemT);
			return moveJigsawItemT;
		}

		// Token: 0x0603035B RID: 197467 RVA: 0x0068D1F0 File Offset: 0x0068B3F0
		public void UnPackTo(IMoveJigsawItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.FoundationEntityId = this.FoundationEntityId;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
		}

		// Token: 0x0603035C RID: 197468 RVA: 0x0068D250 File Offset: 0x0068B450
		public static Offset<IMoveJigsawItem> Pack(FlatBufferBuilder builder, IMoveJigsawItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveJigsawItem>);
			}
			Offset<IPieceIndex> destinationOffset = (_o.Destination == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Destination);
			return IMoveJigsawItem.CreateIMoveJigsawItem(builder, _o.Type, _o.ItemEntityId, _o.FoundationEntityId, destinationOffset);
		}

		// Token: 0x040113E6 RID: 70630
		private Table __p;
	}
}
