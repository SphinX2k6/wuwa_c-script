using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E8 RID: 21224
	public struct IGameplayDataPersistenceTetrisBoardGame : IFlatbufferObject
	{
		// Token: 0x17009BC8 RID: 39880
		// (get) Token: 0x06022A5F RID: 141919 RVA: 0x004CD6D7 File Offset: 0x004CB8D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A60 RID: 141920 RVA: 0x004CD6E4 File Offset: 0x004CB8E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A61 RID: 141921 RVA: 0x004CD6EC File Offset: 0x004CB8EC
		public static IGameplayDataPersistenceTetrisBoardGame GetRootAsIGameplayDataPersistenceTetrisBoardGame(ByteBuffer _bb)
		{
			return IGameplayDataPersistenceTetrisBoardGame.GetRootAsIGameplayDataPersistenceTetrisBoardGame(_bb, default(IGameplayDataPersistenceTetrisBoardGame));
		}

		// Token: 0x06022A62 RID: 141922 RVA: 0x004CD708 File Offset: 0x004CB908
		public static IGameplayDataPersistenceTetrisBoardGame GetRootAsIGameplayDataPersistenceTetrisBoardGame(ByteBuffer _bb, IGameplayDataPersistenceTetrisBoardGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A63 RID: 141923 RVA: 0x004CD725 File Offset: 0x004CB925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A64 RID: 141924 RVA: 0x004CD734 File Offset: 0x004CB934
		public IGameplayDataPersistenceTetrisBoardGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BC9 RID: 39881
		// (get) Token: 0x06022A65 RID: 141925 RVA: 0x004CD744 File Offset: 0x004CB944
		public EDataPersistenceGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDataPersistenceGameplayType.TetrisBoardGame;
				}
				return (EDataPersistenceGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009BCA RID: 39882
		// (get) Token: 0x06022A66 RID: 141926 RVA: 0x004CD780 File Offset: 0x004CB980
		public TVarRef HighestScoreSyncVarType
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

		// Token: 0x06022A67 RID: 141927 RVA: 0x004CD7BC File Offset: 0x004CB9BC
		public TTable? HighestScoreSyncVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022A68 RID: 141928 RVA: 0x004CD800 File Offset: 0x004CBA00
		public IConstVarRef HighestScoreSyncVarAsIConstVarRef()
		{
			return this.HighestScoreSyncVar<IConstVarRef>().Value;
		}

		// Token: 0x06022A69 RID: 141929 RVA: 0x004CD81C File Offset: 0x004CBA1C
		public IGlobalVarRef HighestScoreSyncVarAsIGlobalVarRef()
		{
			return this.HighestScoreSyncVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06022A6A RID: 141930 RVA: 0x004CD838 File Offset: 0x004CBA38
		public IOtherVarRef HighestScoreSyncVarAsIOtherVarRef()
		{
			return this.HighestScoreSyncVar<IOtherVarRef>().Value;
		}

		// Token: 0x06022A6B RID: 141931 RVA: 0x004CD854 File Offset: 0x004CBA54
		public ISelfVarRef HighestScoreSyncVarAsISelfVarRef()
		{
			return this.HighestScoreSyncVar<ISelfVarRef>().Value;
		}

		// Token: 0x06022A6C RID: 141932 RVA: 0x004CD870 File Offset: 0x004CBA70
		public ISystemVarRef HighestScoreSyncVarAsISystemVarRef()
		{
			return this.HighestScoreSyncVar<ISystemVarRef>().Value;
		}

		// Token: 0x06022A6D RID: 141933 RVA: 0x004CD88B File Offset: 0x004CBA8B
		public static Offset<IGameplayDataPersistenceTetrisBoardGame> CreateIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder, EDataPersistenceGameplayType Type = EDataPersistenceGameplayType.TetrisBoardGame, TVarRef HighestScoreSyncVar_type = TVarRef.NONE, int HighestScoreSyncVarOffset = 0)
		{
			builder.StartTable(3);
			IGameplayDataPersistenceTetrisBoardGame.AddHighestScoreSyncVar(builder, HighestScoreSyncVarOffset);
			IGameplayDataPersistenceTetrisBoardGame.AddHighestScoreSyncVarType(builder, HighestScoreSyncVar_type);
			IGameplayDataPersistenceTetrisBoardGame.AddType(builder, Type);
			return IGameplayDataPersistenceTetrisBoardGame.EndIGameplayDataPersistenceTetrisBoardGame(builder);
		}

		// Token: 0x06022A6E RID: 141934 RVA: 0x004CD8AF File Offset: 0x004CBAAF
		public static void StartIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022A6F RID: 141935 RVA: 0x004CD8B8 File Offset: 0x004CBAB8
		public static void AddType(FlatBufferBuilder builder, EDataPersistenceGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022A70 RID: 141936 RVA: 0x004CD8C3 File Offset: 0x004CBAC3
		public static void AddHighestScoreSyncVarType(FlatBufferBuilder builder, TVarRef highestScoreSyncVarType)
		{
			builder.AddByte(1, (byte)highestScoreSyncVarType, 0);
		}

		// Token: 0x06022A71 RID: 141937 RVA: 0x004CD8CE File Offset: 0x004CBACE
		public static void AddHighestScoreSyncVar(FlatBufferBuilder builder, int highestScoreSyncVarOffset)
		{
			builder.AddOffset(2, highestScoreSyncVarOffset, 0);
		}

		// Token: 0x06022A72 RID: 141938 RVA: 0x004CD8D9 File Offset: 0x004CBAD9
		public static Offset<IGameplayDataPersistenceTetrisBoardGame> EndIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistenceTetrisBoardGame>(builder.EndTable());
		}

		// Token: 0x06022A73 RID: 141939 RVA: 0x004CD8E8 File Offset: 0x004CBAE8
		public IGameplayDataPersistenceTetrisBoardGameT UnPack()
		{
			IGameplayDataPersistenceTetrisBoardGameT gameplayDataPersistenceTetrisBoardGameT = new IGameplayDataPersistenceTetrisBoardGameT();
			this.UnPackTo(gameplayDataPersistenceTetrisBoardGameT);
			return gameplayDataPersistenceTetrisBoardGameT;
		}

		// Token: 0x06022A74 RID: 141940 RVA: 0x004CD904 File Offset: 0x004CBB04
		public void UnPackTo(IGameplayDataPersistenceTetrisBoardGameT _o)
		{
			_o.Type = this.Type;
			_o.HighestScoreSyncVar = new TVarRefUnion();
			_o.HighestScoreSyncVar.Type = this.HighestScoreSyncVarType;
			switch (this.HighestScoreSyncVarType)
			{
			case TVarRef.IConstVarRef:
				_o.HighestScoreSyncVar.Value = ((this.HighestScoreSyncVar<IConstVarRef>() != null) ? this.HighestScoreSyncVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.HighestScoreSyncVar.Value = ((this.HighestScoreSyncVar<IGlobalVarRef>() != null) ? this.HighestScoreSyncVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.HighestScoreSyncVar.Value = ((this.HighestScoreSyncVar<IOtherVarRef>() != null) ? this.HighestScoreSyncVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.HighestScoreSyncVar.Value = ((this.HighestScoreSyncVar<ISelfVarRef>() != null) ? this.HighestScoreSyncVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.HighestScoreSyncVar.Value = ((this.HighestScoreSyncVar<ISystemVarRef>() != null) ? this.HighestScoreSyncVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06022A75 RID: 141941 RVA: 0x004CDA70 File Offset: 0x004CBC70
		public static Offset<IGameplayDataPersistenceTetrisBoardGame> Pack(FlatBufferBuilder builder, IGameplayDataPersistenceTetrisBoardGameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayDataPersistenceTetrisBoardGame>);
			}
			TVarRef highestScoreSyncVar_type = (_o.HighestScoreSyncVar == null) ? TVarRef.NONE : _o.HighestScoreSyncVar.Type;
			int highestScoreSyncVarOffset = (_o.HighestScoreSyncVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.HighestScoreSyncVar);
			return IGameplayDataPersistenceTetrisBoardGame.CreateIGameplayDataPersistenceTetrisBoardGame(builder, _o.Type, highestScoreSyncVar_type, highestScoreSyncVarOffset);
		}

		// Token: 0x0400E487 RID: 58503
		private Table __p;
	}
}
