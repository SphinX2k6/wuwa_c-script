using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004696 RID: 18070
	public struct ISetVar : IFlatbufferObject
	{
		// Token: 0x17008047 RID: 32839
		// (get) Token: 0x0601B6FB RID: 112379 RVA: 0x003E5A9A File Offset: 0x003E3C9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B6FC RID: 112380 RVA: 0x003E5AA7 File Offset: 0x003E3CA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B6FD RID: 112381 RVA: 0x003E5AB0 File Offset: 0x003E3CB0
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb)
		{
			return ISetVar.GetRootAsISetVar(_bb, default(ISetVar));
		}

		// Token: 0x0601B6FE RID: 112382 RVA: 0x003E5ACC File Offset: 0x003E3CCC
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb, ISetVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B6FF RID: 112383 RVA: 0x003E5AE9 File Offset: 0x003E3CE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B700 RID: 112384 RVA: 0x003E5AF8 File Offset: 0x003E3CF8
		public ISetVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008048 RID: 32840
		// (get) Token: 0x0601B701 RID: 112385 RVA: 0x003E5B08 File Offset: 0x003E3D08
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

		// Token: 0x17008049 RID: 32841
		// (get) Token: 0x0601B702 RID: 112386 RVA: 0x003E5B44 File Offset: 0x003E3D44
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

		// Token: 0x1700804A RID: 32842
		// (get) Token: 0x0601B703 RID: 112387 RVA: 0x003E5B80 File Offset: 0x003E3D80
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

		// Token: 0x0601B704 RID: 112388 RVA: 0x003E5BB7 File Offset: 0x003E3DB7
		public Span<byte> GetVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B705 RID: 112389 RVA: 0x003E5BC6 File Offset: 0x003E3DC6
		public byte[] GetVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700804B RID: 32843
		// (get) Token: 0x0601B706 RID: 112390 RVA: 0x003E5BD4 File Offset: 0x003E3DD4
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

		// Token: 0x0601B707 RID: 112391 RVA: 0x003E5C0C File Offset: 0x003E3E0C
		public Span<byte> GetVarValueBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601B708 RID: 112392 RVA: 0x003E5C1C File Offset: 0x003E3E1C
		public byte[] GetVarValueArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700804C RID: 32844
		// (get) Token: 0x0601B709 RID: 112393 RVA: 0x003E5C2C File Offset: 0x003E3E2C
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

		// Token: 0x1700804D RID: 32845
		// (get) Token: 0x0601B70A RID: 112394 RVA: 0x003E5C6C File Offset: 0x003E3E6C
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

		// Token: 0x1700804E RID: 32846
		// (get) Token: 0x0601B70B RID: 112395 RVA: 0x003E5CAC File Offset: 0x003E3EAC
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

		// Token: 0x0601B70C RID: 112396 RVA: 0x003E5CEC File Offset: 0x003E3EEC
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

		// Token: 0x0601B70D RID: 112397 RVA: 0x003E5D3B File Offset: 0x003E3F3B
		public static void StartISetVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B70E RID: 112398 RVA: 0x003E5D44 File Offset: 0x003E3F44
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B70F RID: 112399 RVA: 0x003E5D4F File Offset: 0x003E3F4F
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x0601B710 RID: 112400 RVA: 0x003E5D5A File Offset: 0x003E3F5A
		public static void AddVarName(FlatBufferBuilder builder, StringOffset varNameOffset)
		{
			builder.AddOffset(2, varNameOffset.Value, 0);
		}

		// Token: 0x0601B711 RID: 112401 RVA: 0x003E5D6A File Offset: 0x003E3F6A
		public static void AddVarValue(FlatBufferBuilder builder, StringOffset varValueOffset)
		{
			builder.AddOffset(3, varValueOffset.Value, 0);
		}

		// Token: 0x0601B712 RID: 112402 RVA: 0x003E5D7A File Offset: 0x003E3F7A
		public static void AddVarTypeParam(FlatBufferBuilder builder, EVar varTypeParam)
		{
			builder.AddByte(4, (byte)varTypeParam, 0);
		}

		// Token: 0x0601B713 RID: 112403 RVA: 0x003E5D85 File Offset: 0x003E3F85
		public static void AddTargetRefType(FlatBufferBuilder builder, ERefType targetRefType)
		{
			builder.AddByte(5, (byte)targetRefType, 0);
		}

		// Token: 0x0601B714 RID: 112404 RVA: 0x003E5D90 File Offset: 0x003E3F90
		public static void AddTargetRefId(FlatBufferBuilder builder, int targetRefId)
		{
			builder.AddInt(6, targetRefId, 0);
		}

		// Token: 0x0601B715 RID: 112405 RVA: 0x003E5D9B File Offset: 0x003E3F9B
		public static Offset<ISetVar> EndISetVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetVar>(builder.EndTable());
		}

		// Token: 0x0601B716 RID: 112406 RVA: 0x003E5DA8 File Offset: 0x003E3FA8
		public ISetVarT UnPack()
		{
			ISetVarT setVarT = new ISetVarT();
			this.UnPackTo(setVarT);
			return setVarT;
		}

		// Token: 0x0601B717 RID: 112407 RVA: 0x003E5DC4 File Offset: 0x003E3FC4
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

		// Token: 0x0601B718 RID: 112408 RVA: 0x003E5E28 File Offset: 0x003E4028
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

		// Token: 0x0400C856 RID: 51286
		private Table __p;
	}
}
