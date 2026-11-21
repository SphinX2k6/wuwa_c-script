using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFC RID: 27644
	public struct IDestroyPrefab : IFlatbufferObject
	{
		// Token: 0x1700CAAD RID: 51885
		// (get) Token: 0x0602F934 RID: 194868 RVA: 0x0067BF40 File Offset: 0x0067A140
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F935 RID: 194869 RVA: 0x0067BF4D File Offset: 0x0067A14D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F936 RID: 194870 RVA: 0x0067BF54 File Offset: 0x0067A154
		public static IDestroyPrefab GetRootAsIDestroyPrefab(ByteBuffer _bb)
		{
			return IDestroyPrefab.GetRootAsIDestroyPrefab(_bb, default(IDestroyPrefab));
		}

		// Token: 0x0602F937 RID: 194871 RVA: 0x0067BF70 File Offset: 0x0067A170
		public static IDestroyPrefab GetRootAsIDestroyPrefab(ByteBuffer _bb, IDestroyPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F938 RID: 194872 RVA: 0x0067BF8D File Offset: 0x0067A18D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F939 RID: 194873 RVA: 0x0067BF9C File Offset: 0x0067A19C
		public IDestroyPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAAE RID: 51886
		// (get) Token: 0x0602F93A RID: 194874 RVA: 0x0067BFAC File Offset: 0x0067A1AC
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

		// Token: 0x0602F93B RID: 194875 RVA: 0x0067BFE8 File Offset: 0x0067A1E8
		public TTable? VarName<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F93C RID: 194876 RVA: 0x0067C02C File Offset: 0x0067A22C
		public IConstVarRef VarNameAsIConstVarRef()
		{
			return this.VarName<IConstVarRef>().Value;
		}

		// Token: 0x0602F93D RID: 194877 RVA: 0x0067C048 File Offset: 0x0067A248
		public IGlobalVarRef VarNameAsIGlobalVarRef()
		{
			return this.VarName<IGlobalVarRef>().Value;
		}

		// Token: 0x0602F93E RID: 194878 RVA: 0x0067C064 File Offset: 0x0067A264
		public IOtherVarRef VarNameAsIOtherVarRef()
		{
			return this.VarName<IOtherVarRef>().Value;
		}

		// Token: 0x0602F93F RID: 194879 RVA: 0x0067C080 File Offset: 0x0067A280
		public ISelfVarRef VarNameAsISelfVarRef()
		{
			return this.VarName<ISelfVarRef>().Value;
		}

		// Token: 0x0602F940 RID: 194880 RVA: 0x0067C09C File Offset: 0x0067A29C
		public ISystemVarRef VarNameAsISystemVarRef()
		{
			return this.VarName<ISystemVarRef>().Value;
		}

		// Token: 0x0602F941 RID: 194881 RVA: 0x0067C0B7 File Offset: 0x0067A2B7
		public static Offset<IDestroyPrefab> CreateIDestroyPrefab(FlatBufferBuilder builder, TVarRef VarName_type = TVarRef.NONE, int VarNameOffset = 0)
		{
			builder.StartTable(2);
			IDestroyPrefab.AddVarName(builder, VarNameOffset);
			IDestroyPrefab.AddVarNameType(builder, VarName_type);
			return IDestroyPrefab.EndIDestroyPrefab(builder);
		}

		// Token: 0x0602F942 RID: 194882 RVA: 0x0067C0D4 File Offset: 0x0067A2D4
		public static void StartIDestroyPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F943 RID: 194883 RVA: 0x0067C0DD File Offset: 0x0067A2DD
		public static void AddVarNameType(FlatBufferBuilder builder, TVarRef varNameType)
		{
			builder.AddByte(0, (byte)varNameType, 0);
		}

		// Token: 0x0602F944 RID: 194884 RVA: 0x0067C0E8 File Offset: 0x0067A2E8
		public static void AddVarName(FlatBufferBuilder builder, int varNameOffset)
		{
			builder.AddOffset(1, varNameOffset, 0);
		}

		// Token: 0x0602F945 RID: 194885 RVA: 0x0067C0F3 File Offset: 0x0067A2F3
		public static Offset<IDestroyPrefab> EndIDestroyPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyPrefab>(builder.EndTable());
		}

		// Token: 0x0602F946 RID: 194886 RVA: 0x0067C100 File Offset: 0x0067A300
		public IDestroyPrefabT UnPack()
		{
			IDestroyPrefabT destroyPrefabT = new IDestroyPrefabT();
			this.UnPackTo(destroyPrefabT);
			return destroyPrefabT;
		}

		// Token: 0x0602F947 RID: 194887 RVA: 0x0067C11C File Offset: 0x0067A31C
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

		// Token: 0x0602F948 RID: 194888 RVA: 0x0067C27C File Offset: 0x0067A47C
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

		// Token: 0x040119FF RID: 72191
		private Table __p;
	}
}
