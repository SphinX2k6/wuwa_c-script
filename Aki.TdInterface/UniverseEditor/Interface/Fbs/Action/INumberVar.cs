using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734F RID: 29519
	public struct INumberVar : IFlatbufferObject
	{
		// Token: 0x1700D867 RID: 55399
		// (get) Token: 0x060337D4 RID: 210900 RVA: 0x006F0980 File Offset: 0x006EEB80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337D5 RID: 210901 RVA: 0x006F098D File Offset: 0x006EEB8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337D6 RID: 210902 RVA: 0x006F0994 File Offset: 0x006EEB94
		public static INumberVar GetRootAsINumberVar(ByteBuffer _bb)
		{
			return INumberVar.GetRootAsINumberVar(_bb, default(INumberVar));
		}

		// Token: 0x060337D7 RID: 210903 RVA: 0x006F09B0 File Offset: 0x006EEBB0
		public static INumberVar GetRootAsINumberVar(ByteBuffer _bb, INumberVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337D8 RID: 210904 RVA: 0x006F09CD File Offset: 0x006EEBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337D9 RID: 210905 RVA: 0x006F09DC File Offset: 0x006EEBDC
		public INumberVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D868 RID: 55400
		// (get) Token: 0x060337DA RID: 210906 RVA: 0x006F09EC File Offset: 0x006EEBEC
		public string Name
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

		// Token: 0x060337DB RID: 210907 RVA: 0x006F0A23 File Offset: 0x006EEC23
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060337DC RID: 210908 RVA: 0x006F0A32 File Offset: 0x006EEC32
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D869 RID: 55401
		// (get) Token: 0x060337DD RID: 210909 RVA: 0x006F0A40 File Offset: 0x006EEC40
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060337DE RID: 210910 RVA: 0x006F0A80 File Offset: 0x006EEC80
		public static Offset<INumberVar> CreateINumberVar(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), float Value = 0f)
		{
			builder.StartTable(2);
			INumberVar.AddValue(builder, Value);
			INumberVar.AddName(builder, NameOffset);
			return INumberVar.EndINumberVar(builder);
		}

		// Token: 0x060337DF RID: 210911 RVA: 0x006F0A9D File Offset: 0x006EEC9D
		public static void StartINumberVar(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060337E0 RID: 210912 RVA: 0x006F0AA6 File Offset: 0x006EECA6
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x060337E1 RID: 210913 RVA: 0x006F0AB6 File Offset: 0x006EECB6
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(1, value, 0.0);
		}

		// Token: 0x060337E2 RID: 210914 RVA: 0x006F0AC9 File Offset: 0x006EECC9
		public static Offset<INumberVar> EndINumberVar(FlatBufferBuilder builder)
		{
			return new Offset<INumberVar>(builder.EndTable());
		}

		// Token: 0x060337E3 RID: 210915 RVA: 0x006F0AD8 File Offset: 0x006EECD8
		public INumberVarT UnPack()
		{
			INumberVarT numberVarT = new INumberVarT();
			this.UnPackTo(numberVarT);
			return numberVarT;
		}

		// Token: 0x060337E4 RID: 210916 RVA: 0x006F0AF3 File Offset: 0x006EECF3
		public void UnPackTo(INumberVarT _o)
		{
			_o.Name = this.Name;
			_o.Value = this.Value;
		}

		// Token: 0x060337E5 RID: 210917 RVA: 0x006F0B10 File Offset: 0x006EED10
		public static Offset<INumberVar> Pack(FlatBufferBuilder builder, INumberVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<INumberVar>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return INumberVar.CreateINumberVar(builder, nameOffset, _o.Value);
		}

		// Token: 0x04012429 RID: 74793
		private Table __p;
	}
}
