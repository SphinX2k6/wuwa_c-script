using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CC RID: 9932
public class RacingBetsChangeDangoCameraBlendCommand : RacingBetsCommandBase
{
	// Token: 0x17001A62 RID: 6754
	// (get) Token: 0x060145EC RID: 83436 RVA: 0x0052731D File Offset: 0x0052551D
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.CameraBlend;
		}
	}

	// Token: 0x060145ED RID: 83437 RVA: 0x00527324 File Offset: 0x00525524
	public override UniTask OnExecute()
	{
		RacingBetsChangeDangoCameraBlendCommand.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsChangeDangoCameraBlendCommand.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x060145EE RID: 83438 RVA: 0x00527367 File Offset: 0x00525567
	public void SetDangoId(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x060145EF RID: 83439 RVA: 0x00527370 File Offset: 0x00525570
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsChangeDangoCameraBlendCommand";
	}

	// Token: 0x04009913 RID: 39187
	private int DangoId;
}
