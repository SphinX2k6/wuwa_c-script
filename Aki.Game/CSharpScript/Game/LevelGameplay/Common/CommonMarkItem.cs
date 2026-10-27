using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x02006F1A RID: 28442
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonMarkItem : UiPanelBase
	{
		// Token: 0x0604537D RID: 283517 RVA: 0x01120520 File Offset: 0x0111E720
		[NullableContext(2)]
		public CommonMarkItem(in FVectorDouble targetPosition, Vector2D center = null)
		{
			this.TargetPosition = targetPosition;
			this.Center = (center ?? Vector2D.Create(0.0, 0.0));
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		}

		// Token: 0x0604537E RID: 283518 RVA: 0x01120617 File Offset: 0x0111E817
		public Vector2D GetScreenPositionWithoutClamp([Nullable(2)] Vector2D inVector = null)
		{
			if (inVector != null)
			{
				inVector.DeepCopy(this.ScreenPositionWithoutClamp);
				return inVector;
			}
			return this.ScreenPositionWithoutClamp;
		}

		// Token: 0x0604537F RID: 283519 RVA: 0x01120630 File Offset: 0x0111E830
		protected bool IsInRange()
		{
			return this.InRange;
		}

		// Token: 0x06045380 RID: 283520 RVA: 0x01120638 File Offset: 0x0111E838
		protected virtual void InRangeStateChanged(bool bInRange, bool bFirst = false)
		{
		}

		// Token: 0x06045381 RID: 283521 RVA: 0x0112063A File Offset: 0x0111E83A
		protected virtual void OnScreenPositionChanged(bool bInRange)
		{
		}

		// Token: 0x06045382 RID: 283522 RVA: 0x0112063C File Offset: 0x0111E83C
		public virtual void OnTick(float delta)
		{
			this.UpdatePositionAndRotation();
		}

		// Token: 0x06045383 RID: 283523 RVA: 0x01120644 File Offset: 0x0111E844
		protected void UpdatePositionAndRotation()
		{
			FVectorDouble targetPosition = this.TargetPosition;
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return;
			}
			bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, this.TargetPosition, ref this.ScreenPositionRef, false);
			if (!flag)
			{
				FTransformDouble value = CameraModel.Instance.MainModel.CameraTransform.Value;
				FVectorDouble fvectorDouble = value.InverseTransformPositionNoScale(this.TargetPosition);
				fvectorDouble.X = -fvectorDouble.X;
				FVectorDouble fvectorDouble2 = value.TransformPositionNoScale(fvectorDouble);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble2, ref this.ScreenPositionRef, false);
			}
			this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
			if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
			{
				this.LastScreenPosition.DeepCopy(this.ScreenPosition);
				BattleUiModel instance = BattleUiModel.Instance;
				this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
				this.ScreenPositionWithoutClamp.DeepCopy(this.ScreenPosition);
				this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
				if (this.InRange != this.LastInRange)
				{
					this.InRangeStateChanged(this.InRange, false);
				}
				this.LastInRange = this.InRange;
				Vector2D vector2D = this.ScreenPosition.AdditionEqual(this.Center);
				this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
				this.OnScreenPositionChanged(this.InRange);
			}
		}

		// Token: 0x06045384 RID: 283524 RVA: 0x011207C8 File Offset: 0x0111E9C8
		protected virtual bool ClampToEllipse(Vector2D vector, bool inFront)
		{
			double x = vector.X;
			double y = vector.Y;
			float limitA = this.LimitA;
			float limitB = this.LimitB;
			if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
			{
				return true;
			}
			double inB = (double)(limitA * limitB) / Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
			vector.MultiplyEqual(inB);
			return false;
		}

		// Token: 0x04024153 RID: 147795
		protected FVector2D ScreenPositionRef = new FVector2D(0f, 0f);

		// Token: 0x04024154 RID: 147796
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x04024155 RID: 147797
		protected readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x04024156 RID: 147798
		private readonly Vector2D ScreenPositionWithoutClamp = Vector2D.Create();

		// Token: 0x04024157 RID: 147799
		protected readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x04024158 RID: 147800
		private bool LastInRange;

		// Token: 0x04024159 RID: 147801
		protected bool InRange;

		// Token: 0x0402415A RID: 147802
		private readonly float LimitA;

		// Token: 0x0402415B RID: 147803
		private readonly float LimitB;

		// Token: 0x0402415C RID: 147804
		protected FVectorDouble TargetPosition;

		// Token: 0x0402415D RID: 147805
		protected readonly Vector2D Center;
	}
}
