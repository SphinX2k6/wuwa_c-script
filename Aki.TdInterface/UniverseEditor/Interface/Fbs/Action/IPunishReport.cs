using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD7 RID: 28119
	public struct IPunishReport : IFlatbufferObject
	{
		// Token: 0x1700D19D RID: 53661
		// (get) Token: 0x06031AA5 RID: 203429 RVA: 0x006BA2F9 File Offset: 0x006B84F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AA6 RID: 203430 RVA: 0x006BA306 File Offset: 0x006B8506
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031AA7 RID: 203431 RVA: 0x006BA310 File Offset: 0x006B8510
		public static IPunishReport GetRootAsIPunishReport(ByteBuffer _bb)
		{
			return IPunishReport.GetRootAsIPunishReport(_bb, default(IPunishReport));
		}

		// Token: 0x06031AA8 RID: 203432 RVA: 0x006BA32C File Offset: 0x006B852C
		public static IPunishReport GetRootAsIPunishReport(ByteBuffer _bb, IPunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AA9 RID: 203433 RVA: 0x006BA349 File Offset: 0x006B8549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AAA RID: 203434 RVA: 0x006BA358 File Offset: 0x006B8558
		public IPunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D19E RID: 53662
		// (get) Token: 0x06031AAB RID: 203435 RVA: 0x006BA368 File Offset: 0x006B8568
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

		// Token: 0x1700D19F RID: 53663
		// (get) Token: 0x06031AAC RID: 203436 RVA: 0x006BA3A4 File Offset: 0x006B85A4
		public string MainText
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

		// Token: 0x06031AAD RID: 203437 RVA: 0x006BA3DB File Offset: 0x006B85DB
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031AAE RID: 203438 RVA: 0x006BA3EA File Offset: 0x006B85EA
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D1A0 RID: 53664
		// (get) Token: 0x06031AAF RID: 203439 RVA: 0x006BA3F8 File Offset: 0x006B85F8
		public string SubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031AB0 RID: 203440 RVA: 0x006BA42F File Offset: 0x006B862F
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031AB1 RID: 203441 RVA: 0x006BA43E File Offset: 0x006B863E
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D1A1 RID: 53665
		// (get) Token: 0x06031AB2 RID: 203442 RVA: 0x006BA44C File Offset: 0x006B864C
		public EPunishReportShowType ShowType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EPunishReportShowType.Default;
				}
				return (EPunishReportShowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D1A2 RID: 53666
		// (get) Token: 0x06031AB3 RID: 203443 RVA: 0x006BA48C File Offset: 0x006B868C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031AB4 RID: 203444 RVA: 0x006BA4C9 File Offset: 0x006B86C9
		public static Offset<IPunishReport> CreateIPunishReport(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset), StringOffset SubTextOffset = default(StringOffset), EPunishReportShowType ShowType = EPunishReportShowType.Default, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPunishReport.AddSubText(builder, SubTextOffset);
			IPunishReport.AddMainText(builder, MainTextOffset);
			IPunishReport.AddNullMask(builder, NullMask);
			IPunishReport.AddShowType(builder, ShowType);
			IPunishReport.AddType(builder, Type);
			return IPunishReport.EndIPunishReport(builder);
		}

		// Token: 0x06031AB5 RID: 203445 RVA: 0x006BA4FD File Offset: 0x006B86FD
		public static void StartIPunishReport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031AB6 RID: 203446 RVA: 0x006BA506 File Offset: 0x006B8706
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AB7 RID: 203447 RVA: 0x006BA511 File Offset: 0x006B8711
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x06031AB8 RID: 203448 RVA: 0x006BA521 File Offset: 0x006B8721
		public static void AddSubText(FlatBufferBuilder builder, StringOffset subTextOffset)
		{
			builder.AddOffset(2, subTextOffset.Value, 0);
		}

		// Token: 0x06031AB9 RID: 203449 RVA: 0x006BA531 File Offset: 0x006B8731
		public static void AddShowType(FlatBufferBuilder builder, EPunishReportShowType showType)
		{
			builder.AddByte(3, (byte)showType, 0);
		}

		// Token: 0x06031ABA RID: 203450 RVA: 0x006BA53C File Offset: 0x006B873C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031ABB RID: 203451 RVA: 0x006BA547 File Offset: 0x006B8747
		public static Offset<IPunishReport> EndIPunishReport(FlatBufferBuilder builder)
		{
			return new Offset<IPunishReport>(builder.EndTable());
		}

		// Token: 0x06031ABC RID: 203452 RVA: 0x006BA554 File Offset: 0x006B8754
		public IPunishReportT UnPack()
		{
			IPunishReportT punishReportT = new IPunishReportT();
			this.UnPackTo(punishReportT);
			return punishReportT;
		}

		// Token: 0x06031ABD RID: 203453 RVA: 0x006BA56F File Offset: 0x006B876F
		public void UnPackTo(IPunishReportT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.SubText = this.SubText;
			_o.ShowType = this.ShowType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031ABE RID: 203454 RVA: 0x006BA5B0 File Offset: 0x006B87B0
		public static Offset<IPunishReport> Pack(FlatBufferBuilder builder, IPunishReportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPunishReport>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			StringOffset subTextOffset = (_o.SubText == null) ? default(StringOffset) : builder.CreateString(_o.SubText);
			return IPunishReport.CreateIPunishReport(builder, _o.Type, mainTextOffset, subTextOffset, _o.ShowType, _o.NullMask);
		}

		// Token: 0x040117B6 RID: 71606
		private Table __p;
	}
}
