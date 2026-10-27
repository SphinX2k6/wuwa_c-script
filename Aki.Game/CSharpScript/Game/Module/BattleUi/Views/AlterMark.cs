using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CAE RID: 23726
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterMark : UiPanelBase
	{
		// Token: 0x0603BEFD RID: 245501 RVA: 0x00E52820 File Offset: 0x00E50A20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BEFE RID: 245502 RVA: 0x00E528AC File Offset: 0x00E50AAC
		protected override void OnStart()
		{
			this.Mark = base.GetItem(0);
			this.RightSprite = base.GetSprite(1);
			this.LeftSprite = base.GetSprite(2);
			this.LeftSprite.SetFillAmount(0f);
			this.RightSprite.SetFillAmount(0f);
			this.LeftSprite.SetColor(FColor.FromHex("B7E6E7FF"));
			this.RightSprite.SetColor(FColor.FromHex("B7E6E7FF"));
			base.GetItem(0).SetUIActive(false);
			base.GetSprite(1).SetUIActive(false);
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x0603BEFF RID: 245503 RVA: 0x00E52954 File Offset: 0x00E50B54
		[NullableContext(2)]
		public AlterMark([Nullable(1)] UUIItem parent, Vector originPosition = null, AActor trackActor = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			base.CreateThenShowByResourceIdAsync("UiItem_SneakItem_Prefab", parent, false).Forget();
			this.OriginalPosition = new FVectorDouble?((originPosition != null) ? originPosition.ToUeVector(false) : new FVectorDouble());
			this.TrackingActor = trackActor;
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
			this.PlayerController = Global.CharacterController;
			this.PlayerCameraManager = Global.CharacterCameraManager;
		}

		// Token: 0x0603BF00 RID: 245504 RVA: 0x00E52A54 File Offset: 0x00E50C54
		protected override void OnBeforeDestroy()
		{
			this.OriginalPosition = null;
			this.TrackingActor = null;
			this.RightSprite = null;
			this.LeftSprite = null;
			this.Mark = null;
			this.PlayerController = null;
			this.PlayerCameraManager = null;
			this.ProjectScreenLocation = null;
		}

		// Token: 0x0603BF01 RID: 245505 RVA: 0x00E52A94 File Offset: 0x00E50C94
		public void Update()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (this.RootItem == null)
			{
				return;
			}
			if (GeneralLogicTreeUtil.Instance.GetPlayerLocation() == null)
			{
				this.RootItem.SetUIActive(false);
			}
			FVectorDouble value = this.GetCurTrackPosition().Value;
			this.TempTrackPosition.Set(value.X, value.Y, value.Z);
			this.RootItem.SetUIActive(true);
			this.Mark.SetUIActive(true);
			this.RightSprite.SetUIActive(true);
			this.LeftSprite.SetUIActive(true);
			FVectorDouble monsterLocation = this.GetMonsterLocation(this.TrackingActor);
			FVector2D inEllipsePosition = this.GetInEllipsePosition(monsterLocation);
			UUIItem rootItem = this.RootItem;
			FRotator frotator = new FRotator(0f, (float)(Math.Atan2((double)inEllipsePosition.Y, (double)inEllipsePosition.X) * 57.2957763671875 - 90.0), 0f);
			rootItem.SetUIRelativeRotation(frotator);
			this.AlertValueUpdate();
		}

		// Token: 0x0603BF02 RID: 245506 RVA: 0x00E52B88 File Offset: 0x00E50D88
		private FVectorDouble? GetCurTrackPosition()
		{
			if (!ObjectUtils.IsValid(this.TrackingActor))
			{
				return this.OriginalPosition;
			}
			return new FVectorDouble?(this.TrackingActor.D_K2_GetActorLocation());
		}

		// Token: 0x0603BF03 RID: 245507 RVA: 0x00E52BAE File Offset: 0x00E50DAE
		private FVectorDouble GetMonsterLocation(AActor monsterActor)
		{
			return monsterActor.D_K2_GetActorLocation();
		}

		// Token: 0x0603BF04 RID: 245508 RVA: 0x00E52BB8 File Offset: 0x00E50DB8
		private FVector2D GetInEllipsePosition(in FVectorDouble monsterLocation)
		{
			FVector2D screenPosition = new FVector2D();
			if (UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, monsterLocation, ref screenPosition, false))
			{
				return this.ScreenPositionToEllipsePosition(screenPosition, true);
			}
			Vector projectionToFrontPosition = this.GetProjectionToFrontPosition(monsterLocation);
			APlayerController playerController = this.PlayerController;
			FVectorDouble fvectorDouble = projectionToFrontPosition.ToUeVector(false);
			UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref screenPosition, false);
			return this.ScreenPositionToEllipsePosition(screenPosition, false);
		}

		// Token: 0x0603BF05 RID: 245509 RVA: 0x00E52C10 File Offset: 0x00E50E10
		private FVector2D ScreenPositionToEllipsePosition(FVector2D screenPosition, bool isInScreen)
		{
			float viewportSizeX = this.GetViewportSizeX();
			FVector2D uiRootItemSize = this.GetUiRootItemSize();
			FVector2D fvector2D = screenPosition * (uiRootItemSize.X / viewportSizeX);
			FVector2D fvector2D2 = uiRootItemSize * 0.5f;
			FVector2D fvector2D3 = fvector2D - fvector2D2;
			FVector2D fvector2D4 = new FVector2D(1f, -1f);
			FVector2D vector = fvector2D3 * fvector2D4;
			FVector2D fvector2D5 = this.ClampToEllipse(vector, this.LimitA, this.LimitB, isInScreen);
			fvector2D = TrackDefine.center.ToUeVector2D(false);
			return fvector2D5 + fvector2D;
		}

		// Token: 0x0603BF06 RID: 245510 RVA: 0x00E52C9C File Offset: 0x00E50E9C
		private float GetViewportSizeX()
		{
			int num = 0;
			int num2 = 0;
			this.PlayerController.GetViewportSize(ref num, ref num2);
			return (float)num;
		}

		// Token: 0x0603BF07 RID: 245511 RVA: 0x00E52CC0 File Offset: 0x00E50EC0
		private FVector2D GetUiRootItemSize()
		{
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			return new FVector2D(uiRootItem.GetWidth(), uiRootItem.GetHeight());
		}

		// Token: 0x0603BF08 RID: 245512 RVA: 0x00E52CEC File Offset: 0x00E50EEC
		private FVector2D ClampToEllipse(FVector2D vector, float majorAxis, float minorAxis, bool isInScreen)
		{
			float x = vector.X;
			float y = vector.Y;
			if (isInScreen && x * x / (majorAxis * majorAxis) + y * y / (minorAxis * minorAxis) <= 1f)
			{
				return vector;
			}
			double num = (double)(majorAxis * minorAxis) / Math.Sqrt((double)(minorAxis * minorAxis * x * x + majorAxis * majorAxis * y * y));
			return vector * (float)num;
		}

		// Token: 0x0603BF09 RID: 245513 RVA: 0x00E52D48 File Offset: 0x00E50F48
		private Vector GetProjectionToFrontPosition(in FVectorDouble targetLocation)
		{
			this.TargetLocation.Set(targetLocation.X, targetLocation.Y, targetLocation.Z);
			Vector playerLocation = this.GetPlayerLocation();
			Vector monsterToPlayerVector = this.GetMonsterToPlayerVector(this.TargetLocation);
			FVectorDouble cameraForwardVector = this.GetCameraForwardVector();
			FVectorDouble fvectorDouble = UKismetMathLibrary.D_ProjectVectorOnToVector(monsterToPlayerVector.ToUeVector(false), cameraForwardVector);
			FVectorDouble fvectorDouble2 = fvectorDouble * 2.0;
			this.ProjectScreenLocation.Set(fvectorDouble2.X, fvectorDouble2.Y, fvectorDouble2.Z);
			monsterToPlayerVector.SubtractionEqual(this.ProjectScreenLocation);
			playerLocation.Addition(monsterToPlayerVector, this.TargetLocation);
			return this.TargetLocation;
		}

		// Token: 0x0603BF0A RID: 245514 RVA: 0x00E52DE8 File Offset: 0x00E50FE8
		private Vector GetPlayerLocation()
		{
			FVectorDouble actorLocation = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseActorComponent>().ActorLocation;
			this.PlayerLocation.Set(actorLocation.X, actorLocation.Y, actorLocation.Z);
			return this.PlayerLocation;
		}

		// Token: 0x0603BF0B RID: 245515 RVA: 0x00E52E34 File Offset: 0x00E51034
		private Vector GetMonsterToPlayerVector(Vector monsterLocation)
		{
			Vector playerLocation = this.GetPlayerLocation();
			monsterLocation.Subtraction(playerLocation, this.MonsterToPlayerVector);
			return this.MonsterToPlayerVector;
		}

		// Token: 0x0603BF0C RID: 245516 RVA: 0x00E52E5C File Offset: 0x00E5105C
		private FVectorDouble GetCameraForwardVector()
		{
			return this.PlayerCameraManager.GetCameraRotation().VectorDouble();
		}

		// Token: 0x0603BF0D RID: 245517 RVA: 0x00E52E7C File Offset: 0x00E5107C
		private void AlertValueUpdate()
		{
			float alertValue = ActorUtils.GetEntityByActor(this.TrackingActor, true).Entity.GetComponent<CharacterAiComponent>().AiController.AiAlert.AlertValue;
			this.LeftSprite.SetFillAmount(0.5f + alertValue / 100f / 2f);
			this.RightSprite.SetFillAmount(0.5f + alertValue / 100f / 2f);
			if (alertValue < 50f)
			{
				if (this.AlterLevel == AlterMark.EAlterLevel.Normal)
				{
					return;
				}
				this.AlterLevel = AlterMark.EAlterLevel.Normal;
				this.LeftSprite.SetColor(FColor.FromHex("B7E6E7FF"));
				this.RightSprite.SetColor(FColor.FromHex("B7E6E7FF"));
				return;
			}
			else if (alertValue < 80f)
			{
				if (this.AlterLevel == AlterMark.EAlterLevel.Warning)
				{
					return;
				}
				this.AlterLevel = AlterMark.EAlterLevel.Warning;
				this.LeftSprite.SetColor(FColor.FromHex("EDDC4DFF"));
				this.RightSprite.SetColor(FColor.FromHex("EDDC4DFF"));
				return;
			}
			else
			{
				if (this.AlterLevel == AlterMark.EAlterLevel.Error)
				{
					return;
				}
				this.AlterLevel = AlterMark.EAlterLevel.Error;
				this.LeftSprite.SetColor(FColor.FromHex("F01D1BFF"));
				this.RightSprite.SetColor(FColor.FromHex("F01D1BFF"));
				return;
			}
		}

		// Token: 0x0401F46F RID: 128111
		private const int MAX_ALERT = 100;

		// Token: 0x0401F470 RID: 128112
		private const float START_FILL_AMOUNT = 0.5f;

		// Token: 0x0401F471 RID: 128113
		private const string NORMAL_COLOR = "B7E6E7FF";

		// Token: 0x0401F472 RID: 128114
		private const string WARNING_COLOR = "EDDC4DFF";

		// Token: 0x0401F473 RID: 128115
		private const string ERROR_COLOR = "F01D1BFF";

		// Token: 0x0401F474 RID: 128116
		private FVectorDouble? OriginalPosition;

		// Token: 0x0401F475 RID: 128117
		[Nullable(2)]
		private AActor TrackingActor;

		// Token: 0x0401F476 RID: 128118
		private readonly float LimitA;

		// Token: 0x0401F477 RID: 128119
		private readonly float LimitB;

		// Token: 0x0401F478 RID: 128120
		private readonly Vector TempTrackPosition = Vector.Create();

		// Token: 0x0401F479 RID: 128121
		[Nullable(2)]
		private UUISprite RightSprite;

		// Token: 0x0401F47A RID: 128122
		[Nullable(2)]
		private UUISprite LeftSprite;

		// Token: 0x0401F47B RID: 128123
		[Nullable(2)]
		private UUIItem Mark;

		// Token: 0x0401F47C RID: 128124
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x0401F47D RID: 128125
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x0401F47E RID: 128126
		private readonly Vector PlayerLocation = Vector.Create();

		// Token: 0x0401F47F RID: 128127
		private readonly Vector MonsterToPlayerVector = Vector.Create();

		// Token: 0x0401F480 RID: 128128
		[Nullable(2)]
		private APlayerCameraManager PlayerCameraManager;

		// Token: 0x0401F481 RID: 128129
		[Nullable(2)]
		private Vector ProjectScreenLocation = Vector.Create();

		// Token: 0x0401F482 RID: 128130
		private AlterMark.EAlterLevel AlterLevel;

		// Token: 0x0200BE86 RID: 48774
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04039751 RID: 235345
			UIContainerRoot,
			// Token: 0x04039752 RID: 235346
			UIContainerRight,
			// Token: 0x04039753 RID: 235347
			UIContainerLeft
		}

		// Token: 0x0200BE87 RID: 48775
		[NullableContext(0)]
		private enum EAlterLevel
		{
			// Token: 0x04039755 RID: 235349
			Normal,
			// Token: 0x04039756 RID: 235350
			Warning = 50,
			// Token: 0x04039757 RID: 235351
			Error = 80
		}
	}
}
