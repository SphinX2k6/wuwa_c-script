using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006594 RID: 26004
	public struct IDestroyPrefab : IFlatbufferObject
	{
		// Token: 0x1700C11E RID: 49438
		// (get) Token: 0x0602D1B0 RID: 184752 RVA: 0x0062FD7C File Offset: 0x0062DF7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D1B1 RID: 184753 RVA: 0x0062FD89 File Offset: 0x0062DF89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D1B2 RID: 184754 RVA: 0x0062FD90 File Offset: 0x0062DF90
		public static IDestroyPrefab GetRootAsIDestroyPrefab(ByteBuffer _bb)
		{
			return IDestroyPrefab.GetRootAsIDestroyPrefab(_bb, default(IDestroyPrefab));
		}

		// Token: 0x0602D1B3 RID: 184755 RVA: 0x0062FDAC File Offset: 0x0062DFAC
		public static IDestroyPrefab GetRootAsIDestroyPrefab(ByteBuffer _bb, IDestroyPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D1B4 RID: 184756 RVA: 0x0062FDC9 File Offset: 0x0062DFC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D1B5 RID: 184757 RVA: 0x0062FDD8 File Offset: 0x0062DFD8
		public IDestroyPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C11F RID: 49439
		// (get) Token: 0x0602D1B6 RID: 184758 RVA: 0x0062FDE8 File Offset: 0x0062DFE8
		public TVarRef VarNameType
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

		// Token: 0x0602D1B7 RID: 184759 RVA: 0x0062FE24 File Offset: 0x0062E024
		public TTable? VarName<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D1B8 RID: 184760 RVA: 0x0062FE68 File Offset: 0x0062E068
		public IConstVarRef VarNameAsIConstVarRef()
		{
			return this.VarName<IConstVarRef>().Value;
		}

		// Token: 0x0602D1B9 RID: 184761 RVA: 0x0062FE84 File Offset: 0x0062E084
		public IGlobalVarRef VarNameAsIGlobalVarRef()
		{
			return this.VarName<IGlobalVarRef>().Value;
		}

		// Token: 0x0602D1BA RID: 184762 RVA: 0x0062FEA0 File Offset: 0x0062E0A0
		public IOtherVarRef VarNameAsIOtherVarRef()
		{
			return this.VarName<IOtherVarRef>().Value;
		}

		// Token: 0x0602D1BB RID: 184763 RVA: 0x0062FEBC File Offset: 0x0062E0BC
		public ISelfVarRef VarNameAsISelfVarRef()
		{
			return this.VarName<ISelfVarRef>().Value;
		}

		// Token: 0x0602D1BC RID: 184764 RVA: 0x0062FED8 File Offset: 0x0062E0D8
		public ISystemVarRef VarNameAsISystemVarRef()
		{
			return this.VarName<ISystemVarRef>().Value;
		}

		// Token: 0x0602D1BD RID: 184765 RVA: 0x0062FEF3 File Offset: 0x0062E0F3
		public static Offset<IDestroyPrefab> CreateIDestroyPrefab(FlatBufferBuilder builder, TVarRef VarName_type = TVarRef.NONE, int VarNameOffset = 0)
		{
			builder.StartTable(2);
			IDestroyPrefab.AddVarName(builder, VarNameOffset);
			IDestroyPrefab.AddVarNameType(builder, VarName_type);
			return IDestroyPrefab.EndIDestroyPrefab(builder);
		}

		// Token: 0x0602D1BE RID: 184766 RVA: 0x0062FF10 File Offset: 0x0062E110
		public static void StartIDestroyPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D1BF RID: 184767 RVA: 0x0062FF19 File Offset: 0x0062E119
		public static void AddVarNameType(FlatBufferBuilder builder, TVarRef varNameType)
		{
			builder.AddByte(0, (byte)varNameType, 0);
		}

		// Token: 0x0602D1C0 RID: 184768 RVA: 0x0062FF24 File Offset: 0x0062E124
		public static void AddVarName(FlatBufferBuilder builder, int varNameOffset)
		{
			builder.AddOffset(1, varNameOffset, 0);
		}

		// Token: 0x0602D1C1 RID: 184769 RVA: 0x0062FF2F File Offset: 0x0062E12F
		public static Offset<IDestroyPrefab> EndIDestroyPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyPrefab>(builder.EndTable());
		}

		// Token: 0x0602D1C2 RID: 184770 RVA: 0x0062FF3C File Offset: 0x0062E13C
		public IDestroyPrefabT UnPack()
		{
			IDestroyPrefabT destroyPrefabT = new IDestroyPrefabT();
			this.UnPackTo(destroyPrefabT);
			return destroyPrefabT;
		}

		// Token: 0x0602D1C3 RID: 184771 RVA: 0x0062FF58 File Offset: 0x0062E158
		public void UnPackTo(IDestroyPrefabT _o)
		{
			_o.VarName = new TVarRefUnion();
			_o.VarName.Type = this.VarNameType;
			switch (this.VarNameType)
			{
			case TVarRef.IConstVarRef:
				_o.VarName.Value = ((this.VarName<IConstVarRef>() != null) ? this.VarName<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarName.Value = ((this.VarName<IGlobalVarRef>() != null) ? this.VarName<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarName.Value = ((this.VarName<IOtherVarRef>() != null) ? this.VarName<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarName.Value = ((this.VarName<ISelfVarRef>() != null) ? this.VarName<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarName.Value = ((this.VarName<ISystemVarRef>() != null) ? this.VarName<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D1C4 RID: 184772 RVA: 0x006300B8 File Offset: 0x0062E2B8
		public static Offset<IDestroyPrefab> Pack(FlatBufferBuilder builder, IDestroyPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyPrefab>);
			}
			TVarRef varName_type = (_o.VarName == null) ? TVarRef.NONE : _o.VarName.Type;
			int varNameOffset = (_o.VarName == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarName);
			return IDestroyPrefab.CreateIDestroyPrefab(builder, varName_type, varNameOffset);
		}

		// Token: 0x04010BED RID: 68589
		private Table __p;
	}
}
