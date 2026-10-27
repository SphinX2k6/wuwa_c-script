using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Controller;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D1B RID: 23835
	[NullableContext(1)]
	[Nullable(0)]
	public class EavesdropMark : UiPanelBase
	{
		// Token: 0x0603C68E RID: 247438 RVA: 0x00E7BA14 File Offset: 0x00E79C14
		public EavesdropMark(AActor trackActor, int entityId)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			this.TrackingActor = trackActor;
			this.TrackingEntityId = new int?(entityId);
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null)
			{
				return;
			}
			this.TargetTagComp = entity.GetComponent<BaseTagComponent>();
			this.TargetTagComp.AddTagAddOrRemoveListener(EavesdropMark.NormalTag, new BaseTagComponent.TTagSwitchedCallback(this.OnChangeToNormal), null);
			this.TargetTagComp.AddTagAddOrRemoveListener(EavesdropMark.StartTakingTag, new BaseTagComponent.TTagSwitchedCallback(this.OnStartTaking), null);
			this.TargetTagComp.AddTagAddOrRemoveListener(EavesdropMark.EndTag, new BaseTagComponent.TTagSwitchedCallback(this.OnGameplayEnd), null);
		}

		// Token: 0x0603C68F RID: 247439 RVA: 0x00E7BADC File Offset: 0x00E79CDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C690 RID: 247440 RVA: 0x00E7BB88 File Offset: 0x00E79D88
		protected override void OnStart()
		{
			this.NormalItem = base.GetItem(0);
			this.DistText = base.GetText(1);
			this.TakingItem = base.GetItem(2);
			this.FoundItem = base.GetItem(3);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
			}
			UUIItem normalItem = this.NormalItem;
			if (normalItem != null)
			{
				normalItem.SetUIActive(true);
			}
			UUIItem takingItem = this.TakingItem;
			if (takingItem != null)
			{
				takingItem.SetUIActive(false);
			}
			UUIItem foundItem = this.FoundItem;
			if (foundItem != null)
			{
				foundItem.SetUIActive(false);
			}
			this.LevelSequencePlayer.PlaySequencePurely("Eavesdrop_Start", false, false, null, null, false);
			this.SeqState = EavesdropMark.ESeqState.Normal;
			this.MeshComp = (this.TrackingActor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent);
			double? num = this.UpdateDistText();
			this.UpdateRotation();
			this.UpdateLocation();
			if (num != null && SneakController.Instance.IsSneaking)
			{
				double num2 = (double)this.ShowDist;
				double? num3 = num;
				if ((num2 < num3.GetValueOrDefault() & num3 != null) && !base.GetActive())
				{
					this.SetActive(true);
				}
				else
				{
					double num4 = (double)this.ShowDist;
					num3 = num;
					if ((num4 >= num3.GetValueOrDefault() & num3 != null) && base.GetActive())
					{
						this.SetActive(false);
					}
				}
			}
			UUIItem rootItem = this.RootItem;
			FVector fvector = Vector.Create(0.5, 0.5, 0.5).ToUeVectorOld();
			rootItem.SetUIRelativeScale3D(fvector);
		}

		// Token: 0x0603C691 RID: 247441 RVA: 0x00E7BD28 File Offset: 0x00E79F28
		public void Update()
		{
			double? num = this.UpdateDistText();
			this.UpdateRotation();
			this.UpdateLocation();
			if (num != null && SneakController.Instance.IsSneaking)
			{
				double num2 = (double)this.ShowDist;
				double? num3 = num;
				if ((num2 < num3.GetValueOrDefault() & num3 != null) && base.GetActive())
				{
					this.SetActive(false);
					return;
				}
				double num4 = (double)this.ShowDist;
				num3 = num;
				if ((num4 >= num3.GetValueOrDefault() & num3 != null) && !base.GetActive())
				{
					this.SetActive(true);
				}
			}
		}

		// Token: 0x0603C692 RID: 247442 RVA: 0x00E7BDB8 File Offset: 0x00E79FB8
		private void UpdateRotation()
		{
			Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
			float num = cameraRotator.Yaw + 90f;
			float num2 = cameraRotator.Pitch - 90f;
			Rotator rotator = Rotator.Create(this.RootItem.RelativeRotation);
			if (Math.Abs(num - this.RootActorRotation.Yaw) < 0.1f && Math.Abs(num2 - this.RootActorRotation.Roll) < 0.1f && rotator.Equals(this.RootActorRotation, 0.1f))
			{
				return;
			}
			this.RootActorRotation.Yaw = num;
			this.RootActorRotation.Pitch = 0f;
			this.RootActorRotation.Roll = num2;
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			FRotator frotator = this.RootActorRotation.ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0603C693 RID: 247443 RVA: 0x00E7BE90 File Offset: 0x00E7A090
		private double? UpdateDistText()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Vector vector;
			if (baseCharacter == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			Vector vector2 = vector;
			AActor trackingActor = this.TrackingActor;
			FVectorDouble? fvectorDouble = (trackingActor != null) ? new FVectorDouble?(trackingActor.D_K2_GetActorLocation()) : null;
			if (vector2 != null && fvectorDouble != null)
			{
				Vector vector3 = Vector.Create(fvectorDouble).SubtractionEqual(Vector.Create(vector2));
				UUIText distText = this.DistText;
				if (distText != null)
				{
					distText.SetText(Math.Round(vector3.Size() / 100.0).ToString() + " 米", true);
				}
				return new double?(vector3.Size());
			}
			UUIText distText2 = this.DistText;
			if (distText2 != null)
			{
				distText2.SetText(string.Empty, true);
			}
			return null;
		}

		// Token: 0x0603C694 RID: 247444 RVA: 0x00E7BF68 File Offset: 0x00E7A168
		private void UpdateLocation()
		{
			FVectorDouble inVec = this.MeshComp.D_GetSocketLocation(EavesdropMark.HeadName);
			inVec.Z += 150.0;
			FVector uirelativeLocation = UKismetMathLibrary.Conv_VectorDoubleToVector(inVec);
			this.RootItem.SetUIRelativeLocation(uirelativeLocation);
		}

		// Token: 0x0603C695 RID: 247445 RVA: 0x00E7BFAD File Offset: 0x00E7A1AD
		private void OnChangeToNormal(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Normal)
			{
				return;
			}
			this.PlayChangeToNormalSeq();
		}

		// Token: 0x0603C696 RID: 247446 RVA: 0x00E7BFC2 File Offset: 0x00E7A1C2
		private void OnStartTaking(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				return;
			}
			if (this.SeqState != EavesdropMark.ESeqState.Normal)
			{
				return;
			}
			this.PlayTakingSeq();
		}

		// Token: 0x0603C697 RID: 247447 RVA: 0x00E7BFD7 File Offset: 0x00E7A1D7
		private void OnGameplayEnd(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.None)
			{
				return;
			}
			this.PlayEndSeq();
		}

		// Token: 0x0603C698 RID: 247448 RVA: 0x00E7BFF0 File Offset: 0x00E7A1F0
		public void PlayFoundSeq()
		{
			if (this.SeqState == EavesdropMark.ESeqState.Found)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Normal)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("Eavesdrop_Close", false, false, null, null, false);
				}
				this.NextSeqState = EavesdropMark.ESeqState.Found;
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Taking)
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlaySequencePurely("Talk_Close", false, false, null, null, false);
				}
				this.NextSeqState = EavesdropMark.ESeqState.Found;
			}
		}

		// Token: 0x0603C699 RID: 247449 RVA: 0x00E7C070 File Offset: 0x00E7A270
		private void PlayFoundSeqInternal()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("BeFound_Start", false, false, null, null, false);
			}
			this.SeqState = EavesdropMark.ESeqState.Found;
			this.NextSeqState = EavesdropMark.ESeqState.None;
		}

		// Token: 0x0603C69A RID: 247450 RVA: 0x00E7C0B0 File Offset: 0x00E7A2B0
		private void PlayNormalSeqInternal()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Eavesdrop_Start", false, false, null, null, false);
			}
			this.SeqState = EavesdropMark.ESeqState.Normal;
			this.NextSeqState = EavesdropMark.ESeqState.None;
		}

		// Token: 0x0603C69B RID: 247451 RVA: 0x00E7C0F0 File Offset: 0x00E7A2F0
		public void PlayEndSeq()
		{
			if (this.SeqState == EavesdropMark.ESeqState.None)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Taking)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("Talk_Close", false, false, null, null, false);
				}
			}
			else if (this.SeqState == EavesdropMark.ESeqState.Normal)
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlaySequencePurely("Eavesdrop_Close", false, false, null, null, false);
				}
			}
			this.SeqState = EavesdropMark.ESeqState.None;
		}

		// Token: 0x0603C69C RID: 247452 RVA: 0x00E7C168 File Offset: 0x00E7A368
		public void PlayTakingSeq()
		{
			if (this.SeqState == EavesdropMark.ESeqState.Taking)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Normal)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("Eavesdrop_Close", false, false, null, null, false);
				}
				this.NextSeqState = EavesdropMark.ESeqState.Taking;
			}
		}

		// Token: 0x0603C69D RID: 247453 RVA: 0x00E7C1B4 File Offset: 0x00E7A3B4
		public void PlayChangeToNormalSeq()
		{
			if (this.SeqState == EavesdropMark.ESeqState.Normal)
			{
				return;
			}
			if (this.SeqState == EavesdropMark.ESeqState.Taking)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlaySequencePurely("Talk_Close", false, false, null, null, false);
				}
				this.NextSeqState = EavesdropMark.ESeqState.Normal;
			}
		}

		// Token: 0x0603C69E RID: 247454 RVA: 0x00E7C200 File Offset: 0x00E7A400
		private void PlayTakingSeqInternal()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Talk_Start", false, false, null, null, false);
			}
			this.SeqState = EavesdropMark.ESeqState.Taking;
			this.NextSeqState = EavesdropMark.ESeqState.None;
		}

		// Token: 0x0603C69F RID: 247455 RVA: 0x00E7C240 File Offset: 0x00E7A440
		private void SequenceFinishEvent(string sequenceName)
		{
			if (!(sequenceName == "Eavesdrop_Close") && !(sequenceName == "Talk_Close"))
			{
				if (sequenceName == "Talk_Start")
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlaySequencePurely("Loop", false, false, null, null, false);
				}
				return;
			}
			if (sequenceName == "Eavesdrop_Close")
			{
				UUIItem normalItem = this.NormalItem;
				if (normalItem != null)
				{
					normalItem.SetUIActive(false);
				}
			}
			else if (sequenceName == "Talk_Close")
			{
				UUIItem takingItem = this.TakingItem;
				if (takingItem != null)
				{
					takingItem.SetUIActive(false);
				}
			}
			switch (this.NextSeqState)
			{
			case EavesdropMark.ESeqState.Normal:
			{
				UUIItem normalItem2 = this.NormalItem;
				if (normalItem2 != null)
				{
					normalItem2.SetUIActive(true);
				}
				this.PlayNormalSeqInternal();
				return;
			}
			case EavesdropMark.ESeqState.Taking:
			{
				UUIItem takingItem2 = this.TakingItem;
				if (takingItem2 != null)
				{
					takingItem2.SetUIActive(true);
				}
				this.PlayTakingSeqInternal();
				return;
			}
			case EavesdropMark.ESeqState.Found:
			{
				UUIItem foundItem = this.FoundItem;
				if (foundItem != null)
				{
					foundItem.SetUIActive(true);
				}
				this.PlayFoundSeqInternal();
				return;
			}
			case EavesdropMark.ESeqState.None:
				EventSystem.Instance.Emit<int>(EEventName.RemoveEavesdropMark, this.TrackingEntityId.Value);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603C6A0 RID: 247456 RVA: 0x00E7C360 File Offset: 0x00E7A560
		public void Initialize(UUIItem parent, float showDist)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_Eavesdrop", parent, false).Forget();
			this.ShowDist = showDist;
			this.SetActive(SneakController.Instance.IsSneaking);
			EventSystem.Instance.Add(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Add(EEventName.SneakEnd, new Action(this.OnSneakEnd));
		}

		// Token: 0x0603C6A1 RID: 247457 RVA: 0x00E7C3CE File Offset: 0x00E7A5CE
		private void OnSneakStart()
		{
			this.SetActive(true);
		}

		// Token: 0x0603C6A2 RID: 247458 RVA: 0x00E7C3D7 File Offset: 0x00E7A5D7
		private void OnSneakEnd()
		{
			this.SetActive(false);
		}

		// Token: 0x0603C6A3 RID: 247459 RVA: 0x00E7C3E0 File Offset: 0x00E7A5E0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Remove(EEventName.SneakEnd, new Action(this.OnSneakEnd));
		}

		// Token: 0x0401F798 RID: 128920
		private const float UPDATE_TOLERATION = 0.1f;

		// Token: 0x0401F799 RID: 128921
		private const float HEAD_OFFSET = 150f;

		// Token: 0x0401F79A RID: 128922
		private const string NORMAL_START = "Eavesdrop_Start";

		// Token: 0x0401F79B RID: 128923
		private const string NORMAL_END = "Eavesdrop_Close";

		// Token: 0x0401F79C RID: 128924
		private const string TAKING_START = "Talk_Start";

		// Token: 0x0401F79D RID: 128925
		private const string TAKING_LOOP = "Loop";

		// Token: 0x0401F79E RID: 128926
		private const string TAKING_END = "Talk_Close";

		// Token: 0x0401F79F RID: 128927
		private const string FOUND = "BeFound_Start";

		// Token: 0x0401F7A0 RID: 128928
		[StaticVariableRuleIgnore]
		private static readonly int NormalTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.常态"];

		// Token: 0x0401F7A1 RID: 128929
		[StaticVariableRuleIgnore]
		private static readonly int StartTakingTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.剧情中"];

		// Token: 0x0401F7A2 RID: 128930
		[StaticVariableRuleIgnore]
		private static readonly int EndTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.剧情结束"];

		// Token: 0x0401F7A3 RID: 128931
		[StaticVariableRuleIgnore]
		private static readonly FName HeadName = new FName("Bip001Head");

		// Token: 0x0401F7A4 RID: 128932
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x0401F7A5 RID: 128933
		private readonly int? TrackingEntityId;

		// Token: 0x0401F7A6 RID: 128934
		[Nullable(2)]
		private readonly BaseTagComponent TargetTagComp;

		// Token: 0x0401F7A7 RID: 128935
		[Nullable(2)]
		private USkeletalMeshComponent MeshComp;

		// Token: 0x0401F7A8 RID: 128936
		[Nullable(2)]
		private UUIItem NormalItem;

		// Token: 0x0401F7A9 RID: 128937
		[Nullable(2)]
		private UUIText DistText;

		// Token: 0x0401F7AA RID: 128938
		[Nullable(2)]
		private UUIItem TakingItem;

		// Token: 0x0401F7AB RID: 128939
		[Nullable(2)]
		private UUIItem FoundItem;

		// Token: 0x0401F7AC RID: 128940
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F7AD RID: 128941
		private readonly Rotator RootActorRotation = Rotator.Create();

		// Token: 0x0401F7AE RID: 128942
		private EavesdropMark.ESeqState SeqState = EavesdropMark.ESeqState.None;

		// Token: 0x0401F7AF RID: 128943
		private EavesdropMark.ESeqState NextSeqState = EavesdropMark.ESeqState.None;

		// Token: 0x0401F7B0 RID: 128944
		private float ShowDist = -1f;

		// Token: 0x0200BF93 RID: 49043
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04039CC4 RID: 236740
			NormalItem,
			// Token: 0x04039CC5 RID: 236741
			DistText,
			// Token: 0x04039CC6 RID: 236742
			TakingItem,
			// Token: 0x04039CC7 RID: 236743
			FoundItem
		}

		// Token: 0x0200BF94 RID: 49044
		[NullableContext(0)]
		private enum ESeqState
		{
			// Token: 0x04039CC9 RID: 236745
			Normal,
			// Token: 0x04039CCA RID: 236746
			Taking,
			// Token: 0x04039CCB RID: 236747
			Found,
			// Token: 0x04039CCC RID: 236748
			None
		}
	}
}
