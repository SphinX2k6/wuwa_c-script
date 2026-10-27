using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB3 RID: 23731
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackMark : UiPanelBase
	{
		// Token: 0x0603BF45 RID: 245573 RVA: 0x00E54654 File Offset: 0x00E52854
		public AutoPilotTrackMark()
		{
			if (GlobalData.World == null)
			{
				return;
			}
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		}

		// Token: 0x0603BF46 RID: 245574 RVA: 0x00E54717 File Offset: 0x00E52917
		[NullableContext(1)]
		public void Initialize(UUIItem parent)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_Mark_Prefab", parent, true).Forget();
		}

		// Token: 0x0603BF47 RID: 245575 RVA: 0x00E5472C File Offset: 0x00E5292C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BF48 RID: 245576 RVA: 0x00E54819 File Offset: 0x00E52A19
		protected override void OnStart()
		{
			this.DistanceComp = base.GetItem(4);
			this.DirectionComp = base.GetItem(2);
			this.OnUiShow();
		}

		// Token: 0x0603BF49 RID: 245577 RVA: 0x00E5483B File Offset: 0x00E52A3B
		protected override void OnBeforeDestroy()
		{
			this.PointTransport = null;
			if (TimerSystem.Instance.Has(this.DelayTrackSequenceTimerId))
			{
				TimerSystem.Instance.Remove(this.DelayTrackSequenceTimerId);
			}
		}

		// Token: 0x0603BF4A RID: 245578 RVA: 0x00E54867 File Offset: 0x00E52A67
		public void OnUiShow()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetRelativeScale3D(new FVector(1f, 1f, 1f));
		}

		// Token: 0x0603BF4B RID: 245579 RVA: 0x00E5488D File Offset: 0x00E52A8D
		public void OnUiHide()
		{
		}

		// Token: 0x0603BF4C RID: 245580 RVA: 0x00E54890 File Offset: 0x00E52A90
		private void UpdateIcon()
		{
			if (!this.IsIconPathDirty)
			{
				return;
			}
			base.TrySetSpriteByPath(this.IconPath, base.GetSprite(0), false, null, null);
			this.IsIconPathDirty = false;
		}

		// Token: 0x0603BF4D RID: 245581 RVA: 0x00E548CC File Offset: 0x00E52ACC
		private void UpdateTrackDistance()
		{
			AutoPilotFindPathResult findPathResult = AutoPilotModel.Instance.GetFindPathResult();
			if (findPathResult == null)
			{
				return;
			}
			Vector playerPoint = findPathResult.PlayerPoint;
			Vector trackingPoint = findPathResult.GetTrackingPoint();
			if (this.InRange && trackingPoint != null)
			{
				int num = (int)Math.Round(Vector.Distance(playerPoint, trackingPoint) * 0.009999999776482582);
				if (this.TrackDistanceDisplay != num)
				{
					this.TrackDistanceDisplay = num;
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_Meter_Text", new <>z__ReadOnlySingleElementList<object>(this.TrackDistanceDisplay.ToString()));
				}
				UUIItem distanceComp = this.DistanceComp;
				if (distanceComp == null)
				{
					return;
				}
				distanceComp.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem distanceComp2 = this.DistanceComp;
				if (distanceComp2 == null)
				{
					return;
				}
				distanceComp2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603BF4E RID: 245582 RVA: 0x00E54974 File Offset: 0x00E52B74
		public void Update(float delta)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (UiLayer.Instance.UiRootItem == null)
			{
				return;
			}
			if (this.RootItem == null)
			{
				return;
			}
			if (!this.IsShowTrackingMark())
			{
				this.SetRootItemState(false);
				return;
			}
			this.SetRootItemState(true);
			this.UpdatePositionAndRotation(delta);
			this.UpdateTrackDistance();
			this.UpdateIcon();
		}

		// Token: 0x0603BF4F RID: 245583 RVA: 0x00E549CC File Offset: 0x00E52BCC
		protected void UpdatePositionAndRotation(float delta)
		{
			AutoPilotFindPathResult findPathResult = AutoPilotModel.Instance.GetFindPathResult();
			Vector vector = (findPathResult != null) ? findPathResult.GetTrackingPoint() : null;
			if (vector == null)
			{
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			FVectorDouble fvectorDouble = vector.ToUeVector(false);
			bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ScreenPositionRef, false);
			if (!flag)
			{
				FTransformDouble value = CameraModel.Instance.MainModel.CameraTransform.Value;
				FVectorDouble fvectorDouble2 = value.InverseTransformPositionNoScale(fvectorDouble);
				fvectorDouble2.X = -fvectorDouble2.X;
				FVectorDouble fvectorDouble3 = value.TransformPositionNoScale(fvectorDouble2);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble3, ref this.ScreenPositionRef, false);
			}
			this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
			if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
			{
				this.LastScreenPosition.DeepCopy(this.ScreenPosition);
				BattleUiModel instance = BattleUiModel.Instance;
				this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
				this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
				Vector2D vector2D = this.ScreenPosition.AdditionEqual(TrackDefine.center);
				this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
				if (!this.InRange)
				{
					UUIItem directionComp = this.DirectionComp;
					FRotator frotator = new FRotator();
					frotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875);
					directionComp.SetUIRelativeRotation(frotator);
					this.DirectionComp.SetUIActive(true);
					return;
				}
				this.DirectionComp.SetUIActive(false);
			}
		}

		// Token: 0x0603BF50 RID: 245584 RVA: 0x00E54B80 File Offset: 0x00E52D80
		private bool IsShowTrackingMark()
		{
			AutoPilotModel instance = AutoPilotModel.Instance;
			AutoPilotFindPathResult autoPilotFindPathResult = (instance != null) ? instance.GetFindPathResult() : null;
			if (autoPilotFindPathResult == null)
			{
				return false;
			}
			if (autoPilotFindPathResult.MapId != MapModel.Instance.CurrentWorldMapConfigId || autoPilotFindPathResult.GetTrackingPoint() == null)
			{
				return false;
			}
			string text = autoPilotFindPathResult.GetIsShowStartPoint() ? AutoPilotDefine.STARTPOPINT_ICONPATH : AutoPilotDefine.ENDPOINT_ICONPATH;
			if (this.IconPath != text)
			{
				this.IconPath = text;
				this.IsIconPathDirty = true;
			}
			return true;
		}

		// Token: 0x0603BF51 RID: 245585 RVA: 0x00E54BF4 File Offset: 0x00E52DF4
		[NullableContext(1)]
		protected bool ClampToEllipse(Vector2D vector, bool inFront)
		{
			double x = vector.X;
			double y = vector.Y;
			float limitA = this.LimitA;
			float limitB = this.LimitB;
			if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
			{
				return true;
			}
			double num = (double)(limitA * limitB) / Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
			vector.MultiplyEqual((double)((float)num));
			return false;
		}

		// Token: 0x0603BF52 RID: 245586 RVA: 0x00E54C67 File Offset: 0x00E52E67
		private void SetRootItemState(bool bActive)
		{
			if (this.RootItem == null)
			{
				return;
			}
			if (this.RootItem.IsUIActiveSelf() == bActive)
			{
				return;
			}
			this.RootItem.SetUIActive(bActive);
		}

		// Token: 0x0401F4A0 RID: 128160
		private readonly float LimitA;

		// Token: 0x0401F4A1 RID: 128161
		private readonly float LimitB;

		// Token: 0x0401F4A2 RID: 128162
		protected FVector2D ScreenPositionRef = new FVector2D();

		// Token: 0x0401F4A3 RID: 128163
		protected Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x0401F4A4 RID: 128164
		private TimerHandle DelayTrackSequenceTimerId;

		// Token: 0x0401F4A5 RID: 128165
		[Nullable(1)]
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x0401F4A6 RID: 128166
		[Nullable(1)]
		protected readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x0401F4A7 RID: 128167
		protected bool InRange;

		// Token: 0x0401F4A8 RID: 128168
		private int TrackDistanceDisplay = -1;

		// Token: 0x0401F4A9 RID: 128169
		private UUIItem DistanceComp;

		// Token: 0x0401F4AA RID: 128170
		protected UUIItem DirectionComp;

		// Token: 0x0401F4AB RID: 128171
		private string IconPath;

		// Token: 0x0401F4AC RID: 128172
		private bool IsIconPathDirty;

		// Token: 0x0200BE8C RID: 48780
		[NullableContext(0)]
		private enum ETrackedMark
		{
			// Token: 0x04039764 RID: 235364
			Icon,
			// Token: 0x04039765 RID: 235365
			Distance,
			// Token: 0x04039766 RID: 235366
			Direction,
			// Token: 0x04039767 RID: 235367
			TrackedButton,
			// Token: 0x04039768 RID: 235368
			DistanceItem,
			// Token: 0x04039769 RID: 235369
			WaveNiagara,
			// Token: 0x0403976A RID: 235370
			PanelIcon
		}
	}
}
