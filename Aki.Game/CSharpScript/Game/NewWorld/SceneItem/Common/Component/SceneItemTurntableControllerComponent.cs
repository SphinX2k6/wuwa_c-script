using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062DD RID: 25309
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTurntableControllerComponent : EntityComponent
	{
		// Token: 0x0603D323 RID: 250659 RVA: 0x011A8ED0 File Offset: 0x011A70D0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TurntableControlComponent turntableControlComponent = ((args != null) ? args.GetP1<CreateEntityData>() : null).GetParam<SceneItemTurntableControllerComponent>() as TurntableControlComponent;
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return false;
			}
			if (turntableControlComponent == null)
			{
				return true;
			}
			int? num = null;
			IFixedAngleTurntable fixedAngleTurntable = turntableControlComponent.Config as IFixedAngleTurntable;
			if (fixedAngleTurntable != null)
			{
				num = new int?(fixedAngleTurntable.ItemConfig.Count);
			}
			else
			{
				IFreeAngleTurntable freeAngleTurntable = turntableControlComponent.Config as IFreeAngleTurntable;
				if (freeAngleTurntable != null)
				{
					num = new int?(freeAngleTurntable.ItemConfig.Count);
				}
			}
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
				{
					this.CreatureDataComponent = component;
					this.ControllerConfig = turntableControlComponent.Config;
					this.RotatingRings = new List<SceneItemTurntableControllerComponent.RotatingRing>();
					int num4 = 0;
					for (;;)
					{
						int num5 = num4;
						num2 = num;
						if (!(num5 < num2.GetValueOrDefault() & num2 != null))
						{
							break;
						}
						SceneItemTurntableControllerComponent.RotatingRing item = new SceneItemTurntableControllerComponent.RotatingRing
						{
							Index = num4,
							IsAtTarget = false,
							IsSelected = false,
							IsRotating = false,
							CurSpeed = 0f,
							AccumulateAngle = 0f
						};
						this.RotatingRings.Add(item);
						num4++;
					}
					this.IsInitComplete = false;
					return true;
				}
			}
			Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.ZYL, "稷廷开门机关组件创建错误，圈数不对", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x0603D324 RID: 250660 RVA: 0x011A9030 File Offset: 0x011A7230
		protected override bool OnStart()
		{
			this.TagComponent = base.Entity.GetComponent<LevelTagComponent>();
			if (this.TagComponent == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.ZYL, "稷廷开门机关组件初始化错误，找不到LevelTagComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (this.ControllerConfig == null)
			{
				return true;
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			return true;
		}

		// Token: 0x0603D325 RID: 250661 RVA: 0x011A90A4 File Offset: 0x011A72A4
		protected override void OnActivate()
		{
			this.SetAllowRotate(false);
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState)))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "SceneItemTurntableControllerComponent.OnActivate，重复添加事件";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState));
		}

		// Token: 0x0603D326 RID: 250662 RVA: 0x011A914D File Offset: 0x011A734D
		protected override void OnTick(float delta)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			if (this.GetControlType() == EControllerType.FixedAngle)
			{
				this.TickFixedAngleRotate(delta);
			}
			else
			{
				this.TickFreeAngleRotate(delta);
			}
			this.TickAngleCorrectionRotate(delta);
		}

		// Token: 0x0603D327 RID: 250663 RVA: 0x011A9178 File Offset: 0x011A7378
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.HandleUpdateState));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			return true;
		}

		// Token: 0x0603D328 RID: 250664 RVA: 0x011A9210 File Offset: 0x011A7410
		private void OnSceneInteractionLoadCompleted()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			if (!this.InitRingActorArray())
			{
				return;
			}
			this.InitRingActorAngle();
			this.IsInitComplete = true;
			if (this.UpdateAllRingsAtTarget(true))
			{
				LevelTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.完成"]))
				{
					this.RequestTurntableComplete();
				}
			}
		}

		// Token: 0x0603D329 RID: 250665 RVA: 0x011A928C File Offset: 0x011A748C
		private bool InitRingActorArray()
		{
			SceneItemActorComponent component = base.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.ZYL, "稷廷开门机关组件初始化错误，SceneItemActorComponent组件获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Ring");
				defaultInterpolatedStringHandler.AppendFormatted<int>(rotatingRing.Index);
				string text = defaultInterpolatedStringHandler.ToStringAndClear();
				AActor actorInSceneInteraction = component.GetActorInSceneInteraction(text);
				if (actorInSceneInteraction == null || !actorInSceneInteraction.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "稷廷开门机关组件初始化错误，对应Actor无效";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", text);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				rotatingRing.ControllerRingActor = actorInSceneInteraction;
			}
			return true;
		}

		// Token: 0x0603D32A RID: 250666 RVA: 0x011A9390 File Offset: 0x011A7590
		private void InitRingActorAngle()
		{
			LevelTagComponent tagComponent = this.TagComponent;
			bool flag = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.完成"]);
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				ITurntableControlType controllerConfig = this.ControllerConfig;
				IFixedAngleTurntable fixedAngleTurntable = controllerConfig as IFixedAngleTurntable;
				if (fixedAngleTurntable == null)
				{
					IFreeAngleTurntable freeAngleTurntable = controllerConfig as IFreeAngleTurntable;
					if (freeAngleTurntable != null)
					{
						int initAngle = freeAngleTurntable.ItemConfig[rotatingRing.Index].InitAngle;
						int targetAngle = freeAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
						this.SetRingAngle(rotatingRing, (float)(flag ? targetAngle : initAngle));
					}
				}
				else
				{
					int initAngle2 = fixedAngleTurntable.ItemConfig[rotatingRing.Index].InitAngle;
					int targetAngle2 = fixedAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
					this.SetRingAngle(rotatingRing, (float)(flag ? targetAngle2 : initAngle2));
				}
			}
		}

		// Token: 0x0603D32B RID: 250667 RVA: 0x011A94B0 File Offset: 0x011A76B0
		public void DeselectAllRings(bool updateEffect)
		{
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				rotatingRing.IsSelected = false;
			}
			if (updateEffect)
			{
				this.UpdateAllRingsSelectedEffect();
			}
		}

		// Token: 0x0603D32C RID: 250668 RVA: 0x011A950C File Offset: 0x011A770C
		public void SelectRingByIndex(int index, bool updateEffect)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			rotatingRing.IsSelected = true;
			if (updateEffect)
			{
				this.UpdateRingSelectedEffectByIndex(rotatingRing.Index);
			}
		}

		// Token: 0x0603D32D RID: 250669 RVA: 0x011A9540 File Offset: 0x011A7740
		public void DeselectRingByIndex(int index, bool updateEffect)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			rotatingRing.IsSelected = false;
			if (updateEffect)
			{
				this.UpdateRingSelectedEffectByIndex(rotatingRing.Index);
			}
		}

		// Token: 0x0603D32E RID: 250670 RVA: 0x011A9574 File Offset: 0x011A7774
		private int GetSelectedTagByIndex(int index)
		{
			switch (index)
			{
			case 0:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环选中.环0"];
			case 1:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环选中.环1"];
			case 2:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环选中.环2"];
			default:
				return 0;
			}
		}

		// Token: 0x0603D32F RID: 250671 RVA: 0x011A95C8 File Offset: 0x011A77C8
		private int GetAtTargetTagByIndex(int index)
		{
			switch (index)
			{
			case 0:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环到位.环0"];
			case 1:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环到位.环1"];
			case 2:
				return GameplayTagDefine.EGameplayTagId["关卡.转盘机关主控.圆环到位.环2"];
			default:
				return 0;
			}
		}

		// Token: 0x0603D330 RID: 250672 RVA: 0x011A961C File Offset: 0x011A781C
		private void StartRingRotateByIndex(int index, bool clockwise)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			if (!this.IsInitComplete || !this.GetRotateAllowed() || this.IsBusyRotating())
			{
				return;
			}
			rotatingRing.AccumulateAngle = 0f;
			rotatingRing.CurSpeed = (float)Math.Abs(this.ControllerConfig.RotationSpeed) * (clockwise ? 1f : -1f) / 1000f;
			rotatingRing.IsRotating = true;
		}

		// Token: 0x0603D331 RID: 250673 RVA: 0x011A9694 File Offset: 0x011A7894
		private void StopRingsRotateByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			if (!this.IsInitComplete || !this.GetRotateAllowed())
			{
				return;
			}
			rotatingRing.AccumulateAngle = 0f;
			rotatingRing.CurSpeed = 0f;
			rotatingRing.IsRotating = false;
		}

		// Token: 0x0603D332 RID: 250674 RVA: 0x011A96E0 File Offset: 0x011A78E0
		public void TriggerStartSelectedRingsRotate()
		{
			if (this.ControllerConfig.Type == EControllerType.FixedAngle)
			{
				this.TriggerStartSelectedFixedAngleRingsRotate();
				return;
			}
			this.TriggerStartSelectedFreeAngleRingsRotate();
		}

		// Token: 0x0603D333 RID: 250675 RVA: 0x011A9700 File Offset: 0x011A7900
		private void TriggerStartSelectedFixedAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed())
			{
				return;
			}
			if (this.ControllerConfig.Type != EControllerType.FixedAngle)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsSelected)
				{
					bool clockwise = this.ControllerConfig.RotationSpeed > 0;
					this.StartRingRotateByIndex(rotatingRing.Index, clockwise);
				}
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, true, false);
		}

		// Token: 0x0603D334 RID: 250676 RVA: 0x011A97A8 File Offset: 0x011A79A8
		private void TriggerStartSelectedFreeAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed())
			{
				return;
			}
			if (this.ControllerConfig.Type != EControllerType.FreeAngle)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsSelected)
				{
					bool clockwise = this.ControllerConfig.RotationSpeed > 0;
					this.StartRingRotateByIndex(rotatingRing.Index, clockwise);
				}
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, true, false);
		}

		// Token: 0x0603D335 RID: 250677 RVA: 0x011A9850 File Offset: 0x011A7A50
		public void TriggerStopAllRingsRotate()
		{
			if (this.ControllerConfig.Type == EControllerType.FixedAngle)
			{
				this.TriggerStopAllFixedAngleRingsRotate();
				return;
			}
			this.TriggerStopAllFreeAngleRingsRotate();
		}

		// Token: 0x0603D336 RID: 250678 RVA: 0x011A9870 File Offset: 0x011A7A70
		private void TriggerStopAllFixedAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed() || !this.IsBusyRotating())
			{
				return;
			}
			if (this.ControllerConfig.Type != EControllerType.FixedAngle)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsRotating)
				{
					this.AddRingAngle(rotatingRing, -rotatingRing.AccumulateAngle);
				}
				this.StopRingsRotateByIndex(rotatingRing.Index);
			}
			if (this.UpdateAllRingsAtTarget(true))
			{
				this.RequestTurntableComplete();
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, false, this.IsAllRingsAtTarget());
		}

		// Token: 0x0603D337 RID: 250679 RVA: 0x011A9934 File Offset: 0x011A7B34
		private void TriggerStopAllFreeAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed() || !this.IsBusyRotating())
			{
				return;
			}
			if (this.ControllerConfig.Type != EControllerType.FreeAngle)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				this.StopRingsRotateByIndex(rotatingRing.Index);
			}
			if (this.UpdateAllRingsAtTarget(true))
			{
				this.RequestTurntableComplete();
			}
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, false, this.IsAllRingsAtTarget());
		}

		// Token: 0x0603D338 RID: 250680 RVA: 0x011A99E0 File Offset: 0x011A7BE0
		public void TriggerResetAllRingsToInitAngle(bool bForceReset = false)
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed() || this.IsBusyRotating())
			{
				return;
			}
			if (this.IsAllRingsAtTarget() && !bForceReset)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				ITurntableControlType controllerConfig = this.ControllerConfig;
				IFixedAngleTurntable fixedAngleTurntable = controllerConfig as IFixedAngleTurntable;
				if (fixedAngleTurntable == null)
				{
					IFreeAngleTurntable freeAngleTurntable = controllerConfig as IFreeAngleTurntable;
					if (freeAngleTurntable != null)
					{
						int initAngle = freeAngleTurntable.ItemConfig[rotatingRing.Index].InitAngle;
						this.SetRingAngle(rotatingRing, (float)initAngle);
					}
				}
				else
				{
					int initAngle2 = fixedAngleTurntable.ItemConfig[rotatingRing.Index].InitAngle;
					this.SetRingAngle(rotatingRing, (float)initAngle2);
				}
			}
			this.UpdateAllRingsAtTarget(true);
		}

		// Token: 0x0603D339 RID: 250681 RVA: 0x011A9AC0 File Offset: 0x011A7CC0
		private void TickFixedAngleRotate(float delta)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			IFixedAngleTurntable fixedAngleTurntable = this.ControllerConfig as IFixedAngleTurntable;
			if (fixedAngleTurntable == null)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsRotating)
				{
					float num = rotatingRing.CurSpeed * delta;
					float num2 = rotatingRing.AccumulateAngle + num;
					int rotateAngle = fixedAngleTurntable.ItemConfig[rotatingRing.Index].RotateAngle;
					if (Math.Abs(num2) >= (float)Math.Abs(rotateAngle))
					{
						bool flag = rotatingRing.CurSpeed > 0f;
						num -= num2 - (float)(Math.Abs(rotateAngle) * (flag ? 1 : -1));
						this.AddRingAngle(rotatingRing, num);
						rotatingRing.AccumulateAngle += num;
						this.StopRingsRotateByIndex(rotatingRing.Index);
						if (this.IsBusyRotating())
						{
							this.UpdateRingAtTarget(rotatingRing.Index, true);
						}
						else
						{
							if (this.UpdateAllRingsAtTarget(true))
							{
								this.RequestTurntableComplete();
							}
							EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, false, this.IsAllRingsAtTarget());
						}
					}
					else
					{
						this.AddRingAngle(rotatingRing, num);
						rotatingRing.AccumulateAngle += num;
						if (rotatingRing.IsAtTarget)
						{
							this.UpdateRingAtTarget(rotatingRing.Index, true);
						}
					}
				}
			}
		}

		// Token: 0x0603D33A RID: 250682 RVA: 0x011A9C3C File Offset: 0x011A7E3C
		private void TickFreeAngleRotate(float delta)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsRotating)
				{
					float deltaAngle = rotatingRing.CurSpeed * delta;
					this.AddRingAngle(rotatingRing, deltaAngle);
					if (rotatingRing.IsAtTarget)
					{
						this.UpdateRingAtTarget(rotatingRing.Index, true);
					}
				}
			}
		}

		// Token: 0x0603D33B RID: 250683 RVA: 0x011A9CC0 File Offset: 0x011A7EC0
		private void TickAngleCorrectionRotate(float delta)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (!rotatingRing.IsRotating && rotatingRing.IsAtTarget)
				{
					IFixedAngleTurntable fixedAngleTurntable = this.ControllerConfig as IFixedAngleTurntable;
					int targetAngle;
					if (fixedAngleTurntable != null)
					{
						targetAngle = fixedAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
					}
					else
					{
						IFreeAngleTurntable freeAngleTurntable = this.ControllerConfig as IFreeAngleTurntable;
						if (freeAngleTurntable == null)
						{
							continue;
						}
						targetAngle = freeAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
					}
					float num = this.AngleDiff(this.GetRingAngle(rotatingRing).Value, (float)targetAngle);
					if (!MathUtils.Instance.IsNearlyZero((double)num, null))
					{
						bool flag = num > 0f;
						int num2 = this.ControllerConfig.RotationSpeed / 1000;
						float deltaAngle = Math.Min(Math.Abs(num), Math.Abs((float)num2 * delta)) * (float)(flag ? 1 : -1);
						this.AddRingAngle(rotatingRing, deltaAngle);
					}
				}
			}
		}

		// Token: 0x0603D33C RID: 250684 RVA: 0x011A9E10 File Offset: 0x011A8010
		[NullableContext(1)]
		private float? GetRingAngle(SceneItemTurntableControllerComponent.RotatingRing ring)
		{
			AActor controllerRingActor = ring.ControllerRingActor;
			if (controllerRingActor != null && controllerRingActor.IsValid())
			{
				if (ring.RingRotator == null)
				{
					ring.RingRotator = global::Rotator.Create(ring.ControllerRingActor.RootComponent.D_GetRelativeTransform().Rotator());
				}
				return new float?(-ring.RingRotator.Pitch);
			}
			return null;
		}

		// Token: 0x0603D33D RID: 250685 RVA: 0x011A9E80 File Offset: 0x011A8080
		[NullableContext(1)]
		private void SetRingAngle(SceneItemTurntableControllerComponent.RotatingRing ring, float angle)
		{
			AActor controllerRingActor = ring.ControllerRingActor;
			if (controllerRingActor != null && controllerRingActor.IsValid())
			{
				if (ring.RingRotator == null)
				{
					ring.RingRotator = global::Rotator.Create();
				}
				ring.RingRotator.Pitch = -angle;
				ring.ControllerRingActor.RootComponent.K2_SetRelativeRotation(ring.RingRotator.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0603D33E RID: 250686 RVA: 0x011A9EE8 File Offset: 0x011A80E8
		[NullableContext(1)]
		private void AddRingAngle(SceneItemTurntableControllerComponent.RotatingRing ring, float deltaAngle)
		{
			AActor controllerRingActor = ring.ControllerRingActor;
			if (controllerRingActor != null && controllerRingActor.IsValid())
			{
				if (ring.RingRotator == null)
				{
					ring.RingRotator = global::Rotator.Create();
				}
				ring.RingRotator.Pitch -= deltaAngle;
				ring.ControllerRingActor.RootComponent.K2_SetRelativeRotation(ring.RingRotator.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0603D33F RID: 250687 RVA: 0x011A9F54 File Offset: 0x011A8154
		public bool UpdateAllRingsAtTarget(bool updateEffect)
		{
			bool result = true;
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (!this.UpdateRingAtTarget(rotatingRing.Index, false))
				{
					result = false;
				}
			}
			if (updateEffect)
			{
				this.UpdateAllRingsAtTargetEffect();
			}
			return result;
		}

		// Token: 0x0603D340 RID: 250688 RVA: 0x011A9FC0 File Offset: 0x011A81C0
		public bool UpdateRingAtTarget(int index, bool updateEffect)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return false;
			}
			if (!this.IsInitComplete)
			{
				return false;
			}
			if (rotatingRing.RingRotator != null)
			{
				float value = this.GetRingAngle(rotatingRing).Value;
				IFixedAngleTurntable fixedAngleTurntable = this.ControllerConfig as IFixedAngleTurntable;
				int targetAngle;
				int num;
				if (fixedAngleTurntable != null)
				{
					targetAngle = fixedAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
					num = 1;
				}
				else
				{
					IFreeAngleTurntable freeAngleTurntable = this.ControllerConfig as IFreeAngleTurntable;
					if (freeAngleTurntable == null)
					{
						return false;
					}
					targetAngle = freeAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle;
					num = freeAngleTurntable.IntervalAngle;
				}
				if (Math.Abs(this.AngleDiff(value, (float)targetAngle)) <= (float)num)
				{
					rotatingRing.IsAtTarget = true;
				}
				else
				{
					rotatingRing.IsAtTarget = false;
				}
				if (updateEffect)
				{
					this.UpdateRingAtTargetEffectByIndex(rotatingRing.Index);
				}
				return rotatingRing.IsAtTarget;
			}
			return false;
		}

		// Token: 0x0603D341 RID: 250689 RVA: 0x011AA0A0 File Offset: 0x011A82A0
		public bool IsBusyRotating()
		{
			using (List<SceneItemTurntableControllerComponent.RotatingRing>.Enumerator enumerator = this.RotatingRings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsRotating)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603D342 RID: 250690 RVA: 0x011AA0FC File Offset: 0x011A82FC
		public bool IsRingRotatingByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsRotating;
		}

		// Token: 0x0603D343 RID: 250691 RVA: 0x011AA12C File Offset: 0x011A832C
		public int? GetRingsNum()
		{
			List<SceneItemTurntableControllerComponent.RotatingRing> rotatingRings = this.RotatingRings;
			if (rotatingRings == null)
			{
				return null;
			}
			return new int?(rotatingRings.Count);
		}

		// Token: 0x0603D344 RID: 250692 RVA: 0x011AA157 File Offset: 0x011A8357
		public EControllerType GetControlType()
		{
			return this.ControllerConfig.Type;
		}

		// Token: 0x0603D345 RID: 250693 RVA: 0x011AA164 File Offset: 0x011A8364
		public bool IsAllRingsAtTarget()
		{
			using (List<SceneItemTurntableControllerComponent.RotatingRing>.Enumerator enumerator = this.RotatingRings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsAtTarget)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603D346 RID: 250694 RVA: 0x011AA1C0 File Offset: 0x011A83C0
		public bool IsRingAtTargetByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsAtTarget;
		}

		// Token: 0x0603D347 RID: 250695 RVA: 0x011AA1F0 File Offset: 0x011A83F0
		public bool IsRingSelectedByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsSelected;
		}

		// Token: 0x0603D348 RID: 250696 RVA: 0x011AA220 File Offset: 0x011A8420
		public void UpdateAllRingsAtTargetEffect()
		{
			if (this.TagComponent == null)
			{
				return;
			}
			LevelTagComponent tagComponent = this.TagComponent;
			long notifyLock = tagComponent.NotifyLock;
			tagComponent.NotifyLock = notifyLock + 1L;
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsAtTarget)
				{
					int atTargetTagByIndex = this.GetAtTargetTagByIndex(rotatingRing.Index);
					if (!this.TagComponent.HasTag(atTargetTagByIndex))
					{
						this.TagComponent.AddTag(new int?(atTargetTagByIndex));
					}
				}
				else
				{
					int atTargetTagByIndex2 = this.GetAtTargetTagByIndex(rotatingRing.Index);
					if (this.TagComponent.HasTag(atTargetTagByIndex2))
					{
						this.TagComponent.RemoveTag(new int?(atTargetTagByIndex2));
					}
				}
			}
			LevelTagComponent tagComponent2 = this.TagComponent;
			notifyLock = tagComponent2.NotifyLock;
			tagComponent2.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x0603D349 RID: 250697 RVA: 0x011AA308 File Offset: 0x011A8508
		public void UpdateRingAtTargetEffectByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			if (!this.IsInitComplete)
			{
				return;
			}
			if (rotatingRing.IsAtTarget)
			{
				int atTargetTagByIndex = this.GetAtTargetTagByIndex(rotatingRing.Index);
				LevelTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null || !tagComponent.HasTag(atTargetTagByIndex))
				{
					LevelTagComponent tagComponent2 = this.TagComponent;
					if (tagComponent2 == null)
					{
						return;
					}
					tagComponent2.AddTag(new int?(atTargetTagByIndex));
					return;
				}
			}
			else
			{
				int atTargetTagByIndex2 = this.GetAtTargetTagByIndex(rotatingRing.Index);
				LevelTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 != null && tagComponent3.HasTag(atTargetTagByIndex2))
				{
					LevelTagComponent tagComponent4 = this.TagComponent;
					if (tagComponent4 == null)
					{
						return;
					}
					tagComponent4.RemoveTag(new int?(atTargetTagByIndex2));
				}
			}
		}

		// Token: 0x0603D34A RID: 250698 RVA: 0x011AA3AC File Offset: 0x011A85AC
		public void UpdateAllRingsSelectedEffect()
		{
			if (this.TagComponent == null)
			{
				return;
			}
			LevelTagComponent tagComponent = this.TagComponent;
			long notifyLock = tagComponent.NotifyLock;
			tagComponent.NotifyLock = notifyLock + 1L;
			foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
			{
				if (rotatingRing.IsSelected)
				{
					int selectedTagByIndex = this.GetSelectedTagByIndex(rotatingRing.Index);
					if (!this.TagComponent.HasTag(selectedTagByIndex))
					{
						this.TagComponent.AddTag(new int?(selectedTagByIndex));
					}
				}
				else
				{
					int selectedTagByIndex2 = this.GetSelectedTagByIndex(rotatingRing.Index);
					if (this.TagComponent.HasTag(selectedTagByIndex2))
					{
						this.TagComponent.RemoveTag(new int?(selectedTagByIndex2));
					}
				}
			}
			LevelTagComponent tagComponent2 = this.TagComponent;
			notifyLock = tagComponent2.NotifyLock;
			tagComponent2.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x0603D34B RID: 250699 RVA: 0x011AA494 File Offset: 0x011A8694
		public void UpdateRingSelectedEffectByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			if (!this.RotatingRings.TryGetValue(index, out rotatingRing))
			{
				return;
			}
			if (!this.IsInitComplete)
			{
				return;
			}
			if (rotatingRing.IsSelected)
			{
				int selectedTagByIndex = this.GetSelectedTagByIndex(rotatingRing.Index);
				if (!this.TagComponent.HasTag(selectedTagByIndex))
				{
					this.TagComponent.AddTag(new int?(selectedTagByIndex));
					return;
				}
			}
			else
			{
				int selectedTagByIndex2 = this.GetSelectedTagByIndex(rotatingRing.Index);
				if (this.TagComponent.HasTag(selectedTagByIndex2))
				{
					this.TagComponent.RemoveTag(new int?(selectedTagByIndex2));
				}
			}
		}

		// Token: 0x0603D34C RID: 250700 RVA: 0x011AA520 File Offset: 0x011A8720
		public void SetAllowRotate(bool allow)
		{
			if (allow && !this.GetRotateAllowed())
			{
				base.Enable(this.DisableHandle, "SceneItemTurntableControllerComponent.SetAllowRotate");
				this.DisableHandle = null;
				return;
			}
			if (!allow && this.GetRotateAllowed())
			{
				this.DisableHandle = new int?(base.Disable("稷廷开门主控机关: 旋转被禁止，禁用组件"));
			}
		}

		// Token: 0x0603D34D RID: 250701 RVA: 0x011AA578 File Offset: 0x011A8778
		public bool GetRotateAllowed()
		{
			return this.DisableHandle == null;
		}

		// Token: 0x0603D34E RID: 250702 RVA: 0x011AA588 File Offset: 0x011A8788
		private void HandleUpdateState(int stateId, bool isReady)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			if (stateId == GameplayTagDefine.EGameplayTagId["关卡.Common.状态.完成"])
			{
				this.SetAllowRotate(false);
				foreach (SceneItemTurntableControllerComponent.RotatingRing rotatingRing in this.RotatingRings)
				{
					IFreeAngleTurntable freeAngleTurntable = this.ControllerConfig as IFreeAngleTurntable;
					int? num;
					if (freeAngleTurntable != null)
					{
						num = new int?(freeAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle);
					}
					else
					{
						IFixedAngleTurntable fixedAngleTurntable = this.ControllerConfig as IFixedAngleTurntable;
						if (fixedAngleTurntable == null)
						{
							continue;
						}
						num = new int?(fixedAngleTurntable.ItemConfig[rotatingRing.Index].TargetAngle);
					}
					if (!rotatingRing.IsAtTarget)
					{
						this.SetRingAngle(rotatingRing, (float)num.Value);
						this.UpdateRingAtTarget(rotatingRing.Index, false);
					}
				}
				this.UpdateAllRingsAtTargetEffect();
				if (isReady)
				{
					EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, false, false);
				}
			}
		}

		// Token: 0x0603D34F RID: 250703 RVA: 0x011AA6A4 File Offset: 0x011A88A4
		private void RequestTurntableComplete()
		{
			if (this.CreatureDataComponent == null)
			{
				return;
			}
			TurntableCompleteRequest turntableCompleteRequest = TurntableCompleteRequest.Create();
			turntableCompleteRequest.EntityId = this.CreatureDataComponent.GetCreatureDataId();
			Net.Instance.Call(ERequestMessageId.TurntableCompleteRequest, turntableCompleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TurntableCompleteResponse turntableCompleteResponse = (TurntableCompleteResponse)msg;
				if ((turntableCompleteResponse == null || turntableCompleteResponse.ErrCode > ErrorCode.Success) && (turntableCompleteResponse == null || turntableCompleteResponse.ErrCode != ErrorCode.ErrStateEntityStateNoChange))
				{
					if (this.IsInitComplete && this.GetRotateAllowed() && this.IsBusyRotating())
					{
						this.TriggerStopAllRingsRotate();
					}
					this.TriggerResetAllRingsToInitAngle(true);
					EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnTurntableControllerBusyStateChange, false, false);
				}
			}, 0);
		}

		// Token: 0x0603D350 RID: 250704 RVA: 0x011AA6EE File Offset: 0x011A88EE
		private float AngleDiff(float angle1, float angle2)
		{
			return this.AngleClamp(angle2 - angle1, -180f, 180f);
		}

		// Token: 0x0603D351 RID: 250705 RVA: 0x011AA704 File Offset: 0x011A8904
		private float AngleClamp(float angle, float min, float max)
		{
			float num;
			for (num = angle; num < min; num += 360f)
			{
			}
			while (num >= max)
			{
				num -= 360f;
			}
			return num;
		}

		// Token: 0x0603D352 RID: 250706 RVA: 0x011AA730 File Offset: 0x011A8930
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTurntableControllerComponent sceneItemTurntableControllerComponent = (SceneItemTurntableControllerComponent)componentTemplate;
			if (sceneItemTurntableControllerComponent.ControllerConfig == null)
			{
				this.ControllerConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ControllerConfig), "ControllerConfig"))
			{
				return false;
			}
			if (sceneItemTurntableControllerComponent.RotatingRings == null)
			{
				this.RotatingRings = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RotatingRings), "RotatingRings"))
			{
				return false;
			}
			this.DisableHandle = sceneItemTurntableControllerComponent.DisableHandle;
			if (sceneItemTurntableControllerComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (sceneItemTurntableControllerComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
			this.IsInitComplete = sceneItemTurntableControllerComponent.IsInitComplete;
			return true;
		}

		// Token: 0x170073E2 RID: 29666
		// (get) Token: 0x0603D353 RID: 250707 RVA: 0x011AA814 File Offset: 0x011A8A14
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073E3 RID: 29667
		// (get) Token: 0x0603D354 RID: 250708 RVA: 0x011AA817 File Offset: 0x011A8A17
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073E4 RID: 29668
		// (get) Token: 0x0603D355 RID: 250709 RVA: 0x011AA81A File Offset: 0x011A8A1A
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073E5 RID: 29669
		// (get) Token: 0x0603D356 RID: 250710 RVA: 0x011AA81D File Offset: 0x011A8A1D
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020750 RID: 132944
		private ITurntableControlType ControllerConfig;

		// Token: 0x04020751 RID: 132945
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SceneItemTurntableControllerComponent.RotatingRing> RotatingRings;

		// Token: 0x04020752 RID: 132946
		private int? DisableHandle;

		// Token: 0x04020753 RID: 132947
		private LevelTagComponent TagComponent;

		// Token: 0x04020754 RID: 132948
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04020755 RID: 132949
		private bool IsInitComplete;

		// Token: 0x0200BB0E RID: 47886
		[Nullable(0)]
		private class RotatingRing
		{
			// Token: 0x040398E3 RID: 235747
			public int Index;

			// Token: 0x040398E4 RID: 235748
			public AActor ControllerRingActor;

			// Token: 0x040398E5 RID: 235749
			public global::Rotator RingRotator;

			// Token: 0x040398E6 RID: 235750
			public float CurSpeed;

			// Token: 0x040398E7 RID: 235751
			public float AccumulateAngle;

			// Token: 0x040398E8 RID: 235752
			public bool IsSelected;

			// Token: 0x040398E9 RID: 235753
			public bool IsAtTarget;

			// Token: 0x040398EA RID: 235754
			public bool IsRotating;
		}
	}
}
