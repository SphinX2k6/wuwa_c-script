using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586B RID: 22635
	public struct IGameplayDataPersistenceTetrisBoardGame : IFlatbufferObject
	{
		// Token: 0x1700A3F9 RID: 41977
		// (get) Token: 0x06024AF9 RID: 150265 RVA: 0x0050A203 File Offset: 0x00508403
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024AFA RID: 150266 RVA: 0x0050A210 File Offset: 0x00508410
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024AFB RID: 150267 RVA: 0x0050A218 File Offset: 0x00508418
		public static IGameplayDataPersistenceTetrisBoardGame GetRootAsIGameplayDataPersistenceTetrisBoardGame(ByteBuffer _bb)
		{
			return IGameplayDataPersistenceTetrisBoardGame.GetRootAsIGameplayDataPersistenceTetrisBoardGame(_bb, default(IGameplayDataPersistenceTetrisBoardGame));
		}

		// Token: 0x06024AFC RID: 150268 RVA: 0x0050A234 File Offset: 0x00508434
		public static IGameplayDataPersistenceTetrisBoardGame GetRootAsIGameplayDataPersistenceTetrisBoardGame(ByteBuffer _bb, IGameplayDataPersistenceTetrisBoardGame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024AFD RID: 150269 RVA: 0x0050A251 File Offset: 0x00508451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024AFE RID: 150270 RVA: 0x0050A260 File Offset: 0x00508460
		public IGameplayDataPersistenceTetrisBoardGame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3FA RID: 41978
		// (get) Token: 0x06024AFF RID: 150271 RVA: 0x0050A270 File Offset: 0x00508470
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

		// Token: 0x1700A3FB RID: 41979
		// (get) Token: 0x06024B00 RID: 150272 RVA: 0x0050A2AC File Offset: 0x005084AC
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

		// Token: 0x06024B01 RID: 150273 RVA: 0x0050A2E8 File Offset: 0x005084E8
		public TTable? HighestScoreSyncVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024B02 RID: 150274 RVA: 0x0050A32C File Offset: 0x0050852C
		public IConstVarRef HighestScoreSyncVarAsIConstVarRef()
		{
			return this.HighestScoreSyncVar<IConstVarRef>().Value;
		}

		// Token: 0x06024B03 RID: 150275 RVA: 0x0050A348 File Offset: 0x00508548
		public IGlobalVarRef HighestScoreSyncVarAsIGlobalVarRef()
		{
			return this.HighestScoreSyncVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06024B04 RID: 150276 RVA: 0x0050A364 File Offset: 0x00508564
		public IOtherVarRef HighestScoreSyncVarAsIOtherVarRef()
		{
			return this.HighestScoreSyncVar<IOtherVarRef>().Value;
		}

		// Token: 0x06024B05 RID: 150277 RVA: 0x0050A380 File Offset: 0x00508580
		public ISelfVarRef HighestScoreSyncVarAsISelfVarRef()
		{
			return this.HighestScoreSyncVar<ISelfVarRef>().Value;
		}

		// Token: 0x06024B06 RID: 150278 RVA: 0x0050A39C File Offset: 0x0050859C
		public ISystemVarRef HighestScoreSyncVarAsISystemVarRef()
		{
			return this.HighestScoreSyncVar<ISystemVarRef>().Value;
		}

		// Token: 0x06024B07 RID: 150279 RVA: 0x0050A3B7 File Offset: 0x005085B7
		public static Offset<IGameplayDataPersistenceTetrisBoardGame> CreateIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder, EDataPersistenceGameplayType Type = EDataPersistenceGameplayType.TetrisBoardGame, TVarRef HighestScoreSyncVar_type = TVarRef.NONE, int HighestScoreSyncVarOffset = 0)
		{
			builder.StartTable(3);
			IGameplayDataPersistenceTetrisBoardGame.AddHighestScoreSyncVar(builder, HighestScoreSyncVarOffset);
			IGameplayDataPersistenceTetrisBoardGame.AddHighestScoreSyncVarType(builder, HighestScoreSyncVar_type);
			IGameplayDataPersistenceTetrisBoardGame.AddType(builder, Type);
			return IGameplayDataPersistenceTetrisBoardGame.EndIGameplayDataPersistenceTetrisBoardGame(builder);
		}

		// Token: 0x06024B08 RID: 150280 RVA: 0x0050A3DB File Offset: 0x005085DB
		public static void StartIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024B09 RID: 150281 RVA: 0x0050A3E4 File Offset: 0x005085E4
		public static void AddType(FlatBufferBuilder builder, EDataPersistenceGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024B0A RID: 150282 RVA: 0x0050A3EF File Offset: 0x005085EF
		public static void AddHighestScoreSyncVarType(FlatBufferBuilder builder, TVarRef highestScoreSyncVarType)
		{
			builder.AddByte(1, (byte)highestScoreSyncVarType, 0);
		}

		// Token: 0x06024B0B RID: 150283 RVA: 0x0050A3FA File Offset: 0x005085FA
		public static void AddHighestScoreSyncVar(FlatBufferBuilder builder, int highestScoreSyncVarOffset)
		{
			builder.AddOffset(2, highestScoreSyncVarOffset, 0);
		}

		// Token: 0x06024B0C RID: 150284 RVA: 0x0050A405 File Offset: 0x00508605
		public static Offset<IGameplayDataPersistenceTetrisBoardGame> EndIGameplayDataPersistenceTetrisBoardGame(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayDataPersistenceTetrisBoardGame>(builder.EndTable());
		}

		// Token: 0x06024B0D RID: 150285 RVA: 0x0050A414 File Offset: 0x00508614
		public IGameplayDataPersistenceTetrisBoardGameT UnPack()
		{
			IGameplayDataPersistenceTetrisBoardGameT gameplayDataPersistenceTetrisBoardGameT = new IGameplayDataPersistenceTetrisBoardGameT();
			this.UnPackTo(gameplayDataPersistenceTetrisBoardGameT);
			return gameplayDataPersistenceTetrisBoardGameT;
		}

		// Token: 0x06024B0E RID: 150286 RVA: 0x0050A430 File Offset: 0x00508630
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

		// Token: 0x06024B0F RID: 150287 RVA: 0x0050A59C File Offset: 0x0050879C
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

		// Token: 0x0400F0B3 RID: 61619
		private Table __p;
	}
}
