using System;
using CSharpScript.Game.Module.BattleUi.Views;
using UnrealEngine;

// Token: 0x02001B52 RID: 6994
public class QuestViewChildStep : StepWithStatusItem
{
	// Token: 0x060116EB RID: 71403 RVA: 0x00524962 File Offset: 0x00522B62
	public QuestViewChildStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
	{
	}

	// Token: 0x060116EC RID: 71404 RVA: 0x0052496C File Offset: 0x00522B6C
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUISprite)));
	}

	// Token: 0x060116ED RID: 71405 RVA: 0x0052498F File Offset: 0x00522B8F
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x060116EE RID: 71406 RVA: 0x00524997 File Offset: 0x00522B97
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

	// Token: 0x060116EF RID: 71407 RVA: 0x005249C4 File Offset: 0x00522BC4
	protected override bool CheckCanShowStatusRoot()
	{
		return true;
	}

	// Token: 0x02007E34 RID: 32308
	private class EChildComponent
	{
		// Token: 0x04028D9C RID: 167324
		public const int StepProcess = 5;
	}
}
