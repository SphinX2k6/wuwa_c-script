using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADF RID: 27359
	public struct ICommonCalculateVar : IFlatbufferObject
	{
		// Token: 0x1700C8E3 RID: 51427
		// (get) Token: 0x0602F01C RID: 192540 RVA: 0x0066930A File Offset: 0x0066750A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F01D RID: 192541 RVA: 0x00669317 File Offset: 0x00667517
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F01E RID: 192542 RVA: 0x00669320 File Offset: 0x00667520
		public static ICommonCalculateVar GetRootAsICommonCalculateVar(ByteBuffer _bb)
		{
			return ICommonCalculateVar.GetRootAsICommonCalculateVar(_bb, default(ICommonCalculateVar));
		}

		// Token: 0x0602F01F RID: 192543 RVA: 0x0066933C File Offset: 0x0066753C
		public static ICommonCalculateVar GetRootAsICommonCalculateVar(ByteBuffer _bb, ICommonCalculateVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F020 RID: 192544 RVA: 0x00669359 File Offset: 0x00667559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F021 RID: 192545 RVA: 0x00669368 File Offset: 0x00667568
		public ICommonCalculateVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8E4 RID: 51428
		// (get) Token: 0x0602F022 RID: 192546 RVA: 0x00669378 File Offset: 0x00667578
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

		// Token: 0x0602F023 RID: 192547 RVA: 0x006693B4 File Offset: 0x006675B4
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F024 RID: 192548 RVA: 0x006693F8 File Offset: 0x006675F8
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0602F025 RID: 192549 RVA: 0x00669414 File Offset: 0x00667614
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0602F026 RID: 192550 RVA: 0x00669430 File Offset: 0x00667630
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0602F027 RID: 192551 RVA: 0x0066944C File Offset: 0x0066764C
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0602F028 RID: 192552 RVA: 0x00669468 File Offset: 0x00667668
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700C8E5 RID: 51429
		// (get) Token: 0x0602F029 RID: 192553 RVA: 0x00669484 File Offset: 0x00667684
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

		// Token: 0x0602F02A RID: 192554 RVA: 0x006694BB File Offset: 0x006676BB
		public Span<byte> GetOpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F02B RID: 192555 RVA: 0x006694CA File Offset: 0x006676CA
		public byte[] GetOpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C8E6 RID: 51430
		// (get) Token: 0x0602F02C RID: 192556 RVA: 0x006694D8 File Offset: 0x006676D8
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

		// Token: 0x0602F02D RID: 192557 RVA: 0x00669518 File Offset: 0x00667718
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F02E RID: 192558 RVA: 0x00669560 File Offset: 0x00667760
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0602F02F RID: 192559 RVA: 0x0066957C File Offset: 0x0066777C
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0602F030 RID: 192560 RVA: 0x00669598 File Offset: 0x00667798
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0602F031 RID: 192561 RVA: 0x006695B4 File Offset: 0x006677B4
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0602F032 RID: 192562 RVA: 0x006695D0 File Offset: 0x006677D0
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x1700C8E7 RID: 51431
		// (get) Token: 0x0602F033 RID: 192563 RVA: 0x006695EC File Offset: 0x006677EC
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

		// Token: 0x0602F034 RID: 192564 RVA: 0x0066962C File Offset: 0x0066782C
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F035 RID: 192565 RVA: 0x00669674 File Offset: 0x00667874
		public IConstVarRef ResultAsIConstVarRef()
		{
			return this.Result<IConstVarRef>().Value;
		}

		// Token: 0x0602F036 RID: 192566 RVA: 0x00669690 File Offset: 0x00667890
		public IGlobalVarRef ResultAsIGlobalVarRef()
		{
			return this.Result<IGlobalVarRef>().Value;
		}

		// Token: 0x0602F037 RID: 192567 RVA: 0x006696AC File Offset: 0x006678AC
		public IOtherVarRef ResultAsIOtherVarRef()
		{
			return this.Result<IOtherVarRef>().Value;
		}

		// Token: 0x0602F038 RID: 192568 RVA: 0x006696C8 File Offset: 0x006678C8
		public ISelfVarRef ResultAsISelfVarRef()
		{
			return this.Result<ISelfVarRef>().Value;
		}

		// Token: 0x0602F039 RID: 192569 RVA: 0x006696E4 File Offset: 0x006678E4
		public ISystemVarRef ResultAsISystemVarRef()
		{
			return this.Result<ISystemVarRef>().Value;
		}

		// Token: 0x0602F03A RID: 192570 RVA: 0x00669700 File Offset: 0x00667900
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

		// Token: 0x0602F03B RID: 192571 RVA: 0x0066974F File Offset: 0x0066794F
		public static void StartICommonCalculateVar(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602F03C RID: 192572 RVA: 0x00669758 File Offset: 0x00667958
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0602F03D RID: 192573 RVA: 0x00669763 File Offset: 0x00667963
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0602F03E RID: 192574 RVA: 0x0066976E File Offset: 0x0066796E
		public static void AddOp(FlatBufferBuilder builder, StringOffset opOffset)
		{
			builder.AddOffset(2, opOffset.Value, 0);
		}

		// Token: 0x0602F03F RID: 192575 RVA: 0x0066977E File Offset: 0x0066797E
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0602F040 RID: 192576 RVA: 0x00669789 File Offset: 0x00667989
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0602F041 RID: 192577 RVA: 0x00669794 File Offset: 0x00667994
		public static void AddResultType(FlatBufferBuilder builder, TVarRef resultType)
		{
			builder.AddByte(5, (byte)resultType, 0);
		}

		// Token: 0x0602F042 RID: 192578 RVA: 0x0066979F File Offset: 0x0066799F
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(6, resultOffset, 0);
		}

		// Token: 0x0602F043 RID: 192579 RVA: 0x006697AA File Offset: 0x006679AA
		public static Offset<ICommonCalculateVar> EndICommonCalculateVar(FlatBufferBuilder builder)
		{
			return new Offset<ICommonCalculateVar>(builder.EndTable());
		}

		// Token: 0x0602F044 RID: 192580 RVA: 0x006697B8 File Offset: 0x006679B8
		public ICommonCalculateVarT UnPack()
		{
			ICommonCalculateVarT commonCalculateVarT = new ICommonCalculateVarT();
			this.UnPackTo(commonCalculateVarT);
			return commonCalculateVarT;
		}

		// Token: 0x0602F045 RID: 192581 RVA: 0x006697D4 File Offset: 0x006679D4
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

		// Token: 0x0602F046 RID: 192582 RVA: 0x00669C00 File Offset: 0x00667E00
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

		// Token: 0x04011885 RID: 71813
		private Table __p;
	}
}
