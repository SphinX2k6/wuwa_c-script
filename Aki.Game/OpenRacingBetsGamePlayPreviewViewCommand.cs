using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB4 RID: 7092
public class OpenRacingBetsGamePlayPreviewViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A97 RID: 6807
	// (get) Token: 0x06011ABD RID: 72381 RVA: 0x00535E52 File Offset: 0x00534052
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.GamePlayPreviewView;
		}
	}

	// Token: 0x06011ABE RID: 72382 RVA: 0x00535E56 File Offset: 0x00534056
	public void Init(bool canCameraInput = false)
	{
		this.CanCameraInput = canCameraInput;
	}

	// Token: 0x06011ABF RID: 72383 RVA: 0x00535E60 File Offset: 0x00534060
	public override UniTask OnExecute()
	{
		OpenRacingBetsGamePlayPreviewViewCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsGamePlayPreviewViewCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AC0 RID: 72384 RVA: 0x00535EA3 File Offset: 0x005340A3
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsGamePlayPreviewView";
	}

	// Token: 0x04009A69 RID: 39529
	private bool CanCameraInput;
}
