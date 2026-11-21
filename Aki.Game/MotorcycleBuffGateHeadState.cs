using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200119B RID: 4507
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleBuffGateHeadState : UiPanelBase
{
	// Token: 0x0600B3D7 RID: 46039 RVA: 0x003520C7 File Offset: 0x003502C7
	protected virtual string GetResourceId()
	{
		return "UiItem_WorldPosBuff2";
	}

	// Token: 0x0600B3D8 RID: 46040 RVA: 0x003520D0 File Offset: 0x003502D0
	public void CreateHeadStateView(USceneComponent parentComponent, [Nullable(2)] IBuffGateDesc buffGateInfo = null)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.CreateThenShowByPathAsync(resourcePath, (UUIItem)parentComponent, true).Forget();
		this.BuffGateInfo = buffGateInfo;
	}

	// Token: 0x0600B3D9 RID: 46041 RVA: 0x0035210A File Offset: 0x0035030A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600B3DA RID: 46042 RVA: 0x00352144 File Offset: 0x00350344
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleBuffGateHeadState.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleBuffGateHeadState.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3DB RID: 46043 RVA: 0x00352187 File Offset: 0x00350387
	public void UpdateByHeadInfo(FKSC_HeadHpContext headInfo)
	{
		this.UpdateHeadStateLocation(headInfo.Location);
	}

	// Token: 0x0600B3DC RID: 46044 RVA: 0x00352198 File Offset: 0x00350398
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

	// Token: 0x0600B3DD RID: 46045 RVA: 0x003521E4 File Offset: 0x003503E4
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

	// Token: 0x040067D9 RID: 26585
	[Nullable(2)]
	private IBuffGateDesc BuffGateInfo;

	// Token: 0x040067DA RID: 26586
	private FVectorDouble? Location;

	// Token: 0x02007466 RID: 29798
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E42 RID: 155202
		public const int TextureQuality = 0;

		// Token: 0x04025E43 RID: 155203
		public const int TextDialogue = 1;
	}
}
