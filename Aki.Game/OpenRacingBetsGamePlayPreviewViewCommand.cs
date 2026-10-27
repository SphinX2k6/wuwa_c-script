using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026C9 RID: 9929
public class OpenRacingBetsGamePlayPreviewViewCommand : RacingBetsCommandBase
{
	// Token: 0x17001A5F RID: 6751
	// (get) Token: 0x060145DB RID: 83419 RVA: 0x0052711A File Offset: 0x0052531A
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.GamePlayPreviewView;
		}
	}

	// Token: 0x060145DC RID: 83420 RVA: 0x0052711E File Offset: 0x0052531E
	public void Init(bool canCameraInput = false)
	{
		this.CanCameraInput = canCameraInput;
	}

	// Token: 0x060145DD RID: 83421 RVA: 0x00527128 File Offset: 0x00525328
	public override UniTask OnExecute()
	{
		OpenRacingBetsGamePlayPreviewViewCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<OpenRacingBetsGamePlayPreviewViewCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x060145DE RID: 83422 RVA: 0x0052716B File Offset: 0x0052536B
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsGamePlayPreviewView";
	}

	// Token: 0x04009911 RID: 39185
	private bool CanCameraInput;
}
