using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CDA RID: 7386
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleBattleBuff : UiPanelBase
{
	// Token: 0x0600DFC3 RID: 57283 RVA: 0x00346837 File Offset: 0x00344A37
	protected virtual string GetResourceId()
	{
		return "MotorcycleBattleBuff";
	}

	// Token: 0x0600DFC4 RID: 57284 RVA: 0x00346840 File Offset: 0x00344A40
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

	// Token: 0x0600DFC5 RID: 57285 RVA: 0x003468B4 File Offset: 0x00344AB4
	public void UpdateBuffInfo(IBuffGateDesc buffInfo)
	{
		this.BuffInfo = buffInfo;
		if (this.ButtItem != null)
		{
			this.ButtItem.SetDesc(this.BuffInfo);
		}
	}

	// Token: 0x0600DFC6 RID: 57286 RVA: 0x003468D6 File Offset: 0x00344AD6
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600DFC7 RID: 57287 RVA: 0x00346910 File Offset: 0x00344B10
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleBattleBuff.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleBattleBuff.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFC8 RID: 57288 RVA: 0x00346953 File Offset: 0x00344B53
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600DFC9 RID: 57289 RVA: 0x00346968 File Offset: 0x00344B68
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.IsFree = false;
		this.IsUp = false;
		this.CloseTime = (float)Time.Instance.WorldTimeSeconds + 2000f;
		this.RefreshHeadStateRotation();
	}

	// Token: 0x0600DFCA RID: 57290 RVA: 0x003469CC File Offset: 0x00344BCC
	public void SetUp()
	{
		this.IsUp = true;
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlaySequencePurely("Up", false, false, null, null, false);
	}

	// Token: 0x0600DFCB RID: 57291 RVA: 0x00346A0C File Offset: 0x00344C0C
	protected override UniTask OnBeforeHideAsync()
	{
		MotorcycleBattleBuff.<OnBeforeHideAsync>d__17 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MotorcycleBattleBuff.<OnBeforeHideAsync>d__17>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFCC RID: 57292 RVA: 0x00346A50 File Offset: 0x00344C50
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

	// Token: 0x0600DFCD RID: 57293 RVA: 0x00346ADC File Offset: 0x00344CDC
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

	// Token: 0x040066FC RID: 26364
	private const int SHOW_DURATION = 2000;

	// Token: 0x040066FD RID: 26365
	[Nullable(2)]
	private IBuffGateDesc BuffInfo;

	// Token: 0x040066FE RID: 26366
	[Nullable(2)]
	private MotorcycleBuffItem ButtItem;

	// Token: 0x040066FF RID: 26367
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006700 RID: 26368
	public bool IsFree = true;

	// Token: 0x04006701 RID: 26369
	public bool IsUp;

	// Token: 0x04006702 RID: 26370
	public float CloseTime;

	// Token: 0x04006703 RID: 26371
	private readonly global::Vector Offset = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x020082DF RID: 33503
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AB20 RID: 174880
		public const int Self = 0;

		// Token: 0x0402AB21 RID: 174881
		public const int ButtItem = 1;
	}
}
