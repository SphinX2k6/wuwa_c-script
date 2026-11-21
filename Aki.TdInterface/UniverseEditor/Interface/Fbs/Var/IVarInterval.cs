using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F0A RID: 16138
	public struct IVarInterval : IFlatbufferObject
	{
		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x06015E83 RID: 89731 RVA: 0x00326782 File Offset: 0x00324982
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E84 RID: 89732 RVA: 0x0032678F File Offset: 0x0032498F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E85 RID: 89733 RVA: 0x00326798 File Offset: 0x00324998
		public static IVarInterval GetRootAsIVarInterval(ByteBuffer _bb)
		{
			return IVarInterval.GetRootAsIVarInterval(_bb, default(IVarInterval));
		}

		// Token: 0x06015E86 RID: 89734 RVA: 0x003267B4 File Offset: 0x003249B4
		public static IVarInterval GetRootAsIVarInterval(ByteBuffer _bb, IVarInterval obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E87 RID: 89735 RVA: 0x003267D1 File Offset: 0x003249D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E88 RID: 89736 RVA: 0x003267E0 File Offset: 0x003249E0
		public IVarInterval __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x06015E89 RID: 89737 RVA: 0x003267F0 File Offset: 0x003249F0
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

		// Token: 0x06015E8A RID: 89738 RVA: 0x0032682C File Offset: 0x00324A2C
		public TTable? VarMin<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015E8B RID: 89739 RVA: 0x00326870 File Offset: 0x00324A70
		public IConstVarRef VarMinAsIConstVarRef()
		{
			return this.VarMin<IConstVarRef>().Value;
		}

		// Token: 0x06015E8C RID: 89740 RVA: 0x0032688C File Offset: 0x00324A8C
		public IGlobalVarRef VarMinAsIGlobalVarRef()
		{
			return this.VarMin<IGlobalVarRef>().Value;
		}

		// Token: 0x06015E8D RID: 89741 RVA: 0x003268A8 File Offset: 0x00324AA8
		public IOtherVarRef VarMinAsIOtherVarRef()
		{
			return this.VarMin<IOtherVarRef>().Value;
		}

		// Token: 0x06015E8E RID: 89742 RVA: 0x003268C4 File Offset: 0x00324AC4
		public ISelfVarRef VarMinAsISelfVarRef()
		{
			return this.VarMin<ISelfVarRef>().Value;
		}

		// Token: 0x06015E8F RID: 89743 RVA: 0x003268E0 File Offset: 0x00324AE0
		public ISystemVarRef VarMinAsISystemVarRef()
		{
			return this.VarMin<ISystemVarRef>().Value;
		}

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x06015E90 RID: 89744 RVA: 0x003268FC File Offset: 0x00324AFC
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

		// Token: 0x06015E91 RID: 89745 RVA: 0x00326938 File Offset: 0x00324B38
		public TTable? VarMax<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015E92 RID: 89746 RVA: 0x00326980 File Offset: 0x00324B80
		public IConstVarRef VarMaxAsIConstVarRef()
		{
			return this.VarMax<IConstVarRef>().Value;
		}

		// Token: 0x06015E93 RID: 89747 RVA: 0x0032699C File Offset: 0x00324B9C
		public IGlobalVarRef VarMaxAsIGlobalVarRef()
		{
			return this.VarMax<IGlobalVarRef>().Value;
		}

		// Token: 0x06015E94 RID: 89748 RVA: 0x003269B8 File Offset: 0x00324BB8
		public IOtherVarRef VarMaxAsIOtherVarRef()
		{
			return this.VarMax<IOtherVarRef>().Value;
		}

		// Token: 0x06015E95 RID: 89749 RVA: 0x003269D4 File Offset: 0x00324BD4
		public ISelfVarRef VarMaxAsISelfVarRef()
		{
			return this.VarMax<ISelfVarRef>().Value;
		}

		// Token: 0x06015E96 RID: 89750 RVA: 0x003269F0 File Offset: 0x00324BF0
		public ISystemVarRef VarMaxAsISystemVarRef()
		{
			return this.VarMax<ISystemVarRef>().Value;
		}

		// Token: 0x06015E97 RID: 89751 RVA: 0x00326A0B File Offset: 0x00324C0B
		public static Offset<IVarInterval> CreateIVarInterval(FlatBufferBuilder builder, TVarRef VarMin_type = TVarRef.NONE, int VarMinOffset = 0, TVarRef VarMax_type = TVarRef.NONE, int VarMaxOffset = 0)
		{
			builder.StartTable(4);
			IVarInterval.AddVarMax(builder, VarMaxOffset);
			IVarInterval.AddVarMin(builder, VarMinOffset);
			IVarInterval.AddVarMaxType(builder, VarMax_type);
			IVarInterval.AddVarMinType(builder, VarMin_type);
			return IVarInterval.EndIVarInterval(builder);
		}

		// Token: 0x06015E98 RID: 89752 RVA: 0x00326A37 File Offset: 0x00324C37
		public static void StartIVarInterval(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015E99 RID: 89753 RVA: 0x00326A40 File Offset: 0x00324C40
		public static void AddVarMinType(FlatBufferBuilder builder, TVarRef varMinType)
		{
			builder.AddByte(0, (byte)varMinType, 0);
		}

		// Token: 0x06015E9A RID: 89754 RVA: 0x00326A4B File Offset: 0x00324C4B
		public static void AddVarMin(FlatBufferBuilder builder, int varMinOffset)
		{
			builder.AddOffset(1, varMinOffset, 0);
		}

		// Token: 0x06015E9B RID: 89755 RVA: 0x00326A56 File Offset: 0x00324C56
		public static void AddVarMaxType(FlatBufferBuilder builder, TVarRef varMaxType)
		{
			builder.AddByte(2, (byte)varMaxType, 0);
		}

		// Token: 0x06015E9C RID: 89756 RVA: 0x00326A61 File Offset: 0x00324C61
		public static void AddVarMax(FlatBufferBuilder builder, int varMaxOffset)
		{
			builder.AddOffset(3, varMaxOffset, 0);
		}

		// Token: 0x06015E9D RID: 89757 RVA: 0x00326A6C File Offset: 0x00324C6C
		public static Offset<IVarInterval> EndIVarInterval(FlatBufferBuilder builder)
		{
			return new Offset<IVarInterval>(builder.EndTable());
		}

		// Token: 0x06015E9E RID: 89758 RVA: 0x00326A7C File Offset: 0x00324C7C
		public IVarIntervalT UnPack()
		{
			IVarIntervalT varIntervalT = new IVarIntervalT();
			this.UnPackTo(varIntervalT);
			return varIntervalT;
		}

		// Token: 0x06015E9F RID: 89759 RVA: 0x00326A98 File Offset: 0x00324C98
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

		// Token: 0x06015EA0 RID: 89760 RVA: 0x00326D58 File Offset: 0x00324F58
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

		// Token: 0x0400B943 RID: 47427
		private Table __p;
	}
}
