using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADB RID: 15067
	public struct ISystemVarDefine : IFlatbufferObject
	{
		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x0601482B RID: 84011 RVA: 0x002FCAD3 File Offset: 0x002FACD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601482C RID: 84012 RVA: 0x002FCAE0 File Offset: 0x002FACE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601482D RID: 84013 RVA: 0x002FCAE8 File Offset: 0x002FACE8
		public static ISystemVarDefine GetRootAsISystemVarDefine(ByteBuffer _bb)
		{
			return ISystemVarDefine.GetRootAsISystemVarDefine(_bb, default(ISystemVarDefine));
		}

		// Token: 0x0601482E RID: 84014 RVA: 0x002FCB04 File Offset: 0x002FAD04
		public static ISystemVarDefine GetRootAsISystemVarDefine(ByteBuffer _bb, ISystemVarDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601482F RID: 84015 RVA: 0x002FCB21 File Offset: 0x002FAD21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014830 RID: 84016 RVA: 0x002FCB30 File Offset: 0x002FAD30
		public ISystemVarDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x06014831 RID: 84017 RVA: 0x002FCB40 File Offset: 0x002FAD40
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

		// Token: 0x06014832 RID: 84018 RVA: 0x002FCB77 File Offset: 0x002FAD77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014833 RID: 84019 RVA: 0x002FCB86 File Offset: 0x002FAD86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x06014834 RID: 84020 RVA: 0x002FCB94 File Offset: 0x002FAD94
		public string Type
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

		// Token: 0x06014835 RID: 84021 RVA: 0x002FCBCB File Offset: 0x002FADCB
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014836 RID: 84022 RVA: 0x002FCBDA File Offset: 0x002FADDA
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006757 RID: 26455
		// (get) Token: 0x06014837 RID: 84023 RVA: 0x002FCBE8 File Offset: 0x002FADE8
		public ESystemModuleName ModuleName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESystemModuleName.Common;
				}
				return (ESystemModuleName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006758 RID: 26456
		// (get) Token: 0x06014838 RID: 84024 RVA: 0x002FCC24 File Offset: 0x002FAE24
		public string CnName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014839 RID: 84025 RVA: 0x002FCC5C File Offset: 0x002FAE5C
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601483A RID: 84026 RVA: 0x002FCC6C File Offset: 0x002FAE6C
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006759 RID: 26457
		// (get) Token: 0x0601483B RID: 84027 RVA: 0x002FCC7C File Offset: 0x002FAE7C
		public bool Readonly
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700675A RID: 26458
		// (get) Token: 0x0601483C RID: 84028 RVA: 0x002FCCBC File Offset: 0x002FAEBC
		public bool HasArgs
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601483D RID: 84029 RVA: 0x002FCCFC File Offset: 0x002FAEFC
		public static Offset<ISystemVarDefine> CreateISystemVarDefine(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), StringOffset TypeOffset = default(StringOffset), ESystemModuleName ModuleName = ESystemModuleName.Common, StringOffset CnNameOffset = default(StringOffset), bool Readonly = false, bool HasArgs = false)
		{
			builder.StartTable(6);
			ISystemVarDefine.AddCnName(builder, CnNameOffset);
			ISystemVarDefine.AddType(builder, TypeOffset);
			ISystemVarDefine.AddName(builder, NameOffset);
			ISystemVarDefine.AddHasArgs(builder, HasArgs);
			ISystemVarDefine.AddReadonly(builder, Readonly);
			ISystemVarDefine.AddModuleName(builder, ModuleName);
			return ISystemVarDefine.EndISystemVarDefine(builder);
		}

		// Token: 0x0601483E RID: 84030 RVA: 0x002FCD38 File Offset: 0x002FAF38
		public static void StartISystemVarDefine(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601483F RID: 84031 RVA: 0x002FCD41 File Offset: 0x002FAF41
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06014840 RID: 84032 RVA: 0x002FCD51 File Offset: 0x002FAF51
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(1, typeOffset.Value, 0);
		}

		// Token: 0x06014841 RID: 84033 RVA: 0x002FCD61 File Offset: 0x002FAF61
		public static void AddModuleName(FlatBufferBuilder builder, ESystemModuleName moduleName)
		{
			builder.AddByte(2, (byte)moduleName, 0);
		}

		// Token: 0x06014842 RID: 84034 RVA: 0x002FCD6C File Offset: 0x002FAF6C
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(3, cnNameOffset.Value, 0);
		}

		// Token: 0x06014843 RID: 84035 RVA: 0x002FCD7C File Offset: 0x002FAF7C
		public static void AddReadonly(FlatBufferBuilder builder, bool @readonly)
		{
			builder.AddBool(4, @readonly, false);
		}

		// Token: 0x06014844 RID: 84036 RVA: 0x002FCD87 File Offset: 0x002FAF87
		public static void AddHasArgs(FlatBufferBuilder builder, bool hasArgs)
		{
			builder.AddBool(5, hasArgs, false);
		}

		// Token: 0x06014845 RID: 84037 RVA: 0x002FCD92 File Offset: 0x002FAF92
		public static Offset<ISystemVarDefine> EndISystemVarDefine(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarDefine>(builder.EndTable());
		}

		// Token: 0x06014846 RID: 84038 RVA: 0x002FCDA0 File Offset: 0x002FAFA0
		public ISystemVarDefineT UnPack()
		{
			ISystemVarDefineT systemVarDefineT = new ISystemVarDefineT();
			this.UnPackTo(systemVarDefineT);
			return systemVarDefineT;
		}

		// Token: 0x06014847 RID: 84039 RVA: 0x002FCDBC File Offset: 0x002FAFBC
		public void UnPackTo(ISystemVarDefineT _o)
		{
			_o.Name = this.Name;
			_o.Type = this.Type;
			_o.ModuleName = this.ModuleName;
			_o.CnName = this.CnName;
			_o.Readonly = this.Readonly;
			_o.HasArgs = this.HasArgs;
		}

		// Token: 0x06014848 RID: 84040 RVA: 0x002FCE14 File Offset: 0x002FB014
		public static Offset<ISystemVarDefine> Pack(FlatBufferBuilder builder, ISystemVarDefineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemVarDefine>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			StringOffset cnNameOffset = (_o.CnName == null) ? default(StringOffset) : builder.CreateString(_o.CnName);
			return ISystemVarDefine.CreateISystemVarDefine(builder, nameOffset, typeOffset, _o.ModuleName, cnNameOffset, _o.Readonly, _o.HasArgs);
		}

		// Token: 0x0400AF97 RID: 44951
		private Table __p;
	}
}
