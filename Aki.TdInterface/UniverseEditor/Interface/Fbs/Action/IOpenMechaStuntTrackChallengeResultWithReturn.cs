using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007373 RID: 29555
	public struct IOpenMechaStuntTrackChallengeResultWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D8C9 RID: 55497
		// (get) Token: 0x06033967 RID: 211303 RVA: 0x006F40F8 File Offset: 0x006F22F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033968 RID: 211304 RVA: 0x006F4105 File Offset: 0x006F2305
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033969 RID: 211305 RVA: 0x006F410C File Offset: 0x006F230C
		public static IOpenMechaStuntTrackChallengeResultWithReturn GetRootAsIOpenMechaStuntTrackChallengeResultWithReturn(ByteBuffer _bb)
		{
			return IOpenMechaStuntTrackChallengeResultWithReturn.GetRootAsIOpenMechaStuntTrackChallengeResultWithReturn(_bb, default(IOpenMechaStuntTrackChallengeResultWithReturn));
		}

		// Token: 0x0603396A RID: 211306 RVA: 0x006F4128 File Offset: 0x006F2328
		public static IOpenMechaStuntTrackChallengeResultWithReturn GetRootAsIOpenMechaStuntTrackChallengeResultWithReturn(ByteBuffer _bb, IOpenMechaStuntTrackChallengeResultWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603396B RID: 211307 RVA: 0x006F4145 File Offset: 0x006F2345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603396C RID: 211308 RVA: 0x006F4154 File Offset: 0x006F2354
		public IOpenMechaStuntTrackChallengeResultWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8CA RID: 55498
		// (get) Token: 0x0603396D RID: 211309 RVA: 0x006F4164 File Offset: 0x006F2364
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

		// Token: 0x1700D8CB RID: 55499
		// (get) Token: 0x0603396E RID: 211310 RVA: 0x006F41A0 File Offset: 0x006F23A0
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

		// Token: 0x0603396F RID: 211311 RVA: 0x006F41DC File Offset: 0x006F23DC
		public TTable? Score<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033970 RID: 211312 RVA: 0x006F4220 File Offset: 0x006F2420
		public IConstVarRef ScoreAsIConstVarRef()
		{
			return this.Score<IConstVarRef>().Value;
		}

		// Token: 0x06033971 RID: 211313 RVA: 0x006F423C File Offset: 0x006F243C
		public IGlobalVarRef ScoreAsIGlobalVarRef()
		{
			return this.Score<IGlobalVarRef>().Value;
		}

		// Token: 0x06033972 RID: 211314 RVA: 0x006F4258 File Offset: 0x006F2458
		public IOtherVarRef ScoreAsIOtherVarRef()
		{
			return this.Score<IOtherVarRef>().Value;
		}

		// Token: 0x06033973 RID: 211315 RVA: 0x006F4274 File Offset: 0x006F2474
		public ISelfVarRef ScoreAsISelfVarRef()
		{
			return this.Score<ISelfVarRef>().Value;
		}

		// Token: 0x06033974 RID: 211316 RVA: 0x006F4290 File Offset: 0x006F2490
		public ISystemVarRef ScoreAsISystemVarRef()
		{
			return this.Score<ISystemVarRef>().Value;
		}

		// Token: 0x1700D8CC RID: 55500
		// (get) Token: 0x06033975 RID: 211317 RVA: 0x006F42AC File Offset: 0x006F24AC
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

		// Token: 0x1700D8CD RID: 55501
		// (get) Token: 0x06033976 RID: 211318 RVA: 0x006F42EC File Offset: 0x006F24EC
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

		// Token: 0x1700D8CE RID: 55502
		// (get) Token: 0x06033977 RID: 211319 RVA: 0x006F432C File Offset: 0x006F252C
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

		// Token: 0x1700D8CF RID: 55503
		// (get) Token: 0x06033978 RID: 211320 RVA: 0x006F436C File Offset: 0x006F256C
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

		// Token: 0x06033979 RID: 211321 RVA: 0x006F43AC File Offset: 0x006F25AC
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603397A RID: 211322 RVA: 0x006F43F4 File Offset: 0x006F25F4
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x0603397B RID: 211323 RVA: 0x006F4410 File Offset: 0x006F2610
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x0603397C RID: 211324 RVA: 0x006F442C File Offset: 0x006F262C
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x0603397D RID: 211325 RVA: 0x006F4448 File Offset: 0x006F2648
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x0603397E RID: 211326 RVA: 0x006F4464 File Offset: 0x006F2664
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x0603397F RID: 211327 RVA: 0x006F4480 File Offset: 0x006F2680
		public static Offset<IOpenMechaStuntTrackChallengeResultWithReturn> CreateIOpenMechaStuntTrackChallengeResultWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, TVarRef Score_type = TVarRef.NONE, int ScoreOffset = 0, int RankS = 0, int RankA = 0, int RankB = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(8);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddRankB(builder, RankB);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddRankA(builder, RankA);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddRankS(builder, RankS);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddScore(builder, ScoreOffset);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddScoreType(builder, Score_type);
			IOpenMechaStuntTrackChallengeResultWithReturn.AddType(builder, Type);
			return IOpenMechaStuntTrackChallengeResultWithReturn.EndIOpenMechaStuntTrackChallengeResultWithReturn(builder);
		}

		// Token: 0x06033980 RID: 211328 RVA: 0x006F44D7 File Offset: 0x006F26D7
		public static void StartIOpenMechaStuntTrackChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06033981 RID: 211329 RVA: 0x006F44E0 File Offset: 0x006F26E0
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033982 RID: 211330 RVA: 0x006F44EB File Offset: 0x006F26EB
		public static void AddScoreType(FlatBufferBuilder builder, TVarRef scoreType)
		{
			builder.AddByte(1, (byte)scoreType, 0);
		}

		// Token: 0x06033983 RID: 211331 RVA: 0x006F44F6 File Offset: 0x006F26F6
		public static void AddScore(FlatBufferBuilder builder, int scoreOffset)
		{
			builder.AddOffset(2, scoreOffset, 0);
		}

		// Token: 0x06033984 RID: 211332 RVA: 0x006F4501 File Offset: 0x006F2701
		public static void AddRankS(FlatBufferBuilder builder, int rankS)
		{
			builder.AddInt(3, rankS, 0);
		}

		// Token: 0x06033985 RID: 211333 RVA: 0x006F450C File Offset: 0x006F270C
		public static void AddRankA(FlatBufferBuilder builder, int rankA)
		{
			builder.AddInt(4, rankA, 0);
		}

		// Token: 0x06033986 RID: 211334 RVA: 0x006F4517 File Offset: 0x006F2717
		public static void AddRankB(FlatBufferBuilder builder, int rankB)
		{
			builder.AddInt(5, rankB, 0);
		}

		// Token: 0x06033987 RID: 211335 RVA: 0x006F4522 File Offset: 0x006F2722
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(6, (byte)returnVarType, 0);
		}

		// Token: 0x06033988 RID: 211336 RVA: 0x006F452D File Offset: 0x006F272D
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(7, returnVarOffset, 0);
		}

		// Token: 0x06033989 RID: 211337 RVA: 0x006F4538 File Offset: 0x006F2738
		public static Offset<IOpenMechaStuntTrackChallengeResultWithReturn> EndIOpenMechaStuntTrackChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenMechaStuntTrackChallengeResultWithReturn>(builder.EndTable());
		}

		// Token: 0x0603398A RID: 211338 RVA: 0x006F4548 File Offset: 0x006F2748
		public IOpenMechaStuntTrackChallengeResultWithReturnT UnPack()
		{
			IOpenMechaStuntTrackChallengeResultWithReturnT openMechaStuntTrackChallengeResultWithReturnT = new IOpenMechaStuntTrackChallengeResultWithReturnT();
			this.UnPackTo(openMechaStuntTrackChallengeResultWithReturnT);
			return openMechaStuntTrackChallengeResultWithReturnT;
		}

		// Token: 0x0603398B RID: 211339 RVA: 0x006F4564 File Offset: 0x006F2764
		public void UnPackTo(IOpenMechaStuntTrackChallengeResultWithReturnT _o)
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

		// Token: 0x0603398C RID: 211340 RVA: 0x006F4854 File Offset: 0x006F2A54
		public static Offset<IOpenMechaStuntTrackChallengeResultWithReturn> Pack(FlatBufferBuilder builder, IOpenMechaStuntTrackChallengeResultWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenMechaStuntTrackChallengeResultWithReturn>);
			}
			TVarRef score_type = (_o.Score == null) ? TVarRef.NONE : _o.Score.Type;
			int scoreOffset = (_o.Score == null) ? 0 : TVarRefUnion.Pack(builder, _o.Score);
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenMechaStuntTrackChallengeResultWithReturn.CreateIOpenMechaStuntTrackChallengeResultWithReturn(builder, _o.Type, score_type, scoreOffset, _o.RankS, _o.RankA, _o.RankB, returnVar_type, returnVarOffset);
		}

		// Token: 0x04012460 RID: 74848
		private Table __p;
	}
}
