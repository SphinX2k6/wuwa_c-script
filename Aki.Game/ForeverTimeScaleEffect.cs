using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020024A5 RID: 9381
[NullableContext(1)]
[Nullable(0)]
public class ForeverTimeScaleEffect : BuffEffect
{
	// Token: 0x0601758B RID: 95627 RVA: 0x006DF29E File Offset: 0x006DD49E
	public ForeverTimeScaleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601758C RID: 95628 RVA: 0x006DF2B8 File Offset: 0x006DD4B8
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

	// Token: 0x0601758D RID: 95629 RVA: 0x006DF30C File Offset: 0x006DD50C
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

	// Token: 0x0601758E RID: 95630 RVA: 0x006DF366 File Offset: 0x006DD566
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		this.UpdateTimeScale();
	}

	// Token: 0x0601758F RID: 95631 RVA: 0x006DF36E File Offset: 0x006DD56E
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		this.UpdateTimeScale();
	}

	// Token: 0x06017590 RID: 95632 RVA: 0x006DF376 File Offset: 0x006DD576
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017591 RID: 95633 RVA: 0x006DF37C File Offset: 0x006DD57C
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

	// Token: 0x06017592 RID: 95634 RVA: 0x006DF428 File Offset: 0x006DD628
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

	// Token: 0x06017593 RID: 95635 RVA: 0x006DF4D4 File Offset: 0x006DD6D4
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

	// Token: 0x06017594 RID: 95636 RVA: 0x006DF624 File Offset: 0x006DD824
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

	// Token: 0x0400C5FF RID: 50687
	protected int Priority;

	// Token: 0x0400C600 RID: 50688
	protected float InitTimeScale;

	// Token: 0x0400C601 RID: 50689
	protected float BuffStackTimeScale;

	// Token: 0x0400C602 RID: 50690
	private List<int> TeamEntityIds = new List<int>();
}
