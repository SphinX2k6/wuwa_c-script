using System;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

// Token: 0x02002021 RID: 8225
public class SpecialItemLogicEntityCamera : SpecialItemLogicBase
{
	// Token: 0x060101F3 RID: 66035 RVA: 0x003ECEB5 File Offset: 0x003EB0B5
	public SpecialItemLogicEntityCamera(int configId) : base(configId)
	{
	}

	// Token: 0x060101F4 RID: 66036 RVA: 0x003ECEBE File Offset: 0x003EB0BE
	public override bool CheckUseCondition()
	{
		return true;
	}

	// Token: 0x060101F5 RID: 66037 RVA: 0x003ECEC1 File Offset: 0x003EB0C1
	public override void OnUse()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.PhotographView) && PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.EntityCamera))
		{
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.PhotographView);
		}
	}
}
