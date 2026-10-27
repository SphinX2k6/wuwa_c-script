using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006477 RID: 25719
	public struct ICommonCalculateVar : IFlatbufferObject
	{
		// Token: 0x1700BF61 RID: 48993
		// (get) Token: 0x0602C8CB RID: 182475 RVA: 0x0061DCFE File Offset: 0x0061BEFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C8CC RID: 182476 RVA: 0x0061DD0B File Offset: 0x0061BF0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C8CD RID: 182477 RVA: 0x0061DD14 File Offset: 0x0061BF14
		public static ICommonCalculateVar GetRootAsICommonCalculateVar(ByteBuffer _bb)
		{
			return ICommonCalculateVar.GetRootAsICommonCalculateVar(_bb, default(ICommonCalculateVar));
		}

		// Token: 0x0602C8CE RID: 182478 RVA: 0x0061DD30 File Offset: 0x0061BF30
		public static ICommonCalculateVar GetRootAsICommonCalculateVar(ByteBuffer _bb, ICommonCalculateVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C8CF RID: 182479 RVA: 0x0061DD4D File Offset: 0x0061BF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C8D0 RID: 182480 RVA: 0x0061DD5C File Offset: 0x0061BF5C
		public ICommonCalculateVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF62 RID: 48994
		// (get) Token: 0x0602C8D1 RID: 182481 RVA: 0x0061DD6C File Offset: 0x0061BF6C
		public TVarRef Var1Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C8D2 RID: 182482 RVA: 0x0061DDA8 File Offset: 0x0061BFA8
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C8D3 RID: 182483 RVA: 0x0061DDEC File Offset: 0x0061BFEC
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0602C8D4 RID: 182484 RVA: 0x0061DE08 File Offset: 0x0061C008
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0602C8D5 RID: 182485 RVA: 0x0061DE24 File Offset: 0x0061C024
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0602C8D6 RID: 182486 RVA: 0x0061DE40 File Offset: 0x0061C040
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0602C8D7 RID: 182487 RVA: 0x0061DE5C File Offset: 0x0061C05C
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700BF63 RID: 48995
		// (get) Token: 0x0602C8D8 RID: 182488 RVA: 0x0061DE78 File Offset: 0x0061C078
		public string Op
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

		// Token: 0x0602C8D9 RID: 182489 RVA: 0x0061DEAF File Offset: 0x0061C0AF
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C8DA RID: 182490 RVA: 0x0061DEBE File Offset: 0x0061C0BE
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BF64 RID: 48996
		// (get) Token: 0x0602C8DB RID: 182491 RVA: 0x0061DECC File Offset: 0x0061C0CC
		public TVarRef Var2Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C8DC RID: 182492 RVA: 0x0061DF0C File Offset: 0x0061C10C
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C8DD RID: 182493 RVA: 0x0061DF54 File Offset: 0x0061C154
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0602C8DE RID: 182494 RVA: 0x0061DF70 File Offset: 0x0061C170
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0602C8DF RID: 182495 RVA: 0x0061DF8C File Offset: 0x0061C18C
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0602C8E0 RID: 182496 RVA: 0x0061DFA8 File Offset: 0x0061C1A8
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0602C8E1 RID: 182497 RVA: 0x0061DFC4 File Offset: 0x0061C1C4
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x1700BF65 RID: 48997
		// (get) Token: 0x0602C8E2 RID: 182498 RVA: 0x0061DFE0 File Offset: 0x0061C1E0
		public TVarRef ResultType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C8E3 RID: 182499 RVA: 0x0061E020 File Offset: 0x0061C220
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C8E4 RID: 182500 RVA: 0x0061E068 File Offset: 0x0061C268
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x0602C8E5 RID: 182501 RVA: 0x0061E084 File Offset: 0x0061C284
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x0602C8E6 RID: 182502 RVA: 0x0061E0A0 File Offset: 0x0061C2A0
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x0602C8E7 RID: 182503 RVA: 0x0061E0BC File Offset: 0x0061C2BC
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x0602C8E8 RID: 182504 RVA: 0x0061E0D8 File Offset: 0x0061C2D8
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x0602C8E9 RID: 182505 RVA: 0x0061E0F4 File Offset: 0x0061C2F4
		public static Offset<ICommonCalculateVar> CreateICommonCalculateVar(FlatBufferBuilder builder, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, StringOffset OpOffset = default(StringOffset), TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0, TVarRef Result_type = TVarRef.NONE, int ResultOffset = 0)
		{
			builder.StartTable(7);
			ICommonCalculateVar.AddResult(builder, ResultOffset);
			ICommonCalculateVar.AddVar2(builder, Var2Offset);
			ICommonCalculateVar.AddOp(builder, OpOffset);
			ICommonCalculateVar.AddVar1(builder, Var1Offset);
			ICommonCalculateVar.AddResultType(builder, Result_type);
			ICommonCalculateVar.AddVar2Type(builder, Var2_type);
			ICommonCalculateVar.AddVar1Type(builder, Var1_type);
			return ICommonCalculateVar.EndICommonCalculateVar(builder);
		}

		// Token: 0x0602C8EA RID: 182506 RVA: 0x0061E143 File Offset: 0x0061C343
		public static void StartICommonCalculateVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602C8EB RID: 182507 RVA: 0x0061E14C File Offset: 0x0061C34C
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602C8EC RID: 182508 RVA: 0x0061E157 File Offset: 0x0061C357
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602C8ED RID: 182509 RVA: 0x0061E162 File Offset: 0x0061C362
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602C8EE RID: 182510 RVA: 0x0061E172 File Offset: 0x0061C372
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602C8EF RID: 182511 RVA: 0x0061E17D File Offset: 0x0061C37D
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602C8F0 RID: 182512 RVA: 0x0061E188 File Offset: 0x0061C388
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(5, (byte)resultType, 0);
		}

		// Token: 0x0602C8F1 RID: 182513 RVA: 0x0061E193 File Offset: 0x0061C393
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(6, resultOffset, 0);
		}

		// Token: 0x0602C8F2 RID: 182514 RVA: 0x0061E19E File Offset: 0x0061C39E
		public static Offset<ICommonCalculateVar> EndICommonCalculateVar(FlatBufferBuilder builder)
		{
			return new Offset<ICommonCalculateVar>(builder.EndTable());
		}

		// Token: 0x0602C8F3 RID: 182515 RVA: 0x0061E1AC File Offset: 0x0061C3AC
		public ICommonCalculateVarT UnPack()
		{
			ICommonCalculateVarT commonCalculateVarT = new ICommonCalculateVarT();
			this.UnPackTo(commonCalculateVarT);
			return commonCalculateVarT;
		}

		// Token: 0x0602C8F4 RID: 182516 RVA: 0x0061E1C8 File Offset: 0x0061C3C8
		public void UnPackTo(ICommonCalculateVarT _o)
		{
			_o.Var1 = new TVarRefUnion();
			_o.Var1.Type = this.Var1Type;
			switch (this.Var1Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var1.Value = ((this.Var1<IConstVarRef>() != null) ? this.Var1<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var1.Value = ((this.Var1<IGlobalVarRef>() != null) ? this.Var1<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var1.Value = ((this.Var1<IOtherVarRef>() != null) ? this.Var1<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var1.Value = ((this.Var1<ISelfVarRef>() != null) ? this.Var1<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var1.Value = ((this.Var1<ISystemVarRef>() != null) ? this.Var1<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.Op = this.Op;
			_o.Var2 = new TVarRefUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var2.Value = ((this.Var2<IConstVarRef>() != null) ? this.Var2<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var2.Value = ((this.Var2<IGlobalVarRef>() != null) ? this.Var2<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var2.Value = ((this.Var2<IOtherVarRef>() != null) ? this.Var2<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var2.Value = ((this.Var2<ISelfVarRef>() != null) ? this.Var2<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var2.Value = ((this.Var2<ISystemVarRef>() != null) ? this.Var2<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.Result = new TVarRefUnion();
			_o.Result.Type = this.ResultType;
			switch (this.ResultType)
			{
			case TVarRef.IConstVarRef:
				_o.Result.Value = ((this.Result<IConstVarRef>() != null) ? this.Result<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Result.Value = ((this.Result<IGlobalVarRef>() != null) ? this.Result<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Result.Value = ((this.Result<IOtherVarRef>() != null) ? this.Result<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Result.Value = ((this.Result<ISelfVarRef>() != null) ? this.Result<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Result.Value = ((this.Result<ISystemVarRef>() != null) ? this.Result<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602C8F5 RID: 182517 RVA: 0x0061E5F4 File Offset: 0x0061C7F4
		public static Offset<ICommonCalculateVar> Pack(FlatBufferBuilder builder, ICommonCalculateVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonCalculateVar>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			StringOffset opOffset = (_o.Op == null) ? default(StringOffset) : builder.CreateString(_o.Op);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			TVarRef result_type = (_o.Result == null) ? TVarRef.NONE : _o.Result.Type;
			int resultOffset = (_o.Result == null) ? 0 : TVarRefUnion.Pack(builder, _o.Result);
			return ICommonCalculateVar.CreateICommonCalculateVar(builder, var1_type, var1Offset, opOffset, var2_type, var2Offset, result_type, resultOffset);
		}

		// Token: 0x04010A7A RID: 68218
		private Table __p;
	}
}
