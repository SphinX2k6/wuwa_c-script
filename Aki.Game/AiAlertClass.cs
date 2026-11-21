using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using UnrealEngine;

// Token: 0x020000D9 RID: 217
[NullableContext(1)]
[Nullable(0)]
public class AiAlertClass
{
	// Token: 0x06000CE1 RID: 3297 RVA: 0x00044DAF File Offset: 0x00042FAF
	public AiAlertClass(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00044DD0 File Offset: 0x00042FD0
	public void Init(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
		EventSystem.Instance.AddWithTarget<float>(this.ActorComp.Entity, EEventName.SmartObjectAiAlterNotify, new Action<float>(this.ExtraModifyAlterValue));
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00044E00 File Offset: 0x00043000
	// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00044E08 File Offset: 0x00043008
	public AiAlert? AiAlertConfig
	{
		get
		{
			return this.AiAlertInternal;
		}
		set
		{
			this.AiAlertInternal = value;
			if (value == null)
			{
				return;
			}
			if (value.Value.ForwardAngle >= 180f)
			{
				this.CosLimit = 1f;
			}
			else
			{
				this.CosLimit = (float)Math.Cos((double)(value.Value.ForwardAngle * 0.017453292f));
			}
			if (value.Value.DecreaseByDist > 0f)
			{
				this.SquaredDistLimit = (float)MathUtils.Instance.Square((double)(value.Value.BaseIncrease / value.Value.DecreaseByDist));
			}
			else
			{
				this.SquaredDistLimit = 0f;
				if (value.Value.MaxDist > 0f && value.Value.AlertnessType == 3)
				{
					this.SquaredDistLimit = (float)MathUtils.Instance.Square((double)value.Value.MaxDist);
				}
			}
			if (value.Value.AlertnessType == 2 || value.Value.AlertnessType == 3)
			{
				if (!AlertMarkModel.Instance.AlertMarkInit)
				{
					AlertMarkModel.Instance.AddPendingMarkInfo(this.ActorComp.Entity.Id, this.ActorComp.Owner, (EAlertnessType)value.Value.AlertnessType, (float)value.Value.ShowDist);
					return;
				}
				if (value.Value.AlertnessType == 2)
				{
					EventSystem.Instance.Emit<int, AActor>(EEventName.AddStalkAlertMark, this.ActorComp.Entity.Id, this.ActorComp.Owner);
					return;
				}
				if (value.Value.AlertnessType == 3)
				{
					EventSystem.Instance.Emit<int, AActor, float>(EEventName.AddEavesdropMark, this.ActorComp.Entity.Id, this.ActorComp.Owner, (float)value.Value.ShowDist);
				}
			}
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004500B File Offset: 0x0004320B
	public float AlertValue
	{
		get
		{
			return this.CurrentValue;
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00045014 File Offset: 0x00043214
	public void Clear()
	{
		this.CurrentValue = 0f;
		this.InAlertRange = false;
		this.IsAlertState = false;
		EventSystem.Instance.Emit<int>(EEventName.RemoveAlterMark, this.AiController.CharActorComp.Entity.Id);
		Entity entity = this.ActorComp.Entity;
		EventSystem.Instance.Emit<int>(EEventName.RemoveStalkAlertMark, entity.Id);
		EventSystem.Instance.Emit<int>(EEventName.RemoveEavesdropMark, entity.Id);
		EventSystem.Instance.RemoveWithTarget<float>(this.ActorComp.Entity, EEventName.SmartObjectAiAlterNotify, new Action<float>(this.ExtraModifyAlterValue));
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x000450C0 File Offset: 0x000432C0
	public void Tick(float delta)
	{
		GameModeModel instance = GameModeModel.Instance;
		if (instance != null && instance.IsTeleport)
		{
			this.CurrentValue = 0f;
			this.InAlertRange = false;
			this.IsAlertState = false;
			return;
		}
		if (this.AiAlertInternal == null)
		{
			this.InAlertRange = false;
			return;
		}
		if (this.CurrentValue == 100f)
		{
			if (this.AiController.AiHateList.GetCurrentTarget() == null)
			{
				this.CurrentValue = Math.Max(0f, this.CurrentValue - delta * this.AiAlertInternal.Value.BaseDecrease * 0.001f);
				foreach (int id in this.AiController.AiPerception.Enemies)
				{
					CharacterBuffComponent component = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(id);
					if (component != null && component.Valid)
					{
						component.RemoveBuff(70000049L, -1, "AiAlterClass MaxValue", null, null, null);
					}
				}
			}
			return;
		}
		global::Vector actorLocationProxy = this.AiController.CharActorComp.ActorLocationProxy;
		global::Vector actorForwardProxy = this.AiController.CharActorComp.ActorForwardProxy;
		float num = 0f;
		if (this.AiController.AiPerception.Enemies.Count == 0)
		{
			this.InAlertRange = false;
		}
		foreach (int id2 in this.AiController.AiPerception.Enemies)
		{
			Entity entity = EntitySystem.Instance.Get(id2);
			if (entity.GetComponent<CreatureDataComponent>().GetEntityType() != EEntityType.Player)
			{
				this.InAlertRange = false;
			}
			else
			{
				entity.GetComponent<BaseActorComponent>().ActorLocationProxy.Subtraction(actorLocationProxy, this.TmpVector);
				double num2 = this.TmpVector.SizeSquared();
				if (this.SquaredDistLimit > 0f && num2 > (double)this.SquaredDistLimit)
				{
					this.InAlertRange = false;
				}
				else
				{
					this.InAlertRange = true;
					float num3 = (float)Math.Sqrt(num2);
					float num4 = this.AiAlertInternal.Value.BaseIncrease - this.AiAlertInternal.Value.DecreaseByDist * num3;
					if (num4 >= num)
					{
						if (this.TmpVector.DotProduct(actorForwardProxy) < (double)(this.CosLimit * num3))
						{
							num4 *= this.AiAlertInternal.Value.BackwardRate;
						}
						if (num4 >= num)
						{
							num = num4;
						}
					}
				}
			}
		}
		if (num == 0f)
		{
			this.CurrentValue = Math.Max(0f, this.CurrentValue - delta * this.AiAlertInternal.Value.BaseDecrease * 0.001f);
		}
		else
		{
			this.CurrentValue += delta * num * 0.001f;
			if (this.CurrentValue >= 100f)
			{
				this.CurrentValue = 100f;
				foreach (int id3 in this.AiController.AiPerception.Enemies)
				{
					CharacterBuffComponent component2 = EntitySystem.Instance.GetComponent<CharacterBuffComponent>(id3);
					if (component2 != null && component2.Valid)
					{
						component2.RemoveBuff(70000049L, -1, "AiAlterClass MaxValue", null, null, null);
					}
				}
				if (this.CallbackEvent != null)
				{
					this.CallbackEvent.Callback.Broadcast(true);
				}
			}
		}
		this.ProcessAlertness();
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x000454CC File Offset: 0x000436CC
	private void ProcessAlertness()
	{
		switch (this.AiAlertConfig.Value.AlertnessType)
		{
		case 1:
			this.JudgeAlertState();
			return;
		case 2:
			this.JudgeTrackingAlertness();
			return;
		case 3:
			this.JudgeEavesdropAlertness();
			return;
		default:
			return;
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x0004551C File Offset: 0x0004371C
	private void JudgeAlertState()
	{
		if (this.CurrentValue <= 1f || this.IsAlertState)
		{
			if (this.CurrentValue < 1f)
			{
				if (this.IsAlertState)
				{
					this.IsAlertState = false;
					EventSystem.Instance.Emit<int>(EEventName.RemoveAlterMark, this.AiController.CharActorComp.Entity.Id);
				}
				this.ShowUiFrameCount = 5;
			}
			return;
		}
		int showUiFrameCount = this.ShowUiFrameCount;
		this.ShowUiFrameCount = showUiFrameCount - 1;
		if (showUiFrameCount > 0)
		{
			return;
		}
		this.ShowUiFrameCount = 5;
		this.IsAlertState = true;
		EventSystem.Instance.Emit<int, global::Vector, AActor>(EEventName.AddAlterMark, this.AiController.CharActorComp.Entity.Id, global::Vector.Create(), this.AiController.CharActorComp.Owner);
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x000455E4 File Offset: 0x000437E4
	private void JudgeTrackingAlertness()
	{
		Entity entity = this.ActorComp.Entity;
		if (this.IsAlertState)
		{
			if (this.CurrentValue < 1f)
			{
				this.IsAlertState = false;
				this.IsFullAlert = false;
				EventSystem.Instance.EmitWithTarget(entity, EEventName.OnStalkAlertLifted);
				return;
			}
			if (this.CurrentValue >= 100f && !this.IsFullAlert)
			{
				EventSystem.Instance.Emit<int>(EEventName.OnStalkFound, entity.Id);
				this.IsFullAlert = true;
				return;
			}
		}
		else if (this.CurrentValue > 1f)
		{
			this.IsAlertState = true;
			EventSystem.Instance.EmitWithTarget(entity, EEventName.OnStalkAlert);
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0004568A File Offset: 0x0004388A
	private void JudgeEavesdropAlertness()
	{
		if (this.CurrentValue >= 100f)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnEavesdropFound, this.ActorComp.Entity.Id);
		}
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x000456B9 File Offset: 0x000438B9
	public void ExtraModifyAlterValue(float value)
	{
		this.CurrentValue += value;
		this.CurrentValue = MathUtils.Instance.Clamp(this.CurrentValue, 0f, 100f);
		this.ProcessAlertness();
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x000456EF File Offset: 0x000438EF
	public bool CheckInAlertRange()
	{
		return this.InAlertRange;
	}

	// Token: 0x04000A39 RID: 2617
	public const float MAX_ALERT = 100f;

	// Token: 0x04000A3A RID: 2618
	private const float ALERT_THRESHOLD = 1f;

	// Token: 0x04000A3B RID: 2619
	private const int SHOW_UI_FRAMES = 5;

	// Token: 0x04000A3C RID: 2620
	private AiAlert? AiAlertInternal;

	// Token: 0x04000A3D RID: 2621
	private float CurrentValue;

	// Token: 0x04000A3E RID: 2622
	private float CosLimit;

	// Token: 0x04000A3F RID: 2623
	private float SquaredDistLimit;

	// Token: 0x04000A40 RID: 2624
	[Nullable(2)]
	public UKuroBooleanEventBinder CallbackEvent;

	// Token: 0x04000A41 RID: 2625
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x04000A42 RID: 2626
	private int ShowUiFrameCount = 5;

	// Token: 0x04000A43 RID: 2627
	private bool IsAlertState;

	// Token: 0x04000A44 RID: 2628
	private bool IsFullAlert;

	// Token: 0x04000A45 RID: 2629
	private bool InAlertRange;

	// Token: 0x04000A46 RID: 2630
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x04000A47 RID: 2631
	private readonly AiController AiController;
}
