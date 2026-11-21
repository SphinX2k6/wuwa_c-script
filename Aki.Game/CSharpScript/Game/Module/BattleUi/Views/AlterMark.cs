using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C90 RID: 19600
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterMark : UiPanelBase
	{
		// Token: 0x06030E50 RID: 200272 RVA: 0x00DA2EC8 File Offset: 0x00DA10C8
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

		// Token: 0x06030E51 RID: 200273 RVA: 0x00DA2F54 File Offset: 0x00DA1154
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

		// Token: 0x06030E52 RID: 200274 RVA: 0x00DA2FFC File Offset: 0x00DA11FC
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

		// Token: 0x06030E53 RID: 200275 RVA: 0x00DA30FC File Offset: 0x00DA12FC
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

		// Token: 0x06030E54 RID: 200276 RVA: 0x00DA313C File Offset: 0x00DA133C
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

		// Token: 0x06030E55 RID: 200277 RVA: 0x00DA3230 File Offset: 0x00DA1430
		private FVectorDouble? GetCurTrackPosition()
		{
			if (!ObjectUtils.IsValid(this.TrackingActor))
			{
				return this.OriginalPosition;
			}
			return new FVectorDouble?(this.TrackingActor.D_K2_GetActorLocation());
		}

		// Token: 0x06030E56 RID: 200278 RVA: 0x00DA3256 File Offset: 0x00DA1456
		private FVectorDouble GetMonsterLocation(AActor monsterActor)
		{
			return monsterActor.D_K2_GetActorLocation();
		}

		// Token: 0x06030E57 RID: 200279 RVA: 0x00DA3260 File Offset: 0x00DA1460
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

		// Token: 0x06030E58 RID: 200280 RVA: 0x00DA32B8 File Offset: 0x00DA14B8
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

		// Token: 0x06030E59 RID: 200281 RVA: 0x00DA3344 File Offset: 0x00DA1544
		private float GetViewportSizeX()
		{
			int num = 0;
			int num2 = 0;
			this.PlayerController.GetViewportSize(ref num, ref num2);
			return (float)num;
		}

		// Token: 0x06030E5A RID: 200282 RVA: 0x00DA3368 File Offset: 0x00DA1568
		private FVector2D GetUiRootItemSize()
		{
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			return new FVector2D(uiRootItem.GetWidth(), uiRootItem.GetHeight());
		}

		// Token: 0x06030E5B RID: 200283 RVA: 0x00DA3394 File Offset: 0x00DA1594
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

		// Token: 0x06030E5C RID: 200284 RVA: 0x00DA33F0 File Offset: 0x00DA15F0
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

		// Token: 0x06030E5D RID: 200285 RVA: 0x00DA3490 File Offset: 0x00DA1690
		private Vector GetPlayerLocation()
		{
			FVectorDouble actorLocation = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseActorComponent>().ActorLocation;
			this.PlayerLocation.Set(actorLocation.X, actorLocation.Y, actorLocation.Z);
			return this.PlayerLocation;
		}

		// Token: 0x06030E5E RID: 200286 RVA: 0x00DA34DC File Offset: 0x00DA16DC
		private Vector GetMonsterToPlayerVector(Vector monsterLocation)
		{
			Vector playerLocation = this.GetPlayerLocation();
			monsterLocation.Subtraction(playerLocation, this.MonsterToPlayerVector);
			return this.MonsterToPlayerVector;
		}

		// Token: 0x06030E5F RID: 200287 RVA: 0x00DA3504 File Offset: 0x00DA1704
		private FVectorDouble GetCameraForwardVector()
		{
			return this.PlayerCameraManager.GetCameraRotation().VectorDouble();
		}

		// Token: 0x06030E60 RID: 200288 RVA: 0x00DA3524 File Offset: 0x00DA1724
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

		// Token: 0x04019F28 RID: 106280
		private const int MAX_ALERT = 100;

		// Token: 0x04019F29 RID: 106281
		private const float START_FILL_AMOUNT = 0.5f;

		// Token: 0x04019F2A RID: 106282
		private const string NORMAL_COLOR = "B7E6E7FF";

		// Token: 0x04019F2B RID: 106283
		private const string WARNING_COLOR = "EDDC4DFF";

		// Token: 0x04019F2C RID: 106284
		private const string ERROR_COLOR = "F01D1BFF";

		// Token: 0x04019F2D RID: 106285
		private FVectorDouble? OriginalPosition;

		// Token: 0x04019F2E RID: 106286
		[Nullable(2)]
		private AActor TrackingActor;

		// Token: 0x04019F2F RID: 106287
		private readonly float LimitA;

		// Token: 0x04019F30 RID: 106288
		private readonly float LimitB;

		// Token: 0x04019F31 RID: 106289
		private readonly Vector TempTrackPosition = Vector.Create();

		// Token: 0x04019F32 RID: 106290
		[Nullable(2)]
		private UUISprite RightSprite;

		// Token: 0x04019F33 RID: 106291
		[Nullable(2)]
		private UUISprite LeftSprite;

		// Token: 0x04019F34 RID: 106292
		[Nullable(2)]
		private UUIItem Mark;

		// Token: 0x04019F35 RID: 106293
		[Nullable(2)]
		private APlayerController PlayerController;

		// Token: 0x04019F36 RID: 106294
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x04019F37 RID: 106295
		private readonly Vector PlayerLocation = Vector.Create();

		// Token: 0x04019F38 RID: 106296
		private readonly Vector MonsterToPlayerVector = Vector.Create();

		// Token: 0x04019F39 RID: 106297
		[Nullable(2)]
		private APlayerCameraManager PlayerCameraManager;

		// Token: 0x04019F3A RID: 106298
		[Nullable(2)]
		private Vector ProjectScreenLocation = Vector.Create();

		// Token: 0x04019F3B RID: 106299
		private AlterMark.EAlterLevel AlterLevel;

		// Token: 0x0200A88C RID: 43148
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04034112 RID: 213266
			UIContainerRoot,
			// Token: 0x04034113 RID: 213267
			UIContainerRight,
			// Token: 0x04034114 RID: 213268
			UIContainerLeft
		}

		// Token: 0x0200A88D RID: 43149
		[NullableContext(0)]
		private enum EAlterLevel
		{
			// Token: 0x04034116 RID: 213270
			Normal,
			// Token: 0x04034117 RID: 213271
			Warning = 50,
			// Token: 0x04034118 RID: 213272
			Error = 80
		}
	}
}
