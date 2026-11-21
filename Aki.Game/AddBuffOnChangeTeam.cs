using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002446 RID: 9286
[NullableContext(1)]
[Nullable(0)]
public class AddBuffOnChangeTeam : BuffEffect
{
	// Token: 0x060173E9 RID: 95209 RVA: 0x006D4B73 File Offset: 0x006D2D73
	public AddBuffOnChangeTeam(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060173EA RID: 95210 RVA: 0x006D4B90 File Offset: 0x006D2D90
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] array = parameters.ExtraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array[i]);
		}
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(false);
		this.TeamEntityIds = new int[teamEntities.Count];
		for (int j = 0; j < teamEntities.Count; j++)
		{
			this.TeamEntityIds[j] = teamEntities[j].Id;
		}
	}

	// Token: 0x060173EB RID: 95211 RVA: 0x006D4C1C File Offset: 0x006D2E1C
	public override void OnCreated()
	{
		if (!this.OwnerBuffComponent.HasBuffAuthority())
		{
			return;
		}
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
	}

	// Token: 0x060173EC RID: 95212 RVA: 0x006D4C48 File Offset: 0x006D2E48
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || !ownerBuffComponent.HasBuffAuthority())
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
	}

	// Token: 0x060173ED RID: 95213 RVA: 0x006D4C7E File Offset: 0x006D2E7E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060173EE RID: 95214 RVA: 0x006D4C84 File Offset: 0x006D2E84
	private void OnChangeTeam()
	{
		IActiveBuff buffByHandle = this.OwnerBuffComponent.GetBuffByHandle(this.ActiveHandleId);
		if (buffByHandle == null || !buffByHandle.IsValid())
		{
			return;
		}
		List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(false);
		foreach (EntityHandle entityHandle in teamEntities)
		{
			if (this.TeamEntityIds == null || Array.IndexOf<int>(this.TeamEntityIds, entityHandle.Id) < 0)
			{
				CharacterBuffComponent component = entityHandle.Entity.GetComponent<CharacterBuffComponent>();
				for (int i = 0; i < this.BuffIds.Length; i++)
				{
					if (component != null)
					{
						BaseBuffComponent baseBuffComponent = component;
						long buffId = this.BuffIds[i];
						IActiveBuff preBuff = buffByHandle;
						int? stackCount = null;
						bool isIterable = false;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
						defaultInterpolatedStringHandler.AppendLiteral("新入队角色加Buff（前置buff Id=");
						defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
						defaultInterpolatedStringHandler.AppendLiteral(", handle=");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
						defaultInterpolatedStringHandler.AppendLiteral("）");
						baseBuffComponent.AddIterativeBuff(buffId, preBuff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
					}
				}
			}
		}
		this.TeamEntityIds = new int[teamEntities.Count];
		for (int j = 0; j < teamEntities.Count; j++)
		{
			this.TeamEntityIds[j] = teamEntities[j].Id;
		}
	}

	// Token: 0x0400C449 RID: 50249
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C44A RID: 50250
	[Nullable(2)]
	private int[] TeamEntityIds;
}
