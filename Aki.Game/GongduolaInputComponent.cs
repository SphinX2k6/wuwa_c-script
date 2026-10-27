using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x020032EA RID: 13034
[NullableContext(1)]
[Nullable(0)]
public class GongduolaInputComponent : VehicleInputComponent
{
	// Token: 0x1700273F RID: 10047
	// (get) Token: 0x0601C5AE RID: 116142 RVA: 0x007EE92D File Offset: 0x007ECB2D
	[Nullable(2)]
	protected new GongduolaPerformComponent PerformComp
	{
		[NullableContext(2)]
		get
		{
			return this.PerformComp as GongduolaPerformComponent;
		}
	}

	// Token: 0x0601C5AF RID: 116143 RVA: 0x007EE93C File Offset: 0x007ECB3C
	protected override void UpdateVehicleInputDirectAndFacing()
	{
		base.UpdateMoveCache();
		this.InputAdjusted(this.TmpVector1);
		this.ActorComp.Value.Switch(delegate(CharacterActorComponent t1)
		{
			t1.SetInputDirect(this.TmpVector1, true);
		}, delegate(VehicleActorComponent t2)
		{
			t2.SetInputDirect(this.TmpVector1, true);
		});
		this.SetInputFacingFromInputDirect(true);
	}

	// Token: 0x0601C5B0 RID: 116144 RVA: 0x007EE990 File Offset: 0x007ECB90
	protected override void SetInputFacingFromInputDirect(bool clearWhenNoInput = true)
	{
		OneOf<CharacterActorComponent, VehicleActorComponent> value;
		if (this.MoveDirectionCache.X < 0.0)
		{
			this.MoveDirectionCache.UnaryNegation(this.TempVector);
			value = this.ActorComp.Value;
			Rotator inR = value.Match<Rotator>(([Nullable(1)] CharacterActorComponent t1) => t1.ActorRotationProxy, ([Nullable(1)] VehicleActorComponent t2) => t2.ActorRotationProxy);
			this.TempRotator.DeepCopy(inR);
			GravityUtils instance = GravityUtils.Instance;
			value = this.ActorComp.Value;
			instance.GetQuatFromRotatorAndGravityForActor((BaseActorComponent)value.GetValue(), this.TempRotator, this.TempQuat);
			this.TempQuat.RotateVector(this.TempVector, this.TmpVector1);
			value = this.ActorComp.Value;
			value.Switch(delegate(CharacterActorComponent t1)
			{
				t1.SetInputFacing(this.TmpVector1, false);
			}, delegate(VehicleActorComponent t2)
			{
				t2.SetInputFacing(this.TmpVector1, false);
			});
			return;
		}
		value = this.ActorComp.Value;
		Vector vector = value.Match<Vector>(([Nullable(1)] CharacterActorComponent t1) => t1.InputDirectProxy, ([Nullable(1)] VehicleActorComponent t2) => t2.InputDirectProxy);
		GravityUtils instance2 = GravityUtils.Instance;
		value = this.ActorComp.Value;
		if (instance2.GetPlanarSizeSquared2dForActor((BaseActorComponent)value.GetValue(), vector) > 1E-08)
		{
			value = this.ActorComp.Value;
			value.Switch(delegate(CharacterActorComponent t1)
			{
				t1.SetInputFacing(base.GetWorldMoveDirectionCache(), false);
			}, delegate(VehicleActorComponent t2)
			{
				t2.SetInputFacing(base.GetWorldMoveDirectionCache(), false);
			});
			return;
		}
		if (clearWhenNoInput)
		{
			value = this.ActorComp.Value;
			value.Switch(delegate(CharacterActorComponent t1)
			{
				t1.SetInputFacing(t1.ActorForwardProxy, false);
			}, delegate(VehicleActorComponent t2)
			{
				t2.SetInputFacing(t2.ActorForwardProxy, false);
			});
		}
	}

