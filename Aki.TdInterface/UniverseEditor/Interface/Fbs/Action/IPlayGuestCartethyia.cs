using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007492 RID: 29842
	public struct IPlayGuestCartethyia : IFlatbufferObject
	{
		// Token: 0x1700DB39 RID: 56121
		// (get) Token: 0x060343EA RID: 213994 RVA: 0x007094E4 File Offset: 0x007076E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060343EB RID: 213995 RVA: 0x007094F1 File Offset: 0x007076F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060343EC RID: 213996 RVA: 0x007094F8 File Offset: 0x007076F8
		public static IPlayGuestCartethyia GetRootAsIPlayGuestCartethyia(ByteBuffer _bb)
		{
			return IPlayGuestCartethyia.GetRootAsIPlayGuestCartethyia(_bb, default(IPlayGuestCartethyia));
		}

		// Token: 0x060343ED RID: 213997 RVA: 0x00709514 File Offset: 0x00707714
		public static IPlayGuestCartethyia GetRootAsIPlayGuestCartethyia(ByteBuffer _bb, IPlayGuestCartethyia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060343EE RID: 213998 RVA: 0x00709531 File Offset: 0x00707731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060343EF RID: 213999 RVA: 0x00709540 File Offset: 0x00707740
		public IPlayGuestCartethyia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB3A RID: 56122
		// (get) Token: 0x060343F0 RID: 214000 RVA: 0x00709550 File Offset: 0x00707750
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

		// Token: 0x060343F1 RID: 214001 RVA: 0x0070958C File Offset: 0x0070778C
		public static Offset<IPlayGuestCartethyia> CreateIPlayGuestCartethyia(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IPlayGuestCartethyia.AddType(builder, Type);
			return IPlayGuestCartethyia.EndIPlayGuestCartethyia(builder);
		}

		// Token: 0x060343F2 RID: 214002 RVA: 0x007095A2 File Offset: 0x007077A2
		public static void StartIPlayGuestCartethyia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060343F3 RID: 214003 RVA: 0x007095AB File Offset: 0x007077AB
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060343F4 RID: 214004 RVA: 0x007095B6 File Offset: 0x007077B6
		public static Offset<IPlayGuestCartethyia> EndIPlayGuestCartethyia(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestCartethyia>(builder.EndTable());
		}

		// Token: 0x060343F5 RID: 214005 RVA: 0x007095C4 File Offset: 0x007077C4
		public IPlayGuestCartethyiaT UnPack()
		{
			IPlayGuestCartethyiaT playGuestCartethyiaT = new IPlayGuestCartethyiaT();
			this.UnPackTo(playGuestCartethyiaT);
			return playGuestCartethyiaT;
		}

		// Token: 0x060343F6 RID: 214006 RVA: 0x007095DF File Offset: 0x007077DF
		public void UnPackTo(IPlayGuestCartethyiaT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060343F7 RID: 214007 RVA: 0x007095F0 File Offset: 0x007077F0
		public static Offset<IPlayGuestCartethyia> Pack(FlatBufferBuilder builder, IPlayGuestCartethyiaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestCartethyia>);
			}
			return IPlayGuestCartethyia.CreateIPlayGuestCartethyia(builder, _o.Type);
		}

		// Token: 0x0401260E RID: 75278
		private Table __p;
	}
}
