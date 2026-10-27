using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9C RID: 15004
	public struct IGlobalVarRef : IFlatbufferObject
	{
		// Token: 0x170066C8 RID: 26312
		// (get) Token: 0x060145CC RID: 83404 RVA: 0x002F86A3 File Offset: 0x002F68A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060145CD RID: 83405 RVA: 0x002F86B0 File Offset: 0x002F68B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060145CE RID: 83406 RVA: 0x002F86B8 File Offset: 0x002F68B8
		public static IGlobalVarRef GetRootAsIGlobalVarRef(ByteBuffer _bb)
		{
			return IGlobalVarRef.GetRootAsIGlobalVarRef(_bb, default(IGlobalVarRef));
		}

		// Token: 0x060145CF RID: 83407 RVA: 0x002F86D4 File Offset: 0x002F68D4
		public static IGlobalVarRef GetRootAsIGlobalVarRef(ByteBuffer _bb, IGlobalVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060145D0 RID: 83408 RVA: 0x002F86F1 File Offset: 0x002F68F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060145D1 RID: 83409 RVA: 0x002F8700 File Offset: 0x002F6900
		public IGlobalVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x060145D2 RID: 83410 RVA: 0x002F8710 File Offset: 0x002F6910
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

		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x060145D3 RID: 83411 RVA: 0x002F874C File Offset: 0x002F694C
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

		// Token: 0x170066CB RID: 26315
		// (get) Token: 0x060145D4 RID: 83412 RVA: 0x002F8788 File Offset: 0x002F6988
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

		// Token: 0x060145D5 RID: 83413 RVA: 0x002F87BF File Offset: 0x002F69BF
		public Span<byte> GetKeywordBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060145D6 RID: 83414 RVA: 0x002F87CE File Offset: 0x002F69CE
		public byte[] GetKeywordArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060145D7 RID: 83415 RVA: 0x002F87DC File Offset: 0x002F69DC
		public static Offset<IGlobalVarRef> CreateIGlobalVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, StringOffset KeywordOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IGlobalVarRef.AddKeyword(builder, KeywordOffset);
			IGlobalVarRef.AddSource(builder, Source);
			IGlobalVarRef.AddType(builder, Type);
			return IGlobalVarRef.EndIGlobalVarRef(builder);
		}

		// Token: 0x060145D8 RID: 83416 RVA: 0x002F8800 File Offset: 0x002F6A00
		public static void StartIGlobalVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060145D9 RID: 83417 RVA: 0x002F8809 File Offset: 0x002F6A09
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060145DA RID: 83418 RVA: 0x002F8814 File Offset: 0x002F6A14
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x060145DB RID: 83419 RVA: 0x002F881F File Offset: 0x002F6A1F
		public static void AddKeyword(FlatBufferBuilder builder, StringOffset keywordOffset)
		{
			builder.AddOffset(2, keywordOffset.Value, 0);
		}

		// Token: 0x060145DC RID: 83420 RVA: 0x002F882F File Offset: 0x002F6A2F
		public static Offset<IGlobalVarRef> EndIGlobalVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalVarRef>(builder.EndTable());
		}

		// Token: 0x060145DD RID: 83421 RVA: 0x002F883C File Offset: 0x002F6A3C
		public IGlobalVarRefT UnPack()
		{
			IGlobalVarRefT globalVarRefT = new IGlobalVarRefT();
			this.UnPackTo(globalVarRefT);
			return globalVarRefT;
		}

		// Token: 0x060145DE RID: 83422 RVA: 0x002F8857 File Offset: 0x002F6A57
		public void UnPackTo(IGlobalVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Keyword = this.Keyword;
		}

		// Token: 0x060145DF RID: 83423 RVA: 0x002F8880 File Offset: 0x002F6A80
		public static Offset<IGlobalVarRef> Pack(FlatBufferBuilder builder, IGlobalVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalVarRef>);
			}
			StringOffset keywordOffset = (_o.Keyword == null) ? default(StringOffset) : builder.CreateString(_o.Keyword);
			return IGlobalVarRef.CreateIGlobalVarRef(builder, _o.Type, _o.Source, keywordOffset);
		}

		// Token: 0x0400AF1B RID: 44827
		private Table __p;
	}
}
