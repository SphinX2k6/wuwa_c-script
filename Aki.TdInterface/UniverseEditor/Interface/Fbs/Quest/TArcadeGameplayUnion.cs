using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B4 RID: 17076
	public class TArcadeGameplayUnion
	{
		// Token: 0x1700792D RID: 31021
		// (get) Token: 0x060194CD RID: 103629 RVA: 0x003A1CB8 File Offset: 0x0039FEB8
		// (set) Token: 0x060194CE RID: 103630 RVA: 0x003A1CC0 File Offset: 0x0039FEC0
		public TArcadeGameplay Type { get; set; }

		// Token: 0x1700792E RID: 31022
		// (get) Token: 0x060194CF RID: 103631 RVA: 0x003A1CC9 File Offset: 0x0039FEC9
		// (set) Token: 0x060194D0 RID: 103632 RVA: 0x003A1CD1 File Offset: 0x0039FED1
		public object Value { get; set; }

		// Token: 0x060194D1 RID: 103633 RVA: 0x003A1CDA File Offset: 0x0039FEDA
		public TArcadeGameplayUnion()
		{
			this.Type = TArcadeGameplay.NONE;
			this.Value = null;
		}

		// Token: 0x060194D2 RID: 103634 RVA: 0x003A1CF0 File Offset: 0x0039FEF0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060194D3 RID: 103635 RVA: 0x003A1D02 File Offset: 0x0039FF02
		public IArcadeGameplayDropCatchT AsIArcadeGameplayDropCatch()
		{
			return this.As<IArcadeGameplayDropCatchT>();
		}

		// Token: 0x060194D4 RID: 103636 RVA: 0x003A1D0A File Offset: 0x0039FF0A
		public static TArcadeGameplayUnion FromIArcadeGameplayDropCatch(IArcadeGameplayDropCatchT _iarcadegameplaydropcatch)
		{
			return new TArcadeGameplayUnion
			{
				Type = TArcadeGameplay.IArcadeGameplayDropCatch,
				Value = _iarcadegameplaydropcatch
			};
		}

		// Token: 0x060194D5 RID: 103637 RVA: 0x003A1D1F File Offset: 0x0039FF1F
		public IArcadeGameplayTetrisBoardGameT AsIArcadeGameplayTetrisBoardGame()
		{
			return this.As<IArcadeGameplayTetrisBoardGameT>();
		}

		// Token: 0x060194D6 RID: 103638 RVA: 0x003A1D27 File Offset: 0x0039FF27
		public static TArcadeGameplayUnion FromIArcadeGameplayTetrisBoardGame(IArcadeGameplayTetrisBoardGameT _iarcadegameplaytetrisboardgame)
		{
			return new TArcadeGameplayUnion
			{
				Type = TArcadeGameplay.IArcadeGameplayTetrisBoardGame,
				Value = _iarcadegameplaytetrisboardgame
			};
		}

		// Token: 0x060194D7 RID: 103639 RVA: 0x003A1D3C File Offset: 0x0039FF3C
		public static int Pack(FlatBufferBuilder builder, TArcadeGameplayUnion _o)
		{
			TArcadeGameplay type = _o.Type;
			if (type == TArcadeGameplay.IArcadeGameplayDropCatch)
			{
				return IArcadeGameplayDropCatch.Pack(builder, _o.AsIArcadeGameplayDropCatch()).Value;
			}
			if (type != TArcadeGameplay.IArcadeGameplayTetrisBoardGame)
			{
				return 0;
			}
			return IArcadeGameplayTetrisBoardGame.Pack(builder, _o.AsIArcadeGameplayTetrisBoardGame()).Value;
		}
	}
}
