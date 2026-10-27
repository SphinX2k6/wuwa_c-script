using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020034C1 RID: 13505
[NullableContext(1)]
[Nullable(0)]
public class PlayerVelocityFilter : EntityToLoadFilter
{
	// Token: 0x170028D6 RID: 10454
	// (get) Token: 0x0601D69D RID: 120477 RVA: 0x008349C6 File Offset: 0x00832BC6
	public override string DebugName
	{
		get
		{
			return "PlayerVelocityFilter";
		}
	}

	// Token: 0x0601D69E RID: 120478 RVA: 0x008349CD File Offset: 0x00832BCD
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<bool>(EEventName.OnHighSpeedModeChanged, new Action<bool>(this.OnHighSpeedModeChanged));
	}

	// Token: 0x0601D69F RID: 120479 RVA: 0x008349F1 File Offset: 0x00832BF1
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnHighSpeedModeChanged, new Action<bool>(this.OnHighSpeedModeChanged));
		base.Cleanup();
	}

	// Token: 0x0601D6A0 RID: 120480 RVA: 0x00834A15 File Offset: 0x00832C15
	private void OnHighSpeedModeChanged(bool isHighSpeed)
	{
		base.MaxLoadingCount = (isHighSpeed ? 1L : 4L);
		base.LoadingInterval = (isHighSpeed ? 10L : 0L);
	}

	// Token: 0x0400E7C0 RID: 59328
	private const long HIGH_SPEED_MAX_LOADING_ENTITY_COUNT = 1L;

	// Token: 0x0400E7C1 RID: 59329
	private const long HIGH_SPEED_LOADING_INTERVAL = 10L;
}
