using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200626C RID: 25196
	public struct ICalculateVar : IFlatbufferObject
	{
		// Token: 0x1700BBC0 RID: 48064
		// (get) Token: 0x0602B79A RID: 178074 RVA: 0x005FC314 File Offset: 0x005FA514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B79B RID: 178075 RVA: 0x005FC321 File Offset: 0x005FA521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B79C RID: 178076 RVA: 0x005FC328 File Offset: 0x005FA528
		public static ICalculateVar GetRootAsICalculateVar(ByteBuffer _bb)
		{
			return ICalculateVar.GetRootAsICalculateVar(_bb, default(ICalculateVar));
		}

		// Token: 0x0602B79D RID: 178077 RVA: 0x005FC344 File Offset: 0x005FA544
		public static ICalculateVar GetRootAsICalculateVar(ByteBuffer _bb, ICalculateVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B79E RID: 178078 RVA: 0x005FC361 File Offset: 0x005FA561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B79F RID: 178079 RVA: 0x005FC370 File Offset: 0x005FA570
		public ICalculateVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBC1 RID: 48065
		// (get) Token: 0x0602B7A0 RID: 178080 RVA: 0x005FC380 File Offset: 0x005FA580
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

		// Token: 0x0602B7A1 RID: 178081 RVA: 0x005FC3BC File Offset: 0x005FA5BC
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B7A2 RID: 178082 RVA: 0x005FC400 File Offset: 0x005FA600
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0602B7A3 RID: 178083 RVA: 0x005FC41C File Offset: 0x005FA61C
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B7A4 RID: 178084 RVA: 0x005FC438 File Offset: 0x005FA638
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0602B7A5 RID: 178085 RVA: 0x005FC454 File Offset: 0x005FA654
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0602B7A6 RID: 178086 RVA: 0x005FC470 File Offset: 0x005FA670
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700BBC2 RID: 48066
		// (get) Token: 0x0602B7A7 RID: 178087 RVA: 0x005FC48C File Offset: 0x005FA68C
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

		// Token: 0x0602B7A8 RID: 178088 RVA: 0x005FC4C3 File Offset: 0x005FA6C3
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602B7A9 RID: 178089 RVA: 0x005FC4D2 File Offset: 0x005FA6D2
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BBC3 RID: 48067
		// (get) Token: 0x0602B7AA RID: 178090 RVA: 0x005FC4E0 File Offset: 0x005FA6E0
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

		// Token: 0x0602B7AB RID: 178091 RVA: 0x005FC520 File Offset: 0x005FA720
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B7AC RID: 178092 RVA: 0x005FC568 File Offset: 0x005FA768
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0602B7AD RID: 178093 RVA: 0x005FC584 File Offset: 0x005FA784
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B7AE RID: 178094 RVA: 0x005FC5A0 File Offset: 0x005FA7A0
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0602B7AF RID: 178095 RVA: 0x005FC5BC File Offset: 0x005FA7BC
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0602B7B0 RID: 178096 RVA: 0x005FC5D8 File Offset: 0x005FA7D8
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x1700BBC4 RID: 48068
		// (get) Token: 0x0602B7B1 RID: 178097 RVA: 0x005FC5F4 File Offset: 0x005FA7F4
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

		// Token: 0x0602B7B2 RID: 178098 RVA: 0x005FC634 File Offset: 0x005FA834
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B7B3 RID: 178099 RVA: 0x005FC67C File Offset: 0x005FA87C
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x0602B7B4 RID: 178100 RVA: 0x005FC698 File Offset: 0x005FA898
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B7B5 RID: 178101 RVA: 0x005FC6B4 File Offset: 0x005FA8B4
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x0602B7B6 RID: 178102 RVA: 0x005FC6D0 File Offset: 0x005FA8D0
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x0602B7B7 RID: 178103 RVA: 0x005FC6EC File Offset: 0x005FA8EC
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x0602B7B8 RID: 178104 RVA: 0x005FC708 File Offset: 0x005FA908
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

		// Token: 0x0602B7B9 RID: 178105 RVA: 0x005FC757 File Offset: 0x005FA957
		public static void StartICalculateVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602B7BA RID: 178106 RVA: 0x005FC760 File Offset: 0x005FA960
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602B7BB RID: 178107 RVA: 0x005FC76B File Offset: 0x005FA96B
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602B7BC RID: 178108 RVA: 0x005FC776 File Offset: 0x005FA976
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602B7BD RID: 178109 RVA: 0x005FC786 File Offset: 0x005FA986
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602B7BE RID: 178110 RVA: 0x005FC791 File Offset: 0x005FA991
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602B7BF RID: 178111 RVA: 0x005FC79C File Offset: 0x005FA99C
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(5, (byte)resultType, 0);
		}

		// Token: 0x0602B7C0 RID: 178112 RVA: 0x005FC7A7 File Offset: 0x005FA9A7
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(6, resultOffset, 0);
		}

		// Token: 0x0602B7C1 RID: 178113 RVA: 0x005FC7B2 File Offset: 0x005FA9B2
		public static Offset<ICalculateVar> EndICalculateVar(FlatBufferBuilder builder)
		{
			return new Offset<ICalculateVar>(builder.EndTable());
		}

		// Token: 0x0602B7C2 RID: 178114 RVA: 0x005FC7C0 File Offset: 0x005FA9C0
		public ICalculateVarT UnPack()
		{
			ICalculateVarT calculateVarT = new ICalculateVarT();
			this.UnPackTo(calculateVarT);
			return calculateVarT;
		}

		// Token: 0x0602B7C3 RID: 178115 RVA: 0x005FC7DC File Offset: 0x005FA9DC
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

		// Token: 0x0602B7C4 RID: 178116 RVA: 0x005FCC08 File Offset: 0x005FAE08
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

		// Token: 0x040107C6 RID: 67526
		private Table __p;
	}
}
