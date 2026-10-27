using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200467E RID: 18046
	public static class InputDistributeSetupDefine
	{
		// Token: 0x04019540 RID: 103744
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Type[] inputDistributeSetups = new Type[]
		{
			typeof(BlockInputDistribute),
			typeof(ReconnectInputDistribute),
			typeof(PlotInputDistribute),
			typeof(GuideInputDistributeSetup),
			typeof(CreateCharacterInputDistribute),
			typeof(LoginInputDistribute),
			typeof(PhotoCameraInputDistribute),
			typeof(UiProhibitFightInputDistribute),
			typeof(ExploreInputDistribute),
			typeof(RoleMorphInputDistribute),
			typeof(LevelEventInputDistribute),
			typeof(InteractionInputDistribute),
			typeof(AutoPilotInputDistribute),
			typeof(MusicalInstrumentInputDistribute),
			typeof(FightInputDistribute),
			typeof(UiInputDistribute)
		};
	}
}
