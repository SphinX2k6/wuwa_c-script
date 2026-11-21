using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200411C RID: 16668
	public class IArcadeGameplayBase_UnionUnion
	{
		// Token: 0x170070E6 RID: 28902
		// (get) Token: 0x06016DED RID: 93677 RVA: 0x003441A9 File Offset: 0x003423A9
		// (set) Token: 0x06016DEE RID: 93678 RVA: 0x003441B1 File Offset: 0x003423B1
		public IArcadeGameplayBase_Union Type { get; set; }

		// Token: 0x170070E7 RID: 28903
		// (get) Token: 0x06016DEF RID: 93679 RVA: 0x003441BA File Offset: 0x003423BA
		// (set) Token: 0x06016DF0 RID: 93680 RVA: 0x003441C2 File Offset: 0x003423C2
		public object Value { get; set; }

		// Token: 0x06016DF1 RID: 93681 RVA: 0x003441CB File Offset: 0x003423CB
		public IArcadeGameplayBase_UnionUnion()
		{
			this.Type = IArcadeGameplayBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016DF2 RID: 93682 RVA: 0x003441E1 File Offset: 0x003423E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016DF3 RID: 93683 RVA: 0x003441F3 File Offset: 0x003423F3
		public IArcadeGameplayBaseT AsIArcadeGameplayBase()
		{
			return this.As<IArcadeGameplayBaseT>();
		}

		// Token: 0x06016DF4 RID: 93684 RVA: 0x003441FB File Offset: 0x003423FB
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayBase(IArcadeGameplayBaseT _iarcadegameplaybase)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayBase,
				Value = _iarcadegameplaybase
			};
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x00344210 File Offset: 0x00342410
		public IArcadeGameplayDropCatchT AsIArcadeGameplayDropCatch()
		{
			return this.As<IArcadeGameplayDropCatchT>();
		}

		// Token: 0x06016DF6 RID: 93686 RVA: 0x00344218 File Offset: 0x00342418
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayDropCatch(IArcadeGameplayDropCatchT _iarcadegameplaydropcatch)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayDropCatch,
				Value = _iarcadegameplaydropcatch
			};
		}

		// Token: 0x06016DF7 RID: 93687 RVA: 0x0034422D File Offset: 0x0034242D
		public IArcadeGameplayTetrisBoardGameT AsIArcadeGameplayTetrisBoardGame()
		{
			return this.As<IArcadeGameplayTetrisBoardGameT>();
		}

		// Token: 0x06016DF8 RID: 93688 RVA: 0x00344235 File Offset: 0x00342435
		public static IArcadeGameplayBase_UnionUnion FromIArcadeGameplayTetrisBoardGame(IArcadeGameplayTetrisBoardGameT _iarcadegameplaytetrisboardgame)
		{
			return new IArcadeGameplayBase_UnionUnion
			{
				Type = IArcadeGameplayBase_Union.IArcadeGameplayTetrisBoardGame,
				Value = _iarcadegameplaytetrisboardgame
			};
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x0034424C File Offset: 0x0034244C
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
