using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002497 RID: 9367
[NullableContext(1)]
[Nullable(0)]
public class TimeScaleEffect : BuffEffect
{
	// Token: 0x06017533 RID: 95539 RVA: 0x006DCE00 File Offset: 0x006DB000
	public TimeScaleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017534 RID: 95540 RVA: 0x006DCE28 File Offset: 0x006DB028
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			return;
		}
		if (extraEffectParameters_.Length != 0)
		{
			this.Priority = int.Parse(extraEffectParameters_[0]);
		}
		if (extraEffectParameters_.Length > 1)
		{
			this.Dilation = float.Parse(extraEffectParameters_[1]);
		}
		float num = float.Parse((extraEffectParameters_.Length > 3) ? extraEffectParameters_[3] : "-1");
		this.CurveId = ((Math.Abs(num % 1f) < 1.1754944E-38f) ? ((int)num) : -1);
	}

	// Token: 0x06017535 RID: 95541 RVA: 0x006DCE9A File Offset: 0x006DB09A
	public override void OnCreated()
	{
		this.AddTimeScaleByBuff();
	}

	// Token: 0x06017536 RID: 95542 RVA: 0x006DCEA2 File Offset: 0x006DB0A2
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017537 RID: 95543 RVA: 0x006DCEA5 File Offset: 0x006DB0A5
	public override void OnRemoved(bool bPremature)
	{
		this.Active = false;
		this.RemoveTimeScaleByBuff();
		this.CurveDt = null;
	}

	// Token: 0x06017538 RID: 95544 RVA: 0x006DCEBB File Offset: 0x006DB0BB
	public void StartTimeScaleEffect()
	{
		this.AddTimeScaleByBuff();
	}

	// Token: 0x06017539 RID: 95545 RVA: 0x006DCEC3 File Offset: 0x006DB0C3
	public void StopTimeScaleEffect()
	{
		this.RemoveTimeScaleByBuff();
	}

	// Token: 0x0601753A RID: 95546 RVA: 0x006DCECB File Offset: 0x006DB0CB
	private void AddTimeScaleByBuff()
	{
		if (this.CurveId != -1 && this.CurveDt == null)
		{
			ResourceSystem.Instance.LoadAsync<UDataTable>("/Game/Aki/Data/Fight/DT_BuffTimeScaleCurve.DT_BuffTimeScaleCurve", delegate([Nullable(2)] UDataTable table, string _)
			{
				if (!this.Active)
				{
					return;
				}
				this.CurveDt = table;
				this.AddTimeScaleByBuffInner();
			}, 100, "js_undefined");
			return;
		}
		this.AddTimeScaleByBuffInner();
	}

	// Token: 0x0601753B RID: 95547 RVA: 0x006DCF08 File Offset: 0x006DB108
	private void AddTimeScaleByBuffInner()
	{
		STimeScale stimeScale = (this.CurveDt != null) ? DataTableUtil.GetDataTableRow<STimeScale>(this.CurveDt, this.CurveId.ToString()) : null;
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		foreach (BaseFrozenComponent baseFrozenComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseFrozenComponent>(EComponent.BaseFrozenComponent, null) : null) ?? new List<BaseFrozenComponent>()))
		{
			int activeHandleId = this.ActiveHandleId;
			int priority = this.Priority;
			double timeDilation = (double)this.Dilation;
			float? num = (stimeScale != null) ? new float?(stimeScale.时间膨胀时长) : null;
			baseFrozenComponent.AddTimeScaleByBuff(activeHandleId, priority, timeDilation, (num != null) ? new double?((double)num.GetValueOrDefault()) : null, (stimeScale != null) ? stimeScale.时间膨胀变化曲线 : null);
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x0601753C RID: 95548 RVA: 0x006DD038 File Offset: 0x006DB238
	private void RemoveTimeScaleByBuff()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		foreach (BaseFrozenComponent baseFrozenComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseFrozenComponent>(EComponent.BaseFrozenComponent, null) : null) ?? new List<BaseFrozenComponent>()))
		{
			baseFrozenComponent.RemoveTimeScaleByBuff(this.ActiveHandleId);
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x0601753D RID: 95549 RVA: 0x006DD0E4 File Offset: 0x006DB2E4
	private void OnChangeTeam()
	{
		List<int> newOrRemoveTeamEntityIds = BaseBuffComponent.GetNewOrRemoveTeamEntityIds(this.TeamEntityIds, true);
		STimeScale stimeScale = null;
		if (newOrRemoveTeamEntityIds.Count > 0)
		{
			stimeScale = ((this.CurveDt != null) ? DataTableUtil.GetDataTableRow<STimeScale>(this.CurveDt, this.CurveId.ToString()) : null);
		}
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
				int activeHandleId = this.ActiveHandleId;
				int priority = this.Priority;
				double timeDilation = (double)this.Dilation;
				float? num = (stimeScale != null) ? new float?(stimeScale.时间膨胀时长) : null;
				obj2.AddTimeScaleByBuff(activeHandleId, priority, timeDilation, (num != null) ? new double?((double)num.GetValueOrDefault()) : null, (stimeScale != null) ? stimeScale.时间膨胀变化曲线 : null);
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
				obj4.RemoveTimeScaleByBuff(this.ActiveHandleId);
			}
		}
		this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
	}

	// Token: 0x0601753E RID: 95550 RVA: 0x006DD284 File Offset: 0x006DB484
	public override string GetDebugEffectString()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (this.CurveId == -1)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendFormatted((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff");
			defaultInterpolatedStringHandler.AppendLiteral(",设置时间膨胀(倍率");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Dilation);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
		defaultInterpolatedStringHandler.AppendFormatted((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff");
		defaultInterpolatedStringHandler.AppendLiteral(",设置时间膨胀(倍率");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Dilation);
		defaultInterpolatedStringHandler.AppendLiteral(" 曲线");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurveId);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C5D2 RID: 50642
	protected int Priority;

	// Token: 0x0400C5D3 RID: 50643
	protected float Dilation;

	// Token: 0x0400C5D4 RID: 50644
	protected int CurveId = -1;

	// Token: 0x0400C5D5 RID: 50645
	[Nullable(2)]
	protected UDataTable CurveDt;

	// Token: 0x0400C5D6 RID: 50646
	protected bool Active = true;

	// Token: 0x0400C5D7 RID: 50647
	private List<int> TeamEntityIds = new List<int>();
}
