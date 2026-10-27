using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200585D RID: 22621
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionSpotView : UiPanelBase
	{
		// Token: 0x06039829 RID: 235561 RVA: 0x00DA7608 File Offset: 0x00DA5808
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603982A RID: 235562 RVA: 0x00DA76B4 File Offset: 0x00DA58B4
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			this.RootActorRotation = new FRotator?(this.RootActor.K2_GetActorRotation());
			this.NormalSpotItem = base.GetItem(0);
			this.QuestSpotItem = base.GetItem(1);
			this.SpotProgressItem = base.GetItem(2);
			this.SpotProgressSprite = base.GetSprite(3);
			this.NormalSpotItem.SetUIActive(true);
			this.QuestSpotItem.SetUIActive(false);
			this.SpotProgressItem.SetUIActive(false);
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
			if (Info.Instance.IsMobileInputModel())
			{
				this.IsSelect = true;
			}
		}

		// Token: 0x0603982B RID: 235563 RVA: 0x00DA777D File Offset: 0x00DA597D
		protected override void OnBeforeShow()
		{
			this.TickEnabled = true;
			this.OnAddEventListener();
		}

		// Token: 0x0603982C RID: 235564 RVA: 0x00DA778C File Offset: 0x00DA598C
		protected override void OnBeforeHide()
		{
			this.TickEnabled = false;
			this.OnRemoveEventListener();
		}

		// Token: 0x0603982D RID: 235565 RVA: 0x00DA779B File Offset: 0x00DA599B
		protected override void OnAfterShow()
		{
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0603982E RID: 235566 RVA: 0x00DA77A3 File Offset: 0x00DA59A3
		protected void OnAddEventListener()
		{
			if (this.OwnerEntity != null && this.OwnerEntity.Valid)
			{
				EventSystem.Instance.AddWithTarget<float>(this.OwnerEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			}
		}

		// Token: 0x0603982F RID: 235567 RVA: 0x00DA77DC File Offset: 0x00DA59DC
		protected void OnRemoveEventListener()
		{
			if (this.OwnerEntity != null && this.OwnerEntity.Valid)
			{
				EventSystem.Instance.RemoveWithTarget(this.OwnerEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			}
		}

		// Token: 0x06039830 RID: 235568 RVA: 0x00DA7818 File Offset: 0x00DA5A18
		public void DestroySelf(Action callback)
		{
			this.TickEnabled = false;
			this.InDestroyAnim = true;
			this.DestroyCallback = callback;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			if (this.SeqPlayer == null)
			{
				base.Destroy(this.DestroyCallback);
				return;
			}
			if (this.LastShowInner.GetValueOrDefault())
			{
				this.DestroyAnimName = "SetOut";
				this.SeqPlayer.PlayLevelSequenceByName("SetOut", false, null, false);
				return;
			}
			this.DestroyAnimName = "NorOut";
			this.SeqPlayer.PlayLevelSequenceByName("NorOut", false, null, false);
		}

		// Token: 0x06039831 RID: 235569 RVA: 0x00DA78BC File Offset: 0x00DA5ABC
		public void Update()
		{
			if (this.OwnerActor == null || !this.TickEnabled || this.InDestroyAnim)
			{
				return;
			}
			APlayerController characterController = Global.CharacterController;
			FTransformDouble ftransformDouble = this.OwnerActor.D_GetTransform();
			FVectorDouble fvectorDouble = this.Offset.ToUeVector(false);
			FVectorDouble fvectorDouble2 = ftransformDouble.TransformPositionNoScale(fvectorDouble);
			FVector fvector = fvectorDouble2;
			FVector2D fvector2D = new FVector2D();
			fvectorDouble = fvector;
			if (!UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref fvector2D, false))
			{
				this.RootItem.SetUIActive(false);
				return;
			}
			this.RootItem.SetUIActive(true);
			this.ScreenPosition.Set((double)fvector2D.X, (double)fvector2D.Y);
			if (this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
			{
				return;
			}
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			Vector2D vector2D = Vector2D.Create((double)fvector2D.X, (double)fvector2D.Y);
			BattleUiModel instance = BattleUiModel.Instance;
			vector2D.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(Vector2D.Create(1.0, -1.0)).AdditionEqual(InteractionSpotView.center);
			this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}

		// Token: 0x06039832 RID: 235570 RVA: 0x00DA79FE File Offset: 0x00DA5BFE
		public void SetOwnerEntity(Entity entity)
		{
			this.OwnerEntity = entity;
		}

		// Token: 0x06039833 RID: 235571 RVA: 0x00DA7A07 File Offset: 0x00DA5C07
		public void SetOwnerActor(AActor ownerActor)
		{
			this.OwnerActor = ownerActor;
		}

		// Token: 0x06039834 RID: 235572 RVA: 0x00DA7A10 File Offset: 0x00DA5C10
		public void SetIsSelect(bool isSelect)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsSelect = isSelect;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x06039835 RID: 235573 RVA: 0x00DA7A28 File Offset: 0x00DA5C28
		public void SetIsInEntityInteractRange(bool isInEntityInteractRange)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsInEntityInteractRange = isInEntityInteractRange;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x06039836 RID: 235574 RVA: 0x00DA7A40 File Offset: 0x00DA5C40
		public void SetIsTracking(bool isTracking)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsTracking = isTracking;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x06039837 RID: 235575 RVA: 0x00DA7A58 File Offset: 0x00DA5C58
		public void SetIsObstruct(bool isObstruct)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsObstruct = isObstruct;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x06039838 RID: 235576 RVA: 0x00DA7A70 File Offset: 0x00DA5C70
		[NullableContext(1)]
		public void SetOffset(Vector offset)
		{
			this.Offset.DeepCopy(offset);
		}

		// Token: 0x06039839 RID: 235577 RVA: 0x00DA7A7E File Offset: 0x00DA5C7E
		public void SetSuppressLongPressProgress(bool suppress)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.SuppressLongPressProgress = suppress;
			if (suppress)
			{
				UUIItem spotProgressItem = this.SpotProgressItem;
				if (spotProgressItem == null)
				{
					return;
				}
				spotProgressItem.SetUIActive(false);
			}
		}

		// Token: 0x0603983A RID: 235578 RVA: 0x00DA7AA4 File Offset: 0x00DA5CA4
		private void OnInteractionLongPressProgressChange(float progress)
		{
			if (this.SuppressLongPressProgress)
			{
				this.SpotProgressItem.SetUIActive(false);
				return;
			}
			if (progress > 0f)
			{
				this.SpotProgressSprite.SetFillAmount(progress);
				this.SpotProgressItem.SetUIActive(true);
				return;
			}
			this.SpotProgressItem.SetUIActive(false);
		}

		// Token: 0x0603983B RID: 235579 RVA: 0x00DA7AF4 File Offset: 0x00DA5CF4
		private void UpdateInteractionSpotPerform()
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			bool flag = this.IsSelect && this.IsInEntityInteractRange;
			if (this.IsTracking)
			{
				this.NormalSpotItem.SetUIActive(false);
				this.QuestSpotItem.SetUIActive(true);
			}
			else
			{
				this.NormalSpotItem.SetUIActive(true);
				this.QuestSpotItem.SetUIActive(false);
			}
			bool? lastShowInner = this.LastShowInner;
			bool flag2 = flag;
			if (!(lastShowInner.GetValueOrDefault() == flag2 & lastShowInner != null))
			{
				this.OnShowInnerChange(flag);
				this.LastShowInner = new bool?(flag);
			}
			this.NormalSpotItem.SetAlpha(this.IsObstruct ? 0.3f : 1f);
			this.QuestSpotItem.SetAlpha(this.IsObstruct ? 0.3f : 1f);
			this.SpotProgressSprite.SetAlpha(this.IsObstruct ? 0.3f : 1f);
		}

		// Token: 0x0603983C RID: 235580 RVA: 0x00DA7BE4 File Offset: 0x00DA5DE4
		private void OnShowInnerChange(bool showInner)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.NeedAnimTransition = false;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			if (this.LastShowInner == null)
			{
				if (!showInner)
				{
					LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
					if (seqPlayer2 != null)
					{
						seqPlayer2.PlayLevelSequenceByName("Start", false, null, false);
					}
					this.NeedAnimTransition = this.IsTracking;
					return;
				}
				LevelSequencePlayer seqPlayer3 = this.SeqPlayer;
				if (seqPlayer3 == null)
				{
					return;
				}
				seqPlayer3.PlayLevelSequenceByName("Select", false, null, false);
				return;
			}
			else
			{
				bool? lastShowInner = this.LastShowInner;
				bool flag = false;
				if (!(lastShowInner.GetValueOrDefault() == flag & lastShowInner != null))
				{
					if (this.LastShowInner.GetValueOrDefault())
					{
						this.NeedAnimTransition = this.IsTracking;
						LevelSequencePlayer seqPlayer4 = this.SeqPlayer;
						if (seqPlayer4 == null)
						{
							return;
						}
						seqPlayer4.PlayLevelSequenceByName("UnSelect", false, null, false);
					}
					return;
				}
				LevelSequencePlayer seqPlayer5 = this.SeqPlayer;
				if (seqPlayer5 == null)
				{
					return;
				}
				seqPlayer5.PlayLevelSequenceByName("Select", false, null, false);
				return;
			}
		}

		// Token: 0x0603983D RID: 235581 RVA: 0x00DA7CEC File Offset: 0x00DA5EEC
		[NullableContext(1)]
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (this.InDestroyAnim && this.DestroyAnimName == sequenceName)
			{
				Action destroyCallback = this.DestroyCallback;
				this.DestroyCallback = null;
				base.Destroy(destroyCallback);
				return;
			}
			if (this.InDestroyAnim)
			{
				return;
			}
			if (!this.NeedAnimTransition)
			{
				return;
			}
			this.NeedAnimTransition = false;
			if (!(sequenceName == "NorOut"))
			{
				if (sequenceName == "Start" || sequenceName == "UnSelect")
				{
					LevelSequencePlayer seqPlayer = this.SeqPlayer;
					if (seqPlayer == null)
					{
						return;
					}
					seqPlayer.PlayLevelSequenceByName("Loop", false, null, false);
				}
				return;
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.PlayLevelSequenceByName("Select", false, null, false);
		}

		// Token: 0x0401E112 RID: 123154
		private const float CENTER_Y = 62.5f;

		// Token: 0x0401E113 RID: 123155
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Vector2D center = Vector2D.Create(0.0, 62.5);

		// Token: 0x0401E114 RID: 123156
		protected FRotator? RootActorRotation;

		// Token: 0x0401E115 RID: 123157
		private UUIItem NormalSpotItem;

		// Token: 0x0401E116 RID: 123158
		private UUIItem QuestSpotItem;

		// Token: 0x0401E117 RID: 123159
		private UUIItem SpotProgressItem;

		// Token: 0x0401E118 RID: 123160
		private UUISprite SpotProgressSprite;

		// Token: 0x0401E119 RID: 123161
		private bool IsSelect;

		// Token: 0x0401E11A RID: 123162
		private bool IsInEntityInteractRange;

		// Token: 0x0401E11B RID: 123163
		private bool IsTracking;

		// Token: 0x0401E11C RID: 123164
		private bool IsObstruct;

		// Token: 0x0401E11D RID: 123165
		private bool SuppressLongPressProgress;

		// Token: 0x0401E11E RID: 123166
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401E11F RID: 123167
		private bool? LastShowInner;

		// Token: 0x0401E120 RID: 123168
		private bool NeedAnimTransition;

		// Token: 0x0401E121 RID: 123169
		private bool InDestroyAnim;

		// Token: 0x0401E122 RID: 123170
		private string DestroyAnimName;

		// Token: 0x0401E123 RID: 123171
		private Action DestroyCallback;

		// Token: 0x0401E124 RID: 123172
		private Entity OwnerEntity;

		// Token: 0x0401E125 RID: 123173
		private AActor OwnerActor;

		// Token: 0x0401E126 RID: 123174
		[Nullable(1)]
		private readonly Vector Offset = Vector.Create();

		// Token: 0x0401E127 RID: 123175
		[Nullable(1)]
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x0401E128 RID: 123176
		[Nullable(1)]
		private readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x0401E129 RID: 123177
		private bool TickEnabled;

		// Token: 0x0200BA86 RID: 47750
		[NullableContext(0)]
		private class ESpotViewDefine
		{
			// Token: 0x04038616 RID: 230934
			public const int NormalSpot = 0;

			// Token: 0x04038617 RID: 230935
			public const int QuestSpot = 1;

			// Token: 0x04038618 RID: 230936
			public const int SpotProgressItem = 2;

			// Token: 0x04038619 RID: 230937
			public const int SpotProgressSprite = 3;
		}
	}
}
