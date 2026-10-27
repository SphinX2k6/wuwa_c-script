using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D0C RID: 7436
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleHeadStateUiBase : UiPanelBase
{
	// Token: 0x0600E0D2 RID: 57554 RVA: 0x0034B809 File Offset: 0x00349A09
	protected override void OnStart()
	{
		if (this.InitHeadHpContext != null)
		{
			this.UpdateByHeadInfo(this.InitHeadHpContext);
			this.InitHeadHpContext = null;
		}
	}

	// Token: 0x0600E0D3 RID: 57555 RVA: 0x0034B82C File Offset: 0x00349A2C
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		if (this.RootItem == null)
		{
			this.InitHeadHpContext = headInfo;
			return;
		}
		this.OnUpdateByHeadInfo(headInfo);
	}

	// Token: 0x0600E0D4 RID: 57556 RVA: 0x0034B845 File Offset: 0x00349A45
	protected virtual void OnUpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
	}

	// Token: 0x0600E0D5 RID: 57557 RVA: 0x0034B847 File Offset: 0x00349A47
	public void InitScaleCurve(UCurveFloat headStateScaleCurve)
	{
		this.HeadStateScaleCurve = headStateScaleCurve;
	}

	// Token: 0x0600E0D6 RID: 57558 RVA: 0x0034B850 File Offset: 0x00349A50
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

	// Token: 0x0600E0D7 RID: 57559 RVA: 0x0034B8A8 File Offset: 0x00349AA8
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

	// Token: 0x0600E0D8 RID: 57560 RVA: 0x0034B918 File Offset: 0x00349B18
	protected float CalculateScaleByDistance(Vector worldLocation)
	{
		double num = Vector.DistSquared(CameraController.Instance.MainModel.CameraLocation, worldLocation);
		if (this.HeadStateScaleCurve == null)
		{
			return 1f;
		}
		return this.HeadStateScaleCurve.GetFloatValue((float)num);
	}

	// Token: 0x040067CC RID: 26572
	[Nullable(2)]
	private FKSC_HeadHpContext InitHeadHpContext;

	// Token: 0x040067CD RID: 26573
	[Nullable(2)]
	protected UCurveFloat HeadStateScaleCurve;
}
