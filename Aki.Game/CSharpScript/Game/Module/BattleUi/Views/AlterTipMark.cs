using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C93 RID: 19603
	[NullableContext(1)]
	[Nullable(0)]
	public class AlterTipMark : UiPanelBase
	{
		// Token: 0x06030E89 RID: 200329 RVA: 0x00DA4844 File Offset: 0x00DA2A44
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

		// Token: 0x06030E8A RID: 200330 RVA: 0x00DA48AD File Offset: 0x00DA2AAD
		protected override void OnStart()
		{
			this.WarningItem = base.GetItem(0);
			this.ErrorItem = base.GetItem(1);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(false);
		}

		// Token: 0x06030E8B RID: 200331 RVA: 0x00DA48E4 File Offset: 0x00DA2AE4
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

		// Token: 0x06030E8C RID: 200332 RVA: 0x00DA497E File Offset: 0x00DA2B7E
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

		// Token: 0x06030E8D RID: 200333 RVA: 0x00DA49A8 File Offset: 0x00DA2BA8
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

		// Token: 0x06030E8E RID: 200334 RVA: 0x00DA4BAC File Offset: 0x00DA2DAC
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

		// Token: 0x06030E8F RID: 200335 RVA: 0x00DA4C33 File Offset: 0x00DA2E33
		private float GetOffsetY(float x)
		{
			return 6E-05f * x * x - 0.2f * x + 275f;
		}

		// Token: 0x06030E90 RID: 200336 RVA: 0x00DA4C4C File Offset: 0x00DA2E4C
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

		// Token: 0x04019F4C RID: 106316
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x04019F4D RID: 106317
		private readonly Vector TempTrackPosition = Vector.Create();

		// Token: 0x04019F4E RID: 106318
		private readonly Vector Offset = Vector.Create();

		// Token: 0x04019F4F RID: 106319
		private readonly Vector CameraForward = Vector.Create();

		// Token: 0x04019F50 RID: 106320
		private readonly Vector ProjectResult = Vector.Create();

		// Token: 0x04019F51 RID: 106321
		private readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x04019F52 RID: 106322
		private readonly Vector2D ViewportSize = Vector2D.Create();

		// Token: 0x04019F53 RID: 106323
		private readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x04019F54 RID: 106324
		private double AlterLevel;

		// Token: 0x04019F55 RID: 106325
		[Nullable(2)]
		private UUIItem ErrorItem;

		// Token: 0x04019F56 RID: 106326
		[Nullable(2)]
		private UUIItem WarningItem;

		// Token: 0x04019F57 RID: 106327
		private readonly bool IsBattle;

		// Token: 0x0200A891 RID: 43153
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04034122 RID: 213282
			UITipsWarning,
			// Token: 0x04034123 RID: 213283
			UITipError
		}
	}
}
