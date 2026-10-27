using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001F3F RID: 7999
public class WeeklyRogueHandle : HudUnitHandleBase
{
	// Token: 0x0600F71D RID: 63261 RVA: 0x003BB4A1 File Offset: 0x003B96A1
	protected override void OnDestroyed()
	{
		this.DestroyWeeklyRogueUnit();
	}

	// Token: 0x0600F71E RID: 63262 RVA: 0x003BB4A9 File Offset: 0x003B96A9
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.WeeklyRogueBurstEnableChange, new Action<bool>(this.OnWeeklyRogueBurstEnableChange));
	}

	// Token: 0x0600F71F RID: 63263 RVA: 0x003BB4C7 File Offset: 0x003B96C7
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.WeeklyRogueBurstEnableChange, new Action<bool>(this.OnWeeklyRogueBurstEnableChange));
	}

	// Token: 0x0600F720 RID: 63264 RVA: 0x003BB4E5 File Offset: 0x003B96E5
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

	// Token: 0x0600F721 RID: 63265 RVA: 0x003BB510 File Offset: 0x003B9710
	private void NewWeeklyRogueUnit()
	{
		base.NewHudUnitWithReturn<WeeklyRogueUnit>(typeof(WeeklyRogueUnit), "UiView_WeeklyRogueLink", out this.WeeklyRogueUnit, true, delegate(WeeklyRogueUnit _)
		{
		}, false);
		this.WeeklyRogueUnit.SetVisible(true, 0);
	}

	// Token: 0x0600F722 RID: 63266 RVA: 0x003BB566 File Offset: 0x003B9766
	private void DestroyWeeklyRogueUnit()
	{
		if (this.WeeklyRogueUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.WeeklyRogueUnit);
		this.WeeklyRogueUnit = null;
	}

	// Token: 0x04007265 RID: 29285
	[Nullable(2)]
	private WeeklyRogueUnit WeeklyRogueUnit;
}
