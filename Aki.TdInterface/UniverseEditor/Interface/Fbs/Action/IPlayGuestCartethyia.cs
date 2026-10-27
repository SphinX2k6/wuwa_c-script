using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D17 RID: 27927
	public struct IPlayGuestCartethyia : IFlatbufferObject
	{
		// Token: 0x1700CFF3 RID: 53235
		// (get) Token: 0x060313F2 RID: 201714 RVA: 0x006ADEA0 File Offset: 0x006AC0A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313F3 RID: 201715 RVA: 0x006ADEAD File Offset: 0x006AC0AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313F4 RID: 201716 RVA: 0x006ADEB4 File Offset: 0x006AC0B4
		public static IPlayGuestCartethyia GetRootAsIPlayGuestCartethyia(ByteBuffer _bb)
		{
			return IPlayGuestCartethyia.GetRootAsIPlayGuestCartethyia(_bb, default(IPlayGuestCartethyia));
		}

		// Token: 0x060313F5 RID: 201717 RVA: 0x006ADED0 File Offset: 0x006AC0D0
		public static IPlayGuestCartethyia GetRootAsIPlayGuestCartethyia(ByteBuffer _bb, IPlayGuestCartethyia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313F6 RID: 201718 RVA: 0x006ADEED File Offset: 0x006AC0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313F7 RID: 201719 RVA: 0x006ADEFC File Offset: 0x006AC0FC
		public IPlayGuestCartethyia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFF4 RID: 53236
		// (get) Token: 0x060313F8 RID: 201720 RVA: 0x006ADF0C File Offset: 0x006AC10C
		public EGuestUiAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return (EGuestUiAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060313F9 RID: 201721 RVA: 0x006ADF48 File Offset: 0x006AC148
		public static Offset<IPlayGuestCartethyia> CreateIPlayGuestCartethyia(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IPlayGuestCartethyia.AddType(builder, Type);
			return IPlayGuestCartethyia.EndIPlayGuestCartethyia(builder);
		}

		// Token: 0x060313FA RID: 201722 RVA: 0x006ADF5E File Offset: 0x006AC15E
		public static void StartIPlayGuestCartethyia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313FB RID: 201723 RVA: 0x006ADF67 File Offset: 0x006AC167
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313FC RID: 201724 RVA: 0x006ADF72 File Offset: 0x006AC172
		public static Offset<IPlayGuestCartethyia> EndIPlayGuestCartethyia(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestCartethyia>(builder.EndTable());
		}

		// Token: 0x060313FD RID: 201725 RVA: 0x006ADF80 File Offset: 0x006AC180
		public IPlayGuestCartethyiaT UnPack()
		{
			IPlayGuestCartethyiaT playGuestCartethyiaT = new IPlayGuestCartethyiaT();
			this.UnPackTo(playGuestCartethyiaT);
			return playGuestCartethyiaT;
		}

		// Token: 0x060313FE RID: 201726 RVA: 0x006ADF9B File Offset: 0x006AC19B
		public void UnPackTo(IPlayGuestCartethyiaT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313FF RID: 201727 RVA: 0x006ADFAC File Offset: 0x006AC1AC
		public static Offset<IPlayGuestCartethyia> Pack(FlatBufferBuilder builder, IPlayGuestCartethyiaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestCartethyia>);
			}
			return IPlayGuestCartethyia.CreateIPlayGuestCartethyia(builder, _o.Type);
		}

		// Token: 0x04011693 RID: 71315
		private Table __p;
	}
}
