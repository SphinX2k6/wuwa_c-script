using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D65 RID: 23909
	[NullableContext(2)]
	[Nullable(0)]
	public class MiniMapView : BattleVisibleChildView
	{
		// Token: 0x0603CB40 RID: 248640 RVA: 0x00E9322B File Offset: 0x00E9142B
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			this.IsInitFinished = false;
		}

		// Token: 0x0603CB41 RID: 248641 RVA: 0x00E93244 File Offset: 0x00E91444
		protected override UniTask InitializeAsync(object param = null)
		{
			MiniMapView.<InitializeAsync>d__15 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<MiniMapView.<InitializeAsync>d__15>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CB42 RID: 248642 RVA: 0x00E93287 File Offset: 0x00E91487
		public override void Reset()
		{
			this.MiniMap.Destroy(null);
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
				this.TimerId = null;
			}
			base.Reset();
		}

		// Token: 0x0603CB43 RID: 248643 RVA: 0x00E932BC File Offset: 0x00E914BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OpenMapView));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CB44 RID: 248644 RVA: 0x00E933A4 File Offset: 0x00E915A4
		private void OpenMapView()
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, true, null, null);
		}

		// Token: 0x0603CB45 RID: 248645 RVA: 0x00E933B4 File Offset: 0x00E915B4
		public void RefreshShow()
		{
			if (!this.IsInitFinished)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			if (component == null)
			{
				return;
			}
			UUIItem item = base.GetItem(1);
			UUIItem sprite = base.GetSprite(2);
			int num = 90;
			float num2 = -(component.ActorRotationProxy.Yaw + (float)num);
			if (Math.Abs(this.TempPlayerRotator.Yaw - num2) > 10f)
			{
				this.TempPlayerRotator.Yaw = num2;
				item.SetUIRelativeRotation(this.TempPlayerRotator);
			}
			float desiredYaw = -(CameraModel.Instance.MainModel.CameraRotator.Yaw + (float)num);
			this.TempSightRotator.Yaw = this.ClampCameraYaw(desiredYaw);
			sprite.SetUIRelativeRotation(this.TempSightRotator);
		}

		// Token: 0x0603CB46 RID: 248646 RVA: 0x00E93488 File Offset: 0x00E91688
		private float ClampCameraYaw(float desiredYaw)
		{
			ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			if ((cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null) && CameraModel.Instance.MainModel.FightCamera != null && CameraModel.Instance.MainModel.FightCamera.LogicComponent != null)
			{
				VirtualCamera currentCamera = CameraModel.Instance.MainModel.FightCamera.LogicComponent.CurrentCamera;
				float yawLimitMin = currentCamera.YawLimitMin;
				float num = (currentCamera.YawLimitMax - yawLimitMin) % 360f;
				if (MathUtils.Instance.IsNearlyZero((double)num, null) || MathUtils.Instance.IsNearlyEqual((double)num, 360.0, null))
				{
					return MathUtils.Instance.Clamp(MathUtils.Instance.WrapAngle(desiredYaw), currentCamera.WorldYawMin, currentCamera.WorldYawMax);
				}
			}
			return desiredYaw;
		}

		// Token: 0x0603CB47 RID: 248647 RVA: 0x00E9357A File Offset: 0x00E9177A
		private void UpdateMarkItems(float _)
		{
			if (this.LastTickFrame == Time.Instance.Frame)
			{
				return;
			}
			this.LastTickFrame = Time.Instance.Frame;
			this.UpdateMarkItemsForStat();
		}

		// Token: 0x0603CB48 RID: 248648 RVA: 0x00E935A8 File Offset: 0x00E917A8
		private void UpdateMarkItemsForStat()
		{
			if (!base.IsUiActiveInHierarchy())
			{
				return;
			}
			Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation == null)
			{
				return;
			}
			if (this.MiniMap != null)
			{
				this.MiniMap.Tick();
				this.CachedPlayerLocation2D.X = playerLocation.X;
				this.CachedPlayerLocation2D.Y = playerLocation.Y;
				MapUtil.WorldPosition2UiPosition2D(this.CachedPlayerLocation2D, this.CachedPlayerLocation2D);
				this.CachedPlayerLocation2D.MultiplyEqual((double)this.RealMinimapScale).UnaryNegation(this.CachedPlayerLocation2D);
				this.MiniMap.GetRootItem().SetAnchorOffset(this.CachedPlayerLocation2D.ToUeVector2D(false));
				this.MiniMap.UpdateMinimapTiles(playerLocation);
				this.CachedAnchorOffset.FromUeVector2D(this.MiniMap.GetRootItem().GetAnchorOffset());
				float realMinimapScale = this.RealMinimapScale;
				this.MiniMap.MiniMapUpdateMarkItems(this.CachedAnchorOffset, realMinimapScale, playerLocation);
			}
		}

		// Token: 0x0603CB49 RID: 248649 RVA: 0x00E93696 File Offset: 0x00E91896
		public void RefreshOnPlatformChanged()
		{
			EventSystem.Instance.Emit(EEventName.ModelReady);
		}

		// Token: 0x0603CB4A RID: 248650 RVA: 0x00E936A8 File Offset: 0x00E918A8
		public void SetRoguelikeVisible(bool visible)
		{
			base.SetVisible(1, visible);
		}

		// Token: 0x0603CB4B RID: 248651 RVA: 0x00E936B2 File Offset: 0x00E918B2
		public void SetBattleLinkVisible(bool visible)
		{
			base.SetVisible(2, visible);
		}

		// Token: 0x0603CB4C RID: 248652 RVA: 0x00E936BC File Offset: 0x00E918BC
		public void SetShipTowerVisible(bool visible)
		{
			base.SetVisible(3, visible);
		}

		// Token: 0x0603CB4D RID: 248653 RVA: 0x00E936C6 File Offset: 0x00E918C6
		public void RefreshMiniMap()
		{
			MiniMap miniMap = this.MiniMap;
			if (miniMap == null)
			{
				return;
			}
			miniMap.ChangeMapAsync(MapModel.Instance.CurrentMapConfigId);
		}

		// Token: 0x0401F9EB RID: 129515
		private const float UPDATE_INTERVAL = 100f;

		// Token: 0x0401F9EC RID: 129516
		private const float PLAYER_ROTATE_UPDATE_THRESHOLD = 10f;

		// Token: 0x0401F9ED RID: 129517
		private MiniMap MiniMap;

		// Token: 0x0401F9EE RID: 129518
		private float RealMinimapScale;

		// Token: 0x0401F9EF RID: 129519
		private bool IsInitFinished;

		// Token: 0x0401F9F0 RID: 129520
		private TimerHandle TimerId;

		// Token: 0x0401F9F1 RID: 129521
		private FRotator TempSightRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x0401F9F2 RID: 129522
		private FRotator TempPlayerRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x0401F9F3 RID: 129523
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat StatUpdateMarkItems = Stat.Create("MiniMapView.UpdateMarkItems", "", "");

		// Token: 0x0401F9F4 RID: 129524
		private int LastTickFrame = -1;

		// Token: 0x0401F9F5 RID: 129525
		[Nullable(1)]
		private readonly Vector2D CachedPlayerLocation2D = Vector2D.Create();

		// Token: 0x0401F9F6 RID: 129526
		[Nullable(1)]
		private readonly Vector2D CachedAnchorOffset = Vector2D.Create();

		// Token: 0x0200C014 RID: 49172
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039F5F RID: 237407
			MiniMapRoot,
			// Token: 0x04039F60 RID: 237408
			PlayerItem,
			// Token: 0x04039F61 RID: 237409
			PlayerSight,
			// Token: 0x04039F62 RID: 237410
			MiniMapButton
		}

		// Token: 0x0200C015 RID: 49173
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04039F64 RID: 237412
			Default,
			// Token: 0x04039F65 RID: 237413
			Roguelike,
			// Token: 0x04039F66 RID: 237414
			BattleLink,
			// Token: 0x04039F67 RID: 237415
			ShipTower
		}
	}
}
