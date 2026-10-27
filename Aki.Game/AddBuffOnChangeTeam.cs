using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002EF3 RID: 12019
[NullableContext(1)]
[Nullable(0)]
public class AddBuffOnChangeTeam : BuffEffect
{
	// Token: 0x06019ADE RID: 105182 RVA: 0x006AE887 File Offset: 0x006ACA87
	public AddBuffOnChangeTeam(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019ADF RID: 105183 RVA: 0x006AE8A4 File Offset: 0x006ACAA4
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

	// Token: 0x06019AE0 RID: 105184 RVA: 0x006AE930 File Offset: 0x006ACB30
	public override void OnCreated()
	{
		if (!this.OwnerBuffComponent.HasBuffAuthority())
		{
			return;
		}
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
	}

	// Token: 0x06019AE1 RID: 105185 RVA: 0x006AE95C File Offset: 0x006ACB5C
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || !ownerBuffComponent.HasBuffAuthority())
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
	}

	// Token: 0x06019AE2 RID: 105186 RVA: 0x006AE992 File Offset: 0x006ACB92
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019AE3 RID: 105187 RVA: 0x006AE998 File Offset: 0x006ACB98
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

	// Token: 0x0400C0A8 RID: 49320
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C0A9 RID: 49321
	[Nullable(2)]
	private int[] TeamEntityIds;
}
