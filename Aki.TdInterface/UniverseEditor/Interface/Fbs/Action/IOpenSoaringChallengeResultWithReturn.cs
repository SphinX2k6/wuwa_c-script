using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C30 RID: 27696
	public struct IOpenSoaringChallengeResultWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CE03 RID: 52739
		// (get) Token: 0x06030BA2 RID: 199586 RVA: 0x0069DC50 File Offset: 0x0069BE50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030BA3 RID: 199587 RVA: 0x0069DC5D File Offset: 0x0069BE5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030BA4 RID: 199588 RVA: 0x0069DC64 File Offset: 0x0069BE64
		public static IOpenSoaringChallengeResultWithReturn GetRootAsIOpenSoaringChallengeResultWithReturn(ByteBuffer _bb)
		{
			return IOpenSoaringChallengeResultWithReturn.GetRootAsIOpenSoaringChallengeResultWithReturn(_bb, default(IOpenSoaringChallengeResultWithReturn));
		}

		// Token: 0x06030BA5 RID: 199589 RVA: 0x0069DC80 File Offset: 0x0069BE80
		public static IOpenSoaringChallengeResultWithReturn GetRootAsIOpenSoaringChallengeResultWithReturn(ByteBuffer _bb, IOpenSoaringChallengeResultWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030BA6 RID: 199590 RVA: 0x0069DC9D File Offset: 0x0069BE9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030BA7 RID: 199591 RVA: 0x0069DCAC File Offset: 0x0069BEAC
		public IOpenSoaringChallengeResultWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE04 RID: 52740
		// (get) Token: 0x06030BA8 RID: 199592 RVA: 0x0069DCBC File Offset: 0x0069BEBC
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

		// Token: 0x1700CE05 RID: 52741
		// (get) Token: 0x06030BA9 RID: 199593 RVA: 0x0069DCF8 File Offset: 0x0069BEF8
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

		// Token: 0x06030BAA RID: 199594 RVA: 0x0069DD34 File Offset: 0x0069BF34
		public TTable? Score<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BAB RID: 199595 RVA: 0x0069DD78 File Offset: 0x0069BF78
		public IConstVarRef ScoreAsIConstVarRef()
		{
			return this.Score<IConstVarRef>().Value;
		}

		// Token: 0x06030BAC RID: 199596 RVA: 0x0069DD94 File Offset: 0x0069BF94
		public IGlobalVarRef ScoreAsIGlobalVarRef()
		{
			return this.Score<IGlobalVarRef>().Value;
		}

		// Token: 0x06030BAD RID: 199597 RVA: 0x0069DDB0 File Offset: 0x0069BFB0
		public IOtherVarRef ScoreAsIOtherVarRef()
		{
			return this.Score<IOtherVarRef>().Value;
		}

		// Token: 0x06030BAE RID: 199598 RVA: 0x0069DDCC File Offset: 0x0069BFCC
		public ISelfVarRef ScoreAsISelfVarRef()
		{
			return this.Score<ISelfVarRef>().Value;
		}

		// Token: 0x06030BAF RID: 199599 RVA: 0x0069DDE8 File Offset: 0x0069BFE8
		public ISystemVarRef ScoreAsISystemVarRef()
		{
			return this.Score<ISystemVarRef>().Value;
		}

		// Token: 0x1700CE06 RID: 52742
		// (get) Token: 0x06030BB0 RID: 199600 RVA: 0x0069DE04 File Offset: 0x0069C004
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

		// Token: 0x1700CE07 RID: 52743
		// (get) Token: 0x06030BB1 RID: 199601 RVA: 0x0069DE44 File Offset: 0x0069C044
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

		// Token: 0x1700CE08 RID: 52744
		// (get) Token: 0x06030BB2 RID: 199602 RVA: 0x0069DE84 File Offset: 0x0069C084
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

		// Token: 0x1700CE09 RID: 52745
		// (get) Token: 0x06030BB3 RID: 199603 RVA: 0x0069DEC4 File Offset: 0x0069C0C4
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

		// Token: 0x06030BB4 RID: 199604 RVA: 0x0069DF04 File Offset: 0x0069C104
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BB5 RID: 199605 RVA: 0x0069DF4C File Offset: 0x0069C14C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030BB6 RID: 199606 RVA: 0x0069DF68 File Offset: 0x0069C168
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030BB7 RID: 199607 RVA: 0x0069DF84 File Offset: 0x0069C184
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030BB8 RID: 199608 RVA: 0x0069DFA0 File Offset: 0x0069C1A0
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030BB9 RID: 199609 RVA: 0x0069DFBC File Offset: 0x0069C1BC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030BBA RID: 199610 RVA: 0x0069DFD8 File Offset: 0x0069C1D8
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

		// Token: 0x06030BBB RID: 199611 RVA: 0x0069E02F File Offset: 0x0069C22F
		public static void StartIOpenSoaringChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06030BBC RID: 199612 RVA: 0x0069E038 File Offset: 0x0069C238
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030BBD RID: 199613 RVA: 0x0069E043 File Offset: 0x0069C243
		public static void AddScoreType(FlatBufferBuilder builder, TVarRef scoreType)
		{
			builder.AddByte(1, (byte)scoreType, 0);
		}

		// Token: 0x06030BBE RID: 199614 RVA: 0x0069E04E File Offset: 0x0069C24E
		public static void AddScore(FlatBufferBuilder builder, int scoreOffset)
		{
			builder.AddOffset(2, scoreOffset, 0);
		}

		// Token: 0x06030BBF RID: 199615 RVA: 0x0069E059 File Offset: 0x0069C259
		public static void AddRankS(FlatBufferBuilder builder, int rankS)
		{
			builder.AddInt(3, rankS, 0);
		}

		// Token: 0x06030BC0 RID: 199616 RVA: 0x0069E064 File Offset: 0x0069C264
		public static void AddRankA(FlatBufferBuilder builder, int rankA)
		{
			builder.AddInt(4, rankA, 0);
		}

		// Token: 0x06030BC1 RID: 199617 RVA: 0x0069E06F File Offset: 0x0069C26F
		public static void AddRankB(FlatBufferBuilder builder, int rankB)
		{
			builder.AddInt(5, rankB, 0);
		}

		// Token: 0x06030BC2 RID: 199618 RVA: 0x0069E07A File Offset: 0x0069C27A
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(6, (byte)returnVarType, 0);
		}

		// Token: 0x06030BC3 RID: 199619 RVA: 0x0069E085 File Offset: 0x0069C285
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(7, returnVarOffset, 0);
		}

		// Token: 0x06030BC4 RID: 199620 RVA: 0x0069E090 File Offset: 0x0069C290
		public static Offset<IOpenSoaringChallengeResultWithReturn> EndIOpenSoaringChallengeResultWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSoaringChallengeResultWithReturn>(builder.EndTable());
		}

		// Token: 0x06030BC5 RID: 199621 RVA: 0x0069E0A0 File Offset: 0x0069C2A0
		public IOpenSoaringChallengeResultWithReturnT UnPack()
		{
			IOpenSoaringChallengeResultWithReturnT openSoaringChallengeResultWithReturnT = new IOpenSoaringChallengeResultWithReturnT();
			this.UnPackTo(openSoaringChallengeResultWithReturnT);
			return openSoaringChallengeResultWithReturnT;
		}

		// Token: 0x06030BC6 RID: 199622 RVA: 0x0069E0BC File Offset: 0x0069C2BC
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

		// Token: 0x06030BC7 RID: 199623 RVA: 0x0069E3AC File Offset: 0x0069C5AC
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

		// Token: 0x0401153F RID: 70975
		private Table __p;
	}
}
