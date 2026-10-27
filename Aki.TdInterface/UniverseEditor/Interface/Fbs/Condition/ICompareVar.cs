using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BCB RID: 19403
	public struct ICompareVar : IFlatbufferObject
	{
		// Token: 0x17008CEC RID: 36076
		// (get) Token: 0x0601E9F1 RID: 125425 RVA: 0x00448368 File Offset: 0x00446568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9F2 RID: 125426 RVA: 0x00448375 File Offset: 0x00446575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9F3 RID: 125427 RVA: 0x0044837C File Offset: 0x0044657C
		public static ICompareVar GetRootAsICompareVar(ByteBuffer _bb)
		{
			return ICompareVar.GetRootAsICompareVar(_bb, default(ICompareVar));
		}

		// Token: 0x0601E9F4 RID: 125428 RVA: 0x00448398 File Offset: 0x00446598
		public static ICompareVar GetRootAsICompareVar(ByteBuffer _bb, ICompareVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E9F5 RID: 125429 RVA: 0x004483B5 File Offset: 0x004465B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E9F6 RID: 125430 RVA: 0x004483C4 File Offset: 0x004465C4
		public ICompareVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CED RID: 36077
		// (get) Token: 0x0601E9F7 RID: 125431 RVA: 0x004483D4 File Offset: 0x004465D4
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

		// Token: 0x17008CEE RID: 36078
		// (get) Token: 0x0601E9F8 RID: 125432 RVA: 0x00448410 File Offset: 0x00446610
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

		// Token: 0x17008CEF RID: 36079
		// (get) Token: 0x0601E9F9 RID: 125433 RVA: 0x0044844C File Offset: 0x0044664C
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

		// Token: 0x0601E9FA RID: 125434 RVA: 0x00448488 File Offset: 0x00446688
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E9FB RID: 125435 RVA: 0x004484D0 File Offset: 0x004466D0
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0601E9FC RID: 125436 RVA: 0x004484EC File Offset: 0x004466EC
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0601E9FD RID: 125437 RVA: 0x00448508 File Offset: 0x00446708
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0601E9FE RID: 125438 RVA: 0x00448524 File Offset: 0x00446724
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0601E9FF RID: 125439 RVA: 0x00448540 File Offset: 0x00446740
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17008CF0 RID: 36080
		// (get) Token: 0x0601EA00 RID: 125440 RVA: 0x0044855C File Offset: 0x0044675C
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

		// Token: 0x0601EA01 RID: 125441 RVA: 0x0044859C File Offset: 0x0044679C
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EA02 RID: 125442 RVA: 0x004485E4 File Offset: 0x004467E4
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0601EA03 RID: 125443 RVA: 0x00448600 File Offset: 0x00446800
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0601EA04 RID: 125444 RVA: 0x0044861C File Offset: 0x0044681C
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0601EA05 RID: 125445 RVA: 0x00448638 File Offset: 0x00446838
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0601EA06 RID: 125446 RVA: 0x00448654 File Offset: 0x00446854
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x0601EA07 RID: 125447 RVA: 0x0044866F File Offset: 0x0044686F
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

		// Token: 0x0601EA08 RID: 125448 RVA: 0x004486AB File Offset: 0x004468AB
		public static void StartICompareVar(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601EA09 RID: 125449 RVA: 0x004486B4 File Offset: 0x004468B4
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EA0A RID: 125450 RVA: 0x004486BF File Offset: 0x004468BF
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EA0B RID: 125451 RVA: 0x004486CA File Offset: 0x004468CA
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(2, (byte)var1Type, 0);
		}

		// Token: 0x0601EA0C RID: 125452 RVA: 0x004486D5 File Offset: 0x004468D5
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(3, var1Offset, 0);
		}

		// Token: 0x0601EA0D RID: 125453 RVA: 0x004486E0 File Offset: 0x004468E0
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(4, (byte)var2Type, 0);
		}

		// Token: 0x0601EA0E RID: 125454 RVA: 0x004486EB File Offset: 0x004468EB
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(5, var2Offset, 0);
		}

		// Token: 0x0601EA0F RID: 125455 RVA: 0x004486F6 File Offset: 0x004468F6
		public static Offset<ICompareVar> EndICompareVar(FlatBufferBuilder builder)
		{
			return new Offset<ICompareVar>(builder.EndTable());
		}

		// Token: 0x0601EA10 RID: 125456 RVA: 0x00448704 File Offset: 0x00446904
		public ICompareVarT UnPack()
		{
			ICompareVarT compareVarT = new ICompareVarT();
			this.UnPackTo(compareVarT);
			return compareVarT;
		}

		// Token: 0x0601EA11 RID: 125457 RVA: 0x00448720 File Offset: 0x00446920
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

		// Token: 0x0601EA12 RID: 125458 RVA: 0x004489F8 File Offset: 0x00446BF8
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

		// Token: 0x0400D4B8 RID: 54456
		private Table __p;
	}
}
