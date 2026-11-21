using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02001716 RID: 5910
internal class MotorcycleCountDownDefine : IStaticVariableResetter
{
	// Token: 0x0600E5EB RID: 58859 RVA: 0x00436EB4 File Offset: 0x004350B4
	static MotorcycleCountDownDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleCountDownDefine.CreateStaticDefaultValue), new Action(MotorcycleCountDownDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600E5EC RID: 58860 RVA: 0x00436ED3 File Offset: 0x004350D3
	public static void CreateStaticDefaultValue()
	{
		MotorcycleCountDownDefine.hideBattleUiChildren = new EBattleUiChild[]
		{
			EBattleUiChild.HomeButton,
			EBattleUiChild.TopButton,
			EBattleUiChild.MiniMap,
			EBattleUiChild.MotorcycleControlTop
		};
	}

	// Token: 0x0600E5ED RID: 58861 RVA: 0x00436EEB File Offset: 0x004350EB
	public static void ResetStaticDefaultValue()
	{
		MotorcycleCountDownDefine.hideBattleUiChildren = null;
	}

	// Token: 0x04008363 RID: 33635
	[Nullable(1)]
	public static EBattleUiChild[] hideBattleUiChildren;
}
