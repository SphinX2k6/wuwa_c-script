using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EAA RID: 16042
	public struct IOtherVarRef : IFlatbufferObject
	{
		// Token: 0x17006C8F RID: 27791
		// (get) Token: 0x06015B04 RID: 88836 RVA: 0x0031F93D File Offset: 0x0031DB3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B05 RID: 88837 RVA: 0x0031F94A File Offset: 0x0031DB4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B06 RID: 88838 RVA: 0x0031F954 File Offset: 0x0031DB54
		public static IOtherVarRef GetRootAsIOtherVarRef(ByteBuffer _bb)
		{
			return IOtherVarRef.GetRootAsIOtherVarRef(_bb, default(IOtherVarRef));
		}

		// Token: 0x06015B07 RID: 88839 RVA: 0x0031F970 File Offset: 0x0031DB70
		public static IOtherVarRef GetRootAsIOtherVarRef(ByteBuffer _bb, IOtherVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B08 RID: 88840 RVA: 0x0031F98D File Offset: 0x0031DB8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B09 RID: 88841 RVA: 0x0031F99C File Offset: 0x0031DB9C
		public IOtherVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C90 RID: 27792
		// (get) Token: 0x06015B0A RID: 88842 RVA: 0x0031F9AC File Offset: 0x0031DBAC
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

		// Token: 0x17006C91 RID: 27793
		// (get) Token: 0x06015B0B RID: 88843 RVA: 0x0031F9E8 File Offset: 0x0031DBE8
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

		// Token: 0x17006C92 RID: 27794
		// (get) Token: 0x06015B0C RID: 88844 RVA: 0x0031FA24 File Offset: 0x0031DC24
		public ERefType RefType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERefType.Entity;
				}
				return (ERefType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C93 RID: 27795
		// (get) Token: 0x06015B0D RID: 88845 RVA: 0x0031FA60 File Offset: 0x0031DC60
		public int RefId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C94 RID: 27796
		// (get) Token: 0x06015B0E RID: 88846 RVA: 0x0031FAA0 File Offset: 0x0031DCA0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015B0F RID: 88847 RVA: 0x0031FAD8 File Offset: 0x0031DCD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06015B10 RID: 88848 RVA: 0x0031FAE8 File Offset: 0x0031DCE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06015B11 RID: 88849 RVA: 0x0031FAF7 File Offset: 0x0031DCF7
		public static Offset<IOtherVarRef> CreateIOtherVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, ERefType RefType = ERefType.Entity, int RefId = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IOtherVarRef.AddName(builder, NameOffset);
			IOtherVarRef.AddRefId(builder, RefId);
			IOtherVarRef.AddRefType(builder, RefType);
			IOtherVarRef.AddSource(builder, Source);
			IOtherVarRef.AddType(builder, Type);
			return IOtherVarRef.EndIOtherVarRef(builder);
		}

		// Token: 0x06015B12 RID: 88850 RVA: 0x0031FB2B File Offset: 0x0031DD2B
		public static void StartIOtherVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015B13 RID: 88851 RVA: 0x0031FB34 File Offset: 0x0031DD34
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B14 RID: 88852 RVA: 0x0031FB3F File Offset: 0x0031DD3F
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015B15 RID: 88853 RVA: 0x0031FB4A File Offset: 0x0031DD4A
		public static void AddRefType(FlatBufferBuilder builder, ERefType refType)
		{
			builder.AddByte(2, (byte)refType, 0);
		}

		// Token: 0x06015B16 RID: 88854 RVA: 0x0031FB55 File Offset: 0x0031DD55
		public static void AddRefId(FlatBufferBuilder builder, int refId)
		{
			builder.AddInt(3, refId, 0);
		}

		// Token: 0x06015B17 RID: 88855 RVA: 0x0031FB60 File Offset: 0x0031DD60
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x06015B18 RID: 88856 RVA: 0x0031FB70 File Offset: 0x0031DD70
		public static Offset<IOtherVarRef> EndIOtherVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IOtherVarRef>(builder.EndTable());
		}

		// Token: 0x06015B19 RID: 88857 RVA: 0x0031FB80 File Offset: 0x0031DD80
		public IOtherVarRefT UnPack()
		{
			IOtherVarRefT otherVarRefT = new IOtherVarRefT();
			this.UnPackTo(otherVarRefT);
			return otherVarRefT;
		}

		// Token: 0x06015B1A RID: 88858 RVA: 0x0031FB9B File Offset: 0x0031DD9B
		public void UnPackTo(IOtherVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.RefType = this.RefType;
			_o.RefId = this.RefId;
			_o.Name = this.Name;
		}

		// Token: 0x06015B1B RID: 88859 RVA: 0x0031FBDC File Offset: 0x0031DDDC
		public static Offset<IOtherVarRef> Pack(FlatBufferBuilder builder, IOtherVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOtherVarRef>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IOtherVarRef.CreateIOtherVarRef(builder, _o.Type, _o.Source, _o.RefType, _o.RefId, nameOffset);
		}

		// Token: 0x0400B89E RID: 47262
		private Table __p;
	}
}
