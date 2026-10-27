using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BCE RID: 19406
	public struct ICompareVarCondition : IFlatbufferObject
	{
		// Token: 0x17008CF5 RID: 36085
		// (get) Token: 0x0601EA1D RID: 125469 RVA: 0x00448BA3 File Offset: 0x00446DA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA1E RID: 125470 RVA: 0x00448BB0 File Offset: 0x00446DB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA1F RID: 125471 RVA: 0x00448BB8 File Offset: 0x00446DB8
		public static ICompareVarCondition GetRootAsICompareVarCondition(ByteBuffer _bb)
		{
			return ICompareVarCondition.GetRootAsICompareVarCondition(_bb, default(ICompareVarCondition));
		}

		// Token: 0x0601EA20 RID: 125472 RVA: 0x00448BD4 File Offset: 0x00446DD4
		public static ICompareVarCondition GetRootAsICompareVarCondition(ByteBuffer _bb, ICompareVarCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA21 RID: 125473 RVA: 0x00448BF1 File Offset: 0x00446DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA22 RID: 125474 RVA: 0x00448C00 File Offset: 0x00446E00
		public ICompareVarCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CF6 RID: 36086
		// (get) Token: 0x0601EA23 RID: 125475 RVA: 0x00448C10 File Offset: 0x00446E10
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CF7 RID: 36087
		// (get) Token: 0x0601EA24 RID: 125476 RVA: 0x00448C4C File Offset: 0x00446E4C
		public TVarRef Var1Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EA25 RID: 125477 RVA: 0x00448C88 File Offset: 0x00446E88
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EA26 RID: 125478 RVA: 0x00448CCC File Offset: 0x00446ECC
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0601EA27 RID: 125479 RVA: 0x00448CE8 File Offset: 0x00446EE8
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0601EA28 RID: 125480 RVA: 0x00448D04 File Offset: 0x00446F04
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0601EA29 RID: 125481 RVA: 0x00448D20 File Offset: 0x00446F20
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0601EA2A RID: 125482 RVA: 0x00448D3C File Offset: 0x00446F3C
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17008CF8 RID: 36088
		// (get) Token: 0x0601EA2B RID: 125483 RVA: 0x00448D58 File Offset: 0x00446F58
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CF9 RID: 36089
		// (get) Token: 0x0601EA2C RID: 125484 RVA: 0x00448D98 File Offset: 0x00446F98
		public TVarRef Var2Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EA2D RID: 125485 RVA: 0x00448DD8 File Offset: 0x00446FD8
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EA2E RID: 125486 RVA: 0x00448E20 File Offset: 0x00447020
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0601EA2F RID: 125487 RVA: 0x00448E3C File Offset: 0x0044703C
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0601EA30 RID: 125488 RVA: 0x00448E58 File Offset: 0x00447058
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0601EA31 RID: 125489 RVA: 0x00448E74 File Offset: 0x00447074
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0601EA32 RID: 125490 RVA: 0x00448E90 File Offset: 0x00447090
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x0601EA33 RID: 125491 RVA: 0x00448EAB File Offset: 0x004470AB
		public static Offset<ICompareVarCondition> CreateICompareVarCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, ECompare Compare = ECompare.Eq, TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0)
		{
			builder.StartTable(6);
			ICompareVarCondition.AddVar2(builder, Var2Offset);
			ICompareVarCondition.AddVar1(builder, Var1Offset);
			ICompareVarCondition.AddVar2Type(builder, Var2_type);
			ICompareVarCondition.AddCompare(builder, Compare);
			ICompareVarCondition.AddVar1Type(builder, Var1_type);
			ICompareVarCondition.AddType(builder, Type);
			return ICompareVarCondition.EndICompareVarCondition(builder);
		}

		// Token: 0x0601EA34 RID: 125492 RVA: 0x00448EE7 File Offset: 0x004470E7
		public static void StartICompareVarCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601EA35 RID: 125493 RVA: 0x00448EF0 File Offset: 0x004470F0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EA36 RID: 125494 RVA: 0x00448EFB File Offset: 0x004470FB
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(1, (byte)var1Type, 0);
		}

		// Token: 0x0601EA37 RID: 125495 RVA: 0x00448F06 File Offset: 0x00447106
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(2, var1Offset, 0);
		}

		// Token: 0x0601EA38 RID: 125496 RVA: 0x00448F11 File Offset: 0x00447111
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601EA39 RID: 125497 RVA: 0x00448F1C File Offset: 0x0044711C
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(4, (byte)var2Type, 0);
		}

		// Token: 0x0601EA3A RID: 125498 RVA: 0x00448F27 File Offset: 0x00447127
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(5, var2Offset, 0);
		}

		// Token: 0x0601EA3B RID: 125499 RVA: 0x00448F32 File Offset: 0x00447132
		public static Offset<ICompareVarCondition> EndICompareVarCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarCondition>(builder.EndTable());
		}

		// Token: 0x0601EA3C RID: 125500 RVA: 0x00448F40 File Offset: 0x00447140
		public ICompareVarConditionT UnPack()
		{
			ICompareVarConditionT compareVarConditionT = new ICompareVarConditionT();
			this.UnPackTo(compareVarConditionT);
			return compareVarConditionT;
		}

		// Token: 0x0601EA3D RID: 125501 RVA: 0x00448F5C File Offset: 0x0044715C
		public void UnPackTo(ICompareVarConditionT _o)
		{
			_o.Type = this.Type;
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
			_o.Compare = this.Compare;
			_o.Var2 = new TVarRefUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var2.Value = ((this.Var2<IConstVarRef>() != null) ? this.Var2<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var2.Value = ((this.Var2<IGlobalVarRef>() != null) ? this.Var2<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var2.Value = ((this.Var2<IOtherVarRef>() != null) ? this.Var2<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var2.Value = ((this.Var2<ISelfVarRef>() != null) ? this.Var2<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var2.Value = ((this.Var2<ISystemVarRef>() != null) ? this.Var2<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601EA3E RID: 125502 RVA: 0x00449234 File Offset: 0x00447434
		public static Offset<ICompareVarCondition> Pack(FlatBufferBuilder builder, ICompareVarConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVarCondition>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			return ICompareVarCondition.CreateICompareVarCondition(builder, _o.Type, var1_type, var1Offset, _o.Compare, var2_type, var2Offset);
		}

		// Token: 0x0400D4BD RID: 54461
		private Table __p;
	}
}
