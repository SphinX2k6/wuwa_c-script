using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ACF RID: 15055
	public struct ISelfVarRef : IFlatbufferObject
	{
		// Token: 0x17006745 RID: 26437
		// (get) Token: 0x060147A9 RID: 83881 RVA: 0x002FBC2A File Offset: 0x002F9E2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x002FBC37 File Offset: 0x002F9E37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060147AB RID: 83883 RVA: 0x002FBC40 File Offset: 0x002F9E40
		public static ISelfVarRef GetRootAsISelfVarRef(ByteBuffer _bb)
		{
			return ISelfVarRef.GetRootAsISelfVarRef(_bb, default(ISelfVarRef));
		}

		// Token: 0x060147AC RID: 83884 RVA: 0x002FBC5C File Offset: 0x002F9E5C
		public static ISelfVarRef GetRootAsISelfVarRef(ByteBuffer _bb, ISelfVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x002FBC79 File Offset: 0x002F9E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060147AE RID: 83886 RVA: 0x002FBC88 File Offset: 0x002F9E88
		public ISelfVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006746 RID: 26438
		// (get) Token: 0x060147AF RID: 83887 RVA: 0x002FBC98 File Offset: 0x002F9E98
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

		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x060147B0 RID: 83888 RVA: 0x002FBCD4 File Offset: 0x002F9ED4
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

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x060147B1 RID: 83889 RVA: 0x002FBD10 File Offset: 0x002F9F10
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

		// Token: 0x060147B2 RID: 83890 RVA: 0x002FBD47 File Offset: 0x002F9F47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060147B3 RID: 83891 RVA: 0x002FBD56 File Offset: 0x002F9F56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060147B4 RID: 83892 RVA: 0x002FBD64 File Offset: 0x002F9F64
		public static Offset<ISelfVarRef> CreateISelfVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ISelfVarRef.AddName(builder, NameOffset);
			ISelfVarRef.AddSource(builder, Source);
			ISelfVarRef.AddType(builder, Type);
			return ISelfVarRef.EndISelfVarRef(builder);
		}

		// Token: 0x060147B5 RID: 83893 RVA: 0x002FBD88 File Offset: 0x002F9F88
		public static void StartISelfVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060147B6 RID: 83894 RVA: 0x002FBD91 File Offset: 0x002F9F91
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060147B7 RID: 83895 RVA: 0x002FBD9C File Offset: 0x002F9F9C
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x060147B8 RID: 83896 RVA: 0x002FBDA7 File Offset: 0x002F9FA7
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x060147B9 RID: 83897 RVA: 0x002FBDB7 File Offset: 0x002F9FB7
		public static Offset<ISelfVarRef> EndISelfVarRef(FlatBufferBuilder builder)
		{
			return new Offset<ISelfVarRef>(builder.EndTable());
		}

		// Token: 0x060147BA RID: 83898 RVA: 0x002FBDC4 File Offset: 0x002F9FC4
		public ISelfVarRefT UnPack()
		{
			ISelfVarRefT selfVarRefT = new ISelfVarRefT();
			this.UnPackTo(selfVarRefT);
			return selfVarRefT;
		}

		// Token: 0x060147BB RID: 83899 RVA: 0x002FBDDF File Offset: 0x002F9FDF
		public void UnPackTo(ISelfVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Name = this.Name;
		}

		// Token: 0x060147BC RID: 83900 RVA: 0x002FBE08 File Offset: 0x002FA008
		public static Offset<ISelfVarRef> Pack(FlatBufferBuilder builder, ISelfVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfVarRef>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ISelfVarRef.CreateISelfVarRef(builder, _o.Type, _o.Source, nameOffset);
		}

		// Token: 0x0400AF71 RID: 44913
		private Table __p;
	}
}
