using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02002232 RID: 8754
internal class MotorcycleCountDownDefine : IStaticVariableResetter
{
	// Token: 0x06011155 RID: 69973 RVA: 0x0042A310 File Offset: 0x00428510
	static MotorcycleCountDownDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleCountDownDefine.CreateStaticDefaultValue), new Action(MotorcycleCountDownDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06011156 RID: 69974 RVA: 0x0042A32F File Offset: 0x0042852F
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

	// Token: 0x06011157 RID: 69975 RVA: 0x0042A347 File Offset: 0x00428547
	public static void ResetStaticDefaultValue()
	{
		MotorcycleCountDownDefine.hideBattleUiChildren = null;
	}

	// Token: 0x04008225 RID: 33317
	[Nullable(1)]
	public static EBattleUiChild[] hideBattleUiChildren;
}
