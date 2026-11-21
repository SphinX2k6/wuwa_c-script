using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AFE RID: 19198
	public struct ISetVar : IFlatbufferObject
	{
		// Token: 0x17008688 RID: 34440
		// (get) Token: 0x0601CED0 RID: 118480 RVA: 0x00411D36 File Offset: 0x0040FF36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CED1 RID: 118481 RVA: 0x00411D43 File Offset: 0x0040FF43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CED2 RID: 118482 RVA: 0x00411D4C File Offset: 0x0040FF4C
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb)
		{
			return ISetVar.GetRootAsISetVar(_bb, default(ISetVar));
		}

		// Token: 0x0601CED3 RID: 118483 RVA: 0x00411D68 File Offset: 0x0040FF68
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb, ISetVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CED4 RID: 118484 RVA: 0x00411D85 File Offset: 0x0040FF85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CED5 RID: 118485 RVA: 0x00411D94 File Offset: 0x0040FF94
		public ISetVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008689 RID: 34441
		// (get) Token: 0x0601CED6 RID: 118486 RVA: 0x00411DA4 File Offset: 0x0040FFA4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700868A RID: 34442
		// (get) Token: 0x0601CED7 RID: 118487 RVA: 0x00411DE0 File Offset: 0x0040FFE0
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

		// Token: 0x1700868B RID: 34443
		// (get) Token: 0x0601CED8 RID: 118488 RVA: 0x00411E1C File Offset: 0x0041001C
		public string VarName
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

		// Token: 0x0601CED9 RID: 118489 RVA: 0x00411E53 File Offset: 0x00410053
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CEDA RID: 118490 RVA: 0x00411E62 File Offset: 0x00410062
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700868C RID: 34444
		// (get) Token: 0x0601CEDB RID: 118491 RVA: 0x00411E70 File Offset: 0x00410070
		public string VarValue
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

		// Token: 0x0601CEDC RID: 118492 RVA: 0x00411EA8 File Offset: 0x004100A8
		public Span<byte> GetVarValueBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601CEDD RID: 118493 RVA: 0x00411EB8 File Offset: 0x004100B8
		public byte[] GetVarValueArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700868D RID: 34445
		// (get) Token: 0x0601CEDE RID: 118494 RVA: 0x00411EC8 File Offset: 0x004100C8
		public EVar VarTypeParam
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700868E RID: 34446
		// (get) Token: 0x0601CEDF RID: 118495 RVA: 0x00411F08 File Offset: 0x00410108
		public ERefType TargetRefType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ERefType.Entity;
				}
				return (ERefType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700868F RID: 34447
		// (get) Token: 0x0601CEE0 RID: 118496 RVA: 0x00411F48 File Offset: 0x00410148
		public int TargetRefId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CEE1 RID: 118497 RVA: 0x00411F88 File Offset: 0x00410188
		public static Offset<ISetVar> CreateISetVar(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, EVarRefSource Source = EVarRefSource.Constant, StringOffset VarNameOffset = default(StringOffset), StringOffset VarValueOffset = default(StringOffset), EVar VarTypeParam = EVar.Boolean, ERefType TargetRefType = ERefType.Entity, int TargetRefId = 0)
		{
			builder.StartTable(7);
			ISetVar.AddTargetRefId(builder, TargetRefId);
			ISetVar.AddVarValue(builder, VarValueOffset);
			ISetVar.AddVarName(builder, VarNameOffset);
			ISetVar.AddTargetRefType(builder, TargetRefType);
			ISetVar.AddVarTypeParam(builder, VarTypeParam);
			ISetVar.AddSource(builder, Source);
			ISetVar.AddType(builder, Type);
			return ISetVar.EndISetVar(builder);
		}

		// Token: 0x0601CEE2 RID: 118498 RVA: 0x00411FD7 File Offset: 0x004101D7
		public static void StartISetVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601CEE3 RID: 118499 RVA: 0x00411FE0 File Offset: 0x004101E0
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CEE4 RID: 118500 RVA: 0x00411FEB File Offset: 0x004101EB
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x00411FF6 File Offset: 0x004101F6
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(2, varNameOffset.Value, 0);
		}

		// Token: 0x0601CEE6 RID: 118502 RVA: 0x00412006 File Offset: 0x00410206
		public static void AddVarValue(FlatBufferBuilder builder, StringOffset varValueOffset)
		{
			builder.AddOffset(3, varValueOffset.Value, 0);
		}

		// Token: 0x0601CEE7 RID: 118503 RVA: 0x00412016 File Offset: 0x00410216
		public static void AddVarTypeParam(FlatBufferBuilder builder, EVar varTypeParam)
		{
			builder.AddByte(4, (byte)varTypeParam, 0);
		}

		// Token: 0x0601CEE8 RID: 118504 RVA: 0x00412021 File Offset: 0x00410221
		public static void AddTargetRefType(FlatBufferBuilder builder, ERefType targetRefType)
		{
			builder.AddByte(5, (byte)targetRefType, 0);
		}

		// Token: 0x0601CEE9 RID: 118505 RVA: 0x0041202C File Offset: 0x0041022C
		public static void AddTargetRefId(FlatBufferBuilder builder, int targetRefId)
		{
			builder.AddInt(6, targetRefId, 0);
		}

		// Token: 0x0601CEEA RID: 118506 RVA: 0x00412037 File Offset: 0x00410237
		public static Offset<ISetVar> EndISetVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetVar>(builder.EndTable());
		}

		// Token: 0x0601CEEB RID: 118507 RVA: 0x00412044 File Offset: 0x00410244
		public ISetVarT UnPack()
		{
			ISetVarT setVarT = new ISetVarT();
			this.UnPackTo(setVarT);
			return setVarT;
		}

		// Token: 0x0601CEEC RID: 118508 RVA: 0x00412060 File Offset: 0x00410260
		public void UnPackTo(ISetVarT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.VarName = this.VarName;
			_o.VarValue = this.VarValue;
			_o.VarTypeParam = this.VarTypeParam;
			_o.TargetRefType = this.TargetRefType;
			_o.TargetRefId = this.TargetRefId;
		}

		// Token: 0x0601CEED RID: 118509 RVA: 0x004120C4 File Offset: 0x004102C4
		public static Offset<ISetVar> Pack(FlatBufferBuilder builder, ISetVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetVar>);
			}
			StringOffset varNameOffset = (_o.VarName == null) ? default(StringOffset) : builder.CreateString(_o.VarName);
			StringOffset varValueOffset = (_o.VarValue == null) ? default(StringOffset) : builder.CreateString(_o.VarValue);
			return ISetVar.CreateISetVar(builder, _o.Type, _o.Source, varNameOffset, varValueOffset, _o.VarTypeParam, _o.TargetRefType, _o.TargetRefId);
		}

		// Token: 0x0400D285 RID: 53893
		private Table __p;
	}
}
