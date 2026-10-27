using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D05 RID: 15621
	public class IArcadeGameplayBase_UnionUnion
	{
		// Token: 0x17006B2C RID: 27436
		// (get) Token: 0x060158B5 RID: 88245 RVA: 0x0031CF31 File Offset: 0x0031B131
		// (set) Token: 0x060158B6 RID: 88246 RVA: 0x0031CF39 File Offset: 0x0031B139
		public IArcadeGameplayBase_Union Type { get; set; }

		// Token: 0x17006B2D RID: 27437
		// (get) Token: 0x060158B7 RID: 88247 RVA: 0x0031CF42 File Offset: 0x0031B142
		// (set) Token: 0x060158B8 RID: 88248 RVA: 0x0031CF4A File Offset: 0x0031B14A
		public object Value { get; set; }

		// Token: 0x060158B9 RID: 88249 RVA: 0x0031CF53 File Offset: 0x0031B153
		public IArcadeGameplayBase_UnionUnion()
		{
			this.Type = IArcadeGameplayBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060158BA RID: 88250 RVA: 0x0031CF69 File Offset: 0x0031B169
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060158BB RID: 88251 RVA: 0x0031CF7B File Offset: 0x0031B17B
		public IArcadeGameplayBaseT AsIArcadeGameplayBase()
		{
			return this.As<IArcadeGameplayBaseT>();
		}

		// Token: 0x060158BC RID: 88252 RVA: 0x0031CF83 File Offset: 0x0031B183
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayBase(IArcadeGameplayBaseT _iarcadegameplaybase)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayBase,
				Value = _iarcadegameplaybase
			};
		}

		// Token: 0x060158BD RID: 88253 RVA: 0x0031CF98 File Offset: 0x0031B198
		public IArcadeGameplayDropCatchT AsIArcadeGameplayDropCatch()
		{
			return this.As<IArcadeGameplayDropCatchT>();
		}

		// Token: 0x060158BE RID: 88254 RVA: 0x0031CFA0 File Offset: 0x0031B1A0
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayDropCatch(IArcadeGameplayDropCatchT _iarcadegameplaydropcatch)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayDropCatch,
				Value = _iarcadegameplaydropcatch
			};
		}

		// Token: 0x060158BF RID: 88255 RVA: 0x0031CFB5 File Offset: 0x0031B1B5
		public IArcadeGameplayTetrisBoardGameT AsIArcadeGameplayTetrisBoardGame()
		{
			return this.As<IArcadeGameplayTetrisBoardGameT>();
		}

		// Token: 0x060158C0 RID: 88256 RVA: 0x0031CFBD File Offset: 0x0031B1BD
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayTetrisBoardGame(IArcadeGameplayTetrisBoardGameT _iarcadegameplaytetrisboardgame)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayTetrisBoardGame,
				Value = _iarcadegameplaytetrisboardgame
			};
		}

		// Token: 0x060158C1 RID: 88257 RVA: 0x0031CFD4 File Offset: 0x0031B1D4
		public static int Pack(FlatBufferBuilder builder, IArcadeGameplayBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IArcadeGameplayBase_Union.IArcadeGameplayBase:
				return IArcadeGameplayBase.Pack(builder, _o.AsIArcadeGameplayBase()).Value;
			case IArcadeGameplayBase_Union.IArcadeGameplayDropCatch:
				return IArcadeGameplayDropCatch.Pack(builder, _o.AsIArcadeGameplayDropCatch()).Value;
			case IArcadeGameplayBase_Union.IArcadeGameplayTetrisBoardGame:
				return IArcadeGameplayTetrisBoardGame.Pack(builder, _o.AsIArcadeGameplayTetrisBoardGame()).Value;
			default:
				return 0;
			}
		}
	}
}