	// Token: 0x0601C5B1 RID: 116145 RVA: 0x007EEB98 File Offset: 0x007ECD98
	protected void InputAdjusted(Vector output)
	{
		output.DeepCopy(this.MoveVectorCache);
		double num = Math.Abs(this.MoveVectorCache.X);
		int num2 = (this.MoveVectorCache.X < 0.0) ? -1 : 1;
		double num3 = Math.Abs(this.MoveVectorCache.Y);
		int num4 = (this.MoveVectorCache.Y < 0.0) ? -1 : 1;
		if (this.TurningForceInputFactor != 0f && num3 != 0.0)
		{
			OneOf<CharacterActorComponent, VehicleActorComponent> value = this.ActorComp.Value;
			Vector inA = value.Match<Vector>(([Nullable(1)] CharacterActorComponent t1) => t1.ActorVelocityProxy, ([Nullable(1)] VehicleActorComponent t2) => t2.ActorVelocityProxy);
			value = this.ActorComp.Value;
			Vector inB = value.Match<Vector>(([Nullable(1)] CharacterActorComponent t1) => t1.ActorForwardProxy, ([Nullable(1)] VehicleActorComponent t2) => t2.ActorForwardProxy);
			GongduolaPerformComponent performComp = this.PerformComp;
			bool flag = (performComp != null && performComp.IsBeingImpacted) || Vector.DotProduct(inA, inB) >= 0.0;
			float num5 = flag ? 1f : this.TurnBackwardInputMaxX;
			float num6 = flag ? this.TurnForwardInputMinX : -1f;
			float num7 = (float)(flag ? 1 : -1);
			if (output.X < (double)num6)
			{
				num7 = -1f;
			}
			else if (output.X > (double)num5)
			{
				num7 = 1f;
			}
			output.X = (double)num7 * Math.Max(num, num3 * (double)this.TurningForceInputFactor);
		}
		if (num >= (double)this.MaxForwardThreshold)
		{
			output.X = (double)num2;
		}
		if (num3 >= (double)this.MaxRightThreshold)
		{
			output.Y = (double)num4;
		}
		if (Info.Instance.IsInGamepad() && output.Y * this.LastInput.Y < 0.0)
		{
			output.Y = 0.0;
		}
		this.LastInput.DeepCopy(output);
	}

	// Token: 0x0601C5B2 RID: 116146 RVA: 0x007EEDD2 File Offset: 0x007ECFD2
	protected override void ExecuteSprint(SInputCommand command)
	{
		GongduolaPerformComponent component = base.Entity.GetComponent<GongduolaPerformComponent>();
		if (component == null)
		{
			return;
		}
		component.TryEnterSprint(false);
	}

