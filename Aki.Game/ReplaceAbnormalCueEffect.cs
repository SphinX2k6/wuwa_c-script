using System;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F5B RID: 12123
[NullableContext(1)]
[Nullable(0)]
public class ReplaceAbnormalCueEffect : BuffEffect
{
	// Token: 0x06019CC9 RID: 105673 RVA: 0x006BA807 File Offset: 0x006B8A07
	public ReplaceAbnormalCueEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CCA RID: 105674 RVA: 0x006BA824 File Offset: 0x006B8A24
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

	// Token: 0x06019CCB RID: 105675 RVA: 0x006BA876 File Offset: 0x006B8A76
	public override void OnCreated()
	{
		this.CheckTeamRolesForSpecialTag();
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnRoleJoinTeam));
	}

	// Token: 0x06019CCC RID: 105676 RVA: 0x006BA89A File Offset: 0x006B8A9A
	public override void OnRemoved(bool bPremature)
	{
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnRoleJoinTeam));
	}

	// Token: 0x06019CCD RID: 105677 RVA: 0x006BA8B8 File Offset: 0x006B8AB8
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

	// Token: 0x06019CCE RID: 105678 RVA: 0x006BA908 File Offset: 0x006B8B08
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

	// Token: 0x06019CCF RID: 105679 RVA: 0x006BA9A4 File Offset: 0x006B8BA4
	private void CheckTeamRolesForSpecialTag()
	{
		if (string.IsNullOrEmpty(this.SpecialTag))
		{
			this.ReplaceCueEnabled = false;
			return;
		}
		bool replaceCueEnabled = SceneTeamModel.Instance.GetTeamEntities(false).Any(delegate(EntityHandle entityHandle)
		{
			WorldEntity entity = entityHandle.Entity;
			object obj = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			int tagIdByName = GameplayTagUtils.GetTagIdByName(this.SpecialTag);
			object obj2 = obj;
			return obj2 != null && obj2.HasTag(tagIdByName);
		});
		this.ReplaceCueEnabled = replaceCueEnabled;
	}

	// Token: 0x06019CD0 RID: 105680 RVA: 0x006BA9EA File Offset: 0x006B8BEA
	private void OnRoleJoinTeam()
	{
		this.CheckTeamRolesForSpecialTag();
	}

	// Token: 0x06019CD1 RID: 105681 RVA: 0x006BA9F4 File Offset: 0x006B8BF4
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

	// Token: 0x0400C272 RID: 49778
	private string SpecialTag = "";

	// Token: 0x0400C273 RID: 49779
	private long TargetCueId;

	// Token: 0x0400C274 RID: 49780
	private long NewTargetCueId;

	// Token: 0x0400C275 RID: 49781
	private bool ReplaceCueEnabled;
}
