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
	// Token: 0x02005E47 RID: 24135
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackedMarkForTower : TrackedMark
	{
		// Token: 0x0603D5FB RID: 251387 RVA: 0x00ECD423 File Offset: 0x00ECB623
		public TrackedMarkForTower(ITrackData trackData) : base(trackData)
		{
		}

		// Token: 0x0603D5FC RID: 251388 RVA: 0x00ECD442 File Offset: 0x00ECB642
		public override void Initialize(UUIItem parent)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_TowerBar", parent, true).Forget();
		}

		// Token: 0x0603D5FD RID: 251389 RVA: 0x00ECD458 File Offset: 0x00ECB658
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

		// Token: 0x0603D5FE RID: 251390 RVA: 0x00ECD4A5 File Offset: 0x00ECB6A5
		public override void OnUiHide()
		{
			this.StopTweenAnim(4);
			this.PlayTweenAnim(6);
		}

		// Token: 0x0603D5FF RID: 251391 RVA: 0x00ECD4B8 File Offset: 0x00ECB6B8
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

		// Token: 0x0603D600 RID: 251392 RVA: 0x00ECD5C6 File Offset: 0x00ECB7C6
		protected override void OnStart()
		{
			this.DirectionComp = base.GetItem(1);
			this.DirectionComp.SetUIActive(!this.IsInTrackRange && !this.IsForceHideDirection);
			this.InitAllTweenAnim();
		}

		// Token: 0x0603D601 RID: 251393 RVA: 0x00ECD5FA File Offset: 0x00ECB7FA
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

		// Token: 0x0603D602 RID: 251394 RVA: 0x00ECD630 File Offset: 0x00ECB830
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

		// Token: 0x0603D603 RID: 251395 RVA: 0x00ECD6C0 File Offset: 0x00ECB8C0
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

		// Token: 0x0603D604 RID: 251396 RVA: 0x00ECD894 File Offset: 0x00ECBA94
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

		// Token: 0x0603D605 RID: 251397 RVA: 0x00ECD95A File Offset: 0x00ECBB5A
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(4);
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
		}

		// Token: 0x0603D606 RID: 251398 RVA: 0x00ECD974 File Offset: 0x00ECBB74
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

		// Token: 0x0603D607 RID: 251399 RVA: 0x00ECD9F4 File Offset: 0x00ECBBF4
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

		// Token: 0x0603D608 RID: 251400 RVA: 0x00ECDA50 File Offset: 0x00ECBC50
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

		// Token: 0x0603D609 RID: 251401 RVA: 0x00ECDAAC File Offset: 0x00ECBCAC
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

		// Token: 0x0603D60A RID: 251402 RVA: 0x00ECDAE0 File Offset: 0x00ECBCE0
		private void PlayTweener(float from, float to)
		{
			this.Tweener = ULTweenBPLibrary.FloatTo(this.RootActor, DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.SetChangeBar)), from, to, 0.5f, 0f, LTweenEase.OutCubic);
			this.Tweener.OnCompleteCallBack.Bind(new Action(this.DisposeTweener));
		}

		// Token: 0x0603D60B RID: 251403 RVA: 0x00ECDB38 File Offset: 0x00ECBD38
		private void SetChangeBar(float value)
		{
			base.GetSprite(2).SetFillAmount(value);
			base.GetSprite(3).SetFillAmount(value);
		}

		// Token: 0x04020063 RID: 131171
		private const float SUB_SCALE = 0.8f;

		// Token: 0x04020064 RID: 131172
		[Nullable(2)]
		private BaseAttributeComponent AttributeComponent;

		// Token: 0x04020065 RID: 131173
		[Nullable(2)]
		private ULTweener Tweener;

		// Token: 0x04020066 RID: 131174
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x04020067 RID: 131175
		private float LastHp = float.MaxValue;

		// Token: 0x0200C1C8 RID: 49608
		[NullableContext(0)]
		private enum EUiComponent
		{
			// Token: 0x0403A8F9 RID: 239865
			BarBaseSprite,
			// Token: 0x0403A8FA RID: 239866
			DirectionItem,
			// Token: 0x0403A8FB RID: 239867
			BarLightSprite,
			// Token: 0x0403A8FC RID: 239868
			BarYellowSprite,
			// Token: 0x0403A8FD RID: 239869
			AniStartItem,
			// Token: 0x0403A8FE RID: 239870
			AniHitItem,
			// Token: 0x0403A8FF RID: 239871
			AniCloseItem
		}
	}
}
