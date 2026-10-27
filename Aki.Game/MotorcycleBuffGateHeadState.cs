using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CD9 RID: 7385
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleBuffGateHeadState : UiPanelBase
{
	// Token: 0x0600DFBA RID: 57274 RVA: 0x0034669F File Offset: 0x0034489F
	protected virtual string GetResourceId()
	{
		return "UiItem_WorldPosBuff2";
	}

	// Token: 0x0600DFBB RID: 57275 RVA: 0x003466A8 File Offset: 0x003448A8
	public void CreateHeadStateView(USceneComponent parentComponent, [Nullable(2)] IBuffGateDesc buffGateInfo = null)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.CreateThenShowByPathAsync(resourcePath, (UUIItem)parentComponent, true).Forget();
		this.BuffGateInfo = buffGateInfo;
	}

	// Token: 0x0600DFBC RID: 57276 RVA: 0x003466E2 File Offset: 0x003448E2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600DFBD RID: 57277 RVA: 0x0034671C File Offset: 0x0034491C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleBuffGateHeadState.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleBuffGateHeadState.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFBE RID: 57278 RVA: 0x0034675F File Offset: 0x0034495F
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
	}

	// Token: 0x0600DFBF RID: 57279 RVA: 0x00346770 File Offset: 0x00344970
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
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIRelativeLocation(commonTempVector.ToUeVectorOld());
	}

	// Token: 0x0600DFC0 RID: 57280 RVA: 0x003467BC File Offset: 0x003449BC
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

	// Token: 0x040066FA RID: 26362
	[Nullable(2)]
	private IBuffGateDesc BuffGateInfo;

	// Token: 0x040066FB RID: 26363
	private FVectorDouble? Location;

	// Token: 0x020082DD RID: 33501
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AB1A RID: 174874
		public const int TextureQuality = 0;

		// Token: 0x0402AB1B RID: 174875
		public const int TextDialogue = 1;
	}
}
