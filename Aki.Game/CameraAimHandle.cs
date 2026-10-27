using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001F29 RID: 7977
[NullableContext(2)]
[Nullable(0)]
public class CameraAimHandle : HudUnitHandleBase
{
	// Token: 0x0600F5BA RID: 62906 RVA: 0x003B4A98 File Offset: 0x003B2C98
	protected override void OnDestroyed()
	{
		this.ResId = null;
		this.DestroyCameraAimUnit();
	}

	// Token: 0x0600F5BB RID: 62907 RVA: 0x003B4AA7 File Offset: 0x003B2CA7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, new Action<bool, ECameraAimVisibleReason, string, string>(this.OnSetCameraAimVisible));
	}

	// Token: 0x0600F5BC RID: 62908 RVA: 0x003B4AC5 File Offset: 0x003B2CC5
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, new Action<bool, ECameraAimVisibleReason, string, string>(this.OnSetCameraAimVisible));
	}

	// Token: 0x0600F5BD RID: 62909 RVA: 0x003B4AE4 File Offset: 0x003B2CE4
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

	// Token: 0x0600F5BE RID: 62910 RVA: 0x003B4B6C File Offset: 0x003B2D6C
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

	// Token: 0x0600F5BF RID: 62911 RVA: 0x003B4BC6 File Offset: 0x003B2DC6
	private void DestroyCameraAimUnit()
	{
		if (this.CameraAimUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.CameraAimUnit);
		this.CameraAimUnit = null;
	}

	// Token: 0x040071B4 RID: 29108
	private CameraAimUnit CameraAimUnit;

	// Token: 0x040071B5 RID: 29109
	private string ResId;
}
