using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RacingBets;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB6 RID: 7094
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBlackHoleTransmitCommand : RacingBetsCommandBase
{
	// Token: 0x17001A99 RID: 6809
	// (get) Token: 0x06011AC6 RID: 72390 RVA: 0x00535F02 File Offset: 0x00534102
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.BlackHole;
		}
	}

	// Token: 0x06011AC7 RID: 72391 RVA: 0x00535F06 File Offset: 0x00534106
	public void Init(RacingBetsDangoActionBlackHoleTransmit transmitAction)
	{
		this.TransmitAction = transmitAction;
	}

	// Token: 0x06011AC8 RID: 72392 RVA: 0x00535F10 File Offset: 0x00534110
	public override UniTask OnExecute()
	{
		RacingBetsBlackHoleTransmitCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsBlackHoleTransmitCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AC9 RID: 72393 RVA: 0x00535F54 File Offset: 0x00534154
	private UniTask PhaseSink(BaseActorComponent headActorComp, double organZ, [Nullable(2)] Action<float> onProgress = null)
	{
		RacingBetsBlackHoleTransmitCommand.<PhaseSink>d__5 <PhaseSink>d__;
		<PhaseSink>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PhaseSink>d__.<>4__this = this;
		<PhaseSink>d__.headActorComp = headActorComp;
		<PhaseSink>d__.organZ = organZ;
		<PhaseSink>d__.onProgress = onProgress;
		<PhaseSink>d__.<>1__state = -1;
		<PhaseSink>d__.<>t__builder.Start<RacingBetsBlackHoleTransmitCommand.<PhaseSink>d__5>(ref <PhaseSink>d__);
		return <PhaseSink>d__.<>t__builder.Task;
	}

	// Token: 0x06011ACA RID: 72394 RVA: 0x00535FB0 File Offset: 0x005341B0
	private UniTask PhaseFall(BaseActorComponent headActorComp, double targetZ)
	{
		RacingBetsBlackHoleTransmitCommand.<PhaseFall>d__6 <PhaseFall>d__;
		<PhaseFall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PhaseFall>d__.<>4__this = this;
		<PhaseFall>d__.headActorComp = headActorComp;
		<PhaseFall>d__.targetZ = targetZ;
		<PhaseFall>d__.<>1__state = -1;
		<PhaseFall>d__.<>t__builder.Start<RacingBetsBlackHoleTransmitCommand.<PhaseFall>d__6>(ref <PhaseFall>d__);
		return <PhaseFall>d__.<>t__builder.Task;
	}

	// Token: 0x06011ACB RID: 72395 RVA: 0x00536004 File Offset: 0x00534204
	private void OnEffectRefresh(int pointId, float value)
	{
		RacingBetsModel instance = RacingBetsModel.Instance;
		IRacingBetsEffectData racingBetsEffectData = (instance != null) ? instance.GetPointEffectByType(pointId, ERacingBetsEffectType.Default) : null;
		if (racingBetsEffectData == null)
		{
			return;
		}
		int handle = racingBetsEffectData.Handle;
		EffectSystem.Instance.GetNiagaraComponent(handle).SetNiagaraVariableFloat("Dissolve", value);
	}

	// Token: 0x06011ACC RID: 72396 RVA: 0x00536046 File Offset: 0x00534246
	public override string LogInfo()
	{
		return "RacingBetsBlackHoleTransmitCommand";
	}

	// Token: 0x04009A6A RID: 39530
	private RacingBetsDangoActionBlackHoleTransmit TransmitAction;
}
