using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001BBD RID: 7101
public class RacingBetsDangoRoundStartCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA3 RID: 6819
	// (get) Token: 0x06011AFA RID: 72442 RVA: 0x00536445 File Offset: 0x00534645
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoRoundStart;
		}
	}

	// Token: 0x06011AFB RID: 72443 RVA: 0x00536448 File Offset: 0x00534648
	public void Init(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x06011AFC RID: 72444 RVA: 0x00536451 File Offset: 0x00534651
	public override void OnActive()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnRacingBetsDangoRoundStart, this.DangoId);
	}

	// Token: 0x06011AFD RID: 72445 RVA: 0x00536469 File Offset: 0x00534669
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDangoRoundStartCommand";
	}

	// Token: 0x04009A76 RID: 39542
	private int DangoId;
}
