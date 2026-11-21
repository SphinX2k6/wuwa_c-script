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
	// Token: 0x02004C95 RID: 19605
	[NullableContext(2)]
	[Nullable(0)]
	public class AutoPilotTrackMark : UiPanelBase
	{
		// Token: 0x06030E98 RID: 200344 RVA: 0x00DA4CFC File Offset: 0x00DA2EFC
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

		// Token: 0x06030E99 RID: 200345 RVA: 0x00DA4DBF File Offset: 0x00DA2FBF
		[NullableContext(1)]
		public void Initialize(UUIItem parent)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_Mark_Prefab", parent, true).Forget();
		}

		// Token: 0x06030E9A RID: 200346 RVA: 0x00DA4DD4 File Offset: 0x00DA2FD4
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

		// Token: 0x06030E9B RID: 200347 RVA: 0x00DA4EC1 File Offset: 0x00DA30C1
		protected override void OnStart()
		{
			this.DistanceComp = base.GetItem(4);
			this.DirectionComp = base.GetItem(2);
			this.OnUiShow();
		}

		// Token: 0x06030E9C RID: 200348 RVA: 0x00DA4EE3 File Offset: 0x00DA30E3
		protected override void OnBeforeDestroy()
		{
			this.PointTransport = null;
			if (TimerSystem.Instance.Has(this.DelayTrackSequenceTimerId))
			{
				TimerSystem.Instance.Remove(this.DelayTrackSequenceTimerId);
			}
		}

		// Token: 0x06030E9D RID: 200349 RVA: 0x00DA4F0F File Offset: 0x00DA310F
		public void OnUiShow()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetRelativeScale3D(new FVector(1f, 1f, 1f));
		}

		// Token: 0x06030E9E RID: 200350 RVA: 0x00DA4F35 File Offset: 0x00DA3135
		public void OnUiHide()
		{
		}

		// Token: 0x06030E9F RID: 200351 RVA: 0x00DA4F38 File Offset: 0x00DA3138
		private void UpdateIcon()
		{
			if (!this.IsIconPathDirty)
			{
				return;
			}
			base.TrySetSpriteByPath(this.IconPath, base.GetSprite(0), false, null, null);
			this.IsIconPathDirty = false;
		}

		// Token: 0x06030EA0 RID: 200352 RVA: 0x00DA4F74 File Offset: 0x00DA3174
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

		// Token: 0x06030EA1 RID: 200353 RVA: 0x00DA501C File Offset: 0x00DA321C
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

		// Token: 0x06030EA2 RID: 200354 RVA: 0x00DA5074 File Offset: 0x00DA3274
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

		// Token: 0x06030EA3 RID: 200355 RVA: 0x00DA5228 File Offset: 0x00DA3428
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

		// Token: 0x06030EA4 RID: 200356 RVA: 0x00DA529C File Offset: 0x00DA349C
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

		// Token: 0x06030EA5 RID: 200357 RVA: 0x00DA530F File Offset: 0x00DA350F
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

		// Token: 0x04019F59 RID: 106329
		private readonly float LimitA;

		// Token: 0x04019F5A RID: 106330
		private readonly float LimitB;

		// Token: 0x04019F5B RID: 106331
		protected FVector2D ScreenPositionRef = new FVector2D();

		// Token: 0x04019F5C RID: 106332
		protected Vector2D PointTransport = Vector2D.Create(1.0, -1.0);

		// Token: 0x04019F5D RID: 106333
		private TimerHandle DelayTrackSequenceTimerId;

		// Token: 0x04019F5E RID: 106334
		[Nullable(1)]
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x04019F5F RID: 106335
		[Nullable(1)]
		protected readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x04019F60 RID: 106336
		protected bool InRange;

		// Token: 0x04019F61 RID: 106337
		private int TrackDistanceDisplay = -1;

		// Token: 0x04019F62 RID: 106338
		private UUIItem DistanceComp;

		// Token: 0x04019F63 RID: 106339
		protected UUIItem DirectionComp;

		// Token: 0x04019F64 RID: 106340
		private string IconPath;

		// Token: 0x04019F65 RID: 106341
		private bool IsIconPathDirty;

		// Token: 0x0200A892 RID: 43154
		[NullableContext(0)]
		private enum ETrackedMark
		{
			// Token: 0x04034125 RID: 213285
			Icon,
			// Token: 0x04034126 RID: 213286
			Distance,
			// Token: 0x04034127 RID: 213287
			Direction,
			// Token: 0x04034128 RID: 213288
			TrackedButton,
			// Token: 0x04034129 RID: 213289
			DistanceItem,
			// Token: 0x0403412A RID: 213290
			WaveNiagara,
			// Token: 0x0403412B RID: 213291
			PanelIcon
		}
	}
}
