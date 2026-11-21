using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020013EB RID: 5099
[NullableContext(2)]
[Nullable(0)]
public class CameraAimHandle : HudUnitHandleBase
{
	// Token: 0x0600C9D9 RID: 51673 RVA: 0x003C0584 File Offset: 0x003BE784
	protected override void OnDestroyed()
	{
		this.ResId = null;
		this.DestroyCameraAimUnit();
	}

	// Token: 0x0600C9DA RID: 51674 RVA: 0x003C0593 File Offset: 0x003BE793
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, new Action<bool, ECameraAimVisibleReason, string, string>(this.OnSetCameraAimVisible));
	}

	// Token: 0x0600C9DB RID: 51675 RVA: 0x003C05B1 File Offset: 0x003BE7B1
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, new Action<bool, ECameraAimVisibleReason, string, string>(this.OnSetCameraAimVisible));
	}

	// Token: 0x0600C9DC RID: 51676 RVA: 0x003C05D0 File Offset: 0x003BE7D0
	private void OnSetCameraAimVisible(bool bVisible, ECameraAimVisibleReason reason, string resId = null, string cameraName = null)
	{
		if (cameraName != null && cameraName != "MainCamera")
		{
			return;
		}
		if (bVisible && reason == ECameraAimVisibleReason.Default)
		{
			if (this.ResId != resId)
			{
				this.ResId = resId;
			}
			if (this.CameraAimUnit == null)
			{
				this.NewCameraAimUnit();
				return;
			}
			if (this.CameraAimUnit.ResourceId != this.ResId)
			{
				this.DestroyCameraAimUnit();
				this.NewCameraAimUnit();
				return;
			}
		}
		if (this.CameraAimUnit == null)
		{
			return;
		}
		this.CameraAimUnit.SetVisible(bVisible, (int)reason);
	}

	// Token: 0x0600C9DD RID: 51677 RVA: 0x003C0658 File Offset: 0x003BE858
	private void NewCameraAimUnit()
	{
		if (this.ResId == null || this.ResId.Length == 0)
		{
			return;
		}
		base.NewHudUnitWithReturn<CameraAimUnit>(typeof(CameraAimUnit), this.ResId, out this.CameraAimUnit, true, delegate(CameraAimUnit _)
		{
			string resId = this.ResId;
			CameraAimUnit cameraAimUnit = this.CameraAimUnit;
			if (resId != ((cameraAimUnit != null) ? cameraAimUnit.ResourceId : null))
			{
				this.DestroyCameraAimUnit();
			}
		}, false);
		this.CameraAimUnit.SetVisible(true, 0);
	}

	// Token: 0x0600C9DE RID: 51678 RVA: 0x003C06B2 File Offset: 0x003BE8B2
	private void DestroyCameraAimUnit()
	{
		if (this.CameraAimUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.CameraAimUnit);
		this.CameraAimUnit = null;
	}

	// Token: 0x04007295 RID: 29333
	private CameraAimUnit CameraAimUnit;

	// Token: 0x04007296 RID: 29334
	private string ResId;
}
