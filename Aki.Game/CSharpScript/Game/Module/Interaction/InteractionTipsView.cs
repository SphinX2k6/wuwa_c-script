using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004836 RID: 18486
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractionTipsView : UiPanelBase
	{
		// Token: 0x0602E75D RID: 190301 RVA: 0x00CF6B18 File Offset: 0x00CF4D18
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

		// Token: 0x0602E75E RID: 190302 RVA: 0x00CF6B84 File Offset: 0x00CF4D84
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			this.TweenAnimPlayer.InitTweenAnim(0, base.GetItem(0), false);
			this.TweenAnimPlayer.InitTweenAnim(1, base.GetItem(1), false);
			this.AddTick();
		}

		// Token: 0x0602E75F RID: 190303 RVA: 0x00CF6BD1 File Offset: 0x00CF4DD1
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			this.TweenAnimPlayer.StopTweenAnim(1);
			this.TweenAnimPlayer.PlayTweenAnim(0);
		}

		// Token: 0x0602E760 RID: 190304 RVA: 0x00CF6C08 File Offset: 0x00CF4E08
		protected override UniTask OnBeforeHideAsync()
		{
			InteractionTipsView.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<InteractionTipsView.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E761 RID: 190305 RVA: 0x00CF6C4B File Offset: 0x00CF4E4B
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0602E762 RID: 190306 RVA: 0x00CF6C67 File Offset: 0x00CF4E67
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
		}

		// Token: 0x0602E763 RID: 190307 RVA: 0x00CF6C6F File Offset: 0x00CF4E6F
		public void SetEnable(bool b)
		{
			this.IsEnable = b;
			this.Update();
		}

		// Token: 0x0602E764 RID: 190308 RVA: 0x00CF6C7E File Offset: 0x00CF4E7E
		private void AddTick()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "InteractionTipsView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0602E765 RID: 190309 RVA: 0x00CF6CAA File Offset: 0x00CF4EAA
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x0602E766 RID: 190310 RVA: 0x00CF6CCD File Offset: 0x00CF4ECD
		private void OnTick(float delta)
		{
			this.Update();
		}

		// Token: 0x0602E767 RID: 190311 RVA: 0x00CF6CD8 File Offset: 0x00CF4ED8
		private void Update()
		{
			if (this.OwnerActor == null || !this.IsEnable)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetUIActive(false);
				return;
			}
			else if (this.OwnerEntity == null || !SceneItemCaptureController.IsVisible(this.OwnerEntity))
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetUIActive(false);
				return;
			}
			else
			{
				APlayerController playerController = Global.PlayerController;
				FTransformDouble ftransformDouble = this.OwnerActor.D_GetTransform();
				FVectorDouble fvectorDouble = this.Offset.ToUeVector(false);
				FVectorDouble fvectorDouble2 = ftransformDouble.TransformPositionNoScale(fvectorDouble);
				FVector2D fvector2D = new FVector2D();
				if (!UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble2, ref fvector2D, false))
				{
					if (this.RootItem.IsUIActiveSelf())
					{
						this.RootItem.SetUIActive(false);
					}
					return;
				}
				if (!this.RootItem.IsUIActiveSelf())
				{
					this.RootItem.SetUIActive(true);
					this.TweenAnimPlayer.StopTweenAnim(1);
					this.TweenAnimPlayer.PlayTweenAnim(0);
				}
				Vector2D screenPosition = this.ScreenPosition;
				screenPosition.Set((double)fvector2D.X, (double)fvector2D.Y);
				if (this.LastScreenPosition.Equals(screenPosition, 0.10000000149011612))
				{
					return;
				}
				this.LastScreenPosition.DeepCopy(screenPosition);
				screenPosition.MultiplyEqual((double)BattleUiModel.Instance.ScreenPositionScale).AdditionEqual(BattleUiModel.Instance.ScreenPositionOffset).MultiplyEqual(Vector2D.Create(1.0, -1.0));
				this.RootItem.SetAnchorOffset(screenPosition.ToUeVector2D(false));
				return;
			}
		}

		// Token: 0x0602E768 RID: 190312 RVA: 0x00CF6E43 File Offset: 0x00CF5043
		[NullableContext(2)]
		public void SetOwnerEntity(Entity entity)
		{
			this.OwnerEntity = entity;
			AActor ownerActor;
			if (entity == null)
			{
				ownerActor = null;
			}
			else
			{
				BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
				ownerActor = ((component != null) ? component.Owner : null);
			}
			this.OwnerActor = ownerActor;
		}

		// Token: 0x0602E769 RID: 190313 RVA: 0x00CF6E6A File Offset: 0x00CF506A
		public void SetOffset(Vector offset)
		{
			this.Offset.DeepCopy(offset);
		}

		// Token: 0x0602E76A RID: 190314 RVA: 0x00CF6E78 File Offset: 0x00CF5078
		public void DestroySelf(Action callback = null)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			base.Destroy(callback);
		}

		// Token: 0x04018BC7 RID: 101319
		[Nullable(2)]
		private AActor OwnerActor;

		// Token: 0x04018BC8 RID: 101320
		[Nullable(2)]
		private Entity OwnerEntity;

		// Token: 0x04018BC9 RID: 101321
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x04018BCA RID: 101322
		private readonly Vector Offset = Vector.Create();

		// Token: 0x04018BCB RID: 101323
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x04018BCC RID: 101324
		private readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x04018BCD RID: 101325
		private bool IsEnable;

		// Token: 0x04018BCE RID: 101326
		private int TickId = -1;

		// Token: 0x0200A49E RID: 42142
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033011 RID: 208913
			public const int AniIn = 0;

			// Token: 0x04033012 RID: 208914
			public const int AniOut = 1;
		}
	}
}
