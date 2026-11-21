using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB7 RID: 7095
public class RacingBetsChangeDangoCameraBlendCommand : RacingBetsCommandBase
{
	// Token: 0x17001A9A RID: 6810
	// (get) Token: 0x06011ACE RID: 72398 RVA: 0x00536055 File Offset: 0x00534255
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.CameraBlend;
		}
	}

	// Token: 0x06011ACF RID: 72399 RVA: 0x0053605C File Offset: 0x0053425C
	public override UniTask OnExecute()
	{
		RacingBetsChangeDangoCameraBlendCommand.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsChangeDangoCameraBlendCommand.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AD0 RID: 72400 RVA: 0x0053609F File Offset: 0x0053429F
	public void SetDangoId(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x06011AD1 RID: 72401 RVA: 0x005360A8 File Offset: 0x005342A8
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsChangeDangoCameraBlendCommand";
	}

	// Token: 0x04009A6B RID: 39531
	private int DangoId;
}
