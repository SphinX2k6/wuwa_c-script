using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425C RID: 16988
	public struct IUseVar : IFlatbufferObject
	{
		// Token: 0x170078A0 RID: 30880
		// (get) Token: 0x06019230 RID: 102960 RVA: 0x0039D005 File Offset: 0x0039B205
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019231 RID: 102961 RVA: 0x0039D012 File Offset: 0x0039B212
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019232 RID: 102962 RVA: 0x0039D01C File Offset: 0x0039B21C
		public static IUseVar GetRootAsIUseVar(ByteBuffer _bb)
		{
			return IUseVar.GetRootAsIUseVar(_bb, default(IUseVar));
		}

		// Token: 0x06019233 RID: 102963 RVA: 0x0039D038 File Offset: 0x0039B238
		public static IUseVar GetRootAsIUseVar(ByteBuffer _bb, IUseVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019234 RID: 102964 RVA: 0x0039D055 File Offset: 0x0039B255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019235 RID: 102965 RVA: 0x0039D064 File Offset: 0x0039B264
		public IUseVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078A1 RID: 30881
		// (get) Token: 0x06019236 RID: 102966 RVA: 0x0039D074 File Offset: 0x0039B274
		public EProgressBarLeftType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarLeftType.UseCount;
				}
				return (EProgressBarLeftType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078A2 RID: 30882
		// (get) Token: 0x06019237 RID: 102967 RVA: 0x0039D0B0 File Offset: 0x0039B2B0
		public TVarRef VarType
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

		// Token: 0x06019238 RID: 102968 RVA: 0x0039D0EC File Offset: 0x0039B2EC
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019239 RID: 102969 RVA: 0x0039D130 File Offset: 0x0039B330
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601923A RID: 102970 RVA: 0x0039D14C File Offset: 0x0039B34C
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601923B RID: 102971 RVA: 0x0039D168 File Offset: 0x0039B368
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601923C RID: 102972 RVA: 0x0039D184 File Offset: 0x0039B384
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601923D RID: 102973 RVA: 0x0039D1A0 File Offset: 0x0039B3A0
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x0601923E RID: 102974 RVA: 0x0039D1BB File Offset: 0x0039B3BB
		public static Offset<IUseVar> CreateIUseVar(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IUseVar.AddVar(builder, VarOffset);
			IUseVar.AddVarType(builder, Var_type);
			IUseVar.AddType(builder, Type);
			return IUseVar.EndIUseVar(builder);
		}

		// Token: 0x0601923F RID: 102975 RVA: 0x0039D1DF File Offset: 0x0039B3DF
		public static void StartIUseVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019240 RID: 102976 RVA: 0x0039D1E8 File Offset: 0x0039B3E8
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019241 RID: 102977 RVA: 0x0039D1F3 File Offset: 0x0039B3F3
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06019242 RID: 102978 RVA: 0x0039D1FE File Offset: 0x0039B3FE
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019243 RID: 102979 RVA: 0x0039D209 File Offset: 0x0039B409
		public static Offset<IUseVar> EndIUseVar(FlatBufferBuilder builder)
		{
			return new Offset<IUseVar>(builder.EndTable());
		}

		// Token: 0x06019244 RID: 102980 RVA: 0x0039D218 File Offset: 0x0039B418
		public IUseVarT UnPack()
		{
			IUseVarT useVarT = new IUseVarT();
			this.UnPackTo(useVarT);
			return useVarT;
		}

		// Token: 0x06019245 RID: 102981 RVA: 0x0039D234 File Offset: 0x0039B434
		public void UnPackTo(IUseVarT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06019246 RID: 102982 RVA: 0x0039D3A0 File Offset: 0x0039B5A0
		public static Offset<IUseVar> Pack(FlatBufferBuilder builder, IUseVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseVar>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IUseVar.CreateIUseVar(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400BEEB RID: 48875
		private Table __p;
	}
}
