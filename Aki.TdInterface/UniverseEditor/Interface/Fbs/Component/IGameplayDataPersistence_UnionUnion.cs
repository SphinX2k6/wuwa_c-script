using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052EC RID: 21228
	public class IGameplayDataPersistence_UnionUnion
	{
		// Token: 0x17009BCD RID: 39885
		// (get) Token: 0x06022A7C RID: 141948 RVA: 0x004CDB64 File Offset: 0x004CBD64
		// (set) Token: 0x06022A7D RID: 141949 RVA: 0x004CDB6C File Offset: 0x004CBD6C
		public IGameplayDataPersistence_Union Type { get; set; }

		// Token: 0x17009BCE RID: 39886
		// (get) Token: 0x06022A7E RID: 141950 RVA: 0x004CDB75 File Offset: 0x004CBD75
		// (set) Token: 0x06022A7F RID: 141951 RVA: 0x004CDB7D File Offset: 0x004CBD7D
		public object Value { get; set; }

		// Token: 0x06022A80 RID: 141952 RVA: 0x004CDB86 File Offset: 0x004CBD86
		public IGameplayDataPersistence_UnionUnion()
		{
			this.Type = IGameplayDataPersistence_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022A81 RID: 141953 RVA: 0x004CDB9C File Offset: 0x004CBD9C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022A82 RID: 141954 RVA: 0x004CDBAE File Offset: 0x004CBDAE
		public IGameplayDataPersistenceT AsIGameplayDataPersistence()
		{
			return this.As<IGameplayDataPersistenceT>();
		}

		// Token: 0x06022A83 RID: 141955 RVA: 0x004CDBB6 File Offset: 0x004CBDB6
		public static IGameplayDataPersistence_UnionUnion FromIGameplayDataPersistence(IGameplayDataPersistenceT _igameplaydatapersistence)
		{
			return new IGameplayDataPersistence_UnionUnion
			{
				Type = IGameplayDataPersistence_Union.IGameplayDataPersistence,
				Value = _igameplaydatapersistence
			};
		}

		// Token: 0x06022A84 RID: 141956 RVA: 0x004CDBCB File Offset: 0x004CBDCB
		public IGameplayDataPersistenceTetrisBoardGameT AsIGameplayDataPersistenceTetrisBoardGame()
		{
			return this.As<IGameplayDataPersistenceTetrisBoardGameT>();
		}

		// Token: 0x06022A85 RID: 141957 RVA: 0x004CDBD3 File Offset: 0x004CBDD3
		public static IGameplayDataPersistence_UnionUnion FromIGameplayDataPersistenceTetrisBoardGame(IGameplayDataPersistenceTetrisBoardGameT _igameplaydatapersistencetetrisboardgame)
		{
			return new IGameplayDataPersistence_UnionUnion
			{
				Type = IGameplayDataPersistence_Union.IGameplayDataPersistenceTetrisBoardGame,
				Value = _igameplaydatapersistencetetrisboardgame
			};
		}

		// Token: 0x06022A86 RID: 141958 RVA: 0x004CDBE8 File Offset: 0x004CBDE8
		public static int Pack(FlatBufferBuilder builder, IGameplayDataPersistence_UnionUnion _o)
		{
			IGameplayDataPersistence_Union type = _o.Type;
			if (type == IGameplayDataPersistence_Union.IGameplayDataPersistence)
			{
				return IGameplayDataPersistence.Pack(builder, _o.AsIGameplayDataPersistence()).Value;
			}
			if (type != IGameplayDataPersistence_Union.IGameplayDataPersistenceTetrisBoardGame)
			{
				return 0;
			}
			return IGameplayDataPersistenceTetrisBoardGame.Pack(builder, _o.AsIGameplayDataPersistenceTetrisBoardGame()).Value;
		}
	}
}
