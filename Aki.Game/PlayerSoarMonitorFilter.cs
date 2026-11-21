using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002A34 RID: 10804
[NullableContext(1)]
[Nullable(0)]
public class PlayerSoarMonitorFilter : EntityToLoadFilter
{
	// Token: 0x0601B395 RID: 111509 RVA: 0x0085BD48 File Offset: 0x00859F48
	private static bool PlayerSoarMonitorCriteria(EntityHandle entityHandle)
	{
		EEntityType entityType = (EEntityType)entityHandle.EntityType;
		return entityType == EEntityType.Player || entityType == EEntityType.SceneItem || entityType == EEntityType.PlayerEntity || entityType == EEntityType.SceneEntity;
	}

	// Token: 0x17002C6D RID: 11373
	// (get) Token: 0x0601B396 RID: 111510 RVA: 0x0085BD6F File Offset: 0x00859F6F
	public override string DebugName
	{
		get
		{
			return "PlayerSoarMonitorFilter";
		}
	}

	// Token: 0x0601B397 RID: 111511 RVA: 0x0085BD76 File Offset: 0x00859F76
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<bool>(EEventName.PlayerSoarChanged, new Action<bool>(this.OnPlayerSoarChanged));
		EventSystem.Instance.Add<bool>(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
	}

	// Token: 0x0601B398 RID: 111512 RVA: 0x0085BDB6 File Offset: 0x00859FB6
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<bool>(EEventName.PlayerSoarChanged, new Action<bool>(this.OnPlayerSoarChanged));
		EventSystem.Instance.Remove<bool>(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
		base.Cleanup();
	}

	// Token: 0x0601B399 RID: 111513 RVA: 0x0085BDF6 File Offset: 0x00859FF6
	private void OnPlayerSoarChanged(bool isPlayerSoar)
	{
		base.MaxLoadingCount = (isPlayerSoar ? 1L : 4L);
		base.LoadingInterval = (isPlayerSoar ? 10L : 0L);
	}

	// Token: 0x0601B39A RID: 111514 RVA: 0x0085BE18 File Offset: 0x0085A018
	private void OnSlowStreamingBySoar(bool enableSlowStreaming)
	{
		Func<EntityHandle, bool> criteria;
		if (!enableSlowStreaming)
		{
			if ((criteria = PlayerSoarMonitorFilter.<>O.<1>__AlwaysTrueCriteria) == null)
			{
				criteria = (PlayerSoarMonitorFilter.<>O.<1>__AlwaysTrueCriteria = new Func<EntityHandle, bool>(CriteriaDefine.AlwaysTrueCriteria<EntityHandle>));
			}
		}
		else if ((criteria = PlayerSoarMonitorFilter.<>O.<0>__PlayerSoarMonitorCriteria) == null)
		{
			criteria = (PlayerSoarMonitorFilter.<>O.<0>__PlayerSoarMonitorCriteria = new Func<EntityHandle, bool>(PlayerSoarMonitorFilter.PlayerSoarMonitorCriteria));
		}
		base.Criteria = criteria;
	}

	// Token: 0x0400EC72 RID: 60530
	private const long SOAR_MAX_LOADING_ENTITY_COUNT = 1L;

	// Token: 0x0400EC73 RID: 60531
	private const long SOAR_LOADING_INTERVAL = 10L;

	// Token: 0x02008A8A RID: 35466
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BFAE RID: 180142
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EntityHandle, bool> <0>__PlayerSoarMonitorCriteria;

		// Token: 0x0402BFAF RID: 180143
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EntityHandle, bool> <1>__AlwaysTrueCriteria;
	}
}
