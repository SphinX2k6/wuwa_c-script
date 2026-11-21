using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200119C RID: 4508
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleBattleBuff : UiPanelBase
{
	// Token: 0x0600B3E0 RID: 46048 RVA: 0x0035225F File Offset: 0x0035045F
	protected virtual string GetResourceId()
	{
		return "MotorcycleBattleBuff";
	}

	// Token: 0x0600B3E1 RID: 46049 RVA: 0x00352268 File Offset: 0x00350468
	public void CreateHeadStateView(USceneComponent parentComponent, IBuffGateDesc buffInfo)
	{
		string resourceId = this.GetResourceId();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.CreateByPathAsync(resourcePath, (UUIItem)parentComponent, true).Forget();
		this.BuffInfo = buffInfo;
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MotorBuffItemOffset");
		if (intArrayConfig != null && intArrayConfig.Count >= 3)
		{
			this.Offset.Set((double)intArrayConfig[0], (double)intArrayConfig[1], (double)intArrayConfig[2]);
		}
	}

	// Token: 0x0600B3E2 RID: 46050 RVA: 0x003522DC File Offset: 0x003504DC
	public void UpdateBuffInfo(IBuffGateDesc buffInfo)
	{
		this.BuffInfo = buffInfo;
		if (this.ButtItem != null)
		{
			this.ButtItem.SetDesc(this.BuffInfo);
		}
	}

	// Token: 0x0600B3E3 RID: 46051 RVA: 0x003522FE File Offset: 0x003504FE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600B3E4 RID: 46052 RVA: 0x00352338 File Offset: 0x00350538
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleBattleBuff.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleBattleBuff.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3E5 RID: 46053 RVA: 0x0035237B File Offset: 0x0035057B
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600B3E6 RID: 46054 RVA: 0x00352390 File Offset: 0x00350590
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.IsFree = false;
		this.IsUp = false;
		this.CloseTime = (float)Time.Instance.WorldTimeSeconds + 2000f;
		this.RefreshHeadStateRotation();
	}

	// Token: 0x0600B3E7 RID: 46055 RVA: 0x003523F4 File Offset: 0x003505F4
	public void SetUp()
	{
		this.IsUp = true;
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
	}

	// Token: 0x0600B3E8 RID: 46056 RVA: 0x00352434 File Offset: 0x00350634
	protected override UniTask OnBeforeHideAsync()
	{
		MotorcycleBattleBuff.<OnBeforeHideAsync>d__17 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleBattleBuff.<OnBeforeHideAsync>d__17>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3E9 RID: 46057 RVA: 0x00352478 File Offset: 0x00350678
	public void Tick()
	{
		if (this.IsFree)
		{
			return;
		}
		if ((float)Time.Instance.WorldTimeSeconds > this.CloseTime)
		{
			this.SetActive(false);
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		if (entityHandle != null && entityHandle.Valid)
		{
			global::Vector actorLocationProxy = entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			actorLocationProxy.Addition(this.Offset, commonTempVector);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIRelativeLocation(commonTempVector.ToUeVectorOld());
		}
	}

	// Token: 0x0600B3EA RID: 46058 RVA: 0x00352504 File Offset: 0x00350704
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

	// Token: 0x040067DB RID: 26587
	private const int SHOW_DURATION = 2000;

	// Token: 0x040067DC RID: 26588
	[Nullable(2)]
	private IBuffGateDesc BuffInfo;

	// Token: 0x040067DD RID: 26589
	[Nullable(2)]
	private MotorcycleBuffItem ButtItem;

	// Token: 0x040067DE RID: 26590
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040067DF RID: 26591
	public bool IsFree = true;

	// Token: 0x040067E0 RID: 26592
	public bool IsUp;

	// Token: 0x040067E1 RID: 26593
	public float CloseTime;

	// Token: 0x040067E2 RID: 26594
	private readonly global::Vector Offset = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x02007468 RID: 29800
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025E48 RID: 155208
		public const int Self = 0;

		// Token: 0x04025E49 RID: 155209
		public const int ButtItem = 1;
	}
}
