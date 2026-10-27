using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F6C RID: 8044
public class HudUnitPositionUtil
{
	// Token: 0x0600F990 RID: 63888 RVA: 0x003C7CBC File Offset: 0x003C5EBC
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

	// Token: 0x0600F991 RID: 63889 RVA: 0x003C7D2B File Offset: 0x003C5F2B
	public void LogViewPortInfo()
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		BattleUiModel.Instance.UpdateViewPortSize();
	}

	// Token: 0x04007456 RID: 29782
	private FVector2D ScreenPositionRef = new FVector2D();
}
