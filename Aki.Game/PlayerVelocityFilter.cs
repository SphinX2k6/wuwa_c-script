using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A35 RID: 10805
[NullableContext(1)]
[Nullable(0)]
public class PlayerVelocityFilter : EntityToLoadFilter
{
	// Token: 0x17002C6E RID: 11374
	// (get) Token: 0x0601B39C RID: 111516 RVA: 0x0085BE6E File Offset: 0x0085A06E
	public override string DebugName
	{
		get
		{
			return "PlayerVelocityFilter";
		}
	}

	// Token: 0x0601B39D RID: 111517 RVA: 0x0085BE75 File Offset: 0x0085A075
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<bool>(EEventName.OnHighSpeedModeChanged, new Action<bool>(this.OnHighSpeedModeChanged));
	}

	// Token: 0x0601B39E RID: 111518 RVA: 0x0085BE99 File Offset: 0x0085A099
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnHighSpeedModeChanged, new Action<bool>(this.OnHighSpeedModeChanged));
		base.Cleanup();
	}

	// Token: 0x0601B39F RID: 111519 RVA: 0x0085BEBD File Offset: 0x0085A0BD
	private void OnHighSpeedModeChanged(bool isHighSpeed)
	{
		base.MaxLoadingCount = (isHighSpeed ? 1L : 4L);
		base.LoadingInterval = (isHighSpeed ? 10L : 0L);
	}

	// Token: 0x0400EC74 RID: 60532
	private const long HIGH_SPEED_MAX_LOADING_ENTITY_COUNT = 1L;

	// Token: 0x0400EC75 RID: 60533
	private const long HIGH_SPEED_LOADING_INTERVAL = 10L;
}
