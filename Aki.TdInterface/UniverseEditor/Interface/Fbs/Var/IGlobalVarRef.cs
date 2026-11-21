using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9E RID: 16030
	public struct IGlobalVarRef : IFlatbufferObject
	{
		// Token: 0x17006C63 RID: 27747
		// (get) Token: 0x06015A72 RID: 88690 RVA: 0x0031E8AF File Offset: 0x0031CAAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A73 RID: 88691 RVA: 0x0031E8BC File Offset: 0x0031CABC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A74 RID: 88692 RVA: 0x0031E8C4 File Offset: 0x0031CAC4
		public static IGlobalVarRef GetRootAsIGlobalVarRef(ByteBuffer _bb)
		{
			return IGlobalVarRef.GetRootAsIGlobalVarRef(_bb, default(IGlobalVarRef));
		}

		// Token: 0x06015A75 RID: 88693 RVA: 0x0031E8E0 File Offset: 0x0031CAE0
		public static IGlobalVarRef GetRootAsIGlobalVarRef(ByteBuffer _bb, IGlobalVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A76 RID: 88694 RVA: 0x0031E8FD File Offset: 0x0031CAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A77 RID: 88695 RVA: 0x0031E90C File Offset: 0x0031CB0C
		public IGlobalVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C64 RID: 27748
		// (get) Token: 0x06015A78 RID: 88696 RVA: 0x0031E91C File Offset: 0x0031CB1C
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C65 RID: 27749
		// (get) Token: 0x06015A79 RID: 88697 RVA: 0x0031E958 File Offset: 0x0031CB58
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C66 RID: 27750
		// (get) Token: 0x06015A7A RID: 88698 RVA: 0x0031E994 File Offset: 0x0031CB94
		public string Keyword
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

		// Token: 0x06015A7B RID: 88699 RVA: 0x0031E9CB File Offset: 0x0031CBCB
		public Span<byte> GetKeywordBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015A7C RID: 88700 RVA: 0x0031E9DA File Offset: 0x0031CBDA
		public byte[] GetKeywordArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06015A7D RID: 88701 RVA: 0x0031E9E8 File Offset: 0x0031CBE8
		public static Offset<IGlobalVarRef> CreateIGlobalVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, StringOffset KeywordOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGlobalVarRef.AddKeyword(builder, KeywordOffset);
			IGlobalVarRef.AddSource(builder, Source);
			IGlobalVarRef.AddType(builder, Type);
			return IGlobalVarRef.EndIGlobalVarRef(builder);
		}

		// Token: 0x06015A7E RID: 88702 RVA: 0x0031EA0C File Offset: 0x0031CC0C
		public static void StartIGlobalVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015A7F RID: 88703 RVA: 0x0031EA15 File Offset: 0x0031CC15
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A80 RID: 88704 RVA: 0x0031EA20 File Offset: 0x0031CC20
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015A81 RID: 88705 RVA: 0x0031EA2B File Offset: 0x0031CC2B
		public static void AddKeyword(FlatBufferBuilder builder, StringOffset keywordOffset)
		{
			builder.AddOffset(2, keywordOffset.Value, 0);
		}

		// Token: 0x06015A82 RID: 88706 RVA: 0x0031EA3B File Offset: 0x0031CC3B
		public static Offset<IGlobalVarRef> EndIGlobalVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalVarRef>(builder.EndTable());
		}

		// Token: 0x06015A83 RID: 88707 RVA: 0x0031EA48 File Offset: 0x0031CC48
		public IGlobalVarRefT UnPack()
		{
			IGlobalVarRefT globalVarRefT = new IGlobalVarRefT();
			this.UnPackTo(globalVarRefT);
			return globalVarRefT;
		}

		// Token: 0x06015A84 RID: 88708 RVA: 0x0031EA63 File Offset: 0x0031CC63
		public void UnPackTo(IGlobalVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Keyword = this.Keyword;
		}

		// Token: 0x06015A85 RID: 88709 RVA: 0x0031EA8C File Offset: 0x0031CC8C
		public static Offset<IGlobalVarRef> Pack(FlatBufferBuilder builder, IGlobalVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalVarRef>);
			}
			StringOffset keywordOffset = (_o.Keyword == null) ? default(StringOffset) : builder.CreateString(_o.Keyword);
			return IGlobalVarRef.CreateIGlobalVarRef(builder, _o.Type, _o.Source, keywordOffset);
		}

		// Token: 0x0400B886 RID: 47238
		private Table __p;
	}
}
