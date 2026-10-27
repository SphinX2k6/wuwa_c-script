using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D0A RID: 15626
	public struct IArcadeGameplayTetrisBoardGame : IFlatbufferObject
	{
		// Token: 0x17006B33 RID: 27443
		// (get) Token: 0x060158D9 RID: 88281 RVA: 0x0031D27A File Offset: 0x0031B47A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060158DA RID: 88282 RVA: 0x0031D287 File Offset: 0x0031B487
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060158DB RID: 88283 RVA: 0x0031D290 File Offset: 0x0031B490
		public static IArcadeGameplayTetrisBoardGame GetRootAsIArcadeGameplayTetrisBoardGame(ByteBuffer _bb)
		{
			return IArcadeGameplayTetrisBoardGame.GetRootAsIArcadeGameplayTetrisBoardGame(_bb, default(IArcadeGameplayTetrisBoardGame));
		}

		// Token: 0x060158DC RID: 88284 RVA: 0x0031D2AC File Offset: 0x0031B4AC
		public static IArcadeGameplayTetrisBoardGame GetRootAsIArcadeGameplayTetrisBoardGame(ByteBuffer _bb, IArcadeGameplayTetrisBoardGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060158DD RID: 88285 RVA: 0x0031D2C9 File Offset: 0x0031B4C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060158DE RID: 88286 RVA: 0x0031D2D8 File Offset: 0x0031B4D8
		public IArcadeGameplayTetrisBoardGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B34 RID: 27444
		// (get) Token: 0x060158DF RID: 88287 RVA: 0x0031D2E8 File Offset: 0x0031B4E8
		public EArcadeGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EArcadeGameplayType.DropCatch;
				}
				return (EArcadeGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B35 RID: 27445
		// (get) Token: 0x060158E0 RID: 88288 RVA: 0x0031D324 File Offset: 0x0031B524
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060158E1 RID: 88289 RVA: 0x0031D360 File Offset: 0x0031B560
		public static Offset<IArcadeGameplayTetrisBoardGame> CreateIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch, int LevelId = 0)
		{
			builder.StartTable(2);
			IArcadeGameplayTetrisBoardGame.AddLevelId(builder, LevelId);
			IArcadeGameplayTetrisBoardGame.AddType(builder, Type);
			return IArcadeGameplayTetrisBoardGame.EndIArcadeGameplayTetrisBoardGame(builder);
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x0031D37D File Offset: 0x0031B57D
		public static void StartIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x0031D386 File Offset: 0x0031B586
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060158E4 RID: 88292 RVA: 0x0031D391 File Offset: 0x0031B591
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x0031D39C File Offset: 0x0031B59C
		public static Offset<IArcadeGameplayTetrisBoardGame> EndIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayTetrisBoardGame>(builder.EndTable());
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x0031D3AC File Offset: 0x0031B5AC
		public IArcadeGameplayTetrisBoardGameT UnPack()
		{
			IArcadeGameplayTetrisBoardGameT arcadeGameplayTetrisBoardGameT = new IArcadeGameplayTetrisBoardGameT();
			this.UnPackTo(arcadeGameplayTetrisBoardGameT);
			return arcadeGameplayTetrisBoardGameT;
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x0031D3C7 File Offset: 0x0031B5C7
		public void UnPackTo(IArcadeGameplayTetrisBoardGameT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x060158E8 RID: 88296 RVA: 0x0031D3E4 File Offset: 0x0031B5E4
		public static Offset<IArcadeGameplayTetrisBoardGame> Pack(FlatBufferBuilder builder, IArcadeGameplayTetrisBoardGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayTetrisBoardGame>);
			}
			return IArcadeGameplayTetrisBoardGame.CreateIArcadeGameplayTetrisBoardGame(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400B5BE RID: 46526
		private Table __p;
	}
}
