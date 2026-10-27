using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020026D2 RID: 9938
public class RacingBetsDangoRoundStartCommand : RacingBetsCommandBase
{
	// Token: 0x17001A6B RID: 6763
	// (get) Token: 0x06014618 RID: 83480 RVA: 0x0052770D File Offset: 0x0052590D
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoRoundStart;
		}
	}

	// Token: 0x06014619 RID: 83481 RVA: 0x00527710 File Offset: 0x00525910
	public void Init(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x0601461A RID: 83482 RVA: 0x00527719 File Offset: 0x00525919
	public override void OnActive()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnRacingBetsDangoRoundStart, this.DangoId);
	}

	// Token: 0x0601461B RID: 83483 RVA: 0x00527731 File Offset: 0x00525931
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDangoRoundStartCommand";
	}

	// Token: 0x0400991E RID: 39198
	private int DangoId;
}
