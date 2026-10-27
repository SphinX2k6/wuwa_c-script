using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200669F RID: 26271
	public struct IEndCommonTip : IFlatbufferObject
	{
		// Token: 0x1700C339 RID: 49977
		// (get) Token: 0x0602DA91 RID: 187025 RVA: 0x0063F9C5 File Offset: 0x0063DBC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA92 RID: 187026 RVA: 0x0063F9D2 File Offset: 0x0063DBD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA93 RID: 187027 RVA: 0x0063F9DC File Offset: 0x0063DBDC
		public static IEndCommonTip GetRootAsIEndCommonTip(ByteBuffer _bb)
		{
			return IEndCommonTip.GetRootAsIEndCommonTip(_bb, default(IEndCommonTip));
		}

		// Token: 0x0602DA94 RID: 187028 RVA: 0x0063F9F8 File Offset: 0x0063DBF8
		public static IEndCommonTip GetRootAsIEndCommonTip(ByteBuffer _bb, IEndCommonTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA95 RID: 187029 RVA: 0x0063FA15 File Offset: 0x0063DC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA96 RID: 187030 RVA: 0x0063FA24 File Offset: 0x0063DC24
		public IEndCommonTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C33A RID: 49978
		// (get) Token: 0x0602DA97 RID: 187031 RVA: 0x0063FA34 File Offset: 0x0063DC34
		public string Token
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DA98 RID: 187032 RVA: 0x0063FA6B File Offset: 0x0063DC6B
		public Span<byte> GetTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602DA99 RID: 187033 RVA: 0x0063FA7A File Offset: 0x0063DC7A
		public byte[] GetTokenArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602DA9A RID: 187034 RVA: 0x0063FA88 File Offset: 0x0063DC88
		public static Offset<IEndCommonTip> CreateIEndCommonTip(FlatBufferBuilder builder, StringOffset TokenOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IEndCommonTip.AddToken(builder, TokenOffset);
			return IEndCommonTip.EndIEndCommonTip(builder);
		}

		// Token: 0x0602DA9B RID: 187035 RVA: 0x0063FA9E File Offset: 0x0063DC9E
		public static void StartIEndCommonTip(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DA9C RID: 187036 RVA: 0x0063FAA7 File Offset: 0x0063DCA7
		public static void AddToken(FlatBufferBuilder builder, StringOffset tokenOffset)
		{
			builder.AddOffset(0, tokenOffset.Value, 0);
		}

		// Token: 0x0602DA9D RID: 187037 RVA: 0x0063FAB7 File Offset: 0x0063DCB7
		public static Offset<IEndCommonTip> EndIEndCommonTip(FlatBufferBuilder builder)
		{
			return new Offset<IEndCommonTip>(builder.EndTable());
		}

		// Token: 0x0602DA9E RID: 187038 RVA: 0x0063FAC4 File Offset: 0x0063DCC4
		public IEndCommonTipT UnPack()
		{
			IEndCommonTipT endCommonTipT = new IEndCommonTipT();
			this.UnPackTo(endCommonTipT);
			return endCommonTipT;
		}

		// Token: 0x0602DA9F RID: 187039 RVA: 0x0063FADF File Offset: 0x0063DCDF
		public void UnPackTo(IEndCommonTipT _o)
		{
			_o.Token = this.Token;
		}

		// Token: 0x0602DAA0 RID: 187040 RVA: 0x0063FAF0 File Offset: 0x0063DCF0
		public static Offset<IEndCommonTip> Pack(FlatBufferBuilder builder, IEndCommonTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEndCommonTip>);
			}
			StringOffset tokenOffset = (_o.Token == null) ? default(StringOffset) : builder.CreateString(_o.Token);
			return IEndCommonTip.CreateIEndCommonTip(builder, tokenOffset);
		}

		// Token: 0x04010D59 RID: 68953
		private Table __p;
	}
}
