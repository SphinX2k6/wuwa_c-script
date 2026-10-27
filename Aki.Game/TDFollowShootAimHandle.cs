using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001F3D RID: 7997
public class TDFollowShootAimHandle : HudUnitHandleBase
{
	// Token: 0x0600F70B RID: 63243 RVA: 0x003BB14D File Offset: 0x003B934D
	protected override void OnInitialize()
	{
		base.OnInitialize();
	}

	// Token: 0x0600F70C RID: 63244 RVA: 0x003BB155 File Offset: 0x003B9355
	protected override void OnDestroyed()
	{
		this.DestroyCameraAimUnit();
	}

	// Token: 0x0600F70D RID: 63245 RVA: 0x003BB15D File Offset: 0x003B935D
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.SetTDFollowShootAimVisible, new Action<bool>(this.OnSetAimVisible));
	}

	// Token: 0x0600F70E RID: 63246 RVA: 0x003BB17B File Offset: 0x003B937B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.SetTDFollowShootAimVisible, new Action<bool>(this.OnSetAimVisible));
	}

	// Token: 0x0600F70F RID: 63247 RVA: 0x003BB199 File Offset: 0x003B9399
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

	// Token: 0x0600F710 RID: 63248 RVA: 0x003BB1C3 File Offset: 0x003B93C3
	private void NewCameraAimUnit()
	{
		base.NewHudUnitWithReturn<TDFollowShootAimUnit>(typeof(TDFollowShootAimUnit), "TrapDefenseFollowAim", out this.AimUnit, true, null, false);
		this.AimUnit.SetVisible(true, 0);
	}

	// Token: 0x0600F711 RID: 63249 RVA: 0x003BB1F0 File Offset: 0x003B93F0
	private void DestroyCameraAimUnit()
	{
		if (this.AimUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.AimUnit);
		this.AimUnit = null;
	}

	// Token: 0x04007260 RID: 29280
	[Nullable(2)]
	private TDFollowShootAimUnit AimUnit;
}
