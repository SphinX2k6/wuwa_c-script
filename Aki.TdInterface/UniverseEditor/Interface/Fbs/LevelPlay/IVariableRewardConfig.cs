using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A4F RID: 19023
	public struct IVariableRewardConfig : IFlatbufferObject
	{
		// Token: 0x1700857A RID: 34170
		// (get) Token: 0x0601C956 RID: 117078 RVA: 0x00408938 File Offset: 0x00406B38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C957 RID: 117079 RVA: 0x00408945 File Offset: 0x00406B45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C958 RID: 117080 RVA: 0x0040894C File Offset: 0x00406B4C
		public static IVariableRewardConfig GetRootAsIVariableRewardConfig(ByteBuffer _bb)
		{
			return IVariableRewardConfig.GetRootAsIVariableRewardConfig(_bb, default(IVariableRewardConfig));
		}

		// Token: 0x0601C959 RID: 117081 RVA: 0x00408968 File Offset: 0x00406B68
		public static IVariableRewardConfig GetRootAsIVariableRewardConfig(ByteBuffer _bb, IVariableRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C95A RID: 117082 RVA: 0x00408985 File Offset: 0x00406B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C95B RID: 117083 RVA: 0x00408994 File Offset: 0x00406B94
		public IVariableRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700857B RID: 34171
		// (get) Token: 0x0601C95C RID: 117084 RVA: 0x004089A4 File Offset: 0x00406BA4
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

		// Token: 0x0601C95D RID: 117085 RVA: 0x004089E0 File Offset: 0x00406BE0
		public TTable? Var1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C95E RID: 117086 RVA: 0x00408A24 File Offset: 0x00406C24
		public IConstVarRef Var1AsIConstVarRef()
		{
			return this.Var1<IConstVarRef>().Value;
		}

		// Token: 0x0601C95F RID: 117087 RVA: 0x00408A40 File Offset: 0x00406C40
		public IGlobalVarRef Var1AsIGlobalVarRef()
		{
			return this.Var1<IGlobalVarRef>().Value;
		}

		// Token: 0x0601C960 RID: 117088 RVA: 0x00408A5C File Offset: 0x00406C5C
		public IOtherVarRef Var1AsIOtherVarRef()
		{
			return this.Var1<IOtherVarRef>().Value;
		}

		// Token: 0x0601C961 RID: 117089 RVA: 0x00408A78 File Offset: 0x00406C78
		public ISelfVarRef Var1AsISelfVarRef()
		{
			return this.Var1<ISelfVarRef>().Value;
		}

		// Token: 0x0601C962 RID: 117090 RVA: 0x00408A94 File Offset: 0x00406C94
		public ISystemVarRef Var1AsISystemVarRef()
		{
			return this.Var1<ISystemVarRef>().Value;
		}

		// Token: 0x1700857C RID: 34172
		// (get) Token: 0x0601C963 RID: 117091 RVA: 0x00408AB0 File Offset: 0x00406CB0
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

		// Token: 0x1700857D RID: 34173
		// (get) Token: 0x0601C964 RID: 117092 RVA: 0x00408AEC File Offset: 0x00406CEC
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

		// Token: 0x0601C965 RID: 117093 RVA: 0x00408B2C File Offset: 0x00406D2C
		public TTable? Var2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C966 RID: 117094 RVA: 0x00408B74 File Offset: 0x00406D74
		public IConstVarRef Var2AsIConstVarRef()
		{
			return this.Var2<IConstVarRef>().Value;
		}

		// Token: 0x0601C967 RID: 117095 RVA: 0x00408B90 File Offset: 0x00406D90
		public IGlobalVarRef Var2AsIGlobalVarRef()
		{
			return this.Var2<IGlobalVarRef>().Value;
		}

		// Token: 0x0601C968 RID: 117096 RVA: 0x00408BAC File Offset: 0x00406DAC
		public IOtherVarRef Var2AsIOtherVarRef()
		{
			return this.Var2<IOtherVarRef>().Value;
		}

		// Token: 0x0601C969 RID: 117097 RVA: 0x00408BC8 File Offset: 0x00406DC8
		public ISelfVarRef Var2AsISelfVarRef()
		{
			return this.Var2<ISelfVarRef>().Value;
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x00408BE4 File Offset: 0x00406DE4
		public ISystemVarRef Var2AsISystemVarRef()
		{
			return this.Var2<ISystemVarRef>().Value;
		}

		// Token: 0x1700857E RID: 34174
		// (get) Token: 0x0601C96B RID: 117099 RVA: 0x00408C00 File Offset: 0x00406E00
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

		// Token: 0x0601C96C RID: 117100 RVA: 0x00408C3D File Offset: 0x00406E3D
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

		// Token: 0x0601C96D RID: 117101 RVA: 0x00408C79 File Offset: 0x00406E79
		public static void StartIVariableRewardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C96E RID: 117102 RVA: 0x00408C82 File Offset: 0x00406E82
		public static void AddVar1Type(FlatBufferBuilder builder, TVarRef var1Type)
		{
			builder.AddByte(0, (byte)var1Type, 0);
		}

		// Token: 0x0601C96F RID: 117103 RVA: 0x00408C8D File Offset: 0x00406E8D
		public static void AddVar1(FlatBufferBuilder builder, int var1Offset)
		{
			builder.AddOffset(1, var1Offset, 0);
		}

		// Token: 0x0601C970 RID: 117104 RVA: 0x00408C98 File Offset: 0x00406E98
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601C971 RID: 117105 RVA: 0x00408CA3 File Offset: 0x00406EA3
		public static void AddVar2Type(FlatBufferBuilder builder, TVarRef var2Type)
		{
			builder.AddByte(3, (byte)var2Type, 0);
		}

		// Token: 0x0601C972 RID: 117106 RVA: 0x00408CAE File Offset: 0x00406EAE
		public static void AddVar2(FlatBufferBuilder builder, int var2Offset)
		{
			builder.AddOffset(4, var2Offset, 0);
		}

		// Token: 0x0601C973 RID: 117107 RVA: 0x00408CB9 File Offset: 0x00406EB9
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(5, rewardId, 0);
		}

		// Token: 0x0601C974 RID: 117108 RVA: 0x00408CC4 File Offset: 0x00406EC4
		public static Offset<IVariableRewardConfig> EndIVariableRewardConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVariableRewardConfig>(builder.EndTable());
		}

		// Token: 0x0601C975 RID: 117109 RVA: 0x00408CD4 File Offset: 0x00406ED4
		public IVariableRewardConfigT UnPack()
		{
			IVariableRewardConfigT variableRewardConfigT = new IVariableRewardConfigT();
			this.UnPackTo(variableRewardConfigT);
			return variableRewardConfigT;
		}

		// Token: 0x0601C976 RID: 117110 RVA: 0x00408CF0 File Offset: 0x00406EF0
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

		// Token: 0x0601C977 RID: 117111 RVA: 0x00408FD8 File Offset: 0x004071D8
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

		// Token: 0x0400D0F6 RID: 53494
		private Table __p;
	}
}
