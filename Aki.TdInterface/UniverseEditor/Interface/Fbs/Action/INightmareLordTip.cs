using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F2 RID: 29426
	public struct INightmareLordTip : IFlatbufferObject
	{
		// Token: 0x1700D7BB RID: 55227
		// (get) Token: 0x060334E1 RID: 210145 RVA: 0x006EB7E4 File Offset: 0x006E99E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334E2 RID: 210146 RVA: 0x006EB7F1 File Offset: 0x006E99F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334E3 RID: 210147 RVA: 0x006EB7F8 File Offset: 0x006E99F8
		public static INightmareLordTip GetRootAsINightmareLordTip(ByteBuffer _bb)
		{
			return INightmareLordTip.GetRootAsINightmareLordTip(_bb, default(INightmareLordTip));
		}

		// Token: 0x060334E4 RID: 210148 RVA: 0x006EB814 File Offset: 0x006E9A14
		public static INightmareLordTip GetRootAsINightmareLordTip(ByteBuffer _bb, INightmareLordTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334E5 RID: 210149 RVA: 0x006EB831 File Offset: 0x006E9A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334E6 RID: 210150 RVA: 0x006EB840 File Offset: 0x006E9A40
		public INightmareLordTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7BC RID: 55228
		// (get) Token: 0x060334E7 RID: 210151 RVA: 0x006EB850 File Offset: 0x006E9A50
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

		// Token: 0x1700D7BD RID: 55229
		// (get) Token: 0x060334E8 RID: 210152 RVA: 0x006EB88C File Offset: 0x006E9A8C
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

		// Token: 0x060334E9 RID: 210153 RVA: 0x006EB8C3 File Offset: 0x006E9AC3
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060334EA RID: 210154 RVA: 0x006EB8D2 File Offset: 0x006E9AD2
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D7BE RID: 55230
		// (get) Token: 0x060334EB RID: 210155 RVA: 0x006EB8E0 File Offset: 0x006E9AE0
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

		// Token: 0x060334EC RID: 210156 RVA: 0x006EB917 File Offset: 0x006E9B17
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060334ED RID: 210157 RVA: 0x006EB926 File Offset: 0x006E9B26
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060334EE RID: 210158 RVA: 0x006EB934 File Offset: 0x006E9B34
		public static Offset<INightmareLordTip> CreateINightmareLordTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			INightmareLordTip.AddTidSubText(builder, TidSubTextOffset);
			INightmareLordTip.AddTidMainText(builder, TidMainTextOffset);
			INightmareLordTip.AddType(builder, Type);
			return INightmareLordTip.EndINightmareLordTip(builder);
		}

		// Token: 0x060334EF RID: 210159 RVA: 0x006EB958 File Offset: 0x006E9B58
		public static void StartINightmareLordTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060334F0 RID: 210160 RVA: 0x006EB961 File Offset: 0x006E9B61
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060334F1 RID: 210161 RVA: 0x006EB96C File Offset: 0x006E9B6C
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x060334F2 RID: 210162 RVA: 0x006EB97C File Offset: 0x006E9B7C
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x060334F3 RID: 210163 RVA: 0x006EB98C File Offset: 0x006E9B8C
		public static Offset<INightmareLordTip> EndINightmareLordTip(FlatBufferBuilder builder)
		{
			return new Offset<INightmareLordTip>(builder.EndTable());
		}

		// Token: 0x060334F4 RID: 210164 RVA: 0x006EB99C File Offset: 0x006E9B9C
		public INightmareLordTipT UnPack()
		{
			INightmareLordTipT nightmareLordTipT = new INightmareLordTipT();
			this.UnPackTo(nightmareLordTipT);
			return nightmareLordTipT;
		}

		// Token: 0x060334F5 RID: 210165 RVA: 0x006EB9B7 File Offset: 0x006E9BB7
		public void UnPackTo(INightmareLordTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x060334F6 RID: 210166 RVA: 0x006EB9E0 File Offset: 0x006E9BE0
		public static Offset<INightmareLordTip> Pack(FlatBufferBuilder builder, INightmareLordTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareLordTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return INightmareLordTip.CreateINightmareLordTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x040123A8 RID: 74664
		private Table __p;
	}
}
