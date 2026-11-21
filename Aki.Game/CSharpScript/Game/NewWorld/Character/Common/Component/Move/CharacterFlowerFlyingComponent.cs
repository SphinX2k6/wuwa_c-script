using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x02006388 RID: 25480
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterFlowerFlyingComponent : EntityComponent
	{
		// Token: 0x0603DBAC RID: 252844 RVA: 0x011E307C File Offset: 0x011E127C
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
			this.MoveComponent = base.Entity.CheckGetComponent<CharacterMoveComponent>();
			this.TagComponent = base.Entity.GetComponent<BaseTagComponent>();
			this.InputComponent = base.Entity.GetComponent<CharacterInputComponent>();
			CharacterMoveComponent moveComponent = this.MoveComponent;
			object obj;
			if (moveComponent == null)
			{
				obj = null;
			}
			else
			{
				UCharacterMovementComponent characterMovement = moveComponent.CharacterMovement;
				obj = ((characterMovement != null) ? characterMovement.KuroRegisterCustomMovementExtension(19, UKuroCustomMovementFlowerFlying.StaticClass(), false) : null);
			}
			this.FlowerFlyingExtension = (obj as UKuroCustomMovementFlowerFlying);
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnMovementModeChanged));
			this.RefreshSelfEnable();
			this.DisableRelatedComponents();
			return true;
		}

		// Token: 0x0603DBAD RID: 252845 RVA: 0x011E3132 File Offset: 0x011E1332
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnMovementModeChanged));
			this.EnableRelatedComponents();
			this.ActorComp = null;
			this.MoveComponent = null;
			this.TagComponent = null;
			return true;
		}

		// Token: 0x0603DBAE RID: 252846 RVA: 0x011E3174 File Offset: 0x011E1374
		protected override void OnActivate()
		{
			CharacterConfigComponent component = base.Entity.GetComponent<CharacterConfigComponent>();
			if (component != null && this.FlowerFlyingExtension != null)
			{
				string customMovementDataTablePath = this.GetCustomMovementDataTablePath();
				if (customMovementDataTablePath == null)
				{
					Log.Instance.Error(ELogModule.Movement, ELogAuthor.LJM, "[CharacterFlowerFlyingComponent] CustomMovementDataTable 无效，跳过配置注册", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				component.RegisterConfig(this.FlowerFlyingExtension.FlowerFlyingConfigHelper, this.FlowerFlyingExtension, customMovementDataTablePath, null);
			}
		}

		// Token: 0x0603DBAF RID: 252847 RVA: 0x011E31D8 File Offset: 0x011E13D8
		[NullableContext(2)]
		private string GetCustomMovementDataTablePath()
		{
			CharacterMoveComponent moveComponent = this.MoveComponent;
			TSoftObjectPtr<UDataTable> tsoftObjectPtr;
			if (moveComponent == null)
			{
				tsoftObjectPtr = null;
			}
			else
			{
				SMovementSetting_State defaultMovementDataReadonly = moveComponent.DefaultMovementDataReadonly;
				tsoftObjectPtr = ((defaultMovementDataReadonly != null) ? defaultMovementDataReadonly.CustomMovementDTMap.GetValueOrDefault(EKuroCustomMovementMode.FlowerFlying) : null);
			}
			TSoftObjectPtr<UDataTable> tsoftObjectPtr2 = tsoftObjectPtr;
			if (tsoftObjectPtr2 == null)
			{
				return null;
			}
			return tsoftObjectPtr2.ToAssetPathName();
		}

		// Token: 0x0603DBB0 RID: 252848 RVA: 0x011E321C File Offset: 0x011E141C
		protected override void OnEnable()
		{
			this.RefreshInput();
		}

		// Token: 0x0603DBB1 RID: 252849 RVA: 0x011E3224 File Offset: 0x011E1424
		protected override void OnTick(float deltaTime)
		{
			this.RefreshInput();
		}

		// Token: 0x0603DBB2 RID: 252850 RVA: 0x011E322C File Offset: 0x011E142C
		private void RefreshInput()
		{
			if (this.FlowerFlyingExtension == null)
			{
				return;
			}
			FVectorDouble fvectorDouble;
			FVector fvector;
			if (this.IsInFocusMode() && !this.HasInput())
			{
				this.RefreshFocusInput();
				UKuroCustomMovementFlowerFlying flowerFlyingExtension = this.FlowerFlyingExtension;
				fvectorDouble = this.focusInput.ToUeVector(false);
				fvector = fvectorDouble;
				flowerFlyingExtension.SetDirectionInput(fvector, true);
				return;
			}
			UKuroCustomMovementFlowerFlying flowerFlyingExtension2 = this.FlowerFlyingExtension;
			fvectorDouble = this.ActorComp.InputDirectProxy.ToUeVector(false);
			fvector = fvectorDouble;
			flowerFlyingExtension2.SetDirectionInput(fvector, false);
		}

		// Token: 0x0603DBB3 RID: 252851 RVA: 0x011E32A4 File Offset: 0x011E14A4
		private bool HasInput()
		{
			FVector2D inputDeadZone = this.FlowerFlyingExtension.LocationParams.InputDeadZone;
			Vector inputDirectProxy = this.ActorComp.InputDirectProxy;
			return Math.Abs(inputDirectProxy.X) > (double)inputDeadZone.X || Math.Abs(inputDirectProxy.Y) > (double)inputDeadZone.Y;
		}

		// Token: 0x0603DBB4 RID: 252852 RVA: 0x011E32F8 File Offset: 0x011E14F8
		private bool IsInFocusMode()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			return tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.花瓣飞行.专注模式"]);
		}

		// Token: 0x0603DBB5 RID: 252853 RVA: 0x011E331C File Offset: 0x011E151C
		private void RefreshFocusInput()
		{
			CameraController.Instance.GetCameraRotation(this.cameraRotator, "MainCamera");
			this.cameraRotator.Vector(this.cameraForwardWorld);
			this.ActorComp.ActorQuatProxy.UnRotateVector(this.cameraForwardWorld, this.cameraForwardRelative);
			Vector vector = this.cameraForwardRelative;
			double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(vector);
			double num = Math.Atan2(vector.Z, Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y)) * 57.295780181884766;
			FVector2D cameraPitchDeadZone = this.FlowerFlyingExtension.FocusParams.CameraPitchDeadZone;
			double inX = (num >= (double)cameraPitchDeadZone.X && num <= (double)cameraPitchDeadZone.Y) ? 0.0 : MathUtils.Instance.Clamp((num - (double)this.FlowerFlyingExtension.GetTargetPitchFirst()) / 30.0, -1.0, 1.0);
			double inY = MathUtils.Instance.Clamp(angleByVector2D / 90.0, -1.0, 1.0);
			this.focusInput.Set(inX, inY, 0.0);
		}

		// Token: 0x0603DBB6 RID: 252854 RVA: 0x011E3464 File Offset: 0x011E1664
		private void OnMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
		{
			this.RefreshSelfEnable();
		}

		// Token: 0x0603DBB7 RID: 252855 RVA: 0x011E346C File Offset: 0x011E166C
		private bool IsOwnMode()
		{
			CharacterMoveComponent moveComponent = this.MoveComponent;
			UCharacterMovementComponent ucharacterMovementComponent = (moveComponent != null) ? moveComponent.CharacterMovement : null;
			return ucharacterMovementComponent != null && ucharacterMovementComponent.MovementMode == EMovementMode.MOVE_Custom && ucharacterMovementComponent.CustomMovementMode == 19;
		}

		// Token: 0x0603DBB8 RID: 252856 RVA: 0x011E34B0 File Offset: 0x011E16B0
		private void RefreshSelfEnable()
		{
			bool flag = this.IsOwnMode();
			bool flag2 = this.selfDisableHandle != null;
			if (flag && flag2)
			{
				base.Enable(this.selfDisableHandle, "CharacterFlowerFlyingComponent自身进入喷射飞行模式");
				this.selfDisableHandle = null;
				return;
			}
			if (!flag && !flag2)
			{
				this.selfDisableHandle = new int?(base.Disable("CharacterFlowerFlyingComponent自身离开喷射飞行模式"));
			}
		}

		// Token: 0x0603DBB9 RID: 252857 RVA: 0x011E3510 File Offset: 0x011E1710
		private void DisableRelatedComponents()
		{
			foreach (Type type in CharacterFlowerFlyingComponent.DisabledComponents)
			{
				EntityComponent component = base.Entity.GetComponent(type);
				int? num = (component != null) ? new int?(component.Disable("CharacterFlowerFlyingComponent")) : null;
				if (num != null)
				{
					this.disableHandles[type] = num.Value;
				}
			}
		}

		// Token: 0x0603DBBA RID: 252858 RVA: 0x011E3580 File Offset: 0x011E1780
		private void EnableRelatedComponents()
		{
			foreach (KeyValuePair<Type, int> keyValuePair in this.disableHandles)
			{
				Type type;
				int num;
				keyValuePair.Deconstruct(out type, out num);
				Type componentType = type;
				int value = num;
				EntityComponent component = base.Entity.GetComponent(componentType);
				if (component != null)
				{
					component.Enable(new int?(value), "CharacterFlowerFlyingComponent");
				}
			}
			this.disableHandles.Clear();
		}

		// Token: 0x0603DBBB RID: 252859 RVA: 0x011E360C File Offset: 0x011E180C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterFlowerFlyingComponent characterFlowerFlyingComponent = (CharacterFlowerFlyingComponent)componentTemplate;
			if (characterFlowerFlyingComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterFlowerFlyingComponent.MoveComponent == null)
			{
				this.MoveComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComponent), "MoveComponent"))
			{
				return false;
			}
			if (characterFlowerFlyingComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (characterFlowerFlyingComponent.InputComponent == null)
			{
				this.InputComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComponent), "InputComponent"))
			{
				return false;
			}
			if (characterFlowerFlyingComponent.FlowerFlyingExtension == null)
			{
				this.FlowerFlyingExtension = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FlowerFlyingExtension), "FlowerFlyingExtension"))
			{
				return false;
			}
			this.selfDisableHandle = characterFlowerFlyingComponent.selfDisableHandle;
			return (characterFlowerFlyingComponent.cameraRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.cameraRotator), "cameraRotator")) && (characterFlowerFlyingComponent.cameraForwardWorld == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.cameraForwardWorld), "cameraForwardWorld")) && (characterFlowerFlyingComponent.cameraForwardRelative == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.cameraForwardRelative), "cameraForwardRelative")) && (characterFlowerFlyingComponent.focusInput == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.focusInput), "focusInput")) && (characterFlowerFlyingComponent.disableHandles == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.disableHandles), "disableHandles"));
		}

		// Token: 0x17007524 RID: 29988
		// (get) Token: 0x0603DBBC RID: 252860 RVA: 0x011E37B9 File Offset: 0x011E19B9
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007525 RID: 29989
		// (get) Token: 0x0603DBBD RID: 252861 RVA: 0x011E37BC File Offset: 0x011E19BC
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007526 RID: 29990
		// (get) Token: 0x0603DBBE RID: 252862 RVA: 0x011E37BF File Offset: 0x011E19BF
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007527 RID: 29991
		// (get) Token: 0x0603DBBF RID: 252863 RVA: 0x011E37C2 File Offset: 0x011E19C2
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007528 RID: 29992
		// (get) Token: 0x0603DBC0 RID: 252864 RVA: 0x011E37C5 File Offset: 0x011E19C5
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020BAE RID: 134062
		private const int FOCUS_PITCH_LIMIT = 30;

		// Token: 0x04020BAF RID: 134063
		private const int FOCUS_YAW_LIMIT = 90;

		// Token: 0x04020BB0 RID: 134064
		[Nullable(2)]
		protected CharacterActorComponent ActorComp;

		// Token: 0x04020BB1 RID: 134065
		[Nullable(2)]
		protected CharacterMoveComponent MoveComponent;

		// Token: 0x04020BB2 RID: 134066
		[Nullable(2)]
		protected BaseTagComponent TagComponent;

		// Token: 0x04020BB3 RID: 134067
		[Nullable(2)]
		protected CharacterInputComponent InputComponent;

		// Token: 0x04020BB4 RID: 134068
		[Nullable(2)]
		public UKuroCustomMovementFlowerFlying FlowerFlyingExtension;

		// Token: 0x04020BB5 RID: 134069
		private int? selfDisableHandle;

		// Token: 0x04020BB6 RID: 134070
		private readonly Rotator cameraRotator = new Rotator();

		// Token: 0x04020BB7 RID: 134071
		private readonly Vector cameraForwardWorld = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04020BB8 RID: 134072
		private readonly Vector cameraForwardRelative = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04020BB9 RID: 134073
		private readonly Vector focusInput = Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x04020BBA RID: 134074
		[StaticVariableRuleIgnore]
		private static readonly Type[] DisabledComponents = new Type[]
		{
			typeof(CharacterSwimComponent),
			typeof(CharacterWalkOnWaterComponent),
			typeof(CharacterClimbComponent),
			typeof(CharacterGlideComponent),
			typeof(CharacterSlideComponent)
		};

		// Token: 0x04020BBB RID: 134075
		private readonly Dictionary<Type, int> disableHandles = new Dictionary<Type, int>();
	}
}
