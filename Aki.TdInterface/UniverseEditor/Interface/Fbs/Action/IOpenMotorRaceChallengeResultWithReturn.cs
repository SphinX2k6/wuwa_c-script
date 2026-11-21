using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007376 RID: 29558
	public struct IOpenMotorRaceChallengeResultWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D8D6 RID: 55510
		// (get) Token: 0x0603399B RID: 211355 RVA: 0x006F4A5E File Offset: 0x006F2C5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603399C RID: 211356 RVA: 0x006F4A6B File Offset: 0x006F2C6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603399D RID: 211357 RVA: 0x006F4A74 File Offset: 0x006F2C74
		public static IOpenMotorRaceChallengeResultWithReturn GetRootAsIOpenMotorRaceChallengeResultWithReturn(ByteBuffer _bb)
		{
			return IOpenMotorRaceChallengeResultWithReturn.GetRootAsIOpenMotorRaceChallengeResultWithReturn(_bb, default(IOpenMotorRaceChallengeResultWithReturn));
		}

		// Token: 0x0603399E RID: 211358 RVA: 0x006F4A90 File Offset: 0x006F2C90
		public static IOpenMotorRaceChallengeResultWithReturn GetRootAsIOpenMotorRaceChallengeResultWithReturn(ByteBuffer _bb, IOpenMotorRaceChallengeResultWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603399F RID: 211359 RVA: 0x006F4AAD File Offset: 0x006F2CAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339A0 RID: 211360 RVA: 0x006F4ABC File Offset: 0x006F2CBC
		public IOpenMotorRaceChallengeResultWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8D7 RID: 55511
		// (get) Token: 0x060339A1 RID: 211361 RVA: 0x006F4ACC File Offset: 0x006F2CCC
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

		// Token: 0x1700D8D8 RID: 55512
		// (get) Token: 0x060339A2 RID: 211362 RVA: 0x006F4B08 File Offset: 0x006F2D08
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

		// Token: 0x060339A3 RID: 211363 RVA: 0x006F4B44 File Offset: 0x006F2D44
		public TTable? Score<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060339A4 RID: 211364 RVA: 0x006F4B88 File Offset: 0x006F2D88
		public IConstVarRef ScoreAsIConstVarRef()
		{
			return this.Score<IConstVarRef>().Value;
		}

		// Token: 0x060339A5 RID: 211365 RVA: 0x006F4BA4 File Offset: 0x006F2DA4
		public IGlobalVarRef ScoreAsIGlobalVarRef()
		{
			return this.Score<IGlobalVarRef>().Value;
		}

		// Token: 0x060339A6 RID: 211366 RVA: 0x006F4BC0 File Offset: 0x006F2DC0
		public IOtherVarRef ScoreAsIOtherVarRef()
		{
			return this.Score<IOtherVarRef>().Value;
		}

		// Token: 0x060339A7 RID: 211367 RVA: 0x006F4BDC File Offset: 0x006F2DDC
		public ISelfVarRef ScoreAsISelfVarRef()
		{
			return this.Score<ISelfVarRef>().Value;
		}

		// Token: 0x060339A8 RID: 211368 RVA: 0x006F4BF8 File Offset: 0x006F2DF8
		public ISystemVarRef ScoreAsISystemVarRef()
		{
			return this.Score<ISystemVarRef>().Value;
		}

		// Token: 0x1700D8D9 RID: 55513
		// (get) Token: 0x060339A9 RID: 211369 RVA: 0x006F4C14 File Offset: 0x006F2E14
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

		// Token: 0x1700D8DA RID: 55514
		// (get) Token: 0x060339AA RID: 211370 RVA: 0x006F4C54 File Offset: 0x006F2E54
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

		// Token: 0x1700D8DB RID: 55515
		// (get) Token: 0x060339AB RID: 211371 RVA: 0x006F4C94 File Offset: 0x006F2E94
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

		// Token: 0x1700D8DC RID: 55516
		// (get) Token: 0x060339AC RID: 211372 RVA: 0x006F4CD4 File Offset: 0x006F2ED4
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

		// Token: 0x060339AD RID: 211373 RVA: 0x006F4D14 File Offset: 0x006F2F14
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060339AE RID: 211374 RVA: 0x006F4D5C File Offset: 0x006F2F5C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x060339AF RID: 211375 RVA: 0x006F4D78 File Offset: 0x006F2F78
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060339B0 RID: 211376 RVA: 0x006F4D94 File Offset: 0x006F2F94
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x060339B1 RID: 211377 RVA: 0x006F4DB0 File Offset: 0x006F2FB0
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x060339B2 RID: 211378 RVA: 0x006F4DCC File Offset: 0x006F2FCC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x060339B3 RID: 211379 RVA: 0x006F4DE8 File Offset: 0x006F2FE8
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

		// Token: 0x060339B4 RID: 211380 RVA: 0x006F4E3F File Offset: 0x006F303F
		public static void StartIOpenMotorRaceChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060339B5 RID: 211381 RVA: 0x006F4E48 File Offset: 0x006F3048
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060339B6 RID: 211382 RVA: 0x006F4E53 File Offset: 0x006F3053
		public static void AddScoreType(FlatBufferBuilder builder, TVarRef scoreType)
		{
			builder.AddByte(1, (byte)scoreType, 0);
		}

		// Token: 0x060339B7 RID: 211383 RVA: 0x006F4E5E File Offset: 0x006F305E
		public static void AddScore(FlatBufferBuilder builder, int scoreOffset)
		{
			builder.AddOffset(2, scoreOffset, 0);
		}

		// Token: 0x060339B8 RID: 211384 RVA: 0x006F4E69 File Offset: 0x006F3069
		public static void AddRankS(FlatBufferBuilder builder, int rankS)
		{
			builder.AddInt(3, rankS, 0);
		}

		// Token: 0x060339B9 RID: 211385 RVA: 0x006F4E74 File Offset: 0x006F3074
		public static void AddRankA(FlatBufferBuilder builder, int rankA)
		{
			builder.AddInt(4, rankA, 0);
		}

		// Token: 0x060339BA RID: 211386 RVA: 0x006F4E7F File Offset: 0x006F307F
		public static void AddRankB(FlatBufferBuilder builder, int rankB)
		{
			builder.AddInt(5, rankB, 0);
		}

		// Token: 0x060339BB RID: 211387 RVA: 0x006F4E8A File Offset: 0x006F308A
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(6, (byte)returnVarType, 0);
		}

		// Token: 0x060339BC RID: 211388 RVA: 0x006F4E95 File Offset: 0x006F3095
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(7, returnVarOffset, 0);
		}

		// Token: 0x060339BD RID: 211389 RVA: 0x006F4EA0 File Offset: 0x006F30A0
		public static Offset<IOpenMotorRaceChallengeResultWithReturn> EndIOpenMotorRaceChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenMotorRaceChallengeResultWithReturn>(builder.EndTable());
		}

		// Token: 0x060339BE RID: 211390 RVA: 0x006F4EB0 File Offset: 0x006F30B0
		public IOpenMotorRaceChallengeResultWithReturnT UnPack()
		{
			IOpenMotorRaceChallengeResultWithReturnT openMotorRaceChallengeResultWithReturnT = new IOpenMotorRaceChallengeResultWithReturnT();
			this.UnPackTo(openMotorRaceChallengeResultWithReturnT);
			return openMotorRaceChallengeResultWithReturnT;
		}

		// Token: 0x060339BF RID: 211391 RVA: 0x006F4ECC File Offset: 0x006F30CC
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

		// Token: 0x060339C0 RID: 211392 RVA: 0x006F51BC File Offset: 0x006F33BC
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

		// Token: 0x04012467 RID: 74855
		private Table __p;
	}
}
