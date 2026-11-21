using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E2C RID: 20012
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackedMarkForTower : TrackedMark
	{
		// Token: 0x0603258B RID: 206219 RVA: 0x00E1E98F File Offset: 0x00E1CB8F
		public TrackedMarkForTower(ITrackData trackData) : base(trackData)
		{
		}

		// Token: 0x0603258C RID: 206220 RVA: 0x00E1E9AE File Offset: 0x00E1CBAE
		public override void Initialize(UUIItem parent)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_TowerBar", parent, true).Forget();
		}

		// Token: 0x0603258D RID: 206221 RVA: 0x00E1E9C4 File Offset: 0x00E1CBC4
		public override void OnUiShow()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				FVector fvector = new FVector(this.IsSubTrack ? 0.8f : 1f);
				rootItem.D_SetRelativeScale3D(fvector);
			}
			this.StopTweenAnim(6);
			this.PlayTweenAnim(4);
		}

		// Token: 0x0603258E RID: 206222 RVA: 0x00E1EA11 File Offset: 0x00E1CC11
		public override void OnUiHide()
		{
			this.StopTweenAnim(4);
			this.PlayTweenAnim(6);
		}

		// Token: 0x0603258F RID: 206223 RVA: 0x00E1EA24 File Offset: 0x00E1CC24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032590 RID: 206224 RVA: 0x00E1EB32 File Offset: 0x00E1CD32
		protected override void OnStart()
		{
			this.DirectionComp = base.GetItem(1);
			this.DirectionComp.SetUIActive(!this.IsInTrackRange && !this.IsForceHideDirection);
			this.InitAllTweenAnim();
		}

		// Token: 0x06032591 RID: 206225 RVA: 0x00E1EB66 File Offset: 0x00E1CD66
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.AttributeComponent = null;
			this.DisposeTweener();
			this.StopTweenAnim(4);
			this.StopTweenAnim(5);
			this.StopTweenAnim(6);
			this.TweenAnimMap.Clear();
		}

		// Token: 0x06032592 RID: 206226 RVA: 0x00E1EB9C File Offset: 0x00E1CD9C
		public override void Update(float delta)
		{
			if (GlobalData.World == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LK, "【疑难杂症】标记固定在屏幕中心，GameWorld为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (UiLayer.Instance.UiRootItem == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LK, "【疑难杂症】标记固定在屏幕中心，RootItem为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.RootItem == null)
			{
				return;
			}
			this.CurShowTime += delta / 1000f;
			this.RootItem.SetUIActive(true);
			this.UpdatePositionAndRotation(delta);
			this.UpdateHealth();
		}

		// Token: 0x06032593 RID: 206227 RVA: 0x00E1EC2C File Offset: 0x00E1CE2C
		protected override void UpdatePositionAndRotation(float delta)
		{
			TsCharacterController characterController = Global.CharacterController;
			FVectorDouble fvectorDouble = this.TempTrackPosition.ToUeVector(false);
			bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ScreenPositionRef, false);
			if (!flag)
			{
				FTransformDouble value = CameraModel.Instance.MainModel.CameraTransform.Value;
				FVectorDouble fvectorDouble2 = value.InverseTransformPositionNoScale(fvectorDouble);
				fvectorDouble2.X = -fvectorDouble2.X;
				FVectorDouble fvectorDouble3 = value.TransformPositionNoScale(fvectorDouble2);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble3, ref this.ScreenPositionRef, false);
			}
			FVector2D screenPositionRef = this.ScreenPositionRef;
			this.ScreenPosition.Set((double)screenPositionRef.X, (double)screenPositionRef.Y);
			if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0) || this.NiagaraNeedActivateNextTick)
			{
				this.LastScreenPosition.DeepCopy(this.ScreenPosition);
				BattleUiModel instance = BattleUiModel.Instance;
				this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
				this.InRange = base.ClampToEllipse(this.ScreenPosition, flag);
				Vector2D vector2D = this.ScreenPosition.AdditionEqual(TrackDefine.center);
				this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
				if (!this.InRange && !this.IsInTrackRange && !this.IsForceHideDirection)
				{
					this.TempRotator.Reset();
					this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875 - 90.0);
					UUIItem directionComp = this.DirectionComp;
					FRotator frotator = this.TempRotator.ToUeRotator();
					directionComp.SetUIRelativeRotation(frotator);
					this.DirectionComp.SetUIActive(true);
					return;
				}
				this.DirectionComp.SetUIActive(false);
			}
		}

		// Token: 0x06032594 RID: 206228 RVA: 0x00E1EE00 File Offset: 0x00E1D000
		private void UpdateHealth()
		{
			if (this.AttributeComponent == null)
			{
				TTrackTarget_Int ttrackTarget_Int = this.TrackTarget as TTrackTarget_Int;
				if (ttrackTarget_Int == null)
				{
					throw new InvalidCastException();
				}
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ttrackTarget_Int.Value);
				if (entityByPbDataId == null)
				{
					return;
				}
				WorldEntity entity = entityByPbDataId.Entity;
				if (entity == null)
				{
					return;
				}
				this.AttributeComponent = entity.GetComponent<BaseAttributeComponent>();
				if (this.AttributeComponent == null)
				{
					return;
				}
			}
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.Life);
			if (currentValue >= this.LastHp)
			{
				return;
			}
			float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
			float num = currentValue / currentValue2;
			base.GetSprite(0).SetFillAmount(num);
			this.PlayTweenAnim(5);
			float fillAmount = base.GetSprite(3).GetFillAmount();
			this.DisposeTweener();
			this.PlayTweener(fillAmount, num);
			this.LastHp = currentValue;
		}

		// Token: 0x06032595 RID: 206229 RVA: 0x00E1EEC6 File Offset: 0x00E1D0C6
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(4);
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
		}

		// Token: 0x06032596 RID: 206230 RVA: 0x00E1EEE0 File Offset: 0x00E1D0E0
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			foreach (UActorComponent uactorComponent in base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()))
			{
				ULGUIPlayTweenComponent ulguiplayTweenComponent = uactorComponent as ULGUIPlayTweenComponent;
				if (ulguiplayTweenComponent != null)
				{
					list.Add(ulguiplayTweenComponent);
				}
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x06032597 RID: 206231 RVA: 0x00E1EF64 File Offset: 0x00E1D164
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06032598 RID: 206232 RVA: 0x00E1EFC0 File Offset: 0x00E1D1C0
		private void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x06032599 RID: 206233 RVA: 0x00E1F01C File Offset: 0x00E1D21C
		private void DisposeTweener()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.SetChangeBar));
			ULTweener tweener = this.Tweener;
			if (tweener != null)
			{
				tweener.Kill(false);
			}
			this.Tweener = null;
			this.StopTweenAnim(5);
		}

		// Token: 0x0603259A RID: 206234 RVA: 0x00E1F050 File Offset: 0x00E1D250
		private void PlayTweener(float from, float to)
		{
			this.Tweener = ULTweenBPLibrary.FloatTo(this.RootActor, DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.SetChangeBar)), from, to, 0.5f, 0f, LTweenEase.OutCubic);
			this.Tweener.OnCompleteCallBack.Bind(new Action(this.DisposeTweener));
		}

		// Token: 0x0603259B RID: 206235 RVA: 0x00E1F0A8 File Offset: 0x00E1D2A8
		private void SetChangeBar(float value)
		{
			base.GetSprite(2).SetFillAmount(value);
			base.GetSprite(3).SetFillAmount(value);
		}

		// Token: 0x0401AB2A RID: 109354
		private const float SUB_SCALE = 0.8f;

		// Token: 0x0401AB2B RID: 109355
		[Nullable(2)]
		private BaseAttributeComponent AttributeComponent;

		// Token: 0x0401AB2C RID: 109356
		[Nullable(2)]
		private ULTweener Tweener;

		// Token: 0x0401AB2D RID: 109357
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401AB2E RID: 109358
		private float LastHp = float.MaxValue;

		// Token: 0x0200ABD7 RID: 43991
		[NullableContext(0)]
		private enum EUiComponent
		{
			// Token: 0x040352EB RID: 217835
			BarBaseSprite,
			// Token: 0x040352EC RID: 217836
			DirectionItem,
			// Token: 0x040352ED RID: 217837
			BarLightSprite,
			// Token: 0x040352EE RID: 217838
			BarYellowSprite,
			// Token: 0x040352EF RID: 217839
			AniStartItem,
			// Token: 0x040352F0 RID: 217840
			AniHitItem,
			// Token: 0x040352F1 RID: 217841
			AniCloseItem
		}
	}
}
