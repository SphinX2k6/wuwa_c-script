using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007397 RID: 29591
	public struct IOpenSoaringChallengeResultWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D91E RID: 55582
		// (get) Token: 0x06033AF9 RID: 211705 RVA: 0x006F8060 File Offset: 0x006F6260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033AFA RID: 211706 RVA: 0x006F806D File Offset: 0x006F626D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033AFB RID: 211707 RVA: 0x006F8074 File Offset: 0x006F6274
		public static IOpenSoaringChallengeResultWithReturn GetRootAsIOpenSoaringChallengeResultWithReturn(ByteBuffer _bb)
		{
			return IOpenSoaringChallengeResultWithReturn.GetRootAsIOpenSoaringChallengeResultWithReturn(_bb, default(IOpenSoaringChallengeResultWithReturn));
		}

		// Token: 0x06033AFC RID: 211708 RVA: 0x006F8090 File Offset: 0x006F6290
		public static IOpenSoaringChallengeResultWithReturn GetRootAsIOpenSoaringChallengeResultWithReturn(ByteBuffer _bb, IOpenSoaringChallengeResultWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033AFD RID: 211709 RVA: 0x006F80AD File Offset: 0x006F62AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033AFE RID: 211710 RVA: 0x006F80BC File Offset: 0x006F62BC
		public IOpenSoaringChallengeResultWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D91F RID: 55583
		// (get) Token: 0x06033AFF RID: 211711 RVA: 0x006F80CC File Offset: 0x006F62CC
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D920 RID: 55584
		// (get) Token: 0x06033B00 RID: 211712 RVA: 0x006F8108 File Offset: 0x006F6308
		public TVarRef ScoreType
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

		// Token: 0x06033B01 RID: 211713 RVA: 0x006F8144 File Offset: 0x006F6344
		public TTable? Score<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B02 RID: 211714 RVA: 0x006F8188 File Offset: 0x006F6388
		public IConstVarRef ScoreAsIConstVarRef()
		{
			return this.Score<IConstVarRef>().Value;
		}

		// Token: 0x06033B03 RID: 211715 RVA: 0x006F81A4 File Offset: 0x006F63A4
		public IGlobalVarRef ScoreAsIGlobalVarRef()
		{
			return this.Score<IGlobalVarRef>().Value;
		}

		// Token: 0x06033B04 RID: 211716 RVA: 0x006F81C0 File Offset: 0x006F63C0
		public IOtherVarRef ScoreAsIOtherVarRef()
		{
			return this.Score<IOtherVarRef>().Value;
		}

		// Token: 0x06033B05 RID: 211717 RVA: 0x006F81DC File Offset: 0x006F63DC
		public ISelfVarRef ScoreAsISelfVarRef()
		{
			return this.Score<ISelfVarRef>().Value;
		}

		// Token: 0x06033B06 RID: 211718 RVA: 0x006F81F8 File Offset: 0x006F63F8
		public ISystemVarRef ScoreAsISystemVarRef()
		{
			return this.Score<ISystemVarRef>().Value;
		}

		// Token: 0x1700D921 RID: 55585
		// (get) Token: 0x06033B07 RID: 211719 RVA: 0x006F8214 File Offset: 0x006F6414
		public int RankS
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D922 RID: 55586
		// (get) Token: 0x06033B08 RID: 211720 RVA: 0x006F8254 File Offset: 0x006F6454
		public int RankA
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D923 RID: 55587
		// (get) Token: 0x06033B09 RID: 211721 RVA: 0x006F8294 File Offset: 0x006F6494
		public int RankB
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

		// Token: 0x1700D924 RID: 55588
		// (get) Token: 0x06033B0A RID: 211722 RVA: 0x006F82D4 File Offset: 0x006F64D4
		public TVarRef ReturnVarType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B0B RID: 211723 RVA: 0x006F8314 File Offset: 0x006F6514
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B0C RID: 211724 RVA: 0x006F835C File Offset: 0x006F655C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033B0D RID: 211725 RVA: 0x006F8378 File Offset: 0x006F6578
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033B0E RID: 211726 RVA: 0x006F8394 File Offset: 0x006F6594
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033B0F RID: 211727 RVA: 0x006F83B0 File Offset: 0x006F65B0
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033B10 RID: 211728 RVA: 0x006F83CC File Offset: 0x006F65CC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033B11 RID: 211729 RVA: 0x006F83E8 File Offset: 0x006F65E8
		public static Offset<IOpenSoaringChallengeResultWithReturn> CreateIOpenSoaringChallengeResultWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, TVarRef Score_type = TVarRef.NONE, int ScoreOffset = 0, int RankS = 0, int RankA = 0, int RankB = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(8);
			IOpenSoaringChallengeResultWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenSoaringChallengeResultWithReturn.AddRankB(builder, RankB);
			IOpenSoaringChallengeResultWithReturn.AddRankA(builder, RankA);
			IOpenSoaringChallengeResultWithReturn.AddRankS(builder, RankS);
			IOpenSoaringChallengeResultWithReturn.AddScore(builder, ScoreOffset);
			IOpenSoaringChallengeResultWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenSoaringChallengeResultWithReturn.AddScoreType(builder, Score_type);
			IOpenSoaringChallengeResultWithReturn.AddType(builder, Type);
			return IOpenSoaringChallengeResultWithReturn.EndIOpenSoaringChallengeResultWithReturn(builder);
		}

		// Token: 0x06033B12 RID: 211730 RVA: 0x006F843F File Offset: 0x006F663F
		public static void StartIOpenSoaringChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06033B13 RID: 211731 RVA: 0x006F8448 File Offset: 0x006F6648
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B14 RID: 211732 RVA: 0x006F8453 File Offset: 0x006F6653
		public static void AddScoreType(FlatBufferBuilder builder, TVarRef scoreType)
		{
			builder.AddByte(1, (byte)scoreType, 0);
		}

		// Token: 0x06033B15 RID: 211733 RVA: 0x006F845E File Offset: 0x006F665E
		public static void AddScore(FlatBufferBuilder builder, int scoreOffset)
		{
			builder.AddOffset(2, scoreOffset, 0);
		}

		// Token: 0x06033B16 RID: 211734 RVA: 0x006F8469 File Offset: 0x006F6669
		public static void AddRankS(FlatBufferBuilder builder, int rankS)
		{
			builder.AddInt(3, rankS, 0);
		}

		// Token: 0x06033B17 RID: 211735 RVA: 0x006F8474 File Offset: 0x006F6674
		public static void AddRankA(FlatBufferBuilder builder, int rankA)
		{
			builder.AddInt(4, rankA, 0);
		}

		// Token: 0x06033B18 RID: 211736 RVA: 0x006F847F File Offset: 0x006F667F
		public static void AddRankB(FlatBufferBuilder builder, int rankB)
		{
			builder.AddInt(5, rankB, 0);
		}

		// Token: 0x06033B19 RID: 211737 RVA: 0x006F848A File Offset: 0x006F668A
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(6, (byte)returnVarType, 0);
		}

		// Token: 0x06033B1A RID: 211738 RVA: 0x006F8495 File Offset: 0x006F6695
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(7, returnVarOffset, 0);
		}

		// Token: 0x06033B1B RID: 211739 RVA: 0x006F84A0 File Offset: 0x006F66A0
		public static Offset<IOpenSoaringChallengeResultWithReturn> EndIOpenSoaringChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSoaringChallengeResultWithReturn>(builder.EndTable());
		}

		// Token: 0x06033B1C RID: 211740 RVA: 0x006F84B0 File Offset: 0x006F66B0
		public IOpenSoaringChallengeResultWithReturnT UnPack()
		{
			IOpenSoaringChallengeResultWithReturnT openSoaringChallengeResultWithReturnT = new IOpenSoaringChallengeResultWithReturnT();
			this.UnPackTo(openSoaringChallengeResultWithReturnT);
			return openSoaringChallengeResultWithReturnT;
		}

		// Token: 0x06033B1D RID: 211741 RVA: 0x006F84CC File Offset: 0x006F66CC
		public void UnPackTo(IOpenSoaringChallengeResultWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.Score = new TVarRefUnion();
			_o.Score.Type = this.ScoreType;
			switch (this.ScoreType)
			{
			case TVarRef.IConstVarRef:
				_o.Score.Value = ((this.Score<IConstVarRef>() != null) ? this.Score<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Score.Value = ((this.Score<IGlobalVarRef>() != null) ? this.Score<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Score.Value = ((this.Score<IOtherVarRef>() != null) ? this.Score<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Score.Value = ((this.Score<ISelfVarRef>() != null) ? this.Score<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Score.Value = ((this.Score<ISystemVarRef>() != null) ? this.Score<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.RankS = this.RankS;
			_o.RankA = this.RankA;
			_o.RankB = this.RankB;
			_o.ReturnVar = new TVarRefUnion();
			_o.ReturnVar.Type = this.ReturnVarType;
			switch (this.ReturnVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IConstVarRef>() != null) ? this.ReturnVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IGlobalVarRef>() != null) ? this.ReturnVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IOtherVarRef>() != null) ? this.ReturnVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISelfVarRef>() != null) ? this.ReturnVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISystemVarRef>() != null) ? this.ReturnVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033B1E RID: 211742 RVA: 0x006F87BC File Offset: 0x006F69BC
		public static Offset<IOpenSoaringChallengeResultWithReturn> Pack(FlatBufferBuilder builder, IOpenSoaringChallengeResultWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSoaringChallengeResultWithReturn>);
			}
			TVarRef score_type = (_o.Score == null) ? TVarRef.NONE : _o.Score.Type;
			int scoreOffset = (_o.Score == null) ? 0 : TVarRefUnion.Pack(builder, _o.Score);
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenSoaringChallengeResultWithReturn.CreateIOpenSoaringChallengeResultWithReturn(builder, _o.Type, score_type, scoreOffset, _o.RankS, _o.RankA, _o.RankB, returnVar_type, returnVarOffset);
		}

		// Token: 0x04012496 RID: 74902
		private Table __p;
	}
}
