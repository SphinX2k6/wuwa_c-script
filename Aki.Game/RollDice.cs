using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200070E RID: 1806
[NullableContext(2)]
[Nullable(0)]
public class RollDice
{
	// Token: 0x0600533B RID: 21307 RVA: 0x001B9024 File Offset: 0x001B7224
	[NullableContext(1)]
	private RollDice(IRollDiceParam param)
	{
		this.Param = param;
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x001B9046 File Offset: 0x001B7246
	[NullableContext(1)]
	public static RollDice Create(IRollDiceParam param)
	{
		return new RollDice(param);
	}

	// Token: 0x0600533D RID: 21309 RVA: 0x001B9050 File Offset: 0x001B7250
	public UniTask Run()
	{
		RollDice.<Run>d__14 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<RollDice.<Run>d__14>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x001B9094 File Offset: 0x001B7294
	private void UpdateDiceParameter()
	{
		IRollDiceParam param = this.Param;
		Action timerRemove = this.TimerRemove;
		if (timerRemove != null)
		{
			timerRemove();
		}
		this.ProcessName = FNameUtil.GetDynamicFName("Ani_Process").Value;
		this.UpdateProgress(((param != null) ? param.AniProcess : null).GetValueOrDefault());
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, FNameUtil.GetDynamicFName("DiceNub").Value, (float)((param != null) ? param.DicePoints.Length : 0));
		int num = ((param != null) ? param.AniNum : null) ?? this.AniCount;
		int num2 = (int)Math.Floor((double)((float)(Random.Shared.NextDouble() * (double)num)));
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, FNameUtil.GetDynamicFName("Ani_Num").Value, (float)num2);
		if (((param != null) ? param.DicePoints : null) != null)
		{
			for (int i = 0; i < param.DicePoints.Length; i++)
			{
				int num3 = param.DicePoints[i];
				this.UpdateDicePoint(num3, i);
			}
		}
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x001B91D4 File Offset: 0x001B73D4
	public void UpdateSceneBind()
	{
		IRollDiceParam param = this.Param;
		if (((param != null) ? param.BpDiceCase : null) != null)
		{
			this.DiceOutlineBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.Param.BpDiceCase).Value, ECollectActorType.UI) as BP_DiceOL_C);
		}
		IRollDiceParam param2 = this.Param;
		if (((param2 != null) ? param2.DiceCameraCase : null) != null)
		{
			this.DiceCamera = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.Param.DiceCameraCase).Value, ECollectActorType.UI) as ACineCameraActor);
		}
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x001B925C File Offset: 0x001B745C
	public void UpdateDicePoint(int num, int index = 0)
	{
		UObject world = GlobalData.GameInstance.GetWorld();
		UMaterialParameterCollection diceMaterialParameterCollection = this.DiceMaterialParameterCollection;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DicePoints_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(index + 1);
		UKismetMaterialLibrary.SetScalarParameterValue(world, diceMaterialParameterCollection, FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value, (float)num);
	}

	// Token: 0x06005341 RID: 21313 RVA: 0x001B92B4 File Offset: 0x001B74B4
	private void UpdateProgress(float process)
	{
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, this.ProcessName, process);
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x001B92D4 File Offset: 0x001B74D4
	private void OnTick(float deltaTime)
	{
		this.TickTime += deltaTime;
		if (this.TickTime >= this.TickMaxTime)
		{
			this.TickEnd();
			return;
		}
		float process = this.TickTime / this.TickMaxTime;
		this.UpdateProgress(process);
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x001B9319 File Offset: 0x001B7519
	public void TimerSystemCreate()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x001B9344 File Offset: 0x001B7544
	public void TimerSystemRemove()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06005345 RID: 21317 RVA: 0x001B9366 File Offset: 0x001B7566
	public void FlowSystemCreate()
	{
		this.TimerHandle = TimerSystem.FlowTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06005346 RID: 21318 RVA: 0x001B9391 File Offset: 0x001B7591
	public void FlowSystemRemove()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x001B93B3 File Offset: 0x001B75B3
	private void TickEnd()
	{
		Action timerRemove = this.TimerRemove;
		if (timerRemove != null)
		{
			timerRemove();
		}
		CustomPromise promise = this.Promise;
		if (promise != null)
		{
			promise.SetResult();
		}
		this.Promise = null;
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x001B93DE File Offset: 0x001B75DE
	public void TickStart()
	{
		this.TickTime = 0f;
		Action timerCreate = this.TimerCreate;
		if (timerCreate == null)
		{
			return;
		}
		timerCreate();
	}

	// Token: 0x04003AA6 RID: 15014
	[Nullable(1)]
	private UMaterialParameterCollection DiceMaterialParameterCollection;

	// Token: 0x04003AA7 RID: 15015
	public CustomPromise Promise;

	// Token: 0x04003AA8 RID: 15016
	private TimerHandle TimerHandle;

	// Token: 0x04003AA9 RID: 15017
	private readonly float TickMaxTime = 5000f;

	// Token: 0x04003AAA RID: 15018
	private readonly int AniCount = 10;

	// Token: 0x04003AAB RID: 15019
	private float TickTime;

	// Token: 0x04003AAC RID: 15020
	private FName ProcessName;

	// Token: 0x04003AAD RID: 15021
	public Action TimerCreate;

	// Token: 0x04003AAE RID: 15022
	public Action TimerRemove;

	// Token: 0x04003AAF RID: 15023
	public IRollDiceParam Param;

	// Token: 0x04003AB0 RID: 15024
	public BP_DiceOL_C DiceOutlineBp;

	// Token: 0x04003AB1 RID: 15025
	public ACineCameraActor DiceCamera;
}
