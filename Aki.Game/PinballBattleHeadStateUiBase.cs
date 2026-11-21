using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011CE RID: 4558
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleHeadStateUiBase : UiPanelBase
{
	// Token: 0x0600B4EF RID: 46319 RVA: 0x00357239 File Offset: 0x00355439
	protected override void OnStart()
	{
		if (this.InitHeadHpContext != null)
		{
			this.UpdateByHeadInfo(this.InitHeadHpContext);
			this.InitHeadHpContext = null;
		}
	}

	// Token: 0x0600B4F0 RID: 46320 RVA: 0x0035725C File Offset: 0x0035545C
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		if (this.RootItem == null)
		{
			this.InitHeadHpContext = headInfo;
			return;
		}
		this.OnUpdateByHeadInfo(headInfo);
	}

	// Token: 0x0600B4F1 RID: 46321 RVA: 0x00357275 File Offset: 0x00355475
	protected virtual void OnUpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
	}

	// Token: 0x0600B4F2 RID: 46322 RVA: 0x00357277 File Offset: 0x00355477
	public void InitScaleCurve(UCurveFloat headStateScaleCurve)
	{
		this.HeadStateScaleCurve = headStateScaleCurve;
	}

	// Token: 0x0600B4F3 RID: 46323 RVA: 0x00357280 File Offset: 0x00355480
	protected void UpdateHeadStateLocation(FVectorDouble location)
	{
		Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		commonTempVector.FromUeVector(location);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIRelativeLocation(commonTempVector.ToUeVectorOld());
		}
		float num = this.CalculateScaleByDistance(commonTempVector);
		UUIItem rootItem2 = this.RootItem;
		if (rootItem2 == null)
		{
			return;
		}
		rootItem2.SetUIItemScale(new FVector(num, num, num));
	}

	// Token: 0x0600B4F4 RID: 46324 RVA: 0x003572D8 File Offset: 0x003554D8
	protected void UpdateHeadStateRotation()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
		commonTempRotator.Yaw = cameraRotator.Yaw + 90f;
		commonTempRotator.Roll = cameraRotator.Pitch - 90f;
		commonTempRotator.Pitch = 0f;
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		FRotator frotator = commonTempRotator.ToUeRotator();
		rootItem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600B4F5 RID: 46325 RVA: 0x00357348 File Offset: 0x00355548
	protected float CalculateScaleByDistance(Vector worldLocation)
	{
		double num = Vector.DistSquared(CameraController.Instance.MainModel.CameraLocation, worldLocation);
		if (this.HeadStateScaleCurve == null)
		{
			return 1f;
		}
		return this.HeadStateScaleCurve.GetFloatValue((float)num);
	}

	// Token: 0x040068AB RID: 26795
	[Nullable(2)]
	private FKSC_HeadHpContext InitHeadHpContext;

	// Token: 0x040068AC RID: 26796
	[Nullable(2)]
	protected UCurveFloat HeadStateScaleCurve;
}
