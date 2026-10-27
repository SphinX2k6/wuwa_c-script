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
	// Token: 0x06000CDB RID: 3291 RVA: 0x0004421B File Offset: 0x0004241B
	public AiAlertClass(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x0004423C File Offset: 0x0004243C
	public void Init(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
		EventSystem.Instance.AddWithTarget<float>(this.ActorComp.Entity, EEventName.SmartObjectAiAlterNotify, new Action<float>(this.ExtraModifyAlterValue));
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0004426C File Offset: 0x0004246C
	// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00044274 File Offset: 0x00042474
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

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00044477 File Offset: 0x00042677
	public float AlertValue
	{
		get
		{
			return this.CurrentValue;
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00044480 File Offset: 0x00042680
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

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0004452C File Offset: 0x0004272C
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

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00044938 File Offset: 0x00042B38
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

	// Token: 0x06000CE3 RID: 3299 RVA: 0x00044988 File Offset: 0x00042B88
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

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00044A50 File Offset: 0x00042C50
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

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00044AF6 File Offset: 0x00042CF6
	private void JudgeEavesdropAlertness()
	{
		if (this.CurrentValue >= 100f)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnEavesdropFound, this.ActorComp.Entity.Id);
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x00044B25 File Offset: 0x00042D25
	public void ExtraModifyAlterValue(float value)
	{
		this.CurrentValue += value;
		this.CurrentValue = MathUtils.Instance.Clamp(this.CurrentValue, 0f, 100f);
		this.ProcessAlertness();
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x00044B5B File Offset: 0x00042D5B
	public bool CheckInAlertRange()
	{
		return this.InAlertRange;
	}

	// Token: 0x04000A31 RID: 2609
	public const float MAX_ALERT = 100f;

	// Token: 0x04000A32 RID: 2610
	private const float ALERT_THRESHOLD = 1f;

	// Token: 0x04000A33 RID: 2611
	private const int SHOW_UI_FRAMES = 5;

	// Token: 0x04000A34 RID: 2612
	private AiAlert? AiAlertInternal;

	// Token: 0x04000A35 RID: 2613
	private float CurrentValue;

	// Token: 0x04000A36 RID: 2614
	private float CosLimit;

	// Token: 0x04000A37 RID: 2615
	private float SquaredDistLimit;

	// Token: 0x04000A38 RID: 2616
	[Nullable(2)]
	public UKuroBooleanEventBinder CallbackEvent;

	// Token: 0x04000A39 RID: 2617
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x04000A3A RID: 2618
	private int ShowUiFrameCount = 5;

	// Token: 0x04000A3B RID: 2619
	private bool IsAlertState;

	// Token: 0x04000A3C RID: 2620
	private bool IsFullAlert;

	// Token: 0x04000A3D RID: 2621
	private bool InAlertRange;

	// Token: 0x04000A3E RID: 2622
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x04000A3F RID: 2623
	private readonly AiController AiController;
}
