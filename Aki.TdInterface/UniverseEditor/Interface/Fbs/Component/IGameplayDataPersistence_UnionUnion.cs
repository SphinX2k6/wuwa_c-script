using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586F RID: 22639
	public class IGameplayDataPersistence_UnionUnion
	{
		// Token: 0x1700A3FE RID: 41982
		// (get) Token: 0x06024B16 RID: 150294 RVA: 0x0050A690 File Offset: 0x00508890
		// (set) Token: 0x06024B17 RID: 150295 RVA: 0x0050A698 File Offset: 0x00508898
		public IGameplayDataPersistence_Union Type { get; set; }

		// Token: 0x1700A3FF RID: 41983
		// (get) Token: 0x06024B18 RID: 150296 RVA: 0x0050A6A1 File Offset: 0x005088A1
		// (set) Token: 0x06024B19 RID: 150297 RVA: 0x0050A6A9 File Offset: 0x005088A9
		public object Value { get; set; }

		// Token: 0x06024B1A RID: 150298 RVA: 0x0050A6B2 File Offset: 0x005088B2
		public IGameplayDataPersistence_UnionUnion()
		{
			this.Type = IGameplayDataPersistence_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024B1B RID: 150299 RVA: 0x0050A6C8 File Offset: 0x005088C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024B1C RID: 150300 RVA: 0x0050A6DA File Offset: 0x005088DA
		public IGameplayDataPersistenceT AsIGameplayDataPersistence()
		{
			return this.As<IGameplayDataPersistenceT>();
		}

		// Token: 0x06024B1D RID: 150301 RVA: 0x0050A6E2 File Offset: 0x005088E2
		public static IGameplayDataPersistence_UnionUnion FromIGameplayDataPersistence(IGameplayDataPersistenceT _igameplaydatapersistence)
		{
			return new IGameplayDataPersistence_UnionUnion
			{
				Type = IGameplayDataPersistence_Union.IGameplayDataPersistence,
				Value = _igameplaydatapersistence
			};
		}

		// Token: 0x06024B1E RID: 150302 RVA: 0x0050A6F7 File Offset: 0x005088F7
		public IGameplayDataPersistenceTetrisBoardGameT AsIGameplayDataPersistenceTetrisBoardGame()
		{
			return this.As<IGameplayDataPersistenceTetrisBoardGameT>();
		}

		// Token: 0x06024B1F RID: 150303 RVA: 0x0050A6FF File Offset: 0x005088FF
		public static IGameplayDataPersistence_UnionUnion FromIGameplayDataPersistenceTetrisBoardGame(IGameplayDataPersistenceTetrisBoardGameT _igameplaydatapersistencetetrisboardgame)
		{
			return new IGameplayDataPersistence_UnionUnion
			{
				Type = IGameplayDataPersistence_Union.IGameplayDataPersistenceTetrisBoardGame,
				Value = _igameplaydatapersistencetetrisboardgame
			};
		}

		// Token: 0x06024B20 RID: 150304 RVA: 0x0050A714 File Offset: 0x00508914
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
