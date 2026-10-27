using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0F RID: 27663
	public struct IOpenMotorRaceChallengeResultWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CDBB RID: 52667
		// (get) Token: 0x06030A47 RID: 199239 RVA: 0x0069A764 File Offset: 0x00698964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A48 RID: 199240 RVA: 0x0069A771 File Offset: 0x00698971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A49 RID: 199241 RVA: 0x0069A778 File Offset: 0x00698978
		public static IOpenMotorRaceChallengeResultWithReturn GetRootAsIOpenMotorRaceChallengeResultWithReturn(ByteBuffer _bb)
		{
			return IOpenMotorRaceChallengeResultWithReturn.GetRootAsIOpenMotorRaceChallengeResultWithReturn(_bb, default(IOpenMotorRaceChallengeResultWithReturn));
		}

		// Token: 0x06030A4A RID: 199242 RVA: 0x0069A794 File Offset: 0x00698994
		public static IOpenMotorRaceChallengeResultWithReturn GetRootAsIOpenMotorRaceChallengeResultWithReturn(ByteBuffer _bb, IOpenMotorRaceChallengeResultWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A4B RID: 199243 RVA: 0x0069A7B1 File Offset: 0x006989B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A4C RID: 199244 RVA: 0x0069A7C0 File Offset: 0x006989C0
		public IOpenMotorRaceChallengeResultWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDBC RID: 52668
		// (get) Token: 0x06030A4D RID: 199245 RVA: 0x0069A7D0 File Offset: 0x006989D0
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

		// Token: 0x1700CDBD RID: 52669
		// (get) Token: 0x06030A4E RID: 199246 RVA: 0x0069A80C File Offset: 0x00698A0C
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

		// Token: 0x06030A4F RID: 199247 RVA: 0x0069A848 File Offset: 0x00698A48
		public TTable? Score<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A50 RID: 199248 RVA: 0x0069A88C File Offset: 0x00698A8C
		public IConstVarRef ScoreAsIConstVarRef()
		{
			return this.Score<IConstVarRef>().Value;
		}

		// Token: 0x06030A51 RID: 199249 RVA: 0x0069A8A8 File Offset: 0x00698AA8
		public IGlobalVarRef ScoreAsIGlobalVarRef()
		{
			return this.Score<IGlobalVarRef>().Value;
		}

		// Token: 0x06030A52 RID: 199250 RVA: 0x0069A8C4 File Offset: 0x00698AC4
		public IOtherVarRef ScoreAsIOtherVarRef()
		{
			return this.Score<IOtherVarRef>().Value;
		}

		// Token: 0x06030A53 RID: 199251 RVA: 0x0069A8E0 File Offset: 0x00698AE0
		public ISelfVarRef ScoreAsISelfVarRef()
		{
			return this.Score<ISelfVarRef>().Value;
		}

		// Token: 0x06030A54 RID: 199252 RVA: 0x0069A8FC File Offset: 0x00698AFC
		public ISystemVarRef ScoreAsISystemVarRef()
		{
			return this.Score<ISystemVarRef>().Value;
		}

		// Token: 0x1700CDBE RID: 52670
		// (get) Token: 0x06030A55 RID: 199253 RVA: 0x0069A918 File Offset: 0x00698B18
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

		// Token: 0x1700CDBF RID: 52671
		// (get) Token: 0x06030A56 RID: 199254 RVA: 0x0069A958 File Offset: 0x00698B58
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

		// Token: 0x1700CDC0 RID: 52672
		// (get) Token: 0x06030A57 RID: 199255 RVA: 0x0069A998 File Offset: 0x00698B98
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

		// Token: 0x1700CDC1 RID: 52673
		// (get) Token: 0x06030A58 RID: 199256 RVA: 0x0069A9D8 File Offset: 0x00698BD8
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

		// Token: 0x06030A59 RID: 199257 RVA: 0x0069AA18 File Offset: 0x00698C18
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A5A RID: 199258 RVA: 0x0069AA60 File Offset: 0x00698C60
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030A5B RID: 199259 RVA: 0x0069AA7C File Offset: 0x00698C7C
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030A5C RID: 199260 RVA: 0x0069AA98 File Offset: 0x00698C98
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030A5D RID: 199261 RVA: 0x0069AAB4 File Offset: 0x00698CB4
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030A5E RID: 199262 RVA: 0x0069AAD0 File Offset: 0x00698CD0
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030A5F RID: 199263 RVA: 0x0069AAEC File Offset: 0x00698CEC
		public static Offset<IOpenMotorRaceChallengeResultWithReturn> CreateIOpenMotorRaceChallengeResultWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, TVarRef Score_type = TVarRef.NONE, int ScoreOffset = 0, int RankS = 0, int RankA = 0, int RankB = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(8);
			IOpenMotorRaceChallengeResultWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenMotorRaceChallengeResultWithReturn.AddRankB(builder, RankB);
			IOpenMotorRaceChallengeResultWithReturn.AddRankA(builder, RankA);
			IOpenMotorRaceChallengeResultWithReturn.AddRankS(builder, RankS);
			IOpenMotorRaceChallengeResultWithReturn.AddScore(builder, ScoreOffset);
			IOpenMotorRaceChallengeResultWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenMotorRaceChallengeResultWithReturn.AddScoreType(builder, Score_type);
			IOpenMotorRaceChallengeResultWithReturn.AddType(builder, Type);
			return IOpenMotorRaceChallengeResultWithReturn.EndIOpenMotorRaceChallengeResultWithReturn(builder);
		}

		// Token: 0x06030A60 RID: 199264 RVA: 0x0069AB43 File Offset: 0x00698D43
		public static void StartIOpenMotorRaceChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06030A61 RID: 199265 RVA: 0x0069AB4C File Offset: 0x00698D4C
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A62 RID: 199266 RVA: 0x0069AB57 File Offset: 0x00698D57
		public static void AddScoreType(FlatBufferBuilder builder, TVarRef scoreType)
		{
			builder.AddByte(1, (byte)scoreType, 0);
		}

		// Token: 0x06030A63 RID: 199267 RVA: 0x0069AB62 File Offset: 0x00698D62
		public static void AddScore(FlatBufferBuilder builder, int scoreOffset)
		{
			builder.AddOffset(2, scoreOffset, 0);
		}

		// Token: 0x06030A64 RID: 199268 RVA: 0x0069AB6D File Offset: 0x00698D6D
		public static void AddRankS(FlatBufferBuilder builder, int rankS)
		{
			builder.AddInt(3, rankS, 0);
		}

		// Token: 0x06030A65 RID: 199269 RVA: 0x0069AB78 File Offset: 0x00698D78
		public static void AddRankA(FlatBufferBuilder builder, int rankA)
		{
			builder.AddInt(4, rankA, 0);
		}

		// Token: 0x06030A66 RID: 199270 RVA: 0x0069AB83 File Offset: 0x00698D83
		public static void AddRankB(FlatBufferBuilder builder, int rankB)
		{
			builder.AddInt(5, rankB, 0);
		}

		// Token: 0x06030A67 RID: 199271 RVA: 0x0069AB8E File Offset: 0x00698D8E
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(6, (byte)returnVarType, 0);
		}

		// Token: 0x06030A68 RID: 199272 RVA: 0x0069AB99 File Offset: 0x00698D99
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(7, returnVarOffset, 0);
		}

		// Token: 0x06030A69 RID: 199273 RVA: 0x0069ABA4 File Offset: 0x00698DA4
		public static Offset<IOpenMotorRaceChallengeResultWithReturn> EndIOpenMotorRaceChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenMotorRaceChallengeResultWithReturn>(builder.EndTable());
		}

		// Token: 0x06030A6A RID: 199274 RVA: 0x0069ABB4 File Offset: 0x00698DB4
		public IOpenMotorRaceChallengeResultWithReturnT UnPack()
		{
			IOpenMotorRaceChallengeResultWithReturnT openMotorRaceChallengeResultWithReturnT = new IOpenMotorRaceChallengeResultWithReturnT();
			this.UnPackTo(openMotorRaceChallengeResultWithReturnT);
			return openMotorRaceChallengeResultWithReturnT;
		}

		// Token: 0x06030A6B RID: 199275 RVA: 0x0069ABD0 File Offset: 0x00698DD0
		public void UnPackTo(IOpenMotorRaceChallengeResultWithReturnT _o)
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

		// Token: 0x06030A6C RID: 199276 RVA: 0x0069AEC0 File Offset: 0x006990C0
		public static Offset<IOpenMotorRaceChallengeResultWithReturn> Pack(FlatBufferBuilder builder, IOpenMotorRaceChallengeResultWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenMotorRaceChallengeResultWithReturn>);
			}
			TVarRef score_type = (_o.Score == null) ? TVarRef.NONE : _o.Score.Type;
			int scoreOffset = (_o.Score == null) ? 0 : TVarRefUnion.Pack(builder, _o.Score);
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenMotorRaceChallengeResultWithReturn.CreateIOpenMotorRaceChallengeResultWithReturn(builder, _o.Type, score_type, scoreOffset, _o.RankS, _o.RankA, _o.RankB, returnVar_type, returnVarOffset);
		}

		// Token: 0x04011510 RID: 70928
		private Table __p;
	}
}
