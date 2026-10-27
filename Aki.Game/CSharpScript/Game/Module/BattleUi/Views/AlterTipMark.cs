using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB1 RID: 23729
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterTipMark : UiPanelBase
	{
		// Token: 0x0603BF36 RID: 245558 RVA: 0x00E5419C File Offset: 0x00E5239C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BF37 RID: 245559 RVA: 0x00E54205 File Offset: 0x00E52405
		protected override void OnStart()
		{
			this.WarningItem = base.GetItem(0);
			this.ErrorItem = base.GetItem(1);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x0603BF38 RID: 245560 RVA: 0x00E5423C File Offset: 0x00E5243C
		public AlterTipMark(UUIItem parent, AActor trackActor, bool isBattle)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			base.CreateThenShowByResourceIdAsync("UiItem_SneakTip", parent, false).Forget();
			this.TrackingActor = trackActor;
			this.IsBattle = isBattle;
		}

		// Token: 0x0603BF39 RID: 245561 RVA: 0x00E542D6 File Offset: 0x00E524D6
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
			this.PositionUpdate();
			if (!this.IsBattle)
			{
				this.AlertValueUpdate();
			}
		}

		// Token: 0x0603BF3A RID: 245562 RVA: 0x00E54300 File Offset: 0x00E52500
		private void PositionUpdate()
		{
			if (this.TrackingActor == null)
			{
				return;
			}
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			TsCharacterController characterController = Global.CharacterController;
			FVectorDouble fvectorDouble = this.TrackingActor.D_K2_GetActorLocation();
			this.TempTrackPosition.Set(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
			FVector2D fvector2D = new FVector2D();
			if (!UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref fvector2D, false))
			{
				this.TempTrackPosition.Subtraction(playerLocation, this.Offset);
				Rotator.Create(Global.CharacterCameraManager.GetCameraRotation()).Vector(this.CameraForward);
				FVectorDouble fvectorDouble2 = UKismetMathLibrary.D_ProjectVectorOnToVector(this.Offset.ToUeVector(false), this.CameraForward.ToUeVector(false));
				FVectorDouble fvectorDouble3 = fvectorDouble2 * 2.0;
				this.ProjectResult.Set(fvectorDouble3.X, fvectorDouble3.Y, fvectorDouble3.Z);
				this.Offset.SubtractionEqual(this.ProjectResult);
				playerLocation.Addition(this.Offset, this.TempTrackPosition);
				APlayerController player = characterController;
				fvectorDouble2 = this.TempTrackPosition.ToUeVector(false);
				UGameplayStatics.D_ProjectWorldToScreen(player, fvectorDouble2, ref fvector2D, false);
			}
			int num = 0;
			int num2 = 0;
			characterController.GetViewportSize(ref num, ref num2);
			this.ScreenPosition.Set((double)fvector2D.X, (double)fvector2D.Y);
			this.ViewportSize.Set((double)(uiRootItem.GetWidth() * 0.5f), (double)(uiRootItem.GetHeight() * 0.5f));
			this.ScreenPosition.MultiplyEqual((double)(uiRootItem.GetWidth() / (float)num)).SubtractionEqual(this.ViewportSize).MultiplyEqual(this.PointTransport);
			Vector2D vector2D = this.ScreenPosition.AdditionEqual(TrackDefine.center);
			float x = (float)Vector.Distance(playerLocation, this.TempTrackPosition);
			vector2D.AdditionEqual(Vector2D.Create(0.0, (double)this.GetOffsetY(x)));
			this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}

		// Token: 0x0603BF3B RID: 245563 RVA: 0x00E54504 File Offset: 0x00E52704
		private void AlertValueUpdate()
		{
			float alertValue = ActorUtils.GetEntityByActor(this.TrackingActor, true).Entity.GetComponent<CharacterAiComponent>().AiController.AiAlert.AlertValue;
			if (alertValue > 0f)
			{
				if (this.AlterLevel > 0.0)
				{
					return;
				}
				this.WarningItem.SetUIActive(true);
				this.ErrorItem.SetUIActive(false);
			}
			else
			{
				this.WarningItem.SetUIActive(false);
				this.ErrorItem.SetUIActive(false);
			}
			this.AlterLevel = (double)alertValue;
		}

		// Token: 0x0603BF3C RID: 245564 RVA: 0x00E5458B File Offset: 0x00E5278B
		private float GetOffsetY(float x)
		{
			return 6E-05f * x * x - 0.2f * x + 275f;
		}

		// Token: 0x0603BF3D RID: 245565 RVA: 0x00E545A4 File Offset: 0x00E527A4
		public void ChangeToError()
		{
			UUIItem warningItem = this.WarningItem;
			if (warningItem != null)
			{
				warningItem.SetUIActive(false);
			}
			UUIItem errorItem = this.ErrorItem;
			if (errorItem == null)
			{
				return;
			}
			errorItem.SetUIActive(true);
		}

		// Token: 0x0401F493 RID: 128147
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x0401F494 RID: 128148
		private readonly Vector TempTrackPosition = Vector.Create();

		// Token: 0x0401F495 RID: 128149
		private readonly Vector Offset = Vector.Create();

		// Token: 0x0401F496 RID: 128150
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x0401F497 RID: 128151
		private readonly Vector ProjectResult = Vector.Create();

		// Token: 0x0401F498 RID: 128152
		private readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x0401F499 RID: 128153
		private readonly Vector2D ViewportSize = Vector2D.Create();

		// Token: 0x0401F49A RID: 128154
		private readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x0401F49B RID: 128155
		private double AlterLevel;

		// Token: 0x0401F49C RID: 128156
		[Nullable(2)]
		private UUIItem ErrorItem;

		// Token: 0x0401F49D RID: 128157
		[Nullable(2)]
		private UUIItem WarningItem;

		// Token: 0x0401F49E RID: 128158
		private readonly bool IsBattle;

		// Token: 0x0200BE8B RID: 48779
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04039761 RID: 235361
			UITipsWarning,
			// Token: 0x04039762 RID: 235362
			UITipError
		}
	}
}
