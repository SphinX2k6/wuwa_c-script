using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E7 RID: 17895
	public struct IVariableRewardConfig : IFlatbufferObject
	{
		// Token: 0x17007F39 RID: 32569
		// (get) Token: 0x0601B181 RID: 110977 RVA: 0x003DC69C File Offset: 0x003DA89C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B182 RID: 110978 RVA: 0x003DC6A9 File Offset: 0x003DA8A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B183 RID: 110979 RVA: 0x003DC6B0 File Offset: 0x003DA8B0
		public static IVariableRewardConfig GetRootAsIVariableRewardConfig(ByteBuffer _bb)
		{
			return IVariableRewardConfig.GetRootAsIVariableRewardConfig(_bb, default(IVariableRewardConfig));
		}

		// Token: 0x0601B184 RID: 110980 RVA: 0x003DC6CC File Offset: 0x003DA8CC
		public static IVariableRewardConfig GetRootAsIVariableRewardConfig(ByteBuffer _bb, IVariableRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B185 RID: 110981 RVA: 0x003DC6E9 File Offset: 0x003DA8E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B186 RID: 110982 RVA: 0x003DC6F8 File Offset: 0x003DA8F8
		public IVariableRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F3A RID: 32570
		// (get) Token: 0x0601B187 RID: 110983 RVA: 0x003DC708 File Offset: 0x003DA908
		public TVarRef Var1Type
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

		// Token: 0x0601B188 RID: 110984 RVA: 0x003DC744 File Offset: 0x003DA944
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B189 RID: 110985 RVA: 0x003DC788 File Offset: 0x003DA988
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0601B18A RID: 110986 RVA: 0x003DC7A4 File Offset: 0x003DA9A4
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0601B18B RID: 110987 RVA: 0x003DC7C0 File Offset: 0x003DA9C0
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0601B18C RID: 110988 RVA: 0x003DC7DC File Offset: 0x003DA9DC
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0601B18D RID: 110989 RVA: 0x003DC7F8 File Offset: 0x003DA9F8
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x17007F3B RID: 32571
		// (get) Token: 0x0601B18E RID: 110990 RVA: 0x003DC814 File Offset: 0x003DAA14
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F3C RID: 32572
		// (get) Token: 0x0601B18F RID: 110991 RVA: 0x003DC850 File Offset: 0x003DAA50
		public TVarRef Var2Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B190 RID: 110992 RVA: 0x003DC890 File Offset: 0x003DAA90
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B191 RID: 110993 RVA: 0x003DC8D8 File Offset: 0x003DAAD8
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0601B192 RID: 110994 RVA: 0x003DC8F4 File Offset: 0x003DAAF4
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0601B193 RID: 110995 RVA: 0x003DC910 File Offset: 0x003DAB10
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0601B194 RID: 110996 RVA: 0x003DC92C File Offset: 0x003DAB2C
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0601B195 RID: 110997 RVA: 0x003DC948 File Offset: 0x003DAB48
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x17007F3D RID: 32573
		// (get) Token: 0x0601B196 RID: 110998 RVA: 0x003DC964 File Offset: 0x003DAB64
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B197 RID: 110999 RVA: 0x003DC9A1 File Offset: 0x003DABA1
		public static Offset<IVariableRewardConfig> CreateIVariableRewardConfig(FlatBufferBuilder builder, TVarRef Var1_type = TVarRef.NONE, int Var1Offset = 0, ECompare Compare = ECompare.Eq, TVarRef Var2_type = TVarRef.NONE, int Var2Offset = 0, int RewardId = 0)
		{
			builder.StartTable(6);
			IVariableRewardConfig.AddRewardId(builder, RewardId);
			IVariableRewardConfig.AddVar2(builder, Var2Offset);
			IVariableRewardConfig.AddVar1(builder, Var1Offset);
			IVariableRewardConfig.AddVar2Type(builder, Var2_type);
			IVariableRewardConfig.AddCompare(builder, Compare);
			IVariableRewardConfig.AddVar1Type(builder, Var1_type);
			return IVariableRewardConfig.EndIVariableRewardConfig(builder);
		}

		// Token: 0x0601B198 RID: 111000 RVA: 0x003DC9DD File Offset: 0x003DABDD
		public static void StartIVariableRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B199 RID: 111001 RVA: 0x003DC9E6 File Offset: 0x003DABE6
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0601B19A RID: 111002 RVA: 0x003DC9F1 File Offset: 0x003DABF1
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0601B19B RID: 111003 RVA: 0x003DC9FC File Offset: 0x003DABFC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601B19C RID: 111004 RVA: 0x003DCA07 File Offset: 0x003DAC07
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0601B19D RID: 111005 RVA: 0x003DCA12 File Offset: 0x003DAC12
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0601B19E RID: 111006 RVA: 0x003DCA1D File Offset: 0x003DAC1D
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(5, rewardId, 0);
		}

		// Token: 0x0601B19F RID: 111007 RVA: 0x003DCA28 File Offset: 0x003DAC28
		public static Offset<IVariableRewardConfig> EndIVariableRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVariableRewardConfig>(builder.EndTable());
		}

		// Token: 0x0601B1A0 RID: 111008 RVA: 0x003DCA38 File Offset: 0x003DAC38
		public IVariableRewardConfigT UnPack()
		{
			IVariableRewardConfigT variableRewardConfigT = new IVariableRewardConfigT();
			this.UnPackTo(variableRewardConfigT);
			return variableRewardConfigT;
		}

		// Token: 0x0601B1A1 RID: 111009 RVA: 0x003DCA54 File Offset: 0x003DAC54
		public void UnPackTo(IVariableRewardConfigT _o)
		{
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
			_o.Compare = this.Compare;
			_o.Var2 = new TVarRefUnion();
			_o.Var2.Type = this.Var2Type;
			switch (this.Var2Type)
			{
			case TVarRef.IConstVarRef:
				_o.Var2.Value = ((this.Var2<IConstVarRef>() != null) ? this.Var2<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var2.Value = ((this.Var2<IGlobalVarRef>() != null) ? this.Var2<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var2.Value = ((this.Var2<IOtherVarRef>() != null) ? this.Var2<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var2.Value = ((this.Var2<ISelfVarRef>() != null) ? this.Var2<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var2.Value = ((this.Var2<ISystemVarRef>() != null) ? this.Var2<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.RewardId = this.RewardId;
		}

		// Token: 0x0601B1A2 RID: 111010 RVA: 0x003DCD3C File Offset: 0x003DAF3C
		public static Offset<IVariableRewardConfig> Pack(FlatBufferBuilder builder, IVariableRewardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVariableRewardConfig>);
			}
			TVarRef var1_type = (_o.Var1 == null) ? TVarRef.NONE : _o.Var1.Type;
			int var1Offset = (_o.Var1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var1);
			TVarRef var2_type = (_o.Var2 == null) ? TVarRef.NONE : _o.Var2.Type;
			int var2Offset = (_o.Var2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var2);
			return IVariableRewardConfig.CreateIVariableRewardConfig(builder, var1_type, var1Offset, _o.Compare, var2_type, var2Offset, _o.RewardId);
		}

		// Token: 0x0400C6C7 RID: 50887
		private Table __p;
	}
}
