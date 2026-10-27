using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B08 RID: 15112
	public struct IVarInterval : IFlatbufferObject
	{
		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x060149D9 RID: 84441 RVA: 0x003004F2 File Offset: 0x002FE6F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060149DA RID: 84442 RVA: 0x003004FF File Offset: 0x002FE6FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060149DB RID: 84443 RVA: 0x00300508 File Offset: 0x002FE708
		public static IVarInterval GetRootAsIVarInterval(ByteBuffer _bb)
		{
			return IVarInterval.GetRootAsIVarInterval(_bb, default(IVarInterval));
		}

		// Token: 0x060149DC RID: 84444 RVA: 0x00300524 File Offset: 0x002FE724
		public static IVarInterval GetRootAsIVarInterval(ByteBuffer _bb, IVarInterval obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060149DD RID: 84445 RVA: 0x00300541 File Offset: 0x002FE741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060149DE RID: 84446 RVA: 0x00300550 File Offset: 0x002FE750
		public IVarInterval __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x060149DF RID: 84447 RVA: 0x00300560 File Offset: 0x002FE760
		public TVarRef VarMinType
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

		// Token: 0x060149E0 RID: 84448 RVA: 0x0030059C File Offset: 0x002FE79C
		public TTable? VarMin<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060149E1 RID: 84449 RVA: 0x003005E0 File Offset: 0x002FE7E0
		public IConstVarRef VarMinAsIConstVarRef()
		{
			return this.VarMin<IConstVarRef>().Value;
		}

		// Token: 0x060149E2 RID: 84450 RVA: 0x003005FC File Offset: 0x002FE7FC
		public IGlobalVarRef VarMinAsIGlobalVarRef()
		{
			return this.VarMin<IGlobalVarRef>().Value;
		}

		// Token: 0x060149E3 RID: 84451 RVA: 0x00300618 File Offset: 0x002FE818
		public IOtherVarRef VarMinAsIOtherVarRef()
		{
			return this.VarMin<IOtherVarRef>().Value;
		}

		// Token: 0x060149E4 RID: 84452 RVA: 0x00300634 File Offset: 0x002FE834
		public ISelfVarRef VarMinAsISelfVarRef()
		{
			return this.VarMin<ISelfVarRef>().Value;
		}

		// Token: 0x060149E5 RID: 84453 RVA: 0x00300650 File Offset: 0x002FE850
		public ISystemVarRef VarMinAsISystemVarRef()
		{
			return this.VarMin<ISystemVarRef>().Value;
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x060149E6 RID: 84454 RVA: 0x0030066C File Offset: 0x002FE86C
		public TVarRef VarMaxType
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

		// Token: 0x060149E7 RID: 84455 RVA: 0x003006A8 File Offset: 0x002FE8A8
		public TTable? VarMax<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060149E8 RID: 84456 RVA: 0x003006F0 File Offset: 0x002FE8F0
		public IConstVarRef VarMaxAsIConstVarRef()
		{
			return this.VarMax<IConstVarRef>().Value;
		}

		// Token: 0x060149E9 RID: 84457 RVA: 0x0030070C File Offset: 0x002FE90C
		public IGlobalVarRef VarMaxAsIGlobalVarRef()
		{
			return this.VarMax<IGlobalVarRef>().Value;
		}

		// Token: 0x060149EA RID: 84458 RVA: 0x00300728 File Offset: 0x002FE928
		public IOtherVarRef VarMaxAsIOtherVarRef()
		{
			return this.VarMax<IOtherVarRef>().Value;
		}

		// Token: 0x060149EB RID: 84459 RVA: 0x00300744 File Offset: 0x002FE944
		public ISelfVarRef VarMaxAsISelfVarRef()
		{
			return this.VarMax<ISelfVarRef>().Value;
		}

		// Token: 0x060149EC RID: 84460 RVA: 0x00300760 File Offset: 0x002FE960
		public ISystemVarRef VarMaxAsISystemVarRef()
		{
			return this.VarMax<ISystemVarRef>().Value;
		}

		// Token: 0x060149ED RID: 84461 RVA: 0x0030077B File Offset: 0x002FE97B
		public static Offset<IVarInterval> CreateIVarInterval(FlatBufferBuilder builder, TVarRef VarMin_type = TVarRef.NONE, int VarMinOffset = 0, TVarRef VarMax_type = TVarRef.NONE, int VarMaxOffset = 0)
		{
			builder.StartTable(4);
			IVarInterval.AddVarMax(builder, VarMaxOffset);
			IVarInterval.AddVarMin(builder, VarMinOffset);
			IVarInterval.AddVarMaxType(builder, VarMax_type);
			IVarInterval.AddVarMinType(builder, VarMin_type);
			return IVarInterval.EndIVarInterval(builder);
		}

		// Token: 0x060149EE RID: 84462 RVA: 0x003007A7 File Offset: 0x002FE9A7
		public static void StartIVarInterval(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060149EF RID: 84463 RVA: 0x003007B0 File Offset: 0x002FE9B0
		public static void AddVarMinType(FlatBufferBuilder builder, TVarRef varMinType)
		{
			builder.AddByte(0, (byte)varMinType, 0);
		}

		// Token: 0x060149F0 RID: 84464 RVA: 0x003007BB File Offset: 0x002FE9BB
		public static void AddVarMin(FlatBufferBuilder builder, int varMinOffset)
		{
			builder.AddOffset(1, varMinOffset, 0);
		}

		// Token: 0x060149F1 RID: 84465 RVA: 0x003007C6 File Offset: 0x002FE9C6
		public static void AddVarMaxType(FlatBufferBuilder builder, TVarRef varMaxType)
		{
			builder.AddByte(2, (byte)varMaxType, 0);
		}

		// Token: 0x060149F2 RID: 84466 RVA: 0x003007D1 File Offset: 0x002FE9D1
		public static void AddVarMax(FlatBufferBuilder builder, int varMaxOffset)
		{
			builder.AddOffset(3, varMaxOffset, 0);
		}

		// Token: 0x060149F3 RID: 84467 RVA: 0x003007DC File Offset: 0x002FE9DC
		public static Offset<IVarInterval> EndIVarInterval(FlatBufferBuilder builder)
		{
			return new Offset<IVarInterval>(builder.EndTable());
		}

		// Token: 0x060149F4 RID: 84468 RVA: 0x003007EC File Offset: 0x002FE9EC
		public IVarIntervalT UnPack()
		{
			IVarIntervalT varIntervalT = new IVarIntervalT();
			this.UnPackTo(varIntervalT);
			return varIntervalT;
		}

		// Token: 0x060149F5 RID: 84469 RVA: 0x00300808 File Offset: 0x002FEA08
		public void UnPackTo(IVarIntervalT _o)
		{
			_o.VarMin = new TVarRefUnion();
			_o.VarMin.Type = this.VarMinType;
			switch (this.VarMinType)
			{
			case TVarRef.IConstVarRef:
				_o.VarMin.Value = ((this.VarMin<IConstVarRef>() != null) ? this.VarMin<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.VarMin.Value = ((this.VarMin<IGlobalVarRef>() != null) ? this.VarMin<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.VarMin.Value = ((this.VarMin<IOtherVarRef>() != null) ? this.VarMin<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.VarMin.Value = ((this.VarMin<ISelfVarRef>() != null) ? this.VarMin<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.VarMin.Value = ((this.VarMin<ISystemVarRef>() != null) ? this.VarMin<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.VarMax = new TVarRefUnion();
			_o.VarMax.Type = this.VarMaxType;
			switch (this.VarMaxType)
			{
			case TVarRef.IConstVarRef:
				_o.VarMax.Value = ((this.VarMax<IConstVarRef>() != null) ? this.VarMax<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarMax.Value = ((this.VarMax<IGlobalVarRef>() != null) ? this.VarMax<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarMax.Value = ((this.VarMax<IOtherVarRef>() != null) ? this.VarMax<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarMax.Value = ((this.VarMax<ISelfVarRef>() != null) ? this.VarMax<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarMax.Value = ((this.VarMax<ISystemVarRef>() != null) ? this.VarMax<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060149F6 RID: 84470 RVA: 0x00300AC8 File Offset: 0x002FECC8
		public static Offset<IVarInterval> Pack(FlatBufferBuilder builder, IVarIntervalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarInterval>);
			}
			TVarRef varMin_type = (_o.VarMin == null) ? TVarRef.NONE : _o.VarMin.Type;
			int varMinOffset = (_o.VarMin == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarMin);
			TVarRef varMax_type = (_o.VarMax == null) ? TVarRef.NONE : _o.VarMax.Type;
			int varMaxOffset = (_o.VarMax == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarMax);
			return IVarInterval.CreateIVarInterval(builder, varMin_type, varMinOffset, varMax_type, varMaxOffset);
		}

		// Token: 0x0400AFD6 RID: 45014
		private Table __p;
	}
}
