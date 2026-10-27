using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BA RID: 29882
	public struct IUniversalTone : IFlatbufferObject
	{
		// Token: 0x1700E2D2 RID: 58066
		// (get) Token: 0x0603653C RID: 222524 RVA: 0x007621FA File Offset: 0x007603FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603653D RID: 222525 RVA: 0x00762207 File Offset: 0x00760407
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603653E RID: 222526 RVA: 0x00762210 File Offset: 0x00760410
		public static IUniversalTone GetRootAsIUniversalTone(ByteBuffer _bb)
		{
			return IUniversalTone.GetRootAsIUniversalTone(_bb, default(IUniversalTone));
		}

		// Token: 0x0603653F RID: 222527 RVA: 0x0076222C File Offset: 0x0076042C
		public static IUniversalTone GetRootAsIUniversalTone(ByteBuffer _bb, IUniversalTone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036540 RID: 222528 RVA: 0x00762249 File Offset: 0x00760449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036541 RID: 222529 RVA: 0x00762258 File Offset: 0x00760458
		public IUniversalTone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2D3 RID: 58067
		// (get) Token: 0x06036542 RID: 222530 RVA: 0x00762268 File Offset: 0x00760468
		public int UniversalToneId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E2D4 RID: 58068
		// (get) Token: 0x06036543 RID: 222531 RVA: 0x007622A4 File Offset: 0x007604A4
		public int TimberId
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

		// Token: 0x1700E2D5 RID: 58069
		// (get) Token: 0x06036544 RID: 222532 RVA: 0x007622E0 File Offset: 0x007604E0
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

		// Token: 0x06036545 RID: 222533 RVA: 0x0076231C File Offset: 0x0076051C
		public static Offset<IUniversalTone> CreateIUniversalTone(FlatBufferBuilder builder, int UniversalToneId = 0, int TimberId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IUniversalTone.AddTimberId(builder, TimberId);
			IUniversalTone.AddUniversalToneId(builder, UniversalToneId);
			IUniversalTone.AddNullMask(builder, NullMask);
			return IUniversalTone.EndIUniversalTone(builder);
		}

		// Token: 0x06036546 RID: 222534 RVA: 0x00762340 File Offset: 0x00760540
		public static void StartIUniversalTone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036547 RID: 222535 RVA: 0x00762349 File Offset: 0x00760549
		public static void AddUniversalToneId(FlatBufferBuilder builder, int universalToneId)
		{
			builder.AddInt(0, universalToneId, 0);
		}

		// Token: 0x06036548 RID: 222536 RVA: 0x00762354 File Offset: 0x00760554
		public static void AddTimberId(FlatBufferBuilder builder, int timberId)
		{
			builder.AddInt(1, timberId, 0);
		}

		// Token: 0x06036549 RID: 222537 RVA: 0x0076235F File Offset: 0x0076055F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603654A RID: 222538 RVA: 0x0076236A File Offset: 0x0076056A
		public static Offset<IUniversalTone> EndIUniversalTone(FlatBufferBuilder builder)
		{
			return new Offset<IUniversalTone>(builder.EndTable());
		}

		// Token: 0x0603654B RID: 222539 RVA: 0x00762378 File Offset: 0x00760578
		public IUniversalToneT UnPack()
		{
			IUniversalToneT universalToneT = new IUniversalToneT();
			this.UnPackTo(universalToneT);
			return universalToneT;
		}

		// Token: 0x0603654C RID: 222540 RVA: 0x00762393 File Offset: 0x00760593
		public void UnPackTo(IUniversalToneT _o)
		{
			_o.UniversalToneId = this.UniversalToneId;
			_o.TimberId = this.TimberId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603654D RID: 222541 RVA: 0x007623BC File Offset: 0x007605BC
		public static Offset<IUniversalTone> Pack(FlatBufferBuilder builder, IUniversalToneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUniversalTone>);
			}
			return IUniversalTone.CreateIUniversalTone(builder, _o.UniversalToneId, _o.TimberId, _o.NullMask);
		}

		// Token: 0x04012383 RID: 74627
		private Table __p;
	}
}
