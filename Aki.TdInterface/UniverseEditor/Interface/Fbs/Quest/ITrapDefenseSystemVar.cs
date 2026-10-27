using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423B RID: 16955
	public struct ITrapDefenseSystemVar : IFlatbufferObject
	{
		// Token: 0x17007862 RID: 30818
		// (get) Token: 0x0601911E RID: 102686 RVA: 0x0039B0E3 File Offset: 0x003992E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x0039B0F0 File Offset: 0x003992F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019120 RID: 102688 RVA: 0x0039B0F8 File Offset: 0x003992F8
		public static ITrapDefenseSystemVar GetRootAsITrapDefenseSystemVar(ByteBuffer _bb)
		{
			return ITrapDefenseSystemVar.GetRootAsITrapDefenseSystemVar(_bb, default(ITrapDefenseSystemVar));
		}

		// Token: 0x06019121 RID: 102689 RVA: 0x0039B114 File Offset: 0x00399314
		public static ITrapDefenseSystemVar GetRootAsITrapDefenseSystemVar(ByteBuffer _bb, ITrapDefenseSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019122 RID: 102690 RVA: 0x0039B131 File Offset: 0x00399331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019123 RID: 102691 RVA: 0x0039B140 File Offset: 0x00399340
		public ITrapDefenseSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007863 RID: 30819
		// (get) Token: 0x06019124 RID: 102692 RVA: 0x0039B150 File Offset: 0x00399350
		public ETrapDefenseSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSystemVarType.Health;
				}
				return (ETrapDefenseSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007864 RID: 30820
		// (get) Token: 0x06019125 RID: 102693 RVA: 0x0039B18C File Offset: 0x0039938C
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

		// Token: 0x06019126 RID: 102694 RVA: 0x0039B1C8 File Offset: 0x003993C8
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019127 RID: 102695 RVA: 0x0039B20C File Offset: 0x0039940C
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06019128 RID: 102696 RVA: 0x0039B228 File Offset: 0x00399428
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06019129 RID: 102697 RVA: 0x0039B244 File Offset: 0x00399444
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601912A RID: 102698 RVA: 0x0039B260 File Offset: 0x00399460
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601912B RID: 102699 RVA: 0x0039B27C File Offset: 0x0039947C
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601912C RID: 102700 RVA: 0x0039B297 File Offset: 0x00399497
		public static Offset<ITrapDefenseSystemVar> CreateITrapDefenseSystemVar(FlatBufferBuilder builder, ETrapDefenseSystemVarType VarType = ETrapDefenseSystemVarType.Health, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			ITrapDefenseSystemVar.AddVarRef(builder, VarRefOffset);
			ITrapDefenseSystemVar.AddVarRefType(builder, VarRef_type);
			ITrapDefenseSystemVar.AddVarType(builder, VarType);
			return ITrapDefenseSystemVar.EndITrapDefenseSystemVar(builder);
		}

		// Token: 0x0601912D RID: 102701 RVA: 0x0039B2BB File Offset: 0x003994BB
		public static void StartITrapDefenseSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601912E RID: 102702 RVA: 0x0039B2C4 File Offset: 0x003994C4
		public static void AddVarType(FlatBufferBuilder builder, ETrapDefenseSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601912F RID: 102703 RVA: 0x0039B2CF File Offset: 0x003994CF
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06019130 RID: 102704 RVA: 0x0039B2DA File Offset: 0x003994DA
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06019131 RID: 102705 RVA: 0x0039B2E5 File Offset: 0x003994E5
		public static Offset<ITrapDefenseSystemVar> EndITrapDefenseSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSystemVar>(builder.EndTable());
		}

		// Token: 0x06019132 RID: 102706 RVA: 0x0039B2F4 File Offset: 0x003994F4
		public ITrapDefenseSystemVarT UnPack()
		{
			ITrapDefenseSystemVarT trapDefenseSystemVarT = new ITrapDefenseSystemVarT();
			this.UnPackTo(trapDefenseSystemVarT);
			return trapDefenseSystemVarT;
		}

		// Token: 0x06019133 RID: 102707 RVA: 0x0039B310 File Offset: 0x00399510
		public void UnPackTo(ITrapDefenseSystemVarT _o)
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

		// Token: 0x06019134 RID: 102708 RVA: 0x0039B47C File Offset: 0x0039967C
		public static Offset<ITrapDefenseSystemVar> Pack(FlatBufferBuilder builder, ITrapDefenseSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return ITrapDefenseSystemVar.CreateITrapDefenseSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400BEBE RID: 48830
		private Table __p;
	}
}
