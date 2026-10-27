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
	// Token: 0x02007228 RID: 29224
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTurntableControllerComponent : EntityComponent
	{
		// Token: 0x060479D0 RID: 293328 RVA: 0x01250150 File Offset: 0x0124E350
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

		// Token: 0x060479D1 RID: 293329 RVA: 0x012502B0 File Offset: 0x0124E4B0
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

		// Token: 0x060479D2 RID: 293330 RVA: 0x01250324 File Offset: 0x0124E524
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

		// Token: 0x060479D3 RID: 293331 RVA: 0x012503CD File Offset: 0x0124E5CD
		protected override void OnTick(float delta)
		{
			if (!this.IsInitComplete)
			{
				return;
			}
			if (this.GetControlType() == Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
			{
				this.TickFixedAngleRotate(delta);
			}
			else
			{
				this.TickFreeAngleRotate(delta);
			}
			this.TickAngleCorrectionRotate(delta);
		}

		// Token: 0x060479D4 RID: 293332 RVA: 0x012503F8 File Offset: 0x0124E5F8
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

		// Token: 0x060479D5 RID: 293333 RVA: 0x01250490 File Offset: 0x0124E690
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

		// Token: 0x060479D6 RID: 293334 RVA: 0x0125050C File Offset: 0x0124E70C
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

		// Token: 0x060479D7 RID: 293335 RVA: 0x01250610 File Offset: 0x0124E810
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

		// Token: 0x060479D8 RID: 293336 RVA: 0x01250730 File Offset: 0x0124E930
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

		// Token: 0x060479D9 RID: 293337 RVA: 0x0125078C File Offset: 0x0124E98C
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

		// Token: 0x060479DA RID: 293338 RVA: 0x012507C0 File Offset: 0x0124E9C0
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

		// Token: 0x060479DB RID: 293339 RVA: 0x012507F4 File Offset: 0x0124E9F4
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

		// Token: 0x060479DC RID: 293340 RVA: 0x01250848 File Offset: 0x0124EA48
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

		// Token: 0x060479DD RID: 293341 RVA: 0x0125089C File Offset: 0x0124EA9C
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

		// Token: 0x060479DE RID: 293342 RVA: 0x01250914 File Offset: 0x0124EB14
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

		// Token: 0x060479DF RID: 293343 RVA: 0x01250960 File Offset: 0x0124EB60
		public void TriggerStartSelectedRingsRotate()
		{
			if (this.ControllerConfig.Type == Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
			{
				this.TriggerStartSelectedFixedAngleRingsRotate();
				return;
			}
			this.TriggerStartSelectedFreeAngleRingsRotate();
		}

		// Token: 0x060479E0 RID: 293344 RVA: 0x01250980 File Offset: 0x0124EB80
		private void TriggerStartSelectedFixedAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed())
			{
				return;
			}
			if (this.ControllerConfig.Type != Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
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

		// Token: 0x060479E1 RID: 293345 RVA: 0x01250A28 File Offset: 0x0124EC28
		private void TriggerStartSelectedFreeAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed())
			{
				return;
			}
			if (this.ControllerConfig.Type != Aki.TDConfigMgr.Component.EControllerType.FreeAngle)
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

		// Token: 0x060479E2 RID: 293346 RVA: 0x01250AD0 File Offset: 0x0124ECD0
		public void TriggerStopAllRingsRotate()
		{
			if (this.ControllerConfig.Type == Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
			{
				this.TriggerStopAllFixedAngleRingsRotate();
				return;
			}
			this.TriggerStopAllFreeAngleRingsRotate();
		}

		// Token: 0x060479E3 RID: 293347 RVA: 0x01250AF0 File Offset: 0x0124ECF0
		private void TriggerStopAllFixedAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed() || !this.IsBusyRotating())
			{
				return;
			}
			if (this.ControllerConfig.Type != Aki.TDConfigMgr.Component.EControllerType.FixedAngle)
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

		// Token: 0x060479E4 RID: 293348 RVA: 0x01250BB4 File Offset: 0x0124EDB4
		private void TriggerStopAllFreeAngleRingsRotate()
		{
			if (!this.IsInitComplete || !this.GetRotateAllowed() || !this.IsBusyRotating())
			{
				return;
			}
			if (this.ControllerConfig.Type != Aki.TDConfigMgr.Component.EControllerType.FreeAngle)
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

		// Token: 0x060479E5 RID: 293349 RVA: 0x01250C60 File Offset: 0x0124EE60
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

		// Token: 0x060479E6 RID: 293350 RVA: 0x01250D40 File Offset: 0x0124EF40
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

		// Token: 0x060479E7 RID: 293351 RVA: 0x01250EBC File Offset: 0x0124F0BC
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

		// Token: 0x060479E8 RID: 293352 RVA: 0x01250F40 File Offset: 0x0124F140
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

		// Token: 0x060479E9 RID: 293353 RVA: 0x01251090 File Offset: 0x0124F290
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

		// Token: 0x060479EA RID: 293354 RVA: 0x01251100 File Offset: 0x0124F300
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

		// Token: 0x060479EB RID: 293355 RVA: 0x01251168 File Offset: 0x0124F368
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

		// Token: 0x060479EC RID: 293356 RVA: 0x012511D4 File Offset: 0x0124F3D4
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

		// Token: 0x060479ED RID: 293357 RVA: 0x01251240 File Offset: 0x0124F440
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

		// Token: 0x060479EE RID: 293358 RVA: 0x01251320 File Offset: 0x0124F520
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

		// Token: 0x060479EF RID: 293359 RVA: 0x0125137C File Offset: 0x0124F57C
		public bool IsRingRotatingByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsRotating;
		}

		// Token: 0x060479F0 RID: 293360 RVA: 0x012513AC File Offset: 0x0124F5AC
		public int? GetRingsNum()
		{
			List<SceneItemTurntableControllerComponent.RotatingRing> rotatingRings = this.RotatingRings;
			if (rotatingRings == null)
			{
				return null;
			}
			return new int?(rotatingRings.Count);
		}

		// Token: 0x060479F1 RID: 293361 RVA: 0x012513D7 File Offset: 0x0124F5D7
		public Aki.TDConfigMgr.Component.EControllerType GetControlType()
		{
			return this.ControllerConfig.Type;
		}

		// Token: 0x060479F2 RID: 293362 RVA: 0x012513E4 File Offset: 0x0124F5E4
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

		// Token: 0x060479F3 RID: 293363 RVA: 0x01251440 File Offset: 0x0124F640
		public bool IsRingAtTargetByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsAtTarget;
		}

		// Token: 0x060479F4 RID: 293364 RVA: 0x01251470 File Offset: 0x0124F670
		public bool IsRingSelectedByIndex(int index)
		{
			SceneItemTurntableControllerComponent.RotatingRing rotatingRing;
			return this.RotatingRings.TryGetValue(index, out rotatingRing) && this.IsInitComplete && rotatingRing.IsSelected;
		}

		// Token: 0x060479F5 RID: 293365 RVA: 0x012514A0 File Offset: 0x0124F6A0
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

		// Token: 0x060479F6 RID: 293366 RVA: 0x01251588 File Offset: 0x0124F788
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

		// Token: 0x060479F7 RID: 293367 RVA: 0x0125162C File Offset: 0x0124F82C
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

		// Token: 0x060479F8 RID: 293368 RVA: 0x01251714 File Offset: 0x0124F914
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

		// Token: 0x060479F9 RID: 293369 RVA: 0x012517A0 File Offset: 0x0124F9A0
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

		// Token: 0x060479FA RID: 293370 RVA: 0x012517F8 File Offset: 0x0124F9F8
		public bool GetRotateAllowed()
		{
			return this.DisableHandle == null;
		}

		// Token: 0x060479FB RID: 293371 RVA: 0x01251808 File Offset: 0x0124FA08
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

		// Token: 0x060479FC RID: 293372 RVA: 0x01251924 File Offset: 0x0124FB24
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

		// Token: 0x060479FD RID: 293373 RVA: 0x0125196E File Offset: 0x0124FB6E
		private float AngleDiff(float angle1, float angle2)
		{
			return this.AngleClamp(angle2 - angle1, -180f, 180f);
		}

		// Token: 0x060479FE RID: 293374 RVA: 0x01251984 File Offset: 0x0124FB84
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

		// Token: 0x060479FF RID: 293375 RVA: 0x012519B0 File Offset: 0x0124FBB0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTurntableControllerComponent sceneItemTurntableControllerComponent = (SceneItemTurntableControllerComponent)componentTemplate;
			if (base.CanResetComponentProperty("ControllerConfig"))
			{
				if (sceneItemTurntableControllerComponent.ControllerConfig == null)
				{
					this.ControllerConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITurntableControlType>(this.ControllerConfig), "ControllerConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RotatingRings"))
			{
				if (sceneItemTurntableControllerComponent.RotatingRings == null)
				{
					this.RotatingRings = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<SceneItemTurntableControllerComponent.RotatingRing>>(this.RotatingRings), "RotatingRings"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = sceneItemTurntableControllerComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("TagComponent"))
			{
				if (sceneItemTurntableControllerComponent.TagComponent == null)
				{
					this.TagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComponent), "TagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComponent"))
			{
				if (sceneItemTurntableControllerComponent.CreatureDataComponent == null)
				{
					this.CreatureDataComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInitComplete"))
			{
				this.IsInitComplete = sceneItemTurntableControllerComponent.IsInitComplete;
			}
			return true;
		}

		// Token: 0x04025AE1 RID: 154337
		private ITurntableControlType ControllerConfig;

		// Token: 0x04025AE2 RID: 154338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SceneItemTurntableControllerComponent.RotatingRing> RotatingRings;

		// Token: 0x04025AE3 RID: 154339
		private int? DisableHandle;

		// Token: 0x04025AE4 RID: 154340
		private LevelTagComponent TagComponent;

		// Token: 0x04025AE5 RID: 154341
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04025AE6 RID: 154342
		private bool IsInitComplete;

		// Token: 0x0200CF79 RID: 53113
		[Nullable(0)]
		private class RotatingRing
		{
			// Token: 0x0403E5BD RID: 255421
			public int Index;

			// Token: 0x0403E5BE RID: 255422
			public AActor ControllerRingActor;

			// Token: 0x0403E5BF RID: 255423
			public global::Rotator RingRotator;

			// Token: 0x0403E5C0 RID: 255424
			public float CurSpeed;

			// Token: 0x0403E5C1 RID: 255425
			public float AccumulateAngle;

			// Token: 0x0403E5C2 RID: 255426
			public bool IsSelected;

			// Token: 0x0403E5C3 RID: 255427
			public bool IsAtTarget;

			// Token: 0x0403E5C4 RID: 255428
			public bool IsRotating;
		}
	}
}
