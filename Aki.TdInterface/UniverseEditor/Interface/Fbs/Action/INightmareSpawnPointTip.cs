using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F5 RID: 29429
	public struct INightmareSpawnPointTip : IFlatbufferObject
	{
		// Token: 0x1700D7C2 RID: 55234
		// (get) Token: 0x060334FF RID: 210175 RVA: 0x006EBAD1 File Offset: 0x006E9CD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033500 RID: 210176 RVA: 0x006EBADE File Offset: 0x006E9CDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033501 RID: 210177 RVA: 0x006EBAE8 File Offset: 0x006E9CE8
		public static INightmareSpawnPointTip GetRootAsINightmareSpawnPointTip(ByteBuffer _bb)
		{
			return INightmareSpawnPointTip.GetRootAsINightmareSpawnPointTip(_bb, default(INightmareSpawnPointTip));
		}

		// Token: 0x06033502 RID: 210178 RVA: 0x006EBB04 File Offset: 0x006E9D04
		public static INightmareSpawnPointTip GetRootAsINightmareSpawnPointTip(ByteBuffer _bb, INightmareSpawnPointTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033503 RID: 210179 RVA: 0x006EBB21 File Offset: 0x006E9D21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033504 RID: 210180 RVA: 0x006EBB30 File Offset: 0x006E9D30
		public INightmareSpawnPointTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7C3 RID: 55235
		// (get) Token: 0x06033505 RID: 210181 RVA: 0x006EBB40 File Offset: 0x006E9D40
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

		// Token: 0x1700D7C4 RID: 55236
		// (get) Token: 0x06033506 RID: 210182 RVA: 0x006EBB7C File Offset: 0x006E9D7C
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

		// Token: 0x06033507 RID: 210183 RVA: 0x006EBBB3 File Offset: 0x006E9DB3
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033508 RID: 210184 RVA: 0x006EBBC2 File Offset: 0x006E9DC2
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D7C5 RID: 55237
		// (get) Token: 0x06033509 RID: 210185 RVA: 0x006EBBD0 File Offset: 0x006E9DD0
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

		// Token: 0x0603350A RID: 210186 RVA: 0x006EBC07 File Offset: 0x006E9E07
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603350B RID: 210187 RVA: 0x006EBC16 File Offset: 0x006E9E16
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603350C RID: 210188 RVA: 0x006EBC24 File Offset: 0x006E9E24
		public static Offset<INightmareSpawnPointTip> CreateINightmareSpawnPointTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			INightmareSpawnPointTip.AddTidSubText(builder, TidSubTextOffset);
			INightmareSpawnPointTip.AddTidMainText(builder, TidMainTextOffset);
			INightmareSpawnPointTip.AddType(builder, Type);
			return INightmareSpawnPointTip.EndINightmareSpawnPointTip(builder);
		}

		// Token: 0x0603350D RID: 210189 RVA: 0x006EBC48 File Offset: 0x006E9E48
		public static void StartINightmareSpawnPointTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603350E RID: 210190 RVA: 0x006EBC51 File Offset: 0x006E9E51
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603350F RID: 210191 RVA: 0x006EBC5C File Offset: 0x006E9E5C
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06033510 RID: 210192 RVA: 0x006EBC6C File Offset: 0x006E9E6C
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06033511 RID: 210193 RVA: 0x006EBC7C File Offset: 0x006E9E7C
		public static Offset<INightmareSpawnPointTip> EndINightmareSpawnPointTip(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSpawnPointTip>(builder.EndTable());
		}

		// Token: 0x06033512 RID: 210194 RVA: 0x006EBC8C File Offset: 0x006E9E8C
		public INightmareSpawnPointTipT UnPack()
		{
			INightmareSpawnPointTipT nightmareSpawnPointTipT = new INightmareSpawnPointTipT();
			this.UnPackTo(nightmareSpawnPointTipT);
			return nightmareSpawnPointTipT;
		}

		// Token: 0x06033513 RID: 210195 RVA: 0x006EBCA7 File Offset: 0x006E9EA7
		public void UnPackTo(INightmareSpawnPointTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x06033514 RID: 210196 RVA: 0x006EBCD0 File Offset: 0x006E9ED0
		public static Offset<INightmareSpawnPointTip> Pack(FlatBufferBuilder builder, INightmareSpawnPointTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareSpawnPointTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return INightmareSpawnPointTip.CreateINightmareSpawnPointTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x040123AC RID: 74668
		private Table __p;
	}
}
