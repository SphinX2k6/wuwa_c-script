using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x0200609B RID: 24731
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonMarkItem : UiPanelBase
	{
		// Token: 0x0603B52B RID: 242987 RVA: 0x010CA4C0 File Offset: 0x010C86C0
		[NullableContext(2)]
		public CommonMarkItem(in FVectorDouble targetPosition, Vector2D center = null)
		{
			this.TargetPosition = targetPosition;
			this.Center = (center ?? Vector2D.Create(0.0, 0.0));
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		}

		// Token: 0x0603B52C RID: 242988 RVA: 0x010CA5B7 File Offset: 0x010C87B7
		public Vector2D GetScreenPositionWithoutClamp([Nullable(2)] Vector2D inVector = null)
		{
			if (inVector != null)
			{
				inVector.DeepCopy(this.ScreenPositionWithoutClamp);
				return inVector;
			}
			return this.ScreenPositionWithoutClamp;
		}

		// Token: 0x0603B52D RID: 242989 RVA: 0x010CA5D0 File Offset: 0x010C87D0
		protected bool IsInRange()
		{
			return this.InRange;
		}

		// Token: 0x0603B52E RID: 242990 RVA: 0x010CA5D8 File Offset: 0x010C87D8
		protected virtual void InRangeStateChanged(bool bInRange, bool bFirst = false)
		{
		}

		// Token: 0x0603B52F RID: 242991 RVA: 0x010CA5DA File Offset: 0x010C87DA
		protected virtual void OnScreenPositionChanged(bool bInRange)
		{
		}

		// Token: 0x0603B530 RID: 242992 RVA: 0x010CA5DC File Offset: 0x010C87DC
		public virtual void OnTick(float delta)
		{
			this.UpdatePositionAndRotation();
		}

		// Token: 0x0603B531 RID: 242993 RVA: 0x010CA5E4 File Offset: 0x010C87E4
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

		// Token: 0x0603B532 RID: 242994 RVA: 0x010CA768 File Offset: 0x010C8968
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

		// Token: 0x0401F408 RID: 128008
		protected FVector2D ScreenPositionRef = new FVector2D(0f, 0f);

		// Token: 0x0401F409 RID: 128009
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x0401F40A RID: 128010
		protected readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x0401F40B RID: 128011
		private readonly Vector2D ScreenPositionWithoutClamp = Vector2D.Create();

		// Token: 0x0401F40C RID: 128012
		protected readonly Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x0401F40D RID: 128013
		private bool LastInRange;

		// Token: 0x0401F40E RID: 128014
		protected bool InRange;

		// Token: 0x0401F40F RID: 128015
		private readonly float LimitA;

		// Token: 0x0401F410 RID: 128016
		private readonly float LimitB;

		// Token: 0x0401F411 RID: 128017
		protected FVectorDouble TargetPosition;

		// Token: 0x0401F412 RID: 128018
		protected readonly Vector2D Center;
	}
}
