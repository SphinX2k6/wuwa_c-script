using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F52 RID: 12114
[NullableContext(1)]
[Nullable(0)]
public class ForeverTimeScaleEffect : BuffEffect
{
	// Token: 0x06019C80 RID: 105600 RVA: 0x006B8F82 File Offset: 0x006B7182
	public ForeverTimeScaleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C81 RID: 105601 RVA: 0x006B8F9C File Offset: 0x006B719C
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			return;
		}
		if (extraEffectParameters_.Length > 1)
		{
			this.Priority = int.Parse(extraEffectParameters_[1]);
		}
		if (extraEffectParameters_.Length > 2)
		{
			this.InitTimeScale = float.Parse(extraEffectParameters_[2]);
		}
		if (extraEffectParameters_.Length > 3)
		{
			this.BuffStackTimeScale = float.Parse(extraEffectParameters_[3]);
		}
	}

	// Token: 0x06019C82 RID: 105602 RVA: 0x006B8FF0 File Offset: 0x006B71F0
	public override void OnCreated()
	{
		this.UpdateTimeScale();
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06019C83 RID: 105603 RVA: 0x006B904A File Offset: 0x006B724A
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		this.UpdateTimeScale();
	}

	// Token: 0x06019C84 RID: 105604 RVA: 0x006B9052 File Offset: 0x006B7252
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		this.UpdateTimeScale();
	}

	// Token: 0x06019C85 RID: 105605 RVA: 0x006B905A File Offset: 0x006B725A
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C86 RID: 105606 RVA: 0x006B9060 File Offset: 0x006B7260
	public override void OnRemoved(bool bPremature)
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		foreach (BaseFrozenComponent baseFrozenComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseFrozenComponent>(EComponent.BaseFrozenComponent, null) : null) ?? new List<BaseFrozenComponent>()))
		{
			baseFrozenComponent.RemoveForeverTimeScale(this.ActiveHandleId);
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06019C87 RID: 105607 RVA: 0x006B910C File Offset: 0x006B730C
	private void UpdateTimeScale()
	{
		float initTimeScale = this.InitTimeScale;
		float buffStackTimeScale = this.BuffStackTimeScale;
		IActiveBuff buff = base.Buff;
		float timeDilation = initTimeScale + buffStackTimeScale * (float)((buff != null) ? buff.StackCount : 1);
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		foreach (BaseFrozenComponent baseFrozenComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseFrozenComponent>(EComponent.BaseFrozenComponent, null) : null) ?? new List<BaseFrozenComponent>()))
		{
			baseFrozenComponent.SetForeverTimeScale(this.ActiveHandleId, this.Priority, timeDilation);
		}
	}

	// Token: 0x06019C88 RID: 105608 RVA: 0x006B91B8 File Offset: 0x006B73B8
	private void OnChangeTeam()
	{
		List<int> newOrRemoveTeamEntityIds = BaseBuffComponent.GetNewOrRemoveTeamEntityIds(this.TeamEntityIds, true);
		float num;
		if (newOrRemoveTeamEntityIds.Count <= 0)
		{
			num = 0f;
		}
		else
		{
			float initTimeScale = this.InitTimeScale;
			float buffStackTimeScale = this.BuffStackTimeScale;
			IActiveBuff buff = base.Buff;
			num = initTimeScale + buffStackTimeScale * (float)((buff != null) ? buff.StackCount : 1);
		}
		float timeDilation = num;
		foreach (int id in newOrRemoveTeamEntityIds)
		{
			CharacterModel instance = CharacterModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(id);
				if (handle == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = handle.Entity;
					obj = ((entity != null) ? entity.CheckGetComponent<BaseFrozenComponent>() : null);
				}
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.SetForeverTimeScale(this.ActiveHandleId, this.Priority, timeDilation);
			}
		}
		foreach (int id2 in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(this.TeamEntityIds, false))
		{
			CharacterModel instance2 = CharacterModel.Instance;
			object obj3;
			if (instance2 == null)
			{
				obj3 = null;
			}
			else
			{
				EntityHandle handle2 = instance2.GetHandle(id2);
				if (handle2 == null)
				{
					obj3 = null;
				}
				else
				{
					WorldEntity entity2 = handle2.Entity;
					obj3 = ((entity2 != null) ? entity2.CheckGetComponent<BaseFrozenComponent>() : null);
				}
			}
			object obj4 = obj3;
			if (obj4 != null)
			{
				obj4.RemoveForeverTimeScale(this.ActiveHandleId);
			}
		}
		this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
	}

	// Token: 0x06019C89 RID: 105609 RVA: 0x006B9308 File Offset: 0x006B7508
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
		defaultInterpolatedStringHandler.AppendLiteral("设置时间膨胀 初始倍率");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.InitTimeScale);
		defaultInterpolatedStringHandler.AppendLiteral(" + buff层数");
		IActiveBuff buff = base.Buff;
		defaultInterpolatedStringHandler.AppendFormatted<int?>((buff != null) ? new int?(buff.StackCount) : null);
		defaultInterpolatedStringHandler.AppendLiteral(" * 层数变更系数");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.BuffStackTimeScale);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C25D RID: 49757
	protected int Priority;

	// Token: 0x0400C25E RID: 49758
	protected float InitTimeScale;

	// Token: 0x0400C25F RID: 49759
	protected float BuffStackTimeScale;

	// Token: 0x0400C260 RID: 49760
	private List<int> TeamEntityIds = new List<int>();
}
