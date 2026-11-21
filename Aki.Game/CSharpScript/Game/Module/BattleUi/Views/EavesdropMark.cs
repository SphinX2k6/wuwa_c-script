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
	// Token: 0x02004CFD RID: 19709
	[NullableContext(1)]
	[Nullable(0)]
	public class EavesdropMark : UiPanelBase
	{
		// Token: 0x060315E7 RID: 202215 RVA: 0x00DCC094 File Offset: 0x00DCA294
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

		// Token: 0x060315E8 RID: 202216 RVA: 0x00DCC15C File Offset: 0x00DCA35C
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

		// Token: 0x060315E9 RID: 202217 RVA: 0x00DCC208 File Offset: 0x00DCA408
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

		// Token: 0x060315EA RID: 202218 RVA: 0x00DCC3A8 File Offset: 0x00DCA5A8
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

		// Token: 0x060315EB RID: 202219 RVA: 0x00DCC438 File Offset: 0x00DCA638
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

		// Token: 0x060315EC RID: 202220 RVA: 0x00DCC510 File Offset: 0x00DCA710
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

		// Token: 0x060315ED RID: 202221 RVA: 0x00DCC5E8 File Offset: 0x00DCA7E8
		private void UpdateLocation()
		{
			FVectorDouble inVec = this.MeshComp.D_GetSocketLocation(EavesdropMark.HeadName);
			inVec.Z += 150.0;
			FVector uirelativeLocation = UKismetMathLibrary.Conv_VectorDoubleToVector(inVec);
			this.RootItem.SetUIRelativeLocation(uirelativeLocation);
		}

		// Token: 0x060315EE RID: 202222 RVA: 0x00DCC62D File Offset: 0x00DCA82D
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

		// Token: 0x060315EF RID: 202223 RVA: 0x00DCC642 File Offset: 0x00DCA842
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

		// Token: 0x060315F0 RID: 202224 RVA: 0x00DCC657 File Offset: 0x00DCA857
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

		// Token: 0x060315F1 RID: 202225 RVA: 0x00DCC670 File Offset: 0x00DCA870
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

		// Token: 0x060315F2 RID: 202226 RVA: 0x00DCC6F0 File Offset: 0x00DCA8F0
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

		// Token: 0x060315F3 RID: 202227 RVA: 0x00DCC730 File Offset: 0x00DCA930
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

		// Token: 0x060315F4 RID: 202228 RVA: 0x00DCC770 File Offset: 0x00DCA970
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

		// Token: 0x060315F5 RID: 202229 RVA: 0x00DCC7E8 File Offset: 0x00DCA9E8
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

		// Token: 0x060315F6 RID: 202230 RVA: 0x00DCC834 File Offset: 0x00DCAA34
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

		// Token: 0x060315F7 RID: 202231 RVA: 0x00DCC880 File Offset: 0x00DCAA80
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

		// Token: 0x060315F8 RID: 202232 RVA: 0x00DCC8C0 File Offset: 0x00DCAAC0
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

		// Token: 0x060315F9 RID: 202233 RVA: 0x00DCC9E0 File Offset: 0x00DCABE0
		public void Initialize(UUIItem parent, float showDist)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_Eavesdrop", parent, false).Forget();
			this.ShowDist = showDist;
			this.SetActive(SneakController.Instance.IsSneaking);
			EventSystem.Instance.Add(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Add(EEventName.SneakEnd, new Action(this.OnSneakEnd));
		}

		// Token: 0x060315FA RID: 202234 RVA: 0x00DCCA4E File Offset: 0x00DCAC4E
		private void OnSneakStart()
		{
			this.SetActive(true);
		}

		// Token: 0x060315FB RID: 202235 RVA: 0x00DCCA57 File Offset: 0x00DCAC57
		private void OnSneakEnd()
		{
			this.SetActive(false);
		}

		// Token: 0x060315FC RID: 202236 RVA: 0x00DCCA60 File Offset: 0x00DCAC60
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.SneakStart, new Action(this.OnSneakStart));
			EventSystem.Instance.Remove(EEventName.SneakEnd, new Action(this.OnSneakEnd));
		}

		// Token: 0x0401A251 RID: 107089
		private const float UPDATE_TOLERATION = 0.1f;

		// Token: 0x0401A252 RID: 107090
		private const float HEAD_OFFSET = 150f;

		// Token: 0x0401A253 RID: 107091
		private const string NORMAL_START = "Eavesdrop_Start";

		// Token: 0x0401A254 RID: 107092
		private const string NORMAL_END = "Eavesdrop_Close";

		// Token: 0x0401A255 RID: 107093
		private const string TAKING_START = "Talk_Start";

		// Token: 0x0401A256 RID: 107094
		private const string TAKING_LOOP = "Loop";

		// Token: 0x0401A257 RID: 107095
		private const string TAKING_END = "Talk_Close";

		// Token: 0x0401A258 RID: 107096
		private const string FOUND = "BeFound_Start";

		// Token: 0x0401A259 RID: 107097
		[StaticVariableRuleIgnore]
		private static readonly int NormalTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.常态"];

		// Token: 0x0401A25A RID: 107098
		[StaticVariableRuleIgnore]
		private static readonly int StartTakingTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.剧情中"];

		// Token: 0x0401A25B RID: 107099
		[StaticVariableRuleIgnore]
		private static readonly int EndTag = GameplayTagDefine.EGameplayTagId["怪物.common.关卡.偷听玩法.剧情结束"];

		// Token: 0x0401A25C RID: 107100
		[StaticVariableRuleIgnore]
		private static readonly FName HeadName = new FName("Bip001Head");

		// Token: 0x0401A25D RID: 107101
		[Nullable(2)]
		private readonly AActor TrackingActor;

		// Token: 0x0401A25E RID: 107102
		private readonly int? TrackingEntityId;

		// Token: 0x0401A25F RID: 107103
		[Nullable(2)]
		private readonly BaseTagComponent TargetTagComp;

		// Token: 0x0401A260 RID: 107104
		[Nullable(2)]
		private USkeletalMeshComponent MeshComp;

		// Token: 0x0401A261 RID: 107105
		[Nullable(2)]
		private UUIItem NormalItem;

		// Token: 0x0401A262 RID: 107106
		[Nullable(2)]
		private UUIText DistText;

		// Token: 0x0401A263 RID: 107107
		[Nullable(2)]
		private UUIItem TakingItem;

		// Token: 0x0401A264 RID: 107108
		[Nullable(2)]
		private UUIItem FoundItem;

		// Token: 0x0401A265 RID: 107109
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A266 RID: 107110
		private readonly Rotator RootActorRotation = Rotator.Create();

		// Token: 0x0401A267 RID: 107111
		private EavesdropMark.ESeqState SeqState = EavesdropMark.ESeqState.None;

		// Token: 0x0401A268 RID: 107112
		private EavesdropMark.ESeqState NextSeqState = EavesdropMark.ESeqState.None;

		// Token: 0x0401A269 RID: 107113
		private float ShowDist = -1f;

		// Token: 0x0200A999 RID: 43417
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04034686 RID: 214662
			NormalItem,
			// Token: 0x04034687 RID: 214663
			DistText,
			// Token: 0x04034688 RID: 214664
			TakingItem,
			// Token: 0x04034689 RID: 214665
			FoundItem
		}

		// Token: 0x0200A99A RID: 43418
		[NullableContext(0)]
		private enum ESeqState
		{
			// Token: 0x0403468B RID: 214667
			Normal,
			// Token: 0x0403468C RID: 214668
			Taking,
			// Token: 0x0403468D RID: 214669
			Found,
			// Token: 0x0403468E RID: 214670
			None
		}
	}
}
