using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RacingBets;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CB RID: 9931
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBlackHoleTransmitCommand : RacingBetsCommandBase
{
	// Token: 0x17001A61 RID: 6753
	// (get) Token: 0x060145E4 RID: 83428 RVA: 0x005271CA File Offset: 0x005253CA
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.BlackHole;
		}
	}

	// Token: 0x060145E5 RID: 83429 RVA: 0x005271CE File Offset: 0x005253CE
	public void Init(RacingBetsDangoActionBlackHoleTransmit transmitAction)
	{
		this.TransmitAction = transmitAction;
	}

	// Token: 0x060145E6 RID: 83430 RVA: 0x005271D8 File Offset: 0x005253D8
	public override UniTask OnExecute()
	{
		RacingBetsBlackHoleTransmitCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsBlackHoleTransmitCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x060145E7 RID: 83431 RVA: 0x0052721C File Offset: 0x0052541C
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

	// Token: 0x060145E8 RID: 83432 RVA: 0x00527278 File Offset: 0x00525478
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

	// Token: 0x060145E9 RID: 83433 RVA: 0x005272CC File Offset: 0x005254CC
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

	// Token: 0x060145EA RID: 83434 RVA: 0x0052730E File Offset: 0x0052550E
	public override string LogInfo()
	{
		return "RacingBetsBlackHoleTransmitCommand";
	}

	// Token: 0x04009912 RID: 39186
	private RacingBetsDangoActionBlackHoleTransmit TransmitAction;
}
