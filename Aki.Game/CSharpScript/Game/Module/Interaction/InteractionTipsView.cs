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
	// Token: 0x0200585E RID: 22622
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractionTipsView : UiPanelBase
	{
		// Token: 0x06039840 RID: 235584 RVA: 0x00DA7DF0 File Offset: 0x00DA5FF0
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

		// Token: 0x06039841 RID: 235585 RVA: 0x00DA7E5C File Offset: 0x00DA605C
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

		// Token: 0x06039842 RID: 235586 RVA: 0x00DA7EA9 File Offset: 0x00DA60A9
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
			this.TweenAnimPlayer.StopTweenAnim(1);
			this.TweenAnimPlayer.PlayTweenAnim(0);
		}

		// Token: 0x06039843 RID: 235587 RVA: 0x00DA7EE0 File Offset: 0x00DA60E0
		protected override UniTask OnBeforeHideAsync()
		{
			InteractionTipsView.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<InteractionTipsView.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039844 RID: 235588 RVA: 0x00DA7F23 File Offset: 0x00DA6123
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x06039845 RID: 235589 RVA: 0x00DA7F3F File Offset: 0x00DA613F
		protected override void OnBeforeDestroy()
		{
			this.RemoveTick();
		}

		// Token: 0x06039846 RID: 235590 RVA: 0x00DA7F47 File Offset: 0x00DA6147
		public void SetEnable(bool b)
		{
			this.IsEnable = b;
			this.Update();
		}

		// Token: 0x06039847 RID: 235591 RVA: 0x00DA7F56 File Offset: 0x00DA6156
		private void AddTick()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.OnTick), "InteractionTipsView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06039848 RID: 235592 RVA: 0x00DA7F82 File Offset: 0x00DA6182
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x06039849 RID: 235593 RVA: 0x00DA7FA5 File Offset: 0x00DA61A5
		private void OnTick(float delta)
		{
			this.Update();
		}

		// Token: 0x0603984A RID: 235594 RVA: 0x00DA7FB0 File Offset: 0x00DA61B0
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

		// Token: 0x0603984B RID: 235595 RVA: 0x00DA811B File Offset: 0x00DA631B
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

		// Token: 0x0603984C RID: 235596 RVA: 0x00DA8142 File Offset: 0x00DA6342
		public void SetOffset(Vector offset)
		{
			this.Offset.DeepCopy(offset);
		}

		// Token: 0x0603984D RID: 235597 RVA: 0x00DA8150 File Offset: 0x00DA6350
		public void DestroySelf(Action callback = null)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(false);
			}
			base.Destroy(callback);
		}

		// Token: 0x0401E12A RID: 123178
		[Nullable(2)]
		private AActor OwnerActor;

		// Token: 0x0401E12B RID: 123179
		[Nullable(2)]
		private Entity OwnerEntity;

		// Token: 0x0401E12C RID: 123180
		private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401E12D RID: 123181
		private readonly Vector Offset = Vector.Create();

		// Token: 0x0401E12E RID: 123182
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x0401E12F RID: 123183
		private readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x0401E130 RID: 123184
		private bool IsEnable;

		// Token: 0x0401E131 RID: 123185
		private int TickId = -1;

		// Token: 0x0200BA87 RID: 47751
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403861A RID: 230938
			public const int AniIn = 0;

			// Token: 0x0403861B RID: 230939
			public const int AniOut = 1;
		}
	}
}
