using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200125A RID: 4698
[NullableContext(2)]
[Nullable(0)]
public class RollDice
{
	// Token: 0x06007FA4 RID: 32676 RVA: 0x001B0374 File Offset: 0x001AE574
	[NullableContext(1)]
	private RollDice(IRollDiceParam param)
	{
		this.Param = param;
	}

	// Token: 0x06007FA5 RID: 32677 RVA: 0x001B0396 File Offset: 0x001AE596
	[NullableContext(1)]
	public static RollDice Create(IRollDiceParam param)
	{
		return new RollDice(param);
	}

	// Token: 0x06007FA6 RID: 32678 RVA: 0x001B03A0 File Offset: 0x001AE5A0
	public UniTask Run()
	{
		RollDice.<Run>d__14 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<RollDice.<Run>d__14>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x06007FA7 RID: 32679 RVA: 0x001B03E4 File Offset: 0x001AE5E4
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

	// Token: 0x06007FA8 RID: 32680 RVA: 0x001B0524 File Offset: 0x001AE724
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

	// Token: 0x06007FA9 RID: 32681 RVA: 0x001B05AC File Offset: 0x001AE7AC
	public void UpdateDicePoint(int num, int index = 0)
	{
		UObject world = GlobalData.GameInstance.GetWorld();
		UMaterialParameterCollection diceMaterialParameterCollection = this.DiceMaterialParameterCollection;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
		defaultInterpolatedStringHandler.AppendLiteral("DicePoints_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(index + 1);
		UKismetMaterialLibrary.SetScalarParameterValue(world, diceMaterialParameterCollection, FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value, (float)num);
	}

	// Token: 0x06007FAA RID: 32682 RVA: 0x001B0604 File Offset: 0x001AE804
	private void UpdateProgress(float process)
	{
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, this.ProcessName, process);
	}

	// Token: 0x06007FAB RID: 32683 RVA: 0x001B0624 File Offset: 0x001AE824
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

	// Token: 0x06007FAC RID: 32684 RVA: 0x001B0669 File Offset: 0x001AE869
	public void TimerSystemCreate()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06007FAD RID: 32685 RVA: 0x001B0694 File Offset: 0x001AE894
	public void TimerSystemRemove()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06007FAE RID: 32686 RVA: 0x001B06B6 File Offset: 0x001AE8B6
	public void FlowSystemCreate()
	{
		this.TimerHandle = TimerSystem.FlowTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
	}

	// Token: 0x06007FAF RID: 32687 RVA: 0x001B06E1 File Offset: 0x001AE8E1
	public void FlowSystemRemove()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06007FB0 RID: 32688 RVA: 0x001B0703 File Offset: 0x001AE903
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

	// Token: 0x06007FB1 RID: 32689 RVA: 0x001B072E File Offset: 0x001AE92E
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

	// Token: 0x04003A0E RID: 14862
	[Nullable(1)]
	private UMaterialParameterCollection DiceMaterialParameterCollection;

	// Token: 0x04003A0F RID: 14863
	public CustomPromise Promise;

	// Token: 0x04003A10 RID: 14864
	private TimerHandle TimerHandle;

	// Token: 0x04003A11 RID: 14865
	private readonly float TickMaxTime = 5000f;

	// Token: 0x04003A12 RID: 14866
	private readonly int AniCount = 10;

	// Token: 0x04003A13 RID: 14867
	private float TickTime;

	// Token: 0x04003A14 RID: 14868
	private FName ProcessName;

	// Token: 0x04003A15 RID: 14869
	public Action TimerCreate;

	// Token: 0x04003A16 RID: 14870
	public Action TimerRemove;

	// Token: 0x04003A17 RID: 14871
	public IRollDiceParam Param;

	// Token: 0x04003A18 RID: 14872
	public BP_DiceOL_C DiceOutlineBp;

	// Token: 0x04003A19 RID: 14873
	public ACineCameraActor DiceCamera;
}
