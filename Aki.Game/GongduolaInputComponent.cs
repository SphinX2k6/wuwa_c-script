using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x0200285C RID: 10332
[NullableContext(1)]
[Nullable(0)]
public class GongduolaInputComponent : VehicleInputComponent
{
	// Token: 0x17002AA2 RID: 10914
	// (get) Token: 0x0601A265 RID: 107109 RVA: 0x00815061 File Offset: 0x00813261
	[Nullable(2)]
	protected new GongduolaPerformComponent PerformComp
	{
		[NullableContext(2)]
		get
		{
			return this.PerformComp as GongduolaPerformComponent;
		}
	}

	// Token: 0x0601A266 RID: 107110 RVA: 0x00815070 File Offset: 0x00813270
	protected override void UpdateVehicleInputDirectAndFacing()
	{
		base.UpdateMoveCache();
		this.InputAdjusted(this.TmpVector1);
		this.ActorComp.Value.Switch(delegate(CharacterActorComponent t1)
		{
			t1.SetInputDirect(this.TmpVector1, true, EInputDirectSpace.Relative);
		}, delegate(VehicleActorComponent t2)
		{
			t2.SetInputDirect(this.TmpVector1, true, EInputDirectSpace.Relative);
		});
		this.SetInputFacingFromInputDirect(true);
	}

	// Token: 0x0601A267 RID: 107111 RVA: 0x008150C4 File Offset: 0x008132C4
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

	// Token: 0x0601A268 RID: 107112 RVA: 0x008152CC File Offset: 0x008134CC
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

	// Token: 0x0601A269 RID: 107113 RVA: 0x00815506 File Offset: 0x00813706
	protected override void ExecuteSprint(SInputCommand command)
	{
		GongduolaPerformComponent component = base.Entity.GetComponent<GongduolaPerformComponent>();
		if (component == null)
		{
			return;
		}
		component.TryEnterSprint(false);
	}

	// Token: 0x0601A26A RID: 107114 RVA: 0x00815520 File Offset: 0x00813720
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

	// Token: 0x0601A26B RID: 107115 RVA: 0x008155C0 File Offset: 0x008137C0
	protected override void AddBlockEvents()
	{
		base.AddBlockEvents();
		this.TagEventSprint = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["载具.贡多拉.逻辑.禁止冲刺"], EInputAction.闪避);
		this.TagEventChangeRoll1 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色1"], EInputAction.切换角色1);
		this.TagEventChangeRoll2 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色2"], EInputAction.切换角色2);
		this.TagEventChangeRoll3 = base.AddBlockActionEvent(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色3"], EInputAction.切换角色3);
	}

	// Token: 0x0601A26C RID: 107116 RVA: 0x0081565A File Offset: 0x0081385A
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

	// Token: 0x0601A26D RID: 107117 RVA: 0x00815694 File Offset: 0x00813894
	protected override void InitPassengerInputForbidTagInfo()
	{
		base.InitPassengerInputForbidTagInfo();
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色1"]);
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色2"]);
		this.PassengerInputForbidTagArray.Add(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止切换角色3"]);
	}

	// Token: 0x0601A26E RID: 107118 RVA: 0x008156F8 File Offset: 0x008138F8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		GongduolaInputComponent gongduolaInputComponent = (GongduolaInputComponent)componentTemplate;
		this.TurningForceInputFactor = gongduolaInputComponent.TurningForceInputFactor;
		this.TurnForwardInputMinX = gongduolaInputComponent.TurnForwardInputMinX;
		this.TurnBackwardInputMaxX = gongduolaInputComponent.TurnBackwardInputMaxX;
		this.MaxForwardThreshold = gongduolaInputComponent.MaxForwardThreshold;
		this.MaxRightThreshold = gongduolaInputComponent.MaxRightThreshold;
		if (gongduolaInputComponent.LastInput == null)
		{
			this.LastInput = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastInput), "LastInput"))
		{
			return false;
		}
		if (gongduolaInputComponent.TmpVector1 == null)
		{
			this.TmpVector1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector1), "TmpVector1"))
		{
			return false;
		}
		if (gongduolaInputComponent.TmpVector2 == null)
		{
			this.TmpVector2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (gongduolaInputComponent.TagEventChangeRoll1 == null)
		{
			this.TagEventChangeRoll1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll1), "TagEventChangeRoll1"))
		{
			return false;
		}
		if (gongduolaInputComponent.TagEventChangeRoll2 == null)
		{
			this.TagEventChangeRoll2 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll2), "TagEventChangeRoll2"))
		{
			return false;
		}
		if (gongduolaInputComponent.TagEventChangeRoll3 == null)
		{
			this.TagEventChangeRoll3 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventChangeRoll3), "TagEventChangeRoll3"))
		{
			return false;
		}
		if (gongduolaInputComponent.TagEventSprint == null)
		{
			this.TagEventSprint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagEventSprint), "TagEventSprint"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002AA3 RID: 10915
	// (get) Token: 0x0601A26F RID: 107119 RVA: 0x00815881 File Offset: 0x00813A81
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AA4 RID: 10916
	// (get) Token: 0x0601A270 RID: 107120 RVA: 0x00815884 File Offset: 0x00813A84
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AA5 RID: 10917
	// (get) Token: 0x0601A271 RID: 107121 RVA: 0x00815887 File Offset: 0x00813A87
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AA6 RID: 10918
	// (get) Token: 0x0601A272 RID: 107122 RVA: 0x0081588A File Offset: 0x00813A8A
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E58F RID: 58767
	private const int SKILL_ID_RIDER_SHARING = 100034;

	// Token: 0x0400E590 RID: 58768
	public float TurningForceInputFactor;

	// Token: 0x0400E591 RID: 58769
	public float TurnForwardInputMinX;

	// Token: 0x0400E592 RID: 58770
	public float TurnBackwardInputMaxX;

	// Token: 0x0400E593 RID: 58771
	public float MaxForwardThreshold = 1f;

	// Token: 0x0400E594 RID: 58772
	public float MaxRightThreshold = 1f;

	// Token: 0x0400E595 RID: 58773
	protected Vector LastInput = Vector.Create();

	// Token: 0x0400E596 RID: 58774
	protected Vector TmpVector1 = Vector.Create();

	// Token: 0x0400E597 RID: 58775
	protected Vector TmpVector2 = Vector.Create();

	// Token: 0x0400E598 RID: 58776
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll1;

	// Token: 0x0400E599 RID: 58777
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll2;

	// Token: 0x0400E59A RID: 58778
	[Nullable(2)]
	protected ITagTask TagEventChangeRoll3;

	// Token: 0x0400E59B RID: 58779
	[Nullable(2)]
	protected ITagTask TagEventSprint;
}
