using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007905 RID: 30981
	public struct ISlashAndTowerTip : IFlatbufferObject
	{
		// Token: 0x1700E344 RID: 58180
		// (get) Token: 0x060368C4 RID: 223428 RVA: 0x0074D34A File Offset: 0x0074B54A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368C5 RID: 223429 RVA: 0x0074D357 File Offset: 0x0074B557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368C6 RID: 223430 RVA: 0x0074D360 File Offset: 0x0074B560
		public static ISlashAndTowerTip GetRootAsISlashAndTowerTip(ByteBuffer _bb)
		{
			return ISlashAndTowerTip.GetRootAsISlashAndTowerTip(_bb, default(ISlashAndTowerTip));
		}

		// Token: 0x060368C7 RID: 223431 RVA: 0x0074D37C File Offset: 0x0074B57C
		public static ISlashAndTowerTip GetRootAsISlashAndTowerTip(ByteBuffer _bb, ISlashAndTowerTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368C8 RID: 223432 RVA: 0x0074D399 File Offset: 0x0074B599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368C9 RID: 223433 RVA: 0x0074D3A8 File Offset: 0x0074B5A8
		public ISlashAndTowerTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E345 RID: 58181
		// (get) Token: 0x060368CA RID: 223434 RVA: 0x0074D3B8 File Offset: 0x0074B5B8
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E346 RID: 58182
		// (get) Token: 0x060368CB RID: 223435 RVA: 0x0074D3F4 File Offset: 0x0074B5F4
		public string WarningText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060368CC RID: 223436 RVA: 0x0074D42B File Offset: 0x0074B62B
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060368CD RID: 223437 RVA: 0x0074D43A File Offset: 0x0074B63A
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060368CE RID: 223438 RVA: 0x0074D448 File Offset: 0x0074B648
		public static Offset<ISlashAndTowerTip> CreateISlashAndTowerTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlashAndTowerTip.AddWarningText(builder, WarningTextOffset);
			ISlashAndTowerTip.AddType(builder, Type);
			return ISlashAndTowerTip.EndISlashAndTowerTip(builder);
		}

		// Token: 0x060368CF RID: 223439 RVA: 0x0074D465 File Offset: 0x0074B665
		public static void StartISlashAndTowerTip(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060368D0 RID: 223440 RVA: 0x0074D46E File Offset: 0x0074B66E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060368D1 RID: 223441 RVA: 0x0074D479 File Offset: 0x0074B679
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x060368D2 RID: 223442 RVA: 0x0074D489 File Offset: 0x0074B689
		public static Offset<ISlashAndTowerTip> EndISlashAndTowerTip(FlatBufferBuilder builder)
		{
			return new Offset<ISlashAndTowerTip>(builder.EndTable());
		}

		// Token: 0x060368D3 RID: 223443 RVA: 0x0074D498 File Offset: 0x0074B698
		public ISlashAndTowerTipT UnPack()
		{
			ISlashAndTowerTipT slashAndTowerTipT = new ISlashAndTowerTipT();
			this.UnPackTo(slashAndTowerTipT);
			return slashAndTowerTipT;
		}

		// Token: 0x060368D4 RID: 223444 RVA: 0x0074D4B3 File Offset: 0x0074B6B3
		public void UnPackTo(ISlashAndTowerTipT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x060368D5 RID: 223445 RVA: 0x0074D4D0 File Offset: 0x0074B6D0
		public static Offset<ISlashAndTowerTip> Pack(FlatBufferBuilder builder, ISlashAndTowerTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashAndTowerTip>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return ISlashAndTowerTip.CreateISlashAndTowerTip(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04012BC2 RID: 76738
		private Table __p;
	}
}
