using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004710 RID: 18192
	public class TArcadeGameplayUnion
	{
		// Token: 0x17007F5E RID: 32606
		// (get) Token: 0x0601AC39 RID: 109625 RVA: 0x003CD390 File Offset: 0x003CB590
		// (set) Token: 0x0601AC3A RID: 109626 RVA: 0x003CD398 File Offset: 0x003CB598
		public TArcadeGameplay Type { get; set; }

		// Token: 0x17007F5F RID: 32607
		// (get) Token: 0x0601AC3B RID: 109627 RVA: 0x003CD3A1 File Offset: 0x003CB5A1
		// (set) Token: 0x0601AC3C RID: 109628 RVA: 0x003CD3A9 File Offset: 0x003CB5A9
		public object Value { get; set; }

		// Token: 0x0601AC3D RID: 109629 RVA: 0x003CD3B2 File Offset: 0x003CB5B2
		public TArcadeGameplayUnion()
		{
			this.Type = TArcadeGameplay.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC3E RID: 109630 RVA: 0x003CD3C8 File Offset: 0x003CB5C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC3F RID: 109631 RVA: 0x003CD3DA File Offset: 0x003CB5DA
		public IArcadeGameplayDropCatchT AsIArcadeGameplayDropCatch()
		{
			return this.As<IArcadeGameplayDropCatchT>();
		}

		// Token: 0x0601AC40 RID: 109632 RVA: 0x003CD3E2 File Offset: 0x003CB5E2
		public static TArcadeGameplayUnion FromIArcadeGameplayDropCatch(IArcadeGameplayDropCatchT _iarcadegameplaydropcatch)
		{
			return new TArcadeGameplayUnion
			{
				Type = TArcadeGameplay.IArcadeGameplayDropCatch,
				Value = _iarcadegameplaydropcatch
			};
		}

		// Token: 0x0601AC41 RID: 109633 RVA: 0x003CD3F7 File Offset: 0x003CB5F7
		public IArcadeGameplayTetrisBoardGameT AsIArcadeGameplayTetrisBoardGame()
		{
			return this.As<IArcadeGameplayTetrisBoardGameT>();
		}

		// Token: 0x0601AC42 RID: 109634 RVA: 0x003CD3FF File Offset: 0x003CB5FF
		public static TArcadeGameplayUnion FromIArcadeGameplayTetrisBoardGame(IArcadeGameplayTetrisBoardGameT _iarcadegameplaytetrisboardgame)
		{
			return new TArcadeGameplayUnion
			{
				Type = TArcadeGameplay.IArcadeGameplayTetrisBoardGame,
				Value = _iarcadegameplaytetrisboardgame
			};
		}

		// Token: 0x0601AC43 RID: 109635 RVA: 0x003CD414 File Offset: 0x003CB614
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
