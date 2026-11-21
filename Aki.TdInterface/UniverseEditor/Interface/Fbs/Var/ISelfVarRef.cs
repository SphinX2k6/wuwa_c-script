using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED1 RID: 16081
	public struct ISelfVarRef : IFlatbufferObject
	{
		// Token: 0x17006CE0 RID: 27872
		// (get) Token: 0x06015C53 RID: 89171 RVA: 0x00321EBA File Offset: 0x003200BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C54 RID: 89172 RVA: 0x00321EC7 File Offset: 0x003200C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C55 RID: 89173 RVA: 0x00321ED0 File Offset: 0x003200D0
		public static ISelfVarRef GetRootAsISelfVarRef(ByteBuffer _bb)
		{
			return ISelfVarRef.GetRootAsISelfVarRef(_bb, default(ISelfVarRef));
		}

		// Token: 0x06015C56 RID: 89174 RVA: 0x00321EEC File Offset: 0x003200EC
		public static ISelfVarRef GetRootAsISelfVarRef(ByteBuffer _bb, ISelfVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C57 RID: 89175 RVA: 0x00321F09 File Offset: 0x00320109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C58 RID: 89176 RVA: 0x00321F18 File Offset: 0x00320118
		public ISelfVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CE1 RID: 27873
		// (get) Token: 0x06015C59 RID: 89177 RVA: 0x00321F28 File Offset: 0x00320128
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

		// Token: 0x17006CE2 RID: 27874
		// (get) Token: 0x06015C5A RID: 89178 RVA: 0x00321F64 File Offset: 0x00320164
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

		// Token: 0x17006CE3 RID: 27875
		// (get) Token: 0x06015C5B RID: 89179 RVA: 0x00321FA0 File Offset: 0x003201A0
		public string Name
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

		// Token: 0x06015C5C RID: 89180 RVA: 0x00321FD7 File Offset: 0x003201D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06015C5D RID: 89181 RVA: 0x00321FE6 File Offset: 0x003201E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06015C5E RID: 89182 RVA: 0x00321FF4 File Offset: 0x003201F4
		public static Offset<ISelfVarRef> CreateISelfVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ISelfVarRef.AddName(builder, NameOffset);
			ISelfVarRef.AddSource(builder, Source);
			ISelfVarRef.AddType(builder, Type);
			return ISelfVarRef.EndISelfVarRef(builder);
		}

		// Token: 0x06015C5F RID: 89183 RVA: 0x00322018 File Offset: 0x00320218
		public static void StartISelfVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015C60 RID: 89184 RVA: 0x00322021 File Offset: 0x00320221
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C61 RID: 89185 RVA: 0x0032202C File Offset: 0x0032022C
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015C62 RID: 89186 RVA: 0x00322037 File Offset: 0x00320237
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x06015C63 RID: 89187 RVA: 0x00322047 File Offset: 0x00320247
		public static Offset<ISelfVarRef> EndISelfVarRef(FlatBufferBuilder builder)
		{
			return new Offset<ISelfVarRef>(builder.EndTable());
		}

		// Token: 0x06015C64 RID: 89188 RVA: 0x00322054 File Offset: 0x00320254
		public ISelfVarRefT UnPack()
		{
			ISelfVarRefT selfVarRefT = new ISelfVarRefT();
			this.UnPackTo(selfVarRefT);
			return selfVarRefT;
		}

		// Token: 0x06015C65 RID: 89189 RVA: 0x0032206F File Offset: 0x0032026F
		public void UnPackTo(ISelfVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Name = this.Name;
		}

		// Token: 0x06015C66 RID: 89190 RVA: 0x00322098 File Offset: 0x00320298
		public static Offset<ISelfVarRef> Pack(FlatBufferBuilder builder, ISelfVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfVarRef>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ISelfVarRef.CreateISelfVarRef(builder, _o.Type, _o.Source, nameOffset);
		}

		// Token: 0x0400B8DE RID: 47326
		private Table __p;
	}
}
