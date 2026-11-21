using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020024AE RID: 9390
[NullableContext(1)]
[Nullable(0)]
public class ReplaceAbnormalCueEffect : BuffEffect
{
	// Token: 0x060175D4 RID: 95700 RVA: 0x006E0B23 File Offset: 0x006DED23
	public ReplaceAbnormalCueEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175D5 RID: 95701 RVA: 0x006E0B40 File Offset: 0x006DED40
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.SpecialTag = extraEffectParameters_[0];
		}
		if (extraEffectParameters_ != null && extraEffectParameters_.Length > 1)
		{
			this.TargetCueId = long.Parse(extraEffectParameters_[1]);
		}
		if (extraEffectParameters_ != null && extraEffectParameters_.Length > 2)
		{
			this.NewTargetCueId = long.Parse(extraEffectParameters_[2]);
		}
	}

	// Token: 0x060175D6 RID: 95702 RVA: 0x006E0B92 File Offset: 0x006DED92
	public override void OnCreated()
	{
		this.CheckTeamRolesForSpecialTag();
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnRoleJoinTeam));
	}

	// Token: 0x060175D7 RID: 95703 RVA: 0x006E0BB6 File Offset: 0x006DEDB6
	public override void OnRemoved(bool bPremature)
	{
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnRoleJoinTeam));
	}

	// Token: 0x060175D8 RID: 95704 RVA: 0x006E0BD4 File Offset: 0x006DEDD4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (parameters.Length == 0 || !(parameters[0] is long))
		{
			return null;
		}
		long num = (long)parameters[0];
		if (!this.ReplaceCueEnabled)
		{
			return num;
		}
		if (num == this.TargetCueId)
		{
			return this.NewTargetCueId;
		}
		return num;
	}

	// Token: 0x060175D9 RID: 95705 RVA: 0x006E0C24 File Offset: 0x006DEE24
	[NullableContext(2)]
	public static long ApplyEffects(Entity ownerEntity, long cueId)
	{
		if (ownerEntity == null)
		{
			return cueId;
		}
		BaseBuffComponent component = ownerEntity.GetComponent<BaseBuffComponent>();
		if (component == null)
		{
			return cueId;
		}
		ExtraEffectManager buffEffectManager = component.BuffEffectManager;
		if (buffEffectManager == null)
		{
			return cueId;
		}
		foreach (ReplaceAbnormalCueEffect replaceAbnormalCueEffect in buffEffectManager.FilterById<ReplaceAbnormalCueEffect>(EExtraEffectId.ReplaceAbnormalCue, null))
		{
			object obj = replaceAbnormalCueEffect.Execute(new object[]
			{
				cueId
			});
			if (obj is long)
			{
				long num = (long)obj;
				if (num != cueId)
				{
					return num;
				}
			}
		}
		return cueId;
	}

	// Token: 0x060175DA RID: 95706 RVA: 0x006E0CC0 File Offset: 0x006DEEC0
	private void CheckTeamRolesForSpecialTag()
	{
		if (string.IsNullOrEmpty(this.SpecialTag))
		{
			this.ReplaceCueEnabled = false;
			return;
		}
		bool replaceCueEnabled = SceneTeamModel.Instance.GetTeamEntities(false).Exists(delegate(EntityHandle entityHandle)
		{
			WorldEntity entity = entityHandle.Entity;
			object obj = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			int tagIdByName = GameplayTagUtils.GetTagIdByName(this.SpecialTag);
			object obj2 = obj;
			return obj2 != null && obj2.HasTag(tagIdByName);
		});
		this.ReplaceCueEnabled = replaceCueEnabled;
	}

	// Token: 0x060175DB RID: 95707 RVA: 0x006E0D06 File Offset: 0x006DEF06
	private void OnRoleJoinTeam()
	{
		this.CheckTeamRolesForSpecialTag();
	}

	// Token: 0x060175DC RID: 95708 RVA: 0x006E0D10 File Offset: 0x006DEF10
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 4);
		defaultInterpolatedStringHandler.AppendLiteral("当队伍中有Tag[");
		defaultInterpolatedStringHandler.AppendFormatted(this.SpecialTag);
		defaultInterpolatedStringHandler.AppendLiteral("]的角色时，CueId[");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.TargetCueId);
		defaultInterpolatedStringHandler.AppendLiteral("]替换为CueId[");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.NewTargetCueId);
		defaultInterpolatedStringHandler.AppendLiteral("]，当前状态:");
		defaultInterpolatedStringHandler.AppendFormatted(this.ReplaceCueEnabled ? "生效" : "未生效");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C614 RID: 50708
	private string SpecialTag = "";

	// Token: 0x0400C615 RID: 50709
	private long TargetCueId;

	// Token: 0x0400C616 RID: 50710
	private long NewTargetCueId;

	// Token: 0x0400C617 RID: 50711
	private bool ReplaceCueEnabled;
}
