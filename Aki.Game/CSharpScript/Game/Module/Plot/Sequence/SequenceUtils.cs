using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Character.Vehicle.Seq;
using AkiClient.Game.Aki.Sequence.Interface;
using AkiClient.Game.Aki.Sequence.Seq_BP;
using AkiClient.Game.Aki.Sequence.Seq_BP.BpSeqCustom;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FE4 RID: 16356
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceUtils : IStaticVariableResetter
	{
		// Token: 0x06029659 RID: 169561 RVA: 0x00BA805E File Offset: 0x00BA625E
		static SequenceUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceUtils.CreateStaticDefaultValue), new Action(SequenceUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0602965A RID: 169562 RVA: 0x00BA807D File Offset: 0x00BA627D
		public static ULevelSequence GetSelectedSequenceInEditor()
		{
			return null;
		}

		// Token: 0x0602965B RID: 169563 RVA: 0x00BA8080 File Offset: 0x00BA6280
		[NullableContext(1)]
		public static bool CheckIfUseAudioSeq(AActor actor)
		{
			IBPI_SeqAudio_C ibpi_SeqAudio_C = actor as IBPI_SeqAudio_C;
			SeqAudio_Seq_V2_C seqAudio_Seq_V2_C2;
			if (ibpi_SeqAudio_C != null)
			{
				SeqAudio_Seq_V2_C seqAudio_Seq_V2_C = null;
				ibpi_SeqAudio_C.GetSeqAudio(ref seqAudio_Seq_V2_C);
				seqAudio_Seq_V2_C2 = seqAudio_Seq_V2_C;
			}
			else
			{
				BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
				if (bp_BaseRole_Seq_V2_C != null)
				{
					seqAudio_Seq_V2_C2 = bp_BaseRole_Seq_V2_C.SeqAudio_Seq_V2;
				}
				else
				{
					BP_SeqNPC_C bp_SeqNPC_C = actor as BP_SeqNPC_C;
					if (bp_SeqNPC_C != null)
					{
						seqAudio_Seq_V2_C2 = bp_SeqNPC_C.SeqAudio_Seq_V2;
					}
					else
					{
						BP_SeqSkeletal_C bp_SeqSkeletal_C = actor as BP_SeqSkeletal_C;
						if (bp_SeqSkeletal_C == null)
						{
							return false;
						}
						seqAudio_Seq_V2_C2 = bp_SeqSkeletal_C.SeqAudio_Seq_V2;
					}
				}
			}
			return seqAudio_Seq_V2_C2 != null && seqAudio_Seq_V2_C2.UseAudioSeq;
		}

		// Token: 0x0602965C RID: 169564 RVA: 0x00BA80FC File Offset: 0x00BA62FC
		public static FName? GetSeqBindingTag(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			IBPI_SeqBindingActor_C ibpi_SeqBindingActor_C = actor as IBPI_SeqBindingActor_C;
			if (ibpi_SeqBindingActor_C != null)
			{
				FName fname = default(FName);
				ibpi_SeqBindingActor_C.GetSeqBindingTag(ref fname);
				if (!FNameUtil.IsNothing(fname))
				{
					return new FName?(fname);
				}
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				return new FName?(bp_BaseRole_Seq_V2_C.BindingTag);
			}
			BP_BaseVehicle_Seq_V2_C bp_BaseVehicle_Seq_V2_C = actor as BP_BaseVehicle_Seq_V2_C;
			if (bp_BaseVehicle_Seq_V2_C != null)
			{
				return new FName?(bp_BaseVehicle_Seq_V2_C.BindingTag);
			}
			return null;
		}

		// Token: 0x0602965D RID: 169565 RVA: 0x00BA8184 File Offset: 0x00BA6384
		public static USkeletalMeshComponent GetSeqBlendMesh(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			IBPI_SeqBlendActor_C ibpi_SeqBlendActor_C = actor as IBPI_SeqBlendActor_C;
			if (ibpi_SeqBlendActor_C != null)
			{
				USkeletalMeshComponent uskeletalMeshComponent = null;
				ibpi_SeqBlendActor_C.GetSeqBlendMesh(ref uskeletalMeshComponent);
				if (uskeletalMeshComponent != null)
				{
					return uskeletalMeshComponent;
				}
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				return bp_BaseRole_Seq_V2_C.SkeletalMeshComponent0;
			}
			return null;
		}

		// Token: 0x0602965E RID: 169566 RVA: 0x00BA81D0 File Offset: 0x00BA63D0
		public static bool BeginSeqSwitchPose(AActor actor, AActor from, AActor to, float switchTime)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			IBPI_SeqBlendActor_C ibpi_SeqBlendActor_C = actor as IBPI_SeqBlendActor_C;
			if (ibpi_SeqBlendActor_C != null)
			{
				ibpi_SeqBlendActor_C.BeginSeqSwitchPose(from, to, switchTime);
				return true;
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				bp_BaseRole_Seq_V2_C.BeginSwitchPose(from, to, switchTime, true);
				return true;
			}
			return false;
		}

		// Token: 0x0602965F RID: 169567 RVA: 0x00BA821C File Offset: 0x00BA641C
		public static bool EndSeqSwitchPose(AActor actor, AActor to)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			IBPI_SeqBlendActor_C ibpi_SeqBlendActor_C = actor as IBPI_SeqBlendActor_C;
			if (ibpi_SeqBlendActor_C != null)
			{
				ibpi_SeqBlendActor_C.EndSeqSwitchPose(to);
				return true;
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				bp_BaseRole_Seq_V2_C.EndSwitchPose(to, true);
				return true;
			}
			return false;
		}

		// Token: 0x06029660 RID: 169568 RVA: 0x00BA8264 File Offset: 0x00BA6464
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"TalkID",
			"TalkID_SP"
		})]
		public static ValueTuple<int, int>? GetSeqTalkId([Nullable(2)] AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			IBPI_SeqTalkActor_C ibpi_SeqTalkActor_C = actor as IBPI_SeqTalkActor_C;
			if (ibpi_SeqTalkActor_C != null)
			{
				int num = 0;
				int num2 = 0;
				ibpi_SeqTalkActor_C.GetSeqTalkId(ref num, ref num2);
				if (num > 0 || num2 > 0)
				{
					return new ValueTuple<int, int>?(new ValueTuple<int, int>(num, num2));
				}
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(bp_BaseRole_Seq_V2_C.TalkID, bp_BaseRole_Seq_V2_C.TalkID_SP));
			}
			BP_SeqNPC_C bp_SeqNPC_C = actor as BP_SeqNPC_C;
			if (bp_SeqNPC_C != null)
			{
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(bp_SeqNPC_C.TalkID, bp_SeqNPC_C.TalkID_SP));
			}
			BP_SeqSkeletal_C bp_SeqSkeletal_C = actor as BP_SeqSkeletal_C;
			if (bp_SeqSkeletal_C != null)
			{
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(bp_SeqSkeletal_C.TalkID, bp_SeqSkeletal_C.TalkID_SP));
			}
			BP_SeqCustom_C bp_SeqCustom_C = actor as BP_SeqCustom_C;
			if (bp_SeqCustom_C != null)
			{
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(bp_SeqCustom_C.TalkID, bp_SeqCustom_C.TalkID_SP));
			}
			BP_Mascot_C bp_Mascot_C = actor as BP_Mascot_C;
			if (bp_Mascot_C != null)
			{
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(bp_Mascot_C.TalkID, bp_Mascot_C.TalkID_SP));
			}
			return null;
		}

		// Token: 0x06029661 RID: 169569 RVA: 0x00BA8378 File Offset: 0x00BA6578
		public static UAnimInstance GetSeqMouthAnimInstance(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			IBPI_SeqTalkActor_C ibpi_SeqTalkActor_C = actor as IBPI_SeqTalkActor_C;
			if (ibpi_SeqTalkActor_C != null)
			{
				UAnimInstance uanimInstance = null;
				ibpi_SeqTalkActor_C.GetSeqMouthAnimInstance(ref uanimInstance);
				if (uanimInstance != null)
				{
					return uanimInstance;
				}
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				USkeletalMeshComponent skeletalMeshComponent = bp_BaseRole_Seq_V2_C.SkeletalMeshComponent0;
				if (skeletalMeshComponent == null)
				{
					return null;
				}
				return skeletalMeshComponent.GetLinkedAnimGraphInstanceByTag(SequenceDefine.ABP_Base_Name);
			}
			else
			{
				BP_SeqNPC_C bp_SeqNPC_C = actor as BP_SeqNPC_C;
				if (bp_SeqNPC_C != null)
				{
					USkeletalMeshComponent skel_Main = bp_SeqNPC_C.Skel_Main;
					if (skel_Main == null)
					{
						return null;
					}
					return skel_Main.GetAnimInstance();
				}
				else
				{
					BP_SeqSkeletal_C bp_SeqSkeletal_C = actor as BP_SeqSkeletal_C;
					if (bp_SeqSkeletal_C != null)
					{
						USkeletalMeshComponent skeletalMesh = bp_SeqSkeletal_C.SkeletalMesh;
						if (skeletalMesh == null)
						{
							return null;
						}
						return skeletalMesh.GetAnimInstance();
					}
					else
					{
						BP_SeqCustom_C bp_SeqCustom_C = actor as BP_SeqCustom_C;
						if (bp_SeqCustom_C != null)
						{
							USkeletalMeshComponent skeletalMesh2 = bp_SeqCustom_C.SkeletalMesh;
							if (skeletalMesh2 == null)
							{
								return null;
							}
							return skeletalMesh2.GetAnimInstance();
						}
						else
						{
							BP_Mascot_C bp_Mascot_C = actor as BP_Mascot_C;
							if (bp_Mascot_C == null)
							{
								return null;
							}
							USkeletalMeshComponent skeletalMesh3 = bp_Mascot_C.SkeletalMesh;
							if (skeletalMesh3 == null)
							{
								return null;
							}
							return skeletalMesh3.GetAnimInstance();
						}
					}
				}
			}
		}

		// Token: 0x06029662 RID: 169570 RVA: 0x00BA844C File Offset: 0x00BA664C
		public static bool ApplySeqCostumeState(AActor actor, int state)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			IBPI_SeqCostumeState_C ibpi_SeqCostumeState_C = actor as IBPI_SeqCostumeState_C;
			if (ibpi_SeqCostumeState_C != null)
			{
				ibpi_SeqCostumeState_C.ApplySeqCostumeState(state);
				return true;
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				bp_BaseRole_Seq_V2_C.ChangeHuluState(state);
				return true;
			}
			return false;
		}

		// Token: 0x06029663 RID: 169571 RVA: 0x00BA8494 File Offset: 0x00BA6694
		public static bool ClearSeqCostumeState(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			IBPI_SeqCostumeState_C ibpi_SeqCostumeState_C = actor as IBPI_SeqCostumeState_C;
			if (ibpi_SeqCostumeState_C != null)
			{
				ibpi_SeqCostumeState_C.ClearSeqCostumeState();
				return true;
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				bp_BaseRole_Seq_V2_C.CleanHuluState();
				return true;
			}
			return false;
		}

		// Token: 0x06029664 RID: 169572 RVA: 0x00BA84DC File Offset: 0x00BA66DC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static TSoftObjectPtr<USkeletalMesh> GetSeqMeshRef(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			IBPI_SeqRoleMesh_C ibpi_SeqRoleMesh_C = actor as IBPI_SeqRoleMesh_C;
			if (ibpi_SeqRoleMesh_C != null)
			{
				TSoftObjectPtr<USkeletalMesh> tsoftObjectPtr = new TSoftObjectPtr<USkeletalMesh>();
				ibpi_SeqRoleMesh_C.GetSeqMeshRef(ref tsoftObjectPtr);
				if (!StringUtils.IsEmpty(tsoftObjectPtr.ToAssetPathName()))
				{
					return tsoftObjectPtr;
				}
			}
			BP_BaseRole_Seq_V2_C bp_BaseRole_Seq_V2_C = actor as BP_BaseRole_Seq_V2_C;
			if (bp_BaseRole_Seq_V2_C != null)
			{
				return bp_BaseRole_Seq_V2_C.MeshRef;
			}
			return null;
		}

		// Token: 0x06029665 RID: 169573 RVA: 0x00BA8538 File Offset: 0x00BA6738
		[NullableContext(1)]
		public static void AsFrameTime(FFrameRate frameRate, float timeInSeconds, ref FFrameTime outFrameTime)
		{
			float num = timeInSeconds * (float)frameRate.Numerator / (float)frameRate.Denominator;
			int num2 = (int)Math.Floor((double)num);
			float num3 = num - (float)num2;
			if (num3 > 0f)
			{
				num3 = Math.Min(num3, 0.1f);
			}
			outFrameTime.FrameNumber.Value = num2;
			outFrameTime.SubFrame = num3;
		}

		// Token: 0x06029666 RID: 169574 RVA: 0x00BA858C File Offset: 0x00BA678C
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UMovieSceneTrack GetLevelSequenceTransformTrack(ULevelSequence sequence, FName tag)
		{
			if (!sequence.IsValid())
			{
				return null;
			}
			TArray<FMovieSceneObjectBindingID> tarray = sequence.FindBindingsByTag(tag);
			FSequencerBindingRuntimeProxy fsequencerBindingRuntimeProxy = null;
			for (int i = 0; i < tarray.Num(); i++)
			{
				FMovieSceneObjectBindingID fmovieSceneObjectBindingID = tarray.Get(i);
				fsequencerBindingRuntimeProxy = UKuroSequenceRuntimeFunctionLibrary.FindBindingById(sequence, fmovieSceneObjectBindingID.Guid);
				if (fsequencerBindingRuntimeProxy.BindingID.IsValid())
				{
					break;
				}
				fsequencerBindingRuntimeProxy = null;
			}
			if (fsequencerBindingRuntimeProxy == null)
			{
				return null;
			}
			TArray<UMovieSceneTrack> tarray2 = UKuroSequenceRuntimeFunctionLibrary.FindTracksByType(fsequencerBindingRuntimeProxy, UMovieScene3DTransformTrack.StaticClass());
			if (tarray2.Num() <= 0)
			{
				return null;
			}
			return tarray2.Get(0);
		}

		// Token: 0x06029667 RID: 169575 RVA: 0x00BA8617 File Offset: 0x00BA6817
		[NullableContext(1)]
		public static FTransformDouble GetLevelSequenceTransform(ULevelSequence sequence, UMovieSceneTrack track, float time)
		{
			if (SequenceUtils._frameTime == null)
			{
				SequenceUtils._frameTime = new FFrameTime();
			}
			SequenceUtils.AsFrameTime(sequence.MovieScene.TickResolution, time, ref SequenceUtils._frameTime);
			return UKismetMathLibrary.Conv_TransformToTransformDouble(UKuroSequenceRuntimeFunctionLibrary.GetFrameTransform(track, SequenceUtils._frameTime));
		}

		// Token: 0x06029668 RID: 169576 RVA: 0x00BA8656 File Offset: 0x00BA6856
		public static void CreateStaticDefaultValue()
		{
			SequenceUtils._frameTime = null;
		}

		// Token: 0x06029669 RID: 169577 RVA: 0x00BA865E File Offset: 0x00BA685E
		public static void ResetStaticDefaultValue()
		{
			SequenceUtils._frameTime = null;
		}

		// Token: 0x04016978 RID: 92536
		private const float MINI_SUB_FRAME_TIME = 0.1f;

		// Token: 0x04016979 RID: 92537
		private static FFrameTime _frameTime;
	}
}
