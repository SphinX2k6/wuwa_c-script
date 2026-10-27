using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001370 RID: 4976
public class ActivityMotorGiftData : ActivityBaseData
{
	// Token: 0x06008AD7 RID: 35543 RVA: 0x001DA6A0 File Offset: 0x001D88A0
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06008AD8 RID: 35544 RVA: 0x001DA6CE File Offset: 0x001D88CE
	public int GetMotorPreviewId()
	{
		return 1007;
	}

	// Token: 0x06008AD9 RID: 35545 RVA: 0x001DA6D5 File Offset: 0x001D88D5
	public MotorGeneralPreview? GetMotorPreviewConfig()
	{
		return MotorDiyConfig.Instance.GetMotorGeneralPreviewConfig(1007);
	}

	// Token: 0x06008ADA RID: 35546 RVA: 0x001DA6E8 File Offset: 0x001D88E8
	public void OpenMotorPreviewView()
	{
		if (this.GetMotorPreviewConfig() == null)
		{
			return;
		}
		MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(1007);
	}

	// Token: 0x06008ADB RID: 35547 RVA: 0x001DA718 File Offset: 0x001D8918
	public bool IsRewardObtained()
	{
		MotorGeneralPreview? motorPreviewConfig = this.GetMotorPreviewConfig();
		return motorPreviewConfig != null && motorPreviewConfig.Value.Frame > 0 && MotorcycleDiyModel.Instance.HasFrame(motorPreviewConfig.Value.Frame);
	}

	// Token: 0x06008ADC RID: 35548 RVA: 0x001DA762 File Offset: 0x001D8962
	protected override bool GetExDataFinishShowState()
	{
		return this.IsRewardObtained();
	}

	// Token: 0x06008ADD RID: 35549 RVA: 0x001DA76A File Offset: 0x001D896A
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x04003DC5 RID: 15813
	private const int MotorGiftMotorPreviewId = 1007;
}
