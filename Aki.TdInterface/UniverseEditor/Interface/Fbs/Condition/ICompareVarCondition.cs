using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050BB RID: 20667
	public struct ICompareVarCondition : IFlatbufferObject
	{
		// Token: 0x17009419 RID: 37913
		// (get) Token: 0x060205EB RID: 132587 RVA: 0x0047BAAF File Offset: 0x00479CAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060205EC RID: 132588 RVA: 0x0047BABC File Offset: 0x00479CBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060205ED RID: 132589 RVA: 0x0047BAC4 File Offset: 0x00479CC4
		public static ICompareVarCondition GetRootAsICompareVarCondition(ByteBuffer _bb)
		{
			return ICompareVarCondition.GetRootAsICompareVarCondition(_bb, default(ICompareVarCondition));
		}

		// Token: 0x060205EE RID: 132590 RVA: 0x0047BAE0 File Offset: 0x00479CE0
		public static ICompareVarCondition GetRootAsICompareVarCondition(ByteBuffer _bb, ICompareVarCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060205EF RID: 132591 RVA: 0x0047BAFD File Offset: 0x00479CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060205F0 RID: 132592 RVA: 0x0047BB0C File Offset: 0x00479D0C
		public ICompareVarCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700941A RID: 37914
		// (get) Token: 0x060205F1 RID: 132593 RVA: 0x0047BB1C File Offset: 0x00479D1C
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

		// Token: 0x1700941B RID: 37915
		// (get) Token: 0x060205F2 RID: 132594 RVA: 0x0047BB58 File Offset: 0x00479D58
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

		// Token: 0x060205F3 RID: 132595 RVA: 0x0047BB94 File Offset: 0x00479D94
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060205F4 RID: 132596 RVA: 0x0047BBD8 File Offset: 0x00479DD8
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x060205F5 RID: 132597 RVA: 0x0047BBF4 File Offset: 0x00479DF4
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x060205F6 RID: 132598 RVA: 0x0047BC10 File Offset: 0x00479E10
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x060205F7 RID: 132599 RVA: 0x0047BC2C File Offset: 0x00479E2C
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x060205F8 RID: 132600 RVA: 0x0047BC48 File Offset: 0x00479E48
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700941C RID: 37916
		// (get) Token: 0x060205F9 RID: 132601 RVA: 0x0047BC64 File Offset: 0x00479E64
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

		// Token: 0x1700941D RID: 37917
		// (get) Token: 0x060205FA RID: 132602 RVA: 0x0047BCA4 File Offset: 0x00479EA4
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

		// Token: 0x060205FB RID: 132603 RVA: 0x0047BCE4 File Offset: 0x00479EE4
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060205FC RID: 132604 RVA: 0x0047BD2C File Offset: 0x00479F2C
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x060205FD RID: 132605 RVA: 0x0047BD48 File Offset: 0x00479F48
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x060205FE RID: 132606 RVA: 0x0047BD64 File Offset: 0x00479F64
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x060205FF RID: 132607 RVA: 0x0047BD80 File Offset: 0x00479F80
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x06020600 RID: 132608 RVA: 0x0047BD9C File Offset: 0x00479F9C
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x06020601 RID: 132609 RVA: 0x0047BDB7 File Offset: 0x00479FB7
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

		// Token: 0x06020602 RID: 132610 RVA: 0x0047BDF3 File Offset: 0x00479FF3
		public static void StartICompareVarCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06020603 RID: 132611 RVA: 0x0047BDFC File Offset: 0x00479FFC
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020604 RID: 132612 RVA: 0x0047BE07 File Offset: 0x0047A007
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(1, (byte)var1Type, 0);
		}

		// Token: 0x06020605 RID: 132613 RVA: 0x0047BE12 File Offset: 0x0047A012
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(2, var1Offset, 0);
		}

		// Token: 0x06020606 RID: 132614 RVA: 0x0047BE1D File Offset: 0x0047A01D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x06020607 RID: 132615 RVA: 0x0047BE28 File Offset: 0x0047A028
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(4, (byte)var2Type, 0);
		}

		// Token: 0x06020608 RID: 132616 RVA: 0x0047BE33 File Offset: 0x0047A033
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(5, var2Offset, 0);
		}

		// Token: 0x06020609 RID: 132617 RVA: 0x0047BE3E File Offset: 0x0047A03E
		public static Offset<ICompareVarCondition> EndICompareVarCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVarCondition>(builder.EndTable());
		}

		// Token: 0x0602060A RID: 132618 RVA: 0x0047BE4C File Offset: 0x0047A04C
		public ICompareVarConditionT UnPack()
		{
			ICompareVarConditionT compareVarConditionT = new ICompareVarConditionT();
			this.UnPackTo(compareVarConditionT);
			return compareVarConditionT;
		}

		// Token: 0x0602060B RID: 132619 RVA: 0x0047BE68 File Offset: 0x0047A068
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

		// Token: 0x0602060C RID: 132620 RVA: 0x0047C140 File Offset: 0x0047A340
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

		// Token: 0x0400DFC8 RID: 57288
		private Table __p;
	}
}
