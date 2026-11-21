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
	// Token: 0x02004D47 RID: 19783
	[NullableContext(2)]
	[Nullable(0)]
	public class MiniMapView : BattleVisibleChildView
	{
		// Token: 0x06031A9B RID: 203419 RVA: 0x00DE3A67 File Offset: 0x00DE1C67
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			this.IsInitFinished = false;
		}

		// Token: 0x06031A9C RID: 203420 RVA: 0x00DE3A80 File Offset: 0x00DE1C80
		protected override UniTask InitializeAsync(object param = null)
		{
			MiniMapView.<InitializeAsync>d__15 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<MiniMapView.<InitializeAsync>d__15>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A9D RID: 203421 RVA: 0x00DE3AC3 File Offset: 0x00DE1CC3
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

		// Token: 0x06031A9E RID: 203422 RVA: 0x00DE3AF8 File Offset: 0x00DE1CF8
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

		// Token: 0x06031A9F RID: 203423 RVA: 0x00DE3BE0 File Offset: 0x00DE1DE0
		private void OpenMapView()
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, true, null, null);
		}

		// Token: 0x06031AA0 RID: 203424 RVA: 0x00DE3BF0 File Offset: 0x00DE1DF0
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

		// Token: 0x06031AA1 RID: 203425 RVA: 0x00DE3CC4 File Offset: 0x00DE1EC4
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

		// Token: 0x06031AA2 RID: 203426 RVA: 0x00DE3DB6 File Offset: 0x00DE1FB6
		private void UpdateMarkItems(float _)
		{
			if (this.LastTickFrame == Time.Instance.Frame)
			{
				return;
			}
			this.LastTickFrame = Time.Instance.Frame;
			this.UpdateMarkItemsForStat();
		}

		// Token: 0x06031AA3 RID: 203427 RVA: 0x00DE3DE4 File Offset: 0x00DE1FE4
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

		// Token: 0x06031AA4 RID: 203428 RVA: 0x00DE3ED2 File Offset: 0x00DE20D2
		public void RefreshOnPlatformChanged()
		{
			EventSystem.Instance.Emit(EEventName.ModelReady);
		}

		// Token: 0x06031AA5 RID: 203429 RVA: 0x00DE3EE4 File Offset: 0x00DE20E4
		public void SetRoguelikeVisible(bool visible)
		{
			base.SetVisible(1, visible);
		}

		// Token: 0x06031AA6 RID: 203430 RVA: 0x00DE3EEE File Offset: 0x00DE20EE
		public void SetBattleLinkVisible(bool visible)
		{
			base.SetVisible(2, visible);
		}

		// Token: 0x06031AA7 RID: 203431 RVA: 0x00DE3EF8 File Offset: 0x00DE20F8
		public void SetShipTowerVisible(bool visible)
		{
			base.SetVisible(3, visible);
		}

		// Token: 0x06031AA8 RID: 203432 RVA: 0x00DE3F02 File Offset: 0x00DE2102
		public void SetRoleTowerVisible(bool visible)
		{
			base.SetVisible(4, visible);
		}

		// Token: 0x06031AA9 RID: 203433 RVA: 0x00DE3F0C File Offset: 0x00DE210C
		public void RefreshMiniMap()
		{
			MiniMap miniMap = this.MiniMap;
			if (miniMap == null)
			{
				return;
			}
			miniMap.ChangeMapAsync(MapModel.Instance.CurrentMapConfigId);
		}

		// Token: 0x0401A4A3 RID: 107683
		private const float UPDATE_INTERVAL = 100f;

		// Token: 0x0401A4A4 RID: 107684
		private const float PLAYER_ROTATE_UPDATE_THRESHOLD = 10f;

		// Token: 0x0401A4A5 RID: 107685
		private MiniMap MiniMap;

		// Token: 0x0401A4A6 RID: 107686
		private float RealMinimapScale;

		// Token: 0x0401A4A7 RID: 107687
		private bool IsInitFinished;

		// Token: 0x0401A4A8 RID: 107688
		private TimerHandle TimerId;

		// Token: 0x0401A4A9 RID: 107689
		private FRotator TempSightRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x0401A4AA RID: 107690
		private FRotator TempPlayerRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x0401A4AB RID: 107691
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat StatUpdateMarkItems = Stat.Create("MiniMapView.UpdateMarkItems", "", "");

		// Token: 0x0401A4AC RID: 107692
		private int LastTickFrame = -1;

		// Token: 0x0401A4AD RID: 107693
		[Nullable(1)]
		private readonly Vector2D CachedPlayerLocation2D = Vector2D.Create();

		// Token: 0x0401A4AE RID: 107694
		[Nullable(1)]
		private readonly Vector2D CachedAnchorOffset = Vector2D.Create();

		// Token: 0x0200AA1A RID: 43546
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034921 RID: 215329
			MiniMapRoot,
			// Token: 0x04034922 RID: 215330
			PlayerItem,
			// Token: 0x04034923 RID: 215331
			PlayerSight,
			// Token: 0x04034924 RID: 215332
			MiniMapButton
		}

		// Token: 0x0200AA1B RID: 43547
		[NullableContext(0)]
		private enum EVisibleReason
		{
			// Token: 0x04034926 RID: 215334
			Default,
			// Token: 0x04034927 RID: 215335
			Roguelike,
			// Token: 0x04034928 RID: 215336
			BattleLink,
			// Token: 0x04034929 RID: 215337
			ShipTower,
			// Token: 0x0403492A RID: 215338
			RoleTower
		}
	}
}
