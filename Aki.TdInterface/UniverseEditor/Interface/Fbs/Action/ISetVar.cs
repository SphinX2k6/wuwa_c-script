using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A3 RID: 28835
	public struct ISetVar : IFlatbufferObject
	{
		// Token: 0x1700D639 RID: 54841
		// (get) Token: 0x060330EB RID: 209131 RVA: 0x006E2E3A File Offset: 0x006E103A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330EC RID: 209132 RVA: 0x006E2E47 File Offset: 0x006E1047
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330ED RID: 209133 RVA: 0x006E2E50 File Offset: 0x006E1050
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb)
		{
			return ISetVar.GetRootAsISetVar(_bb, default(ISetVar));
		}

		// Token: 0x060330EE RID: 209134 RVA: 0x006E2E6C File Offset: 0x006E106C
		public static ISetVar GetRootAsISetVar(ByteBuffer _bb, ISetVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330EF RID: 209135 RVA: 0x006E2E89 File Offset: 0x006E1089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330F0 RID: 209136 RVA: 0x006E2E98 File Offset: 0x006E1098
		public ISetVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D63A RID: 54842
		// (get) Token: 0x060330F1 RID: 209137 RVA: 0x006E2EA8 File Offset: 0x006E10A8
		public TVarRef VarLeftType
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

		// Token: 0x060330F2 RID: 209138 RVA: 0x006E2EE4 File Offset: 0x006E10E4
		public TTable? VarLeft<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060330F3 RID: 209139 RVA: 0x006E2F28 File Offset: 0x006E1128
		public IConstVarRef VarLeftAsIConstVarRef()
		{
			return this.VarLeft<IConstVarRef>().Value;
		}

		// Token: 0x060330F4 RID: 209140 RVA: 0x006E2F44 File Offset: 0x006E1144
		public IGlobalVarRef VarLeftAsIGlobalVarRef()
		{
			return this.VarLeft<IGlobalVarRef>().Value;
		}

		// Token: 0x060330F5 RID: 209141 RVA: 0x006E2F60 File Offset: 0x006E1160
		public IOtherVarRef VarLeftAsIOtherVarRef()
		{
			return this.VarLeft<IOtherVarRef>().Value;
		}

		// Token: 0x060330F6 RID: 209142 RVA: 0x006E2F7C File Offset: 0x006E117C
		public ISelfVarRef VarLeftAsISelfVarRef()
		{
			return this.VarLeft<ISelfVarRef>().Value;
		}

		// Token: 0x060330F7 RID: 209143 RVA: 0x006E2F98 File Offset: 0x006E1198
		public ISystemVarRef VarLeftAsISystemVarRef()
		{
			return this.VarLeft<ISystemVarRef>().Value;
		}

		// Token: 0x1700D63B RID: 54843
		// (get) Token: 0x060330F8 RID: 209144 RVA: 0x006E2FB4 File Offset: 0x006E11B4
		public TVarRef VarRightType
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

		// Token: 0x060330F9 RID: 209145 RVA: 0x006E2FF0 File Offset: 0x006E11F0
		public TTable? VarRight<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060330FA RID: 209146 RVA: 0x006E3038 File Offset: 0x006E1238
		public IConstVarRef VarRightAsIConstVarRef()
		{
			return this.VarRight<IConstVarRef>().Value;
		}

		// Token: 0x060330FB RID: 209147 RVA: 0x006E3054 File Offset: 0x006E1254
		public IGlobalVarRef VarRightAsIGlobalVarRef()
		{
			return this.VarRight<IGlobalVarRef>().Value;
		}

		// Token: 0x060330FC RID: 209148 RVA: 0x006E3070 File Offset: 0x006E1270
		public IOtherVarRef VarRightAsIOtherVarRef()
		{
			return this.VarRight<IOtherVarRef>().Value;
		}

		// Token: 0x060330FD RID: 209149 RVA: 0x006E308C File Offset: 0x006E128C
		public ISelfVarRef VarRightAsISelfVarRef()
		{
			return this.VarRight<ISelfVarRef>().Value;
		}

		// Token: 0x060330FE RID: 209150 RVA: 0x006E30A8 File Offset: 0x006E12A8
		public ISystemVarRef VarRightAsISystemVarRef()
		{
			return this.VarRight<ISystemVarRef>().Value;
		}

		// Token: 0x060330FF RID: 209151 RVA: 0x006E30C3 File Offset: 0x006E12C3
		public static Offset<ISetVar> CreateISetVar(FlatBufferBuilder builder, TVarRef VarLeft_type = TVarRef.NONE, int VarLeftOffset = 0, TVarRef VarRight_type = TVarRef.NONE, int VarRightOffset = 0)
		{
			builder.StartTable(4);
			ISetVar.AddVarRight(builder, VarRightOffset);
			ISetVar.AddVarLeft(builder, VarLeftOffset);
			ISetVar.AddVarRightType(builder, VarRight_type);
			ISetVar.AddVarLeftType(builder, VarLeft_type);
			return ISetVar.EndISetVar(builder);
		}

		// Token: 0x06033100 RID: 209152 RVA: 0x006E30EF File Offset: 0x006E12EF
		public static void StartISetVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033101 RID: 209153 RVA: 0x006E30F8 File Offset: 0x006E12F8
		public static void AddVarLeftType(FlatBufferBuilder builder, TVarRef varLeftType)
		{
			builder.AddByte(0, (byte)varLeftType, 0);
		}

		// Token: 0x06033102 RID: 209154 RVA: 0x006E3103 File Offset: 0x006E1303
		public static void AddVarLeft(FlatBufferBuilder builder, int varLeftOffset)
		{
			builder.AddOffset(1, varLeftOffset, 0);
		}

		// Token: 0x06033103 RID: 209155 RVA: 0x006E310E File Offset: 0x006E130E
		public static void AddVarRightType(FlatBufferBuilder builder, TVarRef varRightType)
		{
			builder.AddByte(2, (byte)varRightType, 0);
		}

		// Token: 0x06033104 RID: 209156 RVA: 0x006E3119 File Offset: 0x006E1319
		public static void AddVarRight(FlatBufferBuilder builder, int varRightOffset)
		{
			builder.AddOffset(3, varRightOffset, 0);
		}

		// Token: 0x06033105 RID: 209157 RVA: 0x006E3124 File Offset: 0x006E1324
		public static Offset<ISetVar> EndISetVar(FlatBufferBuilder builder)
		{
			return new Offset<ISetVar>(builder.EndTable());
		}

		// Token: 0x06033106 RID: 209158 RVA: 0x006E3134 File Offset: 0x006E1334
		public ISetVarT UnPack()
		{
			ISetVarT setVarT = new ISetVarT();
			this.UnPackTo(setVarT);
			return setVarT;
		}

		// Token: 0x06033107 RID: 209159 RVA: 0x006E3150 File Offset: 0x006E1350
		public void UnPackTo(ISetVarT _o)
		{
			_o.VarLeft = new TVarRefUnion();
			_o.VarLeft.Type = this.VarLeftType;
			switch (this.VarLeftType)
			{
			case TVarRef.IConstVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IConstVarRef>() != null) ? this.VarLeft<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IGlobalVarRef>() != null) ? this.VarLeft<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.VarLeft.Value = ((this.VarLeft<IOtherVarRef>() != null) ? this.VarLeft<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.VarLeft.Value = ((this.VarLeft<ISelfVarRef>() != null) ? this.VarLeft<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.VarLeft.Value = ((this.VarLeft<ISystemVarRef>() != null) ? this.VarLeft<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.VarRight = new TVarRefUnion();
			_o.VarRight.Type = this.VarRightType;
			switch (this.VarRightType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRight.Value = ((this.VarRight<IConstVarRef>() != null) ? this.VarRight<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRight.Value = ((this.VarRight<IGlobalVarRef>() != null) ? this.VarRight<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRight.Value = ((this.VarRight<IOtherVarRef>() != null) ? this.VarRight<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRight.Value = ((this.VarRight<ISelfVarRef>() != null) ? this.VarRight<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRight.Value = ((this.VarRight<ISystemVarRef>() != null) ? this.VarRight<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033108 RID: 209160 RVA: 0x006E3410 File Offset: 0x006E1610
		public static Offset<ISetVar> Pack(FlatBufferBuilder builder, ISetVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetVar>);
			}
			TVarRef varLeft_type = (_o.VarLeft == null) ? TVarRef.NONE : _o.VarLeft.Type;
			int varLeftOffset = (_o.VarLeft == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarLeft);
			TVarRef varRight_type = (_o.VarRight == null) ? TVarRef.NONE : _o.VarRight.Type;
			int varRightOffset = (_o.VarRight == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRight);
			return ISetVar.CreateISetVar(builder, varLeft_type, varLeftOffset, varRight_type, varRightOffset);
		}

		// Token: 0x04011B0B RID: 72459
		private Table __p;
	}
}
