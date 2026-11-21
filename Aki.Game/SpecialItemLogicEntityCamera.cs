using System;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

// Token: 0x020014F4 RID: 5364
public class SpecialItemLogicEntityCamera : SpecialItemLogicBase
{
	// Token: 0x0600D65B RID: 54875 RVA: 0x003F94AD File Offset: 0x003F76AD
	public SpecialItemLogicEntityCamera(int configId) : base(configId)
	{
	}

	// Token: 0x0600D65C RID: 54876 RVA: 0x003F94B6 File Offset: 0x003F76B6
	public override bool CheckUseCondition()
	{
		return true;
	}

	// Token: 0x0600D65D RID: 54877 RVA: 0x003F94B9 File Offset: 0x003F76B9
	public override void OnUse()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.PhotographView) && PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.EntityCamera))
		{
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.PhotographView);
		}
	}
}
