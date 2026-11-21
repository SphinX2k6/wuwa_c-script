using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EDD RID: 16093
	public struct ISystemVarDefine : IFlatbufferObject
	{
		// Token: 0x17006CEF RID: 27887
		// (get) Token: 0x06015CD5 RID: 89301 RVA: 0x00322D63 File Offset: 0x00320F63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015CD6 RID: 89302 RVA: 0x00322D70 File Offset: 0x00320F70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015CD7 RID: 89303 RVA: 0x00322D78 File Offset: 0x00320F78
		public static ISystemVarDefine GetRootAsISystemVarDefine(ByteBuffer _bb)
		{
			return ISystemVarDefine.GetRootAsISystemVarDefine(_bb, default(ISystemVarDefine));
		}

		// Token: 0x06015CD8 RID: 89304 RVA: 0x00322D94 File Offset: 0x00320F94
		public static ISystemVarDefine GetRootAsISystemVarDefine(ByteBuffer _bb, ISystemVarDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015CD9 RID: 89305 RVA: 0x00322DB1 File Offset: 0x00320FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015CDA RID: 89306 RVA: 0x00322DC0 File Offset: 0x00320FC0
		public ISystemVarDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CF0 RID: 27888
		// (get) Token: 0x06015CDB RID: 89307 RVA: 0x00322DD0 File Offset: 0x00320FD0
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

		// Token: 0x06015CDC RID: 89308 RVA: 0x00322E07 File Offset: 0x00321007
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06015CDD RID: 89309 RVA: 0x00322E16 File Offset: 0x00321016
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006CF1 RID: 27889
		// (get) Token: 0x06015CDE RID: 89310 RVA: 0x00322E24 File Offset: 0x00321024
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

		// Token: 0x06015CDF RID: 89311 RVA: 0x00322E5B File Offset: 0x0032105B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015CE0 RID: 89312 RVA: 0x00322E6A File Offset: 0x0032106A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006CF2 RID: 27890
		// (get) Token: 0x06015CE1 RID: 89313 RVA: 0x00322E78 File Offset: 0x00321078
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

		// Token: 0x17006CF3 RID: 27891
		// (get) Token: 0x06015CE2 RID: 89314 RVA: 0x00322EB4 File Offset: 0x003210B4
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

		// Token: 0x06015CE3 RID: 89315 RVA: 0x00322EEC File Offset: 0x003210EC
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06015CE4 RID: 89316 RVA: 0x00322EFC File Offset: 0x003210FC
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006CF4 RID: 27892
		// (get) Token: 0x06015CE5 RID: 89317 RVA: 0x00322F0C File Offset: 0x0032110C
		public bool Readonly
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006CF5 RID: 27893
		// (get) Token: 0x06015CE6 RID: 89318 RVA: 0x00322F4C File Offset: 0x0032114C
		public bool HasArgs
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06015CE7 RID: 89319 RVA: 0x00322F8C File Offset: 0x0032118C
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

		// Token: 0x06015CE8 RID: 89320 RVA: 0x00322FC8 File Offset: 0x003211C8
		public static void StartISystemVarDefine(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015CE9 RID: 89321 RVA: 0x00322FD1 File Offset: 0x003211D1
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06015CEA RID: 89322 RVA: 0x00322FE1 File Offset: 0x003211E1
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(1, typeOffset.Value, 0);
		}

		// Token: 0x06015CEB RID: 89323 RVA: 0x00322FF1 File Offset: 0x003211F1
		public static void AddModuleName(FlatBufferBuilder builder, ESystemModuleName moduleName)
		{
			builder.AddByte(2, (byte)moduleName, 0);
		}

		// Token: 0x06015CEC RID: 89324 RVA: 0x00322FFC File Offset: 0x003211FC
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(3, cnNameOffset.Value, 0);
		}

		// Token: 0x06015CED RID: 89325 RVA: 0x0032300C File Offset: 0x0032120C
		public static void AddReadonly(FlatBufferBuilder builder, bool @readonly)
		{
			builder.AddBool(4, @readonly, false);
		}

		// Token: 0x06015CEE RID: 89326 RVA: 0x00323017 File Offset: 0x00321217
		public static void AddHasArgs(FlatBufferBuilder builder, bool hasArgs)
		{
			builder.AddBool(5, hasArgs, false);
		}

		// Token: 0x06015CEF RID: 89327 RVA: 0x00323022 File Offset: 0x00321222
		public static Offset<ISystemVarDefine> EndISystemVarDefine(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarDefine>(builder.EndTable());
		}

		// Token: 0x06015CF0 RID: 89328 RVA: 0x00323030 File Offset: 0x00321230
		public ISystemVarDefineT UnPack()
		{
			ISystemVarDefineT systemVarDefineT = new ISystemVarDefineT();
			this.UnPackTo(systemVarDefineT);
			return systemVarDefineT;
		}

		// Token: 0x06015CF1 RID: 89329 RVA: 0x0032304C File Offset: 0x0032124C
		public void UnPackTo(ISystemVarDefineT _o)
		{
			_o.Name = this.Name;
			_o.Type = this.Type;
			_o.ModuleName = this.ModuleName;
			_o.CnName = this.CnName;
			_o.Readonly = this.Readonly;
			_o.HasArgs = this.HasArgs;
		}

		// Token: 0x06015CF2 RID: 89330 RVA: 0x003230A4 File Offset: 0x003212A4
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

		// Token: 0x0400B904 RID: 47364
		private Table __p;
	}
}
