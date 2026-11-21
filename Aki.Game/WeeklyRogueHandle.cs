using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001401 RID: 5121
public class WeeklyRogueHandle : HudUnitHandleBase
{
	// Token: 0x0600CB3C RID: 52028 RVA: 0x003C6F8D File Offset: 0x003C518D
	protected override void OnDestroyed()
	{
		this.DestroyWeeklyRogueUnit();
	}

	// Token: 0x0600CB3D RID: 52029 RVA: 0x003C6F95 File Offset: 0x003C5195
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.WeeklyRogueBurstEnableChange, new Action<bool>(this.OnWeeklyRogueBurstEnableChange));
	}

	// Token: 0x0600CB3E RID: 52030 RVA: 0x003C6FB3 File Offset: 0x003C51B3
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.WeeklyRogueBurstEnableChange, new Action<bool>(this.OnWeeklyRogueBurstEnableChange));
	}

	// Token: 0x0600CB3F RID: 52031 RVA: 0x003C6FD1 File Offset: 0x003C51D1
	private void OnWeeklyRogueBurstEnableChange(bool enable)
	{
		if (enable && this.WeeklyRogueUnit == null)
		{
			this.NewWeeklyRogueUnit();
			return;
		}
		if (this.WeeklyRogueUnit == null)
		{
			return;
		}
		this.WeeklyRogueUnit.SetVisible(enable, 0);
	}

	// Token: 0x0600CB40 RID: 52032 RVA: 0x003C6FFC File Offset: 0x003C51FC
	private void NewWeeklyRogueUnit()
	{
		base.NewHudUnitWithReturn<WeeklyRogueUnit>(typeof(WeeklyRogueUnit), "UiView_WeeklyRogueLink", out this.WeeklyRogueUnit, true, delegate(WeeklyRogueUnit _)
		{
		}, false);
		this.WeeklyRogueUnit.SetVisible(true, 0);
	}

	// Token: 0x0600CB41 RID: 52033 RVA: 0x003C7052 File Offset: 0x003C5252
	private void DestroyWeeklyRogueUnit()
	{
		if (this.WeeklyRogueUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.WeeklyRogueUnit);
		this.WeeklyRogueUnit = null;
	}

	// Token: 0x04007346 RID: 29510
	[Nullable(2)]
	private WeeklyRogueUnit WeeklyRogueUnit;
}
