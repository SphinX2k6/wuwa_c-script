using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200142E RID: 5166
public class HudUnitPositionUtil
{
	// Token: 0x0600CDAF RID: 52655 RVA: 0x003D37A8 File Offset: 0x003D19A8
	[NullableContext(1)]
	public bool ProjectWorldToScreen(FVectorDouble worldLocation, Vector2D outScreenPosition)
	{
		if (!UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, worldLocation, ref this.ScreenPositionRef, false))
		{
			return false;
		}
		outScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		BattleUiModel instance = BattleUiModel.Instance;
		outScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset);
		outScreenPosition.Y = -outScreenPosition.Y;
		return true;
	}

	// Token: 0x0600CDB0 RID: 52656 RVA: 0x003D3817 File Offset: 0x003D1A17
	public void LogViewPortInfo()
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		BattleUiModel.Instance.UpdateViewPortSize();
	}

	// Token: 0x04007537 RID: 30007
	private FVector2D ScreenPositionRef = new FVector2D();
}
