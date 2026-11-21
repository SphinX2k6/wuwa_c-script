using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007552 RID: 30034
	public struct IPunishReport : IFlatbufferObject
	{
		// Token: 0x1700DCE5 RID: 56549
		// (get) Token: 0x06034AA1 RID: 215713 RVA: 0x007159E1 File Offset: 0x00713BE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034AA2 RID: 215714 RVA: 0x007159EE File Offset: 0x00713BEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034AA3 RID: 215715 RVA: 0x007159F8 File Offset: 0x00713BF8
		public static IPunishReport GetRootAsIPunishReport(ByteBuffer _bb)
		{
			return IPunishReport.GetRootAsIPunishReport(_bb, default(IPunishReport));
		}

		// Token: 0x06034AA4 RID: 215716 RVA: 0x00715A14 File Offset: 0x00713C14
		public static IPunishReport GetRootAsIPunishReport(ByteBuffer _bb, IPunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034AA5 RID: 215717 RVA: 0x00715A31 File Offset: 0x00713C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034AA6 RID: 215718 RVA: 0x00715A40 File Offset: 0x00713C40
		public IPunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCE6 RID: 56550
		// (get) Token: 0x06034AA7 RID: 215719 RVA: 0x00715A50 File Offset: 0x00713C50
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

		// Token: 0x1700DCE7 RID: 56551
		// (get) Token: 0x06034AA8 RID: 215720 RVA: 0x00715A8C File Offset: 0x00713C8C
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

		// Token: 0x06034AA9 RID: 215721 RVA: 0x00715AC3 File Offset: 0x00713CC3
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034AAA RID: 215722 RVA: 0x00715AD2 File Offset: 0x00713CD2
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DCE8 RID: 56552
		// (get) Token: 0x06034AAB RID: 215723 RVA: 0x00715AE0 File Offset: 0x00713CE0
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

		// Token: 0x06034AAC RID: 215724 RVA: 0x00715B17 File Offset: 0x00713D17
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06034AAD RID: 215725 RVA: 0x00715B26 File Offset: 0x00713D26
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700DCE9 RID: 56553
		// (get) Token: 0x06034AAE RID: 215726 RVA: 0x00715B34 File Offset: 0x00713D34
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

		// Token: 0x1700DCEA RID: 56554
		// (get) Token: 0x06034AAF RID: 215727 RVA: 0x00715B74 File Offset: 0x00713D74
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

		// Token: 0x06034AB0 RID: 215728 RVA: 0x00715BB1 File Offset: 0x00713DB1
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

		// Token: 0x06034AB1 RID: 215729 RVA: 0x00715BE5 File Offset: 0x00713DE5
		public static void StartIPunishReport(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06034AB2 RID: 215730 RVA: 0x00715BEE File Offset: 0x00713DEE
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034AB3 RID: 215731 RVA: 0x00715BF9 File Offset: 0x00713DF9
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x06034AB4 RID: 215732 RVA: 0x00715C09 File Offset: 0x00713E09
		public static void AddSubText(FlatBufferBuilder builder, StringOffset subTextOffset)
		{
			builder.AddOffset(2, subTextOffset.Value, 0);
		}

		// Token: 0x06034AB5 RID: 215733 RVA: 0x00715C19 File Offset: 0x00713E19
		public static void AddShowType(FlatBufferBuilder builder, EPunishReportShowType showType)
		{
			builder.AddByte(3, (byte)showType, 0);
		}

		// Token: 0x06034AB6 RID: 215734 RVA: 0x00715C24 File Offset: 0x00713E24
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06034AB7 RID: 215735 RVA: 0x00715C2F File Offset: 0x00713E2F
		public static Offset<IPunishReport> EndIPunishReport(FlatBufferBuilder builder)
		{
			return new Offset<IPunishReport>(builder.EndTable());
		}

		// Token: 0x06034AB8 RID: 215736 RVA: 0x00715C3C File Offset: 0x00713E3C
		public IPunishReportT UnPack()
		{
			IPunishReportT punishReportT = new IPunishReportT();
			this.UnPackTo(punishReportT);
			return punishReportT;
		}

		// Token: 0x06034AB9 RID: 215737 RVA: 0x00715C57 File Offset: 0x00713E57
		public void UnPackTo(IPunishReportT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.SubText = this.SubText;
			_o.ShowType = this.ShowType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034ABA RID: 215738 RVA: 0x00715C98 File Offset: 0x00713E98
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

		// Token: 0x04012732 RID: 75570
		private Table __p;
	}
}