	// Token: 0x0601C5B3 RID: 116147 RVA: 0x007EEDEC File Offset: 0x007ECFEC
	protected override void ExecuteSkill(SInputCommand command)
	{
		int intValue = command.IntValue;
		if (intValue == 210012)
		{
			PhotographController.Instance.PhotographFastScreenShot(ECameraCaptureType.NormalCamera);
			return;
		}
		if (intValue == 100034)
		{
			GongduolaPerformComponent component = base.Entity.GetComponent<GongduolaPerformComponent>();
			if (component == null || !component.CheckIfCanRiderSharing())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_GongDuoLaCarpoolingForbid_Text", Array.Empty<object>());
				return;
			}
			VehicleMoveComponent component2 = base.Entity.GetComponent<VehicleMoveComponent>();
			if (component2 != null && component2.IsMoving)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ShipTogetherViewCanNotOpenWhenMoving", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.ShipTogetherView, null, null);
		}
	}

	// Token: 0x0601C5B4 RID: 116148 RVA: 0x007EEE8C File Offset: 0x007ED08C
	protected override void AddBlockEvents()
	{
		base.AddBlockEvents();
		this.TagEventSprint = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止冲刺"], EInputAction.闪避);
		this.TagEventChangeRoll1 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色1"], EInputAction.切换角色1);
		this.TagEventChangeRoll2 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色2"], EInputAction.切换角色2);
		this.TagEventChangeRoll3 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色3"], EInputAction.切换角色3);
	}

	// Token: 0x0601C5B5 RID: 116149 RVA: 0x007EEF26 File Offset: 0x007ED126
	protected override void RemoveBlockActionEvents()
	{
		base.RemoveBlockActionEvents();
		ITagTask tagEventSprint = this.TagEventSprint;
		if (tagEventSprint != null)
		{
			tagEventSprint.EndTask();
		}
		this.TagEventChangeRoll1.EndTask();
		this.TagEventChangeRoll2.EndTask();
		this.TagEventChangeRoll3.EndTask();
	}

	// Token: 0x0601C5B6 RID: 116150 RVA: 0x007EEF60 File Offset: 0x007ED160
	protected override void InitPassengerInputForbidTagInfo()
	{
		base.InitPassengerInputForbidTagInfo();
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色1"]);
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色2"]);
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色3"]);
	}

	// Token: 0x0601C5B7 RID: 116151 RVA: 0x007EEFC4 File Offset: 0x007ED1C4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		GongduolaInputComponent gongduolaInputComponent = (GongduolaInputComponent)componentTemplate;
		if (base.CanResetComponentProperty("TurningForceInputFactor"))
		{
			this.TurningForceInputFactor = gongduolaInputComponent.TurningForceInputFactor;
		}
		if (base.CanResetComponentProperty("TurnForwardInputMinX"))
		{
			this.TurnForwardInputMinX = gongduolaInputComponent.TurnForwardInputMinX;
		}
		if (base.CanResetComponentProperty("TurnBackwardInputMaxX"))
		{
			this.TurnBackwardInputMaxX = gongduolaInputComponent.TurnBackwardInputMaxX;
		}
		if (base.CanResetComponentProperty("MaxForwardThreshold"))
		{
			this.MaxForwardThreshold = gongduolaInputComponent.MaxForwardThreshold;
		}
		if (base.CanResetComponentProperty("MaxRightThreshold"))
		{
			this.MaxRightThreshold = gongduolaInputComponent.MaxRightThreshold;
		}
		if (base.CanResetComponentProperty("LastInput"))
		{
			if (gongduolaInputComponent.LastInput == null)
			{
				this.LastInput = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastInput), "LastInput"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector1"))
		{
			if (gongduolaInputComponent.TmpVector1 == null)
			{
				this.TmpVector1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector1), "TmpVector1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector2"))
		{
			if (gongduolaInputComponent.TmpVector2 == null)
			{
				this.TmpVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll1"))
		{
			if (gongduolaInputComponent.TagEventChangeRoll1 == null)
			{
				this.TagEventChangeRoll1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll1), "TagEventChangeRoll1"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll2"))
		{
			if (gongduolaInputComponent.TagEventChangeRoll2 == null)
			{
				this.TagEventChangeRoll2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll2), "TagEventChangeRoll2"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventChangeRoll3"))
		{
			if (gongduolaInputComponent.TagEventChangeRoll3 == null)
			{
				this.TagEventChangeRoll3 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventChangeRoll3), "TagEventChangeRoll3"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagEventSprint"))
		{
			if (gongduolaInputComponent.TagEventSprint == null)
			{
				this.TagEventSprint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.TagEventSprint), "TagEventSprint"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400E0E4 RID: 57572
	private const int SKILL_ID_RIDER_SHARING = 100034;

	// Token: 0x0400E0E5 RID: 57573
	public float TurningForceInputFactor;

	// Token: 0x0400E0E6 RID: 57574
	public float TurnForwardInputMinX;

	// Token: 0x0400E0E7 RID: 57575
	public float TurnBackwardInputMaxX;

	// Token: 0x0400E0E8 RID: 57576
	public float MaxForwardThreshold = 1f;

	// Token: 0x0400E0E9 RID: 57577
	public float MaxRightThreshold = 1f;

	// Token: 0x0400E0EA RID: 57578
	protected Vector LastInput = Vector.Create();

	// Token: 0x0400E0EB RID: 57579
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400E0EC RID: 57580
	protected Vector TmpVector2 = Vector.Create();

	// Token: 0x0400E0ED RID: 57581
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll1;

	// Token: 0x0400E0EE RID: 57582
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll2;

	// Token: 0x0400E0EF RID: 57583
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll3;

	// Token: 0x0400E0F0 RID: 57584
	[Nullable(2)]
	protected ITagTask TagEventSprint;
}
