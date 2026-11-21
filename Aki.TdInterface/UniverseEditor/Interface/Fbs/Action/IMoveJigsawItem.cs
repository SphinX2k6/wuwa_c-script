using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728E RID: 29326
	public struct IMoveJigsawItem : IFlatbufferObject
	{
		// Token: 0x1700D6F5 RID: 55029
		// (get) Token: 0x060331A0 RID: 209312 RVA: 0x006E559A File Offset: 0x006E379A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331A1 RID: 209313 RVA: 0x006E55A7 File Offset: 0x006E37A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331A2 RID: 209314 RVA: 0x006E55B0 File Offset: 0x006E37B0
		public static IMoveJigsawItem GetRootAsIMoveJigsawItem(ByteBuffer _bb)
		{
			return IMoveJigsawItem.GetRootAsIMoveJigsawItem(_bb, default(IMoveJigsawItem));
		}

		// Token: 0x060331A3 RID: 209315 RVA: 0x006E55CC File Offset: 0x006E37CC
		public static IMoveJigsawItem GetRootAsIMoveJigsawItem(ByteBuffer _bb, IMoveJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331A4 RID: 209316 RVA: 0x006E55E9 File Offset: 0x006E37E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331A5 RID: 209317 RVA: 0x006E55F8 File Offset: 0x006E37F8
		public IMoveJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6F6 RID: 55030
		// (get) Token: 0x060331A6 RID: 209318 RVA: 0x006E5608 File Offset: 0x006E3808
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

		// Token: 0x1700D6F7 RID: 55031
		// (get) Token: 0x060331A7 RID: 209319 RVA: 0x006E5644 File Offset: 0x006E3844
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

		// Token: 0x1700D6F8 RID: 55032
		// (get) Token: 0x060331A8 RID: 209320 RVA: 0x006E5680 File Offset: 0x006E3880
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

		// Token: 0x1700D6F9 RID: 55033
		// (get) Token: 0x060331A9 RID: 209321 RVA: 0x006E56BC File Offset: 0x006E38BC
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

		// Token: 0x060331AA RID: 209322 RVA: 0x006E571A File Offset: 0x006E391A
		public static Offset<IMoveJigsawItem> CreateIMoveJigsawItem(FlatBufferBuilder builder, ESetJigsawItemType Type = ESetJigsawItemType.MoveJigsawItem, int ItemEntityId = 0, int FoundationEntityId = 0, Offset<IPieceIndex> DestinationOffset = default(Offset<IPieceIndex>))
		{
			builder.StartTable(4);
			IMoveJigsawItem.AddDestination(builder, DestinationOffset);
			IMoveJigsawItem.AddFoundationEntityId(builder, FoundationEntityId);
			IMoveJigsawItem.AddItemEntityId(builder, ItemEntityId);
			IMoveJigsawItem.AddType(builder, Type);
			return IMoveJigsawItem.EndIMoveJigsawItem(builder);
		}

		// Token: 0x060331AB RID: 209323 RVA: 0x006E5746 File Offset: 0x006E3946
		public static void StartIMoveJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060331AC RID: 209324 RVA: 0x006E574F File Offset: 0x006E394F
		public static void AddType(FlatBufferBuilder builder, ESetJigsawItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060331AD RID: 209325 RVA: 0x006E575A File Offset: 0x006E395A
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x060331AE RID: 209326 RVA: 0x006E5765 File Offset: 0x006E3965
		public static void AddFoundationEntityId(FlatBufferBuilder builder, int foundationEntityId)
		{
			builder.AddInt(2, foundationEntityId, 0);
		}

		// Token: 0x060331AF RID: 209327 RVA: 0x006E5770 File Offset: 0x006E3970
		public static void AddDestination(FlatBufferBuilder builder, Offset<IPieceIndex> destinationOffset)
		{
			builder.AddOffset(3, destinationOffset.Value, 0);
		}

		// Token: 0x060331B0 RID: 209328 RVA: 0x006E5780 File Offset: 0x006E3980
		public static Offset<IMoveJigsawItem> EndIMoveJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<IMoveJigsawItem>(builder.EndTable());
		}

		// Token: 0x060331B1 RID: 209329 RVA: 0x006E5790 File Offset: 0x006E3990
		public IMoveJigsawItemT UnPack()
		{
			IMoveJigsawItemT moveJigsawItemT = new IMoveJigsawItemT();
			this.UnPackTo(moveJigsawItemT);
			return moveJigsawItemT;
		}

		// Token: 0x060331B2 RID: 209330 RVA: 0x006E57AC File Offset: 0x006E39AC
		public void UnPackTo(IMoveJigsawItemT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.FoundationEntityId = this.FoundationEntityId;
			_o.Destination = ((this.Destination != null) ? this.Destination.Value.UnPack() : null);
		}

		// Token: 0x060331B3 RID: 209331 RVA: 0x006E580C File Offset: 0x006E3A0C
		public static Offset<IMoveJigsawItem> Pack(FlatBufferBuilder builder, IMoveJigsawItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveJigsawItem>);
			}
			Offset<IPieceIndex> destinationOffset = (_o.Destination == null) ? default(Offset<IPieceIndex>) : IPieceIndex.Pack(builder, _o.Destination);
			return IMoveJigsawItem.CreateIMoveJigsawItem(builder, _o.Type, _o.ItemEntityId, _o.FoundationEntityId, destinationOffset);
		}

		// Token: 0x0401230F RID: 74511
		private Table __p;
	}
}
