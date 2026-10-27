using System;
using CSharpScript.Game.Module.BattleUi.Views;
using UnrealEngine;

// Token: 0x02002667 RID: 9831
public class QuestViewChildStep : StepWithStatusItem
{
	// Token: 0x06014209 RID: 82441 RVA: 0x00515CAA File Offset: 0x00513EAA
	public QuestViewChildStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
	{
	}

	// Token: 0x0601420A RID: 82442 RVA: 0x00515CB4 File Offset: 0x00513EB4
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUISprite)));
	}

	// Token: 0x0601420B RID: 82443 RVA: 0x00515CD7 File Offset: 0x00513ED7
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x0601420C RID: 82444 RVA: 0x00515CDF File Offset: 0x00513EDF
	protected override void UpdateStepInfo()
	{
		base.UpdateStepInfo();
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(!this.IsDescribeTextVisible || !this.StatusNodeVisible);
	}

	// Token: 0x0601420D RID: 82445 RVA: 0x00515D0C File Offset: 0x00513F0C
	protected override bool CheckCanShowStatusRoot()
	{
		return true;
	}

	// Token: 0x02008CAB RID: 36011
	private class EChildComponent
	{
		// Token: 0x0402DA85 RID: 187013
		public const int StepProcess = 5;
	}
}
