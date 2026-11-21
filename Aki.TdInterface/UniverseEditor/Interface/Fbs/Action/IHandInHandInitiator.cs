using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6E RID: 28526
	public struct IHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700D0FA RID: 53498
		// (get) Token: 0x060315FE RID: 202238 RVA: 0x006B2387 File Offset: 0x006B0587
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315FF RID: 202239 RVA: 0x006B2394 File Offset: 0x006B0594
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031600 RID: 202240 RVA: 0x006B239C File Offset: 0x006B059C
		public static IHandInHandInitiator GetRootAsIHandInHandInitiator(ByteBuffer _bb)
		{
			return IHandInHandInitiator.GetRootAsIHandInHandInitiator(_bb, default(IHandInHandInitiator));
		}

		// Token: 0x06031601 RID: 202241 RVA: 0x006B23B8 File Offset: 0x006B05B8
		public static IHandInHandInitiator GetRootAsIHandInHandInitiator(ByteBuffer _bb, IHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031602 RID: 202242 RVA: 0x006B23D5 File Offset: 0x006B05D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031603 RID: 202243 RVA: 0x006B23E4 File Offset: 0x006B05E4
		public IHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0FB RID: 53499
		// (get) Token: 0x06031604 RID: 202244 RVA: 0x006B23F4 File Offset: 0x006B05F4
		public THandInHandInitiator InitiatorType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THandInHandInitiator.NONE;
				}
				return (THandInHandInitiator)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031605 RID: 202245 RVA: 0x006B2430 File Offset: 0x006B0630
		public TTable? Initiator<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031606 RID: 202246 RVA: 0x006B2474 File Offset: 0x006B0674
		public IEntityHandInHandInitiator InitiatorAsIEntityHandInHandInitiator()
		{
			return this.Initiator<IEntityHandInHandInitiator>().Value;
		}

		// Token: 0x06031607 RID: 202247 RVA: 0x006B2490 File Offset: 0x006B0690
		public IPlayerHandInHandInitiator InitiatorAsIPlayerHandInHandInitiator()
		{
			return this.Initiator<IPlayerHandInHandInitiator>().Value;
		}

		// Token: 0x1700D0FC RID: 53500
		// (get) Token: 0x06031608 RID: 202248 RVA: 0x006B24AC File Offset: 0x006B06AC
		public EHandType HandType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EHandType.Left;
				}
				return (EHandType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031609 RID: 202249 RVA: 0x006B24E8 File Offset: 0x006B06E8
		public static Offset<IHandInHandInitiator> CreateIHandInHandInitiator(FlatBufferBuilder builder, THandInHandInitiator Initiator_type = THandInHandInitiator.NONE, int InitiatorOffset = 0, EHandType HandType = EHandType.Left)
		{
			builder.StartTable(3);
			IHandInHandInitiator.AddInitiator(builder, InitiatorOffset);
			IHandInHandInitiator.AddHandType(builder, HandType);
			IHandInHandInitiator.AddInitiatorType(builder, Initiator_type);
			return IHandInHandInitiator.EndIHandInHandInitiator(builder);
		}

		// Token: 0x0603160A RID: 202250 RVA: 0x006B250C File Offset: 0x006B070C
		public static void StartIHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603160B RID: 202251 RVA: 0x006B2515 File Offset: 0x006B0715
		public static void AddInitiatorType(FlatBufferBuilder builder, THandInHandInitiator initiatorType)
		{
			builder.AddByte(0, (byte)initiatorType, 0);
		}

		// Token: 0x0603160C RID: 202252 RVA: 0x006B2520 File Offset: 0x006B0720
		public static void AddInitiator(FlatBufferBuilder builder, int initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset, 0);
		}

		// Token: 0x0603160D RID: 202253 RVA: 0x006B252B File Offset: 0x006B072B
		public static void AddHandType(FlatBufferBuilder builder, EHandType handType)
		{
			builder.AddByte(2, (byte)handType, 0);
		}

		// Token: 0x0603160E RID: 202254 RVA: 0x006B2536 File Offset: 0x006B0736
		public static Offset<IHandInHandInitiator> EndIHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x0603160F RID: 202255 RVA: 0x006B2544 File Offset: 0x006B0744
		public IHandInHandInitiatorT UnPack()
		{
			IHandInHandInitiatorT handInHandInitiatorT = new IHandInHandInitiatorT();
			this.UnPackTo(handInHandInitiatorT);
			return handInHandInitiatorT;
		}

		// Token: 0x06031610 RID: 202256 RVA: 0x006B2560 File Offset: 0x006B0760
		public void UnPackTo(IHandInHandInitiatorT _o)
		{
			_o.Initiator = new THandInHandInitiatorUnion();
			_o.Initiator.Type = this.InitiatorType;
			THandInHandInitiator initiatorType = this.InitiatorType;
			if (initiatorType != THandInHandInitiator.IEntityHandInHandInitiator)
			{
				if (initiatorType == THandInHandInitiator.IPlayerHandInHandInitiator)
				{
					_o.Initiator.Value = ((this.Initiator<IPlayerHandInHandInitiator>() != null) ? this.Initiator<IPlayerHandInHandInitiator>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Initiator.Value = ((this.Initiator<IEntityHandInHandInitiator>() != null) ? this.Initiator<IEntityHandInHandInitiator>().Value.UnPack() : null);
			}
			_o.HandType = this.HandType;
		}

		// Token: 0x06031611 RID: 202257 RVA: 0x006B2614 File Offset: 0x006B0814
		public static Offset<IHandInHandInitiator> Pack(FlatBufferBuilder builder, IHandInHandInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInHandInitiator>);
			}
			THandInHandInitiator initiator_type = (_o.Initiator == null) ? THandInHandInitiator.NONE : _o.Initiator.Type;
			int initiatorOffset = (_o.Initiator == null) ? 0 : THandInHandInitiatorUnion.Pack(builder, _o.Initiator);
			return IHandInHandInitiator.CreateIHandInHandInitiator(builder, initiator_type, initiatorOffset, _o.HandType);
		}

		// Token: 0x04011E7F RID: 73343
		private Table __p;
	}
}
