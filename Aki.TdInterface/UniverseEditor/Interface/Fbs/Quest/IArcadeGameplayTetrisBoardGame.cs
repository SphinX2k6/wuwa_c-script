using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004121 RID: 16673
	public struct IArcadeGameplayTetrisBoardGame : IFlatbufferObject
	{
		// Token: 0x170070ED RID: 28909
		// (get) Token: 0x06016E11 RID: 93713 RVA: 0x003444F2 File Offset: 0x003426F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x003444FF File Offset: 0x003426FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x00344508 File Offset: 0x00342708
		public static IArcadeGameplayTetrisBoardGame GetRootAsIArcadeGameplayTetrisBoardGame(ByteBuffer _bb)
		{
			return IArcadeGameplayTetrisBoardGame.GetRootAsIArcadeGameplayTetrisBoardGame(_bb, default(IArcadeGameplayTetrisBoardGame));
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x00344524 File Offset: 0x00342724
		public static IArcadeGameplayTetrisBoardGame GetRootAsIArcadeGameplayTetrisBoardGame(ByteBuffer _bb, IArcadeGameplayTetrisBoardGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x00344541 File Offset: 0x00342741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x00344550 File Offset: 0x00342750
		public IArcadeGameplayTetrisBoardGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070EE RID: 28910
		// (get) Token: 0x06016E17 RID: 93719 RVA: 0x00344560 File Offset: 0x00342760
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

		// Token: 0x170070EF RID: 28911
		// (get) Token: 0x06016E18 RID: 93720 RVA: 0x0034459C File Offset: 0x0034279C
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

		// Token: 0x06016E19 RID: 93721 RVA: 0x003445D8 File Offset: 0x003427D8
		public static Offset<IArcadeGameplayTetrisBoardGame> CreateIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch, int LevelId = 0)
		{
			builder.StartTable(2);
			IArcadeGameplayTetrisBoardGame.AddLevelId(builder, LevelId);
			IArcadeGameplayTetrisBoardGame.AddType(builder, Type);
			return IArcadeGameplayTetrisBoardGame.EndIArcadeGameplayTetrisBoardGame(builder);
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x003445F5 File Offset: 0x003427F5
		public static void StartIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016E1B RID: 93723 RVA: 0x003445FE File Offset: 0x003427FE
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E1C RID: 93724 RVA: 0x00344609 File Offset: 0x00342809
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x06016E1D RID: 93725 RVA: 0x00344614 File Offset: 0x00342814
		public static Offset<IArcadeGameplayTetrisBoardGame> EndIArcadeGameplayTetrisBoardGame(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayTetrisBoardGame>(builder.EndTable());
		}

		// Token: 0x06016E1E RID: 93726 RVA: 0x00344624 File Offset: 0x00342824
		public IArcadeGameplayTetrisBoardGameT UnPack()
		{
			IArcadeGameplayTetrisBoardGameT arcadeGameplayTetrisBoardGameT = new IArcadeGameplayTetrisBoardGameT();
			this.UnPackTo(arcadeGameplayTetrisBoardGameT);
			return arcadeGameplayTetrisBoardGameT;
		}

		// Token: 0x06016E1F RID: 93727 RVA: 0x0034463F File Offset: 0x0034283F
		public void UnPackTo(IArcadeGameplayTetrisBoardGameT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x0034465C File Offset: 0x0034285C
		public static Offset<IArcadeGameplayTetrisBoardGame> Pack(FlatBufferBuilder builder, IArcadeGameplayTetrisBoardGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayTetrisBoardGame>);
			}
			return IArcadeGameplayTetrisBoardGame.CreateIArcadeGameplayTetrisBoardGame(builder, _o.Type, _o.LevelId);
		}

		// Token: 0x0400BF6B RID: 49003
		private Table __p;
	}
}
