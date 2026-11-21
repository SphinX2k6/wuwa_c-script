using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000824 RID: 2084
public class ActivityMotorGiftData : ActivityBaseData
{
	// Token: 0x06005E72 RID: 24178 RVA: 0x001E34FC File Offset: 0x001E16FC
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06005E73 RID: 24179 RVA: 0x001E352A File Offset: 0x001E172A
	public int GetMotorPreviewId()
	{
		return 1007;
	}

	// Token: 0x06005E74 RID: 24180 RVA: 0x001E3531 File Offset: 0x001E1731
	public MotorGeneralPreview? GetMotorPreviewConfig()
	{
		return MotorDiyConfig.Instance.GetMotorGeneralPreviewConfig(1007);
	}

	// Token: 0x06005E75 RID: 24181 RVA: 0x001E3544 File Offset: 0x001E1744
	public void OpenMotorPreviewView()
	{
		if (this.GetMotorPreviewConfig() == null)
		{
			return;
		}
		MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(1007);
	}

	// Token: 0x06005E76 RID: 24182 RVA: 0x001E3574 File Offset: 0x001E1774
	public bool IsRewardObtained()
	{
		MotorGeneralPreview? motorPreviewConfig = this.GetMotorPreviewConfig();
		return motorPreviewConfig != null && motorPreviewConfig.Value.Frame > 0 && MotorcycleDiyModel.Instance.HasFrame(motorPreviewConfig.Value.Frame);
	}

	// Token: 0x06005E77 RID: 24183 RVA: 0x001E35BE File Offset: 0x001E17BE
	protected override bool GetExDataFinishShowState()
	{
		return this.IsRewardObtained();
	}

	// Token: 0x06005E78 RID: 24184 RVA: 0x001E35C6 File Offset: 0x001E17C6
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x04003E5D RID: 15965
	private const int MotorGiftMotorPreviewId = 1007;
}
