using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200119E RID: 4510
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDropBuffGateHeadState : UiPanelBase
{
	// Token: 0x0600B3F0 RID: 46064 RVA: 0x003526FA File Offset: 0x003508FA
	protected virtual string GetResourceId()
	{
		return "UiItem_WorldPosBuff1";
	}

	// Token: 0x0600B3F1 RID: 46065 RVA: 0x00352704 File Offset: 0x00350904
	[NullableContext(2)]
	public void CreateHeadStateView([Nullable(1)] USceneComponent parentComponent, IBuffGateDesc buffGateInfo = null, UCurveFloat dropHeadStateScaleCurve = null)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.CreateThenShowByPathAsync(resourcePath, (UUIItem)parentComponent, true).Forget();
		this.BuffGateInfo = buffGateInfo;
		this.DropHeadStateScaleCurve = dropHeadStateScaleCurve;
	}

	// Token: 0x0600B3F2 RID: 46066 RVA: 0x00352748 File Offset: 0x00350948
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600B3F3 RID: 46067 RVA: 0x003527A4 File Offset: 0x003509A4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDropBuffGateHeadState.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDropBuffGateHeadState.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3F4 RID: 46068 RVA: 0x003527E7 File Offset: 0x003509E7
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
	}

	// Token: 0x0600B3F5 RID: 46069 RVA: 0x003527F8 File Offset: 0x003509F8
	private void UpdateHeadStateLocation(FVectorDouble location)
	{
		if (this.RootItem == null)
		{
			this.Location = new FVectorDouble?(location);
			return;
		}
		Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		commonTempVector.FromUeVector(location);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIRelativeLocation(commonTempVector.ToUeVectorOld());
		}
		float num = this.CalculateScaleByDistance(commonTempVector);
		this.RootItem.SetUIItemScale(new FVector(num, num, num));
	}

	// Token: 0x0600B3F6 RID: 46070 RVA: 0x00352860 File Offset: 0x00350A60
	private float CalculateScaleByDistance(Vector worldLocation)
	{
		double num = Vector.DistSquared(CameraController.Instance.MainModel.CameraLocation, worldLocation);
		if (this.DropHeadStateScaleCurve == null)
		{
			return 1f;
		}
		return this.DropHeadStateScaleCurve.GetFloatValue((float)num);
	}

	// Token: 0x0600B3F7 RID: 46071 RVA: 0x003528A0 File Offset: 0x00350AA0
	protected void RefreshHeadStateRotation()
	{
		Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
		Rotator commonTempRotator = MathUtils.Instance.CommonTempRotator;
		commonTempRotator.Yaw = cameraRotator.Yaw + 90f;
		commonTempRotator.Roll = cameraRotator.Pitch - 90f;
		commonTempRotator.Pitch = 0f;
		UUIItem rootItem = this.RootItem;
		FRotator frotator = commonTempRotator.ToUeRotator();
		rootItem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x040067E3 RID: 26595
	[Nullable(2)]
	private IBuffGateDesc BuffGateInfo;

	// Token: 0x040067E4 RID: 26596
	private FVectorDouble? Location;

	// Token: 0x040067E5 RID: 26597
	[Nullable(2)]
	private UCurveFloat DropHeadStateScaleCurve;

	// Token: 0x0200746C RID: 29804
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E56 RID: 155222
		public const int TextureQuality = 0;

		// Token: 0x04025E57 RID: 155223
		public const int TextIcon = 1;

		// Token: 0x04025E58 RID: 155224
		public const int TextDialogue = 2;
	}
}
