using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020034C0 RID: 13504
[NullableContext(1)]
[Nullable(0)]
public class PlayerSoarMonitorFilter : EntityToLoadFilter
{
	// Token: 0x0601D696 RID: 120470 RVA: 0x008348A0 File Offset: 0x00832AA0
	private static bool PlayerSoarMonitorCriteria(EntityHandle entityHandle)
	{
		EEntityType entityType = (EEntityType)entityHandle.EntityType;
		return entityType == EEntityType.Player || entityType == EEntityType.SceneItem || entityType == EEntityType.PlayerEntity || entityType == EEntityType.SceneEntity;
	}

	// Token: 0x170028D5 RID: 10453
	// (get) Token: 0x0601D697 RID: 120471 RVA: 0x008348C7 File Offset: 0x00832AC7
	public override string DebugName
	{
		get
		{
			return "PlayerSoarMonitorFilter";
		}
	}

	// Token: 0x0601D698 RID: 120472 RVA: 0x008348CE File Offset: 0x00832ACE
	public override void Init()
	{
		base.Init();
		EventSystem.Instance.Add<bool>(EEventName.PlayerSoarChanged, new Action<bool>(this.OnPlayerSoarChanged));
		EventSystem.Instance.Add<bool>(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
	}

	// Token: 0x0601D699 RID: 120473 RVA: 0x0083490E File Offset: 0x00832B0E
	public override void Cleanup()
	{
		EventSystem.Instance.Remove<bool>(EEventName.PlayerSoarChanged, new Action<bool>(this.OnPlayerSoarChanged));
		EventSystem.Instance.Remove<bool>(EEventName.SlowStreamingBySoar, new Action<bool>(this.OnSlowStreamingBySoar));
		base.Cleanup();
	}

	// Token: 0x0601D69A RID: 120474 RVA: 0x0083494E File Offset: 0x00832B4E
	private void OnPlayerSoarChanged(bool isPlayerSoar)
	{
		base.MaxLoadingCount = (isPlayerSoar ? 1L : 4L);
		base.LoadingInterval = (isPlayerSoar ? 10L : 0L);
	}

	// Token: 0x0601D69B RID: 120475 RVA: 0x00834970 File Offset: 0x00832B70
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

	// Token: 0x0400E7BE RID: 59326
	private const long SOAR_MAX_LOADING_ENTITY_COUNT = 1L;

	// Token: 0x0400E7BF RID: 59327
	private const long SOAR_LOADING_INTERVAL = 10L;

	// Token: 0x02009870 RID: 39024
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0403092B RID: 198955
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EntityHandle, bool> <0>__PlayerSoarMonitorCriteria;

		// Token: 0x0403092C RID: 198956
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EntityHandle, bool> <1>__AlwaysTrueCriteria;
	}
}
