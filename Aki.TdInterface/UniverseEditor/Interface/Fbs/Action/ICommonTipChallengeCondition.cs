using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF7 RID: 27383
	public struct ICommonTipChallengeCondition : IFlatbufferObject
	{
		// Token: 0x1700C91A RID: 51482
		// (get) Token: 0x0602F12A RID: 192810 RVA: 0x0066BE66 File Offset: 0x0066A066
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F12B RID: 192811 RVA: 0x0066BE73 File Offset: 0x0066A073
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F12C RID: 192812 RVA: 0x0066BE7C File Offset: 0x0066A07C
		public static ICommonTipChallengeCondition GetRootAsICommonTipChallengeCondition(ByteBuffer _bb)
		{
			return ICommonTipChallengeCondition.GetRootAsICommonTipChallengeCondition(_bb, default(ICommonTipChallengeCondition));
		}

		// Token: 0x0602F12D RID: 192813 RVA: 0x0066BE98 File Offset: 0x0066A098
		public static ICommonTipChallengeCondition GetRootAsICommonTipChallengeCondition(ByteBuffer _bb, ICommonTipChallengeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F12E RID: 192814 RVA: 0x0066BEB5 File Offset: 0x0066A0B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F12F RID: 192815 RVA: 0x0066BEC4 File Offset: 0x0066A0C4
		public ICommonTipChallengeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C91B RID: 51483
		// (get) Token: 0x0602F130 RID: 192816 RVA: 0x0066BED4 File Offset: 0x0066A0D4
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

		// Token: 0x1700C91C RID: 51484
		// (get) Token: 0x0602F131 RID: 192817 RVA: 0x0066BF10 File Offset: 0x0066A110
		public string TidMainText
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

		// Token: 0x0602F132 RID: 192818 RVA: 0x0066BF47 File Offset: 0x0066A147
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F133 RID: 192819 RVA: 0x0066BF56 File Offset: 0x0066A156
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C91D RID: 51485
		// (get) Token: 0x0602F134 RID: 192820 RVA: 0x0066BF64 File Offset: 0x0066A164
		public string TidSubText
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

		// Token: 0x0602F135 RID: 192821 RVA: 0x0066BF9B File Offset: 0x0066A19B
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F136 RID: 192822 RVA: 0x0066BFAA File Offset: 0x0066A1AA
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F137 RID: 192823 RVA: 0x0066BFB8 File Offset: 0x0066A1B8
		public static Offset<ICommonTipChallengeCondition> CreateICommonTipChallengeCondition(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipChallengeCondition.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipChallengeCondition.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeCondition.AddType(builder, Type);
			return ICommonTipChallengeCondition.EndICommonTipChallengeCondition(builder);
		}

		// Token: 0x0602F138 RID: 192824 RVA: 0x0066BFDC File Offset: 0x0066A1DC
		public static void StartICommonTipChallengeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F139 RID: 192825 RVA: 0x0066BFE5 File Offset: 0x0066A1E5
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F13A RID: 192826 RVA: 0x0066BFF0 File Offset: 0x0066A1F0
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F13B RID: 192827 RVA: 0x0066C000 File Offset: 0x0066A200
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602F13C RID: 192828 RVA: 0x0066C010 File Offset: 0x0066A210
		public static Offset<ICommonTipChallengeCondition> EndICommonTipChallengeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeCondition>(builder.EndTable());
		}

		// Token: 0x0602F13D RID: 192829 RVA: 0x0066C020 File Offset: 0x0066A220
		public ICommonTipChallengeConditionT UnPack()
		{
			ICommonTipChallengeConditionT commonTipChallengeConditionT = new ICommonTipChallengeConditionT();
			this.UnPackTo(commonTipChallengeConditionT);
			return commonTipChallengeConditionT;
		}

		// Token: 0x0602F13E RID: 192830 RVA: 0x0066C03B File Offset: 0x0066A23B
		public void UnPackTo(ICommonTipChallengeConditionT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602F13F RID: 192831 RVA: 0x0066C064 File Offset: 0x0066A264
		public static Offset<ICommonTipChallengeCondition> Pack(FlatBufferBuilder builder, ICommonTipChallengeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeCondition>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipChallengeCondition.CreateICommonTipChallengeCondition(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x040118A9 RID: 71849
		private Table __p;
	}
}
