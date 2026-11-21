using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020013FF RID: 5119
public class TDFollowShootAimHandle : HudUnitHandleBase
{
	// Token: 0x0600CB2A RID: 52010 RVA: 0x003C6C39 File Offset: 0x003C4E39
	protected override void OnInitialize()
	{
		base.OnInitialize();
	}

	// Token: 0x0600CB2B RID: 52011 RVA: 0x003C6C41 File Offset: 0x003C4E41
	protected override void OnDestroyed()
	{
		this.DestroyCameraAimUnit();
	}

	// Token: 0x0600CB2C RID: 52012 RVA: 0x003C6C49 File Offset: 0x003C4E49
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.SetTDFollowShootAimVisible, new Action<bool>(this.OnSetAimVisible));
	}

	// Token: 0x0600CB2D RID: 52013 RVA: 0x003C6C67 File Offset: 0x003C4E67
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.SetTDFollowShootAimVisible, new Action<bool>(this.OnSetAimVisible));
	}

	// Token: 0x0600CB2E RID: 52014 RVA: 0x003C6C85 File Offset: 0x003C4E85
	private void OnSetAimVisible(bool bVisible)
	{
		if (bVisible && this.AimUnit == null)
		{
			this.NewCameraAimUnit();
			return;
		}
		if (this.AimUnit == null)
		{
			return;
		}
		this.AimUnit.SetVisible(bVisible, 0);
	}

	// Token: 0x0600CB2F RID: 52015 RVA: 0x003C6CAF File Offset: 0x003C4EAF
	private void NewCameraAimUnit()
	{
		base.NewHudUnitWithReturn<TDFollowShootAimUnit>(typeof(TDFollowShootAimUnit), "TrapDefenseFollowAim", out this.AimUnit, true, null, false);
		this.AimUnit.SetVisible(true, 0);
	}

	// Token: 0x0600CB30 RID: 52016 RVA: 0x003C6CDC File Offset: 0x003C4EDC
	private void DestroyCameraAimUnit()
	{
		if (this.AimUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.AimUnit);
		this.AimUnit = null;
	}

	// Token: 0x04007341 RID: 29505
	[Nullable(2)]
	private TDFollowShootAimUnit AimUnit;
}
