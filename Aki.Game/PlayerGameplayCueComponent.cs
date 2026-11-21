using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002803 RID: 10243
[NullableContext(1)]
[Nullable(0)]
public class PlayerGameplayCueComponent : BaseGameplayCueComponent
{
	// Token: 0x06019CA5 RID: 105637 RVA: 0x007F256C File Offset: 0x007F076C
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		return true;
	}

	// Token: 0x06019CA6 RID: 105638 RVA: 0x007F2598 File Offset: 0x007F0798
	protected override bool OnStart()
	{
		base.OnStart();
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06019CA7 RID: 105639 RVA: 0x007F25BE File Offset: 0x007F07BE
	protected override bool OnEnd()
	{
		base.OnEnd();
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06019CA8 RID: 105640 RVA: 0x007F25E4 File Offset: 0x007F07E4
	protected override void OnTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in base.GetAllCurrentCueRef())
		{
			if (gameplayCueBase.IsActorValid())
			{
				gameplayCueBase.Tick(delta2);
			}
		}
	}

	// Token: 0x06019CA9 RID: 105641 RVA: 0x007F2648 File Offset: 0x007F0848
	protected override void OnAfterTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in base.GetAllCurrentCueRef())
		{
			if (gameplayCueBase.IsActorValid())
			{
				gameplayCueBase.AfterTick(delta2);
			}
		}
	}

	// Token: 0x06019CAA RID: 105642 RVA: 0x007F26AC File Offset: 0x007F08AC
	[NullableContext(2)]
	protected override EntityHandle GetEntityHandle()
	{
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
		long? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
			}
		}
		long? num2 = num;
		return CreatureModel.Instance.GetEntity(num2.GetValueOrDefault());
	}

	// Token: 0x06019CAB RID: 105643 RVA: 0x007F271C File Offset: 0x007F091C
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		foreach (GameplayCueBase gameplayCueBase in base.GetAllCurrentCueRef())
		{
			if (gameplayCueBase.EntityHandle != newEntityHandle)
			{
				gameplayCueBase.OnChangeRole(newEntityHandle);
			}
		}
	}

	// Token: 0x06019CAC RID: 105644 RVA: 0x007F2774 File Offset: 0x007F0974
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerGameplayCueComponent playerGameplayCueComponent = (PlayerGameplayCueComponent)componentTemplate;
		this.PlayerId = playerGameplayCueComponent.PlayerId;
		return true;
	}

	// Token: 0x1700298A RID: 10634
	// (get) Token: 0x06019CAD RID: 105645 RVA: 0x007F27A0 File Offset: 0x007F09A0
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700298B RID: 10635
	// (get) Token: 0x06019CAE RID: 105646 RVA: 0x007F27A3 File Offset: 0x007F09A3
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700298C RID: 10636
	// (get) Token: 0x06019CAF RID: 105647 RVA: 0x007F27A6 File Offset: 0x007F09A6
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700298D RID: 10637
	// (get) Token: 0x06019CB0 RID: 105648 RVA: 0x007F27A9 File Offset: 0x007F09A9
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E23A RID: 57914
	protected int PlayerId;
}
