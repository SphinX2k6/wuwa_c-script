using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DD RID: 26845
	public struct ICalculateVar : IFlatbufferObject
	{
		// Token: 0x1700C548 RID: 50504
		// (get) Token: 0x0602DEFB RID: 188155 RVA: 0x0064711C File Offset: 0x0064531C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEFC RID: 188156 RVA: 0x00647129 File Offset: 0x00645329
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEFD RID: 188157 RVA: 0x00647130 File Offset: 0x00645330
		public static ICalculateVar GetRootAsICalculateVar(ByteBuffer _bb)
		{
			return ICalculateVar.GetRootAsICalculateVar(_bb, default(ICalculateVar));
		}

		// Token: 0x0602DEFE RID: 188158 RVA: 0x0064714C File Offset: 0x0064534C
		public static ICalculateVar GetRootAsICalculateVar(ByteBuffer _bb, ICalculateVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEFF RID: 188159 RVA: 0x00647169 File Offset: 0x00645369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF00 RID: 188160 RVA: 0x00647178 File Offset: 0x00645378
		public ICalculateVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C549 RID: 50505
		// (get) Token: 0x0602DF01 RID: 188161 RVA: 0x00647188 File Offset: 0x00645388
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

		// Token: 0x0602DF02 RID: 188162 RVA: 0x006471C4 File Offset: 0x006453C4
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DF03 RID: 188163 RVA: 0x00647208 File Offset: 0x00645408
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0602DF04 RID: 188164 RVA: 0x00647224 File Offset: 0x00645424
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0602DF05 RID: 188165 RVA: 0x00647240 File Offset: 0x00645440
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0602DF06 RID: 188166 RVA: 0x0064725C File Offset: 0x0064545C
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0602DF07 RID: 188167 RVA: 0x00647278 File Offset: 0x00645478
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700C54A RID: 50506
		// (get) Token: 0x0602DF08 RID: 188168 RVA: 0x00647294 File Offset: 0x00645494
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

		// Token: 0x0602DF09 RID: 188169 RVA: 0x006472CB File Offset: 0x006454CB
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602DF0A RID: 188170 RVA: 0x006472DA File Offset: 0x006454DA
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C54B RID: 50507
		// (get) Token: 0x0602DF0B RID: 188171 RVA: 0x006472E8 File Offset: 0x006454E8
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

		// Token: 0x0602DF0C RID: 188172 RVA: 0x00647328 File Offset: 0x00645528
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DF0D RID: 188173 RVA: 0x00647370 File Offset: 0x00645570
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0602DF0E RID: 188174 RVA: 0x0064738C File Offset: 0x0064558C
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0602DF0F RID: 188175 RVA: 0x006473A8 File Offset: 0x006455A8
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0602DF10 RID: 188176 RVA: 0x006473C4 File Offset: 0x006455C4
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0602DF11 RID: 188177 RVA: 0x006473E0 File Offset: 0x006455E0
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x1700C54C RID: 50508
		// (get) Token: 0x0602DF12 RID: 188178 RVA: 0x006473FC File Offset: 0x006455FC
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

		// Token: 0x0602DF13 RID: 188179 RVA: 0x0064743C File Offset: 0x0064563C
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DF14 RID: 188180 RVA: 0x00647484 File Offset: 0x00645684
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x0602DF15 RID: 188181 RVA: 0x006474A0 File Offset: 0x006456A0
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x0602DF16 RID: 188182 RVA: 0x006474BC File Offset: 0x006456BC
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x0602DF17 RID: 188183 RVA: 0x006474D8 File Offset: 0x006456D8
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x0602DF18 RID: 188184 RVA: 0x006474F4 File Offset: 0x006456F4
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x0602DF19 RID: 188185 RVA: 0x00647510 File Offset: 0x00645710
		public static Offset<ICalculateVar> CreateICalculateVar(FlatBufferBuilder builder, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, StringOffset OpOffset = default(StringOffset), TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0, TVarRef Result_type = TVarRef.NONE, int ResultOffset = 0)
		{
			builder.StartTable(7);
			ICalculateVar.AddResult(builder, ResultOffset);
			ICalculateVar.AddVar2(builder, Var2Offset);
			ICalculateVar.AddOp(builder, OpOffset);
			ICalculateVar.AddVar1(builder, Var1Offset);
			ICalculateVar.AddResultType(builder, Result_type);
			ICalculateVar.AddVar2Type(builder, Var2_type);
			ICalculateVar.AddVar1Type(builder, Var1_type);
			return ICalculateVar.EndICalculateVar(builder);
		}

		// Token: 0x0602DF1A RID: 188186 RVA: 0x0064755F File Offset: 0x0064575F
		public static void StartICalculateVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DF1B RID: 188187 RVA: 0x00647568 File Offset: 0x00645768
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602DF1C RID: 188188 RVA: 0x00647573 File Offset: 0x00645773
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602DF1D RID: 188189 RVA: 0x0064757E File Offset: 0x0064577E
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602DF1E RID: 188190 RVA: 0x0064758E File Offset: 0x0064578E
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602DF1F RID: 188191 RVA: 0x00647599 File Offset: 0x00645799
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602DF20 RID: 188192 RVA: 0x006475A4 File Offset: 0x006457A4
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(5, (byte)resultType, 0);
		}

		// Token: 0x0602DF21 RID: 188193 RVA: 0x006475AF File Offset: 0x006457AF
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(6, resultOffset, 0);
		}

		// Token: 0x0602DF22 RID: 188194 RVA: 0x006475BA File Offset: 0x006457BA
		public static Offset<ICalculateVar> EndICalculateVar(FlatBufferBuilder builder)
		{
			return new Offset<ICalculateVar>(builder.EndTable());
		}

		// Token: 0x0602DF23 RID: 188195 RVA: 0x006475C8 File Offset: 0x006457C8
		public ICalculateVarT UnPack()
		{
			ICalculateVarT calculateVarT = new ICalculateVarT();
			this.UnPackTo(calculateVarT);
			return calculateVarT;
		}

		// Token: 0x0602DF24 RID: 188196 RVA: 0x006475E4 File Offset: 0x006457E4
		public void UnPackTo(ICalculateVarT _o)
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

		// Token: 0x0602DF25 RID: 188197 RVA: 0x00647A10 File Offset: 0x00645C10
		public static Offset<ICalculateVar> Pack(FlatBufferBuilder builder, ICalculateVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICalculateVar>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			StringOffset opOffset = (_o.Op == null) ? default(StringOffset) : builder.CreateString(_o.Op);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			TVarRef result_type = (_o.Result == null) ? TVarRef.NONE : _o.Result.Type;
			int resultOffset = (_o.Result == null) ? 0 : TVarRefUnion.Pack(builder, _o.Result);
			return ICalculateVar.CreateICalculateVar(builder, var1_type, var1Offset, opOffset, var2_type, var2Offset, result_type, resultOffset);
		}

		// Token: 0x040115DB RID: 71131
		private Table __p;
	}
}
