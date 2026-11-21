using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B3 RID: 17843
	public struct ISurvivorsRougeSystemVar : IFlatbufferObject
	{
		// Token: 0x17007CB2 RID: 31922
		// (get) Token: 0x0601A072 RID: 106610 RVA: 0x003B59C0 File Offset: 0x003B3BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x003B59CD File Offset: 0x003B3BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A074 RID: 106612 RVA: 0x003B59D4 File Offset: 0x003B3BD4
		public static ISurvivorsRougeSystemVar GetRootAsISurvivorsRougeSystemVar(ByteBuffer _bb)
		{
			return ISurvivorsRougeSystemVar.GetRootAsISurvivorsRougeSystemVar(_bb, default(ISurvivorsRougeSystemVar));
		}

		// Token: 0x0601A075 RID: 106613 RVA: 0x003B59F0 File Offset: 0x003B3BF0
		public static ISurvivorsRougeSystemVar GetRootAsISurvivorsRougeSystemVar(ByteBuffer _bb, ISurvivorsRougeSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A076 RID: 106614 RVA: 0x003B5A0D File Offset: 0x003B3C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A077 RID: 106615 RVA: 0x003B5A1C File Offset: 0x003B3C1C
		public ISurvivorsRougeSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CB3 RID: 31923
		// (get) Token: 0x0601A078 RID: 106616 RVA: 0x003B5A2C File Offset: 0x003B3C2C
		public ESurvivorsRougeSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeSystemVarType.Gold;
				}
				return (ESurvivorsRougeSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CB4 RID: 31924
		// (get) Token: 0x0601A079 RID: 106617 RVA: 0x003B5A68 File Offset: 0x003B3C68
		public TVarRef VarRefType
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

		// Token: 0x0601A07A RID: 106618 RVA: 0x003B5AA4 File Offset: 0x003B3CA4
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A07B RID: 106619 RVA: 0x003B5AE8 File Offset: 0x003B3CE8
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0601A07C RID: 106620 RVA: 0x003B5B04 File Offset: 0x003B3D04
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0601A07D RID: 106621 RVA: 0x003B5B20 File Offset: 0x003B3D20
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601A07E RID: 106622 RVA: 0x003B5B3C File Offset: 0x003B3D3C
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601A07F RID: 106623 RVA: 0x003B5B58 File Offset: 0x003B3D58
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601A080 RID: 106624 RVA: 0x003B5B73 File Offset: 0x003B3D73
		public static Offset<ISurvivorsRougeSystemVar> CreateISurvivorsRougeSystemVar(FlatBufferBuilder builder, ESurvivorsRougeSystemVarType VarType = ESurvivorsRougeSystemVarType.Gold, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			ISurvivorsRougeSystemVar.AddVarRef(builder, VarRefOffset);
			ISurvivorsRougeSystemVar.AddVarRefType(builder, VarRef_type);
			ISurvivorsRougeSystemVar.AddVarType(builder, VarType);
			return ISurvivorsRougeSystemVar.EndISurvivorsRougeSystemVar(builder);
		}

		// Token: 0x0601A081 RID: 106625 RVA: 0x003B5B97 File Offset: 0x003B3D97
		public static void StartISurvivorsRougeSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A082 RID: 106626 RVA: 0x003B5BA0 File Offset: 0x003B3DA0
		public static void AddVarType(FlatBufferBuilder builder, ESurvivorsRougeSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601A083 RID: 106627 RVA: 0x003B5BAB File Offset: 0x003B3DAB
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0601A084 RID: 106628 RVA: 0x003B5BB6 File Offset: 0x003B3DB6
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x0601A085 RID: 106629 RVA: 0x003B5BC1 File Offset: 0x003B3DC1
		public static Offset<ISurvivorsRougeSystemVar> EndISurvivorsRougeSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeSystemVar>(builder.EndTable());
		}

		// Token: 0x0601A086 RID: 106630 RVA: 0x003B5BD0 File Offset: 0x003B3DD0
		public ISurvivorsRougeSystemVarT UnPack()
		{
			ISurvivorsRougeSystemVarT survivorsRougeSystemVarT = new ISurvivorsRougeSystemVarT();
			this.UnPackTo(survivorsRougeSystemVarT);
			return survivorsRougeSystemVarT;
		}

		// Token: 0x0601A087 RID: 106631 RVA: 0x003B5BEC File Offset: 0x003B3DEC
		public void UnPackTo(ISurvivorsRougeSystemVarT _o)
		{
			_o.VarType = this.VarType;
			_o.VarRef = new TVarRefUnion();
			_o.VarRef.Type = this.VarRefType;
			switch (this.VarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRef.Value = ((this.VarRef<IConstVarRef>() != null) ? this.VarRef<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRef.Value = ((this.VarRef<IGlobalVarRef>() != null) ? this.VarRef<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRef.Value = ((this.VarRef<IOtherVarRef>() != null) ? this.VarRef<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRef.Value = ((this.VarRef<ISelfVarRef>() != null) ? this.VarRef<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRef.Value = ((this.VarRef<ISystemVarRef>() != null) ? this.VarRef<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601A088 RID: 106632 RVA: 0x003B5D58 File Offset: 0x003B3F58
		public static Offset<ISurvivorsRougeSystemVar> Pack(FlatBufferBuilder builder, ISurvivorsRougeSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return ISurvivorsRougeSystemVar.CreateISurvivorsRougeSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C778 RID: 51064
		private Table __p;
	}
}
