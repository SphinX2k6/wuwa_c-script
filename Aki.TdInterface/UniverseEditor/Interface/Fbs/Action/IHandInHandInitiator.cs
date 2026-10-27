using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BE RID: 26814
	public struct IHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700C702 RID: 50946
		// (get) Token: 0x0602EC52 RID: 191570 RVA: 0x006622FA File Offset: 0x006604FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC53 RID: 191571 RVA: 0x00662307 File Offset: 0x00660507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC54 RID: 191572 RVA: 0x00662310 File Offset: 0x00660510
		public static IHandInHandInitiator GetRootAsIHandInHandInitiator(ByteBuffer _bb)
		{
			return IHandInHandInitiator.GetRootAsIHandInHandInitiator(_bb, default(IHandInHandInitiator));
		}

		// Token: 0x0602EC55 RID: 191573 RVA: 0x0066232C File Offset: 0x0066052C
		public static IHandInHandInitiator GetRootAsIHandInHandInitiator(ByteBuffer _bb, IHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC56 RID: 191574 RVA: 0x00662349 File Offset: 0x00660549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC57 RID: 191575 RVA: 0x00662358 File Offset: 0x00660558
		public IHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C703 RID: 50947
		// (get) Token: 0x0602EC58 RID: 191576 RVA: 0x00662368 File Offset: 0x00660568
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

		// Token: 0x0602EC59 RID: 191577 RVA: 0x006623A4 File Offset: 0x006605A4
		public TTable? Initiator<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EC5A RID: 191578 RVA: 0x006623E8 File Offset: 0x006605E8
		public IEntityHandInHandInitiator InitiatorAsIEntityHandInHandInitiator()
		{
			return this.Initiator<IEntityHandInHandInitiator>().Value;
		}

		// Token: 0x0602EC5B RID: 191579 RVA: 0x00662404 File Offset: 0x00660604
		public IPlayerHandInHandInitiator InitiatorAsIPlayerHandInHandInitiator()
		{
			return this.Initiator<IPlayerHandInHandInitiator>().Value;
		}

		// Token: 0x1700C704 RID: 50948
		// (get) Token: 0x0602EC5C RID: 191580 RVA: 0x00662420 File Offset: 0x00660620
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

		// Token: 0x0602EC5D RID: 191581 RVA: 0x0066245C File Offset: 0x0066065C
		public static Offset<IHandInHandInitiator> CreateIHandInHandInitiator(FlatBufferBuilder builder, THandInHandInitiator Initiator_type = THandInHandInitiator.NONE, int InitiatorOffset = 0, EHandType HandType = EHandType.Left)
		{
			builder.StartTable(3);
			IHandInHandInitiator.AddInitiator(builder, InitiatorOffset);
			IHandInHandInitiator.AddHandType(builder, HandType);
			IHandInHandInitiator.AddInitiatorType(builder, Initiator_type);
			return IHandInHandInitiator.EndIHandInHandInitiator(builder);
		}

		// Token: 0x0602EC5E RID: 191582 RVA: 0x00662480 File Offset: 0x00660680
		public static void StartIHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EC5F RID: 191583 RVA: 0x00662489 File Offset: 0x00660689
		public static void AddInitiatorType(FlatBufferBuilder builder, THandInHandInitiator initiatorType)
		{
			builder.AddByte(0, (byte)initiatorType, 0);
		}

		// Token: 0x0602EC60 RID: 191584 RVA: 0x00662494 File Offset: 0x00660694
		public static void AddInitiator(FlatBufferBuilder builder, int initiatorOffset)
		{
			builder.AddOffset(1, initiatorOffset, 0);
		}

		// Token: 0x0602EC61 RID: 191585 RVA: 0x0066249F File Offset: 0x0066069F
		public static void AddHandType(FlatBufferBuilder builder, EHandType handType)
		{
			builder.AddByte(2, (byte)handType, 0);
		}

		// Token: 0x0602EC62 RID: 191586 RVA: 0x006624AA File Offset: 0x006606AA
		public static Offset<IHandInHandInitiator> EndIHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x0602EC63 RID: 191587 RVA: 0x006624B8 File Offset: 0x006606B8
		public IHandInHandInitiatorT UnPack()
		{
			IHandInHandInitiatorT handInHandInitiatorT = new IHandInHandInitiatorT();
			this.UnPackTo(handInHandInitiatorT);
			return handInHandInitiatorT;
		}

		// Token: 0x0602EC64 RID: 191588 RVA: 0x006624D4 File Offset: 0x006606D4
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

		// Token: 0x0602EC65 RID: 191589 RVA: 0x00662588 File Offset: 0x00660788
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

		// Token: 0x04011019 RID: 69657
		private Table __p;
	}
}
