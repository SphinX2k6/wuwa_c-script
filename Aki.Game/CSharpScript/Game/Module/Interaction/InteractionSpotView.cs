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
	// Token: 0x02004835 RID: 18485
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionSpotView : UiPanelBase
	{
		// Token: 0x0602E746 RID: 190278 RVA: 0x00CF6330 File Offset: 0x00CF4530
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

		// Token: 0x0602E747 RID: 190279 RVA: 0x00CF63DC File Offset: 0x00CF45DC
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

		// Token: 0x0602E748 RID: 190280 RVA: 0x00CF64A5 File Offset: 0x00CF46A5
		protected override void OnBeforeShow()
		{
			this.TickEnabled = true;
			this.OnAddEventListener();
		}

		// Token: 0x0602E749 RID: 190281 RVA: 0x00CF64B4 File Offset: 0x00CF46B4
		protected override void OnBeforeHide()
		{
			this.TickEnabled = false;
			this.OnRemoveEventListener();
		}

		// Token: 0x0602E74A RID: 190282 RVA: 0x00CF64C3 File Offset: 0x00CF46C3
		protected override void OnAfterShow()
		{
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0602E74B RID: 190283 RVA: 0x00CF64CB File Offset: 0x00CF46CB
		protected void OnAddEventListener()
		{
			if (this.OwnerEntity != null && this.OwnerEntity.Valid)
			{
				EventSystem.Instance.AddWithTarget<float>(this.OwnerEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			}
		}

		// Token: 0x0602E74C RID: 190284 RVA: 0x00CF6504 File Offset: 0x00CF4704
		protected void OnRemoveEventListener()
		{
			if (this.OwnerEntity != null && this.OwnerEntity.Valid)
			{
				EventSystem.Instance.RemoveWithTarget(this.OwnerEntity, EEventName.OnInteractionLongPressProgressChange, new Action<float>(this.OnInteractionLongPressProgressChange));
			}
		}

		// Token: 0x0602E74D RID: 190285 RVA: 0x00CF6540 File Offset: 0x00CF4740
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

		// Token: 0x0602E74E RID: 190286 RVA: 0x00CF65E4 File Offset: 0x00CF47E4
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

		// Token: 0x0602E74F RID: 190287 RVA: 0x00CF6726 File Offset: 0x00CF4926
		public void SetOwnerEntity(Entity entity)
		{
			this.OwnerEntity = entity;
		}

		// Token: 0x0602E750 RID: 190288 RVA: 0x00CF672F File Offset: 0x00CF492F
		public void SetOwnerActor(AActor ownerActor)
		{
			this.OwnerActor = ownerActor;
		}

		// Token: 0x0602E751 RID: 190289 RVA: 0x00CF6738 File Offset: 0x00CF4938
		public void SetIsSelect(bool isSelect)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsSelect = isSelect;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0602E752 RID: 190290 RVA: 0x00CF6750 File Offset: 0x00CF4950
		public void SetIsInEntityInteractRange(bool isInEntityInteractRange)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsInEntityInteractRange = isInEntityInteractRange;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0602E753 RID: 190291 RVA: 0x00CF6768 File Offset: 0x00CF4968
		public void SetIsTracking(bool isTracking)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsTracking = isTracking;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0602E754 RID: 190292 RVA: 0x00CF6780 File Offset: 0x00CF4980
		public void SetIsObstruct(bool isObstruct)
		{
			if (this.InDestroyAnim)
			{
				return;
			}
			this.IsObstruct = isObstruct;
			this.UpdateInteractionSpotPerform();
		}

		// Token: 0x0602E755 RID: 190293 RVA: 0x00CF6798 File Offset: 0x00CF4998
		[NullableContext(1)]
		public void SetOffset(Vector offset)
		{
			this.Offset.DeepCopy(offset);
		}

		// Token: 0x0602E756 RID: 190294 RVA: 0x00CF67A6 File Offset: 0x00CF49A6
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

		// Token: 0x0602E757 RID: 190295 RVA: 0x00CF67CC File Offset: 0x00CF49CC
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

		// Token: 0x0602E758 RID: 190296 RVA: 0x00CF681C File Offset: 0x00CF4A1C
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

		// Token: 0x0602E759 RID: 190297 RVA: 0x00CF690C File Offset: 0x00CF4B0C
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

		// Token: 0x0602E75A RID: 190298 RVA: 0x00CF6A14 File Offset: 0x00CF4C14
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

		// Token: 0x04018BAF RID: 101295
		private const float CENTER_Y = 62.5f;

		// Token: 0x04018BB0 RID: 101296
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Vector2D center = Vector2D.Create(0.0, 62.5);

		// Token: 0x04018BB1 RID: 101297
		protected FRotator? RootActorRotation;

		// Token: 0x04018BB2 RID: 101298
		private UUIItem NormalSpotItem;

		// Token: 0x04018BB3 RID: 101299
		private UUIItem QuestSpotItem;

		// Token: 0x04018BB4 RID: 101300
		private UUIItem SpotProgressItem;

		// Token: 0x04018BB5 RID: 101301
		private UUISprite SpotProgressSprite;

		// Token: 0x04018BB6 RID: 101302
		private bool IsSelect;

		// Token: 0x04018BB7 RID: 101303
		private bool IsInEntityInteractRange;

		// Token: 0x04018BB8 RID: 101304
		private bool IsTracking;

		// Token: 0x04018BB9 RID: 101305
		private bool IsObstruct;

		// Token: 0x04018BBA RID: 101306
		private bool SuppressLongPressProgress;

		// Token: 0x04018BBB RID: 101307
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04018BBC RID: 101308
		private bool? LastShowInner;

		// Token: 0x04018BBD RID: 101309
		private bool NeedAnimTransition;

		// Token: 0x04018BBE RID: 101310
		private bool InDestroyAnim;

		// Token: 0x04018BBF RID: 101311
		private string DestroyAnimName;

		// Token: 0x04018BC0 RID: 101312
		private Action DestroyCallback;

		// Token: 0x04018BC1 RID: 101313
		private Entity OwnerEntity;

		// Token: 0x04018BC2 RID: 101314
		private AActor OwnerActor;

		// Token: 0x04018BC3 RID: 101315
		[Nullable(1)]
		private readonly Vector Offset = Vector.Create();

		// Token: 0x04018BC4 RID: 101316
		[Nullable(1)]
		protected readonly Vector2D ScreenPosition = Vector2D.Create();

		// Token: 0x04018BC5 RID: 101317
		[Nullable(1)]
		private readonly Vector2D LastScreenPosition = Vector2D.Create();

		// Token: 0x04018BC6 RID: 101318
		private bool TickEnabled;

		// Token: 0x0200A49D RID: 42141
		[NullableContext(0)]
		private class ESpotViewDefine
		{
			// Token: 0x0403300D RID: 208909
			public const int NormalSpot = 0;

			// Token: 0x0403300E RID: 208910
			public const int QuestSpot = 1;

			// Token: 0x0403300F RID: 208911
			public const int SpotProgressItem = 2;

			// Token: 0x04033010 RID: 208912
			public const int SpotProgressSprite = 3;
		}
	}
}
