using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B8 RID: 20664
	public struct ICompareVar : IFlatbufferObject
	{
		// Token: 0x17009410 RID: 37904
		// (get) Token: 0x060205BF RID: 132543 RVA: 0x0047B274 File Offset: 0x00479474
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060205C0 RID: 132544 RVA: 0x0047B281 File Offset: 0x00479481
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060205C1 RID: 132545 RVA: 0x0047B288 File Offset: 0x00479488
		public static ICompareVar GetRootAsICompareVar(ByteBuffer _bb)
		{
			return ICompareVar.GetRootAsICompareVar(_bb, default(ICompareVar));
		}

		// Token: 0x060205C2 RID: 132546 RVA: 0x0047B2A4 File Offset: 0x004794A4
		public static ICompareVar GetRootAsICompareVar(ByteBuffer _bb, ICompareVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060205C3 RID: 132547 RVA: 0x0047B2C1 File Offset: 0x004794C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060205C4 RID: 132548 RVA: 0x0047B2D0 File Offset: 0x004794D0
		public ICompareVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009411 RID: 37905
		// (get) Token: 0x060205C5 RID: 132549 RVA: 0x0047B2E0 File Offset: 0x004794E0
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009412 RID: 37906
		// (get) Token: 0x060205C6 RID: 132550 RVA: 0x0047B31C File Offset: 0x0047951C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009413 RID: 37907
		// (get) Token: 0x060205C7 RID: 132551 RVA: 0x0047B358 File Offset: 0x00479558
		public TVarRef Var1Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060205C8 RID: 132552 RVA: 0x0047B394 File Offset: 0x00479594
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060205C9 RID: 132553 RVA: 0x0047B3DC File Offset: 0x004795DC
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x060205CA RID: 132554 RVA: 0x0047B3F8 File Offset: 0x004795F8
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x060205CB RID: 132555 RVA: 0x0047B414 File Offset: 0x00479614
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x060205CC RID: 132556 RVA: 0x0047B430 File Offset: 0x00479630
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x060205CD RID: 132557 RVA: 0x0047B44C File Offset: 0x0047964C
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17009414 RID: 37908
		// (get) Token: 0x060205CE RID: 132558 RVA: 0x0047B468 File Offset: 0x00479668
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

		// Token: 0x060205CF RID: 132559 RVA: 0x0047B4A8 File Offset: 0x004796A8
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060205D0 RID: 132560 RVA: 0x0047B4F0 File Offset: 0x004796F0
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x060205D1 RID: 132561 RVA: 0x0047B50C File Offset: 0x0047970C
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x060205D2 RID: 132562 RVA: 0x0047B528 File Offset: 0x00479728
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x060205D3 RID: 132563 RVA: 0x0047B544 File Offset: 0x00479744
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x060205D4 RID: 132564 RVA: 0x0047B560 File Offset: 0x00479760
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x060205D5 RID: 132565 RVA: 0x0047B57B File Offset: 0x0047977B
		public static Offset<ICompareVar> CreateICompareVar(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0)
		{
			builder.StartTable(6);
			ICompareVar.AddVar2(builder, Var2Offset);
			ICompareVar.AddVar1(builder, Var1Offset);
			ICompareVar.AddVar2Type(builder, Var2_type);
			ICompareVar.AddVar1Type(builder, Var1_type);
			ICompareVar.AddCompare(builder, Compare);
			ICompareVar.AddType(builder, Type);
			return ICompareVar.EndICompareVar(builder);
		}

		// Token: 0x060205D6 RID: 132566 RVA: 0x0047B5B7 File Offset: 0x004797B7
		public static void StartICompareVar(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060205D7 RID: 132567 RVA: 0x0047B5C0 File Offset: 0x004797C0
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060205D8 RID: 132568 RVA: 0x0047B5CB File Offset: 0x004797CB
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060205D9 RID: 132569 RVA: 0x0047B5D6 File Offset: 0x004797D6
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(2, (byte)var1Type, 0);
		}

		// Token: 0x060205DA RID: 132570 RVA: 0x0047B5E1 File Offset: 0x004797E1
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(3, var1Offset, 0);
		}

		// Token: 0x060205DB RID: 132571 RVA: 0x0047B5EC File Offset: 0x004797EC
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(4, (byte)var2Type, 0);
		}

		// Token: 0x060205DC RID: 132572 RVA: 0x0047B5F7 File Offset: 0x004797F7
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(5, var2Offset, 0);
		}

		// Token: 0x060205DD RID: 132573 RVA: 0x0047B602 File Offset: 0x00479802
		public static Offset<ICompareVar> EndICompareVar(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVar>(builder.EndTable());
		}

		// Token: 0x060205DE RID: 132574 RVA: 0x0047B610 File Offset: 0x00479810
		public ICompareVarT UnPack()
		{
			ICompareVarT compareVarT = new ICompareVarT();
			this.UnPackTo(compareVarT);
			return compareVarT;
		}

		// Token: 0x060205DF RID: 132575 RVA: 0x0047B62C File Offset: 0x0047982C
		public void UnPackTo(ICompareVarT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
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

		// Token: 0x060205E0 RID: 132576 RVA: 0x0047B904 File Offset: 0x00479B04
		public static Offset<ICompareVar> Pack(FlatBufferBuilder builder, ICompareVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareVar>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			return ICompareVar.CreateICompareVar(builder, _o.Type, _o.Compare, var1_type, var1Offset, var2_type, var2Offset);
		}

		// Token: 0x0400DFC3 RID: 57283
		private Table __p;
	}
}
