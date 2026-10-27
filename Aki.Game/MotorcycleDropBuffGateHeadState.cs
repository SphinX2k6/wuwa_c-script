using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CDC RID: 7388
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDropBuffGateHeadState : UiPanelBase
{
	// Token: 0x0600DFD3 RID: 57299 RVA: 0x00346CD2 File Offset: 0x00344ED2
	protected virtual string GetResourceId()
	{
		return "UiItem_WorldPosBuff1";
	}

	// Token: 0x0600DFD4 RID: 57300 RVA: 0x00346CDC File Offset: 0x00344EDC
	[NullableContext(2)]
	public void CreateHeadStateView([Nullable(1)] USceneComponent parentComponent, IBuffGateDesc buffGateInfo = null, UCurveFloat dropHeadStateScaleCurve = null)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.CreateThenShowByPathAsync(resourcePath, (UUIItem)parentComponent, true).Forget();
		this.BuffGateInfo = buffGateInfo;
		this.DropHeadStateScaleCurve = dropHeadStateScaleCurve;
	}

	// Token: 0x0600DFD5 RID: 57301 RVA: 0x00346D20 File Offset: 0x00344F20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600DFD6 RID: 57302 RVA: 0x00346D7C File Offset: 0x00344F7C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDropBuffGateHeadState.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDropBuffGateHeadState.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFD7 RID: 57303 RVA: 0x00346DBF File Offset: 0x00344FBF
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
	}

	// Token: 0x0600DFD8 RID: 57304 RVA: 0x00346DD0 File Offset: 0x00344FD0
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

	// Token: 0x0600DFD9 RID: 57305 RVA: 0x00346E38 File Offset: 0x00345038
	private float CalculateScaleByDistance(Vector worldLocation)
	{
		double num = Vector.DistSquared(CameraController.Instance.MainModel.CameraLocation, worldLocation);
		if (this.DropHeadStateScaleCurve == null)
		{
			return 1f;
		}
		return this.DropHeadStateScaleCurve.GetFloatValue((float)num);
	}

	// Token: 0x0600DFDA RID: 57306 RVA: 0x00346E78 File Offset: 0x00345078
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

	// Token: 0x04006704 RID: 26372
	[Nullable(2)]
	private IBuffGateDesc BuffGateInfo;

	// Token: 0x04006705 RID: 26373
	private FVectorDouble? Location;

	// Token: 0x04006706 RID: 26374
	[Nullable(2)]
	private UCurveFloat DropHeadStateScaleCurve;

	// Token: 0x020082E3 RID: 33507
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AB2E RID: 174894
		public const int TextureQuality = 0;

		// Token: 0x0402AB2F RID: 174895
		public const int TextIcon = 1;

		// Token: 0x0402AB30 RID: 174896
		public const int TextDialogue = 2;
	}
}
